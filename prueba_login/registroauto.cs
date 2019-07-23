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
        constructorvehiculo add = new constructorvehiculo();

        public void agregar()
        {
            add.nombre_vehiculo = txtmarca.Text;
            add.modelo = txtmodelo.Text;
            add.tipo_auto = txttipovehiculo.Text;
            add.year = Convert.ToInt32(txtanio.Text);
            int datos = funcionesvehiculo.agregar(add);
            
        }

        constructorvehiculo actualizar = new constructorvehiculo();
        private void upd()
        {
            actualizar.id_vehiculo = int.Parse(txtIdvehiculo.Text);
            actualizar.nombre_vehiculo = txtmarca.Text;
            actualizar.modelo = txtmodelo.Text;
            actualizar.year = int.Parse(    txtanio.Text);
            actualizar.tipo_auto = txttipovehiculo.Text;
            funcionesvehiculo.actualizar(actualizar);


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
          
            txtIdvehiculo.Text = dgvvehiculos[0, posicion].Value.ToString();
            txtmarca.Text = dgvvehiculos[1, posicion].Value.ToString();
            txtmodelo.Text = dgvvehiculos[2, posicion].Value.ToString();
            txtanio.Text = dgvvehiculos[3, posicion].Value.ToString();
            txttipovehiculo.Text = dgvvehiculos[4, posicion].Value.ToString();
          
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
            txttipovehiculo.Clear();
            txtmodelo.Clear();
            txtmarca.Clear();
            txtanio.Clear();
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
    }
}
