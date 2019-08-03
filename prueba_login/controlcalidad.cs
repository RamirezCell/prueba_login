using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prueba_login.Controlador;
using prueba_login.Modelo;

namespace prueba_login
{
    public partial class controlcalidad : Form
    {
        public controlcalidad()
        {
            InitializeComponent();
        }

        private void controlcalidad_Load(object sender, EventArgs e)
        {

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            registrar();
        }

        public void registrar()
        {
            
            constructordetalle add = new constructordetalle();
            if (rbsi.Checked)
            {
                add.aprobado = "Si";
            }
            else if (rbno.Checked)
            {
                add.aprobado = "No";
            }

            add.detallefin = txtdes.Text;
            add.detalleacabado = txtdet.Text;
            int datos = funcioncontrol.agregar(add);
        }
    }
}
