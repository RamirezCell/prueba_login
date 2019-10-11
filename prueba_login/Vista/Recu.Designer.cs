namespace prueba_login
{
    partial class Recu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnre = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnverificarusu = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcifrado = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnregresar = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnre});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(525, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // btnre
            // 
            this.btnre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnre.Image = ((System.Drawing.Image)(resources.GetObject("btnre.Image")));
            this.btnre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnre.Name = "btnre";
            this.btnre.Size = new System.Drawing.Size(299, 22);
            this.btnre.Text = "Recuperacion de contraseña|Interna por admin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnverificarusu);
            this.groupBox2.Controls.Add(this.user);
            this.groupBox2.Controls.Add(this.txtusuario);
            this.groupBox2.Location = new System.Drawing.Point(46, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 177);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(186, 51);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(54, 17);
            this.user.TabIndex = 1;
            this.user.Text = "Usuario";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(108, 81);
            this.txtusuario.MaxLength = 20;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(215, 20);
            this.txtusuario.TabIndex = 1;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            // 
            // txtcifrado
            // 
            this.txtcifrado.Location = new System.Drawing.Point(403, 291);
            this.txtcifrado.Name = "txtcifrado";
            this.txtcifrado.Size = new System.Drawing.Size(100, 20);
            this.txtcifrado.TabIndex = 6;
            this.txtcifrado.Visible = false;
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregresar.Location = new System.Drawing.Point(171, 249);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(198, 38);
            this.btnregresar.TabIndex = 3;
            this.btnregresar.Text = "Regresar al Registro de empleados";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // Recu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(525, 323);
            this.Controls.Add(this.txtcifrado);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recu";
            this.Load += new System.EventHandler(this.Recu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcifrado;
        private System.Windows.Forms.Button btnverificarusu;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox txtusuario;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnregresar;
    }
}