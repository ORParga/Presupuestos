using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Presupuestos
{
    class Line
    {
        int p1 = 0;
        int p2 = 0;
    }
    class Area : ICloneable
    {
        public Rectangle clientAreaWrk = new Rectangle();
        protected List<Point> pointList = new List<Point>();
        protected List<Line> lineList = new List<Line>();
        protected Color debugColor_prv = Color.Blue;
        public Color debugColor { get { return debugColor_prv; } set { penDeBug = new Pen(value, lineWidth); debugColor_prv = value; } }
        protected Pen penDefault;
        protected Pen penDeBug;
        protected Pen pen;//Defined in constructor;
        protected Brush brsh = new SolidBrush(Color.Red);
        protected Font font = new Font("Times New Roman", 26);

        public Rectangle rectangleSrc=new Rectangle();

        float lineWidth = 1;

        public Area()
        {
            constructor();
        }
        public Area (Color DebugColor)
        {
            debugColor_prv = DebugColor;
            constructor();
        }
        protected void constructor()
        {
            penDefault = new Pen(Color.Black, lineWidth);
            penDeBug = new Pen(debugColor_prv, lineWidth);
            pen = penDefault;
        }
        public bool IsMouseOver()
        {
            return false;
        }
        public void Resize(int MouseOffsetX,int MouseOffsetY)
        {

        }
        /// <summary>
        /// Utilizada para crear un rectángulo arrastrando el mouse sobre el area de trabajo
        /// </summary>
        /// <param name="workArea">Objeto de la clase WorkArea que representa el area de Trabajo donde se está dibujando el rectángulo</param>
        /// <param name="MouseP1_X">Coordenada X del punto donde se empieza a arrastrar el mouse, en coordenadas de pantalla. (MouseEvents e)</param>
        /// <param name="MouseP1_Y">Coordenada Y del punto donde se empieza a arrastrar el mouse, en coordenadas de pantalla. (MouseEvents e)</param>
        /// <param name="MouseP2_X">Coordenada X del último punto el mouse ( o su punto actualizado durante el Drag) , en coordenadas de pantalla. (MouseEvents e)</param>
        /// <param name="MouseP2_Y">Coordenada Y del último punto el mouse ( o su punto actualizado durante el Drag) , en coordenadas de pantalla. (MouseEvents e)</param>
        public void CreatingWithMouse(WorkArea workArea,double MouseP1_X,double MouseP1_Y, double MouseP2_X, double MouseP2_Y)
        {
            double comodin;
            Punto MouseP1Wrk = new Punto();
            Punto MouseP2Wrk = new Punto();

            if (MouseP1_X > MouseP2_X)
            {
                comodin = MouseP1_X;
                MouseP1_X = MouseP2_X;
                MouseP2_X = comodin;
            }
            if (MouseP1_Y > MouseP2_Y)
            {
                comodin = MouseP1_Y;
                MouseP1_Y = MouseP2_Y;
                MouseP2_Y = comodin;
            }

            MouseP1Wrk.X = (int)(workArea.WorkAreaOriginSrc.X + (MouseP1_X * workArea.Scale));
            MouseP1Wrk.Y = (int)(workArea.WorkAreaOriginSrc.Y + (MouseP1_Y * workArea.Scale));
            MouseP2Wrk.X = (int)(workArea.WorkAreaOriginSrc.X + (MouseP2_X * workArea.Scale));
            MouseP2Wrk.Y = (int)(workArea.WorkAreaOriginSrc.Y + (MouseP2_Y * workArea.Scale));



            clientAreaWrk.X = (int)MouseP1Wrk.X;
            clientAreaWrk.Width = (int)MouseP2Wrk.X - (int)MouseP1Wrk.X;
            clientAreaWrk.Y = (int)MouseP1Wrk.Y;
            clientAreaWrk.Height = (int)MouseP2Wrk.Y - (int)MouseP1Wrk.Y;
        }
        public void Draw(WorkArea workArea, Graphics g)
        {
            Punto WAO_Src = workArea.WorkAreaOriginSrc;
            rectangleSrc.X = (int)(((double)clientAreaWrk.X* workArea.Scale) + WAO_Src.X );
            rectangleSrc.Y = (int)(((double)clientAreaWrk.Y* workArea.Scale) + WAO_Src.Y );
            rectangleSrc.Width = (int)(clientAreaWrk.Width * workArea.Scale);
            rectangleSrc.Height = (int)(clientAreaWrk.Height * workArea.Scale);

            g.DrawRectangle(pen, rectangleSrc);
        }
        public void Draw(WorkArea workArea, Graphics g,bool Debugging)
        {
            if (Debugging) pen = penDeBug;
            else pen = penDefault;
            Draw(workArea, g);
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
