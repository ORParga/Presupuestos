using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presupuestos
{
    class WorkArea
    {
        public double Scale=1;
        double ScaleSpeed = 0.0005;
        private Punto WorkAreaOriginSrc_prv = new Punto(0, 0);
        public Punto WorkAreaOriginSrc { 
            get
            {
                WorkAreaOriginSrc_prv.X = (-(double)ScreenOriginWrk.X * Scale);
                WorkAreaOriginSrc_prv.Y = (-(double)ScreenOriginWrk.Y * Scale);
                return WorkAreaOriginSrc_prv; } }
        public Punto ScreenOriginWrk = new Punto(0, 0);

        public void ReScale(double MouseX, double MouseY, double MouseTrackWheel)
        {
            double OldScale = (double)Scale;
            double NewScale = (double)Scale + ((double)Scale * (double)MouseTrackWheel * (double)ScaleSpeed);

            Punto Old_ScreenOriginWrk = new Punto(ScreenOriginWrk.X, ScreenOriginWrk.Y);
            Punto New_ScreenOriginWrk = new Punto();

            double Old_MouseXWrk = ((double)Old_ScreenOriginWrk.X) + (((double)MouseX) / OldScale);
            double New_MouseXWrk = Old_MouseXWrk;
            New_ScreenOriginWrk.X = (((double)New_MouseXWrk) - (((double)MouseX) / NewScale));


            double Old_MouseYWrk = ((double)Old_ScreenOriginWrk.Y) + (((double)MouseY) / OldScale);
            double New_MouseYWrk = Old_MouseYWrk;
            New_ScreenOriginWrk.Y = (((double)New_MouseYWrk) - (((double)MouseY) / NewScale));

            ScreenOriginWrk.X = New_ScreenOriginWrk.X;
            ScreenOriginWrk.Y = New_ScreenOriginWrk.Y;
            Scale = NewScale;
        }
        public void Move (double MouseOffsetX, double MouseOffsetY)
        {
            ScreenOriginWrk.X -= ((double)MouseOffsetX/ (double)Scale);
            ScreenOriginWrk.Y -= ((double)MouseOffsetY / (double)Scale);
        }
        public Punto ScreenToWork (Punto pointScr)
        {
            Punto returnValue = new Punto();
            Punto WAOriginSrc = WorkAreaOriginSrc;
            returnValue.X = ((pointScr.X- WAOriginSrc.X) / Scale);
            returnValue.Y = ((pointScr.Y- WAOriginSrc.Y) / Scale);

            return returnValue;
        }
        public Punto ScreenToWork (Point pointScr)
        {
            Punto punto = new Punto(pointScr.X, pointScr.Y);
            return ScreenToWork(punto);
        }
    }
}
