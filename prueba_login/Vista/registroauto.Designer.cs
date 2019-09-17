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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtchasis = new System.Windows.Forms.TextBox();
            this.txtmotor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbplaca = new System.Windows.Forms.ComboBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.cmbLinea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipo_Vehiculo = new System.Windows.Forms.ComboBox();
            this.cmbEstado_Vehiculo = new System.Windows.Forms.ComboBox();
            this.cmbModelo_Vehiculo = new System.Windows.Forms.ComboBox();
            this.cmbMarca_vehiculo = new System.Windows.Forms.ComboBox();
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
            this.btnlimp = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.grpregistro.Controls.Add(this.label8);
            this.grpregistro.Controls.Add(this.label7);
            this.grpregistro.Controls.Add(this.label4);
            this.grpregistro.Controls.Add(this.txtchasis);
            this.grpregistro.Controls.Add(this.txtmotor);
            this.grpregistro.Controls.Add(this.label2);
            this.grpregistro.Controls.Add(this.cmbplaca);
            this.grpregistro.Controls.Add(this.txtplaca);
            this.grpregistro.Controls.Add(this.cmbLinea);
            this.grpregistro.Controls.Add(this.label1);
            this.grpregistro.Controls.Add(this.cmbTipo_Vehiculo);
            this.grpregistro.Controls.Add(this.cmbEstado_Vehiculo);
            this.grpregistro.Controls.Add(this.cmbModelo_Vehiculo);
            this.grpregistro.Controls.Add(this.cmbMarca_vehiculo);
            this.grpregistro.Controls.Add(this.label6);
            this.grpregistro.Controls.Add(this.label5);
            this.grpregistro.Controls.Add(this.label3);
            this.grpregistro.Controls.Add(this.label);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(31, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Propietario del vehiculo";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(797, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Numero del motor";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(785, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Numero de Chasis";
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
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(572, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Placa del vehiculo";
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(572, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Linea de vehiculo";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(47, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Estado del vehiculo";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(331, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tipo vehiculo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(292, 14);
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
            this.label.Location = new System.Drawing.Point(47, 15);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(151, 20);
            this.label.TabIndex = 10;
            this.label.Text = "Marca de vehiculo";
            this.label.Click += new System.EventHandler(this.label2_Click);
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
            this.txtFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // registroauto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1016, 695);
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
        private System.Windows.Forms.ComboBox cmbTipo_Vehiculo;
        private System.Windows.Forms.ComboBox cmbEstado_Vehiculo;
        private System.Windows.Forms.ComboBox cmbModelo_Vehiculo;
        private System.Windows.Forms.ComboBox cmbMarca_vehiculo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtchasis;
        private System.Windows.Forms.TextBox txtmotor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbplaca;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.ComboBox cmbLinea;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnlimp;
        private System.Windows.Forms.ComboBox cmbPropietario;
        private System.Windows.Forms.Label label8;
    }
}