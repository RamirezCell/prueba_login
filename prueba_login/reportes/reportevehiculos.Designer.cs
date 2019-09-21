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
            this.tbvehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetvehiculo = new prueba_login.reportes.DataSetvehiculo();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbvehiculosTableAdapter = new prueba_login.reportes.DataSetvehiculoTableAdapters.tbvehiculosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbvehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetvehiculo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbvehiculosBindingSource
            // 
            this.tbvehiculosBindingSource.DataMember = "tbvehiculos";
            this.tbvehiculosBindingSource.DataSource = this.DataSetvehiculo;
            // 
            // DataSetvehiculo
            // 
            this.DataSetvehiculo.DataSetName = "DataSetvehiculo";
            this.DataSetvehiculo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
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
            // tbvehiculosTableAdapter
            // 
            this.tbvehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // reportevehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 386);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "reportevehiculos";
            this.Text = "reportevehiculos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.reportevehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbvehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetvehiculo)).EndInit();
            this.panel1.ResumeLayout(false);
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
    }
}