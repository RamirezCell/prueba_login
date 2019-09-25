namespace prueba_login
{
    partial class Aseguradora
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtnit = new System.Windows.Forms.MaskedTextBox();
            this.pctlogo = new System.Windows.Forms.PictureBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtrepresentante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnexaminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnregistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnmostrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnupdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnlimp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctlogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1016, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(134, 22);
            this.toolStripLabel1.Text = "Registro de aseguradora";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(76, 113);
            this.txtnombre.MaxLength = 25;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(236, 20);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(46, 145);
            this.txttelefono.Mask = "0000-0000";
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(233, 20);
            this.txttelefono.TabIndex = 3;
            this.txttelefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // txtnit
            // 
            this.txtnit.Location = new System.Drawing.Point(76, 286);
            this.txtnit.Mask = "0000-00000000-000-0";
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(236, 20);
            this.txtnit.TabIndex = 5;
            this.txtnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnit_KeyPress);
            // 
            // pctlogo
            // 
            this.pctlogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctlogo.BackColor = System.Drawing.Color.White;
            this.pctlogo.Location = new System.Drawing.Point(710, 57);
            this.pctlogo.Name = "pctlogo";
            this.pctlogo.Size = new System.Drawing.Size(150, 163);
            this.pctlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctlogo.TabIndex = 5;
            this.pctlogo.TabStop = false;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcorreo.Location = new System.Drawing.Point(377, 113);
            this.txtcorreo.MaxLength = 25;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(248, 20);
            this.txtcorreo.TabIndex = 2;
            this.txtcorreo.TextChanged += new System.EventHandler(this.txtcorreo_TextChanged);
            // 
            // txtrepresentante
            // 
            this.txtrepresentante.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtrepresentante.Location = new System.Drawing.Point(377, 201);
            this.txtrepresentante.MaxLength = 25;
            this.txtrepresentante.Name = "txtrepresentante";
            this.txtrepresentante.Size = new System.Drawing.Size(248, 20);
            this.txtrepresentante.TabIndex = 4;
            this.txtrepresentante.TextChanged += new System.EventHandler(this.txtrepresentante_TextChanged);
            this.txtrepresentante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrepresentante_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre de aseguradora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numero de telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "NIT";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(374, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Correo electronico";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(374, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Representante Legal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(707, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Logo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.btnexaminar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.pctlogo);
            this.groupBox1.Location = new System.Drawing.Point(33, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 279);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(344, 171);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(89, 20);
            this.txtId.TabIndex = 0;
            this.txtId.Visible = false;
            // 
            // btnexaminar
            // 
            this.btnexaminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexaminar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnexaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexaminar.Location = new System.Drawing.Point(749, 230);
            this.btnexaminar.Name = "btnexaminar";
            this.btnexaminar.Size = new System.Drawing.Size(75, 23);
            this.btnexaminar.TabIndex = 6;
            this.btnexaminar.Text = "Examinar";
            this.btnexaminar.UseVisualStyleBackColor = false;
            this.btnexaminar.Click += new System.EventHandler(this.btnexaminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 416);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(952, 265);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.btnregistrar.Location = new System.Drawing.Point(27, 346);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Normalcolor = System.Drawing.Color.Gold;
            this.btnregistrar.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnregistrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnregistrar.selected = false;
            this.btnregistrar.Size = new System.Drawing.Size(182, 56);
            this.btnregistrar.TabIndex = 7;
            this.btnregistrar.Text = "      Registrar";
            this.btnregistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistrar.Textcolor = System.Drawing.Color.Black;
            this.btnregistrar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
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
            this.btnmostrar.Location = new System.Drawing.Point(226, 346);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Normalcolor = System.Drawing.Color.Gold;
            this.btnmostrar.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnmostrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnmostrar.selected = false;
            this.btnmostrar.Size = new System.Drawing.Size(182, 56);
            this.btnmostrar.TabIndex = 8;
            this.btnmostrar.Text = "      Mostrar";
            this.btnmostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmostrar.Textcolor = System.Drawing.Color.Black;
            this.btnmostrar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
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
            this.btnupdate.Location = new System.Drawing.Point(421, 346);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Normalcolor = System.Drawing.Color.Gold;
            this.btnupdate.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnupdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnupdate.selected = false;
            this.btnupdate.Size = new System.Drawing.Size(182, 56);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "      Actualizar";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Textcolor = System.Drawing.Color.Black;
            this.btnupdate.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
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
            this.btneliminar.Location = new System.Drawing.Point(616, 346);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Normalcolor = System.Drawing.Color.Gold;
            this.btneliminar.OnHovercolor = System.Drawing.Color.DimGray;
            this.btneliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneliminar.selected = false;
            this.btneliminar.Size = new System.Drawing.Size(182, 56);
            this.btneliminar.TabIndex = 10;
            this.btneliminar.Text = "     Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Textcolor = System.Drawing.Color.Black;
            this.btneliminar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
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
            this.btnlimp.Location = new System.Drawing.Point(813, 346);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Normalcolor = System.Drawing.Color.Gold;
            this.btnlimp.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnlimp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnlimp.selected = false;
            this.btnlimp.Size = new System.Drawing.Size(182, 56);
            this.btnlimp.TabIndex = 11;
            this.btnlimp.Text = "  Limpiar campos";
            this.btnlimp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlimp.Textcolor = System.Drawing.Color.Black;
            this.btnlimp.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimp.Click += new System.EventHandler(this.btnlimp_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(706, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Generar reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Aseguradora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1016, 693);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnlimp);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtrepresentante);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtnit);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Aseguradora";
            this.Text = "Aseguradora";
            this.Load += new System.EventHandler(this.Aseguradora_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctlogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.MaskedTextBox txttelefono;
        private System.Windows.Forms.MaskedTextBox txtnit;
        private System.Windows.Forms.PictureBox pctlogo;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtrepresentante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnexaminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuFlatButton btnregistrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnmostrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnupdate;
        private Bunifu.Framework.UI.BunifuFlatButton btneliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnlimp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button1;
    }
}