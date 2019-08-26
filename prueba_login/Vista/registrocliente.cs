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


namespace prueba_login
{
    public partial class registrocliente : Form
    {
        public registrocliente()
        {

            InitializeComponent();


            txtnamecliente.ContextMenu = new ContextMenu();
            txtapelliocliente.ContextMenu = new ContextMenu();
            txtnum.ContextMenu = new ContextMenu();
            txtdui.ContextMenu = new ContextMenu();
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lineShape5_Click(object sender, EventArgs e)
        {

        }

        private void txtapelliocliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnamecliente_Enter(object sender, EventArgs e)
        {

        }

        private void txtnamecliente_Leave(object sender, EventArgs e)
        {

        }

        private void txtapelliocliente_Enter(object sender, EventArgs e)
        {

        }

        private void txtapelliocliente_Leave(object sender, EventArgs e)
        {

        }

        private void txtnumcliente_Enter(object sender, EventArgs e)
        {

        }

        private void txtnumcliente_Leave(object sender, EventArgs e)
        {

        }

        private void btnduicliente_Leave(object sender, EventArgs e)
        {

        }

        private void txtduicliente_Enter(object sender, EventArgs e)
        {

        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {

        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {

        }

        private void txtcorreo_Enter(object sender, EventArgs e)
        {

        }

        private void txtcorreo_Leave(object sender, EventArgs e)
        {

        }

        private void txtnamecliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtduicliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnregistrar_Click(object sender, EventArgs e)
        {
            agregar();
            mostrar();
            limpiar();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            mostrar();
        }
        constructorcliente add = new constructorcliente();
        public void agregar()


        {

            if (txtapelliocliente.Text.Trim() == "" || txtnamecliente.Text.Trim() == "" || txtnum.Text.Trim() == ""||txtdui.Text.Trim()==""
                ||txtDireccion.Text.Trim()==""||txtcorreo.Text.Trim()=="")
            {
                MessageBox.Show("Hay campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                add.nombre_cliente = txtnamecliente.Text;
                add.apellido_cliente = txtapelliocliente.Text;
                add.correo = txtcorreo.Text;
                add.direccion = txtDireccion.Text;
                add.telefono = txtnum.Text;
                add.tipo_cliente = Convert.ToInt16(cmbTipoCliente.SelectedValue);
                add.dui = txtdui.Text;
                add.direccion = txtDireccion.Text;
                int datos = funcionescliente.agregar(add);
            }
           
        }

        private void registrocliente_Load(object sender, EventArgs e)
        {
            cmbTipoCliente.DataSource = funcionescliente.obtenertipocliente();
            cmbTipoCliente.DisplayMember = "tipo_cliente";
            cmbTipoCliente.ValueMember = "id_tipo_cliente";
            dgvcliente.DataSource = funcionescliente.mostrar();
            btneliminar.Enabled = false;
            btnupdate.Enabled = false;
            this.dgvcliente.Columns[0].Visible = false;

        }
        public void mostrar()
        {
            dgvcliente.DataSource = funcionescliente.mostrar();
        }

        private void dgvcliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = this.dgvcliente.CurrentRow.Index;
            txtId.Text = dgvcliente[0, posicion].Value.ToString();
            txtnamecliente.Text = dgvcliente[1, posicion].Value.ToString();
            txtapelliocliente.Text = dgvcliente[2, posicion].Value.ToString();
            txtdui.Text = dgvcliente[3, posicion].Value.ToString();
            txtcorreo.Text = dgvcliente[4, posicion].Value.ToString();
            txtnum.Text = dgvcliente[5, posicion].Value.ToString();
            txtDireccion.Text = dgvcliente[6, posicion].Value.ToString();
            cmbTipoCliente.Text = dgvcliente[7, posicion].Value.ToString();
            btnregistrar.Enabled = false;
            btnupdate.Enabled = true;
            btneliminar.Enabled = true;
        }
        public void Actualizar()
        {
            constructorcliente actualizar = new constructorcliente();
            actualizar.nombre_cliente = txtnamecliente.Text;
            actualizar.id_cliente = int.Parse(txtId.Text);
            actualizar.apellido_cliente = txtapelliocliente.Text;
            actualizar.correo = txtcorreo.Text;
            actualizar.telefono = txtnum.Text;
            actualizar.dui = txtdui.Text;
            actualizar.tipo_cliente = Convert.ToInt32(cmbTipoCliente.SelectedValue);
            actualizar.direccion = txtDireccion.Text;
            funcionescliente.actualizar(actualizar);
         

        }

        public void Eliminar()
        {
            if (MessageBox.Show("Esta seguro de eliminar el registro", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                funcionescliente.eliminar(Convert.ToInt32(txtId.Text));
                btnregistrar.Enabled = true;
                btneliminar.Enabled = false;


            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Actualizar();
            mostrar();
            limpiar();
            btnupdate.Enabled = false;
            btneliminar.Enabled = false;
            btnregistrar.Enabled = true;
        }
        public void eliminarcliente()
        {
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            mostrar();
            limpiar();
            btneliminar.Enabled = true;
            btnregistrar.Enabled = true;
            btnupdate.Enabled = true;
        }
        public void limpiar()
        {
            txtId.Clear();
            txtdui.Clear();
            txtDireccion.Clear();
            txtcorreo.Clear();
            txtnamecliente.Clear();
            txtnum.Clear();
            txtapelliocliente.Clear();
            txtDireccion.Clear();
        }

        private void cmbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltrar.Text != "")
            {
                dgvcliente.CurrentCell = null;
                foreach(DataGridViewRow r in dgvcliente.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvcliente.Rows)
                {
                    foreach(DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtFiltrar.Text.ToUpper()) ==0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                 dgvcliente.DataSource = funcionescliente.mostrar();
            }
        }

        private void txtFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void txtnamecliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtapelliocliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }
    }
    
}
