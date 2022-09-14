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

namespace SAMPLE_MEMO_NOTIF
{
    public partial class ShowOfficesForm : DevExpress.XtraEditors.XtraForm
    {
        public ShowOfficesForm()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void ShowOfficesForm_Load(object sender, EventArgs e)
        {
            DataTable dtb = ShowOfficesDal.showoffice();
            gridControl1.DataSource = dtb;
        }


    }
}