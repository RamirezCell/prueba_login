namespace prueba_login
{
    partial class recu_contra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recu_contra));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnrecu = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnregresar = new System.Windows.Forms.Button();
            this.btncod = new System.Windows.Forms.Button();
            this.veri = new System.Windows.Forms.Label();
            this.txtcifrado = new System.Windows.Forms.TextBox();
            this.txtveri = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnenviar = new System.Windows.Forms.Button();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtt = new System.Windows.Forms.TextBox();
            this.veripass = new System.Windows.Forms.Label();
            this.upd = new System.Windows.Forms.Button();
            this.txpass = new System.Windows.Forms.TextBox();
            this.newpass = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnrecu,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(949, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // btnrecu
            // 
            this.btnrecu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnrecu.Enabled = false;
            this.btnrecu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecu.ForeColor = System.Drawing.Color.White;
            this.btnrecu.Image = ((System.Drawing.Image)(resources.GetObject("btnrecu.Image")));
            this.btnrecu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnrecu.Name = "btnrecu";
            this.btnrecu.Size = new System.Drawing.Size(200, 22);
            this.btnrecu.Text = "Recuperacion de contraseña";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::prueba_login.Properties.Resources.Close_Window__2_48px;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Salir";
            this.toolStripButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton2_MouseDown);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::prueba_login.Properties.Resources.Minimize_Window_2_48px;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Minimizar";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.btnregresar);
            this.panel1.Controls.Add(this.btncod);
            this.panel1.Controls.Add(this.veri);
            this.panel1.Controls.Add(this.txtcifrado);
            this.panel1.Controls.Add(this.txtveri);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.lblresult);
            this.panel1.Controls.Add(this.btnenviar);
            this.panel1.Controls.Add(this.txtusuario);
            this.panel1.Location = new System.Drawing.Point(34, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 370);
            this.panel1.TabIndex = 1;
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnregresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnregresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnregresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.ForeColor = System.Drawing.Color.White;
            this.btnregresar.Location = new System.Drawing.Point(451, 323);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(104, 30);
            this.btnregresar.TabIndex = 8;
            this.btnregresar.Text = "REGRESAR";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btncod
            // 
            this.btncod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btncod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btncod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btncod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btncod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncod.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncod.ForeColor = System.Drawing.Color.White;
            this.btncod.Location = new System.Drawing.Point(222, 323);
            this.btncod.Name = "btncod";
            this.btncod.Size = new System.Drawing.Size(156, 30);
            this.btncod.TabIndex = 4;
            this.btncod.Text = "VERIFICAR CODIGO";
            this.btncod.UseVisualStyleBackColor = false;
            this.btncod.Click += new System.EventHandler(this.button1_Click);
            // 
            // veri
            // 
            this.veri.AutoSize = true;
            this.veri.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veri.Location = new System.Drawing.Point(144, 255);
            this.veri.Name = "veri";
            this.veri.Size = new System.Drawing.Size(132, 16);
            this.veri.TabIndex = 11;
            this.veri.Text = "Codigo de verificacion";
            // 
            // txtcifrado
            // 
            this.txtcifrado.Location = new System.Drawing.Point(31, 329);
            this.txtcifrado.Name = "txtcifrado";
            this.txtcifrado.Size = new System.Drawing.Size(100, 20);
            this.txtcifrado.TabIndex = 4;
            this.txtcifrado.Visible = false;
            this.txtcifrado.TextChanged += new System.EventHandler(this.txtcifrado_TextChanged);
            // 
            // txtveri
            // 
            this.txtveri.BackColor = System.Drawing.Color.Black;
            this.txtveri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtveri.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtveri.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtveri.Location = new System.Drawing.Point(147, 281);
            this.txtveri.MaxLength = 4;
            this.txtveri.Name = "txtveri";
            this.txtveri.Size = new System.Drawing.Size(308, 17);
            this.txtveri.TabIndex = 3;
            this.txtveri.TextChanged += new System.EventHandler(this.txtveri_TextChanged_1);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(144, 24);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(47, 16);
            this.user.TabIndex = 7;
            this.user.Text = "Usuario";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(122, 208);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(62, 16);
            this.lblresult.TabIndex = 5;
            this.lblresult.Text = "Resultado";
            this.lblresult.Click += new System.EventHandler(this.lblresult_Click);
            // 
            // btnenviar
            // 
            this.btnenviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnenviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnenviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnenviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenviar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviar.ForeColor = System.Drawing.Color.White;
            this.btnenviar.Location = new System.Drawing.Point(173, 131);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(259, 30);
            this.btnenviar.TabIndex = 2;
            this.btnenviar.Text = "ENVIAR";
            this.btnenviar.UseVisualStyleBackColor = false;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.Black;
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtusuario.Location = new System.Drawing.Point(147, 50);
            this.txtusuario.MaxLength = 20;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(308, 17);
            this.txtusuario.TabIndex = 1;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            this.txtusuario.Enter += new System.EventHandler(this.txtusuario_Enter);
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            this.txtusuario.Leave += new System.EventHandler(this.txtusuario_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.lblpass);
            this.panel2.Controls.Add(this.txtt);
            this.panel2.Controls.Add(this.veripass);
            this.panel2.Controls.Add(this.upd);
            this.panel2.Controls.Add(this.txpass);
            this.panel2.Controls.Add(this.newpass);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(628, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 370);
            this.panel2.TabIndex = 2;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.Color.Black;
            this.lblpass.Location = new System.Drawing.Point(117, 217);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(168, 16);
            this.lblpass.TabIndex = 35;
            this.lblpass.Text = "Las contraseñas no coinciden";
            this.lblpass.Visible = false;
            // 
            // txtt
            // 
            this.txtt.BackColor = System.Drawing.Color.Black;
            this.txtt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtt.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtt.Location = new System.Drawing.Point(22, 108);
            this.txtt.MaxLength = 20;
            this.txtt.Name = "txtt";
            this.txtt.Size = new System.Drawing.Size(263, 17);
            this.txtt.TabIndex = 5;
            this.txtt.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // veripass
            // 
            this.veripass.AutoSize = true;
            this.veripass.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veripass.Location = new System.Drawing.Point(97, 167);
            this.veripass.Name = "veripass";
            this.veripass.Size = new System.Drawing.Size(115, 16);
            this.veripass.TabIndex = 13;
            this.veripass.Text = "Verificar contraseña";
            // 
            // upd
            // 
            this.upd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.upd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.upd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.upd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.upd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upd.ForeColor = System.Drawing.Color.White;
            this.upd.Location = new System.Drawing.Point(104, 295);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(104, 30);
            this.upd.TabIndex = 7;
            this.upd.Text = "ACTUALIZAR";
            this.upd.UseVisualStyleBackColor = false;
            this.upd.Click += new System.EventHandler(this.button2_Click);
            // 
            // txpass
            // 
            this.txpass.BackColor = System.Drawing.Color.Black;
            this.txpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txpass.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txpass.ForeColor = System.Drawing.SystemColors.Menu;
            this.txpass.Location = new System.Drawing.Point(22, 197);
            this.txpass.MaxLength = 20;
            this.txpass.Name = "txpass";
            this.txpass.Size = new System.Drawing.Size(263, 17);
            this.txpass.TabIndex = 6;
            this.txpass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txpass.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // newpass
            // 
            this.newpass.AutoSize = true;
            this.newpass.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass.Location = new System.Drawing.Point(97, 80);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(111, 16);
            this.newpass.TabIndex = 12;
            this.newpass.Text = "Nueva contraseña";
            // 
            // recu_contra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(949, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "recu_contra";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "recu_contra";
            this.Load += new System.EventHandler(this.recu_contra_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton btnrecu;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox txtcifrado;
        private System.Windows.Forms.Label veri;
        private System.Windows.Forms.TextBox txtveri;
        private System.Windows.Forms.Button btncod;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button upd;
        private System.Windows.Forms.TextBox txpass;
        private System.Windows.Forms.Label newpass;
        private System.Windows.Forms.Label veripass;
        private System.Windows.Forms.TextBox txtt;
        private System.Windows.Forms.Label lblpass;
    }
}