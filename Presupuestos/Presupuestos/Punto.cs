using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presupuestos
{
    public class Punto
    {
        public double X;
        public double Y;
        public Punto()
        {
            X = 0;
            Y = 0;
        }
        public Punto(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public override string ToString()
        {
            return "X=" + X.ToString("0.00") + " Y=" + Y.ToString("0.00");
        }
        public  string ToString(string format)
        {
            return "X=" + X.ToString(format) + " Y=" + Y.ToString(format);
        }
    }
}
