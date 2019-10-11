namespace prueba_login
{
    partial class Trabajador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnSalir2 = new System.Windows.Forms.ToolStripButton();
            this.BtnMaximizar2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BtnRestaurar2 = new System.Windows.Forms.ToolStripButton();
            this.BtnMinizar2 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnVerOrden = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbllog = new System.Windows.Forms.Label();
            this.lbltrabajo = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panelContenedor4 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSalir2,
            this.BtnMaximizar2,
            this.toolStripLabel1,
            this.BtnRestaurar2,
            this.BtnMinizar2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1280, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // BtnSalir2
            // 
            this.BtnSalir2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnSalir2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSalir2.Image = global::prueba_login.Properties.Resources.Close_Window__2_48px;
            this.BtnSalir2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSalir2.Name = "BtnSalir2";
            this.BtnSalir2.Size = new System.Drawing.Size(23, 22);
            this.BtnSalir2.Text = "Salir";
            this.BtnSalir2.Click += new System.EventHandler(this.BtnSalir2_Click);
            // 
            // BtnMaximizar2
            // 
            this.BtnMaximizar2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMaximizar2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMaximizar2.Image = global::prueba_login.Properties.Resources.Maximize_Window_2_48px;
            this.BtnMaximizar2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMaximizar2.Name = "BtnMaximizar2";
            this.BtnMaximizar2.Size = new System.Drawing.Size(23, 22);
            this.BtnMaximizar2.Text = "Maximizar";
            this.BtnMaximizar2.Click += new System.EventHandler(this.BtnMaximizar2_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(19, 22);
            this.toolStripLabel1.Text = "FF";
            // 
            // BtnRestaurar2
            // 
            this.BtnRestaurar2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnRestaurar2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRestaurar2.Image = global::prueba_login.Properties.Resources.Restore_Window_2_48px;
            this.BtnRestaurar2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRestaurar2.Name = "BtnRestaurar2";
            this.BtnRestaurar2.Size = new System.Drawing.Size(23, 22);
            this.BtnRestaurar2.Text = "Restaurar";
            this.BtnRestaurar2.Click += new System.EventHandler(this.BtnRestaurar2_Click);
            // 
            // BtnMinizar2
            // 
            this.BtnMinizar2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMinizar2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMinizar2.Image = global::prueba_login.Properties.Resources.Minimize_Window_2_48px;
            this.BtnMinizar2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMinizar2.Name = "BtnMinizar2";
            this.BtnMinizar2.Size = new System.Drawing.Size(23, 22);
            this.BtnMinizar2.Text = "Minimizar";
            this.BtnMinizar2.Click += new System.EventHandler(this.BtnMinizar2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btnVerOrden);
            this.panel1.Controls.Add(this.lbllog);
            this.panel1.Controls.Add(this.lbltrabajo);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.MaximumSize = new System.Drawing.Size(1720, 728);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 695);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.Image = global::prueba_login.Properties.Resources.boton_de_encendido;
            this.btnsalir.ImageActive = null;
            this.btnsalir.Location = new System.Drawing.Point(27, 30);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(83, 83);
            this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsalir.TabIndex = 6;
            this.btnsalir.TabStop = false;
            this.btnsalir.Zoom = 10;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnVerOrden
            // 
            this.btnVerOrden.Activecolor = System.Drawing.Color.DarkGoldenrod;
            this.btnVerOrden.BackColor = System.Drawing.Color.Gold;
            this.btnVerOrden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerOrden.BorderRadius = 0;
            this.btnVerOrden.ButtonText = "    Ver Ordenes";
            this.btnVerOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerOrden.DisabledColor = System.Drawing.Color.Gray;
            this.btnVerOrden.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVerOrden.Iconimage = global::prueba_login.Properties.Resources.eye__1_;
            this.btnVerOrden.Iconimage_right = null;
            this.btnVerOrden.Iconimage_right_Selected = null;
            this.btnVerOrden.Iconimage_Selected = null;
            this.btnVerOrden.IconMarginLeft = 0;
            this.btnVerOrden.IconMarginRight = 0;
            this.btnVerOrden.IconRightVisible = true;
            this.btnVerOrden.IconRightZoom = 0D;
            this.btnVerOrden.IconVisible = true;
            this.btnVerOrden.IconZoom = 90D;
            this.btnVerOrden.IsTab = false;
            this.btnVerOrden.Location = new System.Drawing.Point(0, 252);
            this.btnVerOrden.Name = "btnVerOrden";
            this.btnVerOrden.Normalcolor = System.Drawing.Color.Gold;
            this.btnVerOrden.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerOrden.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVerOrden.selected = false;
            this.btnVerOrden.Size = new System.Drawing.Size(264, 71);
            this.btnVerOrden.TabIndex = 1;
            this.btnVerOrden.Text = "    Ver Ordenes";
            this.btnVerOrden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerOrden.Textcolor = System.Drawing.Color.Black;
            this.btnVerOrden.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerOrden.Click += new System.EventHandler(this.btnregistro_Click);
            // 
            // lbllog
            // 
            this.lbllog.AutoSize = true;
            this.lbllog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllog.Location = new System.Drawing.Point(23, 128);
            this.lbllog.Name = "lbllog";
            this.lbllog.Size = new System.Drawing.Size(110, 21);
            this.lbllog.TabIndex = 2;
            this.lbllog.Text = "Cerrar Sesion";
            // 
            // lbltrabajo
            // 
            this.lbltrabajo.AutoSize = true;
            this.lbltrabajo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrabajo.Location = new System.Drawing.Point(123, 81);
            this.lbltrabajo.Name = "lbltrabajo";
            this.lbltrabajo.Size = new System.Drawing.Size(96, 21);
            this.lbltrabajo.TabIndex = 0;
            this.lbltrabajo.Text = "Trabajador";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(264, 695);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 27;
            this.lineShape1.X2 = 239;
            this.lineShape1.Y1 = 179;
            this.lineShape1.Y2 = 179;
            // 
            // panelContenedor4
            // 
            this.panelContenedor4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelContenedor4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor4.Location = new System.Drawing.Point(264, 25);
            this.panelContenedor4.Name = "panelContenedor4";
            this.panelContenedor4.Size = new System.Drawing.Size(1016, 695);
            this.panelContenedor4.TabIndex = 2;
            // 
            // Trabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelContenedor4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 726);
            this.Name = "Trabajador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajador";
            this.Load += new System.EventHandler(this.Trabajador_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnSalir2;
        private System.Windows.Forms.ToolStripButton BtnMaximizar2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContenedor4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label lbltrabajo;
        private System.Windows.Forms.Label lbllog;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ToolStripButton BtnRestaurar2;
        private System.Windows.Forms.ToolStripButton BtnMinizar2;
        private Bunifu.Framework.UI.BunifuFlatButton btnVerOrden;
        private Bunifu.Framework.UI.BunifuImageButton btnsalir;
    }
}