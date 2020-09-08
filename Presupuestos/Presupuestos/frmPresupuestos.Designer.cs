namespace Presupuestos
{
    partial class frmPresupuestos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresupuestos));
            this.MainContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMouseScrTittle = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMouseScr = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMouseWrkTittle = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMouseWrk = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnShowWork = new System.Windows.Forms.ToolStripButton();
            this.btnShowAreas = new System.Windows.Forms.ToolStripButton();
            this.workPanel1 = new Presupuestos.WorkPanel();
            this.MainContainer.ContentPanel.SuspendLayout();
            this.MainContainer.TopToolStripPanel.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainContainer
            // 
            // 
            // MainContainer.ContentPanel
            // 
            this.MainContainer.ContentPanel.Controls.Add(this.workPanel1);
            this.MainContainer.ContentPanel.Size = new System.Drawing.Size(1137, 612);
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(0, 0);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(1137, 686);
            this.MainContainer.TabIndex = 0;
            this.MainContainer.Text = "toolStripContainer1";
            // 
            // MainContainer.TopToolStripPanel
            // 
            this.MainContainer.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.MainContainer.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMouseScrTittle,
            this.lblMouseScr,
            this.lblMouseWrkTittle,
            this.lblMouseWrk});
            this.statusStrip1.Location = new System.Drawing.Point(0, 662);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1137, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMouseScrTittle
            // 
            this.lblMouseScrTittle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblMouseScrTittle.Name = "lblMouseScrTittle";
            this.lblMouseScrTittle.Size = new System.Drawing.Size(70, 19);
            this.lblMouseScrTittle.Text = "Screen (X,Y)";
            // 
            // lblMouseScr
            // 
            this.lblMouseScr.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblMouseScr.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblMouseScr.Name = "lblMouseScr";
            this.lblMouseScr.Size = new System.Drawing.Size(44, 19);
            this.lblMouseScr.Text = "( - , - )";
            // 
            // lblMouseWrkTittle
            // 
            this.lblMouseWrkTittle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblMouseWrkTittle.Name = "lblMouseWrkTittle";
            this.lblMouseWrkTittle.Size = new System.Drawing.Size(87, 19);
            this.lblMouseWrkTittle.Text = "WorkArea (X,Y)";
            // 
            // lblMouseWrk
            // 
            this.lblMouseWrk.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblMouseWrk.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblMouseWrk.Name = "lblMouseWrk";
            this.lblMouseWrk.Size = new System.Drawing.Size(44, 19);
            this.lblMouseWrk.Text = "( - , - )";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1137, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.ToolTipText = "Administrar archivos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.ToolTipText = "Apagar \"Presupuestos\"";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salir_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowWork,
            this.btnShowAreas});
            this.toolStrip1.Location = new System.Drawing.Point(3, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(89, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // btnShowWork
            // 
            this.btnShowWork.Checked = true;
            this.btnShowWork.CheckOnClick = true;
            this.btnShowWork.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnShowWork.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnShowWork.Image = ((System.Drawing.Image)(resources.GetObject("btnShowWork.Image")));
            this.btnShowWork.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowWork.Name = "btnShowWork";
            this.btnShowWork.Size = new System.Drawing.Size(23, 22);
            this.btnShowWork.Text = "W";
            this.btnShowWork.Click += new System.EventHandler(this.btnShowWork_Click);
            // 
            // btnShowAreas
            // 
            this.btnShowAreas.Checked = true;
            this.btnShowAreas.CheckOnClick = true;
            this.btnShowAreas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnShowAreas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnShowAreas.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAreas.Image")));
            this.btnShowAreas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowAreas.Name = "btnShowAreas";
            this.btnShowAreas.Size = new System.Drawing.Size(23, 22);
            this.btnShowAreas.Text = "A";
            this.btnShowAreas.Click += new System.EventHandler(this.btnShowAreas_Click);
            // 
            // workPanel1
            // 
            this.workPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workPanel1.Location = new System.Drawing.Point(0, 0);
            this.workPanel1.Name = "workPanel1";
            this.workPanel1.Size = new System.Drawing.Size(1137, 612);
            this.workPanel1.TabIndex = 0;
            this.workPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.workPanel1_MouseMove);
            // 
            // frmPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1137, 686);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainContainer);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPresupuestos";
            this.Text = "Presupuestos";
            this.MainContainer.ContentPanel.ResumeLayout(false);
            this.MainContainer.TopToolStripPanel.ResumeLayout(false);
            this.MainContainer.TopToolStripPanel.PerformLayout();
            this.MainContainer.ResumeLayout(false);
            this.MainContainer.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer MainContainer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblMouseScrTittle;
        private System.Windows.Forms.ToolStripStatusLabel lblMouseScr;
        private System.Windows.Forms.ToolStripStatusLabel lblMouseWrkTittle;
        private System.Windows.Forms.ToolStripStatusLabel lblMouseWrk;
        private WorkPanel workPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnShowWork;
        private System.Windows.Forms.ToolStripButton btnShowAreas;
    }
}

