namespace SAMPLE_MEMO_NOTIF
{
    partial class AddMemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMemo));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddMemo = new DevExpress.XtraEditors.SimpleButton();
            this.txtMemoNo = new DevExpress.XtraEditors.TextEdit();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            this.lblMemoNo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtParticulars = new DevExpress.XtraEditors.TextEdit();
            this.ceEditMemo = new DevExpress.XtraEditors.CheckEdit();
            this.btncancel = new DevExpress.XtraEditors.SimpleButton();
            this.bgAddMemo = new System.ComponentModel.BackgroundWorker();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::SAMPLE_MEMO_NOTIF.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemoNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParticulars.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceEditMemo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(228, 263);
            this.gridControl1.TabIndex = 330;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.title});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // id
            // 
            this.id.Caption = "Memo ID";
            this.id.FieldName = "id";
            this.id.Name = "id";
            this.id.Visible = true;
            this.id.VisibleIndex = 0;
            // 
            // title
            // 
            this.title.Caption = "TITLE";
            this.title.FieldName = "title";
            this.title.Name = "title";
            this.title.Visible = true;
            this.title.VisibleIndex = 1;
            // 
            // btnAddMemo
            // 
            this.btnAddMemo.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMemo.Image")));
            this.btnAddMemo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAddMemo.Location = new System.Drawing.Point(435, 229);
            this.btnAddMemo.Name = "btnAddMemo";
            this.btnAddMemo.Size = new System.Drawing.Size(106, 46);
            this.btnAddMemo.TabIndex = 331;
            this.btnAddMemo.Text = "Add Memo";
            this.btnAddMemo.Click += new System.EventHandler(this.btnAddMemo_Click);
            // 
            // txtMemoNo
            // 
            this.txtMemoNo.Location = new System.Drawing.Point(285, 41);
            this.txtMemoNo.Name = "txtMemoNo";
            this.txtMemoNo.Size = new System.Drawing.Size(129, 20);
            this.txtMemoNo.TabIndex = 332;
            this.txtMemoNo.EditValueChanged += new System.EventHandler(this.txtMemoNo_EditValueChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(285, 86);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(372, 20);
            this.txtTitle.TabIndex = 333;
            // 
            // lblMemoNo
            // 
            this.lblMemoNo.Location = new System.Drawing.Point(285, 21);
            this.lblMemoNo.Name = "lblMemoNo";
            this.lblMemoNo.Size = new System.Drawing.Size(48, 13);
            this.lblMemoNo.TabIndex = 335;
            this.lblMemoNo.Text = "Memo No.";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(285, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 336;
            this.labelControl2.Text = "TITLE:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(285, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 338;
            this.labelControl3.Text = "Particulars";
            // 
            // txtParticulars
            // 
            this.txtParticulars.Location = new System.Drawing.Point(285, 139);
            this.txtParticulars.Name = "txtParticulars";
            this.txtParticulars.Size = new System.Drawing.Size(372, 20);
            this.txtParticulars.TabIndex = 337;
            // 
            // ceEditMemo
            // 
            this.ceEditMemo.EditValue = true;
            this.ceEditMemo.Location = new System.Drawing.Point(582, 15);
            this.ceEditMemo.Name = "ceEditMemo";
            this.ceEditMemo.Properties.Caption = "Edit Memo";
            this.ceEditMemo.Size = new System.Drawing.Size(75, 19);
            this.ceEditMemo.TabIndex = 339;
            this.ceEditMemo.CheckedChanged += new System.EventHandler(this.ceEditMemo_CheckedChanged);
            // 
            // btncancel
            // 
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(550, 229);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(106, 46);
            this.btncancel.TabIndex = 340;
            this.btncancel.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // bgAddMemo
            // 
            this.bgAddMemo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.bgAddMemo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // AddMemo
            // 
            this.AcceptButton = this.btnAddMemo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 302);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.ceEditMemo);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtParticulars);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblMemoNo);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtMemoNo);
            this.Controls.Add(this.btnAddMemo);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddMemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMemo";
            this.Load += new System.EventHandler(this.AddMemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemoNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParticulars.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceEditMemo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btnAddMemo;
        private DevExpress.XtraEditors.TextEdit txtMemoNo;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private DevExpress.XtraEditors.LabelControl lblMemoNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtParticulars;
        private DevExpress.XtraEditors.CheckEdit ceEditMemo;
        private DevExpress.XtraEditors.SimpleButton btncancel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn title;
        private System.ComponentModel.BackgroundWorker bgAddMemo;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}