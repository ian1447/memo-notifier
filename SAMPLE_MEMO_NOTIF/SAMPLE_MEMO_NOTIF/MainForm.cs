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
            Object_control(false);
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void btnShowMemo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Object_control(true);
        }
        private void Object_control(bool control) {

            GrpMemoList.Visible = control;
            GrpMemoInfo.Visible = control;
            
        }
    }
}