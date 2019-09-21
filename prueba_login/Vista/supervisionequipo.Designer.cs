namespace prueba_login
{
    partial class supervisionequipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supervisionequipo));
            this.dgtmaterial = new System.Windows.Forms.DataGridView();
            this.btnenviar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgtmaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgtmaterial
            // 
            this.dgtmaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgtmaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtmaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtmaterial.Location = new System.Drawing.Point(50, 107);
            this.dgtmaterial.Name = "dgtmaterial";
            this.dgtmaterial.Size = new System.Drawing.Size(912, 546);
            this.dgtmaterial.TabIndex = 0;
            // 
            // btnenviar
            // 
            this.btnenviar.Activecolor = System.Drawing.Color.Gold;
            this.btnenviar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnenviar.BackColor = System.Drawing.Color.Gold;
            this.btnenviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnenviar.BorderRadius = 0;
            this.btnenviar.ButtonText = "          Ver";
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
            this.btnenviar.Location = new System.Drawing.Point(426, 34);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Normalcolor = System.Drawing.Color.Gold;
            this.btnenviar.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnenviar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnenviar.selected = false;
            this.btnenviar.Size = new System.Drawing.Size(182, 56);
            this.btnenviar.TabIndex = 1;
            this.btnenviar.Text = "          Ver";
            this.btnenviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnenviar.Textcolor = System.Drawing.Color.Black;
            this.btnenviar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // supervisionequipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1016, 693);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.dgtmaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "supervisionequipo";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.supervisionequipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtmaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtmaterial;
        private Bunifu.Framework.UI.BunifuFlatButton btnenviar;
    }
}