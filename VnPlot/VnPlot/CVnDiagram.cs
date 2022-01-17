using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace VnPlot
{
    class CVnDiagram
    {
        const double g = 9.8;                   //重力加速度
        const double rhosl = 1.225;             //海平面大气密度
        const double Nit = 10;                  //曲线区间数
        CInput input = new CInput();
        ArrayList m_DataU = new ArrayList();     //存储机动过载点上半部；
        ArrayList m_DataL = new ArrayList();     //存储机动过载点下半部；
        ArrayList m_DataGust = new ArrayList();  //存储阵风过载边界点；
        public CVnDiagram(CInput inp)
        {
            input = inp;
            //修正速度为等效速度：
            double sig;
            sig = Math.Sqrt(input.Rho / rhosl);
            input.Vcr = sig * input.Vcr;
            input.Vmax = sig * input.Vmax;
        }

        void ClearArrays()
        {
            m_DataU.Clear();
            m_DataL.Clear();
            m_DataGust.Clear();
        }

        /// <summary>
        /// 返回机动过载包线：
        /// </summary>
        /// <returns></returns>
        public ArrayList GetManuverDiagram()
        {
            ArrayList re = new ArrayList();
            int i, ind;
            CPoint pt = null;
            //曲线上半部：
            re.AddRange(m_DataU);
            //曲线下半部，点是反过来的：
            for (i = 0; i < m_DataL.Count; i++)
            {
                ind = m_DataL.Count - i - 1;
                pt = (CPoint) m_DataL[ind];
                re.Add(pt);
            }
            //形成曲线闭环：
            pt = (CPoint)m_DataU[0];
            re.Add(pt);
            return re;
        }

        /// <summary>
        /// 返回阵风过载包线：
        /// </summary>
        /// <returns></returns>
        public ArrayList GetGustDiagram()
        {
            return m_DataGust;
        }

        double GetRho(double alt)
        {
            double rho = 0.0;
            return rho;
        }

        double GetVs(double W, double rho, double clmax)
        {
            double Vs = Math.Sqrt(2 * W / (rho * input.A * clmax));
            return Vs;
        }

        /// <summary>
        /// 计算过载系数
        /// </summary>
        /// <param name="v">速度</param>
        /// <param name="rho">大气密度</param>
        /// <param name="A">参考翼面积</param>
        /// <param name="clmax">最大升力系数</param>
        /// <param name="W">全机重量</param>
        /// <returns></returns>
        double GetN(double v, double rho, double A, double clmax, double W)
        {
            double N;
            N = v * v * rho * A * clmax / (2.0 * W);
            return N;
        }

        ArrayList GetNCLmax_P(double vs, double va, double rho, double W, double A, double clmax, bool positive)
        {
            ArrayList data = new ArrayList();
            CPoint pt = null;
            double coe;
            double v, dv, n, v0, n0;
            if (positive)
                coe = 1.0;
            else
                coe = -1.0;
            int i;
            dv = (va - vs) / Nit;
            //曲线起始点：
            v0 = vs;     //起始速度是失速速度；
            n0 = coe * GetN(v0, rho, A, clmax, W);   //起始过载系数；
            pt = new CPoint(v0, n0);
            data.Add(pt);
            //曲线后续点：
            for (i = 1; i < Nit; i++)
            {
                v = v0 + i * dv;
                n = coe * GetN(v, rho, input.A, clmax, W);
                pt = new CPoint(v, n);
                data.Add(pt);
            }
            //曲线终点：
            v = va;
            n = coe * GetN(v, rho, input.A, clmax, W);
            pt = new CPoint(v, n);
            data.Add(pt);
            return data;
        }

        /// <summary>
        /// 计算机动过载边界：
        /// </summary>
        void ComputeManeuverDiagram()
        {
            ArrayList datapos = null;
            ArrayList dataneg = null;
            CPoint pt;
            double W, rho;
            W = input.M * g;
            rho = input.Rho;
            //------------------------------------
            // 一、计算机动曲线边界上半部：
            //------------------------------------
            //1. Compute Vs: 
            double Vs = GetVs(W, rho, input.CLmax);
            pt = new CPoint(Vs, 0);
            m_DataU.Add(pt);
            //2. Compute Va: 
            double Va = Math.Sqrt(input.Nmax) * Vs;
            //3. Compute Nmax~Va curve under CLmax: 
            datapos = GetNCLmax_P(Vs, Va, rho, W, input.A, input.CLmax, true);
            m_DataU.AddRange(datapos);
            //4. Compute (Vd, Nmax): 
            pt = new CPoint(input.Vmax, input.Nmax);
            m_DataU.Add(pt);
            //5. Compute (Vd, 0): 
            pt = new CPoint(input.Vmax, 0);
            m_DataU.Add(pt);
            //------------------------------------
            // 二、计算机动曲线边界下半部：
            //------------------------------------
            //1. Compute Vsneg: 
            double Vsneg = GetVs(W, rho, input.CLmin);
            pt = new CPoint(Vsneg, 0);
            m_DataL.Add(pt);
            //2. Compute Vaneg: 
            double Vaneg = Math.Sqrt(input.Nmin) * Vsneg;
            //3. Compute Nmin~Vaneg curve under CLmin: 
            dataneg = GetNCLmax_P(Vsneg, Vaneg, rho, W, input.A, input.CLmin, false);
            m_DataL.AddRange(dataneg);
            //4. Compute (Vd, Nmin): 
            pt = new CPoint(input.Vmax, -input.Nmin);
            m_DataL.Add(pt);
            //5. Compute (Vd, 0): 
            pt = new CPoint(input.Vmax, 0);
            m_DataL.Add(pt);
        }

        /// <summary>
        /// 计算Ngust
        /// </summary>
        /// <param name="m">飞机质量（kg）</param>
        /// <param name="rho">大气密度</param>
        /// <param name="C">参考弦长</param>
        /// <param name="cla">全机升力线斜率</param>
        /// <param name="A">参考翼面积</param>
        /// <param name="Ve">等效飞行速度</param>
        /// <param name="Vgust">阵风速度</param>
        /// <returns></returns>
        double GetNgust(double m, double rho, double C, double cla, double A, double Ve, double Vgust)
        {
            double mu ,kg, n;
            //1. 求解mu:
            mu = 2.0 * m / (rho * C * cla * A);
            //2. 求解Kg（阵风减缓因子）：
            kg = 0.88 * mu / (5.3 + mu);
            //3. 求解n：
            n = 1.0 + (kg * Vgust * Ve * cla * rho * A) / (2 * m * g);
            return n;
        }

        /// <summary>
        /// 求解Vb，最大阵风设计速度
        /// </summary>
        /// <param name="m">飞机质量（kg）</param>
        /// <param name="rho">大气密度</param>
        /// <param name="C">参考弦长</param>
        /// <param name="cla">全机升力线斜率</param>
        /// <param name="A">参考翼面积</param>
        /// <param name="Vs">失速速度</param>
        /// <param name="Vc">巡航速度</param>
        /// <param name="Vgustmaxit">最大阵风设计速度下（Vb）的最大阵风速度 [FAR23.341]</param>
        /// <returns></returns>
        double GetVb(double m, double rho, double C, double cla, double A, double Vs, double Vc, double Vgustmaxit)
        {
            double mu, kg, Vb;
            //1. 求解mu:
            mu = 2.0 * m / (rho * C * cla * A);
            //2. 求解Kg（阵风减缓因子）：
            kg = 0.88 * mu / (5.3 + mu);
            //3. 求解Vb：
            double tmp;
            tmp = kg * Vgustmaxit * Vc * cla / (16 * m * g);
            Vb = Vs * Math.Pow((1.0 + tmp), 0.5);
            return Vb;
        }

        /// <summary>
        /// 计算阵风过载边界
        /// </summary>
        void ComputeGustDiagram()
        {
            double Vb, ngust;
            CPoint pt = null;
            double W, rho;
            W = input.M * g;
            rho = input.Rho;
            double vs = GetVs(W, rho, input.CLmax);
            //------------------------------------
            //曲线上半部分：
            //1. 第0个点在n=1处：
            pt = new CPoint(0, 1.0);
            m_DataGust.Add(pt);
            //2. 第1个点（最大阵风设计速度，曲线上半部）：
            Vb = GetVb(input.M, rho, input.C, input.CLa, input.A, vs, input.Vcr, input.Vgust_maxint);
            ngust = GetNgust(input.M, rho, input.C, input.CLa, input.A, Vb, input.Vgust_maxint);
            pt = new CPoint(Vb, ngust);
            m_DataGust.Add(pt);
            //3. 第2个点（巡航速度，曲线上半部）：
            ngust = GetNgust(input.M, rho, input.C, input.CLa, input.A, input.Vcr, input.Vgust_cr);
            pt = new CPoint(input.Vcr, ngust);
            m_DataGust.Add(pt);
            //4. 第3个点（俯冲速度（最大速度），曲线上半部）
            ngust = GetNgust(input.M, rho, input.C, input.CLa, input.A, input.Vmax, input.Vgust_dv);
            pt = new CPoint(input.Vmax, ngust);
            m_DataGust.Add(pt);
            //------------------------------------
            //曲线下半部分：
            CPoint ptt = null;
            int i;
            double py;
            for(i=3;i>=0;i--)
            {
                pt = (CPoint)m_DataGust[i];
                py = 2.0 - pt.y;
                ptt = new CPoint(pt.x, py);
                m_DataGust.Add(ptt);
            }
        }

        string ComposeDataString()
        {
            string lines = "";
            string str  = "";
            string rtn = "\r\n";
            string fmt = "0.0000";
            int i, np;
            CPoint pt =null;
            ArrayList mdata = null;
            //--------------------
            // 创建字符串：
            //--------------------
            //0. 表头：
            str = "Manuever boundary V\tManuever boundary n\tGust boundary V\tGust boundary n\t" + rtn;
            lines = lines + str;
            str = " \t \t \t \t" + rtn;
            lines = lines + str;
            str = "Vm\tNm\tVg\tNg\t" + rtn;
            lines = lines + str;
            //1. 首先输出机动边界：
            if (m_DataL.Count != m_DataU.Count) throw new Exception("Inconsistant manuever boundary array size! ");
            mdata = GetManuverDiagram();
            np = mdata.Count;
            for (i=0;i< np; i++)
            {
                //机动边界：
                pt = (CPoint)mdata[i];
                str = pt.x.ToString(fmt) + "\t" + pt.y.ToString(fmt) + "\t";
                lines = lines + str;
                //阵风边界：
                if (i< m_DataGust.Count)
                {
                    pt = (CPoint)m_DataGust[i];
                    str = pt.x.ToString(fmt) + "\t" + pt.y.ToString(fmt) + "\r\n";
                    lines = lines + str;
                }
                else
                {
                    lines = lines + "\r\n";
                }
            }
            return lines;
        }

        public string Compute()
        {
            string re = "";
            try
            {
                ClearArrays();
                ComputeManeuverDiagram();
                ComputeGustDiagram();
                re = ComposeDataString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                re = "";
            }
            return re;
        }
    }
}
