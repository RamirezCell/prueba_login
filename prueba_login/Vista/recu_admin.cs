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
using System.Security.Cryptography;

namespace prueba_login
{
    public partial class recu_admin : Form
    {

        public recu_admin()
        {
            InitializeComponent();
            txtadmin.ContextMenu = new ContextMenu();
            txtcontra.ContextMenu = new ContextMenu();
            txtnuevacontra.ContextMenu = new ContextMenu();
            txtusuario.ContextMenu = new ContextMenu();
           
        }

        public void caracter(KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }
        public void validar()
        {





            constructotlogin validar = new constructotlogin(txtadmin.Text,txtcontra.Text);
            validar.clave = txtcifrado.Text;
            constructotlogin.usuario =txtadmin.Text;
            
            
            bool datos =validarlogin.validarusername(validar);
            if (datos == true)
            {
                txtusuario.Enabled = true;
                btnverificarusu.Enabled = true;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            validar();
        }

        public void confirmar_user()
        {
            constructor_recuadmin usuario = new constructor_recuadmin();
            usuario.usuario = txtusuario.Text;
            bool datos = Funciones_Recu_admin.validaruser(usuario);
            if (datos == true)
            {
             
                txtnuevacontra.Enabled = true;
                btnconfirmar.Enabled = true;
            }
          
        }

        public void nueva_contra()
        {
            constructor_recuadmin upd = new constructor_recuadmin();
            upd.nuevacontraseña = textBox1.Text;
            upd.usuario = txtusuario.Text;
            Funciones_Recu_admin.cambiar(upd);
        }
        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            nueva_contra();
        }

        private void btnverificarusu_Click(object sender, EventArgs e)
        {
            confirmar_user();
        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(txtcontra.Text.ToString());
            txtcontra.UseSystemPasswordChar = true;
            txtcifrado.Text = Hash(pass);
        }

        private void txtnuevacontra_TextChanged(object sender, EventArgs e)
        {
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(txtnuevacontra.Text.ToString());
            txtnuevacontra.UseSystemPasswordChar = true;
            textBox1.Text = Hash(pass);
        }

        private void recu_admin_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void txtadmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtcontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtnuevacontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtadmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form yow = new YourOwnWorkshop();
            yow.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
