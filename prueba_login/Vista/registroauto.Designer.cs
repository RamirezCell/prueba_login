namespace prueba_login
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
            this.cmbPropietario = new System.Windows.Forms.ComboBox();
            this.lblpropetario = new System.Windows.Forms.Label();
            this.lblnummotor = new System.Windows.Forms.Label();
            this.lblnumchasis = new System.Windows.Forms.Label();
            this.txtchasis = new System.Windows.Forms.TextBox();
            this.txtmotor = new System.Windows.Forms.TextBox();
            this.lblplaca = new System.Windows.Forms.Label();
            this.cmbplaca = new System.Windows.Forms.ComboBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.cmbLinea = new System.Windows.Forms.ComboBox();
            this.lbllinea = new System.Windows.Forms.Label();
            this.cmbTipo_Vehiculo = new System.Windows.Forms.ComboBox();
            this.cmbEstado_Vehiculo = new System.Windows.Forms.ComboBox();
            this.cmbModelo_Vehiculo = new System.Windows.Forms.ComboBox();
            this.cmbMarca_vehiculo = new System.Windows.Forms.ComboBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.lbltipovehiculo = new System.Windows.Forms.Label();
            this.lblmodelo = new System.Windows.Forms.Label();
            this.lblmarca = new System.Windows.Forms.Label();
            this.txtIdvehiculo = new System.Windows.Forms.TextBox();
            this.btnupdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnmostrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnregistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvvehiculos = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnreg = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.lblfilt = new System.Windows.Forms.ToolStripLabel();
            this.btnlimp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnreport = new System.Windows.Forms.Button();
            this.grpregistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvehiculos)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpregistro
            // 
            this.grpregistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpregistro.Controls.Add(this.cmbPropietario);
            this.grpregistro.Controls.Add(this.lblpropetario);
            this.grpregistro.Controls.Add(this.lblnummotor);
            this.grpregistro.Controls.Add(this.lblnumchasis);
            this.grpregistro.Controls.Add(this.txtchasis);
            this.grpregistro.Controls.Add(this.txtmotor);
            this.grpregistro.Controls.Add(this.lblplaca);
            this.grpregistro.Controls.Add(this.cmbplaca);
            this.grpregistro.Controls.Add(this.txtplaca);
            this.grpregistro.Controls.Add(this.cmbLinea);
            this.grpregistro.Controls.Add(this.lbllinea);
            this.grpregistro.Controls.Add(this.cmbTipo_Vehiculo);
            this.grpregistro.Controls.Add(this.cmbEstado_Vehiculo);
            this.grpregistro.Controls.Add(this.cmbModelo_Vehiculo);
            this.grpregistro.Controls.Add(this.cmbMarca_vehiculo);
            this.grpregistro.Controls.Add(this.lblestado);
            this.grpregistro.Controls.Add(this.lbltipovehiculo);
            this.grpregistro.Controls.Add(this.lblmodelo);
            this.grpregistro.Controls.Add(this.lblmarca);
            this.grpregistro.Location = new System.Drawing.Point(21, 49);
            this.grpregistro.Name = "grpregistro";
            this.grpregistro.Size = new System.Drawing.Size(973, 220);
            this.grpregistro.TabIndex = 1;
            this.grpregistro.TabStop = false;
            this.grpregistro.Text = "-";
            this.grpregistro.Enter += new System.EventHandler(this.grpregistro_Enter);
            // 
            // cmbPropietario
            // 
            this.cmbPropietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPropietario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPropietario.FormattingEnabled = true;
            this.cmbPropietario.Location = new System.Drawing.Point(22, 173);
            this.cmbPropietario.Name = "cmbPropietario";
            this.cmbPropietario.Size = new System.Drawing.Size(204, 24);
            this.cmbPropietario.TabIndex = 10;
            // 
            // lblpropetario
            // 
            this.lblpropetario.AutoSize = true;
            this.lblpropetario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpropetario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblpropetario.Location = new System.Drawing.Point(31, 150);
            this.lblpropetario.Name = "lblpropetario";
            this.lblpropetario.Size = new System.Drawing.Size(184, 20);
            this.lblpropetario.TabIndex = 28;
            this.lblpropetario.Text = "Propietario del vehiculo";
            // 
            // lblnummotor
            // 
            this.lblnummotor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnummotor.AutoSize = true;
            this.lblnummotor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnummotor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblnummotor.Location = new System.Drawing.Point(797, 14);
            this.lblnummotor.Name = "lblnummotor";
            this.lblnummotor.Size = new System.Drawing.Size(141, 20);
            this.lblnummotor.TabIndex = 27;
            this.lblnummotor.Text = "Numero del motor";
            // 
            // lblnumchasis
            // 
            this.lblnumchasis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnumchasis.AutoSize = true;
            this.lblnumchasis.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumchasis.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblnumchasis.Location = new System.Drawing.Point(785, 79);
            this.lblnumchasis.Name = "lblnumchasis";
            this.lblnumchasis.Size = new System.Drawing.Size(141, 20);
            this.lblnumchasis.TabIndex = 26;
            this.lblnumchasis.Text = "Numero de Chasis";
            // 
            // txtchasis
            // 
            this.txtchasis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtchasis.Location = new System.Drawing.Point(773, 101);
            this.txtchasis.MaxLength = 17;
            this.txtchasis.Name = "txtchasis";
            this.txtchasis.Size = new System.Drawing.Size(173, 20);
            this.txtchasis.TabIndex = 9;
            this.txtchasis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtchasis_KeyPress);
            // 
            // txtmotor
            // 
            this.txtmotor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmotor.Location = new System.Drawing.Point(773, 42);
            this.txtmotor.MaxLength = 17;
            this.txtmotor.Name = "txtmotor";
            this.txtmotor.Size = new System.Drawing.Size(173, 20);
            this.txtmotor.TabIndex = 4;
            this.txtmotor.TextChanged += new System.EventHandler(this.Txtmotor_TextChanged);
            this.txtmotor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtmotor_KeyPress);
            // 
            // lblplaca
            // 
            this.lblplaca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblplaca.AutoSize = true;
            this.lblplaca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplaca.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblplaca.Location = new System.Drawing.Point(570, 78);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(146, 20);
            this.lblplaca.TabIndex = 23;
            this.lblplaca.Text = "Placa del vehiculo";
            // 
            // cmbplaca
            // 
            this.cmbplaca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbplaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbplaca.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbplaca.FormattingEnabled = true;
            this.cmbplaca.Location = new System.Drawing.Point(531, 102);
            this.cmbplaca.Name = "cmbplaca";
            this.cmbplaca.Size = new System.Drawing.Size(83, 24);
            this.cmbplaca.TabIndex = 7;
            // 
            // txtplaca
            // 
            this.txtplaca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtplaca.Location = new System.Drawing.Point(620, 106);
            this.txtplaca.MaxLength = 6;
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(122, 20);
            this.txtplaca.TabIndex = 8;
            this.txtplaca.TextChanged += new System.EventHandler(this.Txtplaca_TextChanged);
            this.txtplaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtplaca_KeyPress);
            // 
            // cmbLinea
            // 
            this.cmbLinea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLinea.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLinea.FormattingEnabled = true;
            this.cmbLinea.Location = new System.Drawing.Point(531, 38);
            this.cmbLinea.Name = "cmbLinea";
            this.cmbLinea.Size = new System.Drawing.Size(211, 24);
            this.cmbLinea.TabIndex = 3;
            // 
            // lbllinea
            // 
            this.lbllinea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbllinea.AutoSize = true;
            this.lbllinea.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllinea.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbllinea.Location = new System.Drawing.Point(572, 14);
            this.lbllinea.Name = "lbllinea";
            this.lbllinea.Size = new System.Drawing.Size(140, 20);
            this.lbllinea.TabIndex = 19;
            this.lbllinea.Text = "Linea de vehiculo";
            // 
            // cmbTipo_Vehiculo
            // 
            this.cmbTipo_Vehiculo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTipo_Vehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo_Vehiculo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo_Vehiculo.FormattingEnabled = true;
            this.cmbTipo_Vehiculo.Location = new System.Drawing.Point(267, 102);
            this.cmbTipo_Vehiculo.Name = "cmbTipo_Vehiculo";
            this.cmbTipo_Vehiculo.Size = new System.Drawing.Size(211, 24);
            this.cmbTipo_Vehiculo.TabIndex = 6;
            // 
            // cmbEstado_Vehiculo
            // 
            this.cmbEstado_Vehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado_Vehiculo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado_Vehiculo.FormattingEnabled = true;
            this.cmbEstado_Vehiculo.Location = new System.Drawing.Point(22, 101);
            this.cmbEstado_Vehiculo.Name = "cmbEstado_Vehiculo";
            this.cmbEstado_Vehiculo.Size = new System.Drawing.Size(204, 24);
            this.cmbEstado_Vehiculo.TabIndex = 5;
            // 
            // cmbModelo_Vehiculo
            // 
            this.cmbModelo_Vehiculo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbModelo_Vehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo_Vehiculo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModelo_Vehiculo.FormattingEnabled = true;
            this.cmbModelo_Vehiculo.Location = new System.Drawing.Point(267, 38);
            this.cmbModelo_Vehiculo.Name = "cmbModelo_Vehiculo";
            this.cmbModelo_Vehiculo.Size = new System.Drawing.Size(211, 24);
            this.cmbModelo_Vehiculo.TabIndex = 2;
            this.cmbModelo_Vehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbModelo_Vehiculo_SelectedIndexChanged);
            // 
            // cmbMarca_vehiculo
            // 
            this.cmbMarca_vehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca_vehiculo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarca_vehiculo.FormattingEnabled = true;
            this.cmbMarca_vehiculo.Location = new System.Drawing.Point(22, 38);
            this.cmbMarca_vehiculo.Name = "cmbMarca_vehiculo";
            this.cmbMarca_vehiculo.Size = new System.Drawing.Size(204, 24);
            this.cmbMarca_vehiculo.TabIndex = 1;
            this.cmbMarca_vehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_vehiculo_SelectedIndexChanged);
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblestado.Location = new System.Drawing.Point(47, 78);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(153, 20);
            this.lblestado.TabIndex = 14;
            this.lblestado.Text = "Estado del vehiculo";
            // 
            // lbltipovehiculo
            // 
            this.lbltipovehiculo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltipovehiculo.AutoSize = true;
            this.lbltipovehiculo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipovehiculo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbltipovehiculo.Location = new System.Drawing.Point(331, 78);
            this.lbltipovehiculo.Name = "lbltipovehiculo";
            this.lbltipovehiculo.Size = new System.Drawing.Size(105, 20);
            this.lbltipovehiculo.TabIndex = 13;
            this.lbltipovehiculo.Text = "Tipo vehiculo";
            // 
            // lblmodelo
            // 
            this.lblmodelo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblmodelo.AutoSize = true;
            this.lblmodelo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodelo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblmodelo.Location = new System.Drawing.Point(292, 14);
            this.lblmodelo.Name = "lblmodelo";
            this.lblmodelo.Size = new System.Drawing.Size(159, 20);
            this.lblmodelo.TabIndex = 11;
            this.lblmodelo.Text = "Modelo de vehiculo";
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarca.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblmarca.Location = new System.Drawing.Point(47, 15);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(151, 20);
            this.lblmarca.TabIndex = 10;
            this.lblmarca.Text = "Marca de vehiculo";
            this.lblmarca.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtIdvehiculo
            // 
            this.txtIdvehiculo.Location = new System.Drawing.Point(909, 12);
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
            this.btnupdate.Location = new System.Drawing.Point(419, 275);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Normalcolor = System.Drawing.Color.Gold;
            this.btnupdate.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnupdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnupdate.selected = false;
            this.btnupdate.Size = new System.Drawing.Size(182, 56);
            this.btnupdate.TabIndex = 13;
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
            this.btnmostrar.Location = new System.Drawing.Point(220, 275);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Normalcolor = System.Drawing.Color.Gold;
            this.btnmostrar.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnmostrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnmostrar.selected = false;
            this.btnmostrar.Size = new System.Drawing.Size(182, 56);
            this.btnmostrar.TabIndex = 12;
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
            this.btneliminar.Location = new System.Drawing.Point(618, 275);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Normalcolor = System.Drawing.Color.Gold;
            this.btneliminar.OnHovercolor = System.Drawing.Color.DimGray;
            this.btneliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneliminar.selected = false;
            this.btneliminar.Size = new System.Drawing.Size(182, 56);
            this.btneliminar.TabIndex = 14;
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
            this.btnregistrar.Location = new System.Drawing.Point(21, 275);
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
            this.dgvvehiculos.Location = new System.Drawing.Point(13, 337);
            this.dgvvehiculos.Name = "dgvvehiculos";
            this.dgvvehiculos.ReadOnly = true;
            this.dgvvehiculos.Size = new System.Drawing.Size(996, 342);
            this.dgvvehiculos.TabIndex = 15;
            this.dgvvehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvehiculos_CellClick);
            this.dgvvehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvvehiculos_CellContentClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnreg,
            this.toolStripSeparator1,
            this.txtFiltrar,
            this.lblfilt});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(1016, 36);
            this.toolStrip2.TabIndex = 16;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnreg
            // 
            this.btnreg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnreg.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreg.ForeColor = System.Drawing.Color.White;
            this.btnreg.Image = ((System.Drawing.Image)(resources.GetObject("btnreg.Image")));
            this.btnreg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(169, 33);
            this.btnreg.Text = "Registro de vehiculos";
            this.btnreg.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            // lblfilt
            // 
            this.lblfilt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfilt.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblfilt.Name = "lblfilt";
            this.lblfilt.Size = new System.Drawing.Size(41, 33);
            this.lblfilt.Text = "Filtrar";
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
            this.btnlimp.Location = new System.Drawing.Point(813, 275);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Normalcolor = System.Drawing.Color.Gold;
            this.btnlimp.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnlimp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnlimp.selected = false;
            this.btnlimp.Size = new System.Drawing.Size(182, 56);
            this.btnlimp.TabIndex = 15;
            this.btnlimp.Text = "  Limpiar campos";
            this.btnlimp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlimp.Textcolor = System.Drawing.Color.Black;
            this.btnlimp.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimp.Click += new System.EventHandler(this.btnlimp_Click);
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.Gold;
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.Location = new System.Drawing.Point(762, 6);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(247, 23);
            this.btnreport.TabIndex = 17;
            this.btnreport.Text = "Generar reporte";
            this.btnreport.UseVisualStyleBackColor = false;
            this.btnreport.Click += new System.EventHandler(this.button1_Click);
            // 
            // registroauto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1016, 695);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btnlimp);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dgvvehiculos);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.grpregistro);
            this.Controls.Add(this.txtIdvehiculo);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpregistro;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lbltipovehiculo;
        private System.Windows.Forms.Label lblmodelo;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.TextBox txtIdvehiculo;
        private Bunifu.Framework.UI.BunifuFlatButton btnupdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnmostrar;
        private Bunifu.Framework.UI.BunifuFlatButton btneliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnregistrar;
        private System.Windows.Forms.DataGridView dgvvehiculos;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnreg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtFiltrar;
        private System.Windows.Forms.ToolStripLabel lblfilt;
        private System.Windows.Forms.ComboBox cmbTipo_Vehiculo;
        private System.Windows.Forms.ComboBox cmbEstado_Vehiculo;
        private System.Windows.Forms.ComboBox cmbModelo_Vehiculo;
        private System.Windows.Forms.ComboBox cmbMarca_vehiculo;
        private System.Windows.Forms.Label lblnummotor;
        private System.Windows.Forms.Label lblnumchasis;
        private System.Windows.Forms.TextBox txtchasis;
        private System.Windows.Forms.TextBox txtmotor;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.ComboBox cmbplaca;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.ComboBox cmbLinea;
        private System.Windows.Forms.Label lbllinea;
        private Bunifu.Framework.UI.BunifuFlatButton btnlimp;
        private System.Windows.Forms.ComboBox cmbPropietario;
        private System.Windows.Forms.Label lblpropetario;
        private System.Windows.Forms.Button btnreport;
    }
}