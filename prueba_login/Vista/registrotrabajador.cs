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
using System.IO;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using prueba_login.reportes;


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
            if (txtapellido.Text.Trim() == "" || txtdui.Text.Trim() == ""  || txtnombre.Text.Trim() == "" ||
                txtnum.Text.Trim() == "" || txtuser.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtcorreo.Text.Trim() == "")
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
                add.fecha = dateTimePicker1.Text;
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
            cmbgender.DataSource = registrouser.generos();

            cmbgender.ValueMember = "id_genero";
            cmbgender.DisplayMember = "genero";

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
            upd.fecha = dateTimePicker1.Text;
            upd.telefono = txtnum.Text;
            upd.dui = txtdui.Text;
            upd.correo = txtcorreo.Text;
            upd.id_usuario = Convert.ToInt16(txtId.Text);
            registrouser.actualizar(upd);

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (Email_Valido(txtcorreo.Text) == false)// llamado del metodo Email_Valido
            {
                error1.SetError(txtcorreo, " Ingrese un Email Válido");
                txtcorreo.Focus();
               
                return;
            }
            else
            {
                error1.Clear();
                validar.Visible = true;
                agregar();
            }
            
            dgvuser.DataSource = registrouser.usuarios();
            validar.Visible = false;
            limpiar();
        }

        public void limpiar()
        {
            txtapellido.Clear();
            txtcifrado.Clear();
            txtcorreo.Clear();
            txtDireccion.Clear();
            txtdui.Clear();
            
            txtnombre.Clear();
            
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
         
         
           cmbgender.Text = dgvuser[7, posicion].Value.ToString();
            cmboc.Text = dgvuser[8, posicion].Value.ToString();

       
            txtcorreo.Text = dgvuser[9, posicion].Value.ToString();

         
            txtuser.Enabled = false;
            btnupdate.Enabled = true;
            btneliminar.Enabled = true;
            btnregistrar.Enabled = false;
           
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            update();
            limpiar();
            dgvuser.DataSource = registrouser.usuarios();

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
            limpiar();
            dgvuser.DataSource = registrouser.usuarios();

            btnregistrar.Enabled = true;
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
        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexaminar_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btnlimp_Click(object sender, EventArgs e)
        {
            limpiar();
            txtuser.Enabled = true;
            btnregistrar.Enabled = true;
            btneliminar.Enabled = false;
            btnupdate.Enabled = false;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            reporteusers repo = new reporteusers();
            repo.id_userconseguir = Convert.ToInt32(dgvuser.CurrentRow.Cells["id_usuario"].Value);
            repo.Show();
        }
    }
}
