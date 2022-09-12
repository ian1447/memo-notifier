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
            if (!string.IsNullOrEmpty(txtTitle.Text) && !string.IsNullOrEmpty(txtParticulars.Text))
            {
                ShowLoading("Adding Memo.....");
                bgAddMemo.RunWorkerAsync();
            }
            else
                MessageBox.Show("Please Input Details Above!!");
        }

        private void txtMemoNo_EditValueChanged(object sender, EventArgs e)
        {
            idno = txtMemoNo.Text;
            DataTable tbl2 = new DataTable();
            tbl2 = AddMemoDal.CheckEdit(idno);
            if (tbl2 == null)
                ceEditMemo.Checked = false;
            else
                ceEditMemo.Checked = true;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            string id_value = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"id")+ "";
            txtMemoNo.Text = id_value;
            ceEditMemo.Checked = true;
            txtMemoNo.Visible = true;
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMemoNo.Text))
                idno = txtMemoNo.Text;
            else
                idno = "0";
            MessageBox.Show(idno);
            AddMemoDal.add_memo(idno, txtTitle.Text, txtParticulars.Text, addedby);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (ceEditMemo.Checked == true)
            {
                if (AddMemoDal.isAddingSuccessful)
                {
                    MessageBox.Show("Editing Successful.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(AddMemoDal.ErrorMessage + "\nFunction: add_memo");
                }
            }
            else
            {
                if (AddMemoDal.isAddingSuccessful)
                {
                    MessageBox.Show("Adding Successful.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(AddMemoDal.ErrorMessage + "\nFunction: add_memo");
                }
            }
        }

        private void ceEditMemo_CheckedChanged(object sender, EventArgs e)
        {
            if (ceEditMemo.Checked == false)
            {
                txtMemoNo.Text = string.Empty;
                txtMemoNo.Visible = false;
                lblMemoNo.Visible = false;
            }
            else
            {
                txtMemoNo.Visible = true;
                lblMemoNo.Visible = true;
            }
                
        }
    }
}