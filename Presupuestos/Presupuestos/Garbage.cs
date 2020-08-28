using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Presupuestos
{
    class Garbage
    {
        Point pointOrigin = new Point(), pointEnd = new Point();
        Area dragRectangle = new Area();
        public Pen pn = new Pen(Color.Blue);
        public Brush brsh = new SolidBrush((Color.Red));
        Font font = new Font("Times New Roman", 26);

        void BufferedGraphics ()
        {
        //    public partial class Form1 : Form
        //{
        //    private BufferedGraphicsContext context;
        //    private BufferedGraphics grafx;

        //    Point pointOrigin = new Point(), pointEnd = new Point();
        //    Rectangle dragRectangle = new Rectangle();
        //    public Pen pn = new Pen(Color.Blue);
        //    public Brush brsh = new SolidBrush((Color.Red));
        //    Font font = new Font("Times New Roman", 26);
        //    public Form1() : base()
        //    {
        //        this.Resize += new EventHandler(this.OnResize);
        //        this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);

        //        // Retrieves the BufferedGraphicsContext for the
        //        // current application domain.
        //        context = BufferedGraphicsManager.Current;

        //        // Sets the maximum size for the primary graphics buffer
        //        // of the buffered graphics context for the application
        //        // domain.  Any allocation requests for a buffer larger
        //        // than this will create a temporary buffered graphics
        //        // context to host the graphics buffer.
        //        context.MaximumBuffer = new Size(this.Width + 1, this.Height + 1);

        //        // Allocates a graphics buffer the size of this form
        //        // using the pixel format of the Graphics created by
        //        // the Form.CreateGraphics() method, which returns a
        //        // Graphics object that matches the pixel format of the form.
        //        grafx = context.Allocate(this.CreateGraphics(),
        //             new Rectangle(0, 0, this.Width, this.Height));

        //        InitializeComponent();
        //    }

        //    private void Form1_Shown(object sender, EventArgs e)
        //    {
        //        grafx.Graphics.FillRectangle(Brushes.Black, 0, 0, this.Width, this.Height);
        //    }

        //    private void OnResize(object sender, EventArgs e)
        //    {
        //        // Re-create the graphics buffer for a new window size.
        //        context.MaximumBuffer = new Size(this.Width + 1, this.Height + 1);
        //        if (grafx != null)
        //        {
        //            grafx.Dispose();
        //            grafx = null;
        //        }
        //        grafx = context.Allocate(this.CreateGraphics(),
        //            new Rectangle(0, 0, this.Width, this.Height));

        //        // Cause the background to be cleared and redraw.
        //        //count = 6;
        //        DrawToBuffer(grafx.Graphics);
        //        this.Refresh();
        //    }

        //    private void DrawToBuffer(Graphics g)
        //    {
        //        grafx.Graphics.FillRectangle(Brushes.White, 0, 0, this.Width, this.Height);

        //        if (Control.MouseButtons == MouseButtons.Left)
        //        {
        //            if (pointOrigin.X < pointEnd.X)
        //            {
        //                dragRectangle.X = pointOrigin.X;
        //                dragRectangle.Width = pointEnd.X - pointOrigin.X;
        //            }
        //            else
        //            {
        //                dragRectangle.X = pointEnd.X;
        //                dragRectangle.Width = pointOrigin.X - pointEnd.X;
        //            }
        //            if (pointOrigin.Y < pointEnd.Y)
        //            {
        //                dragRectangle.Y = pointOrigin.Y;
        //                dragRectangle.Height = pointEnd.Y - pointOrigin.Y;
        //            }
        //            else
        //            {
        //                dragRectangle.Y = pointEnd.Y;
        //                dragRectangle.Height = pointOrigin.Y - pointEnd.Y;
        //            }
        //            g.DrawRectangle(pn, dragRectangle);
        //            //g.FillRectangle(brsh, dragRectangle);
        //        }
        //    }
        //    private void Form1_Paint(object sender, PaintEventArgs e)
        //    {
        //        //grafx.Render(e.Graphics);
        //    }

        //    private void Form1_MouseMove(object sender, MouseEventArgs e)
        //    {
        //        if ((e.Button & MouseButtons.Left) != 0)
        //        {
        //            pointEnd.X = e.X;
        //            pointEnd.Y = e.Y;

        //            DrawToBuffer(grafx.Graphics);
        //            grafx.Render(Graphics.FromHwnd(this.Handle));
        //        }
        //        //this.Invalidate();
        //    }

        //    private void Form1_MouseDown(object sender, MouseEventArgs e)
        //    {
        //        pointOrigin.X = e.X;
        //        pointOrigin.Y = e.Y;
        //        pointEnd.X = e.X;
        //        pointEnd.Y = e.Y;
        //    }
        //}
    }

        private void Draw(Graphics g)
        {

            if (Control.MouseButtons == MouseButtons.Left)
            {
                if (pointOrigin.X < pointEnd.X)
                {
                    dragRectangle.clientAreaWrk.X = pointOrigin.X;
                    dragRectangle.clientAreaWrk.Width = pointEnd.X - pointOrigin.X;
                }
                else
                {
                    dragRectangle.clientAreaWrk.X = pointEnd.X;
                    dragRectangle.clientAreaWrk.Width = pointOrigin.X - pointEnd.X;
                }
                if (pointOrigin.Y < pointEnd.Y)
                {
                    dragRectangle.clientAreaWrk.Y = pointOrigin.Y;
                    dragRectangle.clientAreaWrk.Height = pointEnd.Y - pointOrigin.Y;
                }
                else
                {
                    dragRectangle.clientAreaWrk.Y = pointEnd.Y;
                    dragRectangle.clientAreaWrk.Height = pointOrigin.Y - pointEnd.Y;
                }
                g.DrawRectangle(pn, dragRectangle.clientAreaWrk);
                g.FillRectangle(brsh, dragRectangle.clientAreaWrk);
            }
        }
    }
}
