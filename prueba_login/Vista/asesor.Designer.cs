namespace prueba_login
{
    partial class Secretaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Secretaria));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnexit = new System.Windows.Forms.ToolStripButton();
            this.btnmaximizar = new System.Windows.Forms.ToolStripButton();
            this.btnnormal = new System.Windows.Forms.ToolStripButton();
            this.btnminimizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btngcli = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btngfx = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnauti = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblog = new System.Windows.Forms.Label();
            this.btnsalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnregistro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lablasesor = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnexit,
            this.btnmaximizar,
            this.btnnormal,
            this.btnminimizar,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1280, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // btnexit
            // 
            this.btnexit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnexit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnexit.Image = global::prueba_login.Properties.Resources.Close_Window__2_48px;
            this.btnexit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(23, 24);
            this.btnexit.Text = "Salir";
            this.btnexit.Click += new System.EventHandler(this.toolStripButton1_Click);
            this.btnexit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton1_MouseDown);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnmaximizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnmaximizar.Image = global::prueba_login.Properties.Resources.Maximize_Window_2_48px;
            this.btnmaximizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(23, 24);
            this.btnmaximizar.Text = "Maximizar";
            this.btnmaximizar.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnnormal
            // 
            this.btnnormal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnnormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnnormal.Image = global::prueba_login.Properties.Resources.Restore_Window_2_48px;
            this.btnnormal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnnormal.Name = "btnnormal";
            this.btnnormal.Size = new System.Drawing.Size(23, 24);
            this.btnnormal.Text = "Restaurar";
            this.btnnormal.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnminimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnminimizar.Image = global::prueba_login.Properties.Resources.Minimize_Window_2_48px;
            this.btnminimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(23, 24);
            this.btnminimizar.Text = "Minimizar";
            this.btnminimizar.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.ForeColor = System.Drawing.Color.White;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(153, 24);
            this.toolStripButton2.Text = "YourOwnWorkshop";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.btngcli);
            this.panel2.Controls.Add(this.btngfx);
            this.panel2.Controls.Add(this.btnauti);
            this.panel2.Controls.Add(this.lblog);
            this.panel2.Controls.Add(this.btnsalir);
            this.panel2.Controls.Add(this.btnregistro);
            this.panel2.Controls.Add(this.lablasesor);
            this.panel2.Controls.Add(this.shapeContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 693);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btngcli
            // 
            this.btngcli.Activecolor = System.Drawing.Color.Gold;
            this.btngcli.BackColor = System.Drawing.Color.Gold;
            this.btngcli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngcli.BorderRadius = 0;
            this.btngcli.ButtonText = "     Grafica de clientes";
            this.btngcli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngcli.DisabledColor = System.Drawing.Color.Gray;
            this.btngcli.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btngcli.Iconcolor = System.Drawing.Color.Transparent;
            this.btngcli.Iconimage = global::prueba_login.Properties.Resources.add_user_button;
            this.btngcli.Iconimage_right = null;
            this.btngcli.Iconimage_right_Selected = null;
            this.btngcli.Iconimage_Selected = null;
            this.btngcli.IconMarginLeft = 0;
            this.btngcli.IconMarginRight = 0;
            this.btngcli.IconRightVisible = true;
            this.btngcli.IconRightZoom = 0D;
            this.btngcli.IconVisible = true;
            this.btngcli.IconZoom = 90D;
            this.btngcli.IsTab = false;
            this.btngcli.Location = new System.Drawing.Point(0, 311);
            this.btngcli.Name = "btngcli";
            this.btngcli.Normalcolor = System.Drawing.Color.Gold;
            this.btngcli.OnHovercolor = System.Drawing.Color.Yellow;
            this.btngcli.OnHoverTextColor = System.Drawing.Color.Black;
            this.btngcli.selected = false;
            this.btngcli.Size = new System.Drawing.Size(264, 71);
            this.btngcli.TabIndex = 9;
            this.btngcli.Text = "     Grafica de clientes";
            this.btngcli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngcli.Textcolor = System.Drawing.Color.Black;
            this.btngcli.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngcli.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btngfx
            // 
            this.btngfx.Activecolor = System.Drawing.Color.Gold;
            this.btngfx.BackColor = System.Drawing.Color.Gold;
            this.btngfx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngfx.BorderRadius = 0;
            this.btngfx.ButtonText = "     Grafica de automoviles";
            this.btngfx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngfx.DisabledColor = System.Drawing.Color.Gray;
            this.btngfx.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btngfx.Iconcolor = System.Drawing.Color.Transparent;
            this.btngfx.Iconimage = global::prueba_login.Properties.Resources.sports_car;
            this.btngfx.Iconimage_right = null;
            this.btngfx.Iconimage_right_Selected = null;
            this.btngfx.Iconimage_Selected = null;
            this.btngfx.IconMarginLeft = 0;
            this.btngfx.IconMarginRight = 0;
            this.btngfx.IconRightVisible = true;
            this.btngfx.IconRightZoom = 0D;
            this.btngfx.IconVisible = true;
            this.btngfx.IconZoom = 90D;
            this.btngfx.IsTab = false;
            this.btngfx.Location = new System.Drawing.Point(0, 551);
            this.btngfx.Name = "btngfx";
            this.btngfx.Normalcolor = System.Drawing.Color.Gold;
            this.btngfx.OnHovercolor = System.Drawing.Color.Yellow;
            this.btngfx.OnHoverTextColor = System.Drawing.Color.Black;
            this.btngfx.selected = false;
            this.btngfx.Size = new System.Drawing.Size(264, 71);
            this.btngfx.TabIndex = 8;
            this.btngfx.Text = "     Grafica de automoviles";
            this.btngfx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngfx.Textcolor = System.Drawing.Color.Black;
            this.btngfx.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngfx.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnauti
            // 
            this.btnauti.Activecolor = System.Drawing.Color.Gold;
            this.btnauti.BackColor = System.Drawing.Color.Gold;
            this.btnauti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnauti.BorderRadius = 0;
            this.btnauti.ButtonText = "     Registro de automoviles";
            this.btnauti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnauti.DisabledColor = System.Drawing.Color.Gray;
            this.btnauti.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnauti.Iconcolor = System.Drawing.Color.Transparent;
            this.btnauti.Iconimage = global::prueba_login.Properties.Resources.sports_car;
            this.btnauti.Iconimage_right = null;
            this.btnauti.Iconimage_right_Selected = null;
            this.btnauti.Iconimage_Selected = null;
            this.btnauti.IconMarginLeft = 0;
            this.btnauti.IconMarginRight = 0;
            this.btnauti.IconRightVisible = true;
            this.btnauti.IconRightZoom = 0D;
            this.btnauti.IconVisible = true;
            this.btnauti.IconZoom = 90D;
            this.btnauti.IsTab = false;
            this.btnauti.Location = new System.Drawing.Point(0, 432);
            this.btnauti.Name = "btnauti";
            this.btnauti.Normalcolor = System.Drawing.Color.Gold;
            this.btnauti.OnHovercolor = System.Drawing.Color.Yellow;
            this.btnauti.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnauti.selected = false;
            this.btnauti.Size = new System.Drawing.Size(264, 71);
            this.btnauti.TabIndex = 2;
            this.btnauti.Text = "     Registro de automoviles";
            this.btnauti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnauti.Textcolor = System.Drawing.Color.Black;
            this.btnauti.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnauti.Click += new System.EventHandler(this.btnauti_Click);
            // 
            // lblog
            // 
            this.lblog.AutoSize = true;
            this.lblog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblog.Location = new System.Drawing.Point(10, 126);
            this.lblog.Name = "lblog";
            this.lblog.Size = new System.Drawing.Size(110, 21);
            this.lblog.TabIndex = 7;
            this.lblog.Text = "Cerrar Sesion";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.Image = global::prueba_login.Properties.Resources.boton_de_encendido;
            this.btnsalir.ImageActive = null;
            this.btnsalir.Location = new System.Drawing.Point(26, 28);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(83, 83);
            this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsalir.TabIndex = 1;
            this.btnsalir.TabStop = false;
            this.btnsalir.Zoom = 10;
            this.btnsalir.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btnregistro
            // 
            this.btnregistro.Activecolor = System.Drawing.Color.Gold;
            this.btnregistro.BackColor = System.Drawing.Color.Gold;
            this.btnregistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistro.BorderRadius = 0;
            this.btnregistro.ButtonText = "     Registro de clientes";
            this.btnregistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistro.DisabledColor = System.Drawing.Color.Gray;
            this.btnregistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnregistro.Iconcolor = System.Drawing.Color.Transparent;
            this.btnregistro.Iconimage = global::prueba_login.Properties.Resources.add_user_button;
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
            this.btnregistro.Location = new System.Drawing.Point(0, 183);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Normalcolor = System.Drawing.Color.Gold;
            this.btnregistro.OnHovercolor = System.Drawing.Color.Yellow;
            this.btnregistro.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnregistro.selected = false;
            this.btnregistro.Size = new System.Drawing.Size(264, 71);
            this.btnregistro.TabIndex = 1;
            this.btnregistro.Text = "     Registro de clientes";
            this.btnregistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistro.Textcolor = System.Drawing.Color.Black;
            this.btnregistro.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click);
            // 
            // lablasesor
            // 
            this.lablasesor.AutoSize = true;
            this.lablasesor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablasesor.Location = new System.Drawing.Point(130, 67);
            this.lablasesor.Name = "lablasesor";
            this.lablasesor.Size = new System.Drawing.Size(60, 21);
            this.lablasesor.TabIndex = 2;
            this.lablasesor.Text = "Asesor";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(264, 693);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 20;
            this.lineShape1.X2 = 232;
            this.lineShape1.Y1 = 160;
            this.lineShape1.Y2 = 160;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(264, 27);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1016, 693);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // Secretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1720, 728);
            this.Name = "Secretaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secretaria";
            this.Load += new System.EventHandler(this.Secretaria_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnexit;
        private System.Windows.Forms.ToolStripButton btnmaximizar;
        private System.Windows.Forms.ToolStripButton btnnormal;
        private System.Windows.Forms.ToolStripButton btnminimizar;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblog;
        private Bunifu.Framework.UI.BunifuImageButton btnsalir;
        private Bunifu.Framework.UI.BunifuFlatButton btnregistro;
        private System.Windows.Forms.Label lablasesor;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel panelContenedor;
        private Bunifu.Framework.UI.BunifuFlatButton btnauti;
        private Bunifu.Framework.UI.BunifuFlatButton btngfx;
        private Bunifu.Framework.UI.BunifuFlatButton btngcli;
    }
}