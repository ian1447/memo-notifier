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
    public partial class AddMemo : DevExpress.XtraEditors.XtraForm
    {
        public AddMemo()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMemo_Load(object sender, EventArgs e)
        {
            try {
                DataTable tbl = new DataTable();
                tbl = GetMemo.fillTable();
                if (tbl.Rows.Count > 0)
                    gridControl1.DataSource = tbl;
                    //gridView1.DataSource = tbl;
                else
                    MessageBox.Show("No Memo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + GetMemo.ErrorMessage);
            }
        }

        public static string idno = "0";
        public static string addedby = "4";
        private void btnAddMemo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTitle.Text) && !string.IsNullOrEmpty(txtParticulars.Text) && !string.IsNullOrEmpty(txtMemoNo.Text))
            {
                idno = txtMemoNo.Text;
                AddMemoDal.add_memo(idno,txtTitle.Text,txtParticulars.Text,addedby);
                if (AddMemoDal.isAddingSuccessful)
                {
                    MessageBox.Show("Adding Successful.");
                    this.Close();
                }
                else {
                    MessageBox.Show(AddMemoDal.ErrorMessage + "\nFunction: add_memo");
                }
            }
            else
                MessageBox.Show("Please Input Details Above!!");
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
        }
    }
}