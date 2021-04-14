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
        SaveAndLoad SaveAndLoad;
        PropertiesPanel PropertiesPanel;
        frmDebugger frmDebugger;

        string PresupuestosTittle = "presupuestos";
        string CurrentFileName_prv = "";
        string CurrentFileName
        {
            get { return CurrentFileName_prv; }
            set {
                CurrentFileName_prv = value;
                if (value.Equals(""))
                {
                this.Text = "PresupuestosTittle";
                    guardarToolStripMenuItem.Enabled = false;
                }
                else
                {
                this.Text = "PresupuestosTittle - " + value;
                    guardarToolStripMenuItem.Enabled = true;
                }
            }
        }

        public frmPresupuestos()
        {
            InitializeComponent();
            // Set KeyPreview object to true to allow the form to process 
            // the key before the control with focus processes it.
            frmDebugger = new frmDebugger();
            SaveAndLoad = new SaveAndLoad();
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
            workPanel1.ShowWorkAreaValues = btnShowWork.Checked;
            workPanel1.Invalidate();

        }

        private void frmPresupuestos_KeyDown(object sender, KeyEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("KeyDown " + e.KeyCode);
            workPanel1.My_KeyDown(sender, e);
        }

        private void frmPresupuestos_KeyUp(object sender, KeyEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("KeyUp " + e.KeyCode);
            workPanel1.My_KeyUp(sender, e);

        }

        private void frmPresupuestos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("KeyPress "+e.KeyChar);

        }

        private void toolStripButton1_CheckStateChanged(object sender, EventArgs e)
        {
            if (btnDebug.Checked){
                frmDebugger.Show(this);
                frmDebugger.setPosition(Top, Right);
            }
            else
            {
                frmDebugger.Hide();
            }
        }

        private void frmPresupuestos_Load(object sender, EventArgs e)
        {
            PropertiesPanel = new PropertiesPanel(this.splitContainer2);
            workPanel1.setForms(this,frmDebugger);
            if (btnDebug.Checked)
            {
                frmDebugger.Show(this);
                frmDebugger.setPosition(Top, Right);
            }
            else
            {
                frmDebugger.Hide();
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            activateButton((ToolStripButton)sender);
            workPanel1.setToolMode(WorkPanel.ToolMode.SELECT);
        }
        private void btnRoom_Click(object sender, EventArgs e)
        {
            activateButton((ToolStripButton)sender);
            workPanel1.setToolMode(WorkPanel.ToolMode.ROOM);
        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            activateButton((ToolStripButton)sender);
            workPanel1.setToolMode(WorkPanel.ToolMode.LINE);
        }
        private void btnImage_Click(object sender, EventArgs e)
        {

            activateButton((ToolStripButton)sender);
            workPanel1.setToolMode(WorkPanel.ToolMode.CABLE);
        }
        private void activateButton(ToolStripButton button)
        {
            btnRoom.Checked = button.Equals(btnRoom);
            btnSelect.Checked = button.Equals(btnSelect);
            btnLine.Checked = button.Equals(btnLine);
            btnImage.Checked = button.Equals(btnImage);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = openPresupuestoDlg.ShowDialog();

            if (dialog == DialogResult.OK)
            {
                CurrentFileName = openPresupuestoDlg.FileName;
                WorkPanel_FileValues FileValues_local = SaveAndLoad.Load(openPresupuestoDlg.FileName);
                if (FileValues_local == null)
                {
                    MessageBox.Show("¡Ha habido un error al intentar abrir el archivo!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                this.workPanel1.WorkPanelFileValues = FileValues_local;
                this.workPanel1.Invalidate();
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (!SaveAndLoad.Save(CurrentFileName, this.workPanel1.WorkPanelFileValues))
                {
                    //Ha habido un error al intentar guardar el archivo
                    MessageBox.Show("¡Ha habido un error al intentar guardar el archivo!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dialog = savePresupuestoDlg.ShowDialog();

            if (dialog == DialogResult.OK)
            {
                if(!SaveAndLoad.Save(savePresupuestoDlg.FileName, this.workPanel1.WorkPanelFileValues))
                {
                    //Ha habido un error al intentar guardar el archivo
                    MessageBox.Show("¡Ha habido un error al intentar guardar el archivo!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                CurrentFileName = savePresupuestoDlg.FileName;
                
            }
        }
        private void imagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = ImageDialog.ShowDialog();

            if (dialog == DialogResult.OK)
            {
                workPanel1.setBackground(ImageDialog.FileName);
            }

        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPresupuestos_Shown(object sender, EventArgs e)
        {


            frmDebugger.AddMessage("splitContainer1.Width", "" + splitContainer1.Width);
            frmDebugger.AddMessage("SplitContainer.SplitterDistance", "" + splitContainer1.SplitterDistance);
            splitContainer1.SplitterDistance = splitContainer1.Width - splitContainer1.Panel2MinSize;
            frmDebugger.AddMessage("SplitContainer.SplitterDistance2", "" + splitContainer1.SplitterDistance);
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
          foreach(Control control in   splitContainer2.Panel1.Controls[0].Controls)
            {
                control.Width = splitContainer2.Panel1.Controls[0].Width- (PropertiesPanel.MarginLeft*2);
                control.Invalidate();
            }
        }

        private void panel2_Resize(object sender, EventArgs e)
        {

          foreach(Control control in   splitContainer2.Panel2.Controls[0].Controls)
            {
                control.Width = splitContainer2.Panel2.Controls[0].Width- (PropertiesPanel.MarginLeft*2);
                control.Invalidate();
            }
        }
        /// <summary>
        /// setPropertiesInPanel llama AddPropertyToPanel, la cual llama a CreatePropertyTexBoxes 
        /// en caso de que sea necesario crear un par de textbox
        /// </summary>
        /// <param name="properties"></param>
        public void setPropertiesInPanel(List<PropertyRow> properties)
        {
            TextBoxPair textBoxPair_loc;
            int index;
            if (properties != null)
            {
                for ( index = 0; index < properties.Count; index++)
                {
                    textBoxPair_loc = PropertiesPanel.AddPropertyToPanel(index, properties[index].property);
                    properties[index].txtName= textBoxPair_loc.txtName;
                    properties[index].txtValue2 = textBoxPair_loc.txtValue2;
                }
                for (;index< splitContainer2.Panel1.Controls[0].Controls.Count; index++)
                {
                    splitContainer2.Panel1.Controls[0].Controls[index].Hide();
                    splitContainer2.Panel2.Controls[0].Controls[index].Hide();
                }
            }
        }
    }
}
