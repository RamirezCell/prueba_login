using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prueba_login.reportes;
using prueba_login.Controlador;
using prueba_login.Modelo;
using System.Text.RegularExpressions;

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

            if (txtplaca.Text.Trim()==""||txtmotor.Text.Trim()==""||txtchasis.Text.Trim()=="")
            {
                MessageBox.Show("Existen campos vacios","Por favor complete los datos solicitados",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                add.estado_vehiculo = Convert.ToInt32(cmbEstado_Vehiculo.SelectedValue);
                add.id_cliente = Convert.ToInt32(cmbPropietario.SelectedValue);
                add.marca = Convert.ToInt32(cmbMarca_vehiculo.SelectedValue);
                add.modelo = Convert.ToInt32(cmbModelo_Vehiculo.SelectedValue);
                add.linea = Convert.ToInt32(cmbModelo_Vehiculo.SelectedValue);
                add.tipo_placa = Convert.ToInt32(cmbplaca.SelectedValue);
                add.tipo_vehiculo = Convert.ToInt32(cmbTipo_Vehiculo.SelectedValue);
                add.numero_motor = txtmotor.Text;
                add.numero_chasis = txtchasis.Text;
                add.numplaca = Convert.ToInt32(txtplaca.Text);
                int datos = funcionesvehiculo.agregar(add);
            }
          
        }

        constructorvehiculo actualizar = new constructorvehiculo();
        private void upd()
        {
            actualizar.estado_vehiculo = Convert.ToInt32(cmbEstado_Vehiculo.SelectedValue);
            actualizar.id_cliente = Convert.ToInt32(cmbPropietario.SelectedValue);
            constructorvehiculo.id_vehiculo = Convert.ToInt32(txtIdvehiculo.Text);
            actualizar.linea = Convert.ToInt32(cmbLinea.SelectedValue);
            actualizar.marca = Convert.ToInt32(cmbMarca_vehiculo.SelectedValue);
            actualizar.modelo = Convert.ToInt32(cmbModelo_Vehiculo.SelectedValue);
            actualizar.tipo_placa = Convert.ToInt32(cmbplaca.SelectedValue);
            actualizar.tipo_vehiculo = Convert.ToInt32(cmbTipo_Vehiculo.SelectedValue);
            actualizar.numero_chasis = txtchasis.Text;
            actualizar.numero_motor = txtmotor.Text;
            actualizar.numplaca = Convert.ToInt32(txtplaca.Text);
            funcionesvehiculo.actualizar(actualizar);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            agregar();
            limpiar();
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

        

        public void mazda323()
        {
            cmbLinea.DataSource = funcionesvehiculo.edicionmazda323();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }
        public void rx8()
        {
            cmbLinea.DataSource = funcionesvehiculo.edicionmazdarex8();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }
        public void cx5()
        {
            cmbLinea.DataSource = funcionesvehiculo.edicionmazdacx5();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }
        public void accent()
        {
            cmbLinea.DataSource = funcionesvehiculo.accent();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }
        public void elantra()
        {
            cmbLinea.DataSource = funcionesvehiculo.elantra();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void tiburon()
        {
            cmbLinea.DataSource = funcionesvehiculo.tiburon();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void tucson()
        {
            cmbLinea.DataSource = funcionesvehiculo.tucson();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void veloster()
        {
            cmbLinea.DataSource = funcionesvehiculo.veloster();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void santafe()
        {
            cmbLinea.DataSource = funcionesvehiculo.santafe();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void terracan()
        {
            cmbLinea.DataSource = funcionesvehiculo.terracan();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void creta()
        {
            cmbLinea.DataSource = funcionesvehiculo.creta();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }
        //toyota//

        public void corolla()
        {
            cmbLinea.DataSource = funcionesvehiculo.corolla();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void rav4()
        {
            cmbLinea.DataSource = funcionesvehiculo.rav4();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void yaris()
        {
            cmbLinea.DataSource = funcionesvehiculo.yaris();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void hilux()
        {
            cmbLinea.DataSource = funcionesvehiculo.hilux();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void agya()
        {
            cmbLinea.DataSource = funcionesvehiculo.agya();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void matrix()
        {
            cmbLinea.DataSource = funcionesvehiculo.matrix();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void tacoma()
        {
            cmbLinea.DataSource = funcionesvehiculo.tacoma();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void tercel()
        {
            cmbLinea.DataSource = funcionesvehiculo.tercel();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void landcrusuiser()
        {
            cmbLinea.DataSource = funcionesvehiculo.prado();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }
        //nissan//
        public void sentra()
        {
            cmbLinea.DataSource = funcionesvehiculo.sentra();
            cmbLinea.DisplayMember = "linea";

            cmbLinea.ValueMember = "id_linea";
        }


        public void frontier()
        {
            cmbLinea.DataSource = funcionesvehiculo.frontier();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void navara()
        {
            cmbLinea.DataSource = funcionesvehiculo.navara();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void urvan()
        {
            cmbLinea.DataSource = funcionesvehiculo.urvan();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void versa()
        {
            cmbLinea.DataSource = funcionesvehiculo.versa();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void maxima()
        {
            cmbLinea.DataSource = funcionesvehiculo.maxima();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void rogue()
        {
            cmbLinea.DataSource = funcionesvehiculo.rogue();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void patrol()
        {
            cmbLinea.DataSource = funcionesvehiculo.patrol();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }
        //mercedes//
        public void clasea()
        {
            cmbLinea.DataSource = funcionesvehiculo.clasea();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void claseb()
        {
            cmbLinea.DataSource = funcionesvehiculo.claseb();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }


        public void clasec()
        {
            cmbLinea.DataSource = funcionesvehiculo.clasec();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }


        public void cla()
        {
            cmbLinea.DataSource = funcionesvehiculo.cla();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }


        public void cls()
        {
            cmbLinea.DataSource = funcionesvehiculo.cls();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void glc()
        {
            cmbLinea.DataSource = funcionesvehiculo.glc();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void clasee()
        {
            cmbLinea.DataSource = funcionesvehiculo.clasee();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }
        //kia//

        public void rio()
        {
            cmbLinea.DataSource = funcionesvehiculo.rio();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void forte()
        {
            cmbLinea.DataSource = funcionesvehiculo.forte();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }


        public void sorento()
        {
            cmbLinea.DataSource = funcionesvehiculo.sorento();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }


        public void sportage()
        {
            cmbLinea.DataSource = funcionesvehiculo.sportage();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }


        public void picanto()
        {
            cmbLinea.DataSource = funcionesvehiculo.picanto();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }


        public void koup()
        {
            cmbLinea.DataSource = funcionesvehiculo.koup();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }


        public void soul()
        {
            cmbLinea.DataSource = funcionesvehiculo.soul();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }


        public void optima()
        {
            cmbLinea.DataSource = funcionesvehiculo.optima();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }
        //jeep//
        public void wrangler()
        {
            cmbLinea.DataSource = funcionesvehiculo.wrangler();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void cherokee()
        {
            cmbLinea.DataSource = funcionesvehiculo.cherokee();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void regenade()
        {
            cmbLinea.DataSource = funcionesvehiculo.regenade();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }


        public void dmax()
        {
            cmbLinea.DataSource = funcionesvehiculo.dmax();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void rodeo()
        {
            cmbLinea.DataSource = funcionesvehiculo.rodeo();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }
        //honda//

        public void accord()
        {
            cmbLinea.DataSource = funcionesvehiculo.accord();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void fit()
        {
            cmbLinea.DataSource = funcionesvehiculo.fit();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void civic()
        {
            cmbLinea.DataSource = funcionesvehiculo.civic();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }


        public void hrv()
        {
            cmbLinea.DataSource = funcionesvehiculo.hrv();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void crv()
        {
            cmbLinea.DataSource = funcionesvehiculo.crv();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }


        public void pilot()
        {
            cmbLinea.DataSource = funcionesvehiculo.pilot();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        //ford//
        public void focus()
        {
            cmbLinea.DataSource = funcionesvehiculo.focus();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }


        public void fiesta()
        {
            cmbLinea.DataSource = funcionesvehiculo.fiesta();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void escape()
        {
            cmbLinea.DataSource = funcionesvehiculo.escape();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void explorer()
        {
            cmbLinea.DataSource = funcionesvehiculo.explorer();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }


        public void ranger()
        {
            cmbLinea.DataSource = funcionesvehiculo.ranger();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }

        public void f150()
        {
            cmbLinea.DataSource = funcionesvehiculo.f150();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }
        //bmw//

        public void serie1()
        {
            cmbLinea.DataSource = funcionesvehiculo.serie1();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }
        public void serie2()
        {
            cmbLinea.DataSource = funcionesvehiculo.serie2();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }
        public void serie3()
        {
            cmbLinea.DataSource = funcionesvehiculo.serie3();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }
        public void serie5()
        {
            cmbLinea.DataSource = funcionesvehiculo.serie5();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }
        public void x3()
        {
            cmbLinea.DataSource = funcionesvehiculo.x3();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }
        public void x6()
        {
            cmbLinea.DataSource = funcionesvehiculo.x6();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }
        public void m5()
        {
            cmbLinea.DataSource = funcionesvehiculo.m5();
            cmbLinea.DisplayMember = "linea";
            cmbLinea.ValueMember = "id_linea";
        }
        private void registroauto_Load(object sender, EventArgs e)
        {
            mostrar();


            marcas();
            cmbEstado_Vehiculo.DataSource = funcionesvehiculo.estadosvehiculo();
            cmbEstado_Vehiculo.DisplayMember = "estado";
            cmbEstado_Vehiculo.ValueMember = "id_estado_vehiculo";

            cmbTipo_Vehiculo.DataSource = funcionesvehiculo.tiposcarro();
            cmbTipo_Vehiculo.DisplayMember = "tipo_vehiculo";
            cmbTipo_Vehiculo.ValueMember = "id_tipo_vehiculo";

            cmbplaca.DataSource = funcionesvehiculo.placas();
            cmbplaca.DisplayMember = "tipo_placa";
            cmbplaca.ValueMember = "id_placa";


            cmbPropietario.DataSource = funcionesvehiculo.clientes();
            cmbPropietario.DisplayMember = "Nombrecliente";
            cmbPropietario.ValueMember = "id_cliente";








            btneliminar.Enabled = false;
            btnupdate.Enabled = false;
            this.dgvvehiculos.Columns[0].Visible = false;


            mostrar();
            

        }

      

    

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void dgvvehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = this.dgvvehiculos.CurrentRow.Index;
            txtIdvehiculo.Text = dgvvehiculos[0, posicion].Value.ToString();
            cmbMarca_vehiculo.Text = dgvvehiculos[1, posicion].Value.ToString();
            cmbModelo_Vehiculo.Text = dgvvehiculos[2, posicion].Value.ToString();
            cmbLinea.Text = dgvvehiculos[3, posicion].Value.ToString();
            cmbTipo_Vehiculo.Text = dgvvehiculos[4, posicion].Value.ToString();
            cmbEstado_Vehiculo.Text = dgvvehiculos[5, posicion].Value.ToString();
            cmbplaca.Text = dgvvehiculos[6, posicion].Value.ToString();
            cmbPropietario.Text = dgvvehiculos[7, posicion].Value.ToString();
            txtmotor.Text = dgvvehiculos[8, posicion].Value.ToString();
            txtplaca.Text = dgvvehiculos[9, posicion].Value.ToString();
            txtchasis.Text = dgvvehiculos[10, posicion].Value.ToString();
            
          
           
          
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

            txtchasis.Clear();
            txtmotor.Clear()
                ;
            txtplaca.Clear();


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
            limpiarcampos();
            btneliminar.Enabled = false;
            btnregistrar.Enabled = true;
            btnupdate.Enabled = false;
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
            if (modelo == "3")
            {
                mazda3();
            }
          
            else if (modelo == "323")
            {
                mazda323();
            }
            else if (modelo == "Rx-8")
            {
                rx8();
            }
            else if (modelo == "Cx5")
            {
                cx5();
            }
            else if (modelo == "Accent")
            {
                accent();
            }
            else if (modelo == "Tiburon")
            {
                tiburon();
            }
            else if (modelo == "Elantra")
            {
                elantra();
            }
            else if (modelo == "Veloster")
            {
                veloster();
            }
            else if (modelo == "Santa fe")
            {
                santafe();
            }
            else if (modelo == "Terracan")
            {
                terracan();
            }
            else if (modelo == "Creta")
            {
                creta();
            }
            else if (modelo == "Tucson")
            {
                tucson();
            }
            //toyota
            else if (modelo == "Corolla")
            {
                corolla();
            }
            else if (modelo == "Rav4")
            {
                rav4();
            }
            else if (modelo == "Yaris")
            {
                yaris();
            }
            else if (modelo == "Hilux")
            {
                hilux();
            }
            else if (modelo == "Agya")
            {
                agya();
            }
            else if (modelo == "Matrix")
            {
                matrix();
            }
            else if (modelo == "Tacoma")
            {
                tacoma();
            }
            else if (modelo == "Tercel")
            {
                tercel();
            }
            else if (modelo == "Land Cruiser Prado")
            {
                landcrusuiser();
            }
            //nissan//
            else if (modelo=="Sentra")
            {
                sentra();
            }
            else if (modelo=="Frontier")
            {
                frontier();
            }
            else if (modelo=="Navara")
            {
                navara();
            }
            else if (modelo=="Urvan")
            {
                urvan();
            }
            else if (modelo=="Versa")
            {
                versa();
            }
            else if (modelo=="Maxima")
            {
                maxima();
            }
            else if (modelo=="Rogue")
            {
                rogue();
            }
            else if (modelo=="Patrol")
            {
                patrol();
            }
            //jeep//
            else if (modelo=="Wrangler")
            {
                wrangler();
            }
            else if (modelo=="Grand Cherokee")
            {
                cherokee();
            }
            else if (modelo=="Regenade")
            {
                regenade();
            }
            //ford//
            else if (modelo=="Focus")
            {
                focus();
            }
            else if (modelo=="Fiesta")
            {
                fiesta();
            }
            else if (modelo=="Escape")
            {
                escape();
            }
            else if (modelo=="Explorer")
            {
                explorer();
            }
            else if (modelo=="Ranger")
            {
                ranger();
            }
            else if (modelo=="F-150")
            {
                f150();
            }
            //kia//
            else if (modelo == "Rio")
            {
                rio();
            }
            else if (modelo == "Forte")
            {
                forte();
            }
            else if (modelo == "Sorento")
            {
                sorento();
            }
            else if (modelo == "Sportage")
            {
                sportage();
            }
            else if (modelo == "Picanto")
            {
                picanto();
            }
            else if (modelo == "Koup")
            {
                koup();
            }
            else if (modelo == "Soul")
            {
                soul();
            }
            else if (modelo == "Optima")
            {
                optima();
            }
            //mercedes//
            else if (modelo == "Clase A")
            {
                clasea();
            }
            else if (modelo == "Clase B")
            {
                claseb();
            }
            else if (modelo == "Clase C")
            {
               clasec();
            }
            else if (modelo == "Clase CLA")
            {
                cla();
            }
            else if (modelo == "Clase CLS")
            {
                cls();
            }
            else if (modelo == "Clase GLC")
            {
                glc();
            }
            else if (modelo == "Clase E")
            {
                clasee();
            }
            //isuzu//
            else if (modelo == "D-Max")
            {
                dmax();
            }
            else if (modelo == "Rodeo")
            {
                rodeo();
            }
            //honda//
            else if (modelo == "Accord")
            {
                accord();
            }
            else if (modelo == "Fit")
            {
                fit();
            }
            else if (modelo == "Civic")
            {
                civic();
            }
            else if (modelo == "Hr-v")
            {
                hrv();
            }
            else if (modelo == "Cr-v")
            {
                crv();
            }
            else if (modelo == "Pilot")
            {
                pilot();
            }
            //bmw//
            else if (modelo == "Serie 1")
            {
                serie1();
            }
            else if (modelo == "Serie 2")
            {
                serie2();
            }
            else if (modelo == "Serie 3")
            {
                serie3();
            }
            else if (modelo == "Serie 5")
            {
                serie5();
            }
            else if (modelo == "X3")
            {
                x3();
            }
            else if (modelo == "X6")
            {
                x6();
            }
            else if (modelo == "M5")
            {
                m5();
            }
        }
        private void cmbModelo_Vehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ediciones();
        }

        private void Dgvvehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txtplaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtplaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Txtmotor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Txtmotor_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void Txtchasis_KeyPress(object sender, KeyPressEventArgs e)
        {
            caracter(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            reportevehiculos repo = new reportevehiculos();
            repo.conseguir_id_vehiculo = Convert.ToInt32(dgvvehiculos.CurrentRow.Cells["id_vehiculo"].Value);
            repo.Show();
            
        }
    }
}
