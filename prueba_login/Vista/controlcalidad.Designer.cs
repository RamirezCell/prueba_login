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
            this.control = new System.Windows.Forms.ToolStripButton();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.lbldes = new System.Windows.Forms.Label();
            this.lbldetalle = new System.Windows.Forms.Label();
            this.txtdet = new System.Windows.Forms.TextBox();
            this.rbno = new System.Windows.Forms.RadioButton();
            this.rbsi = new System.Windows.Forms.RadioButton();
            this.aprobar = new System.Windows.Forms.Label();
            this.Send = new Bunifu.Framework.UI.BunifuFlatButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.control});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1016, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // control
            // 
            this.control.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.control.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control.ForeColor = System.Drawing.SystemColors.Control;
            this.control.Image = ((System.Drawing.Image)(resources.GetObject("control.Image")));
            this.control.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(136, 22);
            this.control.Text = "Control de calidad";
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
            // lbldes
            // 
            this.lbldes.AutoSize = true;
            this.lbldes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbldes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldes.Location = new System.Drawing.Point(225, 45);
            this.lbldes.Name = "lbldes";
            this.lbldes.Size = new System.Drawing.Size(151, 16);
            this.lbldes.TabIndex = 8;
            this.lbldes.Text = "Descripcion de finalizacion";
            // 
            // lbldetalle
            // 
            this.lbldetalle.AutoSize = true;
            this.lbldetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbldetalle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldetalle.Location = new System.Drawing.Point(240, 255);
            this.lbldetalle.Name = "lbldetalle";
            this.lbldetalle.Size = new System.Drawing.Size(136, 16);
            this.lbldetalle.TabIndex = 10;
            this.lbldetalle.Text = "Detalles en el acabado";
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
            this.rbno.TabIndex = 4;
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
            this.rbsi.TabIndex = 3;
            this.rbsi.TabStop = true;
            this.rbsi.Text = "Si";
            this.rbsi.UseVisualStyleBackColor = true;
            // 
            // aprobar
            // 
            this.aprobar.AutoSize = true;
            this.aprobar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aprobar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprobar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aprobar.Location = new System.Drawing.Point(118, 451);
            this.aprobar.Name = "aprobar";
            this.aprobar.Size = new System.Drawing.Size(52, 16);
            this.aprobar.TabIndex = 13;
            this.aprobar.Text = "Aprobar";
            // 
            // Send
            // 
            this.Send.Activecolor = System.Drawing.Color.Gold;
            this.Send.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Send.BackColor = System.Drawing.Color.Gold;
            this.Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Send.BorderRadius = 0;
            this.Send.ButtonText = "      Enviar";
            this.Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Send.DisabledColor = System.Drawing.Color.Gray;
            this.Send.Iconcolor = System.Drawing.Color.Transparent;
            this.Send.Iconimage = global::prueba_login.Properties.Resources.checked1;
            this.Send.Iconimage_right = null;
            this.Send.Iconimage_right_Selected = null;
            this.Send.Iconimage_Selected = null;
            this.Send.IconMarginLeft = 0;
            this.Send.IconMarginRight = 0;
            this.Send.IconRightVisible = true;
            this.Send.IconRightZoom = 0D;
            this.Send.IconVisible = true;
            this.Send.IconZoom = 90D;
            this.Send.IsTab = false;
            this.Send.Location = new System.Drawing.Point(629, 457);
            this.Send.Name = "Send";
            this.Send.Normalcolor = System.Drawing.Color.Gold;
            this.Send.OnHovercolor = System.Drawing.Color.DimGray;
            this.Send.OnHoverTextColor = System.Drawing.Color.White;
            this.Send.selected = false;
            this.Send.Size = new System.Drawing.Size(182, 56);
            this.Send.TabIndex = 5;
            this.Send.Text = "      Enviar";
            this.Send.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Send.Textcolor = System.Drawing.Color.Black;
            this.Send.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // controlcalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1016, 693);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.aprobar);
            this.Controls.Add(this.rbsi);
            this.Controls.Add(this.rbno);
            this.Controls.Add(this.lbldetalle);
            this.Controls.Add(this.txtdet);
            this.Controls.Add(this.lbldes);
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
        private System.Windows.Forms.ToolStripButton control;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.Label lbldes;
        private System.Windows.Forms.Label lbldetalle;
        private System.Windows.Forms.TextBox txtdet;
        private System.Windows.Forms.RadioButton rbno;
        private System.Windows.Forms.RadioButton rbsi;
        private System.Windows.Forms.Label aprobar;
        private Bunifu.Framework.UI.BunifuFlatButton Send;
    }
}