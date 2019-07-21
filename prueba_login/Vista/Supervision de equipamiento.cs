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
    public partial class Supervision_de_equipamiento : Form
    {
        public Supervision_de_equipamiento()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNombre_FontChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre de equipamiento")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.White;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre de equipamiento";
                txtNombre.ForeColor = Color.White;
            }
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "Cantidad")
            {
                txtCantidad.Text = "";
                txtCantidad.ForeColor = Color.White;
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                txtCantidad.Text = "Cantidad";
                txtCantidad.ForeColor = Color.White;
            }
        }

        private void txtFecha_Enter(object sender, EventArgs e)
        {
            if (txtFecha.Text == "Fecha de vencimiento")
            {
                txtFecha.Text = "";
                txtFecha.ForeColor = Color.White;
            }
        }

        private void txtFecha_Leave(object sender, EventArgs e)
        {
            if (txtFecha.Text == "")
            {
                txtFecha.Text = "Fecha de vencimiento";
                txtFecha.ForeColor = Color.White;
            }
        }

        private void txtCodigoEquip_Enter(object sender, EventArgs e)
        {
            if (txtCodigoEquip.Text == "Código de equipamiento")
            {
                txtCodigoEquip.Text = "";
                txtCodigoEquip.ForeColor = Color.White;
            }
        }

        private void txtCodigoEquip_Leave(object sender, EventArgs e)
        {
            if (txtCodigoEquip.Text == "")
            {
                txtCodigoEquip.Text = "Código de equipamiento";
                txtCodigoEquip.ForeColor = Color.White;
            }
        }

        private void txtCosto_Enter(object sender, EventArgs e)
        {
            if (txtCosto.Text == "Costo")
            {
                txtCosto.Text = "";
                txtCosto.ForeColor = Color.White;
            }
        }

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            if (txtCosto.Text == "")
            {
                txtCosto.Text = "Costo";
                txtCosto.ForeColor = Color.White;
            }
        }

        private void txtNombreEquip_Enter(object sender, EventArgs e)
        {
            if (txtNombreEquip.Text == "Nombre o código de equipamiento")
            {
                txtNombreEquip.Text = "";
                txtNombreEquip.ForeColor = Color.White;
            }
        }

        private void txtNombreEquip_Leave(object sender, EventArgs e)
        {
            if (txtNombreEquip.Text == "")
            {
                txtNombreEquip.Text = "Nombre o código de equipamiento";
                txtNombreEquip.ForeColor = Color.White;
            }
        }
    }
}
