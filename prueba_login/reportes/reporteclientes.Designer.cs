namespace prueba_login.reportes
{
    partial class reporteclientes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetcliente = new prueba_login.reportes.DataSetcliente();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbclientesTableAdapter = new prueba_login.reportes.DataSetclienteTableAdapters.tbclientesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbtipocliente = new System.Windows.Forms.ComboBox();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.btntodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbclientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetcliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbclientesBindingSource
            // 
            this.tbclientesBindingSource.DataMember = "tbclientes";
            this.tbclientesBindingSource.DataSource = this.DataSetcliente;
            // 
            // DataSetcliente
            // 
            this.DataSetcliente.DataSetName = "DataSetcliente";
            this.DataSetcliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 393);
            this.panel1.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetclientes";
            reportDataSource1.Value = this.tbclientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "prueba_login.reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(798, 393);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbclientesTableAdapter
            // 
            this.tbclientesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione el tipo de cliente que desea visualizar";
            // 
            // cmbtipocliente
            // 
            this.cmbtipocliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipocliente.FormattingEnabled = true;
            this.cmbtipocliente.Location = new System.Drawing.Point(259, 1);
            this.cmbtipocliente.Name = "cmbtipocliente";
            this.cmbtipocliente.Size = new System.Drawing.Size(121, 21);
            this.cmbtipocliente.TabIndex = 3;
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Location = new System.Drawing.Point(396, 0);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(119, 23);
            this.btnfiltrar.TabIndex = 4;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = true;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // btntodo
            // 
            this.btntodo.Location = new System.Drawing.Point(521, 0);
            this.btntodo.Name = "btntodo";
            this.btntodo.Size = new System.Drawing.Size(139, 23);
            this.btntodo.TabIndex = 5;
            this.btntodo.Text = "Cargar todo";
            this.btntodo.UseVisualStyleBackColor = true;
            this.btntodo.Click += new System.EventHandler(this.btntodo_Click);
            // 
            // reporteclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 417);
            this.Controls.Add(this.btntodo);
            this.Controls.Add(this.btnfiltrar);
            this.Controls.Add(this.cmbtipocliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "reporteclientes";
            this.Text = "reporteclientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.reporteclientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbclientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetcliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbclientesBindingSource;
        private DataSetcliente DataSetcliente;
        private DataSetclienteTableAdapters.tbclientesTableAdapter tbclientesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbtipocliente;
        private System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.Button btntodo;
    }
}