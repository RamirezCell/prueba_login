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
using prueba_login.reportes;
namespace prueba_login
{
    public partial class verordenes : Form
    {
        public verordenes()
        {
            InitializeComponent();
        }

        private void verordenes_Load(object sender, EventArgs e)
        {
           dgvorden.DataSource= funcionesordendetrabajo.mostrar();
            this.dgvorden.Columns[0].Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtfiltrar.Text != "")
            {
                dgvorden.CurrentCell = null;
                foreach(DataGridViewRow r in dgvorden.Rows)
                {
                    r.Visible = false;
                }
                foreach(DataGridViewRow r in dgvorden.Rows)
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
                dgvorden.DataSource = funcionesordendetrabajo.mostrar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            reporteorden repo = new reporteorden();
            repo.id_ordenconseguir = Convert.ToInt32(dgvorden.CurrentRow.Cells["id_orden"].Value);
            repo.Show();
           
        }

        private void dgvorden_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
