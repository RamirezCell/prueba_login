﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using prueba_login.Controlador;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prueba_login.Modelo;

namespace prueba_login.reportes
{
    public partial class reportevehiculos : Form
    {
        public reportevehiculos()
        {
            InitializeComponent();
        }

        int idauto = constructorvehiculo.id_vehiculo;
        void cargar() {
            
           
        }

        private void reportevehiculos_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'DataSetvehiculo.tbvehiculos' table. You can move, or remove it, as needed.
            this.tbvehiculosTableAdapter.cargarvehiculos(this.DataSetvehiculo.tbvehiculos);

            this.reportViewer1.RefreshReport();
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
