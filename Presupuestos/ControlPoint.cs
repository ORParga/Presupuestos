using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Presupuestos
{
    public class ControlPoint_FileValues
    {
        public double X;
        public double Y;

        public ControlPoint_FileValues()
        {

        }

        public ControlPoint_FileValues(double X,double Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public ControlPoint_FileValues(ControlPoint controlPoint)
        {
            this.X = controlPoint.X;
            this.Y = controlPoint.Y;
        }
        public static List<ControlPoint_FileValues> ToFileValues (List<ControlPoint> controlPoints)
        {
            List<ControlPoint_FileValues> controlPointFileValues_list = new List<ControlPoint_FileValues>();

            if (controlPoints == null) return null;
            foreach (ControlPoint controlPoint in controlPoints)
            {
                controlPointFileValues_list.Add(new ControlPoint_FileValues(controlPoint));
            }

            return controlPointFileValues_list;
        }
    }
    public class ControlPoint
    {
        protected Punto punto_prv;
        protected bool Selected_prv=false;
        protected bool Focused_prv = false;
        protected bool HightLight_prv = false;
        protected bool Moving_prv = false;
        public bool Moving
        {
            get { return Moving_prv; }
            set { Moving_prv = value; }
        }
        public DRAW_MODE draw_mode
        {
            get
            {
                if (Focused_prv) return DRAW_MODE.FOCUSED;
                if (Selected_prv) return DRAW_MODE.SELECTED;
                if (HightLight_prv) return DRAW_MODE.HIGHTLIGHT;
                return DRAW_MODE.NORMAL;
            }
        }

        protected ISelectable owner_prv=null;
        protected int index_prv=-1;

        //**********************************Graphics****************************************
        public enum DRAW_FIGURE { SQUARE,CROSS};
        public DRAW_FIGURE drawFigure = DRAW_FIGURE.SQUARE;
        protected const float lineWidthDefault = 1;
        protected const double controlPointSize = 4;
        protected Pen penControlPointDefault = new Pen(Color.FromArgb(255, 127, 127, 127), lineWidthDefault);
        protected Pen penControlPointHightLightDefault = new Pen(Color.FromArgb(255, 247, 159, 0), lineWidthDefault);
        protected Pen penControlPointSelectedDefault = new Pen(Color.FromArgb(255, 247, 208, 138), lineWidthDefault);
        protected Pen penControlPointFocusedDefault = new Pen(Color.FromArgb(255, 255, 130, 0), lineWidthDefault);

        protected Pen  penControlPoint;
        protected Pen  penControlPointHightLight;
        protected Pen  penControlPointSelected;
        protected Pen  penControlPointFocused;

        public ControlPoint()
        {
            punto_prv = new Punto();
            constructor();
        }
        public ControlPoint(double X,double Y)
        {
            punto_prv = new Punto(X, Y);
            constructor();
        }
        public ControlPoint(ISelectable owner, double X, double Y)
        {
            punto_prv = new Punto(X, Y);
            this.owner_prv = owner;
            constructor();
        }
        public ControlPoint(ISelectable owner,int index, double X, double Y)
        {
            punto_prv = new Punto(X, Y);
            this.owner_prv = owner;
            this.index_prv = index;
            constructor();
        }
        protected void constructor ()
        {

            penControlPoint = (Pen)penControlPointDefault.Clone();
            penControlPointHightLight = (Pen)penControlPointHightLightDefault.Clone();
            penControlPointSelected = (Pen)penControlPointSelectedDefault.Clone();
            penControlPointFocused = (Pen)penControlPointFocusedDefault.Clone();
        }
        public double X
        {
            get { return punto_prv.X; }
            set { punto_prv.X = value; }
        }
        public double Y
        {
            get { return punto_prv.Y; }
            set { punto_prv.Y=value; }
        }
        //Only if it is selected it can be focused..., and always it is focused, it is selected
        public bool Selected
        {
            get { return Selected_prv; }
            set { Selected_prv = value;if (!value) Focused_prv = false; }
        }
        //Only if it is selected it can be focused..., and always it is focused, it is selected
        public bool Focused
        {
            get { return Focused_prv; }
            set { Focused_prv = value;if (value) Selected_prv = true; }
        }
        public bool HightLight
        {
            get { return HightLight_prv; }
            set { HightLight_prv = value; }
        }
        public ISelectable owner
        {
            get { return owner_prv; }
            set { owner_prv = value; }
        }
        public int index
        {
            get { return index_prv; }
            set { index_prv = value; }
        }
        //Devuelve una copia clonada del punto, o establece los valores guardandolos en 
        //el miembro punto_prv privado
        public Punto punto
        {
            get { return (Punto)punto_prv.Clone(); }
            set { punto_prv.X = value.X;punto_prv.Y = value.Y; }
        }
        public void set(double X,double Y)
        {
            punto_prv.X = X;
            punto_prv.Y = Y;
        }
        public void set(Punto punto)
        {
            punto_prv.X = punto.X;
            punto_prv.Y = punto.Y;
        }
        public void setCoordinates(ControlPoint punto)
        {
            punto_prv.X = punto.X;
            punto_prv.Y = punto.Y;
        }
        public void set(ISelectable owner,int index)
        {
            this.owner_prv = owner;
            this.index_prv = index;
        }
        public void set(ISelectable owner)
        {
            this.owner_prv = owner;
        }
        public void set(int index)
        {
            this.index_prv = index;
        }
        public void set(ISelectable owner,int index,double X,double Y)
        {
            this.owner_prv = owner;
            this.index_prv = index;
            punto_prv.X = X;
            punto_prv.Y = Y;
            
        }
        public void set(ISelectable owner,int index,ControlPoint controlPoint)
        {
            this.owner_prv = owner;
            this.index_prv = index;
            punto_prv.X = controlPoint.X;
            punto_prv.Y = controlPoint.Y;

        }
        public void SetMode(DRAW_MODE drawMode)
        {

            switch (drawMode)
            {
                case DRAW_MODE.NORMAL:
                    HightLight = false;
                    Selected = false;
                    break;
                case DRAW_MODE.HIGHTLIGHT:
                    HightLight = true;
                    break;
                case DRAW_MODE.SELECTED:
                    Selected = true;
                    break;
                case DRAW_MODE.FOCUSED:
                    Focused = true;
                    break;
            }
        }
        public void MovingControlPoint(Punto pointOriginWA, Punto pointEndWA)
        {
            owner.MovingControlPoint(pointOriginWA, pointEndWA, this);
        }

        public void MoveEndControlPoint(Punto pointOriginWA, Punto pointEndWA)
        {
            owner.MoveEndControlPoint(pointOriginWA, pointEndWA, this);
        }
        public void Draw(WorkArea workArea,Graphics g)
        {
            Draw(workArea, g, draw_mode);
        }
        public void Draw(WorkArea workArea, Graphics g, DRAW_MODE draw_mode)
        {
            Pen pen_local;
            switch (draw_mode)
            {
                default:
                case DRAW_MODE.NORMAL:
                    //Lo normal es que no se dibuje el punto de control
                    return;
                case DRAW_MODE.HIGHTLIGHT:
                    pen_local = penControlPointHightLight;
                    break;
                case DRAW_MODE.SELECTED:
                    pen_local = penControlPointSelected;
                    break;
                case DRAW_MODE.FOCUSED:
                    pen_local = penControlPointFocused;
                    break;
            }
            Punto PuntoScr;
            PuntoScr = workArea.WorkToScreen(this);
            switch (drawFigure)
            {
                case DRAW_FIGURE.SQUARE:
                    {
                        g.DrawRectangle(pen_local, (float)(PuntoScr.X - controlPointSize),
                            (float)(PuntoScr.Y - controlPointSize),
                            (float)controlPointSize * 2,
                            (float)controlPointSize * 2);
                        break;
                    }
                case DRAW_FIGURE.CROSS:
                    {
                        g.DrawLine(pen_local, (float)PuntoScr.X,
                            (float)(PuntoScr.Y - controlPointSize),
                            (float)PuntoScr.X,
                            (float)(PuntoScr.Y + controlPointSize));
                        g.DrawLine(pen_local, (float)(PuntoScr.X - controlPointSize),
                            (float)(PuntoScr.Y),
                            (float)(PuntoScr.X + controlPointSize),
                            (float)(PuntoScr.Y));
                        break;
                    }
            }


        }
        public override string ToString()
        {
            return "(" + X.ToString("F2") + "," + Y.ToString("F2") + ")";
        }
        public string ToString(string format)
        {
            return "(" + X.ToString(format) + "," + Y.ToString(format) + ")";
        }
    }
}
