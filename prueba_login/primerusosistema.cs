using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prueba_login.Modelo;
using prueba_login.Controlador;

namespace prueba_login
{
    public partial class primerusosistema : Form
    {
        public primerusosistema()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void Agregar()
        {
            if (txtNombre.Text.Trim()=="" || txtNumero.Text.Trim()=="" || txtNit.Text.Trim()=="" || txtPostal.Text.Trim()==""||txtDireccion.Text.Trim()==""||txtCorreo.Text.Trim()=="")
            {
                MessageBox.Show("Por favor complete todos los campos solicitados", "Campos no ingresados", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                constructorsistema add = new constructorsistema();
                add.nombre = txtNombre.Text;
                add.numero = txtNumero.Text;
                add.NIT = txtNit.Text;
                add.direccion = txtDireccion.Text;
                add.codigo_postal = Convert.ToInt32(txtPostal.Text);
                add.correo = txtCorreo.Text;
                PrimerUsoSystem.AgregarSistema(add); 

                    
            }
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form Login = new YourOwnWorkshop();
            Login.Show();
            this.Hide();




        }

        private void primerusosistema_Load(object sender, EventArgs e)
        {

        }
    }
}
