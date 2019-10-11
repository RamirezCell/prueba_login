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
        void ingles()
        {
            btnre.Text = "Password recovery|Restart by administrator";
            user.Text = "Username";
            btnverificarusu.Text = "Verify";
            btnregresar.Text = "Back to employee registration";
        }

        private void Recu_Load(object sender, EventArgs e)
        {
            if (constructoridioma.Traducir == 1)
            {
                //MessageBox.Show("ESPAÑOL");

            }
            else
            {
                ingles();
                //MessageBox.Show("INGLES");

            }
        }
        public void contra() {

            
            
            

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
               
            }
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
           
        }

        private void txtnuevacontra_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
