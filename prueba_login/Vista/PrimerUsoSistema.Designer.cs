﻿namespace prueba_login
{
    partial class PrimerUsoSistema
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimerUsoSistema));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtreplegal = new System.Windows.Forms.TextBox();
            this.pctlogo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnex = new System.Windows.Forms.Button();
            this.btnguadar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtit = new System.Windows.Forms.MaskedTextBox();
            this.validar = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(899, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::prueba_login.Properties.Resources.Close_Window__2_48px2;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(93, 106);
            this.txtname.MaxLength = 25;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(237, 22);
            this.txtname.TabIndex = 1;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(90, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la empresa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(90, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de Identificacion Tributaria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(90, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Represente legal";
            // 
            // txtreplegal
            // 
            this.txtreplegal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreplegal.Location = new System.Drawing.Point(93, 304);
            this.txtreplegal.MaxLength = 25;
            this.txtreplegal.Name = "txtreplegal";
            this.txtreplegal.Size = new System.Drawing.Size(237, 22);
            this.txtreplegal.TabIndex = 3;
            this.txtreplegal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtreplegal_KeyPress);
            // 
            // pctlogo
            // 
            this.pctlogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pctlogo.Location = new System.Drawing.Point(696, 139);
            this.pctlogo.Name = "pctlogo";
            this.pctlogo.Size = new System.Drawing.Size(137, 167);
            this.pctlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctlogo.TabIndex = 7;
            this.pctlogo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(90, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Codigo postal";
            // 
            // txtcod
            // 
            this.txtcod.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.Location = new System.Drawing.Point(93, 403);
            this.txtcod.MaxLength = 5;
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(237, 22);
            this.txtcod.TabIndex = 4;
            this.txtcod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcod_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(397, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Correo electronico";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(400, 106);
            this.txtcorreo.MaxLength = 25;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(237, 22);
            this.txtcorreo.TabIndex = 5;
            this.txtcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcorreo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(397, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Direccion";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(400, 205);
            this.txtdireccion.MaxLength = 500;
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(237, 130);
            this.txtdireccion.TabIndex = 6;
            this.txtdireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdireccion_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(701, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Logo de la empresa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(372, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(309, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Haz clic en examinar para cargar el logo de la empresa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(372, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Todos los campos son obligatorios";
            // 
            // btnex
            // 
            this.btnex.BackColor = System.Drawing.Color.Gold;
            this.btnex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnex.ForeColor = System.Drawing.Color.Black;
            this.btnex.Location = new System.Drawing.Point(696, 322);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(137, 29);
            this.btnex.TabIndex = 7;
            this.btnex.Text = "Examinar";
            this.btnex.UseVisualStyleBackColor = false;
            this.btnex.Click += new System.EventHandler(this.btnex_Click);
            // 
            // btnguadar
            // 
            this.btnguadar.BackColor = System.Drawing.Color.Gold;
            this.btnguadar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguadar.ForeColor = System.Drawing.Color.Black;
            this.btnguadar.Location = new System.Drawing.Point(696, 371);
            this.btnguadar.Name = "btnguadar";
            this.btnguadar.Size = new System.Drawing.Size(137, 29);
            this.btnguadar.TabIndex = 8;
            this.btnguadar.Text = "Guardar y continuar";
            this.btnguadar.UseVisualStyleBackColor = false;
            this.btnguadar.Click += new System.EventHandler(this.btnguadar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtit
            // 
            this.txtit.Location = new System.Drawing.Point(93, 207);
            this.txtit.Mask = "0000-00000000-000-0";
            this.txtit.Name = "txtit";
            this.txtit.Size = new System.Drawing.Size(237, 20);
            this.txtit.TabIndex = 2;
            // 
            // validar
            // 
            this.validar.Image = global::prueba_login.Properties.Resources.check22;
            this.validar.Location = new System.Drawing.Point(643, 110);
            this.validar.Name = "validar";
            this.validar.Size = new System.Drawing.Size(24, 18);
            this.validar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.validar.TabIndex = 31;
            this.validar.TabStop = false;
            this.validar.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PrimerUsoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(899, 480);
            this.Controls.Add(this.validar);
            this.Controls.Add(this.txtit);
            this.Controls.Add(this.btnguadar);
            this.Controls.Add(this.btnex);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pctlogo);
            this.Controls.Add(this.txtreplegal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrimerUsoSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrimerUsoSistema";
            this.Load += new System.EventHandler(this.PrimerUsoSistema_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtreplegal;
        private System.Windows.Forms.PictureBox pctlogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.Button btnguadar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MaskedTextBox txtit;
        private System.Windows.Forms.PictureBox validar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}