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
        }

        private void controlinventario_Load(object sender, EventArgs e)
        {

            mostrar();
            btneliminar.Enabled = false;
            btnupdate.Enabled = false;
            this.dgvcliente.Columns[0].Visible = false;

        }
        public void limpiar()
        {
            txttipo.Clear();
            marca.Clear();
            txtprice.Clear();
            txtId.Clear();
            txtname.Clear();
            txtcant.Clear();

        }
        public void mostrar()
        {

            dgvcliente.DataSource = funciones_material.mostrar();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {

            add();
            mostrar();
            limpiar();
           
        
           
        }
        public void add()
        {
            if (txtcant.Text.Trim() == "" || txtname.Text.Trim()==""||txtprice.Text.Trim()==""||txttipo.Text.Trim()==""||marca.Text.Trim()=="")
            {
                MessageBox.Show("campos vacios", "faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                constructorequip add = new constructorequip();
                int val;
                if (Int32.TryParse(txtcant.Text, out val))
                {


                    add.marca = marca.Text;
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
            int posicion = this.dgvcliente.CurrentRow.Index;
            txtId.Text = dgvcliente[0, posicion].Value.ToString();
            txtname.Text = dgvcliente[1, posicion].Value.ToString();
            txttipo.Text = dgvcliente[2, posicion].Value.ToString();
            marca.Text = dgvcliente[3, posicion].Value.ToString();
            txtprice.Text = dgvcliente[4, posicion].Value.ToString();
            txtcant.Text = dgvcliente[5, posicion].Value.ToString();
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
                upd.marca = marca.Text;
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
    }
}
