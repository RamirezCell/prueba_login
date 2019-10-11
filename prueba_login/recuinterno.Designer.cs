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
            this.lblcn = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lblnew = new System.Windows.Forms.Label();
            this.txtxcifrado = new System.Windows.Forms.TextBox();
            this.btnguardar = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.lblcn.Location = new System.Drawing.Point(409, 37);
            this.lblcn.Name = "lblcn";
            this.lblcn.Size = new System.Drawing.Size(169, 20);
            this.lblcn.TabIndex = 33;
            this.lblcn.Text = "Confirmar contraseña";
            // 
            // txtpass
            // 
            this.txtpass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(62, 76);
            this.txtpass.MaxLength = 20;
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
            this.lblnew.Location = new System.Drawing.Point(58, 37);
            this.lblnew.Name = "lblnew";
            this.lblnew.Size = new System.Drawing.Size(147, 20);
            this.lblnew.TabIndex = 31;
            this.lblnew.Text = "Nueva contraseña";
            // 
            // txtxcifrado
            // 
            this.txtxcifrado.Location = new System.Drawing.Point(261, 12);
            this.txtxcifrado.Name = "txtxcifrado";
            this.txtxcifrado.Size = new System.Drawing.Size(100, 20);
            this.txtxcifrado.TabIndex = 37;
            this.txtxcifrado.Visible = false;
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
            this.btnguardar.Location = new System.Drawing.Point(224, 141);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Normalcolor = System.Drawing.Color.Gold;
            this.btnguardar.OnHovercolor = System.Drawing.Color.Gray;
            this.btnguardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnguardar.selected = false;
            this.btnguardar.Size = new System.Drawing.Size(249, 52);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "          Guardar y salir";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Textcolor = System.Drawing.Color.Black;
            this.btnguardar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // recuinterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(704, 216);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtxcifrado);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.txtpassveri);
            this.Controls.Add(this.lblcn);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.lblnew);
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
        private System.Windows.Forms.Label lblcn;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lblnew;
        private System.Windows.Forms.TextBox txtxcifrado;
        private Bunifu.Framework.UI.BunifuFlatButton btnguardar;
    }
}