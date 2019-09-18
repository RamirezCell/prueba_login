namespace prueba_login
{
    partial class recuinterno
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
            this.lblpass = new System.Windows.Forms.Label();
            this.txtpassveri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtxcifrado = new System.Windows.Forms.TextBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.Color.Gold;
            this.lblpass.Location = new System.Drawing.Point(413, 110);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(168, 16);
            this.lblpass.TabIndex = 34;
            this.lblpass.Text = "Las contraseñas no coinciden";
            this.lblpass.Visible = false;
            // 
            // txtpassveri
            // 
            this.txtpassveri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpassveri.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassveri.Location = new System.Drawing.Point(413, 76);
            this.txtpassveri.MaxLength = 20;
            this.txtpassveri.Name = "txtpassveri";
            this.txtpassveri.Size = new System.Drawing.Size(231, 23);
            this.txtpassveri.TabIndex = 32;
            this.txtpassveri.TextChanged += new System.EventHandler(this.txtpassveri_TextChanged);
            this.txtpassveri.Enter += new System.EventHandler(this.txtpassveri_Enter);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(409, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Confirmar contraseña";
            // 
            // txtpass
            // 
            this.txtpass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(62, 76);
            this.txtpass.MaxLength = 20;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(231, 23);
            this.txtpass.TabIndex = 30;
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(58, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Nueva contraseña";
            // 
            // txtxcifrado
            // 
            this.txtxcifrado.Location = new System.Drawing.Point(261, 12);
            this.txtxcifrado.Name = "txtxcifrado";
            this.txtxcifrado.Size = new System.Drawing.Size(100, 20);
            this.txtxcifrado.TabIndex = 37;
            this.txtxcifrado.Visible = false;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(224, 141);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Gold;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(249, 52);
            this.bunifuFlatButton1.TabIndex = 38;
            this.bunifuFlatButton1.Text = "          Guardar y salir";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // recuinterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(704, 216);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.txtxcifrado);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.txtpassveri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "recuinterno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "recuinterno";
            this.Load += new System.EventHandler(this.recuinterno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtpassveri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtxcifrado;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}