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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btncerrar = new System.Windows.Forms.ToolStripButton();
            this.btnmaximizar = new System.Windows.Forms.ToolStripButton();
            this.btnnormal = new System.Windows.Forms.ToolStripButton();
            this.btnmin = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btncar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdminProductos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdminEmpleados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSupervision = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbllogout = new System.Windows.Forms.Label();
            this.lblocup = new System.Windows.Forms.Label();
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
            this.btnmin,
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
            // btnmin
            // 
            this.btnmin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnmin.Image = global::prueba_login.Properties.Resources.Minimize_Window_2_48px;
            this.btnmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(23, 22);
            this.btnmin.Text = "Minimizar";
            this.btnmin.Click += new System.EventHandler(this.toolStripButton4_Click);
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
            this.panel1.Controls.Add(this.btncar);
            this.panel1.Controls.Add(this.btncliente);
            this.panel1.Controls.Add(this.btnAdminProductos);
            this.panel1.Controls.Add(this.btnAdminEmpleados);
            this.panel1.Controls.Add(this.btnSupervision);
            this.panel1.Controls.Add(this.lbllogout);
            this.panel1.Controls.Add(this.lblocup);
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
            // btncar
            // 
            this.btncar.Activecolor = System.Drawing.Color.DarkGoldenrod;
            this.btncar.BackColor = System.Drawing.Color.Gold;
            this.btncar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncar.BorderRadius = 0;
            this.btncar.ButtonText = "  Administracion de vehiculos";
            this.btncar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncar.DisabledColor = System.Drawing.Color.Gray;
            this.btncar.Iconcolor = System.Drawing.Color.Transparent;
            this.btncar.Iconimage = global::prueba_login.Properties.Resources.car_front;
            this.btncar.Iconimage_right = null;
            this.btncar.Iconimage_right_Selected = null;
            this.btncar.Iconimage_Selected = null;
            this.btncar.IconMarginLeft = 0;
            this.btncar.IconMarginRight = 0;
            this.btncar.IconRightVisible = true;
            this.btncar.IconRightZoom = 0D;
            this.btncar.IconVisible = true;
            this.btncar.IconZoom = 90D;
            this.btncar.IsTab = false;
            this.btncar.Location = new System.Drawing.Point(0, 455);
            this.btncar.Name = "btncar";
            this.btncar.Normalcolor = System.Drawing.Color.Gold;
            this.btncar.OnHovercolor = System.Drawing.Color.Yellow;
            this.btncar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btncar.selected = false;
            this.btncar.Size = new System.Drawing.Size(264, 71);
            this.btncar.TabIndex = 5;
            this.btncar.Text = "  Administracion de vehiculos";
            this.btncar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncar.Textcolor = System.Drawing.Color.Black;
            this.btncar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncar.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btncliente
            // 
            this.btncliente.Activecolor = System.Drawing.Color.DarkGoldenrod;
            this.btncliente.BackColor = System.Drawing.Color.Gold;
            this.btncliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncliente.BorderRadius = 0;
            this.btncliente.ButtonText = "   Administracion de clientes";
            this.btncliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncliente.DisabledColor = System.Drawing.Color.Gray;
            this.btncliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btncliente.Iconimage = global::prueba_login.Properties.Resources.user_inside_bubble_speech;
            this.btncliente.Iconimage_right = null;
            this.btncliente.Iconimage_right_Selected = null;
            this.btncliente.Iconimage_Selected = null;
            this.btncliente.IconMarginLeft = 0;
            this.btncliente.IconMarginRight = 0;
            this.btncliente.IconRightVisible = true;
            this.btncliente.IconRightZoom = 0D;
            this.btncliente.IconVisible = true;
            this.btncliente.IconZoom = 90D;
            this.btncliente.IsTab = false;
            this.btncliente.Location = new System.Drawing.Point(0, 378);
            this.btncliente.Name = "btncliente";
            this.btncliente.Normalcolor = System.Drawing.Color.Gold;
            this.btncliente.OnHovercolor = System.Drawing.Color.Yellow;
            this.btncliente.OnHoverTextColor = System.Drawing.Color.Black;
            this.btncliente.selected = false;
            this.btncliente.Size = new System.Drawing.Size(264, 71);
            this.btncliente.TabIndex = 4;
            this.btncliente.Text = "   Administracion de clientes";
            this.btncliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncliente.Textcolor = System.Drawing.Color.Black;
            this.btncliente.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncliente.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
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
            this.btnSupervision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSupervision.Textcolor = System.Drawing.Color.Black;
            this.btnSupervision.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupervision.Click += new System.EventHandler(this.btnSupervision_Click);
            // 
            // lbllogout
            // 
            this.lbllogout.AutoSize = true;
            this.lbllogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogout.Location = new System.Drawing.Point(13, 119);
            this.lbllogout.Name = "lbllogout";
            this.lbllogout.Size = new System.Drawing.Size(110, 21);
            this.lbllogout.TabIndex = 2;
            this.lbllogout.Text = "Cerrar Sesion";
            // 
            // lblocup
            // 
            this.lblocup.AutoSize = true;
            this.lblocup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblocup.Location = new System.Drawing.Point(137, 61);
            this.lblocup.Name = "lblocup";
            this.lblocup.Size = new System.Drawing.Size(62, 21);
            this.lblocup.TabIndex = 1;
            this.lblocup.Text = "Admin";
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
            this.Load += new System.EventHandler(this.admin_Load);
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
        private System.Windows.Forms.ToolStripButton btnmin;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdminEmpleados;
        private Bunifu.Framework.UI.BunifuFlatButton btnSupervision;
        private System.Windows.Forms.Label lbllogout;
        private System.Windows.Forms.Label lblocup;
        private System.Windows.Forms.Panel panelContenedor;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdminProductos;
        private Bunifu.Framework.UI.BunifuFlatButton btncliente;
        private Bunifu.Framework.UI.BunifuFlatButton btncar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}