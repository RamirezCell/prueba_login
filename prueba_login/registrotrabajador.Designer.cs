namespace prueba_login
{
    partial class registrotrabajador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrotrabajador));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.grpregistro = new System.Windows.Forms.GroupBox();
            this.txtdui = new System.Windows.Forms.MaskedTextBox();
            this.txtnum = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnupdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnmostrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnregistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvcliente = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.grpregistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(838, 36);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(193, 33);
            this.toolStripButton1.Text = "Registro de trabajadores";
            // 
            // grpregistro
            // 
            this.grpregistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpregistro.Controls.Add(this.label9);
            this.grpregistro.Controls.Add(this.comboBox2);
            this.grpregistro.Controls.Add(this.label8);
            this.grpregistro.Controls.Add(this.comboBox1);
            this.grpregistro.Controls.Add(this.txtdui);
            this.grpregistro.Controls.Add(this.txtnum);
            this.grpregistro.Controls.Add(this.label7);
            this.grpregistro.Controls.Add(this.label6);
            this.grpregistro.Controls.Add(this.label5);
            this.grpregistro.Controls.Add(this.label4);
            this.grpregistro.Controls.Add(this.label3);
            this.grpregistro.Controls.Add(this.label2);
            this.grpregistro.Controls.Add(this.label1);
            this.grpregistro.Controls.Add(this.cmbTipoCliente);
            this.grpregistro.Controls.Add(this.txtId);
            this.grpregistro.Controls.Add(this.txtDireccion);
            this.grpregistro.Controls.Add(this.txtcorreo);
            this.grpregistro.Controls.Add(this.txtapellido);
            this.grpregistro.Controls.Add(this.txtnombre);
            this.grpregistro.Location = new System.Drawing.Point(12, 49);
            this.grpregistro.Name = "grpregistro";
            this.grpregistro.Size = new System.Drawing.Size(814, 230);
            this.grpregistro.TabIndex = 3;
            this.grpregistro.TabStop = false;
            this.grpregistro.Enter += new System.EventHandler(this.grpregistro_Enter);
            // 
            // txtdui
            // 
            this.txtdui.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtdui.Location = new System.Drawing.Point(250, 112);
            this.txtdui.Mask = "000000-0";
            this.txtdui.Name = "txtdui";
            this.txtdui.Size = new System.Drawing.Size(172, 20);
            this.txtdui.TabIndex = 17;
            // 
            // txtnum
            // 
            this.txtnum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnum.Location = new System.Drawing.Point(12, 113);
            this.txtnum.Mask = "0000-0000";
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(180, 20);
            this.txtnum.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(296, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(28, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Correo electronico";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(320, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "DUI";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(30, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Numero telefonico";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(303, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(66, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(493, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ocupacion";
            // 
            // cmbTipoCliente
            // 
            this.cmbTipoCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCliente.FormattingEnabled = true;
            this.cmbTipoCliente.Location = new System.Drawing.Point(452, 46);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(166, 21);
            this.cmbTipoCliente.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtId.Location = new System.Drawing.Point(744, 204);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(64, 20);
            this.txtId.TabIndex = 8;
            this.txtId.Visible = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDireccion.Location = new System.Drawing.Point(250, 178);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(172, 46);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcorreo.BackColor = System.Drawing.Color.White;
            this.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcorreo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcorreo.Location = new System.Drawing.Point(12, 183);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(180, 19);
            this.txtcorreo.TabIndex = 5;
            // 
            // txtapellido
            // 
            this.txtapellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtapellido.BackColor = System.Drawing.Color.White;
            this.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtapellido.Location = new System.Drawing.Point(250, 48);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(172, 19);
            this.txtapellido.TabIndex = 2;
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnombre.BackColor = System.Drawing.Color.White;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtnombre.Location = new System.Drawing.Point(12, 48);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(180, 19);
            this.txtnombre.TabIndex = 1;
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
            this.btnupdate.Location = new System.Drawing.Point(429, 299);
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
            this.btnmostrar.Location = new System.Drawing.Point(230, 299);
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
            this.btneliminar.Location = new System.Drawing.Point(628, 299);
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
            this.btnregistrar.Location = new System.Drawing.Point(31, 299);
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
            // 
            // dgvcliente
            // 
            this.dgvcliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvcliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcliente.Location = new System.Drawing.Point(12, 371);
            this.dgvcliente.Name = "dgvcliente";
            this.dgvcliente.ReadOnly = true;
            this.dgvcliente.Size = new System.Drawing.Size(814, 190);
            this.dgvcliente.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(676, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Genero";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(632, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(593, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Estado";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(538, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(166, 21);
            this.comboBox2.TabIndex = 20;
            // 
            // registrotrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(838, 573);
            this.Controls.Add(this.dgvcliente);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.grpregistro);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registrotrabajador";
            this.Text = "registrotrabajador";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpregistro.ResumeLayout(false);
            this.grpregistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox grpregistro;
        private System.Windows.Forms.MaskedTextBox txtdui;
        private System.Windows.Forms.MaskedTextBox txtnum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoCliente;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private Bunifu.Framework.UI.BunifuFlatButton btnupdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnmostrar;
        private Bunifu.Framework.UI.BunifuFlatButton btneliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnregistrar;
        private System.Windows.Forms.DataGridView dgvcliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}