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
using System.Text.RegularExpressions;


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
        public static bool Email_Valido(String email) // Método para validar el Email ingresado
        {
            String validando;
            validando = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            if (Regex.IsMatch(email, validando))
            {
                if (Regex.Replace(email, validando, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            else
            {
                return false;
            }

        }

        public void caracter(KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }
        void ingles()
        {
            lblname.Text = "Enterprise name"  ;
            lbldi.Text = "Direction";
            lblcorreo.Text = "Email";
            lblcam.Text = "All data are required";
            tip.Text = "Click Browse to upload the user's profile picture";
            btnguadar.Text = "Save and exit";
            btnex.Text = "Browse";logo.Text = "Enterprise logo";
            Salir.Text = "Exit";
            rep.Text = "Legal agent";
            cod.Text = "Postal code";


        }
        private void PrimerUsoSistema_Load(object sender, EventArgs e)
        {

            if (constructoridioma.Traducir == 1)
            {
                //MessageBox.Show("ESPAÑOL");

            }
            else
            {
                
                //MessageBox.Show("INGLES");

            }
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
            try
            {
                openFileDialog1.Filter = " Archivo de imagen(.jpg)|*.jpg|Archivo de imagen(.png)|*.png|Archivos de imagen(.jpeg)|*.jpeg|Todos los archivos (*.*)|*.*";
                DialogResult resultado = openFileDialog1.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pctlogo.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("El peso de la imagen es mayor al soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnguadar_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Trim() == "" || txtit.Text.Trim() == "" || txtreplegal.Text.Trim() == "" || txtdireccion.Text.Trim() == ""|| txtcod.Text.Trim()== "" || pctlogo.Image == null)
            {
                MessageBox.Show("Existen campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (Email_Valido(txtcorreo.Text) == false)
            {
                errorProvider1.SetError(txtcorreo, " Ingrese un Email Válido");
                txtcorreo.Focus();

                return;
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
                errorProvider1.Clear();
                validar.Visible = true;
                if (registroempresa.empresa(add) >= 1)
                {
                    Form user = new YourOwnWorkshop();
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
            
        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
