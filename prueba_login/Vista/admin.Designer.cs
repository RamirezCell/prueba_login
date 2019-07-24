namespace prueba_login
{
    partial class admin
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
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnAdminProductos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdminEmpleados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnregistro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSupervision = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.ToolStripButton();
            this.btnmaximizar = new System.Windows.Forms.ToolStripButton();
            this.btnnormal = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btncerrar,
            this.btnmaximizar,
            this.btnnormal,
            this.toolStripButton4,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1102, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(149, 22);
            this.toolStripLabel1.Text = "YourOwnWorkshop";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.btnAdminProductos);
            this.panel1.Controls.Add(this.btnAdminEmpleados);
            this.panel1.Controls.Add(this.btnregistro);
            this.panel1.Controls.Add(this.btnSupervision);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 575);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(264, 25);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(838, 575);
            this.panelContenedor.TabIndex = 3;
            // 
            // btnAdminProductos
            // 
            this.btnAdminProductos.Activecolor = System.Drawing.Color.DarkGoldenrod;
            this.btnAdminProductos.BackColor = System.Drawing.Color.Gold;
            this.btnAdminProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdminProductos.BorderRadius = 0;
            this.btnAdminProductos.ButtonText = "   Administracion de productos";
            this.btnAdminProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminProductos.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdminProductos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdminProductos.Iconimage = global::prueba_login.Properties.Resources.truck;
            this.btnAdminProductos.Iconimage_right = null;
            this.btnAdminProductos.Iconimage_right_Selected = null;
            this.btnAdminProductos.Iconimage_Selected = null;
            this.btnAdminProductos.IconMarginLeft = 0;
            this.btnAdminProductos.IconMarginRight = 0;
            this.btnAdminProductos.IconRightVisible = true;
            this.btnAdminProductos.IconRightZoom = 0D;
            this.btnAdminProductos.IconVisible = true;
            this.btnAdminProductos.IconZoom = 90D;
            this.btnAdminProductos.IsTab = false;
            this.btnAdminProductos.Location = new System.Drawing.Point(0, 481);
            this.btnAdminProductos.Name = "btnAdminProductos";
            this.btnAdminProductos.Normalcolor = System.Drawing.Color.Gold;
            this.btnAdminProductos.OnHovercolor = System.Drawing.Color.Yellow;
            this.btnAdminProductos.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAdminProductos.selected = false;
            this.btnAdminProductos.Size = new System.Drawing.Size(264, 71);
            this.btnAdminProductos.TabIndex = 7;
            this.btnAdminProductos.Text = "   Administracion de productos";
            this.btnAdminProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdminProductos.Textcolor = System.Drawing.Color.Black;
            this.btnAdminProductos.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAdminEmpleados
            // 
            this.btnAdminEmpleados.Activecolor = System.Drawing.Color.DarkGoldenrod;
            this.btnAdminEmpleados.BackColor = System.Drawing.Color.Gold;
            this.btnAdminEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdminEmpleados.BorderRadius = 0;
            this.btnAdminEmpleados.ButtonText = "   Administracion de empleados";
            this.btnAdminEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminEmpleados.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdminEmpleados.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdminEmpleados.Iconimage = global::prueba_login.Properties.Resources.office_worker_outline;
            this.btnAdminEmpleados.Iconimage_right = null;
            this.btnAdminEmpleados.Iconimage_right_Selected = null;
            this.btnAdminEmpleados.Iconimage_Selected = null;
            this.btnAdminEmpleados.IconMarginLeft = 0;
            this.btnAdminEmpleados.IconMarginRight = 0;
            this.btnAdminEmpleados.IconRightVisible = true;
            this.btnAdminEmpleados.IconRightZoom = 0D;
            this.btnAdminEmpleados.IconVisible = true;
            this.btnAdminEmpleados.IconZoom = 90D;
            this.btnAdminEmpleados.IsTab = false;
            this.btnAdminEmpleados.Location = new System.Drawing.Point(0, 385);
            this.btnAdminEmpleados.Name = "btnAdminEmpleados";
            this.btnAdminEmpleados.Normalcolor = System.Drawing.Color.Gold;
            this.btnAdminEmpleados.OnHovercolor = System.Drawing.Color.Yellow;
            this.btnAdminEmpleados.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAdminEmpleados.selected = false;
            this.btnAdminEmpleados.Size = new System.Drawing.Size(264, 71);
            this.btnAdminEmpleados.TabIndex = 6;
            this.btnAdminEmpleados.Text = "   Administracion de empleados";
            this.btnAdminEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdminEmpleados.Textcolor = System.Drawing.Color.Black;
            this.btnAdminEmpleados.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminEmpleados.Click += new System.EventHandler(this.btnAdminEmpleados_Click);
            // 
            // btnregistro
            // 
            this.btnregistro.Activecolor = System.Drawing.Color.DarkGoldenrod;
            this.btnregistro.BackColor = System.Drawing.Color.Gold;
            this.btnregistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistro.BorderRadius = 0;
            this.btnregistro.ButtonText = "   Configuracion del sistema";
            this.btnregistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistro.DisabledColor = System.Drawing.Color.Gray;
            this.btnregistro.Iconcolor = System.Drawing.Color.Transparent;
            this.btnregistro.Iconimage = global::prueba_login.Properties.Resources.gears;
            this.btnregistro.Iconimage_right = null;
            this.btnregistro.Iconimage_right_Selected = null;
            this.btnregistro.Iconimage_Selected = null;
            this.btnregistro.IconMarginLeft = 0;
            this.btnregistro.IconMarginRight = 0;
            this.btnregistro.IconRightVisible = true;
            this.btnregistro.IconRightZoom = 0D;
            this.btnregistro.IconVisible = true;
            this.btnregistro.IconZoom = 90D;
            this.btnregistro.IsTab = false;
            this.btnregistro.Location = new System.Drawing.Point(0, 288);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Normalcolor = System.Drawing.Color.Gold;
            this.btnregistro.OnHovercolor = System.Drawing.Color.Yellow;
            this.btnregistro.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnregistro.selected = false;
            this.btnregistro.Size = new System.Drawing.Size(264, 71);
            this.btnregistro.TabIndex = 4;
            this.btnregistro.Text = "   Configuracion del sistema";
            this.btnregistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistro.Textcolor = System.Drawing.Color.Black;
            this.btnregistro.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click);
            // 
            // btnSupervision
            // 
            this.btnSupervision.Activecolor = System.Drawing.Color.DarkGoldenrod;
            this.btnSupervision.BackColor = System.Drawing.Color.Gold;
            this.btnSupervision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupervision.BorderRadius = 0;
            this.btnSupervision.ButtonText = "   Supervision de equipamiento";
            this.btnSupervision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupervision.DisabledColor = System.Drawing.Color.Gray;
            this.btnSupervision.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSupervision.Iconimage = global::prueba_login.Properties.Resources.edit;
            this.btnSupervision.Iconimage_right = null;
            this.btnSupervision.Iconimage_right_Selected = null;
            this.btnSupervision.Iconimage_Selected = null;
            this.btnSupervision.IconMarginLeft = 0;
            this.btnSupervision.IconMarginRight = 0;
            this.btnSupervision.IconRightVisible = true;
            this.btnSupervision.IconRightZoom = 0D;
            this.btnSupervision.IconVisible = true;
            this.btnSupervision.IconZoom = 90D;
            this.btnSupervision.IsTab = false;
            this.btnSupervision.Location = new System.Drawing.Point(0, 175);
            this.btnSupervision.Name = "btnSupervision";
            this.btnSupervision.Normalcolor = System.Drawing.Color.Gold;
            this.btnSupervision.OnHovercolor = System.Drawing.Color.Yellow;
            this.btnSupervision.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSupervision.selected = false;
            this.btnSupervision.Size = new System.Drawing.Size(264, 71);
            this.btnSupervision.TabIndex = 3;
            this.btnSupervision.Text = "   Supervision de equipamiento";
            this.btnSupervision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupervision.Textcolor = System.Drawing.Color.Black;
            this.btnSupervision.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupervision.Click += new System.EventHandler(this.btnSupervision_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prueba_login.Properties.Resources.boton_de_encendido;
            this.pictureBox1.Location = new System.Drawing.Point(23, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btncerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btncerrar.Image = global::prueba_login.Properties.Resources.Close_Window__2_48px;
            this.btncerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(23, 22);
            this.btncerrar.Text = "toolStripButton1";
            this.btncerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseDown);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnmaximizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnmaximizar.Image = global::prueba_login.Properties.Resources.Maximize_Window_2_48px;
            this.btnmaximizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(23, 22);
            this.btnmaximizar.Text = "toolStripButton2";
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btnnormal
            // 
            this.btnnormal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnnormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnnormal.Image = global::prueba_login.Properties.Resources.Restore_Window_2_48px;
            this.btnnormal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnnormal.Name = "btnnormal";
            this.btnnormal.Size = new System.Drawing.Size(23, 22);
            this.btnnormal.Text = "toolStripButton3";
            this.btnnormal.Click += new System.EventHandler(this.btnnormal_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::prueba_login.Properties.Resources.Minimize_Window_2_48px;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 600);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1720, 728);
            this.Name = "admin";
            this.Opacity = 0.9D;
            this.Text = "admin";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btncerrar;
        private System.Windows.Forms.ToolStripButton btnmaximizar;
        private System.Windows.Forms.ToolStripButton btnnormal;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdminEmpleados;
        private Bunifu.Framework.UI.BunifuFlatButton btnregistro;
        private Bunifu.Framework.UI.BunifuFlatButton btnSupervision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContenedor;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdminProductos;
    }
}