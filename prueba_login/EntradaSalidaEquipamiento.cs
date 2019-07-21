using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba_login
{
    public partial class EntradaSalidaEquipamiento : Form
    {
        public EntradaSalidaEquipamiento()
        {
            InitializeComponent();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.White;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE";
                txtNombre.ForeColor = Color.White;
            }
        }

        private void txtFechaEntrada_Enter(object sender, EventArgs e)
        {
            if (txtFechaEntrada.Text == "FECHA DE ENTRADA")
            {
                txtFechaEntrada.Text = "";
                txtFechaEntrada.ForeColor = Color.White;
            }
        }

        private void txtFechaEntrada_Leave(object sender, EventArgs e)
        {
            if (txtFechaEntrada.Text == "")
            {
                txtFechaEntrada.Text = "FECHA DE ENTRADA";
                txtFechaEntrada.ForeColor = Color.White;
            }
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "CÓDIGO")
            {
                txtCodigo.Text = "";
                txtCodigo.ForeColor = Color.White;
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                txtCodigo.Text = "CÓDIGO";
                txtCodigo.ForeColor = Color.White;
            }
        }

        private void txtFechaSalida_Enter(object sender, EventArgs e)
        {
            if (txtFechaSalida.Text == "FECHA DE SALIDA")
            {
                txtFechaSalida.Text = "";
                txtFechaSalida.ForeColor = Color.White;
            }
        }

        private void txtFechaSalida_Leave(object sender, EventArgs e)
        {
            if (txtFechaSalida.Text == "")
            {
                txtFechaSalida.Text = "FECHA DE SALIDA";
                txtFechaSalida.ForeColor = Color.White;
            }
        }
    }
}
