namespace prueba_login
{
    partial class torre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(torre));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.btnMaximizar = new System.Windows.Forms.ToolStripButton();
            this.btnNormal = new System.Windows.Forms.ToolStripButton();
            this.btnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnasegu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbllog = new System.Windows.Forms.Label();
            this.lbltorre = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCerrar,
            this.btnMaximizar,
            this.btnNormal,
            this.btnMinimizar,
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1280, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCerrar.Image = global::prueba_login.Properties.Resources.Close_Window__2_48px1;
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 22);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMaximizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMaximizar.Image = global::prueba_login.Properties.Resources.Maximize_Window_2_48px;
            this.btnMaximizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(23, 22);
            this.btnMaximizar.Text = "Maximizar";
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNormal.Image = global::prueba_login.Properties.Resources.Restore_Window_2_48px;
            this.btnNormal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(23, 22);
            this.btnNormal.Text = "Restaurar";
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMinimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMinimizar.Image = global::prueba_login.Properties.Resources.Minimize_Window_2_48px;
            this.btnMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(23, 22);
            this.btnMinimizar.Text = "Minimizar";
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.Black;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.ForeColor = System.Drawing.Color.White;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(170, 25);
            this.toolStripTextBox1.Text = "YourOwnWorkshop";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.btnasegu);
            this.panel1.Controls.Add(this.lbllog);
            this.panel1.Controls.Add(this.lbltorre);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 695);
            this.panel1.TabIndex = 3;
            // 
            // btnasegu
            // 
            this.btnasegu.Activecolor = System.Drawing.Color.Gold;
            this.btnasegu.BackColor = System.Drawing.Color.Gold;
            this.btnasegu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnasegu.BorderRadius = 0;
            this.btnasegu.ButtonText = "  Administrador de aseguradora";
            this.btnasegu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnasegu.DisabledColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnasegu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnasegu.Iconimage = global::prueba_login.Properties.Resources.bill__1_;
            this.btnasegu.Iconimage_right = null;
            this.btnasegu.Iconimage_right_Selected = null;
            this.btnasegu.Iconimage_Selected = null;
            this.btnasegu.IconMarginLeft = 0;
            this.btnasegu.IconMarginRight = 0;
            this.btnasegu.IconRightVisible = true;
            this.btnasegu.IconRightZoom = 0D;
            this.btnasegu.IconVisible = true;
            this.btnasegu.IconZoom = 90D;
            this.btnasegu.IsTab = false;
            this.btnasegu.Location = new System.Drawing.Point(0, 332);
            this.btnasegu.Name = "btnasegu";
            this.btnasegu.Normalcolor = System.Drawing.Color.Gold;
            this.btnasegu.OnHovercolor = System.Drawing.Color.Yellow;
            this.btnasegu.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnasegu.selected = false;
            this.btnasegu.Size = new System.Drawing.Size(264, 87);
            this.btnasegu.TabIndex = 10;
            this.btnasegu.Text = "  Administrador de aseguradora";
            this.btnasegu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnasegu.Textcolor = System.Drawing.Color.Black;
            this.btnasegu.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnasegu.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // lbllog
            // 
            this.lbllog.AutoSize = true;
            this.lbllog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllog.Location = new System.Drawing.Point(28, 127);
            this.lbllog.Name = "lbllog";
            this.lbllog.Size = new System.Drawing.Size(110, 21);
            this.lbllog.TabIndex = 8;
            this.lbllog.Text = "Cerrar Sesion";
            // 
            // lbltorre
            // 
            this.lbltorre.AutoSize = true;
            this.lbltorre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltorre.Location = new System.Drawing.Point(140, 72);
            this.lbltorre.Name = "lbltorre";
            this.lbltorre.Size = new System.Drawing.Size(48, 21);
            this.lbltorre.TabIndex = 3;
            this.lbltorre.Text = "Torre";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::prueba_login.Properties.Resources.boton_de_encendido;
            this.btnSalir.Location = new System.Drawing.Point(32, 31);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 83);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 1;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(264, 695);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 26;
            this.lineShape1.X2 = 238;
            this.lineShape1.Y1 = 162;
            this.lineShape1.Y2 = 162;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(264, 25);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1016, 695);
            this.panelContenedor.TabIndex = 4;
            // 
            // torre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1720, 728);
            this.Name = "torre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "torre";
            this.Load += new System.EventHandler(this.torre_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCerrar;
        private System.Windows.Forms.ToolStripButton btnMaximizar;
        private System.Windows.Forms.ToolStripButton btnNormal;
        private System.Windows.Forms.ToolStripButton btnMinimizar;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbllog;
        private System.Windows.Forms.Label lbltorre;
        private System.Windows.Forms.PictureBox btnSalir;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel panelContenedor;
        private Bunifu.Framework.UI.BunifuFlatButton btnasegu;
    }
}