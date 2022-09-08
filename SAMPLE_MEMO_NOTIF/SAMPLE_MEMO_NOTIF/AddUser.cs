using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SAMPLE_MEMO_NOTIF.DAL;
using System.Threading;

namespace SAMPLE_MEMO_NOTIF
{
    public partial class AddUser : DevExpress.XtraEditors.XtraForm
    {
        public AddUser()
        {
            InitializeComponent();
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
                    splashScreenManager1.ShowWaitForm();
                }
                splashScreenManager1.SetWaitFormDescription(message);
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
                splashScreenManager1.CloseWaitForm();
            }
            catch { }
        }
        private void btnadduser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnewuser.Text) && !string.IsNullOrEmpty(txtnewpasswd.Text) && !string.IsNullOrEmpty(txtretypepasswd.Text))
            {
                if (txtretypepasswd.Text == txtnewpasswd.Text)
                {
                    ShowLoading("Adding User....");
                    bgadduser.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Passwords are not the same!!");
                }
            }
            else
            {
                MessageBox.Show("Please Fill Data Above!");
            }

        }

        private void bgadduser_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(3000);
            try
            {
                AddUserDal.AddingUsers(txtnewuser.Text,txtnewpasswd.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bgadduser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (!AddUserDal.isAddingSuccessful)
                MessageBox.Show(AddUserDal.ErrorMessage);
            else
                MessageBox.Show("Done!!");
                this.Close();
        }
    }
}