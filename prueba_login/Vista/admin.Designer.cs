﻿namespace prueba_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btncerrar = new System.Windows.Forms.ToolStripButton();
            this.btnmaximizar = new System.Windows.Forms.ToolStripButton();
            this.btnnormal = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdminProductos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdminEmpleados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSupervision = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1280, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // btncerrar
            // 
            this.btncerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btncerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btncerrar.Image = global::prueba_login.Properties.Resources.Close_Window__2_48px;
            this.btncerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(23, 22);
            this.btncerrar.Text = "Salir";
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
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
            this.btnmaximizar.Text = "Maximizar";
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
            this.btnnormal.Text = "Restaurar";
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
            this.toolStripButton4.Text = "Minimizar";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
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
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.bunifuFlatButton2);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.btnAdminProductos);
            this.panel1.Controls.Add(this.btnAdminEmpleados);
            this.panel1.Controls.Add(this.btnSupervision);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 695);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::prueba_login.Properties.Resources.boton_de_encendido;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(24, 22);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(83, 83);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.DarkGoldenrod;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Gold;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "  Administracion de vehiculos";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::prueba_login.Properties.Resources.car_front;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 455);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Gold;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Yellow;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(264, 71);
            this.bunifuFlatButton2.TabIndex = 5;
            this.bunifuFlatButton2.Text = "  Administracion de vehiculos";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.DarkGoldenrod;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Gold;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "   Administracion de clientes";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::prueba_login.Properties.Resources.user_inside_bubble_speech;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 378);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Gold;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Yellow;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(264, 71);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Text = "   Administracion de clientes";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
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
            this.btnAdminProductos.Location = new System.Drawing.Point(0, 310);
            this.btnAdminProductos.Name = "btnAdminProductos";
            this.btnAdminProductos.Normalcolor = System.Drawing.Color.Gold;
            this.btnAdminProductos.OnHovercolor = System.Drawing.Color.Yellow;
            this.btnAdminProductos.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAdminProductos.selected = false;
            this.btnAdminProductos.Size = new System.Drawing.Size(264, 71);
            this.btnAdminProductos.TabIndex = 3;
            this.btnAdminProductos.Text = "   Administracion de productos";
            this.btnAdminProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdminProductos.Textcolor = System.Drawing.Color.Black;
            this.btnAdminProductos.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminProductos.Click += new System.EventHandler(this.btnAdminProductos_Click);
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
            this.btnAdminEmpleados.Location = new System.Drawing.Point(0, 229);
            this.btnAdminEmpleados.Name = "btnAdminEmpleados";
            this.btnAdminEmpleados.Normalcolor = System.Drawing.Color.Gold;
            this.btnAdminEmpleados.OnHovercolor = System.Drawing.Color.Yellow;
            this.btnAdminEmpleados.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAdminEmpleados.selected = false;
            this.btnAdminEmpleados.Size = new System.Drawing.Size(264, 71);
            this.btnAdminEmpleados.TabIndex = 2;
            this.btnAdminEmpleados.Text = "   Administracion de empleados";
            this.btnAdminEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdminEmpleados.Textcolor = System.Drawing.Color.Black;
            this.btnAdminEmpleados.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminEmpleados.Click += new System.EventHandler(this.btnAdminEmpleados_Click);
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
            this.btnSupervision.Location = new System.Drawing.Point(0, 152);
            this.btnSupervision.Name = "btnSupervision";
            this.btnSupervision.Normalcolor = System.Drawing.Color.Gold;
            this.btnSupervision.OnHovercolor = System.Drawing.Color.Yellow;
            this.btnSupervision.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSupervision.selected = false;
            this.btnSupervision.Size = new System.Drawing.Size(264, 71);
            this.btnSupervision.TabIndex = 1;
            this.btnSupervision.Text = "   Supervision de equipamiento";
            this.btnSupervision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupervision.Textcolor = System.Drawing.Color.Black;
            this.btnSupervision.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupervision.Click += new System.EventHandler(this.btnSupervision_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cerrar Sesion";
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
            this.panelContenedor.Size = new System.Drawing.Size(1016, 695);
            this.panelContenedor.TabIndex = 3;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // admin
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
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
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
        private Bunifu.Framework.UI.BunifuFlatButton btnSupervision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenedor;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdminProductos;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}