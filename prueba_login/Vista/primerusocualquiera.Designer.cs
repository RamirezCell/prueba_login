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
            this.label11 = new System.Windows.Forms.Label();
            this.txtpassveri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtp2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtp1 = new System.Windows.Forms.TextBox();
            this.txtp3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtxcifrado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtpass
            // 
            this.txtpass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(89, 86);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(231, 23);
            this.txtpass.TabIndex = 24;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(85, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Nueva contraseña";
            // 
            // txtpassveri
            // 
            this.txtpassveri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpassveri.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassveri.Location = new System.Drawing.Point(440, 86);
            this.txtpassveri.Name = "txtpassveri";
            this.txtpassveri.Size = new System.Drawing.Size(231, 23);
            this.txtpassveri.TabIndex = 26;
            this.txtpassveri.TextChanged += new System.EventHandler(this.txtpassveri_TextChanged);
            this.txtpassveri.Enter += new System.EventHandler(this.txtpassveri_Enter);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(436, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Confirmar contraseña";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuFlatButton1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtp2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtp1);
            this.groupBox1.Controls.Add(this.txtp3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(41, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 205);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preguntas de seguridad";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Yellow;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Gold;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "          Guardar y salir";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::prueba_login.Properties.Resources.add;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(224, 134);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Gold;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(249, 52);
            this.bunifuFlatButton1.TabIndex = 35;
            this.bunifuFlatButton1.Text = "          Guardar y salir";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(490, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "¿Cual es su equipo de futbol favorito?";
            // 
            // txtp2
            // 
            this.txtp2.Location = new System.Drawing.Point(254, 82);
            this.txtp2.Name = "txtp2";
            this.txtp2.Size = new System.Drawing.Size(197, 20);
            this.txtp2.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(253, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "¿Cual es su marca de auto favorito?";
            // 
            // txtp1
            // 
            this.txtp1.Location = new System.Drawing.Point(17, 82);
            this.txtp1.Name = "txtp1";
            this.txtp1.Size = new System.Drawing.Size(197, 20);
            this.txtp1.TabIndex = 29;
            // 
            // txtp3
            // 
            this.txtp3.Location = new System.Drawing.Point(493, 82);
            this.txtp3.Name = "txtp3";
            this.txtp3.Size = new System.Drawing.Size(212, 20);
            this.txtp3.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(35, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "¿Cual es su animal favorito?";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.ForeColor = System.Drawing.Color.Gold;
            this.lblpass.Location = new System.Drawing.Point(440, 120);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(143, 13);
            this.lblpass.TabIndex = 29;
            this.lblpass.Text = "Las contraseñas no coiciden";
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtpassveri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "primerusocualquiera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "primerusocualquiera";
            this.Load += new System.EventHandler(this.primerusocualquiera_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtpassveri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtp2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtp1;
        private System.Windows.Forms.TextBox txtp3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtxcifrado;
    }
}