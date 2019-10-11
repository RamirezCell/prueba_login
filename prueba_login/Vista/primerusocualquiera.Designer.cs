namespace prueba_login
{
    partial class primerusocualquiera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(primerusocualquiera));
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lblnew = new System.Windows.Forms.Label();
            this.txtpassveri = new System.Windows.Forms.TextBox();
            this.lblcn = new System.Windows.Forms.Label();
            this.grppre = new System.Windows.Forms.GroupBox();
            this.btnguardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblp3 = new System.Windows.Forms.Label();
            this.txtp2 = new System.Windows.Forms.TextBox();
            this.lblp2 = new System.Windows.Forms.Label();
            this.txtp1 = new System.Windows.Forms.TextBox();
            this.txtp3 = new System.Windows.Forms.TextBox();
            this.lblp1 = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtxcifrado = new System.Windows.Forms.TextBox();
            this.grppre.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtpass
            // 
            this.txtpass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(89, 86);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(231, 23);
            this.txtpass.TabIndex = 1;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            // 
            // lblnew
            // 
            this.lblnew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnew.AutoSize = true;
            this.lblnew.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnew.ForeColor = System.Drawing.Color.White;
            this.lblnew.Location = new System.Drawing.Point(85, 47);
            this.lblnew.Name = "lblnew";
            this.lblnew.Size = new System.Drawing.Size(147, 20);
            this.lblnew.TabIndex = 25;
            this.lblnew.Text = "Nueva contraseña";
            // 
            // txtpassveri
            // 
            this.txtpassveri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpassveri.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassveri.Location = new System.Drawing.Point(440, 86);
            this.txtpassveri.Name = "txtpassveri";
            this.txtpassveri.Size = new System.Drawing.Size(231, 23);
            this.txtpassveri.TabIndex = 2;
            this.txtpassveri.TextChanged += new System.EventHandler(this.txtpassveri_TextChanged);
            this.txtpassveri.Enter += new System.EventHandler(this.txtpassveri_Enter);
            // 
            // lblcn
            // 
            this.lblcn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcn.AutoSize = true;
            this.lblcn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcn.ForeColor = System.Drawing.Color.White;
            this.lblcn.Location = new System.Drawing.Point(436, 47);
            this.lblcn.Name = "lblcn";
            this.lblcn.Size = new System.Drawing.Size(169, 20);
            this.lblcn.TabIndex = 27;
            this.lblcn.Text = "Confirmar contraseña";
            this.lblcn.Click += new System.EventHandler(this.label1_Click);
            // 
            // grppre
            // 
            this.grppre.Controls.Add(this.btnguardar);
            this.grppre.Controls.Add(this.lblp3);
            this.grppre.Controls.Add(this.txtp2);
            this.grppre.Controls.Add(this.lblp2);
            this.grppre.Controls.Add(this.txtp1);
            this.grppre.Controls.Add(this.txtp3);
            this.grppre.Controls.Add(this.lblp1);
            this.grppre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grppre.Location = new System.Drawing.Point(41, 152);
            this.grppre.Name = "grppre";
            this.grppre.Size = new System.Drawing.Size(722, 205);
            this.grppre.TabIndex = 28;
            this.grppre.TabStop = false;
            this.grppre.Text = "Preguntas de seguridad";
            // 
            // btnguardar
            // 
            this.btnguardar.Activecolor = System.Drawing.Color.Yellow;
            this.btnguardar.BackColor = System.Drawing.Color.Gold;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.BorderRadius = 0;
            this.btnguardar.ButtonText = "          Guardar y salir";
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnguardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnguardar.Iconimage = global::prueba_login.Properties.Resources.add;
            this.btnguardar.Iconimage_right = null;
            this.btnguardar.Iconimage_right_Selected = null;
            this.btnguardar.Iconimage_Selected = null;
            this.btnguardar.IconMarginLeft = 0;
            this.btnguardar.IconMarginRight = 0;
            this.btnguardar.IconRightVisible = true;
            this.btnguardar.IconRightZoom = 0D;
            this.btnguardar.IconVisible = true;
            this.btnguardar.IconZoom = 90D;
            this.btnguardar.IsTab = false;
            this.btnguardar.Location = new System.Drawing.Point(224, 134);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Normalcolor = System.Drawing.Color.Gold;
            this.btnguardar.OnHovercolor = System.Drawing.Color.Gray;
            this.btnguardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnguardar.selected = false;
            this.btnguardar.Size = new System.Drawing.Size(249, 52);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "          Guardar y salir";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Textcolor = System.Drawing.Color.Black;
            this.btnguardar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // lblp3
            // 
            this.lblp3.AutoSize = true;
            this.lblp3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblp3.Location = new System.Drawing.Point(490, 52);
            this.lblp3.Name = "lblp3";
            this.lblp3.Size = new System.Drawing.Size(215, 16);
            this.lblp3.TabIndex = 34;
            this.lblp3.Text = "¿Cual es su equipo de futbol favorito?";
            // 
            // txtp2
            // 
            this.txtp2.Location = new System.Drawing.Point(254, 82);
            this.txtp2.Name = "txtp2";
            this.txtp2.Size = new System.Drawing.Size(197, 20);
            this.txtp2.TabIndex = 4;
            this.txtp2.TextChanged += new System.EventHandler(this.txtp2_TextChanged);
            // 
            // lblp2
            // 
            this.lblp2.AutoSize = true;
            this.lblp2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblp2.Location = new System.Drawing.Point(253, 53);
            this.lblp2.Name = "lblp2";
            this.lblp2.Size = new System.Drawing.Size(207, 16);
            this.lblp2.TabIndex = 33;
            this.lblp2.Text = "¿Cual es su marca de auto favorito?";
            // 
            // txtp1
            // 
            this.txtp1.Location = new System.Drawing.Point(17, 82);
            this.txtp1.Name = "txtp1";
            this.txtp1.Size = new System.Drawing.Size(197, 20);
            this.txtp1.TabIndex = 3;
            // 
            // txtp3
            // 
            this.txtp3.Location = new System.Drawing.Point(493, 82);
            this.txtp3.Name = "txtp3";
            this.txtp3.Size = new System.Drawing.Size(212, 20);
            this.txtp3.TabIndex = 5;
            // 
            // lblp1
            // 
            this.lblp1.AutoSize = true;
            this.lblp1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblp1.Location = new System.Drawing.Point(35, 52);
            this.lblp1.Name = "lblp1";
            this.lblp1.Size = new System.Drawing.Size(161, 16);
            this.lblp1.TabIndex = 32;
            this.lblp1.Text = "¿Cual es su animal favorito?";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.Color.Gold;
            this.lblpass.Location = new System.Drawing.Point(440, 120);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(168, 16);
            this.lblpass.TabIndex = 29;
            this.lblpass.Text = "Las contraseñas no coinciden";
            this.lblpass.Visible = false;
            this.lblpass.Click += new System.EventHandler(this.lblpass_Click);
            // 
            // txtxcifrado
            // 
            this.txtxcifrado.Location = new System.Drawing.Point(617, 12);
            this.txtxcifrado.Name = "txtxcifrado";
            this.txtxcifrado.Size = new System.Drawing.Size(100, 20);
            this.txtxcifrado.TabIndex = 36;
            this.txtxcifrado.Visible = false;
            // 
            // primerusocualquiera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.txtxcifrado);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.grppre);
            this.Controls.Add(this.txtpassveri);
            this.Controls.Add(this.lblcn);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.lblnew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "primerusocualquiera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "primerusocualquiera";
            this.Load += new System.EventHandler(this.primerusocualquiera_Load);
            this.grppre.ResumeLayout(false);
            this.grppre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lblnew;
        private System.Windows.Forms.TextBox txtpassveri;
        private System.Windows.Forms.Label lblcn;
        private System.Windows.Forms.GroupBox grppre;
        private System.Windows.Forms.Label lblp3;
        private System.Windows.Forms.TextBox txtp2;
        private System.Windows.Forms.Label lblp2;
        private System.Windows.Forms.TextBox txtp1;
        private System.Windows.Forms.TextBox txtp3;
        private System.Windows.Forms.Label lblp1;
        private Bunifu.Framework.UI.BunifuFlatButton btnguardar;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtxcifrado;
    }
}