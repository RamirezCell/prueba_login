using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using prueba_login.Modelo;

namespace prueba_login
{
    public partial class supervisionequipo : Form
    {
        public supervisionequipo()
        {
            InitializeComponent();
        }

        private void supervisionequipo_Load(object sender, EventArgs e)
        {

        }
       

        private void btnenviar_Click(object sender, EventArgs e)
        {
            dgtmaterial.DataSource = mostrarmaterial.mostrar();
        }
    }
}
