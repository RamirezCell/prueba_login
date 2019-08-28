namespace prueba_login
{
    partial class recuadmin
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
            this.txtadmin = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcontrase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.btnverificar = new System.Windows.Forms.Button();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtadmin
            // 
            this.txtadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadmin.ForeColor = System.Drawing.Color.White;
            this.txtadmin.Location = new System.Drawing.Point(102, 67);
            this.txtadmin.Name = "txtadmin";
            this.txtadmin.Size = new System.Drawing.Size(223, 22);
            this.txtadmin.TabIndex = 0;
            this.txtadmin.Text = "Admin";
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(102, 148);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(223, 20);
            this.txtcontra.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(179, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnverificar);
            this.groupBox1.Controls.Add(this.txtcontra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtadmin);
            this.groupBox1.Location = new System.Drawing.Point(56, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 278);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnconfirmar);
            this.groupBox2.Controls.Add(this.txtcontrase);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtusuario);
            this.groupBox2.Location = new System.Drawing.Point(56, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 278);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // txtcontrase
            // 
            this.txtcontrase.Location = new System.Drawing.Point(127, 148);
            this.txtcontrase.Name = "txtcontrase";
            this.txtcontrase.Size = new System.Drawing.Size(223, 20);
            this.txtcontrase.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(172, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nueva contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(172, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre de usuario";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.Color.White;
            this.txtusuario.Location = new System.Drawing.Point(127, 67);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(223, 22);
            this.txtusuario.TabIndex = 0;
            this.txtusuario.Text = "Admin";
            // 
            // btnverificar
            // 
            this.btnverificar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnverificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverificar.Location = new System.Drawing.Point(172, 223);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(75, 23);
            this.btnverificar.TabIndex = 5;
            this.btnverificar.Text = "Verificar";
            this.btnverificar.UseVisualStyleBackColor = false;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirmar.Location = new System.Drawing.Point(194, 223);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnconfirmar.TabIndex = 6;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            // 
            // recuadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(535, 576);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "recuadmin";
            this.Text = "recuadmin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtadmin;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.TextBox txtcontrase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtusuario;
    }
}