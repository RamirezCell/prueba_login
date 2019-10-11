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
using System.IO;
using System.Drawing.Imaging;
using prueba_login.reportes;

namespace prueba_login
{
    public partial class Aseguradora : Form
    {
        public Aseguradora()
        {
            InitializeComponent();
            txtnombre.ContextMenu = new ContextMenu();
            txttelefono.ContextMenu = new ContextMenu();
            txtrepresentante.ContextMenu = new ContextMenu();
            txtnit.ContextMenu = new ContextMenu();
        }
        public void caracter(KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        constructoraseguradora add = new constructoraseguradora();
        public void registrar()
        {
            if (txtcorreo.Text.Trim()==""||txtnit.Text.Trim()==""||txtnombre.Text.Trim()==""||txtrepresentante.Text.Trim()==""||txttelefono.Text.Trim()==""||pctlogo==null)
            {
                MessageBox.Show("Los campos estan vacios", "Por favor ingrese todos los datos pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                add.correo = txtcorreo.Text;
                add.nit = txtnit.Text;
                add.nombre = txtnombre.Text;
                add.representante = txtrepresentante.Text;
                add.telefono = txttelefono.Text;
                MemoryStream ms = new MemoryStream();
                pctlogo.Image.Save(ms, ImageFormat.Jpeg);
                byte[] abyte = ms.ToArray();
                string encoded = Convert.ToBase64String(abyte);
                add.logo = encoded;
                int datos = funcionesaseguradora.registrar(add);
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            registrar();
            limpiar();
            mostrar();
        }
        public void mostrar()
        {
            dataGridView1.DataSource = funcionesaseguradora.mostrar();
        }
        void ingles()
        {
            lblase.Text = "Insurer registration";
            lblcorreo.Text = "Email";
            lblname.Text = "Insurer name";
            lblnum.Text = "Telephone number";
            lblrep.Text = "Legal agent";
            btnregistrar.Text = "    Create";
            btnmostrar.Text = "    Show";
            btnupdate.Text = "    Update";
            btneliminar.Text = "    Delete";
            btnlimp.Text = "    Clear";
            btnreport.Text = "Generate report";
            btnexaminar.Text = "Browse";
        }
        private void Aseguradora_Load(object sender, EventArgs e)
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
            dataGridView1.DataSource = funcionesaseguradora.mostrar();
            this.dataGridView1.Columns[0].Visible = false;

        }

        private void btnexaminar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivo de imagen(.jpg)|*.jpg|Archivo de imagen(.png)|*.png|Archivo de imagen(.jpeg)|*.jpeg|Todos los archivos(*.*)|*.*";
            DialogResult resultado = openFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                pctlogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        public void limpiar()
        {
            txtcorreo.Clear();
            txtnit.Clear();
            txtnombre.Clear();
            txtrepresentante.Clear();
            txttelefono.Clear();
            btnregistrar.Enabled = true;
            btneliminar.Enabled = false;
            btnupdate.Enabled = false;
        }
        private void btnlimp_Click(object sender, EventArgs e)
        {
            limpiar();
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = this.dataGridView1.CurrentRow.Index;
            txtId.Text = dataGridView1[0, posicion].Value.ToString();
            txtnombre.Text = dataGridView1[1, posicion].Value.ToString();
            txttelefono.Text = dataGridView1[2, posicion].Value.ToString();
            txtnit.Text = dataGridView1[3, posicion].Value.ToString();
            txtcorreo.Text = dataGridView1[4, posicion].Value.ToString();
            txtrepresentante.Text = dataGridView1[5, posicion].Value.ToString();

            btnupdate.Enabled = true;
            btneliminar.Enabled = true;
            btnregistrar.Enabled = false;
        }
        constructoraseguradora upd = new constructoraseguradora();
        public void update()
        {
            upd.nombre = txtnombre.Text;
            upd.nit = txtnit.Text;
            upd.representante = txtrepresentante.Text;
            upd.telefono = txttelefono.Text;
            upd.id_aseguradora = Convert.ToInt16(txtId.Text);
            funcionesaseguradora.actualizar(upd);
        }

        public void eliminar()
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el registro", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                funcionesaseguradora.eliminar(Convert.ToInt32(txtId.Text));
            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            update();
            limpiar();
            mostrar();
            btnregistrar.Enabled = true;
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = funcionesaseguradora.mostrar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            limpiar();
            btnregistrar.Enabled = true;
        }

        private void txtrepresentante_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtrepresentante_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reporteaseguradora re = new reporteaseguradora();
            re.id_secureconseguir = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_aseguradora"].Value);
            re.Show();
        }
    }
}
