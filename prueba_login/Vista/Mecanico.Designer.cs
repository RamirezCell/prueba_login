namespace prueba_login
{
    partial class Mecanico
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnSalir3 = new System.Windows.Forms.ToolStripButton();
            this.BtnMaximizar3 = new System.Windows.Forms.ToolStripButton();
            this.BtnRestaurar3 = new System.Windows.Forms.ToolStripButton();
            this.BtnMinizar3 = new System.Windows.Forms.ToolStripButton();
            this.panelSecundario = new System.Windows.Forms.Panel();
            this.btnsalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.btningreso = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnregistro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panelContenedor2 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.panelSecundario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSalir3,
            this.BtnMaximizar3,
            this.BtnRestaurar3,
            this.BtnMinizar3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1102, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // BtnSalir3
            // 
            this.BtnSalir3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnSalir3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSalir3.Image = global::prueba_login.Properties.Resources.Close_Window__2_48px;
            this.BtnSalir3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSalir3.Name = "BtnSalir3";
            this.BtnSalir3.Size = new System.Drawing.Size(23, 22);
            this.BtnSalir3.Text = "Salir";
            this.BtnSalir3.Click += new System.EventHandler(this.BtnSalir3_Click);
            // 
            // BtnMaximizar3
            // 
            this.BtnMaximizar3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMaximizar3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMaximizar3.Image = global::prueba_login.Properties.Resources.Maximize_Window_2_48px;
            this.BtnMaximizar3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMaximizar3.Name = "BtnMaximizar3";
            this.BtnMaximizar3.Size = new System.Drawing.Size(23, 22);
            this.BtnMaximizar3.Text = "Maximizar";
            this.BtnMaximizar3.Click += new System.EventHandler(this.BtnMaximizar3_Click);
            // 
            // BtnRestaurar3
            // 
            this.BtnRestaurar3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnRestaurar3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRestaurar3.Image = global::prueba_login.Properties.Resources.Restore_Window_2_48px;
            this.BtnRestaurar3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRestaurar3.Name = "BtnRestaurar3";
            this.BtnRestaurar3.Size = new System.Drawing.Size(23, 22);
            this.BtnRestaurar3.Text = "Restaurar";
            this.BtnRestaurar3.Click += new System.EventHandler(this.BtnRestaurar3_Click);
            // 
            // BtnMinizar3
            // 
            this.BtnMinizar3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMinizar3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMinizar3.Image = global::prueba_login.Properties.Resources.Minimize_Window_2_48px;
            this.BtnMinizar3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMinizar3.Name = "BtnMinizar3";
            this.BtnMinizar3.Size = new System.Drawing.Size(23, 22);
            this.BtnMinizar3.Text = "Minimizar";
            this.BtnMinizar3.Click += new System.EventHandler(this.BtnMinizar3_Click);
            // 
            // panelSecundario
            // 
            this.panelSecundario.BackColor = System.Drawing.Color.Gold;
            this.panelSecundario.Controls.Add(this.btnsalir);
            this.panelSecundario.Controls.Add(this.btningreso);
            this.panelSecundario.Controls.Add(this.btnregistro);
            this.panelSecundario.Controls.Add(this.label2);
            this.panelSecundario.Controls.Add(this.label1);
            this.panelSecundario.Controls.Add(this.shapeContainer1);
            this.panelSecundario.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSecundario.Location = new System.Drawing.Point(0, 25);
            this.panelSecundario.Name = "panelSecundario";
            this.panelSecundario.Size = new System.Drawing.Size(264, 550);
            this.panelSecundario.TabIndex = 1;
            this.panelSecundario.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.Image = global::prueba_login.Properties.Resources.boton_de_encendido;
            this.btnsalir.ImageActive = null;
            this.btnsalir.Location = new System.Drawing.Point(25, 22);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(83, 83);
            this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsalir.TabIndex = 14;
            this.btnsalir.TabStop = false;
            this.btnsalir.Zoom = 10;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btningreso
            // 
            this.btningreso.Activecolor = System.Drawing.Color.DarkGoldenrod;
            this.btningreso.BackColor = System.Drawing.Color.Black;
            this.btningreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btningreso.BorderRadius = 0;
            this.btningreso.ButtonText = "Control De Calidad";
            this.btningreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btningreso.DisabledColor = System.Drawing.Color.Gray;
            this.btningreso.Iconcolor = System.Drawing.Color.Transparent;
            this.btningreso.Iconimage = global::prueba_login.Properties.Resources.check;
            this.btningreso.Iconimage_right = null;
            this.btningreso.Iconimage_right_Selected = null;
            this.btningreso.Iconimage_Selected = null;
            this.btningreso.IconMarginLeft = 0;
            this.btningreso.IconMarginRight = 0;
            this.btningreso.IconRightVisible = true;
            this.btningreso.IconRightZoom = 0D;
            this.btningreso.IconVisible = true;
            this.btningreso.IconZoom = 90D;
            this.btningreso.IsTab = false;
            this.btningreso.Location = new System.Drawing.Point(-3, 381);
            this.btningreso.Name = "btningreso";
            this.btningreso.Normalcolor = System.Drawing.Color.Black;
            this.btningreso.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btningreso.OnHoverTextColor = System.Drawing.Color.White;
            this.btningreso.selected = false;
            this.btningreso.Size = new System.Drawing.Size(267, 71);
            this.btningreso.TabIndex = 12;
            this.btningreso.Text = "Control De Calidad";
            this.btningreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btningreso.Textcolor = System.Drawing.Color.White;
            this.btningreso.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningreso.Click += new System.EventHandler(this.btningreso_Click);
            // 
            // btnregistro
            // 
            this.btnregistro.Activecolor = System.Drawing.Color.DarkGoldenrod;
            this.btnregistro.BackColor = System.Drawing.Color.Black;
            this.btnregistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistro.BorderRadius = 0;
            this.btnregistro.ButtonText = "   Registro De Vehiculos";
            this.btnregistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistro.DisabledColor = System.Drawing.Color.Gray;
            this.btnregistro.Iconcolor = System.Drawing.Color.Transparent;
            this.btnregistro.Iconimage = global::prueba_login.Properties.Resources.carro_compacto;
            this.btnregistro.Iconimage_right = null;
            this.btnregistro.Iconimage_right_Selected = null;
            this.btnregistro.Iconimage_Selected = null;
            this.btnregistro.IconMarginLeft = 0;
            this.btnregistro.IconMarginRight = 0;
            this.btnregistro.IconRightVisible = true;
            this.btnregistro.IconRightZoom = 0D;
            this.btnregistro.IconVisible = true;
            this.btnregistro.IconZoom = 90D;
            this.btnregistro.IsTab = false;
            this.btnregistro.Location = new System.Drawing.Point(0, 202);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Normalcolor = System.Drawing.Color.Black;
            this.btnregistro.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnregistro.OnHoverTextColor = System.Drawing.Color.White;
            this.btnregistro.selected = false;
            this.btnregistro.Size = new System.Drawing.Size(264, 71);
            this.btnregistro.TabIndex = 11;
            this.btnregistro.Text = "   Registro De Vehiculos";
            this.btnregistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistro.Textcolor = System.Drawing.Color.White;
            this.btnregistro.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Salir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(134, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mecanico";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(264, 550);
            this.shapeContainer1.TabIndex = 13;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 25;
            this.lineShape1.X2 = 237;
            this.lineShape1.Y1 = 155;
            this.lineShape1.Y2 = 155;
            // 
            // panelContenedor2
            // 
            this.panelContenedor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelContenedor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor2.ForeColor = System.Drawing.Color.Transparent;
            this.panelContenedor2.Location = new System.Drawing.Point(264, 25);
            this.panelContenedor2.Name = "panelContenedor2";
            this.panelContenedor2.Size = new System.Drawing.Size(838, 550);
            this.panelContenedor2.TabIndex = 2;
            this.panelContenedor2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor2_Paint);
            // 
            // Mecanico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 575);
            this.Controls.Add(this.panelContenedor2);
            this.Controls.Add(this.panelSecundario);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1720, 728);
            this.Name = "Mecanico";
            this.Opacity = 0.9D;
            this.Text = "Mecanico";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelSecundario.ResumeLayout(false);
            this.panelSecundario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnSalir3;
        private System.Windows.Forms.ToolStripButton BtnMaximizar3;
        private System.Windows.Forms.Panel panelSecundario;
        private System.Windows.Forms.Panel panelContenedor2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnregistro;
        private Bunifu.Framework.UI.BunifuFlatButton btningreso;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ToolStripButton BtnRestaurar3;
        private System.Windows.Forms.ToolStripButton BtnMinizar3;
        private Bunifu.Framework.UI.BunifuImageButton btnsalir;
    }
}