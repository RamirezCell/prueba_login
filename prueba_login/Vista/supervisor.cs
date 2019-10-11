using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using prueba_login.Controlador;


namespace prueba_login
{
    public partial class Mecanico : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Mecanico()
        {
            
            InitializeComponent();
            BtnRestaurar3.Visible = false;
        }
        Form currentForm;

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            //Buscar la coleccion del formulario
            formulario = panelContenedor2.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                if (currentForm != null)
                {
                    currentForm.Close();
                    panelContenedor2.Controls.Remove(currentForm);
                }

                currentForm = formulario;
                panelContenedor2.Controls.Add(formulario);
                panelContenedor2.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }

        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            foreach (var control in panelContenedor2.Controls)
            {
                if (control is Mecanico)
                {

                }
               
               
                else
                {

                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnControl2_Click(object sender, EventArgs e)
        {
           
        }

        private void panelContenedor2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRegisVeh_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnMaximizar3_Click(object sender, EventArgs e)
        {
            BtnMaximizar3.Visible = false;
            BtnRestaurar3.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void BtnRestaurar3_Click(object sender, EventArgs e)
        {
            BtnMaximizar3.Visible = true;
            BtnRestaurar3.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void BtnMinizar3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSalir3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btningreso_Click(object sender, EventArgs e)
        {
           

        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new YourOwnWorkshop();
            f.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form f = new YourOwnWorkshop();
            f.Show();
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnregistro_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<controlcalidad>();
        }

        private void btnorden_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ordentrabajo>();
        }
        void ingles()
        {
            lblsup.Text = "Overseer";
            logout.Text = "    Log out";
            btnorden.Text = "  Order creation";
            btnregistro.Text = "  Quality control";
            BtnMaximizar3.Text = "Maximize";
            BtnMinizar3.Text = "Minimize";
            BtnRestaurar3.Text = "Restore down";
            BtnSalir3.Text = "Exit";
          
        }
        private void Mecanico_Load(object sender, EventArgs e)
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
        }
    }
}
