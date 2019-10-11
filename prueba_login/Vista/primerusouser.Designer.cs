namespace prueba_login
{
    partial class primerusouser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(primerusouser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btncerrar = new System.Windows.Forms.ToolStripButton();
            this.tpuser = new System.Windows.Forms.ToolStripButton();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.lbldui = new System.Windows.Forms.Label();
            this.txtdui = new System.Windows.Forms.MaskedTextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.MaskedTextBox();
            this.lblnum = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.lblestate = new System.Windows.Forms.Label();
            this.lblgenero = new System.Windows.Forms.Label();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.lblocu = new System.Windows.Forms.Label();
            this.cmbocupacion = new System.Windows.Forms.ComboBox();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblnac = new System.Windows.Forms.Label();
            this.lblfoto = new System.Windows.Forms.Label();
            this.pctlogo = new System.Windows.Forms.PictureBox();
            this.btnex = new System.Windows.Forms.Button();
            this.tip = new System.Windows.Forms.Label();
            this.lblcam = new System.Windows.Forms.Label();
            this.grppre = new System.Windows.Forms.GroupBox();
            this.btnguadar = new System.Windows.Forms.Button();
            this.lblp3 = new System.Windows.Forms.Label();
            this.lblp2 = new System.Windows.Forms.Label();
            this.txtp3 = new System.Windows.Forms.TextBox();
            this.txtp2 = new System.Windows.Forms.TextBox();
            this.lblp1 = new System.Windows.Forms.Label();
            this.txtp1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtxcifrado = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.validar = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctlogo)).BeginInit();
            this.grppre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validar)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btncerrar,
            this.tpuser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(914, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btncerrar
            // 
            this.btncerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btncerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btncerrar.Image = global::prueba_login.Properties.Resources.Close_Window__2_48px2;
            this.btncerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(23, 22);
            this.btncerrar.Text = "Salir";
            this.btncerrar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tpuser
            // 
            this.tpuser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tpuser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpuser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tpuser.Image = ((System.Drawing.Image)(resources.GetObject("tpuser.Image")));
            this.tpuser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tpuser.Name = "tpuser";
            this.tpuser.Size = new System.Drawing.Size(136, 22);
            this.tpuser.Text = "Primer uso de usuario";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(36, 64);
            this.txtname.MaxLength = 25;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(182, 21);
            this.txtname.TabIndex = 1;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblname.Location = new System.Drawing.Point(33, 42);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(54, 16);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Nombre ";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblapellido.Location = new System.Drawing.Point(33, 110);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(51, 16);
            this.lblapellido.TabIndex = 4;
            this.lblapellido.Text = "Apellido";
            // 
            // txtapellido
            // 
            this.txtapellido.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.Location = new System.Drawing.Point(36, 132);
            this.txtapellido.MaxLength = 25;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(182, 21);
            this.txtapellido.TabIndex = 2;
            this.txtapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellido_KeyPress);
            // 
            // lbldui
            // 
            this.lbldui.AutoSize = true;
            this.lbldui.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldui.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldui.Location = new System.Drawing.Point(33, 187);
            this.lbldui.Name = "lbldui";
            this.lbldui.Size = new System.Drawing.Size(27, 16);
            this.lbldui.TabIndex = 5;
            this.lbldui.Text = "DUI";
            // 
            // txtdui
            // 
            this.txtdui.Location = new System.Drawing.Point(36, 210);
            this.txtdui.Mask = "0000000-0";
            this.txtdui.Name = "txtdui";
            this.txtdui.Size = new System.Drawing.Size(182, 20);
            this.txtdui.TabIndex = 3;
            this.txtdui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdui_KeyPress);
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldireccion.Location = new System.Drawing.Point(243, 42);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(58, 16);
            this.lbldireccion.TabIndex = 8;
            this.lbldireccion.Text = "Direccion";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(246, 66);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(182, 102);
            this.txtdireccion.TabIndex = 5;
            this.txtdireccion.TextChanged += new System.EventHandler(this.txtdireccion_TextChanged);
            this.txtdireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdireccion_KeyPress);
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(246, 214);
            this.txttel.Mask = "0000-0000";
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(182, 20);
            this.txttel.TabIndex = 6;
            this.txttel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttel_KeyPress);
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnum.Location = new System.Drawing.Point(243, 191);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(106, 16);
            this.lblnum.TabIndex = 9;
            this.lblnum.Text = "Numero telefonico";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbluser.Location = new System.Drawing.Point(243, 260);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(110, 16);
            this.lbluser.TabIndex = 12;
            this.lbluser.Text = "Nombre de usuario";
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(246, 283);
            this.txtuser.MaxLength = 20;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(182, 21);
            this.txtuser.TabIndex = 7;
            this.txtuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuser_KeyPress);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpass.Location = new System.Drawing.Point(458, 49);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(42, 16);
            this.lblpass.TabIndex = 14;
            this.lblpass.Text = "Clave";
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(461, 77);
            this.txtpass.MaxLength = 20;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(182, 21);
            this.txtpass.TabIndex = 8;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpass_KeyPress);
            // 
            // cmbestado
            // 
            this.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Location = new System.Drawing.Point(36, 282);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(184, 21);
            this.cmbestado.TabIndex = 4;
            // 
            // lblestate
            // 
            this.lblestate.AutoSize = true;
            this.lblestate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblestate.Location = new System.Drawing.Point(33, 255);
            this.lblestate.Name = "lblestate";
            this.lblestate.Size = new System.Drawing.Size(45, 16);
            this.lblestate.TabIndex = 16;
            this.lblestate.Text = "Estado";
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgenero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblgenero.Location = new System.Drawing.Point(677, 53);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(49, 16);
            this.lblgenero.TabIndex = 18;
            this.lblgenero.Text = "Genero";
            // 
            // cmbgender
            // 
            this.cmbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Location = new System.Drawing.Point(680, 77);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(184, 21);
            this.cmbgender.TabIndex = 12;
            // 
            // lblocu
            // 
            this.lblocu.AutoSize = true;
            this.lblocu.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblocu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblocu.Location = new System.Drawing.Point(458, 110);
            this.lblocu.Name = "lblocu";
            this.lblocu.Size = new System.Drawing.Size(71, 16);
            this.lblocu.TabIndex = 20;
            this.lblocu.Text = "Ocupacion";
            // 
            // cmbocupacion
            // 
            this.cmbocupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbocupacion.FormattingEnabled = true;
            this.cmbocupacion.Location = new System.Drawing.Point(461, 132);
            this.cmbocupacion.Name = "cmbocupacion";
            this.cmbocupacion.Size = new System.Drawing.Size(184, 21);
            this.cmbocupacion.TabIndex = 9;
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorreo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcorreo.Location = new System.Drawing.Point(460, 183);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(107, 16);
            this.lblcorreo.TabIndex = 22;
            this.lblcorreo.Text = "Correo electronico";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(463, 205);
            this.txtcorreo.MaxLength = 76;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(182, 21);
            this.txtcorreo.TabIndex = 10;
            this.txtcorreo.TextChanged += new System.EventHandler(this.txtcorreo_TextChanged);
            this.txtcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcorreo_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(461, 284);
            this.dateTimePicker1.MaxDate = new System.DateTime(1999, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1940, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(1999, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblnac
            // 
            this.lblnac.AutoSize = true;
            this.lblnac.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnac.Location = new System.Drawing.Point(460, 255);
            this.lblnac.Name = "lblnac";
            this.lblnac.Size = new System.Drawing.Size(124, 16);
            this.lblnac.TabIndex = 24;
            this.lblnac.Text = "Fecha de nacimiento";
            // 
            // lblfoto
            // 
            this.lblfoto.AutoSize = true;
            this.lblfoto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblfoto.Location = new System.Drawing.Point(724, 118);
            this.lblfoto.Name = "lblfoto";
            this.lblfoto.Size = new System.Drawing.Size(77, 16);
            this.lblfoto.TabIndex = 25;
            this.lblfoto.Text = "Foto de perfil";
            // 
            // pctlogo
            // 
            this.pctlogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pctlogo.Location = new System.Drawing.Point(704, 145);
            this.pctlogo.Name = "pctlogo";
            this.pctlogo.Size = new System.Drawing.Size(119, 126);
            this.pctlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctlogo.TabIndex = 26;
            this.pctlogo.TabStop = false;
            this.pctlogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnex
            // 
            this.btnex.BackColor = System.Drawing.Color.Gold;
            this.btnex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnex.ForeColor = System.Drawing.Color.Black;
            this.btnex.Location = new System.Drawing.Point(695, 281);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(137, 29);
            this.btnex.TabIndex = 13;
            this.btnex.Text = "Examinar";
            this.btnex.UseVisualStyleBackColor = false;
            this.btnex.Click += new System.EventHandler(this.btnex_Click);
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip.ForeColor = System.Drawing.Color.Yellow;
            this.tip.Location = new System.Drawing.Point(553, 336);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(334, 16);
            this.tip.TabIndex = 28;
            this.tip.Text = "Haz clic en examinar para cargar la foto de perfil del usuario";
            // 
            // lblcam
            // 
            this.lblcam.AutoSize = true;
            this.lblcam.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcam.ForeColor = System.Drawing.Color.Yellow;
            this.lblcam.Location = new System.Drawing.Point(333, 336);
            this.lblcam.Name = "lblcam";
            this.lblcam.Size = new System.Drawing.Size(187, 16);
            this.lblcam.TabIndex = 29;
            this.lblcam.Text = "Todos los campos son obligatorios";
            // 
            // grppre
            // 
            this.grppre.Controls.Add(this.btnguadar);
            this.grppre.Controls.Add(this.lblp3);
            this.grppre.Controls.Add(this.lblp2);
            this.grppre.Controls.Add(this.txtp3);
            this.grppre.Controls.Add(this.txtp2);
            this.grppre.Controls.Add(this.lblp1);
            this.grppre.Controls.Add(this.txtp1);
            this.grppre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grppre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grppre.Location = new System.Drawing.Point(36, 369);
            this.grppre.Name = "grppre";
            this.grppre.Size = new System.Drawing.Size(828, 243);
            this.grppre.TabIndex = 30;
            this.grppre.TabStop = false;
            this.grppre.Text = "Preguntas de seguridad";
            // 
            // btnguadar
            // 
            this.btnguadar.BackColor = System.Drawing.Color.Gold;
            this.btnguadar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguadar.ForeColor = System.Drawing.Color.Black;
            this.btnguadar.Location = new System.Drawing.Point(327, 199);
            this.btnguadar.Name = "btnguadar";
            this.btnguadar.Size = new System.Drawing.Size(137, 29);
            this.btnguadar.TabIndex = 17;
            this.btnguadar.Text = "Guardar y continuar";
            this.btnguadar.UseVisualStyleBackColor = false;
            this.btnguadar.Click += new System.EventHandler(this.btnguadar_Click);
            // 
            // lblp3
            // 
            this.lblp3.AutoSize = true;
            this.lblp3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblp3.Location = new System.Drawing.Point(21, 165);
            this.lblp3.Name = "lblp3";
            this.lblp3.Size = new System.Drawing.Size(215, 16);
            this.lblp3.TabIndex = 16;
            this.lblp3.Text = "¿Cual es su equipo de futbol favorito?";
            // 
            // lblp2
            // 
            this.lblp2.AutoSize = true;
            this.lblp2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblp2.Location = new System.Drawing.Point(21, 113);
            this.lblp2.Name = "lblp2";
            this.lblp2.Size = new System.Drawing.Size(207, 16);
            this.lblp2.TabIndex = 15;
            this.lblp2.Text = "¿Cual es su marca de auto favorito?";
            // 
            // txtp3
            // 
            this.txtp3.Location = new System.Drawing.Point(252, 161);
            this.txtp3.MaxLength = 20;
            this.txtp3.Name = "txtp3";
            this.txtp3.Size = new System.Drawing.Size(544, 21);
            this.txtp3.TabIndex = 16;
            // 
            // txtp2
            // 
            this.txtp2.Location = new System.Drawing.Point(252, 110);
            this.txtp2.MaxLength = 20;
            this.txtp2.Name = "txtp2";
            this.txtp2.Size = new System.Drawing.Size(544, 21);
            this.txtp2.TabIndex = 15;
            // 
            // lblp1
            // 
            this.lblp1.AutoSize = true;
            this.lblp1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblp1.Location = new System.Drawing.Point(21, 61);
            this.lblp1.Name = "lblp1";
            this.lblp1.Size = new System.Drawing.Size(161, 16);
            this.lblp1.TabIndex = 14;
            this.lblp1.Text = "¿Cual es su animal favorito?";
            // 
            // txtp1
            // 
            this.txtp1.Location = new System.Drawing.Point(200, 58);
            this.txtp1.MaxLength = 20;
            this.txtp1.Name = "txtp1";
            this.txtp1.Size = new System.Drawing.Size(596, 21);
            this.txtp1.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtxcifrado
            // 
            this.txtxcifrado.Location = new System.Drawing.Point(87, 331);
            this.txtxcifrado.Name = "txtxcifrado";
            this.txtxcifrado.Size = new System.Drawing.Size(100, 20);
            this.txtxcifrado.TabIndex = 31;
            this.txtxcifrado.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // validar
            // 
            this.validar.Image = global::prueba_login.Properties.Resources.check22;
            this.validar.Location = new System.Drawing.Point(652, 208);
            this.validar.Name = "validar";
            this.validar.Size = new System.Drawing.Size(24, 18);
            this.validar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.validar.TabIndex = 32;
            this.validar.TabStop = false;
            this.validar.Visible = false;
            // 
            // primerusouser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(914, 693);
            this.Controls.Add(this.validar);
            this.Controls.Add(this.txtxcifrado);
            this.Controls.Add(this.grppre);
            this.Controls.Add(this.lblcam);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.btnex);
            this.Controls.Add(this.pctlogo);
            this.Controls.Add(this.lblfoto);
            this.Controls.Add(this.lblnac);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.lblocu);
            this.Controls.Add(this.cmbocupacion);
            this.Controls.Add(this.lblgenero);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.lblestate);
            this.Controls.Add(this.cmbestado);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtdui);
            this.Controls.Add(this.lbldui);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "primerusouser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "primerusouser";
            this.Load += new System.EventHandler(this.primerusouser_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctlogo)).EndInit();
            this.grppre.ResumeLayout(false);
            this.grppre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btncerrar;
        private System.Windows.Forms.ToolStripButton tpuser;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label lbldui;
        private System.Windows.Forms.MaskedTextBox txtdui;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.MaskedTextBox txttel;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Label lblestate;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.Label lblocu;
        private System.Windows.Forms.ComboBox cmbocupacion;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblnac;
        private System.Windows.Forms.Label lblfoto;
        private System.Windows.Forms.PictureBox pctlogo;
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Label lblcam;
        private System.Windows.Forms.GroupBox grppre;
        private System.Windows.Forms.Label lblp3;
        private System.Windows.Forms.Label lblp2;
        private System.Windows.Forms.TextBox txtp3;
        private System.Windows.Forms.TextBox txtp2;
        private System.Windows.Forms.Label lblp1;
        private System.Windows.Forms.TextBox txtp1;
        private System.Windows.Forms.Button btnguadar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtxcifrado;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox validar;
    }
}