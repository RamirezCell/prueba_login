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
    public partial class bodeguero : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Form currentForm;

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            //Buscar la coleccion del formulario
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                if (currentForm != null)
                {
                    currentForm.Close();
                    panelContenedor.Controls.Remove(currentForm);
                }

                currentForm = formulario;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
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
            foreach (var control in panelContenedor.Controls)
            {
                if (control is bodeguero)
                {

                }


                else
                {

                }
            }
        }
        public bodeguero()
        {
            InitializeComponent();
            btnNormal.Visible = false;
        }

        private void btnCerrar_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            btnMinimizar.Visible = true;
            btnNormal.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form f = new YourOwnWorkshop();
            f.Show();
        }

        private void btnre_Click(object sender, EventArgs e)
        {
            AbrirFormulario<controlinventario>();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
        void ingles()
        {
            bodeguer.Text = "Keeper";
            btnre.Text = " Inventory control";
            logout.Text = "     Log out";
            btnCerrar.Text = "Exit";
            btnMaximizar.Text = "Maximize";

            btnNormal.Text = "Restore Down";
            btnMinimizar.Text = "Minimize";
        }


        private void bodeguero_Load(object sender, EventArgs e)
        {
            if (constructoridioma.Traducir == 1)
            {
                //MessageBox.Show("ESPAÑOL");

            }
            else
            {
                //MessageBox.Show("INGLES");
                ingles();

            }
        }
    }
    
}
