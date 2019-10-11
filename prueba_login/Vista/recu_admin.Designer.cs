namespace prueba_login
{
    partial class recu_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recu_admin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcifrado = new System.Windows.Forms.TextBox();
            this.btnverificar = new System.Windows.Forms.Button();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtadmin = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnverificarusu = new System.Windows.Forms.Button();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.lblnew = new System.Windows.Forms.Label();
            this.txtnuevacontra = new System.Windows.Forms.TextBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnsalir = new System.Windows.Forms.ToolStripButton();
            this.btnrec = new System.Windows.Forms.ToolStripButton();
            this.btnop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcifrado);
            this.groupBox1.Controls.Add(this.btnverificar);
            this.groupBox1.Controls.Add(this.lblpass);
            this.groupBox1.Controls.Add(this.txtcontra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtadmin);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(475, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtcifrado
            // 
            this.txtcifrado.Location = new System.Drawing.Point(320, 256);
            this.txtcifrado.Name = "txtcifrado";
            this.txtcifrado.Size = new System.Drawing.Size(100, 20);
            this.txtcifrado.TabIndex = 5;
            this.txtcifrado.Visible = false;
            // 
            // btnverificar
            // 
            this.btnverificar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnverificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverificar.Location = new System.Drawing.Point(175, 256);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(81, 26);
            this.btnverificar.TabIndex = 6;
            this.btnverificar.Text = "Verificar";
            this.btnverificar.UseVisualStyleBackColor = false;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.BackColor = System.Drawing.Color.Transparent;
            this.lblpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.Color.White;
            this.lblpass.Location = new System.Drawing.Point(172, 156);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(84, 17);
            this.lblpass.TabIndex = 3;
            this.lblpass.Text = "Contraseña";
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(108, 185);
            this.txtcontra.MaxLength = 20;
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(215, 20);
            this.txtcontra.TabIndex = 5;
            this.txtcontra.TextChanged += new System.EventHandler(this.txtcontra_TextChanged);
            this.txtcontra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontra_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            // 
            // txtadmin
            // 
            this.txtadmin.Location = new System.Drawing.Point(108, 81);
            this.txtadmin.MaxLength = 20;
            this.txtadmin.Name = "txtadmin";
            this.txtadmin.Size = new System.Drawing.Size(215, 20);
            this.txtadmin.TabIndex = 4;
            this.txtadmin.TextChanged += new System.EventHandler(this.txtadmin_TextChanged);
            this.txtadmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtadmin_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnverificarusu);
            this.groupBox2.Controls.Add(this.btnconfirmar);
            this.groupBox2.Controls.Add(this.lblnew);
            this.groupBox2.Controls.Add(this.txtnuevacontra);
            this.groupBox2.Controls.Add(this.lbluser);
            this.groupBox2.Controls.Add(this.txtusuario);
            this.groupBox2.Location = new System.Drawing.Point(11, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 309);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnverificarusu
            // 
            this.btnverificarusu.BackColor = System.Drawing.Color.Goldenrod;
            this.btnverificarusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverificarusu.Location = new System.Drawing.Point(175, 124);
            this.btnverificarusu.Name = "btnverificarusu";
            this.btnverificarusu.Size = new System.Drawing.Size(81, 26);
            this.btnverificarusu.TabIndex = 2;
            this.btnverificarusu.Text = "Verificar";
            this.btnverificarusu.UseVisualStyleBackColor = false;
            this.btnverificarusu.Click += new System.EventHandler(this.btnverificarusu_Click);
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnconfirmar.Enabled = false;
            this.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirmar.Location = new System.Drawing.Point(175, 256);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(81, 26);
            this.btnconfirmar.TabIndex = 8;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // lblnew
            // 
            this.lblnew.AutoSize = true;
            this.lblnew.BackColor = System.Drawing.Color.Transparent;
            this.lblnew.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnew.ForeColor = System.Drawing.Color.White;
            this.lblnew.Location = new System.Drawing.Point(149, 180);
            this.lblnew.Name = "lblnew";
            this.lblnew.Size = new System.Drawing.Size(128, 17);
            this.lblnew.TabIndex = 3;
            this.lblnew.Text = "Nueva contraseña";
            // 
            // txtnuevacontra
            // 
            this.txtnuevacontra.Enabled = false;
            this.txtnuevacontra.Location = new System.Drawing.Point(106, 212);
            this.txtnuevacontra.MaxLength = 20;
            this.txtnuevacontra.Name = "txtnuevacontra";
            this.txtnuevacontra.Size = new System.Drawing.Size(215, 20);
            this.txtnuevacontra.TabIndex = 7;
            this.txtnuevacontra.TextChanged += new System.EventHandler(this.txtnuevacontra_TextChanged);
            this.txtnuevacontra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnuevacontra_KeyPress);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.White;
            this.lbluser.Location = new System.Drawing.Point(186, 51);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(54, 17);
            this.lbluser.TabIndex = 1;
            this.lbluser.Text = "Usuario";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(108, 81);
            this.txtusuario.MaxLength = 20;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(215, 20);
            this.txtusuario.TabIndex = 1;
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnsalir,
            this.btnrec});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(952, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnsalir
            // 
            this.btnsalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnsalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnsalir.Image = global::prueba_login.Properties.Resources.Close_Window__2_48px2;
            this.btnsalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(23, 22);
            this.btnsalir.Text = "Salir";
            this.btnsalir.Click += new System.EventHandler(this.toolStripButton1_Click);
            this.btnsalir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton1_MouseDown);
            // 
            // btnrec
            // 
            this.btnrec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnrec.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrec.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnrec.Image = ((System.Drawing.Image)(resources.GetObject("btnrec.Image")));
            this.btnrec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnrec.Name = "btnrec";
            this.btnrec.Size = new System.Drawing.Size(329, 22);
            this.btnrec.Text = "Recuperacion de contraseña|Intervencion de admin";
            // 
            // btnop
            // 
            this.btnop.BackColor = System.Drawing.Color.Goldenrod;
            this.btnop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnop.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnop.Location = new System.Drawing.Point(345, 390);
            this.btnop.Name = "btnop";
            this.btnop.Size = new System.Drawing.Size(252, 35);
            this.btnop.TabIndex = 10;
            this.btnop.Text = "Volver a opciones";
            this.btnop.UseVisualStyleBackColor = false;
            this.btnop.Click += new System.EventHandler(this.button1_Click);
            // 
            // recu_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.btnop);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "recu_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "recu_admin";
            this.Load += new System.EventHandler(this.recu_admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadmin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Label lblnew;
        private System.Windows.Forms.TextBox txtnuevacontra;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Button btnverificarusu;
        private System.Windows.Forms.TextBox txtcifrado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnsalir;
        private System.Windows.Forms.ToolStripButton btnrec;
        private System.Windows.Forms.Button btnop;
    }
}