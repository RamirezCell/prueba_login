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
using prueba_login.Modelo;
using prueba_login.Controlador;
namespace prueba_login
{
    public partial class contranueva : Form
    {
        public contranueva()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form recu = new recu_contra();
            recu.Show();
            this.Hide();
        }
        public string Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassveri_TextChanged(object sender, EventArgs e)
        {
            if (txtpassveri.Text != txtpass.Text)
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(txtpassveri.Text.ToString());
            txtpassveri.UseSystemPasswordChar = true;
            txtcifrado.Text = Hash(pass);
        }

        private void contranueva_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (txtpass.Text.Trim() == "" || txtpassveri.Text.Trim() == "")
            {
                MessageBox.Show("Campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            else
            {

            }
            
            

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
        }
    }
}
