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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtfiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.grpregistro = new System.Windows.Forms.GroupBox();
            this.btnexaminar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pctlogo = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.txtdui = new System.Windows.Forms.MaskedTextBox();
            this.txtnum = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboc = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcifrado = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dgvuser = new System.Windows.Forms.DataGridView();
            this.btnrecuperacion = new System.Windows.Forms.Button();
            this.btnlimp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnupdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnmostrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnregistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.grpregistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.txtfiltrar,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1016, 36);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // txtfiltrar
            // 
            this.txtfiltrar.Name = "txtfiltrar";
            this.txtfiltrar.Size = new System.Drawing.Size(100, 36);
            this.txtfiltrar.Click += new System.EventHandler(this.txtfiltrar_Click);
            this.txtfiltrar.TextChanged += new System.EventHandler(this.txtfiltrar_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 33);
            this.toolStripLabel1.Text = "Flitrar";
            // 
            // grpregistro
            // 
            this.grpregistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpregistro.Controls.Add(this.btnexaminar);
            this.grpregistro.Controls.Add(this.label13);
            this.grpregistro.Controls.Add(this.pctlogo);
            this.grpregistro.Controls.Add(this.label12);
            this.grpregistro.Controls.Add(this.txtuser);
            this.grpregistro.Controls.Add(this.label11);
            this.grpregistro.Controls.Add(this.label8);
            this.grpregistro.Controls.Add(this.cmbgender);
            this.grpregistro.Controls.Add(this.txtdui);
            this.grpregistro.Controls.Add(this.txtnum);
            this.grpregistro.Controls.Add(this.label7);
            this.grpregistro.Controls.Add(this.label6);
            this.grpregistro.Controls.Add(this.label5);
            this.grpregistro.Controls.Add(this.label4);
            this.grpregistro.Controls.Add(this.label3);
            this.grpregistro.Controls.Add(this.label2);
            this.grpregistro.Controls.Add(this.label1);
            this.grpregistro.Controls.Add(this.cmboc);
            this.grpregistro.Controls.Add(this.txtDireccion);
            this.grpregistro.Controls.Add(this.txtcorreo);
            this.grpregistro.Controls.Add(this.txtapellido);
            this.grpregistro.Controls.Add(this.txtnombre);
            this.grpregistro.Location = new System.Drawing.Point(12, 49);
            this.grpregistro.Name = "grpregistro";
            this.grpregistro.Size = new System.Drawing.Size(992, 230);
            this.grpregistro.TabIndex = 3;
            this.grpregistro.TabStop = false;
            this.grpregistro.Enter += new System.EventHandler(this.grpregistro_Enter);
            // 
            // btnexaminar
            // 
            this.btnexaminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexaminar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnexaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexaminar.Location = new System.Drawing.Point(810, 197);
            this.btnexaminar.Name = "btnexaminar";
            this.btnexaminar.Size = new System.Drawing.Size(75, 23);
            this.btnexaminar.TabIndex = 30;
            this.btnexaminar.Text = "Examinar";
            this.btnexaminar.UseVisualStyleBackColor = false;
            this.btnexaminar.Click += new System.EventHandler(this.btnexaminar_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(792, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Foto de perfil";
            // 
            // pctlogo
            // 
            this.pctlogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctlogo.BackColor = System.Drawing.Color.White;
            this.pctlogo.Location = new System.Drawing.Point(775, 39);
            this.pctlogo.Name = "pctlogo";
            this.pctlogo.Size = new System.Drawing.Size(138, 150);
            this.pctlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctlogo.TabIndex = 28;
            this.pctlogo.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(629, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Intentos";
            // 
            // txtuser
            // 
            this.txtuser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtuser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(536, 111);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(164, 23);
            this.txtuser.TabIndex = 7;
            this.txtuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuser_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(588, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Usuario";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(578, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Genero";
            // 
            // cmbgender
            // 
            this.cmbgender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Location = new System.Drawing.Point(534, 175);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(166, 21);
            this.cmbgender.TabIndex = 4;
            // 
            // txtdui
            // 
            this.txtdui.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtdui.Location = new System.Drawing.Point(301, 112);
            this.txtdui.Mask = "0000000-0";
            this.txtdui.Name = "txtdui";
            this.txtdui.Size = new System.Drawing.Size(172, 20);
            this.txtdui.TabIndex = 6;
            this.txtdui.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtdui_MaskInputRejected);
            this.txtdui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdui_KeyPress);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(58, 113);
            this.txtnum.Mask = "0000-0000";
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(180, 20);
            this.txtnum.TabIndex = 5;
            this.txtnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(347, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(74, 155);
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
            this.label5.Location = new System.Drawing.Point(371, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "DUI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(76, 86);
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
            this.label3.Location = new System.Drawing.Point(347, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(112, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(578, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ocupacion";
            // 
            // cmboc
            // 
            this.cmboc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboc.FormattingEnabled = true;
            this.cmboc.Location = new System.Drawing.Point(534, 50);
            this.cmboc.Name = "cmboc";
            this.cmboc.Size = new System.Drawing.Size(166, 21);
            this.cmboc.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDireccion.Location = new System.Drawing.Point(301, 178);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(172, 46);
            this.txtDireccion.TabIndex = 10;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtcorreo
            // 
            this.txtcorreo.BackColor = System.Drawing.Color.White;
            this.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcorreo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcorreo.Location = new System.Drawing.Point(58, 183);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(180, 19);
            this.txtcorreo.TabIndex = 9;
            this.txtcorreo.TextChanged += new System.EventHandler(this.txtcorreo_TextChanged);
            this.txtcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcorreo_KeyPress);
            // 
            // txtapellido
            // 
            this.txtapellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtapellido.BackColor = System.Drawing.Color.White;
            this.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtapellido.Location = new System.Drawing.Point(301, 48);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(172, 19);
            this.txtapellido.TabIndex = 2;
            this.txtapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellido_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.White;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtnombre.Location = new System.Drawing.Point(58, 48);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(180, 19);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtcifrado
            // 
            this.txtcifrado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcifrado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcifrado.Location = new System.Drawing.Point(429, 6);
            this.txtcifrado.Name = "txtcifrado";
            this.txtcifrado.Size = new System.Drawing.Size(137, 23);
            this.txtcifrado.TabIndex = 12;
            this.txtcifrado.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtId.Location = new System.Drawing.Point(355, 9);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(64, 20);
            this.txtId.TabIndex = 8;
            this.txtId.Visible = false;
            // 
            // dgvuser
            // 
            this.dgvuser.AllowUserToAddRows = false;
            this.dgvuser.AllowUserToDeleteRows = false;
            this.dgvuser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvuser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuser.Location = new System.Drawing.Point(12, 371);
            this.dgvuser.Name = "dgvuser";
            this.dgvuser.ReadOnly = true;
            this.dgvuser.Size = new System.Drawing.Size(992, 310);
            this.dgvuser.TabIndex = 15;
            this.dgvuser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcliente_CellClick);
            this.dgvuser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcliente_CellContentClick);
            // 
            // btnrecuperacion
            // 
            this.btnrecuperacion.BackColor = System.Drawing.Color.Goldenrod;
            this.btnrecuperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecuperacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecuperacion.Location = new System.Drawing.Point(628, 2);
            this.btnrecuperacion.Name = "btnrecuperacion";
            this.btnrecuperacion.Size = new System.Drawing.Size(198, 31);
            this.btnrecuperacion.TabIndex = 18;
            this.btnrecuperacion.Text = "Recuperacion de contraseña";
            this.btnrecuperacion.UseVisualStyleBackColor = false;
            this.btnrecuperacion.Click += new System.EventHandler(this.btnrecuperacion_Click);
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
            this.btnlimp.Location = new System.Drawing.Point(818, 299);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Normalcolor = System.Drawing.Color.Gold;
            this.btnlimp.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnlimp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnlimp.selected = false;
            this.btnlimp.Size = new System.Drawing.Size(182, 56);
            this.btnlimp.TabIndex = 19;
            this.btnlimp.Text = "  Limpiar campos";
            this.btnlimp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlimp.Textcolor = System.Drawing.Color.Black;
            this.btnlimp.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimp.Click += new System.EventHandler(this.btnlimp_Click);
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
            this.btnupdate.Location = new System.Drawing.Point(418, 299);
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
            this.btnmostrar.Location = new System.Drawing.Point(219, 299);
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
            this.btneliminar.Location = new System.Drawing.Point(617, 299);
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
            this.btnregistrar.Location = new System.Drawing.Point(20, 299);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // registrotrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1016, 693);
            this.Controls.Add(this.btnlimp);
            this.Controls.Add(this.btnrecuperacion);
            this.Controls.Add(this.dgvuser);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.txtcifrado);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.grpregistro);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registrotrabajador";
            this.Text = "registrotrabajador";
            this.Load += new System.EventHandler(this.registrotrabajador_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpregistro.ResumeLayout(false);
            this.grpregistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox cmboc;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private Bunifu.Framework.UI.BunifuFlatButton btnupdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnmostrar;
        private Bunifu.Framework.UI.BunifuFlatButton btneliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnregistrar;
        private System.Windows.Forms.DataGridView dgvuser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtcifrado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtfiltrar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button btnrecuperacion;
        private System.Windows.Forms.Button btnexaminar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pctlogo;
        private Bunifu.Framework.UI.BunifuFlatButton btnlimp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}