using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using SAMPLE_MEMO_NOTIF.CORE;
using SAMPLE_MEMO_NOTIF.DAL;

namespace SAMPLE_MEMO_NOTIF
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnShowMemo_ItemClick(object sender, ItemClickEventArgs e)
        {
            ViewMemoForm vmf = new ViewMemoForm();
            vmf.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Go back?","Confirmation.",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Login.UserLogout = true;
                this.Close();
            }
        }

    }
}