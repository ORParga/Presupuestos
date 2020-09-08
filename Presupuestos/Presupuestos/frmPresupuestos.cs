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
    }
}
