using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAMPLE_MEMO_NOTIF.DAL;

namespace SAMPLE_MEMO_NOTIF
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
            LoginDal.Connection();
            LoginDal.TryConnection();
            if (LoginDal.isConnection)
            {
                btnlogin1.Enabled = true;
            }
            else
            {
                MessageBox.Show(LoginDal.errormessage);
                btncancel1.Enabled = false;
                btnlogin1.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUsername.Text) && !String.IsNullOrEmpty(txtPassword.Text))
            {
                DataTable UserData = LoginDal.GetUserData(txtUsername.Text,txtPassword.Text);
                if (UserData != null)
                {
                    MessageBox.Show("hello");
                }
                else
                    MessageBox.Show(LoginDal.GetUserDataError);
            }
        }
        private void btnlogin1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUsername.Text) && !String.IsNullOrEmpty(txtPassword.Text))
            {
                DataTable UserData = LoginDal.GetUserData(txtUsername.Text, txtPassword.Text);
                if (UserData != null)
                {
                    MessageBox.Show(LoginDal.errormessage);
                }
                else
                    MessageBox.Show("Wrong Username or Password!!");
            }
        }

        private void btncancel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
