using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presupuestos
{
    class Box
    {
        protected double Bottom_prv = 0;
        protected double Up_prv = 0;
        protected double Left_prv = 0;
        protected double Right_prv = 0;
        public double Bottom { get { return Bottom_prv; } }
        public double Up { get { return Up_prv; } }
        public double Left { get { return Left_prv; } }
        public double Right { get { return Right_prv; } }
        public double Width { get { return Right_prv - Left_prv; } }
        public double Height { get { return Bottom_prv - Up_prv; } }
        protected System.Drawing.Rectangle rectangle_prv=new System.Drawing.Rectangle();
        public System.Drawing.Rectangle Rectangle
        {
            get
            {
                rectangle_prv.X = (int)Left_prv;
                rectangle_prv.Y = (int)Up_prv;
                rectangle_prv.Width = (int)Right_prv - (int)Left_prv;
                rectangle_prv.Height = (int)Bottom_prv - (int)Up_prv;

                return rectangle_prv;
            }
            set
            {
                set(value.X, value.Y, value.Right, value.Bottom);
            }
        }
        public Box()
        {

        }
        /// <summary>
        /// Crea un objeto Box que guarda el rectangulo definido por dor puntos cualesquiera
        /// </summary>
        /// <param name="corner">Un vertice del rectangulo</param>
        /// <param name="oppositeCorner">vertice opuesto del rectangulo</param>
        public Box(Punto corner, Punto oppositeCorner)
        {
            set(corner, oppositeCorner);
        }
        public void set(Punto corner, Punto oppositeCorner)
        {
            set(corner.X, corner.Y, oppositeCorner.X, oppositeCorner.Y);

        }
        public void set(ControlPoint corner,ControlPoint oppositeCorner)
        {
            set(corner.X, corner.Y, oppositeCorner.X, oppositeCorner.Y);
        }
        public void set(double X1, double Y1, double X2, double Y2)
        {

            if (X1 < X2)
            {
                Left_prv = X1;
                Right_prv = X2;
            }
            else
            {
                Left_prv = X2;
                Right_prv = X1;
            }
            if (Y1 < Y2)
            {
                Up_prv = Y1;
                Bottom_prv = Y2;
            }
            else
            {
                Up_prv = Y2;
                Bottom_prv = Y1;
            }
        }
        public bool IsPointInside (int X,int Y )
        {
            if (X < Left) return false;
            if (X > Right) return false;
            if (Y < Up) return false;
            if (Y > Bottom) return false;
            return true;

        }
        public bool IsPointInside (Punto punto)
        {

            if (punto.X < Left) return false;
            if (punto.X > Right) return false;
            if (punto.Y < Up) return false;
            if (punto.Y > Bottom) return false;
            return true;
        }
        public bool IsBoxInside (Box insideBox)
        {
            foreach(Punto punto in insideBox.puntos())
            {
                if (!IsPointInside(punto)) return false;
            }
            return true;
        }
        public List<Punto> puntos()
        {
            List<Punto> returnValue = new List<Punto>();
                returnValue.Add(new Punto(Left_prv, Up_prv));
                returnValue.Add(new Punto(Right_prv, Up_prv));
                returnValue.Add(new Punto(Right_prv, Bottom_prv));
                returnValue.Add(new Punto(Left_prv, Bottom_prv));
            return returnValue;
        }
        public override string ToString()
        {
            return "(" + Right_prv.ToString("0") + "." + Up_prv.ToString("0") + ")" + "(" + Left_prv.ToString("0") + "." + Bottom_prv.ToString("0") + ")";
        }
        public string ToString(string format)
        {
            return "(" + Left_prv.ToString(format) + "." + Up_prv.ToString(format) + ")" + "(" + Right_prv.ToString(format) + "." + Bottom_prv.ToString(format) + ")";
        }
    }
}
