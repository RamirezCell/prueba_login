using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prueba_login.Controlador;
using System.Windows.Forms;
//using Sistema_de_facturacion_YOW;


namespace prueba_login
{
    public partial class torre : Form
    {
        public torre()
        {
            InitializeComponent();
            btnNormal.Visible = false;
        }
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
                if (control is registrocliente)
                {

                }

                else
                {

                }
            }
        }

        private void btnre_Click(object sender, EventArgs e)
        {

            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Aseguradora>();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnNormal.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form yow = new YourOwnWorkshop();
            yow.Show();
            this.Hide();
        }
        void ingles()
        {
            lbllog.Text = "   Log out";
            btnasegu.Text = "   Insurance administration";
            btnCerrar.Text = "Exit";
            btnMaximizar.Text = "Maximize";
            btnMinimizar.Text = "Minimize";
            lbltorre.Text = "  Tower";
            btnNormal.Text = "Restore down";
        }

        private void torre_Load(object sender, EventArgs e)
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
