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
            DataTable tbl = new DataTable();
            
            
        }
    }
}
