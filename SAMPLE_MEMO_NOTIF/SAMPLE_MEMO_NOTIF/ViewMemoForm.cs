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
    public partial class ViewMemoForm : Form
    {
      
        public ViewMemoForm()
        {
            InitializeComponent();
        }

        private void bwLoadData_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void ViewMemoForm_Load(object sender, EventArgs e)
        {

            FillMemoTable();
        }
        public void FillMemoTable() {
            try
            {
                DataTable tbl = new DataTable();
                tbl = GetMemo.fillTable();
                if (tbl.Rows.Count > 0)
                    memoDataTable.DataSource = tbl;
                else
                    MessageBox.Show("No Memo");
            }
            catch(Exception ex) {
                
                MessageBox.Show(ex + GetMemo.ErrorMessage);
            }
        }

        private void memoDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.memoDataTable.Rows[e.RowIndex];

                lblTitle.Text = row.Cells["title"].Value.ToString();
                lblParticulars.Text = row.Cells["particulars"].Value.ToString();
                lblCategory.Text = row.Cells["category_id"].Value.ToString();

                /*try
                {

                    MemoryStream images = con.getImage(label1.Text);
                    pictureBox1.Image = Image.FromStream(images);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }*/



            }
        }
    }
}
