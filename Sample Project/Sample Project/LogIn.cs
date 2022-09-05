using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Sample_Project
{
    public partial class LogIn : DevExpress.XtraEditors.XtraForm
    {
        MySqlConnectivity newconn = new MySqlConnectivity();
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Button_Click(object sender, EventArgs e)
        {

        }
    }
}