using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using prueba_login.Controlador;
using prueba_login.Modelo;

namespace prueba_login
{
    public partial class primerusocualquiera : Form
    {
        public primerusocualquiera()
        {
            InitializeComponent();
        }
        public string Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }
        }


        private void primerusocualquiera_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            constructorpasspregunta upd = new constructorpasspregunta();
            if (txtp1.Text.Trim()==""|| txtp2.Text.Trim() == "" || txtp3.Text.Trim() == "" || txtpass.Text.Trim() == "" || txtpassveri.Text.Trim() == "" )
            {
                MessageBox.Show("Campos vacios", "Por favor llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
            else
            {
                upd.pass = txtxcifrado.Text;
                upd.pregunta1 = txtp1.Text;
                upd.pregunta2 = txtp2.Text;
                upd.pregunta3 = txtp3.Text;
                upd.user = constructotlogin.usuario;
                funcionprimeruso.pass(upd);
                Form frm = new YourOwnWorkshop();
                this.Hide();
                frm.Show();
            }
           
            
          
        }
        
        private void txtpassveri_TextChanged(object sender, EventArgs e)
        {
            if (txtpassveri.Text != txtpass.Text)
            {
                lblpass.Visible = true;
            }
         
            else if (txtpassveri.Text == txtpass.Text)
            {
                lblpass.Visible = false;

            }
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(txtpassveri.Text.ToString());
            txtxcifrado.Text = Hash(pass);
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
        }

        private void txtpassveri_Enter(object sender, EventArgs e)
        {
            txtpassveri.UseSystemPasswordChar = true;
        }

        private void lblpass_Click(object sender, EventArgs e)
        {

        }

        private void txtp2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
