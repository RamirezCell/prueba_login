using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prueba_login.Controlador;
using prueba_login.Modelo;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace prueba_login
{
    public partial class ordentrabajo : Form
    {
        public ordentrabajo()
        {
            InitializeComponent();
            
            txtdetalles.ContextMenu = new ContextMenu();
        }
        public void caracter(KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void enviar()
        {
            if (txtdetalles.Text.Trim()==""||pctarriba==null||pctderecha==null||pctfrontal==null||pctizquierda==null||pcttrasera==null)

            {
                MessageBox.Show("Existen campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                constructor_ordentrabajo add = new constructor_ordentrabajo();
               
                add.cliente = Convert.ToInt16 (cmbcliente.SelectedValue);
                add.usuario = Convert.ToInt16(cmbusuario.SelectedValue);
                add.vehiculo = Convert.ToInt16(cmbvehiculo.SelectedValue);
                add.detalles = txtdetalles.Text;
                MemoryStream ms1 = new MemoryStream();
                pctfrontal.Image.Save(ms1, ImageFormat.Jpeg);
                byte[] abyte = ms1.ToArray();
                string encoded = Convert.ToBase64String(abyte);
                add.foto1 = encoded;

                MemoryStream ms2 = new MemoryStream();
                pctderecha.Image.Save(ms2, ImageFormat.Jpeg);
                byte[] abyte2 = ms2.ToArray();
                string encoded2 = Convert.ToBase64String(abyte);
                add.foto2 = encoded;

                MemoryStream ms3 = new MemoryStream();
                pctarriba.Image.Save(ms3, ImageFormat.Jpeg);
                byte[] abyte3 = ms3.ToArray();
                string encoded3 = Convert.ToBase64String(abyte);
                add.foto3 = encoded;

                MemoryStream ms4 = new MemoryStream();
                pctizquierda.Image.Save(ms4, ImageFormat.Jpeg);
                byte[] abyte4 = ms4.ToArray();
                string encode4d = Convert.ToBase64String(abyte);
                add.foto4 = encoded;

                MemoryStream ms5 = new MemoryStream();
                pcttrasera.Image.Save(ms5, ImageFormat.Jpeg);
                byte[] abyte5 = ms5.ToArray();
                string encoded5= Convert.ToBase64String(abyte);
                add.foto5 = encoded;

                funciones_ordendetrabajo.agregarorden(add);


            }
        }
        

        private void ordentrabajo_Load(object sender, EventArgs e)
        {
            cmbusuario.DataSource = funciones_ordendetrabajo.asesor();
            cmbusuario.ValueMember = "id_usuario";
            cmbusuario.DisplayMember = "Nombreuser";
            cmbcliente.DataSource = funciones_ordendetrabajo.cliente();
            cmbcliente.ValueMember = "id_cliente";
            cmbcliente.DisplayMember = "Nombrecliente";
            cmbvehiculo.DataSource = funciones_ordendetrabajo.vehiculos();
            cmbvehiculo.ValueMember = "id_vehiculo";
            cmbvehiculo.DisplayMember = "vehiculo";


           
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnexaminar1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = " Archivo de imagen(.jpg)|*.jpg|Archivo de imagen(.png)|*.png|Archivos de imagen(.jpeg)|*.jpeg|Todos los archivos (*.*)|*.*";
                DialogResult resultado = openFileDialog1.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pctfrontal.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void btnexaminar2_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = " Archivo de imagen(.jpg)|*.jpg|Archivo de imagen(.png)|*.png|Archivos de imagen(.jpeg)|*.jpeg|Todos los archivos (*.*)|*.*";
                DialogResult resultado = openFileDialog1.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pctderecha.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void btnexaminar3_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = " Archivo de imagen(.jpg)|*.jpg|Archivo de imagen(.png)|*.png|Archivos de imagen(.jpeg)|*.jpeg|Todos los archivos (*.*)|*.*";
                DialogResult resultado = openFileDialog1.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pctarriba.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void btnexaminar4_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = " Archivo de imagen(.jpg)|*.jpg|Archivo de imagen(.png)|*.png|Archivos de imagen(.jpeg)|*.jpeg|Todos los archivos (*.*)|*.*";
                DialogResult resultado = openFileDialog1.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pcttrasera.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnexaminar5_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = " Archivo de imagen(.jpg)|*.jpg|Archivo de imagen(.png)|*.png|Archivos de imagen(.jpeg)|*.jpeg|Todos los archivos (*.*)|*.*";
                DialogResult resultado = openFileDialog1.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pctizquierda.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            enviar();
         
            txtdetalles.Clear();
           
        }

        private void txtplaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtchasis_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtmotor_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtdetalles_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void cmbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbtipocarro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
