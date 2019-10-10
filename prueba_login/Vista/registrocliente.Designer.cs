namespace prueba_login
{
    partial class registrocliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrocliente));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btntspcliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.lblfilt = new System.Windows.Forms.ToolStripLabel();
            this.txtnamecliente = new System.Windows.Forms.TextBox();
            this.txtapelliocliente = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.grpregistro = new System.Windows.Forms.GroupBox();
            this.txtdui = new System.Windows.Forms.MaskedTextBox();
            this.txtnum = new System.Windows.Forms.MaskedTextBox();
            this.lbldir = new System.Windows.Forms.Label();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.lbldui = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.llbltipocli = new System.Windows.Forms.Label();
            this.cmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.dgvcliente = new System.Windows.Forms.DataGridView();
            this.btnupdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnmostrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnregistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnlimp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnreport = new System.Windows.Forms.Button();
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
            this.btntspcliente,
            this.toolStripSeparator1,
            this.txtFiltrar,
            this.lblfilt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1016, 36);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btntspcliente
            // 
            this.btntspcliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btntspcliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntspcliente.ForeColor = System.Drawing.Color.White;
            this.btntspcliente.Image = ((System.Drawing.Image)(resources.GetObject("btntspcliente.Image")));
            this.btntspcliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntspcliente.Name = "btntspcliente";
            this.btntspcliente.Size = new System.Drawing.Size(155, 33);
            this.btntspcliente.Text = "Registro de clientes";
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
            this.txtFiltrar.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // lblfilt
            // 
            this.lblfilt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfilt.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblfilt.Name = "lblfilt";
            this.lblfilt.Size = new System.Drawing.Size(41, 33);
            this.lblfilt.Text = "Filtrar";
            // 
            // txtnamecliente
            // 
            this.txtnamecliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnamecliente.BackColor = System.Drawing.Color.White;
            this.txtnamecliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnamecliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamecliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtnamecliente.Location = new System.Drawing.Point(128, 48);
            this.txtnamecliente.MaxLength = 25;
            this.txtnamecliente.Name = "txtnamecliente";
            this.txtnamecliente.Size = new System.Drawing.Size(228, 19);
            this.txtnamecliente.TabIndex = 1;
            this.txtnamecliente.TextChanged += new System.EventHandler(this.txtnamecliente_TextChanged);
            this.txtnamecliente.Enter += new System.EventHandler(this.txtnamecliente_Enter);
            this.txtnamecliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnamecliente_KeyPress);
            this.txtnamecliente.Leave += new System.EventHandler(this.txtnamecliente_Leave);
            // 
            // txtapelliocliente
            // 
            this.txtapelliocliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtapelliocliente.BackColor = System.Drawing.Color.White;
            this.txtapelliocliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapelliocliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapelliocliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtapelliocliente.Location = new System.Drawing.Point(400, 48);
            this.txtapelliocliente.MaxLength = 25;
            this.txtapelliocliente.Name = "txtapelliocliente";
            this.txtapelliocliente.Size = new System.Drawing.Size(228, 19);
            this.txtapelliocliente.TabIndex = 2;
            this.txtapelliocliente.TextChanged += new System.EventHandler(this.txtapelliocliente_TextChanged);
            this.txtapelliocliente.Enter += new System.EventHandler(this.txtapelliocliente_Enter);
            this.txtapelliocliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapelliocliente_KeyPress);
            this.txtapelliocliente.Leave += new System.EventHandler(this.txtapelliocliente_Leave);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcorreo.BackColor = System.Drawing.Color.White;
            this.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcorreo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcorreo.Location = new System.Drawing.Point(131, 178);
            this.txtcorreo.MaxLength = 25;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(225, 19);
            this.txtcorreo.TabIndex = 5;
            this.txtcorreo.TextChanged += new System.EventHandler(this.txtcorreo_TextChanged);
            this.txtcorreo.Enter += new System.EventHandler(this.txtcorreo_Enter);
            this.txtcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcorreo_KeyPress);
            this.txtcorreo.Leave += new System.EventHandler(this.txtcorreo_Leave);
            // 
            // grpregistro
            // 
            this.grpregistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpregistro.Controls.Add(this.txtdui);
            this.grpregistro.Controls.Add(this.txtnum);
            this.grpregistro.Controls.Add(this.lbldir);
            this.grpregistro.Controls.Add(this.lblcorreo);
            this.grpregistro.Controls.Add(this.lbldui);
            this.grpregistro.Controls.Add(this.lblnum);
            this.grpregistro.Controls.Add(this.lblapellido);
            this.grpregistro.Controls.Add(this.lblname);
            this.grpregistro.Controls.Add(this.llbltipocli);
            this.grpregistro.Controls.Add(this.cmbTipoCliente);
            this.grpregistro.Controls.Add(this.txtId);
            this.grpregistro.Controls.Add(this.txtDireccion);
            this.grpregistro.Controls.Add(this.txtcorreo);
            this.grpregistro.Controls.Add(this.txtapelliocliente);
            this.grpregistro.Controls.Add(this.txtnamecliente);
            this.grpregistro.Location = new System.Drawing.Point(30, 56);
            this.grpregistro.Name = "grpregistro";
            this.grpregistro.Size = new System.Drawing.Size(957, 230);
            this.grpregistro.TabIndex = 0;
            this.grpregistro.TabStop = false;
            this.grpregistro.Enter += new System.EventHandler(this.grpregistro_Enter);
            // 
            // txtdui
            // 
            this.txtdui.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtdui.Location = new System.Drawing.Point(400, 113);
            this.txtdui.Mask = "000000-0";
            this.txtdui.Name = "txtdui";
            this.txtdui.Size = new System.Drawing.Size(228, 20);
            this.txtdui.TabIndex = 4;
            this.txtdui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdui_KeyPress);
            // 
            // txtnum
            // 
            this.txtnum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnum.Location = new System.Drawing.Point(128, 112);
            this.txtnum.Mask = "0000-0000";
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(228, 20);
            this.txtnum.TabIndex = 3;
            this.txtnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum_KeyPress);
            // 
            // lbldir
            // 
            this.lbldir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldir.AutoSize = true;
            this.lbldir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbldir.Location = new System.Drawing.Point(469, 136);
            this.lbldir.Name = "lbldir";
            this.lbldir.Size = new System.Drawing.Size(80, 20);
            this.lbldir.TabIndex = 15;
            this.lbldir.Text = "Direccion";
            // 
            // lblcorreo
            // 
            this.lblcorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorreo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblcorreo.Location = new System.Drawing.Point(161, 146);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(150, 20);
            this.lblcorreo.TabIndex = 14;
            this.lblcorreo.Text = "Correo electronico";
            // 
            // lbldui
            // 
            this.lbldui.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldui.AutoSize = true;
            this.lbldui.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldui.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbldui.Location = new System.Drawing.Point(469, 83);
            this.lbldui.Name = "lbldui";
            this.lbldui.Size = new System.Drawing.Size(114, 20);
            this.lbldui.TabIndex = 13;
            this.lbldui.Text = "DUI de cliente";
            // 
            // lblnum
            // 
            this.lblnum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblnum.Location = new System.Drawing.Point(165, 83);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(146, 20);
            this.lblnum.TabIndex = 12;
            this.lblnum.Text = "Numero telefonico";
            // 
            // lblapellido
            // 
            this.lblapellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblapellido.AutoSize = true;
            this.lblapellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellido.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblapellido.Location = new System.Drawing.Point(445, 18);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(147, 20);
            this.lblapellido.TabIndex = 11;
            this.lblapellido.Text = "Apellido de cliente";
            // 
            // lblname
            // 
            this.lblname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblname.Location = new System.Drawing.Point(165, 19);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(146, 20);
            this.lblname.TabIndex = 10;
            this.lblname.Text = "Nombre de cliente";
            this.lblname.Click += new System.EventHandler(this.label2_Click);
            // 
            // llbltipocli
            // 
            this.llbltipocli.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.llbltipocli.AutoSize = true;
            this.llbltipocli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbltipocli.ForeColor = System.Drawing.Color.White;
            this.llbltipocli.Location = new System.Drawing.Point(714, 77);
            this.llbltipocli.Name = "llbltipocli";
            this.llbltipocli.Size = new System.Drawing.Size(71, 16);
            this.llbltipocli.TabIndex = 9;
            this.llbltipocli.Text = "Tipo Cliente";
            this.llbltipocli.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbTipoCliente
            // 
            this.cmbTipoCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCliente.FormattingEnabled = true;
            this.cmbTipoCliente.Location = new System.Drawing.Point(670, 96);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(166, 21);
            this.cmbTipoCliente.TabIndex = 7;
            this.cmbTipoCliente.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCliente_SelectedIndexChanged);
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtId.Location = new System.Drawing.Point(717, 159);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
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
            this.txtDireccion.Location = new System.Drawing.Point(400, 159);
            this.txtDireccion.MaxLength = 40;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(228, 62);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            this.txtDireccion.Enter += new System.EventHandler(this.txtDireccion_Enter);
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            this.txtDireccion.Leave += new System.EventHandler(this.txtDireccion_Leave);
            // 
            // dgvcliente
            // 
            this.dgvcliente.AllowUserToAddRows = false;
            this.dgvcliente.AllowUserToDeleteRows = false;
            this.dgvcliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvcliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcliente.Location = new System.Drawing.Point(12, 371);
            this.dgvcliente.Name = "dgvcliente";
            this.dgvcliente.ReadOnly = true;
            this.dgvcliente.Size = new System.Drawing.Size(992, 310);
            this.dgvcliente.TabIndex = 2;
            this.dgvcliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcliente_CellClick);
            this.dgvcliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcliente_CellContentClick);
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
            this.btnupdate.Location = new System.Drawing.Point(422, 299);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Normalcolor = System.Drawing.Color.Gold;
            this.btnupdate.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnupdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnupdate.selected = false;
            this.btnupdate.Size = new System.Drawing.Size(182, 56);
            this.btnupdate.TabIndex = 10;
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
            this.btnmostrar.Location = new System.Drawing.Point(223, 299);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Normalcolor = System.Drawing.Color.Gold;
            this.btnmostrar.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnmostrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnmostrar.selected = false;
            this.btnmostrar.Size = new System.Drawing.Size(182, 56);
            this.btnmostrar.TabIndex = 9;
            this.btnmostrar.Text = "      Mostrar";
            this.btnmostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmostrar.Textcolor = System.Drawing.Color.Black;
            this.btnmostrar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
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
            this.btneliminar.Location = new System.Drawing.Point(621, 299);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Normalcolor = System.Drawing.Color.Gold;
            this.btneliminar.OnHovercolor = System.Drawing.Color.DimGray;
            this.btneliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneliminar.selected = false;
            this.btneliminar.Size = new System.Drawing.Size(182, 56);
            this.btneliminar.TabIndex = 11;
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
            this.btnregistrar.Location = new System.Drawing.Point(24, 299);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Normalcolor = System.Drawing.Color.Gold;
            this.btnregistrar.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnregistrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnregistrar.selected = false;
            this.btnregistrar.Size = new System.Drawing.Size(182, 56);
            this.btnregistrar.TabIndex = 8;
            this.btnregistrar.Text = "      Registrar";
            this.btnregistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistrar.Textcolor = System.Drawing.Color.Black;
            this.btnregistrar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnlimp
            // 
            this.btnlimp.Activecolor = System.Drawing.Color.Gold;
            this.btnlimp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnlimp.BackColor = System.Drawing.Color.Gold;
            this.btnlimp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimp.BorderRadius = 0;
            this.btnlimp.ButtonText = "  Limpiar campos";
            this.btnlimp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimp.DisabledColor = System.Drawing.Color.Gray;
            this.btnlimp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnlimp.Iconimage = global::prueba_login.Properties.Resources.short_broom;
            this.btnlimp.Iconimage_right = null;
            this.btnlimp.Iconimage_right_Selected = null;
            this.btnlimp.Iconimage_Selected = null;
            this.btnlimp.IconMarginLeft = 0;
            this.btnlimp.IconMarginRight = 0;
            this.btnlimp.IconRightVisible = true;
            this.btnlimp.IconRightZoom = 0D;
            this.btnlimp.IconVisible = true;
            this.btnlimp.IconZoom = 90D;
            this.btnlimp.IsTab = false;
            this.btnlimp.Location = new System.Drawing.Point(816, 299);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Normalcolor = System.Drawing.Color.Gold;
            this.btnlimp.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnlimp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnlimp.selected = false;
            this.btnlimp.Size = new System.Drawing.Size(182, 56);
            this.btnlimp.TabIndex = 12;
            this.btnlimp.Text = "  Limpiar campos";
            this.btnlimp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlimp.Textcolor = System.Drawing.Color.Black;
            this.btnlimp.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimp.Click += new System.EventHandler(this.btnlimp_Click);
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.Yellow;
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.Location = new System.Drawing.Point(773, 6);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(231, 23);
            this.btnreport.TabIndex = 21;
            this.btnreport.Text = "Generar reporte";
            this.btnreport.UseVisualStyleBackColor = false;
            this.btnreport.Click += new System.EventHandler(this.button1_Click);
            // 
            // registrocliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1016, 693);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btnlimp);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.dgvcliente);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpregistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registrocliente";
            this.Text = "registrocliente";
            this.Load += new System.EventHandler(this.registrocliente_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpregistro.ResumeLayout(false);
            this.grpregistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox txtnamecliente;
        private System.Windows.Forms.TextBox txtapelliocliente;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.GroupBox grpregistro;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DataGridView dgvcliente;
        private Bunifu.Framework.UI.BunifuFlatButton btnregistrar;
        private Bunifu.Framework.UI.BunifuFlatButton btneliminar;
        private System.Windows.Forms.ToolStripButton btntspcliente;
        private System.Windows.Forms.Label llbltipocli;
        private System.Windows.Forms.ComboBox cmbTipoCliente;
        private System.Windows.Forms.TextBox txtId;
        private Bunifu.Framework.UI.BunifuFlatButton btnmostrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnupdate;
        private System.Windows.Forms.Label lbldir;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.Label lbldui;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.MaskedTextBox txtdui;
        private System.Windows.Forms.MaskedTextBox txtnum;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtFiltrar;
        private System.Windows.Forms.ToolStripLabel lblfilt;
        private Bunifu.Framework.UI.BunifuFlatButton btnlimp;
        private System.Windows.Forms.Button btnreport;
    }
}