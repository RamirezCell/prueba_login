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
    public partial class controlinventario : Form
    {
        public controlinventario()
        {
            InitializeComponent();
            txtname.ContextMenu = new ContextMenu();
            txtprice.ContextMenu = new ContextMenu();
            txtmarca.ContextMenu = new ContextMenu();
            txttipo.ContextMenu = new ContextMenu();
            txtcant.ContextMenu = new ContextMenu();

        }
        public void caracter(KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }
        void ingles()
        {
            btnregistrar.Text = "    Create";
            btnmostrar.Text = "    Show";
            btnupdate.Text = "    Update";
            btneliminar.Text = "    Delete";
            btnlimp.Text = "    Clear";
            lblflit.Text = "Filter";
            lblmarca.Text = "Brand";
            lblnombre.Text = "Name";
            lblprice.Text = "Price";
            lbltipo.Text = "Type"
                ;
            lblcant.Text = "Quantity";
            btnequipo.Text = "Product registration";
        }

        private void controlinventario_Load(object sender, EventArgs e)
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
            mostrar();
            btneliminar.Enabled = false;
            btnupdate.Enabled = false;
            this.dgvmat.Columns[0].Visible = false;

        }
        public void limpiar()
        {
            txttipo.Clear();
            txtmarca.Clear();
            txtprice.Clear();
            txtId.Clear();
            txtname.Clear();
            txtcant.Clear();

        }
        public void mostrar()
        {

            dgvmat.DataSource = funciones_material.mostrar();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {

            add();
            mostrar();
            limpiar();
           
        
           
        }
        public void add()
        {
            if (txtcant.Text.Trim() == "" || txtname.Text.Trim()==""||txtprice.Text.Trim()==""||txttipo.Text.Trim()==""||txtmarca.Text.Trim()=="")
            {
                MessageBox.Show("campos vacios", "faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                constructorequip add = new constructorequip();
                int val;
                if (Int32.TryParse(txtcant.Text, out val))
                {


                    add.marca = txtmarca.Text;
                    add.nombre = txtname.Text;
                    add.precio = double.Parse(txtprice.Text);
                    add.tipo = txttipo.Text;
                    add.cantidad = Convert.ToInt32(txtcant.Text);
                    int datos = funciones_material.agregar(add);

                }
            }
           
            
               
            
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void dgvcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvcliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = this.dgvmat.CurrentRow.Index;
            txtId.Text = dgvmat[0, posicion].Value.ToString();
            txtname.Text = dgvmat[1, posicion].Value.ToString();
            txttipo.Text = dgvmat[2, posicion].Value.ToString();
            txtmarca.Text = dgvmat[3, posicion].Value.ToString();
            txtprice.Text = dgvmat[4, posicion].Value.ToString();
            txtcant.Text = dgvmat[5, posicion].Value.ToString();
            btnregistrar.Enabled = false;
            btnupdate.Enabled = true;
            btneliminar.Enabled = true;
        }
        constructorequip upd = new constructorequip();
        public void update()
        {
            int val;
            if (Int32.TryParse(txtcant.Text, out val))
            {
                upd.tipo = txttipo.Text;
                upd.precio = double.Parse(txtprice.Text);
                upd.marca = txtmarca.Text;
                upd.cantidad = Convert.ToInt32(txtcant.Text);
                upd.id_material = int.Parse(txtId.Text);
                upd.nombre = txtname.Text;
                funciones_material.actualizar(upd);
            }
        }
        public void delete()
        {
            if (MessageBox.Show("Esta seguro de eliminar el registro", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                funciones_material.eliminar(Convert.ToInt32(txtId.Text));

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            update();
            limpiar();
            mostrar();
            btnregistrar.Enabled = true;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            delete();
            mostrar();
            limpiar();
            btnregistrar.Enabled = true;
            btneliminar.Enabled = false;
            btnupdate.Enabled = false;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfiltrar_TextChanged(object sender, EventArgs e)
        {
            if (txtfiltrar.Text !="")
            {
                dgvmat.CurrentCell = null;
                foreach (DataGridViewRow r in dgvmat.Rows)
                {
                    r.Visible = false;
                }
                foreach(DataGridViewRow r in dgvmat.Rows)
                {
                    foreach(DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtfiltrar.Text.ToUpper())==0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
               dgvmat.DataSource = funciones_material.mostrar();
            }
        }

        private void txtfiltrar_Click(object sender, EventArgs e)
        {

        }

        private void grpregistro_Enter(object sender, EventArgs e)
        {

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txttipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtmarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtcant_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void btnlimp_Click(object sender, EventArgs e)
        {
            limpiar();
            btneliminar.Enabled = false;
            btnupdate.Enabled = false;
            btnregistrar.Enabled = true;
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
