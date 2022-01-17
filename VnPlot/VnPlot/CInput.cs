using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VnPlot
{
    class CInput
    {
        public double Rho;  //Air density
        public double M;    //Aircraft mass
        public double A;    //Refernce area
        public double C;    //Refernce chord
        public double Vmax; //Maximum velocity
        public double CLmax;//Maximum CL
        public double CLmin;//Minimum CL
        public double Nmax; //Maximum load factor
        public double Nmin; //Minimum load factor
        public double Vgust_cr;     //Gust velocity for cruise speed (FAR23.341)

        public double Vgust_dv;     //Gust velocity for diving speed (FAR23.341)
        public double Vgust_maxint; //Gust velocity for speed of maximum gust intensiy (FAR23.341)
        public double CLa;          //Aircraft lift line curve slope (1/rad);
        public double Vcr;          //Cruise speed;

        public void Clear()
        {
            Rho = 0.0;
            M = 0.0;
            A = 0.0;
            C = 0.0;
            Vmax = 0.0;
            CLmax = 0.0;
            CLmin = 0.0;
            Nmax = 0.0;
            Nmin = 0.0;
            Vgust_cr = 0.0;

            Vgust_dv = 0.0;
            Vgust_maxint = 0.0;
            CLa = 0.0;
            Vcr = 0.0;
        }
    }
}
