﻿namespace prueba_login
{
    partial class registroauto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registroauto));
            this.grpregistro = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtIdvehiculo = new System.Windows.Forms.TextBox();
            this.btnupdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnmostrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnregistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvvehiculos = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.grpregistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvehiculos)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpregistro
            // 
            this.grpregistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpregistro.Controls.Add(this.comboBox4);
            this.grpregistro.Controls.Add(this.comboBox3);
            this.grpregistro.Controls.Add(this.comboBox2);
            this.grpregistro.Controls.Add(this.comboBox1);
            this.grpregistro.Controls.Add(this.label6);
            this.grpregistro.Controls.Add(this.label5);
            this.grpregistro.Controls.Add(this.label3);
            this.grpregistro.Controls.Add(this.label);
            this.grpregistro.Controls.Add(this.txtIdvehiculo);
            this.grpregistro.Location = new System.Drawing.Point(21, 49);
            this.grpregistro.Name = "grpregistro";
            this.grpregistro.Size = new System.Drawing.Size(973, 220);
            this.grpregistro.TabIndex = 1;
            this.grpregistro.TabStop = false;
            this.grpregistro.Enter += new System.EventHandler(this.grpregistro_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(47, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Año del vehiculo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(301, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tipo vehiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(301, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Modelo de vehiculo";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label.Location = new System.Drawing.Point(47, 52);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(151, 20);
            this.label.TabIndex = 10;
            this.label.Text = "Marca de vehiculo";
            this.label.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtIdvehiculo
            // 
            this.txtIdvehiculo.Location = new System.Drawing.Point(51, 29);
            this.txtIdvehiculo.Name = "txtIdvehiculo";
            this.txtIdvehiculo.Size = new System.Drawing.Size(100, 20);
            this.txtIdvehiculo.TabIndex = 8;
            this.txtIdvehiculo.Visible = false;
            // 
            // btnupdate
            // 
            this.btnupdate.Activecolor = System.Drawing.Color.Gold;
            this.btnupdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnupdate.BackColor = System.Drawing.Color.Gold;
            this.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnupdate.BorderRadius = 0;
            this.btnupdate.ButtonText = "      Actualizar";
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnupdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnupdate.Iconimage = global::prueba_login.Properties.Resources.refresh_button;
            this.btnupdate.Iconimage_right = null;
            this.btnupdate.Iconimage_right_Selected = null;
            this.btnupdate.Iconimage_Selected = null;
            this.btnupdate.IconMarginLeft = 0;
            this.btnupdate.IconMarginRight = 0;
            this.btnupdate.IconRightVisible = true;
            this.btnupdate.IconRightZoom = 0D;
            this.btnupdate.IconVisible = true;
            this.btnupdate.IconZoom = 90D;
            this.btnupdate.IsTab = false;
            this.btnupdate.Location = new System.Drawing.Point(516, 285);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Normalcolor = System.Drawing.Color.Gold;
            this.btnupdate.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnupdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnupdate.selected = false;
            this.btnupdate.Size = new System.Drawing.Size(182, 56);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "      Actualizar";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Textcolor = System.Drawing.Color.Black;
            this.btnupdate.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Activecolor = System.Drawing.Color.Gold;
            this.btnmostrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnmostrar.BackColor = System.Drawing.Color.Gold;
            this.btnmostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmostrar.BorderRadius = 0;
            this.btnmostrar.ButtonText = "      Mostrar";
            this.btnmostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmostrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnmostrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnmostrar.Iconimage = global::prueba_login.Properties.Resources.eye1;
            this.btnmostrar.Iconimage_right = null;
            this.btnmostrar.Iconimage_right_Selected = null;
            this.btnmostrar.Iconimage_Selected = null;
            this.btnmostrar.IconMarginLeft = 0;
            this.btnmostrar.IconMarginRight = 0;
            this.btnmostrar.IconRightVisible = true;
            this.btnmostrar.IconRightZoom = 0D;
            this.btnmostrar.IconVisible = true;
            this.btnmostrar.IconZoom = 90D;
            this.btnmostrar.IsTab = false;
            this.btnmostrar.Location = new System.Drawing.Point(317, 285);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Normalcolor = System.Drawing.Color.Gold;
            this.btnmostrar.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnmostrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnmostrar.selected = false;
            this.btnmostrar.Size = new System.Drawing.Size(182, 56);
            this.btnmostrar.TabIndex = 13;
            this.btnmostrar.Text = "      Mostrar";
            this.btnmostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmostrar.Textcolor = System.Drawing.Color.Black;
            this.btnmostrar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Activecolor = System.Drawing.Color.Gold;
            this.btneliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btneliminar.BackColor = System.Drawing.Color.Gold;
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.BorderRadius = 0;
            this.btneliminar.ButtonText = "     Eliminar";
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btneliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btneliminar.Iconimage = global::prueba_login.Properties.Resources.rubbish_bin_delete_button;
            this.btneliminar.Iconimage_right = null;
            this.btneliminar.Iconimage_right_Selected = null;
            this.btneliminar.Iconimage_Selected = null;
            this.btneliminar.IconMarginLeft = 0;
            this.btneliminar.IconMarginRight = 0;
            this.btneliminar.IconRightVisible = true;
            this.btneliminar.IconRightZoom = 0D;
            this.btneliminar.IconVisible = true;
            this.btneliminar.IconZoom = 90D;
            this.btneliminar.IsTab = false;
            this.btneliminar.Location = new System.Drawing.Point(715, 285);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Normalcolor = System.Drawing.Color.Gold;
            this.btneliminar.OnHovercolor = System.Drawing.Color.DimGray;
            this.btneliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneliminar.selected = false;
            this.btneliminar.Size = new System.Drawing.Size(182, 56);
            this.btneliminar.TabIndex = 12;
            this.btneliminar.Text = "     Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Textcolor = System.Drawing.Color.Black;
            this.btneliminar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.Activecolor = System.Drawing.Color.Gold;
            this.btnregistrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnregistrar.BackColor = System.Drawing.Color.Gold;
            this.btnregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistrar.BorderRadius = 0;
            this.btnregistrar.ButtonText = "      Registrar";
            this.btnregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnregistrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnregistrar.Iconimage = global::prueba_login.Properties.Resources.add_button_inside_black_circle;
            this.btnregistrar.Iconimage_right = null;
            this.btnregistrar.Iconimage_right_Selected = null;
            this.btnregistrar.Iconimage_Selected = null;
            this.btnregistrar.IconMarginLeft = 0;
            this.btnregistrar.IconMarginRight = 0;
            this.btnregistrar.IconRightVisible = true;
            this.btnregistrar.IconRightZoom = 0D;
            this.btnregistrar.IconVisible = true;
            this.btnregistrar.IconZoom = 90D;
            this.btnregistrar.IsTab = false;
            this.btnregistrar.Location = new System.Drawing.Point(118, 285);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Normalcolor = System.Drawing.Color.Gold;
            this.btnregistrar.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnregistrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnregistrar.selected = false;
            this.btnregistrar.Size = new System.Drawing.Size(182, 56);
            this.btnregistrar.TabIndex = 11;
            this.btnregistrar.Text = "      Registrar";
            this.btnregistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistrar.Textcolor = System.Drawing.Color.Black;
            this.btnregistrar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // dgvvehiculos
            // 
            this.dgvvehiculos.AllowUserToAddRows = false;
            this.dgvvehiculos.AllowUserToDeleteRows = false;
            this.dgvvehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvvehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvvehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvehiculos.Location = new System.Drawing.Point(8, 347);
            this.dgvvehiculos.Name = "dgvvehiculos";
            this.dgvvehiculos.ReadOnly = true;
            this.dgvvehiculos.Size = new System.Drawing.Size(996, 342);
            this.dgvvehiculos.TabIndex = 15;
            this.dgvvehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvehiculos_CellClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.txtFiltrar,
            this.toolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(1016, 36);
            this.toolStrip2.TabIndex = 16;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(169, 33);
            this.toolStripButton1.Text = "Registro de vehiculos";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(100, 36);
            this.txtFiltrar.Click += new System.EventHandler(this.txtFiltrar_Click);
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Goldenrod;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(41, 33);
            this.toolStripLabel1.Text = "Filtrar";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(305, 75);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(211, 24);
            this.comboBox2.TabIndex = 16;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(51, 148);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(204, 24);
            this.comboBox3.TabIndex = 17;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(305, 148);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(211, 24);
            this.comboBox4.TabIndex = 18;
            // 
            // registroauto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1016, 695);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dgvvehiculos);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.grpregistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registroauto";
            this.Text = "registroauto";
            this.Load += new System.EventHandler(this.registroauto_Load);
            this.grpregistro.ResumeLayout(false);
            this.grpregistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvehiculos)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpregistro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtIdvehiculo;
        private Bunifu.Framework.UI.BunifuFlatButton btnupdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnmostrar;
        private Bunifu.Framework.UI.BunifuFlatButton btneliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnregistrar;
        private System.Windows.Forms.DataGridView dgvvehiculos;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtFiltrar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}