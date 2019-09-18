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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnregresar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcifrado = new System.Windows.Forms.TextBox();
            this.txtveri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnenviar = new System.Windows.Forms.Button();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.toolStripButton1,
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(200, 22);
            this.toolStripButton1.Text = "Recuperacion de contraseña";
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtcifrado);
            this.panel1.Controls.Add(this.txtveri);
            this.panel1.Controls.Add(this.label1);
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
            this.btnregresar.TabIndex = 3;
            this.btnregresar.Text = "REGRESAR";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(222, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "VERIFICAR CODIGO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Codigo de verificacion";
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
            this.txtveri.TabIndex = 10;
            this.txtveri.TextChanged += new System.EventHandler(this.txtveri_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario";
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
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txpass);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(628, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 370);
            this.panel2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(104, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "ACTUALIZAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txpass
            // 
            this.txpass.BackColor = System.Drawing.Color.Black;
            this.txpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txpass.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txpass.ForeColor = System.Drawing.SystemColors.Menu;
            this.txpass.Location = new System.Drawing.Point(22, 158);
            this.txpass.MaxLength = 20;
            this.txpass.Name = "txpass";
            this.txpass.Size = new System.Drawing.Size(263, 17);
            this.txpass.TabIndex = 12;
            this.txpass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txpass.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nueva contraseña";
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcifrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtveri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txpass;
        private System.Windows.Forms.Label label3;
    }
}