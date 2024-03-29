﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prueba_login.Controlador;
using System.Runtime.InteropServices;

namespace prueba_login
{
    public partial class Trabajador : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        public Trabajador()
        {
            InitializeComponent();
            BtnRestaurar2.Visible = false;

        }
        Form currentForm;

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            //Buscar la coleccion del formulario
            formulario = panelContenedor4.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                if (currentForm != null)
                {
                    currentForm.Close();
                    panelContenedor4.Controls.Remove(currentForm);
                }

                currentForm = formulario;
                panelContenedor4.Controls.Add(formulario);
                panelContenedor4.Tag = formulario;
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
            foreach (var control in panelContenedor4.Controls)
            {
                if (control is Trabajador)
                {

                }


                else
                {

                }
            }
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new YourOwnWorkshop();
            f.Show();
        }
        int lx, ly, sw, sh;
        private void BtnMaximizar2_Click(object sender, EventArgs e)
        {
            BtnMaximizar2.Visible = false;
            BtnRestaurar2.Visible = true;
            lx = this.Location.X;

            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void BtnRestaurar2_Click(object sender, EventArgs e)
        {
            BtnMaximizar2.Visible = true;
            BtnRestaurar2.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void BtnMinizar2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSalir2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void ingles()
        {
            lbllog.Text = "   Log out";
            lbltrabajo.Text = "  Worker";
            btnVerOrden.Text = "  View orders";
            BtnSalir2.Text = "Exit";
            BtnRestaurar2.Text = "Restore down";
            BtnMaximizar2.Text = "Maximize";
            BtnMinizar2.Text = "Minimize";

        }

        private void Trabajador_Load(object sender, EventArgs e)
        {
            if(constructoridioma.Traducir == 1)
            {
                //MessageBox.Show("ESPAÑOL");

            }
            else
            {
                //MessageBox.Show("INGLES");
                ingles();
            }
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            AbrirFormulario <verordenes>();
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
    }
}
