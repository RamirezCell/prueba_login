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
    public partial class registroauto : Form
    {
        public registroauto()
        {
            InitializeComponent();
            
        }

        public void caracter(KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }
        constructorvehiculo add = new constructorvehiculo();

        public void agregar()
        {
            
            
        }

        constructorvehiculo actualizar = new constructorvehiculo();
        private void upd()
        {
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            agregar();
            mostrar();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
        public void mostrar()
        {
            dgvvehiculos.DataSource = funcionesvehiculo.mostrar();

        }

        private void registroauto_Load(object sender, EventArgs e)
        {
           
            btneliminar.Enabled = false;
            btnupdate.Enabled = false;


            mostrar();

            this.dgvvehiculos.Columns[0].Visible = false;

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void dgvvehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvvehiculos.CurrentRow.Index;
          
            //txtIdvehiculo.Text = dgvvehiculos[0, posicion].Value.ToString();
            //txtmarca.Text = dgvvehiculos[1, posicion].Value.ToString();
            //txtmodelo.Text = dgvvehiculos[2, posicion].Value.ToString();
            //txtanio.Text = dgvvehiculos[3, posicion].Value.ToString();
            //txttipovehiculo.Text = dgvvehiculos[4, posicion].Value.ToString();
          
            btnregistrar.Enabled = false;
            btnupdate.Enabled = true;
            btneliminar.Enabled = true;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            upd();
            mostrar();
           limpiar();
            btnupdate.Enabled = false;
            btneliminar.Enabled = false;
            btnregistrar.Enabled = true;
        }
        public void limpiar()
        {
           
            txtIdvehiculo.Clear();

        }
        public void Eliminar()
        {
            if (MessageBox.Show("Esta seguro de eliminar el registro", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                funcionesvehiculo.eliminar(Convert.ToInt32(txtIdvehiculo.Text));

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            mostrar();
            limpiar();
            btneliminar.Enabled = false;
            btnregistrar.Enabled = true;
            btnupdate.Enabled = false;
        }

        private void txtFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltrar.Text != "")
            {
                dgvvehiculos.CurrentCell = null;
                foreach(DataGridViewRow r in dgvvehiculos.Rows)
                {
                    r.Visible = false;

                }
                foreach (DataGridViewRow r in dgvvehiculos.Rows)
                {
                    foreach(DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtFiltrar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }

                }
            }
            else
            {
                dgvvehiculos.DataSource = funcionesvehiculo.mostrar();
            }
        }

        private void grpregistro_Enter(object sender, EventArgs e)
        {

        }

        private void txtmarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtmodelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtanio_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txttipovehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }
    }
}
