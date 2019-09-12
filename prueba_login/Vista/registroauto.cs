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
using MySql.Data.MySqlClient;

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
    
        public void marcas()
        {
            cmbMarca_vehiculo.DataSource = funcionesvehiculo.obtenermarcas();
            cmbMarca_vehiculo.DisplayMember = "marca";
            cmbMarca_vehiculo.ValueMember = "id_marca";
        }
        public void mazda()
        {
            cmbModelo_Vehiculo.DataSource = funcionesvehiculo.mazda();
            cmbModelo_Vehiculo.DisplayMember = "modelo";
            cmbModelo_Vehiculo.ValueMember = "id_modelo";
        }
        public void toyota()
        {
            cmbModelo_Vehiculo.DataSource = funcionesvehiculo.toyota();
            cmbModelo_Vehiculo.DisplayMember = "modelo";
            cmbModelo_Vehiculo.ValueMember = "id_modelo";
        }
        public void nissan()
        {
            cmbModelo_Vehiculo.DataSource = funcionesvehiculo.nissan();
            cmbModelo_Vehiculo.DisplayMember = "modelo";
            cmbModelo_Vehiculo.ValueMember = "id_modelo";
        }
        public void jeep()
        {
            cmbModelo_Vehiculo.DataSource = funcionesvehiculo.jeep();
            cmbModelo_Vehiculo.DisplayMember = "modelo";
            cmbModelo_Vehiculo.ValueMember = "id_modelo";
        }
        public void ford()
        {
            cmbModelo_Vehiculo.DataSource = funcionesvehiculo.ford();
            cmbModelo_Vehiculo.DisplayMember = "modelo";
            cmbModelo_Vehiculo.ValueMember = "id_modelo";
        }
        public void kia()
        {
            cmbModelo_Vehiculo.DataSource = funcionesvehiculo.kia();
            cmbModelo_Vehiculo.DisplayMember = "modelo";
            cmbModelo_Vehiculo.ValueMember = "id_modelo";
        }
        public void hyundai()
        {
            cmbModelo_Vehiculo.DataSource = funcionesvehiculo.hyundai();
            cmbModelo_Vehiculo.DisplayMember = "modelo";
            cmbModelo_Vehiculo.ValueMember = "id_modelo";
        }
        public void bmw()
        {
            cmbModelo_Vehiculo.DataSource = funcionesvehiculo.bmw();
            cmbModelo_Vehiculo.DisplayMember = "modelo";
            cmbModelo_Vehiculo.ValueMember = "id_modelo";
        }

        public void honda()
        {
            cmbModelo_Vehiculo.DataSource = funcionesvehiculo.honda();
            cmbModelo_Vehiculo.DisplayMember = "modelo";
            cmbModelo_Vehiculo.ValueMember = "id_modelo";
        }
        public void isuzu()
        {
            cmbModelo_Vehiculo.DataSource = funcionesvehiculo.isuzu();
            cmbModelo_Vehiculo.DisplayMember = "modelo";
            cmbModelo_Vehiculo.ValueMember = "id_modelo";
        }
        public void menche()
        {
            cmbModelo_Vehiculo.DataSource = funcionesvehiculo.mercedes();
            cmbModelo_Vehiculo.DisplayMember = "modelo";
            cmbModelo_Vehiculo.ValueMember = "id_modelo";
        }
        public void mazda3()
        {
            cmbLinea.DataSource = funcionesvehiculo.edicionmazda3();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void mazda6()
        {
            cmbLinea.DataSource = funcionesvehiculo.edicionmazda6();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void mazda323()
        {
            cmbLinea.DataSource = funcionesvehiculo.edicionmazda323();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        private void registroauto_Load(object sender, EventArgs e)
        {
            mostrar();


            marcas();

            
           
            








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
        public void limpiarcampos()
        {
            txtplaca.Clear();
            txtchasis.Clear();
            txtmotor.Clear();
           
        }

        private void btnlimp_Click(object sender, EventArgs e)
        {
            
        }
        public void clasimarcas()
        {
            string marca = cmbMarca_vehiculo.Text;
            if (marca=="Mazda")
            {
                mazda();
            }
            else if (marca=="Toyota")
            {
                toyota();
            }
            else if (marca == "Nissan")
            {
                nissan();
            }
            else if (marca == "Jeep")
            {
                jeep();
            }
            else if (marca == "Ford")
            {
                ford();
            }
            else if (marca == "Kia")
            {
                kia();
            }
            else if (marca == "Hyundai")
            {
                hyundai();
            }
            else if (marca == "BMW")
            {
                bmw();
            }
            else if (marca == "Honda")
            {
                honda();
            }
            else if (marca == "Isuzu")
            {
                isuzu();
            }
            else if (marca == "Mercedes-Benz")
            {
                menche();
            }
          


        }

        private void cmbMarca_vehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            clasimarcas();
          
        }
        public void ediciones()
        {
            string modelo = cmbModelo_Vehiculo.Text;
            if (modelo=="3")
            {
                mazda3();
            }
            else if (modelo=="6")
            {
                mazda6();
            }
            else if (modelo == "323")
            {
                mazda323();
            }
        }
        private void cmbModelo_Vehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ediciones();
        }
    }
}
