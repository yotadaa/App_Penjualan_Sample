using MDI_Form.Kelas;
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
    public partial class FormLogin : Form
    {

        private string username = "admin";
        private string password = "123";
        private Menu_Utama mainForm;
        public FormLogin(Menu_Utama callingForm)
        {
            mainForm = callingForm;
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void login_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_login_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (user.getUser(login_nama.Text, login_password.Text))
            {
                mainForm.loginProcess();
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Login Gagal");
            }
        }


        private void login_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
