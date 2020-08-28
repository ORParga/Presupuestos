using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presupuestos
{
    class Punto
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
            return "X=" + X + " Y=" + Y;
        }
    }
}
