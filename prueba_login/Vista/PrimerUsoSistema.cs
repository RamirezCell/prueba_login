using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using prueba_login.Modelo;
using prueba_login.Controlador;
using System.Windows.Forms;

namespace prueba_login
{
    public partial class PrimerUsoSistema : Form
    {
        public PrimerUsoSistema()
        {
            InitializeComponent();

            txtname.ContextMenu = new ContextMenu();
            txtit.ContextMenu = new ContextMenu();
            txtreplegal.ContextMenu = new ContextMenu();
            txtcod.ContextMenu = new ContextMenu();
            txtcorreo.ContextMenu = new ContextMenu();
            txtdireccion.ContextMenu = new ContextMenu();
        }


        public void caracter(KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }
        private void PrimerUsoSistema_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnex_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = " Archivo de imagen(.jpg)|*.jpg|Archivo de imagen(.png)|*.png|Archivos de imagen(.jpeg)|*.jpeg|Todos los archivos (*.*)|*.*";
            DialogResult resultado = openFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                pctlogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnguadar_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Trim() == "" || txtit.Text.Trim() == "" || txtreplegal.Text.Trim() == "" || txtdireccion.Text.Trim() == ""|| txtcod.Text.Trim()== "" || pctlogo.Image == null)
            {
                MessageBox.Show("Existen campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                constructorsistema add = new constructorsistema();
                add.nombre = txtname.Text;
                add.representante = txtreplegal.Text;
                add.NIT = txtit.Text;
                add.direccion = txtdireccion.Text;
                add.correo = txtcorreo.Text;
                add.codigo_postal = Convert.ToInt32(txtcod.Text); 
               
                MemoryStream ms = new MemoryStream();
                pctlogo.Image.Save(ms, ImageFormat.Jpeg);
                byte[] abyte = ms.ToArray();
                string encoded = Convert.ToBase64String(abyte);
                add.foto = encoded;

                if (registroempresa.empresa(add) >= 1)
                {
                    Form user = new primerusouser();
                    user.Show();
                    this.Hide();
                }


            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtit_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtreplegal_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }
    }
}
