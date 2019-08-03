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
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace prueba_login
{
    public partial class primeruso : Form
    {
        public primeruso()
        {
            InitializeComponent();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        constructoruser add = new constructoruser();

        public void agregar()
        {
            if (txtap.Text.Trim() == "" || txtdui.Text.Trim() == "" || txtint.Text.Trim() == "" || txtname.Text.Trim() == "" ||
                txtnum.Text.Trim() == "" || txtuser.Text.Trim() == ""||txtpass.Text.Trim()==""||txtdi.Text.Trim()==""||txtcorreo.Text.Trim()=="")
            {
                MessageBox.Show("Hay campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

              
                add.apellido = txtap.Text;
                add.clave = txtcifrado.Text;
                add.correo = txtcorreo.Text;
                add.genero = Convert.ToInt32(cmbgender.SelectedValue);
                add.ocupacion = Convert.ToInt32(cbmoc.SelectedValue);
                add.intentos = Convert.ToInt32(txtint.Text);
                add.estado = Convert.ToInt32(cmbest.SelectedValue);
                add.usuario = txtuser.Text;
                add.direccion = txtdi.Text;
                add.dui = txtdui.Text;
                add.nombre = txtname.Text;
                add.apellido = txtap.Text;
                add.telefono = txtnum.Text;
                add.pregunta1 = txtp1.Text;
                add.pregunta2 = txtp2.Text;
                add.pregunta3 = txtp3.Text;
                int datos = registrouser.registrar(add);
            }
            if (add.ocupacion==4)
            {
                btns.Visible = true;
            }

        }
        public string Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }
        }

        private void primeruso_Load(object sender, EventArgs e)
        {
            cbmoc.DataSource = registrouser.obtenerocupacion();
            cmbest.DataSource = registrouser.obtenerestado();
            cmbgender.DataSource = registrouser.generos();

            cmbgender.ValueMember = "id_genero";
            cmbgender.DisplayMember = "genero";

            cmbest.ValueMember = "id_estado";
            cmbest.DisplayMember = "estado";

            cbmoc.ValueMember = "id_ocupacion";
            cbmoc.DisplayMember = "ocupacion";
    }

        private void btnregistrar_Click(object sender, EventArgs e)
        {

           

            agregar();
            

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form login = new YourOwnWorkshop();
            login.Show();
            this.Hide();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(txtpass.Text.ToString());
            txtcifrado.Text = Hash(pass);
        }

        private void cmbgender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbmoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form uso = new primerusosistema();
            uso.Show();
            this.Hide();
        }
    }
}
