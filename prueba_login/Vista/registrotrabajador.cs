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
    public partial class registrotrabajador : Form
    {
        public string Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }
        }

        public registrotrabajador()
        {
            InitializeComponent();
            txtnombre.ContextMenu = new ContextMenu();
            txtapellido.ContextMenu = new ContextMenu();
            txtdui.ContextMenu = new ContextMenu();
            txtuser.ContextMenu = new ContextMenu();
            txtcorreo.ContextMenu = new ContextMenu();
            txtDireccion.ContextMenu = new ContextMenu();
            txtpass.ContextMenu = new ContextMenu();
            
        }
        public void caracter(KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }

        private void grpregistro_Enter(object sender, EventArgs e)
        {

        }
        constructoruser add = new constructoruser();
        public void agregar()
        {
            if (txtapellido.Text.Trim() == "" || txtdui.Text.Trim() == "" || txtint.Text.Trim() == "" || txtnombre.Text.Trim() == "" ||
                txtnum.Text.Trim() == "" || txtuser.Text.Trim() == "" || txtpass.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtcorreo.Text.Trim() == "")
            {
                MessageBox.Show("Hay campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {


                add.apellido = txtapellido.Text;
                add.clave = txtcifrado.Text;
                add.correo = txtcorreo.Text;
                add.genero = Convert.ToInt32(cmbgender.SelectedValue);
                add.ocupacion = Convert.ToInt32(cmboc.SelectedValue);
                add.intentos = Convert.ToInt32(txtint.Text);
                add.estado = Convert.ToInt32(cmbestado.SelectedValue);
                add.usuario = txtuser.Text;
                add.direccion = txtDireccion.Text;
                add.dui = txtdui.Text;
                add.nombre = txtnombre.Text;
                add.apellido = txtapellido.Text;
                add.telefono = txtnum.Text;
                int datos = registrouser.registrar(add);
            }
        }

        private void registrotrabajador_Load(object sender, EventArgs e)
        {
            cmboc.DataSource = registrouser.obtenerocupacion();
            cmbestado.DataSource = registrouser.obtenerestado();
            cmbgender.DataSource = registrouser.generos();

            cmbgender.ValueMember = "id_genero";
            cmbgender.DisplayMember = "genero";

            cmbestado.ValueMember = "id_estado";
            cmbestado.DisplayMember = "estado";
            dgvuser.DataSource = registrouser.usuarios();
            cmboc.ValueMember = "id_ocupacion";
            cmboc.DisplayMember = "ocupacion";
            this.dgvuser.Columns[0].Visible = false;
            btneliminar.Enabled = false;
            btnupdate.Enabled = true;


        }
        constructoruser upd = new constructoruser();
        public void update()
        {

            upd.nombre = txtnombre.Text;
            upd.apellido = txtapellido.Text;
            upd.direccion = txtDireccion.Text;
            upd.ocupacion = Convert.ToInt32(cmboc.SelectedValue);
            upd.genero = Convert.ToInt32(cmbgender.SelectedValue);
            upd.estado = Convert.ToInt32(cmbestado.SelectedValue);

            upd.telefono = txtnum.Text;
            upd.dui = txtdui.Text;
            upd.correo = txtcorreo.Text;
            upd.id_usuario = Convert.ToInt16(txtId.Text);
            registrouser.actualizar(upd);

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(txtpass.Text.ToString());
            txtcifrado.Text = Hash(pass);
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        public void limpiar()
        {
            txtapellido.Clear();
            txtcifrado.Clear();
            txtcorreo.Clear();
            txtDireccion.Clear();
            txtdui.Clear();
            txtint.Clear();
            txtnombre.Clear();
            txtpass.Clear();
            txtnum.Clear();
            txtuser.Clear();
        }

        private void dgvcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            dgvuser.DataSource = registrouser.usuarios();
        }

        private void dgvcliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = this.dgvuser.CurrentRow.Index;
            txtnombre.Text = dgvuser[1, posicion].Value.ToString();
            txtId.Text = dgvuser[0, posicion].Value.ToString();
            txtapellido.Text = dgvuser[2, posicion].Value.ToString();
            txtdui.Text = dgvuser[3, posicion].Value.ToString();
            txtDireccion.Text = dgvuser[4, posicion].Value.ToString();
            txtnum.Text = dgvuser[5, posicion].Value.ToString();
            txtuser.Text = dgvuser[6, posicion].Value.ToString();
            txtpass.Text = dgvuser[7, posicion].Value.ToString();
            cmbestado.Text = dgvuser[8, posicion].Value.ToString();
            cmbgender.Text = dgvuser[9, posicion].Value.ToString();
            cmboc.Text = dgvuser[10, posicion].Value.ToString();

       
            txtint.Text = dgvuser[11, posicion].Value.ToString();
            txtcorreo.Text = dgvuser[12, posicion].Value.ToString();

            txtpass.Enabled = false;
            txtuser.Enabled = false;
            btnupdate.Enabled = true;
            btneliminar.Enabled = true;
            btnregistrar.Enabled = false;
            txtint.Enabled = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            update();
            limpiar();
            btnregistrar.Enabled = true;
        }
        public void eliminarregistro()
        {
            if (MessageBox.Show("Esta seguro de eliminar el registro", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                registrouser.eliminar(Convert.ToInt32(txtId.Text));
            }


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            eliminarregistro();
        }

        private void txtfiltrar_TextChanged(object sender, EventArgs e)
        {
            if (txtfiltrar.Text != "")
            {
                dgvuser.CurrentCell = null;
                foreach(DataGridViewRow r in dgvuser.Rows)
                {
                    r.Visible = false;
                    
                }
                foreach(DataGridViewRow r in dgvuser.Rows)
                {
                    foreach(DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtfiltrar.Text.ToUpper()) ==0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dgvuser.DataSource = registrouser.usuarios();
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtdui_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtdui_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnrecuperacion_Click(object sender, EventArgs e)
        {
            Form frm = new Recu();
            frm.Show();
           
        }

        private void txtfiltrar_Click(object sender, EventArgs e)
        {

        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
