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

namespace prueba_login
{
    public partial class frmprguntas : Form
    {
        public frmprguntas()
        {
            InitializeComponent();
        }
        public void update()
        {
            constructorpreguntas upd = new constructorpreguntas();
            upd.pass = txtcifrado.Text;
            upd.usuario = txtuser.Text;
            validarpreguntas.cambiar(upd);
        }

        private void frmprguntas_Load(object sender, EventArgs e)
        {

        }

        public void comprobarpreguntas()
        {
            constructorpreguntas preguntas = new constructorpreguntas();
            preguntas.pregunta1 = txtp1.Text;
            preguntas.pregunta2 = txtp2.Text;
            preguntas.pregunta3 = txtp3.Text;
            preguntas.usuario = txtuser.Text;
            bool datos = validarpreguntas.validar(preguntas);
            if (datos==true)
            {
                MessageBox.Show("encontrado");
                txtp1.Enabled = false;
                txtp2.Enabled = false;
                txtp3.Enabled = false;
                txtpass.Enabled = true;
            }
            else
            {
                MessageBox.Show("No encontrado");
            }
        }

        public void cambiarclave()
        {
            constructorpreguntas cambiar = new constructorpreguntas();
            cambiar.pass = txtpass.Text;

        }

        public string Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            comprobarpreguntas();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(txtpass.Text.ToString());
            txtpass.UseSystemPasswordChar = true;
            txtcifrado.Text = Hash(pass);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form log = new YourOwnWorkshop();
            log.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
