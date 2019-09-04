namespace prueba_login
{
    partial class controlcalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlcalidad));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdet = new System.Windows.Forms.TextBox();
            this.rbno = new System.Windows.Forms.RadioButton();
            this.rbsi = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnenviar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1016, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(136, 22);
            this.toolStripButton1.Text = "Control de calidad";
            // 
            // txtdes
            // 
            this.txtdes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtdes.BackColor = System.Drawing.Color.White;
            this.txtdes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdes.Location = new System.Drawing.Point(210, 75);
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(601, 132);
            this.txtdes.TabIndex = 1;
            this.txtdes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdes_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(225, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descripcion de finalizacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(240, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Detalles en el acabado";
            // 
            // txtdet
            // 
            this.txtdet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtdet.BackColor = System.Drawing.Color.White;
            this.txtdet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdet.Location = new System.Drawing.Point(210, 289);
            this.txtdet.Multiline = true;
            this.txtdet.Name = "txtdet";
            this.txtdet.Size = new System.Drawing.Size(601, 132);
            this.txtdet.TabIndex = 2;
            this.txtdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdet_KeyPress);
            // 
            // rbno
            // 
            this.rbno.AutoSize = true;
            this.rbno.Checked = true;
            this.rbno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbno.Location = new System.Drawing.Point(121, 502);
            this.rbno.Name = "rbno";
            this.rbno.Size = new System.Drawing.Size(39, 17);
            this.rbno.TabIndex = 11;
            this.rbno.TabStop = true;
            this.rbno.Text = "No";
            this.rbno.UseVisualStyleBackColor = true;
            // 
            // rbsi
            // 
            this.rbsi.AutoSize = true;
            this.rbsi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbsi.Location = new System.Drawing.Point(121, 479);
            this.rbsi.Name = "rbsi";
            this.rbsi.Size = new System.Drawing.Size(34, 17);
            this.rbsi.TabIndex = 12;
            this.rbsi.TabStop = true;
            this.rbsi.Text = "Si";
            this.rbsi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(118, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Aprobar";
            // 
            // btnenviar
            // 
            this.btnenviar.Activecolor = System.Drawing.Color.Gold;
            this.btnenviar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnenviar.BackColor = System.Drawing.Color.Gold;
            this.btnenviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnenviar.BorderRadius = 0;
            this.btnenviar.ButtonText = "      Enviar";
            this.btnenviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnenviar.DisabledColor = System.Drawing.Color.Gray;
            this.btnenviar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnenviar.Iconimage = global::prueba_login.Properties.Resources.checked1;
            this.btnenviar.Iconimage_right = null;
            this.btnenviar.Iconimage_right_Selected = null;
            this.btnenviar.Iconimage_Selected = null;
            this.btnenviar.IconMarginLeft = 0;
            this.btnenviar.IconMarginRight = 0;
            this.btnenviar.IconRightVisible = true;
            this.btnenviar.IconRightZoom = 0D;
            this.btnenviar.IconVisible = true;
            this.btnenviar.IconZoom = 90D;
            this.btnenviar.IsTab = false;
            this.btnenviar.Location = new System.Drawing.Point(629, 457);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Normalcolor = System.Drawing.Color.Gold;
            this.btnenviar.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnenviar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnenviar.selected = false;
            this.btnenviar.Size = new System.Drawing.Size(182, 56);
            this.btnenviar.TabIndex = 3;
            this.btnenviar.Text = "      Enviar";
            this.btnenviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnenviar.Textcolor = System.Drawing.Color.Black;
            this.btnenviar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // controlcalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1016, 693);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbsi);
            this.Controls.Add(this.rbno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "controlcalidad";
            this.Text = "controlcalidad";
            this.Load += new System.EventHandler(this.controlcalidad_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdet;
        private System.Windows.Forms.RadioButton rbno;
        private System.Windows.Forms.RadioButton rbsi;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnenviar;
    }
}