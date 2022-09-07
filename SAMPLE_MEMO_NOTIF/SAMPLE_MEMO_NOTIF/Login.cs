using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAMPLE_MEMO_NOTIF.DAL;
using System.Threading;

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

        bool loadingIsAlreadyShowing = false;
        private void ShowLoading(string message)
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    c.Enabled = false;
                }

                if (!loadingIsAlreadyShowing)
                {
                    loadingIsAlreadyShowing = true;
                    splashScreenManager.ShowWaitForm();
                }
                splashScreenManager.SetWaitFormDescription(message);
            }
            catch { }
        }

        private void HideLoading()
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    c.Enabled = true;
                }

                loadingIsAlreadyShowing = false;
                splashScreenManager.CloseWaitForm();
            }
            catch { }
        }

        DataTable UserData = new DataTable();
        private void btnlogin1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtUsername.Text) && !String.IsNullOrEmpty(txtPassword.Text))
                {
                    btnlogin1.Enabled = false;
                    ShowLoading("Getting User Data....");
                    bglogin.RunWorkerAsync();
                }
                else
                    MessageBox.Show("Please Input Username or Password!!");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncancel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bglogin_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                UserData = LoginDal.GetUserData(txtUsername.Text, txtPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bglogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            btnlogin1.Enabled = true;
            if (LoginDal.GetUserDataSuccessful)
            {
                if (UserData != null)
                {
                    this.Hide();
                    MessageBox.Show("Welcome " + txtUsername.Text);
                    MainForm MainWin = new MainForm();
                    MainWin.Show();
                }
                else
                    MessageBox.Show(LoginDal.errormessage + "\nWrong Username or Password!!");
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
            txtPassword.Focus();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.SelectAll();
            txtUsername.Focus();
        }
    }
}
