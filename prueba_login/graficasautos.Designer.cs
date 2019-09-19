namespace prueba_login
{
    partial class graficasautos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.graficademarcas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btngrafica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graficademarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(302, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marcas mas registradas de autos";
            // 
            // graficademarcas
            // 
            chartArea1.Name = "ChartArea1";
            this.graficademarcas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficademarcas.Legends.Add(legend1);
            this.graficademarcas.Location = new System.Drawing.Point(167, 180);
            this.graficademarcas.Name = "graficademarcas";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Color = System.Drawing.Color.Goldenrod;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graficademarcas.Series.Add(series1);
            this.graficademarcas.Size = new System.Drawing.Size(731, 436);
            this.graficademarcas.TabIndex = 2;
            this.graficademarcas.Text = "chart1";
            // 
            // btngrafica
            // 
            this.btngrafica.BackColor = System.Drawing.Color.Black;
            this.btngrafica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngrafica.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrafica.ForeColor = System.Drawing.Color.White;
            this.btngrafica.Location = new System.Drawing.Point(753, 149);
            this.btngrafica.Name = "btngrafica";
            this.btngrafica.Size = new System.Drawing.Size(145, 25);
            this.btngrafica.TabIndex = 3;
            this.btngrafica.Text = "Actualizar grafica";
            this.btngrafica.UseVisualStyleBackColor = false;
            this.btngrafica.Click += new System.EventHandler(this.btngrafica_Click);
            // 
            // graficasautos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1016, 693);
            this.Controls.Add(this.btngrafica);
            this.Controls.Add(this.graficademarcas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "graficasautos";
            this.Text = "graficasautos";
            this.Load += new System.EventHandler(this.graficasautos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graficademarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficademarcas;
        private System.Windows.Forms.Button btngrafica;
    }
}