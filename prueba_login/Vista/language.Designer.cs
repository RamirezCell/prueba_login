namespace prueba_login
{
    partial class language
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(language));
            this.lbleselec = new System.Windows.Forms.Label();
            this.rdenglish = new System.Windows.Forms.RadioButton();
            this.rdespanol = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbleselec
            // 
            this.lbleselec.AutoSize = true;
            this.lbleselec.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleselec.ForeColor = System.Drawing.Color.White;
            this.lbleselec.Location = new System.Drawing.Point(181, 32);
            this.lbleselec.Name = "lbleselec";
            this.lbleselec.Size = new System.Drawing.Size(191, 16);
            this.lbleselec.TabIndex = 0;
            this.lbleselec.Text = "Seleccione el lenguaje del sistema";
            // 
            // rdenglish
            // 
            this.rdenglish.AutoSize = true;
            this.rdenglish.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdenglish.ForeColor = System.Drawing.Color.White;
            this.rdenglish.Location = new System.Drawing.Point(83, 178);
            this.rdenglish.Name = "rdenglish";
            this.rdenglish.Size = new System.Drawing.Size(61, 20);
            this.rdenglish.TabIndex = 1;
            this.rdenglish.TabStop = true;
            this.rdenglish.Text = "English";
            this.rdenglish.UseVisualStyleBackColor = true;
            this.rdenglish.CheckedChanged += new System.EventHandler(this.rdenglish_CheckedChanged);
            // 
            // rdespanol
            // 
            this.rdespanol.AutoSize = true;
            this.rdespanol.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdespanol.ForeColor = System.Drawing.Color.White;
            this.rdespanol.Location = new System.Drawing.Point(378, 178);
            this.rdespanol.Name = "rdespanol";
            this.rdespanol.Size = new System.Drawing.Size(68, 20);
            this.rdespanol.TabIndex = 2;
            this.rdespanol.TabStop = true;
            this.rdespanol.Text = "Español";
            this.rdespanol.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::prueba_login.Properties.Resources.ilustracion_bandera_espana_53876_181681;
            this.pictureBox2.Location = new System.Drawing.Point(338, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prueba_login.Properties.Resources.bandera_eeuu;
            this.pictureBox1.Location = new System.Drawing.Point(50, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnlog
            // 
            this.btnlog.BackColor = System.Drawing.Color.Gold;
            this.btnlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlog.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlog.ForeColor = System.Drawing.Color.Black;
            this.btnlog.Location = new System.Drawing.Point(177, 208);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(166, 31);
            this.btnlog.TabIndex = 5;
            this.btnlog.Text = "Ir al login";
            this.btnlog.UseVisualStyleBackColor = false;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // language
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(530, 255);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdespanol);
            this.Controls.Add(this.rdenglish);
            this.Controls.Add(this.lbleselec);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "language";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "language";
            this.Load += new System.EventHandler(this.language_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbleselec;
        private System.Windows.Forms.RadioButton rdenglish;
        private System.Windows.Forms.RadioButton rdespanol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnlog;
    }
}