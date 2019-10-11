namespace prueba_login
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
            this.Salir = new System.Windows.Forms.ToolStripButton();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.nit = new System.Windows.Forms.Label();
            this.rep = new System.Windows.Forms.Label();
            this.txtreplegal = new System.Windows.Forms.TextBox();
            this.pctlogo = new System.Windows.Forms.PictureBox();
            this.cod = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.lbldi = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.Label();
            this.lblcam = new System.Windows.Forms.Label();
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
            this.Salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(899, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Salir
            // 
            this.Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Salir.Image = global::prueba_login.Properties.Resources.Close_Window__2_48px2;
            this.Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(23, 22);
            this.Salir.Text = "Salir";
            this.Salir.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.Control;
            this.lblname.Location = new System.Drawing.Point(90, 59);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(144, 17);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Nombre de la empresa";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // nit
            // 
            this.nit.AutoSize = true;
            this.nit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nit.ForeColor = System.Drawing.SystemColors.Control;
            this.nit.Location = new System.Drawing.Point(90, 158);
            this.nit.Name = "nit";
            this.nit.Size = new System.Drawing.Size(218, 17);
            this.nit.TabIndex = 3;
            this.nit.Text = "Numero de Identificacion Tributaria";
            // 
            // rep
            // 
            this.rep.AutoSize = true;
            this.rep.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rep.ForeColor = System.Drawing.SystemColors.Control;
            this.rep.Location = new System.Drawing.Point(90, 257);
            this.rep.Name = "rep";
            this.rep.Size = new System.Drawing.Size(109, 17);
            this.rep.TabIndex = 5;
            this.rep.Text = "Represente legal";
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
            // cod
            // 
            this.cod.AutoSize = true;
            this.cod.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod.ForeColor = System.Drawing.SystemColors.Control;
            this.cod.Location = new System.Drawing.Point(90, 356);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(92, 17);
            this.cod.TabIndex = 8;
            this.cod.Text = "Codigo postal";
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
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorreo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblcorreo.Location = new System.Drawing.Point(397, 59);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(122, 17);
            this.lblcorreo.TabIndex = 10;
            this.lblcorreo.Text = "Correo electronico";
            this.lblcorreo.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(400, 106);
            this.txtcorreo.MaxLength = 25;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(237, 22);
            this.txtcorreo.TabIndex = 5;
            this.txtcorreo.TextChanged += new System.EventHandler(this.txtcorreo_TextChanged);
            this.txtcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcorreo_KeyPress);
            // 
            // lbldi
            // 
            this.lbldi.AutoSize = true;
            this.lbldi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldi.ForeColor = System.Drawing.SystemColors.Control;
            this.lbldi.Location = new System.Drawing.Point(397, 158);
            this.lbldi.Name = "lbldi";
            this.lbldi.Size = new System.Drawing.Size(66, 17);
            this.lbldi.TabIndex = 12;
            this.lbldi.Text = "Direccion";
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
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.SystemColors.Control;
            this.logo.Location = new System.Drawing.Point(701, 106);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(126, 17);
            this.logo.TabIndex = 14;
            this.logo.Text = "Logo de la empresa";
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip.ForeColor = System.Drawing.Color.Yellow;
            this.tip.Location = new System.Drawing.Point(372, 403);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(309, 16);
            this.tip.TabIndex = 15;
            this.tip.Text = "Haz clic en examinar para cargar el logo de la empresa";
            // 
            // lblcam
            // 
            this.lblcam.AutoSize = true;
            this.lblcam.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcam.ForeColor = System.Drawing.Color.Yellow;
            this.lblcam.Location = new System.Drawing.Point(372, 427);
            this.lblcam.Name = "lblcam";
            this.lblcam.Size = new System.Drawing.Size(187, 16);
            this.lblcam.TabIndex = 16;
            this.lblcam.Text = "Todos los campos son obligatorios";
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
            this.Controls.Add(this.lblcam);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.lbldi);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.pctlogo);
            this.Controls.Add(this.txtreplegal);
            this.Controls.Add(this.rep);
            this.Controls.Add(this.nit);
            this.Controls.Add(this.lblname);
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
        private System.Windows.Forms.ToolStripButton Salir;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label nit;
        private System.Windows.Forms.Label rep;
        private System.Windows.Forms.TextBox txtreplegal;
        private System.Windows.Forms.PictureBox pctlogo;
        private System.Windows.Forms.Label cod;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label lbldi;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Label lblcam;
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.Button btnguadar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MaskedTextBox txtit;
        private System.Windows.Forms.PictureBox validar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}