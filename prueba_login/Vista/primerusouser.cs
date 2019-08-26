using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using prueba_login.Modelo;
using prueba_login.Controlador;
using System.Security.Cryptography;


namespace prueba_login
{
    public partial class primerusouser : Form
    {
        public primerusouser()
        {
            InitializeComponent();
            txtname.ContextMenu = new ContextMenu();
            txtapellido.ContextMenu = new ContextMenu();
            txtdui.ContextMenu = new ContextMenu();
            txtdireccion.ContextMenu = new ContextMenu();
            txttel.ContextMenu = new ContextMenu();
            txtuser.ContextMenu = new ContextMenu();
            txtpass.ContextMenu = new ContextMenu();
            txtcorreo.ContextMenu = new ContextMenu();
        }
        public void caracter(KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }
        public string Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
            if (txtapellido.Text.Trim()==""||txtname.Text.Trim()==""||txtdui.Text.Trim()==""||txtcorreo.Text.Trim()==""||txtdireccion.Text.Trim()==""||txtuser.Text.Trim()==""||txtpass.Text.Trim()==""||txttel.Text.Trim()==""||pctlogo==null||txtp1.Text.Trim()==""||txtp2.Text.Trim()==""||txtp3.Text.Trim()=="")
            {
                MessageBox.Show("Existen campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                constructoruser add = new constructoruser();
                add.nombre = txtname.Text;
                add.apellido = txtapellido.Text;
                add.correo = txtcorreo.Text;
                add.usuario = txtuser.Text;
                add.telefono = txttel.Text;
                add.dui = txtdui.Text;
                add.fecha = dateTimePicker1.Text;
                add.direccion = txtdireccion.Text;
                add.pregunta1 = txtp1.Text;
                add.pregunta2 = txtp2.Text;
                add.pregunta3 = txtp3.Text;
                add.clave = txtxcifrado.Text;
                add.genero = Convert.ToInt32(cmbgender.SelectedValue);
                add.ocupacion = Convert.ToInt32(cmbocupacion.SelectedValue);
                add.estado = Convert.ToInt32(cmbestado.SelectedValue);
               
                MemoryStream ms = new MemoryStream();
                pctlogo.Image.Save(ms, ImageFormat.Jpeg);
                byte[] abyte = ms.ToArray();
                string encoded = Convert.ToBase64String(abyte);
                add.foto = encoded;
                if (registrouser.registrar(add) >= 1)
                {
                    Form user = new YourOwnWorkshop();
                    user.Show();
                    this.Hide();
                    
                }


            }
        }

        private void primerusouser_Load(object sender, EventArgs e)
        {
            cmbestado.DataSource = registrouser.obtenerestado();
            cmbgender.DataSource = registrouser.generos();
            cmbocupacion.DataSource = registrouser.obtenerocupacion();
            cmbocupacion.ValueMember = "id_ocupacion";
            cmbocupacion.DisplayMember = "ocupacion";
            cmbgender.DisplayMember = "genero";
            cmbgender.ValueMember = "id_genero";
            cmbestado.ValueMember = "id_estado";
            cmbestado.DisplayMember = "estado";
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(txtpass.Text.ToString());
            txtxcifrado.Text = Hash(pass);
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtdui_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }
    }
}
