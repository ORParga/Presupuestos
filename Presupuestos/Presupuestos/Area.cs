using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
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

        protected int fontDimensionsSize;
        protected Font fontDimensions;
        protected int transDimensions;
        protected Color colorDimensions;
        protected Color colorBackDimensions;
        protected Brush brushDimensions;
        protected Brush brushBackDimensions;

        protected Rectangle ClientAreaScr = new Rectangle();

        public Rectangle getClientAreaScr (WorkArea workArea)
        {

            Punto WAO_Src = workArea.WorkAreaOriginSrc;
            ClientAreaScr.X = (int)(((double)clientAreaWrk.X * workArea.Scale) + WAO_Src.X);
            ClientAreaScr.Y = (int)(((double)clientAreaWrk.Y * workArea.Scale) + WAO_Src.Y);
            ClientAreaScr.Width = (int)(clientAreaWrk.Width * workArea.Scale);
            ClientAreaScr.Height = (int)(clientAreaWrk.Height * workArea.Scale);
            return ClientAreaScr;
        }
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

            fontDimensionsSize = 12;
            fontDimensions = new Font("Times New Roman", fontDimensionsSize);
            transDimensions = 170;
            colorDimensions = Color.FromArgb(transDimensions, Color.Red.R, Color.Red.G, Color.Red.B);
            colorBackDimensions = Color.FromArgb(transDimensions, Color.Pink.R, Color.Pink.G, Color.Pink.B);
            brushDimensions = new SolidBrush(colorDimensions);
            brushBackDimensions = new SolidBrush(colorBackDimensions);
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

            MouseP1Wrk.X = (workArea.ScreenOriginWrk.X + (MouseP1_X / workArea.Scale));
            MouseP1Wrk.Y = (workArea.ScreenOriginWrk.Y + (MouseP1_Y / workArea.Scale));
            MouseP2Wrk.X = (workArea.ScreenOriginWrk.X + (MouseP2_X / workArea.Scale));
            MouseP2Wrk.Y = (workArea.ScreenOriginWrk.Y + (MouseP2_Y / workArea.Scale));



            clientAreaWrk.X = (int)MouseP1Wrk.X;
            clientAreaWrk.Width = (int)MouseP2Wrk.X - (int)MouseP1Wrk.X;
            clientAreaWrk.Y = (int)MouseP1Wrk.Y;
            clientAreaWrk.Height = (int)MouseP2Wrk.Y - (int)MouseP1Wrk.Y;
        }
        public void Draw(WorkArea workArea, Graphics g)
        {
            Punto WAO_Src = workArea.WorkAreaOriginSrc;

            ClientAreaScr = getClientAreaScr( workArea);

            g.DrawRectangle(pen, ClientAreaScr);
        }
        public void DrawWidth(WorkArea workArea, Graphics g)
        {
            String Text =clientAreaWrk.Width.ToString("0.00");
            ClientAreaScr = getClientAreaScr(workArea);
            SizeF sizeText=g.MeasureString(Text, fontDimensions);
            Rectangle textRectangle = new Rectangle(ClientAreaScr.X, ClientAreaScr.Y - (int)sizeText.Height,  (int)sizeText.Width+10, (int)sizeText.Height);
            //g.FillRectangle(brushBackDimensions, textRectangle);
            g.DrawString(Text , fontDimensions, brushDimensions, textRectangle, StringFormat.GenericDefault);
        }
        public void DrawHeight(WorkArea workArea, Graphics g)
        {
            String Text = clientAreaWrk.Height.ToString("0.00");
            ClientAreaScr = getClientAreaScr(workArea);
            Rectangle textRectangle = new Rectangle(ClientAreaScr.X, ClientAreaScr.Y - fontDimensionsSize - 4, ClientAreaScr.Width, fontDimensionsSize + 4);
            //g.DrawString("" + clientAreaWrk.Height.ToString("0.00"), fontDimensions, brsh, textRectangle, StringFormat.GenericDefault);
            drawRotatedText(g, Text, ClientAreaScr.X, ClientAreaScr.Y);
        }
        public bool MouseOver (WorkArea workArea, int MouseX,int MouseY)
        {

            Punto MouseWrk = new Punto();
            MouseWrk.X = (int)(workArea.ScreenOriginWrk.X + (MouseX / workArea.Scale));
            MouseWrk.Y = (int)(workArea.ScreenOriginWrk.Y + (MouseY / workArea.Scale));

            if (MouseWrk.X > clientAreaWrk.X)
            {
                if(MouseWrk.Y > clientAreaWrk.Y)
                {
                    if(MouseWrk.X<clientAreaWrk.Right)
                    {
                        if (MouseWrk.Y < clientAreaWrk.Bottom)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
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
        /// <summary>
        /// DEvuelve el tamaño del texto
        /// </summary>
        /// <param name="g">objeto graphics donde se dibuja el texto</param>
        /// <param name="text">texto a dibujar</param>
        /// <param name="x">coordenada x donde se dibuja( en realidad se dibuja a la izquierda de esta coordenada
        /// teniendo en cuenta la altura del texto</param>
        /// <param name="y">lugar donde se dibuja el texto</param>
        /// <returns></returns>
        public SizeF drawRotatedText(Graphics g,string text,int x,int y)
        {
            //Bitmap bmp2 = new Bitmap(200, 200, g);
            Bitmap bmp2 = new Bitmap(200, 200, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics intGraphics=Graphics.FromImage(bmp2);
            intGraphics.Clear(Color.White);
            //intGraphics.Clear(colorBackDimensions);
            SizeF size = intGraphics.MeasureString(text, fontDimensions); // Get size of rotated text (bounding box)
            intGraphics.TranslateTransform(size.Height, 0); // Set rotation point
            intGraphics.RotateTransform(90); // Rotate text
            intGraphics.DrawString(text, fontDimensions, brushDimensions, new PointF(0, 0));
            intGraphics.ResetTransform(); // Only needed if you reuse the Graphics object for multiple calls to DrawString
            g.DrawImage(bmp2, x- size.Height, y, new RectangleF(0,0,size.Height ,size.Width),GraphicsUnit.Pixel);
            intGraphics.Dispose();

            return size;
        }
    }
}
