using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presupuestos
{
    public partial class frmPresupuestos : Form
    {
        public frmPresupuestos()
        {
            InitializeComponent();
            // Set KeyPreview object to true to allow the form to process 
            // the key before the control with focus processes it.
            this.KeyPreview = true;
        }

        private void workPanel1_MouseMove(object sender, MouseEventArgs e)
        {

            Point MouseScr = workPanel1.PointToClient(Cursor.Position);
            Punto MouseWrk = workPanel1.workArea.ScreenToWork(MouseScr);

            lblMouseScr.Text = "(" + MouseScr.X.ToString() + "," + MouseScr.Y.ToString() + ")";
            lblMouseWrk.Text = "(" + MouseWrk.X.ToString("0.00") + "," + MouseWrk.Y.ToString("0.00") + ")";

        }

        private void salir_Click(object sender, EventArgs e)
        {
            CancelEventArgs cancel = new CancelEventArgs(true);
            Application.Exit(cancel);
            if(cancel.Cancel)
            {
                MessageBox.Show("Please, no.");
            }
        }

        private void btnShowAreas_Click(object sender, EventArgs e)
        {

            workPanel1.ShowAreasValues = btnShowAreas.Checked;
            workPanel1.Invalidate();
        }

        private void btnShowWork_Click(object sender, EventArgs e)
        {
            workPanel1.ShowWorkValues = btnShowWork.Checked;
            workPanel1.Invalidate();

        }

        private void frmPresupuestos_KeyDown(object sender, KeyEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("KeyDown " + e.KeyCode);
            workPanel1.KeyPressed(sender, e);
        }

        private void frmPresupuestos_KeyUp(object sender, KeyEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("KeyUp " + e.KeyCode);
            workPanel1.KeyReleased(sender, e);

        }

        private void frmPresupuestos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("KeyPress "+e.KeyChar);

        }
    }
}
