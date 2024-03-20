using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Form.GUI
{
    public partial class Menu_Utama : Form
    {

        public FormBarang brg;
        public FormLogin login;
        void brg_FormClosed(Object sender, FormClosedEventArgs e)
        {
            brg = null;
        }

        void login_FormClosed(Object sender, FormClosedEventArgs e)
        {
            login = null;
        }

        public Menu_Utama()
        {
            InitializeComponent();
        }

        private void submenu_barang_Click(object sender, EventArgs e)
        {
            if (brg == null)
            {
                brg = new FormBarang();
                brg.MdiParent = this;
                brg.FormClosed += new FormClosedEventHandler(brg_FormClosed);
                brg.Show();
            } else
            {
                brg.Activate();
            }
        }

        private void submenu_login_Click(object sender, EventArgs e)
        {
            if (login == null)
            {
                login = new FormLogin(this);
                login.MdiParent = this;
                login.FormClosed += new FormClosedEventHandler(login_FormClosed);
                login.Show();
            }
            else
            {
                login.Activate();
            }
        }

        private void loginStatus_Click(object sender, EventArgs e)
        {
            
        }

        public void loginProcess()
        {
            toolStrip.Items["loginStatus"].Text = "Logged In";
            submenu_login.Enabled = false;
            submenu_logout.Enabled = true;
            MessageBox.Show("Login Berhasil");
        }

        private void submenu_logout_Click(object sender, EventArgs e)
        {
            toolStrip.Items["loginStatus"].Text = "Belum Login";
            submenu_login.Enabled = true;
            submenu_logout.Enabled = false;
            MessageBox.Show("Logout Berhasil");
        }
    }
}
