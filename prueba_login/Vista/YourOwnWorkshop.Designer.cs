namespace prueba_login
{
    partial class YourOwnWorkshop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YourOwnWorkshop));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnprimeruso = new Bunifu.Framework.UI.BunifuTileButton();
            this.txtcifrado = new System.Windows.Forms.TextBox();
            this.btnrecuperar = new System.Windows.Forms.LinkLabel();
            this.btningresar = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnsalir = new System.Windows.Forms.ToolStripButton();
            this.btnminimizar = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 282);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::prueba_login.Properties.Resources.LogoSinFondo;
            this.pictureBox1.Location = new System.Drawing.Point(29, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnprimeruso);
            this.panel2.Controls.Add(this.txtcifrado);
            this.panel2.Controls.Add(this.btnrecuperar);
            this.panel2.Controls.Add(this.btningresar);
            this.panel2.Controls.Add(this.txtpass);
            this.panel2.Controls.Add(this.txtuser);
            this.panel2.Controls.Add(this.shapeContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(214, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 282);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnprimeruso
            // 
            this.btnprimeruso.BackColor = System.Drawing.Color.Gold;
            this.btnprimeruso.color = System.Drawing.Color.Gold;
            this.btnprimeruso.colorActive = System.Drawing.Color.DimGray;
            this.btnprimeruso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprimeruso.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnprimeruso.ForeColor = System.Drawing.Color.Black;
            this.btnprimeruso.Image = global::prueba_login.Properties.Resources.settings1;
            this.btnprimeruso.ImagePosition = 20;
            this.btnprimeruso.ImageZoom = 35;
            this.btnprimeruso.LabelPosition = 41;
            this.btnprimeruso.LabelText = "Bienvenido al primer uso de sistema";
            this.btnprimeruso.Location = new System.Drawing.Point(91, 32);
            this.btnprimeruso.Margin = new System.Windows.Forms.Padding(6);
            this.btnprimeruso.Name = "btnprimeruso";
            this.btnprimeruso.Size = new System.Drawing.Size(400, 210);
            this.btnprimeruso.TabIndex = 5;
            this.btnprimeruso.Click += new System.EventHandler(this.btnprimeruso_Click);
            // 
            // txtcifrado
            // 
            this.txtcifrado.Location = new System.Drawing.Point(454, 3);
            this.txtcifrado.Name = "txtcifrado";
            this.txtcifrado.Size = new System.Drawing.Size(100, 20);
            this.txtcifrado.TabIndex = 4;
            this.txtcifrado.Visible = false;
            // 
            // btnrecuperar
            // 
            this.btnrecuperar.ActiveLinkColor = System.Drawing.Color.Gold;
            this.btnrecuperar.AutoSize = true;
            this.btnrecuperar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecuperar.LinkColor = System.Drawing.Color.Gray;
            this.btnrecuperar.Location = new System.Drawing.Point(216, 248);
            this.btnrecuperar.Name = "btnrecuperar";
            this.btnrecuperar.Size = new System.Drawing.Size(132, 16);
            this.btnrecuperar.TabIndex = 0;
            this.btnrecuperar.TabStop = true;
            this.btnrecuperar.Text = "Recuperar Contraseña";
            this.btnrecuperar.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.btnrecuperar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnrecuperar_LinkClicked);
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btningresar.FlatAppearance.BorderSize = 0;
            this.btningresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btningresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btningresar.Location = new System.Drawing.Point(101, 183);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(366, 36);
            this.btningresar.TabIndex = 3;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            this.btningresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btningresar_KeyPress);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.Black;
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.White;
            this.txtpass.Location = new System.Drawing.Point(101, 122);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(366, 16);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "CONTRASEÑA";
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            this.txtpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpass_KeyPress);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.Black;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.White;
            this.txtuser.Location = new System.Drawing.Point(101, 39);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(366, 17);
            this.txtuser.TabIndex = 1;
            this.txtuser.Text = "USUARIO";
            this.txtuser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtuser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtuser_KeyDown);
            this.txtuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuser_KeyPress);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(566, 282);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.SelectionColor = System.Drawing.Color.White;
            this.lineShape2.X1 = 101;
            this.lineShape2.X2 = 466;
            this.lineShape2.Y1 = 141;
            this.lineShape2.Y2 = 141;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.Color.White;
            this.lineShape1.X1 = 101;
            this.lineShape1.X2 = 466;
            this.lineShape1.Y1 = 59;
            this.lineShape1.Y2 = 59;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnsalir,
            this.btnminimizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(780, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(87, 22);
            this.toolStripButton1.Text = "Iniciar sesion";
            // 
            // btnsalir
            // 
            this.btnsalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnsalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnsalir.Image = global::prueba_login.Properties.Resources.Close_Window__2_48px;
            this.btnsalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(23, 22);
            this.btnsalir.Text = "Salir";
            this.btnsalir.Click += new System.EventHandler(this.toolStripButton2_Click);
            this.btnsalir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton2_MouseDown);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnminimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnminimizar.Image = global::prueba_login.Properties.Resources.Minimize_Window_2_48px;
            this.btnminimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(23, 22);
            this.btnminimizar.Text = "Minimizar";
            this.btnminimizar.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // YourOwnWorkshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 307);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YourOwnWorkshop";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YourOwnWorkshop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.LinkLabel btnrecuperar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnsalir;
        private System.Windows.Forms.ToolStripButton btnminimizar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox txtcifrado;
        private Bunifu.Framework.UI.BunifuTileButton btnprimeruso;
    }
}

