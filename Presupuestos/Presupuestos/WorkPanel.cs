using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presupuestos
{
    public partial class WorkPanel : Panel
    {

        enum MouseStatus { NONE, CREATING_AREA, RIGHT_DOWN, MOVING_WORKAREA };

        MouseStatus mouseStatus = MouseStatus.NONE;

        public WorkArea workArea = new WorkArea();
        List<Area> areaList = new List<Area>();
        Area dragRectangle = new Area();

        Punto pointOrigin = new Punto(), pointEnd = new Punto();

        int colorNumber = 2;
        BasicColor basicColor = new BasicColor();
        public Brush brushRed = new SolidBrush((Color.Red));
        public Brush brushRedTrans = new SolidBrush(Color.FromArgb(63, 255, 0, 0));
        public Brush brushBlack = new SolidBrush((Color.Black));
        Font font = new Font("Times New Roman", 10);
        Pen pen = new Pen(Color.Blue);

        //***************************** DEBUG **************************************
        public bool ShowWorkValues = true;
        public bool ShowAreasValues = true;
        public bool ShowMouseValues = false;
        //**************************************************************************

        public WorkPanel()
        {
            InitializeComponent();

            MouseWheel += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseWheel);

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
           | BindingFlags.Instance | BindingFlags.NonPublic, null,
           this, new object[] { true });

        }

        private void WorkAreaMove(double MouseX, double MouseY)
        {
            workArea.Move((double)MouseX - pointOrigin.X, (double)MouseY - pointOrigin.Y);
            pointOrigin.X = MouseX;
            pointOrigin.Y = MouseY;

            this.Invalidate();
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            // Insert code to do custom painting.
            // If you want to completely change the appearance of your control,
            // do not call base.OnPaint(pe).
            Draw(pe.Graphics);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            switch (mouseStatus)
            {
                case MouseStatus.CREATING_AREA:
                    if ((e.Button & MouseButtons.Left) != 0)
                    {
                        pointEnd.X = e.X;
                        pointEnd.Y = e.Y;
                        dragRectangle.CreatingWithMouse(workArea, pointOrigin.X, pointOrigin.Y, e.X, e.Y);
                    }
                    else
                    {
                        //For any reason, this app has not captured de UpMouse event.
                        //Disable "CREATING_AREA" mode to prevent bugs
                        mouseStatus = MouseStatus.NONE;
                    }
                    break;
                case MouseStatus.RIGHT_DOWN:
                    if ((e.Button & MouseButtons.Right) != 0)
                    {
                        mouseStatus = MouseStatus.MOVING_WORKAREA;
                        WorkAreaMove(e.X, e.Y);
                        this.Cursor = Cursors.SizeAll;
                    }
                    else
                    {
                        //For any reason, this app has not captured de UpMouse event.
                        //Disable "RIGHT_DOWN" mode to prevent bugs
                        mouseStatus = MouseStatus.RIGHT_DOWN;
                    }
                    break;
                case MouseStatus.MOVING_WORKAREA:
                    if ((e.Button & MouseButtons.Right) != 0)
                    {
                        WorkAreaMove(e.X, e.Y);
                    }
                    else
                    {
                        //For any reason, this app has not captured de UpMouse event.
                        //Disable "MOVING_WORKAREA" mode to prevent bugs
                        mouseStatus = MouseStatus.RIGHT_DOWN;
                    }
                    break;
                case MouseStatus.NONE:

                    break;
            }
            //Draw(g);
            this.Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {

            if ((e.Button & MouseButtons.Left) != 0)
            {
                mouseStatus = MouseStatus.CREATING_AREA;
                pointOrigin.X = e.X;
                pointOrigin.Y = e.Y;
                pointEnd.X = e.X;
                pointEnd.Y = e.Y;
                dragRectangle.CreatingWithMouse(workArea, e.X, e.Y, e.X, e.Y);

            }

            if ((e.Button & MouseButtons.Right) != 0)
            {
                pointOrigin.X = e.X;
                pointOrigin.Y = e.Y;
                pointEnd.X = e.X;
                pointEnd.Y = e.Y;
                mouseStatus = MouseStatus.RIGHT_DOWN;
                this.Cursor = Cursors.SizeAll;
            }
            base.OnMouseDown(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            switch (mouseStatus)
            {
                case MouseStatus.CREATING_AREA:
                    dragRectangle.debugColor = Color.FromArgb((int)basicColor.map.ElementAt(colorNumber).Value);
                    colorNumber++;
                    if (colorNumber >= basicColor.map.Count) colorNumber = 2;
                    areaList.Add((Area)dragRectangle.Clone());
                    mouseStatus = MouseStatus.NONE;
                    this.Invalidate();
                    break;
                case MouseStatus.MOVING_WORKAREA:
                    mouseStatus = MouseStatus.NONE;
                    break;
                case MouseStatus.RIGHT_DOWN:
                    mouseStatus = MouseStatus.NONE;
                    ContextMenuOpen();
                    break;
                case MouseStatus.NONE:
                    break;
            }

            this.Cursor = Cursors.Default;
        }
        protected void Draw(Graphics g)
        {

            Point Mouse = PointToClient(Cursor.Position);


            int line = 0;
            Punto WAOrigin_Src = workArea.WorkAreaOriginSrc;
            g.DrawLine(pen, (float)WAOrigin_Src.X, 0, (float)WAOrigin_Src.X, ClientRectangle.Height);
            g.DrawLine(pen, 0, (float)WAOrigin_Src.Y, ClientRectangle.Width, (float)WAOrigin_Src.Y);
            if (ShowWorkValues)
            {
                g.DrawString("WorkAreaOriginSrc=" + workArea.WorkAreaOriginSrc.ToString(), font, brushBlack, 300, 0);
                g.DrawString("ScreenOriginWrk=" + workArea.ScreenOriginWrk.ToString(), font, brushBlack, 300, 20);
                g.DrawString("Scale=" + workArea.Scale.ToString(), font, brushBlack, 550, 0);
            }
            if (ShowMouseValues)
            {
                g.DrawString("MouseWrk=" + workArea.ScreenToWork(Mouse).ToString(), font, brushBlack, 500, 500);
                g.DrawString("MouseScr=" + Mouse.ToString(), font, brushBlack, 500, 520);
            }
            foreach (Area a in areaList)
            {
                a.Draw(workArea, g, true);

                if (ShowAreasValues)
                {
                    g.DrawString("Src=" + a.getClientAreaScr(workArea).ToString(), font, new SolidBrush(a.debugColor), 0, line += 20);
                    g.DrawString("Wrk=" + a.clientAreaWrk.ToString(), font, new SolidBrush(a.debugColor), 0, line += 20);
                }
            }
            switch (mouseStatus)
            {
                case MouseStatus.NONE:
                    foreach (Area a in areaList)
                    {
                        if (a.MouseOver(workArea, Mouse.X, Mouse.Y))
                        {
                            g.FillRectangle(brushRedTrans, a.getClientAreaScr(workArea));
                            a.DrawWidth(workArea, g);
                            a.DrawHeight(workArea, g);

                        }
                    }
                    break;
                case MouseStatus.CREATING_AREA:
                    if (Control.MouseButtons == MouseButtons.Left)
                    {
                        dragRectangle.Draw(workArea, g);
                        dragRectangle.DrawWidth(workArea, g);
                        dragRectangle.DrawHeight(workArea, g);
                        g.DrawString(dragRectangle.getClientAreaScr(workArea).ToString(), font, brushRed, 0, 0);
                    }
                    else
                    {
                        mouseStatus = MouseStatus.NONE;
                    }
                    break;
                default:
                    break;
            }
        }

        protected void panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            workArea.ReScale(e.X, e.Y, e.Delta);
            Invalidate();
        }
        protected void ContextMenuOpen()
        {

        }
    }
}
