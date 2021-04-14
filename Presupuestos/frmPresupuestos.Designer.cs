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
            Presupuestos.WorkPanel_FileValues workPanel_FileValues3 = new Presupuestos.WorkPanel_FileValues();
            this.ToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolDraw = new System.Windows.Forms.ToolStrip();
            this.btnSelect = new System.Windows.Forms.ToolStripButton();
            this.btnRoom = new System.Windows.Forms.ToolStripButton();
            this.btnLine = new System.Windows.Forms.ToolStripButton();
            this.btnImage = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnShowWork = new System.Windows.Forms.ToolStripButton();
            this.btnShowAreas = new System.Windows.Forms.ToolStripButton();
            this.btnDebug = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMouseScrTittle = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMouseScr = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMouseWrkTittle = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMouseWrk = new System.Windows.Forms.ToolStripStatusLabel();
            this.ImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.openPresupuestoDlg = new System.Windows.Forms.OpenFileDialog();
            this.savePresupuestoDlg = new System.Windows.Forms.SaveFileDialog();
            this.workPanel1 = new Presupuestos.WorkPanel();
            this.ToolStripContainer.ContentPanel.SuspendLayout();
            this.ToolStripContainer.LeftToolStripPanel.SuspendLayout();
            this.ToolStripContainer.TopToolStripPanel.SuspendLayout();
            this.ToolStripContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolDraw.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripContainer
            // 
            // 
            // ToolStripContainer.ContentPanel
            // 
            this.ToolStripContainer.ContentPanel.Controls.Add(this.splitContainer1);
            this.ToolStripContainer.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToolStripContainer.ContentPanel.Size = new System.Drawing.Size(1928, 981);
            this.ToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // ToolStripContainer.LeftToolStripPanel
            // 
            this.ToolStripContainer.LeftToolStripPanel.Controls.Add(this.toolDraw);
            this.ToolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.ToolStripContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToolStripContainer.Name = "ToolStripContainer";
            this.ToolStripContainer.Size = new System.Drawing.Size(1964, 1055);
            this.ToolStripContainer.TabIndex = 0;
            this.ToolStripContainer.Text = "toolStripContainer1";
            // 
            // ToolStripContainer.TopToolStripPanel
            // 
            this.ToolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.ToolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.workPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Panel2MinSize = 300;
            this.splitContainer1.Size = new System.Drawing.Size(1928, 981);
            this.splitContainer1.SplitterDistance = 978;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Size = new System.Drawing.Size(936, 977);
            this.splitContainer2.SplitterDistance = 468;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 977);
            this.panel1.TabIndex = 0;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 977);
            this.panel2.TabIndex = 0;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // toolDraw
            // 
            this.toolDraw.Dock = System.Windows.Forms.DockStyle.None;
            this.toolDraw.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolDraw.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelect,
            this.btnRoom,
            this.btnLine,
            this.btnImage});
            this.toolDraw.Location = new System.Drawing.Point(0, 4);
            this.toolDraw.Name = "toolDraw";
            this.toolDraw.Size = new System.Drawing.Size(36, 148);
            this.toolDraw.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Checked = true;
            this.btnSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(33, 28);
            this.btnSelect.Text = "S";
            this.btnSelect.ToolTipText = "Select";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnRoom.Image")));
            this.btnRoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(33, 28);
            this.btnRoom.Text = "R";
            this.btnRoom.ToolTipText = "Room";
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnLine
            // 
            this.btnLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLine.Image = ((System.Drawing.Image)(resources.GetObject("btnLine.Image")));
            this.btnLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(33, 28);
            this.btnLine.Text = "toolStripButton1";
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnImage
            // 
            this.btnImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImage.Image = ((System.Drawing.Image)(resources.GetObject("btnImage.Image")));
            this.btnImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(33, 28);
            this.btnImage.Text = "toolStripButton1";
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowWork,
            this.btnShowAreas,
            this.btnDebug});
            this.toolStrip1.Location = new System.Drawing.Point(4, 36);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(120, 38);
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
            this.btnShowWork.Size = new System.Drawing.Size(34, 33);
            this.btnShowWork.Tag = "";
            this.btnShowWork.Text = "W";
            this.btnShowWork.ToolTipText = "Show Work Area Values";
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
            this.btnShowAreas.Size = new System.Drawing.Size(34, 33);
            this.btnShowAreas.Text = "A";
            this.btnShowAreas.ToolTipText = "Show Areas";
            this.btnShowAreas.Click += new System.EventHandler(this.btnShowAreas_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.Checked = true;
            this.btnDebug.CheckOnClick = true;
            this.btnDebug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnDebug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDebug.Image = ((System.Drawing.Image)(resources.GetObject("btnDebug.Image")));
            this.btnDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(34, 33);
            this.btnDebug.Text = "D";
            this.btnDebug.ToolTipText = "Debug Window";
            this.btnDebug.CheckStateChanged += new System.EventHandler(this.toolStripButton1_CheckStateChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.insertarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1964, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 32);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.ToolTipText = "Administrar archivos";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.abrirToolStripMenuItem.Text = "Abrir...";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Enabled = false;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.guardarComoToolStripMenuItem.Text = "Guardar Como...";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(240, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.ToolTipText = "Apagar \"Presupuestos\"";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salir_Click);
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagenToolStripMenuItem});
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(87, 32);
            this.insertarToolStripMenuItem.Text = "Insertar";
            // 
            // imagenToolStripMenuItem
            // 
            this.imagenToolStripMenuItem.Name = "imagenToolStripMenuItem";
            this.imagenToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.imagenToolStripMenuItem.Text = "Background...";
            this.imagenToolStripMenuItem.Click += new System.EventHandler(this.imagenToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMouseScrTittle,
            this.lblMouseScr,
            this.lblMouseWrkTittle,
            this.lblMouseWrk});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1019);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1964, 36);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMouseScrTittle
            // 
            this.lblMouseScrTittle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblMouseScrTittle.Name = "lblMouseScrTittle";
            this.lblMouseScrTittle.Size = new System.Drawing.Size(104, 29);
            this.lblMouseScrTittle.Text = "Screen (X,Y)";
            // 
            // lblMouseScr
            // 
            this.lblMouseScr.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblMouseScr.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblMouseScr.Name = "lblMouseScr";
            this.lblMouseScr.Size = new System.Drawing.Size(64, 29);
            this.lblMouseScr.Text = "( - , - )";
            // 
            // lblMouseWrkTittle
            // 
            this.lblMouseWrkTittle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblMouseWrkTittle.Name = "lblMouseWrkTittle";
            this.lblMouseWrkTittle.Size = new System.Drawing.Size(130, 29);
            this.lblMouseWrkTittle.Text = "WorkArea (X,Y)";
            // 
            // lblMouseWrk
            // 
            this.lblMouseWrk.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblMouseWrk.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblMouseWrk.Name = "lblMouseWrk";
            this.lblMouseWrk.Size = new System.Drawing.Size(64, 29);
            this.lblMouseWrk.Text = "( - , - )";
            // 
            // ImageDialog
            // 
            this.ImageDialog.FileName = "Image";
            this.ImageDialog.Filter = "JPG files (*.jpg)|*.jpg|BMP files (*.bmp)|*.bmp|All files (*.*)|*.*";
            // 
            // openPresupuestoDlg
            // 
            this.openPresupuestoDlg.FileName = "presupuesto.pre";
            this.openPresupuestoDlg.Filter = "presupuesto (.pre)|*.pre|All files (*.*)|*.*";
            // 
            // savePresupuestoDlg
            // 
            this.savePresupuestoDlg.FileName = "presupuesto.pre";
            this.savePresupuestoDlg.Filter = "presupuesto (.pre)|*.pre|All files (*.*)|*.*";
            // 
            // workPanel1
            // 
            this.workPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workPanel1.Location = new System.Drawing.Point(0, 0);
            this.workPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.workPanel1.Name = "workPanel1";
            this.workPanel1.Size = new System.Drawing.Size(974, 977);
            this.workPanel1.TabIndex = 0;
            this.workPanel1.WorkPanelFileValues = workPanel_FileValues3;
            this.workPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.workPanel1_MouseMove);
            // 
            // frmPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1964, 1055);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ToolStripContainer);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPresupuestos";
            this.Text = "Presupuestos";
            this.Load += new System.EventHandler(this.frmPresupuestos_Load);
            this.Shown += new System.EventHandler(this.frmPresupuestos_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPresupuestos_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPresupuestos_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPresupuestos_KeyUp);
            this.ToolStripContainer.ContentPanel.ResumeLayout(false);
            this.ToolStripContainer.LeftToolStripPanel.ResumeLayout(false);
            this.ToolStripContainer.LeftToolStripPanel.PerformLayout();
            this.ToolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.ToolStripContainer.TopToolStripPanel.PerformLayout();
            this.ToolStripContainer.ResumeLayout(false);
            this.ToolStripContainer.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolDraw.ResumeLayout(false);
            this.toolDraw.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer ToolStripContainer;
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
        private System.Windows.Forms.ToolStripButton btnDebug;
        private System.Windows.Forms.ToolStrip toolDraw;
        private System.Windows.Forms.ToolStripButton btnSelect;
        private System.Windows.Forms.ToolStripButton btnRoom;
        private System.Windows.Forms.ToolStripButton btnLine;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton btnImage;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagenToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ImageDialog;
        private System.Windows.Forms.OpenFileDialog openPresupuestoDlg;
        private System.Windows.Forms.SaveFileDialog savePresupuestoDlg;
    }
}

