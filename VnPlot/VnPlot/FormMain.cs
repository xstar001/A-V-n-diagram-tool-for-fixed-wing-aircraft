using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;

namespace VnPlot
{
    public partial class FormMain : Form
    {
        string m_ResLines = "";
        char m_Sep = ',';
        CInput m_In = new CInput();
        CVnDiagram m_Vnd = null;
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        void EnableControls(bool enable)
        {
            button_ExportOrg.Enabled = enable;
            button_Copy.Enabled = enable;
            //button_SaveInput.Enabled = enable;
            //button_LoadInput.Enabled = enable;
        }

        private void button_Compute_Click(object sender, EventArgs e)
        {
            //1. Read input first: 
            try
            {
                ReadInput();
                m_Vnd = new CVnDiagram(m_In);
                m_ResLines = m_Vnd.Compute();
                if (m_ResLines.Length > 0) textBox_Output.Text = m_ResLines;
                DrawVnDiagram();
                EnableControls(true);
            }
            catch (Exception ex)
            {
                EnableControls(false);
                textBox_Output.Text = "";
                chart_Vn.Series.Clear();
                MessageBox.Show(ex.Message);
            }
        }

        void ReadInput()
        {
            m_In.A = Convert.ToDouble(textBox_in_Area.Text);
            m_In.Rho = Convert.ToDouble(textBox_in_Rho.Text);
            m_In.C = Convert.ToDouble(textBox_in_Chord.Text);
            m_In.CLmax = Convert.ToDouble(textBox_in_CLMax.Text);
            m_In.CLmin = Convert.ToDouble(textBox_in_CLmin.Text);
            m_In.Nmax = Convert.ToDouble(textBox_in_NMax.Text);
            m_In.Nmin = Convert.ToDouble(textBox_in_NMin.Text);
            m_In.Vmax = Convert.ToDouble(textBox_in_Vmax.Text);
            m_In.M = Convert.ToDouble(textBox_in_M.Text);
            m_In.Vgust_cr = Convert.ToDouble(textBox_in_VgCr.Text);

            m_In.Vgust_dv = Convert.ToDouble(textBox_in_VgDv.Text);
            m_In.Vgust_maxint = Convert.ToDouble(textBox_in_VgMaxInt.Text);
            m_In.CLa = Convert.ToDouble(textBox_in_Cla.Text);
            m_In.Vcr = Convert.ToDouble(textBox_in_Vcr.Text);
            ValidateInput();
        }

        void SetInput()
        {
            string fmt = "0.0000";
            textBox_in_Area.Text = m_In.A.ToString(fmt);
            textBox_in_Chord.Text = m_In.C.ToString(fmt);
            textBox_in_Cla.Text = m_In.CLa.ToString(fmt);
            textBox_in_CLMax.Text = m_In.CLmax.ToString(fmt);
            textBox_in_CLmin.Text = m_In.CLmin.ToString(fmt);
            textBox_in_M.Text = m_In.M.ToString(fmt);
            textBox_in_NMax.Text = m_In.Nmax.ToString(fmt);
            textBox_in_NMin.Text = m_In.Nmin.ToString(fmt);
            textBox_in_Rho.Text = m_In.Rho.ToString(fmt);
            textBox_in_Vcr.Text = m_In.Vcr.ToString(fmt);

            textBox_in_VgCr.Text = m_In.Vgust_cr.ToString(fmt);
            textBox_in_VgDv.Text = m_In.Vgust_dv.ToString(fmt);
            textBox_in_VgMaxInt.Text = m_In.Vgust_maxint.ToString(fmt);
            textBox_in_Vmax.Text = m_In.Vmax.ToString(fmt);
        }

        void ValidateInput()
        {
            if (m_In.Nmin <= 0) throw new Exception("Nmin shall be greater than 0.0! Check your input. ");
            if (m_In.Nmax <= 0) throw new Exception("Nmax shall be greater than 0.0! Check your input. ");
            if (m_In.CLmax <= 0) throw new Exception("CLmax shall be greater than 0.0! Check your input. ");
            if (m_In.CLmin <= 0) throw new Exception("CLmin shall be greater than 0.0! Check your input. ");
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Copy_Click(object sender, EventArgs e)
        {
            if (textBox_Output.Text.Count() == 0) return;
            if(tabControl_Output.SelectedIndex==0)
            {
                Clipboard.SetText(textBox_Output.Text);
            }
            if (tabControl_Output.SelectedIndex == 1)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    chart_Vn.SaveImage(ms, ChartImageFormat.Bmp);
                    Bitmap m = new Bitmap(ms);
                    //复制到粘贴板
                    Clipboard.SetImage(m);
                }
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (m_ResLines.Length == 0 || textBox_Output.Text.Length == 0) return;
            string fname;
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            fname = ofd.FileName;
            try
            {
                StreamWriter ofs = new StreamWriter(fname);
                ofs.WriteLine(m_ResLines);
                ofs.Flush();
                ofs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void DrawVnDiagram()
        {
            if (m_Vnd == null) throw new Exception("DrawVnDiagram() error: m_Vnd==null! ");
            ArrayList mdata = null;
            ArrayList gdata = null;
            Series Sm = null;
            Series Sg = null;
            mdata = m_Vnd.GetManuverDiagram();
            if (mdata.Count == 0) throw new Exception("DrawVnDiagram() error: Empty maneuver V-n diagram array! ");
            gdata = m_Vnd.GetGustDiagram();
            if (gdata.Count == 0) throw new Exception("DrawVnDiagram() error: Empty gust V-n diagram array! ");
            //-----------------------------------------
            // 开始绘图：
            chart_Vn.Enabled = true;
            chart_Vn.ChartAreas[0].Position.Auto=false;
            chart_Vn.ChartAreas[0].Position.Height = 82;
            chart_Vn.ChartAreas[0].Position.Width = 95;
            if (chart_Vn.Series.Count != 0)
            {
                chart_Vn.Series.Clear();
            }
            Sm = chart_Vn.Series.Add("Maneuver loads");
            Sg = chart_Vn.Series.Add("Gust loads");
            Sm.ChartType = SeriesChartType.Line;
            Sm.Color = Color.Black;
            Sm.BorderWidth = 3;
            Sm.Points.Clear();
            Sg.ChartType = SeriesChartType.Line;
            Sg.Color = Color.Blue;
            Sg.BorderDashStyle = ChartDashStyle.Dash;
            Sg.Points.Clear();
            int i;
            CPoint pt = null;
            for (i = 0; i < mdata.Count; i++)
            {
                pt = (CPoint)mdata[i];
                Sm.Points.AddXY(pt.x, pt.y);
            }
            for (i = 0; i < gdata.Count; i++)
            {
                pt = (CPoint)gdata[i];
                Sg.Points.AddXY(pt.x, pt.y);
            }
            //设置X轴：
            chart_Vn.ChartAreas[0].AxisX.Title = "V [EAS] (m/s)";
            chart_Vn.ChartAreas[0].AxisX.RoundAxisValues();
            chart_Vn.ChartAreas[0].AxisX.Minimum = 0;
            chart_Vn.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 16, FontStyle.Regular);
            chart_Vn.ChartAreas[0].AxisY.Title = "n";
            chart_Vn.ChartAreas[0].AxisX.LabelStyle.Font= new System.Drawing.Font("Times New Roman", 12, FontStyle.Regular);
            //设置Y轴：
            chart_Vn.ChartAreas[0].AxisY.RoundAxisValues();
            chart_Vn.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 16, FontStyle.Regular);
            chart_Vn.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 12, FontStyle.Regular);
            //设置图例：
            Legend lgd = new Legend();
            lgd.Font = new System.Drawing.Font("Times New Roman", 16, FontStyle.Regular);
            lgd.Docking = Docking.Bottom;
            chart_Vn.Legends.Add(lgd);

        }

        private void label_EMail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:julius_hu@hotmail.com");
        }

        private void button_SaveInput_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            StreamWriter ofs = new StreamWriter(sfd.FileName);
            try
            {
                ReadInput();
                string fmt = "0.0000";
                string line = "";
                line =
                    m_In.Rho.ToString(fmt) + m_Sep +
                    m_In.M.ToString(fmt) + m_Sep +
                    m_In.A.ToString(fmt) + m_Sep +
                    m_In.C.ToString(fmt) + m_Sep +
                    m_In.Vmax.ToString(fmt) + m_Sep +
                    m_In.CLmax.ToString(fmt) + m_Sep +
                    m_In.CLmin.ToString(fmt) + m_Sep +
                    m_In.Nmax.ToString(fmt) + m_Sep +
                    m_In.Nmin.ToString(fmt) + m_Sep +
                    m_In.Vcr.ToString(fmt) + m_Sep +
                    m_In.Vgust_cr.ToString(fmt) + m_Sep +
                    m_In.Vgust_dv.ToString(fmt) + m_Sep +
                    m_In.Vgust_maxint.ToString(fmt) + m_Sep +
                    m_In.CLa.ToString(fmt);
                //写入数据：
                ofs.WriteLine(line);
                ofs.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ofs.Close();
        }

        private void button_LoadInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK) return;
            StreamReader ifs = new StreamReader(ofd.FileName);
            try
            {
                string line = "";
                string[] elements = null;
                line = ifs.ReadLine();
                if (line.Length == 0) throw new Exception("Empty file! ");
                elements = line.Split(m_Sep);
                if (elements.Length != 14)
                    throw new Exception("Element count error. Element count shall be 14 and elements shall be separted by " + m_Sep +
                                        "Check your inputs. ");
                //更新数据：
                m_In.Rho = Convert.ToDouble(elements[0]);
                m_In.M = Convert.ToDouble(elements[1]);
                m_In.A = Convert.ToDouble(elements[2]);
                m_In.C = Convert.ToDouble(elements[3]);
                m_In.Vmax = Convert.ToDouble(elements[4]);
                m_In.CLmax = Convert.ToDouble(elements[5]);
                m_In.CLmin = Convert.ToDouble(elements[6]);
                m_In.Nmax = Convert.ToDouble(elements[7]);
                m_In.Nmin = Convert.ToDouble(elements[8]);
                m_In.Vcr = Convert.ToDouble(elements[9]);
                m_In.Vgust_cr = Convert.ToDouble(elements[10]);
                m_In.Vgust_dv = Convert.ToDouble(elements[11]);
                m_In.Vgust_maxint = Convert.ToDouble(elements[12]);
                m_In.CLa = Convert.ToDouble(elements[13]);
                //更新数据显示：
                SetInput();
                chart_Vn.Series.Clear();
                textBox_Output.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ifs.Close();
        }
    }
}
