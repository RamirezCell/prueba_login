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
    public partial class Recu : Form
    {
        public Recu()
        {
            InitializeComponent();
        }

        private void btnverificarusu_Click(object sender, EventArgs e)
        {
            confirmar_user();
        }

        private void Recu_Load(object sender, EventArgs e)
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

        private void confirmar_user()
        {
            constructor_recuinterno usuario = new constructor_recuinterno();
            usuario.usuario = txtusuario.Text;
            bool datos = funciones_recu_interno.validar(usuario);
            if (datos == true)
            {
                txtnuevacontra.Enabled = true;
                btnverificarusu.Enabled = true;
            }
        }

        public void nueva_contra()
        {
            constructor_recuinterno upd = new constructor_recuinterno();
            upd.contraseña = txtcifrado.Text;
            upd.usuario = txtusuario.Text;
            funciones_recu_interno.cambiar(upd);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            
            this.Hide();

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            nueva_contra();
        }

        private void txtnuevacontra_TextChanged(object sender, EventArgs e)
        {
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(txtnuevacontra.Text.ToString());
            txtnuevacontra.UseSystemPasswordChar = true;
            txtcifrado.Text = Hash(pass);
        }
    }
}
