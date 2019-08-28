using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using prueba_login.serviciosemail;
using prueba_login.Modelo;
using System.Security.Cryptography;
using prueba_login.Controlador;

namespace prueba_login
{
    public partial class recu_contra : Form


    {
       


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public recu_contra()
        {
            InitializeComponent();
            txtusuario.ContextMenu = new ContextMenu();
        }
        public void caracter(KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }

        private void toolStripButton2_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txttel_TextChanged(object sender, EventArgs e)
        {

        }

        private void lineShape2_Click(object sender, EventArgs e)
        {

        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "USUARIO O CORREO")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.Black;


            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "USUARIO O CORREO";
                txtusuario.ForeColor = Color.Black;


            }
        }

        private void txttel_Enter(object sender, EventArgs e)
        {
        }

        private void txttel_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcod_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtcod_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form form = new opcion_recu();
            form.Show();
            this.Hide();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
        public string Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            if ( txtusuario.Text.Trim() == "")
            {
                MessageBox.Show("campos vacios", "Llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                var user = new referenciarecover();
                var result = user.recovery(txtusuario.Text);
                lblresult.Text = result;
                txtveri.Visible = true;
              



            }
           
        }

        private void recu_contra_Load(object sender, EventArgs e)
        {

        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }


        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void txtveri_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtcifrado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
        }

        private void txtveri_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtveri.Text.Trim() == "")
            {
                MessageBox.Show("campos vacios", "Llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                constructoruser codigo = new constructoruser();
                codigo.cod = txtveri.Text;
                bool datos = registrouser.validarcod(codigo);
                if (datos==true)
                {
                    panel2.Enabled = true;
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            txpass.UseSystemPasswordChar = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(txpass.Text.ToString());
            txpass.UseSystemPasswordChar = true;
            txtcifrado.Text = Hash(pass);
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            
           
        }

        private void lblver_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            constructorpass upd = new constructorpass();
            upd.pass = txtcifrado.Text;
            upd.usuario = txtusuario.Text;
            passcorreo.cambiar(upd);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
