namespace prueba_login
{
    partial class frmprguntas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprguntas));
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtp1 = new System.Windows.Forms.TextBox();
            this.txtp2 = new System.Windows.Forms.TextBox();
            this.txtp3 = new System.Windows.Forms.TextBox();
            this.btnverificar = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblp1 = new System.Windows.Forms.Label();
            this.lblp2 = new System.Windows.Forms.Label();
            this.lblp3 = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnact = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnregresar = new System.Windows.Forms.Button();
            this.gpnew = new System.Windows.Forms.GroupBox();
            this.txtcifrado = new System.Windows.Forms.TextBox();
            this.gpvalidacion = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.gpnew.SuspendLayout();
            this.gpvalidacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(316, 47);
            this.txtuser.MaxLength = 20;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 20);
            this.txtuser.TabIndex = 1;
            this.txtuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuser_KeyPress);
            // 
            // txtp1
            // 
            this.txtp1.Location = new System.Drawing.Point(20, 125);
            this.txtp1.MaxLength = 25;
            this.txtp1.Name = "txtp1";
            this.txtp1.Size = new System.Drawing.Size(197, 20);
            this.txtp1.TabIndex = 2;
            this.txtp1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtp1_KeyPress);
            // 
            // txtp2
            // 
            this.txtp2.Location = new System.Drawing.Point(259, 125);
            this.txtp2.MaxLength = 25;
            this.txtp2.Name = "txtp2";
            this.txtp2.Size = new System.Drawing.Size(197, 20);
            this.txtp2.TabIndex = 3;
            this.txtp2.TextChanged += new System.EventHandler(this.txtp2_TextChanged);
            this.txtp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtp2_KeyPress);
            // 
            // txtp3
            // 
            this.txtp3.Location = new System.Drawing.Point(496, 125);
            this.txtp3.MaxLength = 25;
            this.txtp3.Name = "txtp3";
            this.txtp3.Size = new System.Drawing.Size(212, 20);
            this.txtp3.TabIndex = 4;
            this.txtp3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtp3_KeyPress);
            // 
            // btnverificar
            // 
            this.btnverificar.BackColor = System.Drawing.Color.Gold;
            this.btnverificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnverificar.Location = new System.Drawing.Point(288, 185);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(125, 23);
            this.btnverificar.TabIndex = 5;
            this.btnverificar.Text = "verifcar";
            this.btnverificar.UseVisualStyleBackColor = false;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbluser.Location = new System.Drawing.Point(340, 26);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(47, 16);
            this.lbluser.TabIndex = 6;
            this.lbluser.Text = "Usuario";
            // 
            // lblp1
            // 
            this.lblp1.AutoSize = true;
            this.lblp1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblp1.Location = new System.Drawing.Point(38, 95);
            this.lblp1.Name = "lblp1";
            this.lblp1.Size = new System.Drawing.Size(161, 16);
            this.lblp1.TabIndex = 7;
            this.lblp1.Text = "¿Cual es su animal favorito?";
            this.lblp1.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblp2
            // 
            this.lblp2.AutoSize = true;
            this.lblp2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblp2.Location = new System.Drawing.Point(256, 96);
            this.lblp2.Name = "lblp2";
            this.lblp2.Size = new System.Drawing.Size(207, 16);
            this.lblp2.TabIndex = 9;
            this.lblp2.Text = "¿Cual es su marca de auto favorito?";
            // 
            // lblp3
            // 
            this.lblp3.AutoSize = true;
            this.lblp3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblp3.Location = new System.Drawing.Point(493, 95);
            this.lblp3.Name = "lblp3";
            this.lblp3.Size = new System.Drawing.Size(215, 16);
            this.lblp3.TabIndex = 10;
            this.lblp3.Text = "¿Cual es su equipo de futbol favorito?";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.Color.White;
            this.lblpass.Location = new System.Drawing.Point(257, 309);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(111, 16);
            this.lblpass.TabIndex = 12;
            this.lblpass.Text = "Nueva contraseña";
            this.lblpass.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtpass
            // 
            this.txtpass.Enabled = false;
            this.txtpass.Location = new System.Drawing.Point(258, 348);
            this.txtpass.MaxLength = 20;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 6;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            this.txtpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpass_KeyPress);
            // 
            // btnact
            // 
            this.btnact.BackColor = System.Drawing.Color.Gold;
            this.btnact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnact.Location = new System.Drawing.Point(414, 348);
            this.btnact.Name = "btnact";
            this.btnact.Size = new System.Drawing.Size(75, 23);
            this.btnact.TabIndex = 13;
            this.btnact.Text = "Actualizar";
            this.btnact.UseVisualStyleBackColor = false;
            this.btnact.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(125, 22);
            this.toolStripButton1.Text = "Recuperar contraseña";
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.Gold;
            this.btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnregresar.Location = new System.Drawing.Point(557, 98);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(161, 23);
            this.btnregresar.TabIndex = 8;
            this.btnregresar.Text = "Regresar a las opciones";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // gpnew
            // 
            this.gpnew.Controls.Add(this.btnregresar);
            this.gpnew.Controls.Add(this.txtcifrado);
            this.gpnew.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpnew.Location = new System.Drawing.Point(35, 283);
            this.gpnew.Name = "gpnew";
            this.gpnew.Size = new System.Drawing.Size(724, 140);
            this.gpnew.TabIndex = 7;
            this.gpnew.TabStop = false;
            this.gpnew.Text = "Ingreso de nueva contraseña";
            // 
            // txtcifrado
            // 
            this.txtcifrado.Enabled = false;
            this.txtcifrado.Location = new System.Drawing.Point(64, 101);
            this.txtcifrado.Name = "txtcifrado";
            this.txtcifrado.Size = new System.Drawing.Size(100, 20);
            this.txtcifrado.TabIndex = 18;
            this.txtcifrado.Visible = false;
            // 
            // gpvalidacion
            // 
            this.gpvalidacion.Controls.Add(this.lblp3);
            this.gpvalidacion.Controls.Add(this.lblp2);
            this.gpvalidacion.Controls.Add(this.txtp3);
            this.gpvalidacion.Controls.Add(this.txtp2);
            this.gpvalidacion.Controls.Add(this.btnverificar);
            this.gpvalidacion.Controls.Add(this.lblp1);
            this.gpvalidacion.Controls.Add(this.txtuser);
            this.gpvalidacion.Controls.Add(this.lbluser);
            this.gpvalidacion.Controls.Add(this.txtp1);
            this.gpvalidacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpvalidacion.Location = new System.Drawing.Point(35, 41);
            this.gpvalidacion.Name = "gpvalidacion";
            this.gpvalidacion.Size = new System.Drawing.Size(724, 236);
            this.gpvalidacion.TabIndex = 17;
            this.gpvalidacion.TabStop = false;
            this.gpvalidacion.Text = "Verificacion de usuario";
            this.gpvalidacion.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // frmprguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnact);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.gpnew);
            this.Controls.Add(this.gpvalidacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmprguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmprguntas";
            this.Load += new System.EventHandler(this.frmprguntas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gpnew.ResumeLayout(false);
            this.gpnew.PerformLayout();
            this.gpvalidacion.ResumeLayout(false);
            this.gpvalidacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtp1;
        private System.Windows.Forms.TextBox txtp2;
        private System.Windows.Forms.TextBox txtp3;
        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblp1;
        private System.Windows.Forms.Label lblp2;
        private System.Windows.Forms.Label lblp3;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnact;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.GroupBox gpnew;
        private System.Windows.Forms.GroupBox gpvalidacion;
        private System.Windows.Forms.TextBox txtcifrado;
    }
}