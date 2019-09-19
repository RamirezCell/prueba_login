namespace prueba_login.reportes
{
    partial class reportevehiculos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetvehiculo = new prueba_login.reportes.DataSetvehiculo();
            this.tbvehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbvehiculosTableAdapter = new prueba_login.reportes.DataSetvehiculoTableAdapters.tbvehiculosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbmarca = new System.Windows.Forms.ComboBox();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.btntodo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetvehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbvehiculosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 362);
            this.panel1.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSetvehiculos";
            reportDataSource3.Value = this.tbvehiculosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "prueba_login.reportes.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(782, 362);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetvehiculo
            // 
            this.DataSetvehiculo.DataSetName = "DataSetvehiculo";
            this.DataSetvehiculo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbvehiculosBindingSource
            // 
            this.tbvehiculosBindingSource.DataMember = "tbvehiculos";
            this.tbvehiculosBindingSource.DataSource = this.DataSetvehiculo;
            // 
            // tbvehiculosTableAdapter
            // 
            this.tbvehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione la marca que desea visualizar";
            // 
            // cmbmarca
            // 
            this.cmbmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmarca.FormattingEnabled = true;
            this.cmbmarca.Location = new System.Drawing.Point(214, 1);
            this.cmbmarca.Name = "cmbmarca";
            this.cmbmarca.Size = new System.Drawing.Size(219, 21);
            this.cmbmarca.TabIndex = 4;
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Location = new System.Drawing.Point(439, 0);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(119, 23);
            this.btnfiltrar.TabIndex = 5;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = true;
            // 
            // btntodo
            // 
            this.btntodo.Location = new System.Drawing.Point(565, 0);
            this.btntodo.Name = "btntodo";
            this.btntodo.Size = new System.Drawing.Size(139, 23);
            this.btntodo.TabIndex = 6;
            this.btntodo.Text = "Cargar todo";
            this.btntodo.UseVisualStyleBackColor = true;
            // 
            // reportevehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 386);
            this.Controls.Add(this.btntodo);
            this.Controls.Add(this.btnfiltrar);
            this.Controls.Add(this.cmbmarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "reportevehiculos";
            this.Text = "reportevehiculos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.reportevehiculos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetvehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbvehiculosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbvehiculosBindingSource;
        private DataSetvehiculo DataSetvehiculo;
        private DataSetvehiculoTableAdapters.tbvehiculosTableAdapter tbvehiculosTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbmarca;
        private System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.Button btntodo;
    }
}