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
using prueba_login.Modelo;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;









namespace prueba_login
{
    public partial class YourOwnWorkshop : Form

    {
        public string Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }
        }

        




        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public YourOwnWorkshop()



        {
            InitializeComponent();
            txtpass.ContextMenu = new ContextMenu();
            txtuser.ContextMenu = new ContextMenu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (verificar.verificarempresa() == true)
            {
                if (verificar.verificaruser() == true)
                {
                    btnprimeruso.Visible = false;

                }
                else
                {

                   
                    txtpass.Visible = false;
                    txtuser.Visible = false;
                    btningresar.Visible = false;
                    btnprimeruso.Visible = true;
                    btnrecuperar.Visible = false;


                    btnprimeruso.LabelText = "Crear primer usuario";
                }

            }
            else
            {
                
                txtuser.Visible = false;
                txtpass.Visible = false;
                btningresar.Visible = false;
                btnprimeruso.Visible = true;
               btnrecuperar.Visible=false;
            }
           



        }

        
      



        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text=="USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.White;
            }

        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.LightGray;


            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.White;
                txtpass.UseSystemPasswordChar = true;
            }

        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text=="")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(txtpass.Text.ToString());
            txtcifrado.Text = Hash(pass);
        }

       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnmot_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            


          

            enviar();





        }
       


        void enviar()
        {
          

            if (txtpass.Text.Trim() == "" || txtuser.Text.Trim() == "")
            {
                MessageBox.Show("campos vacios", "Llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                constructotlogin login = new constructotlogin(txtuser.Text, txtpass.Text);
                constructotlogin.usuario = txtuser.Text;
                login.clave = txtcifrado.Text;
                
                
                



                bool datos = validarlogin.acceso(login);
                if (datos == true)
                {

                    if (login.clave== "LoXc4qdLw/ZNPczO4W4h7a7BjsY=")
                    {
                        Form uso = new primerusocualquiera();
                        this.Hide();
                        uso.Show();
                    }
                    else if (login.clave== "ke8MFgiyDJxb2eADu7YAIpwN/rE=")
                    {
                        Form recu = new recuinterno();
                        recu.Show();
                        this.Hide();
                    }

                   else if (constructotlogin.nivel == 1)
                    {
                        Form asesor = new Secretaria();
                        asesor.Show();
                        this.Hide();

                    }
                    else if (constructotlogin.nivel == 2)
                    {
                        Form trabajador = new Trabajador();
                        trabajador.Show();
                        this.Hide();

                    }
                    else if (constructotlogin.nivel == 3)
                    {
                        Form suprevisor = new Mecanico();
                        suprevisor.Show();
                        this.Hide();
                    }
                    else if (constructotlogin.nivel == 4)
                    {
                        Form admin = new admin();
                        admin.Show();
                        this.Hide();
                    }
                    else if (constructotlogin.nivel == 5)
                    {
                        Form bodega = new bodeguero();
                        bodega.Show();
                        this.Hide();
                    }
                    else if (constructotlogin.nivel == 6)
                    {
                        Form torre = new torre();
                        torre.Show();
                        this.Hide();
                    }








                }
            }
        }

        private void btnrecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new opcion_recu();
            form.Show();
            this.Hide();
        }
       







        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == (char)13)
            {
                this.enviar();
            }
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnprimeruso_Click(object sender, EventArgs e)
        {
            if (btnprimeruso.LabelText == "Crear primer usuario")
            {
                Form primeruso = new primerusouser();
                this.Hide();
                primeruso.Show();
            }
            else
            {
                Form primeruso = new PrimerUsoSistema();
                this.Hide();
                primeruso.Show();
            }
        }

        private void btningresar_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
