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
using System.Runtime.InteropServices;


namespace prueba_login
{
    public partial class opcion_recu : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        public opcion_recu()
        {
            InitializeComponent();
        }

        private void btncodi_Click(object sender, EventArgs e)
        {
            Form form = new recu_contra();
            form.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Form form = new YourOwnWorkshop();
            form.Show();
            this.Hide();
        }

        private void opcion_recu_Load(object sender, EventArgs e)
        {
            if (constructoridioma.Traducir == 1)
            {
                //MessageBox.Show("ESPAÑOL");

            }
            else
            {
                //MessageBox.Show("INGLES");
                lblopcion.Text = "Choose an option";
                btncodi.Text = "    Email";
                btnlogin.Text = "Back to login";
                bunifuFlatButton1.Text = "    Security questions";
                bunifuFlatButton2.Text= "    Admin intervention";
            }
        }

        private void opcion_recu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form frm = new frmprguntas();
            frm.Show();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form frm = new recu_admin();
            frm.Show();
            this.Hide();
        }
    }
}
