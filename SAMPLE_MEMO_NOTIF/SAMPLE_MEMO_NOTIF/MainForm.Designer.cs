namespace SAMPLE_MEMO_NOTIF
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAddMemo = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowMemo = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowOffices = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.GrpMemoList = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GrpMemoInfo = new System.Windows.Forms.GroupBox();
            this.picMemoImage = new DevExpress.XtraEditors.PictureEdit();
            this.lblMemoDescription = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblMemoTitle = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblMemoNo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnMarkReceived = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.GrpMemoList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GrpMemoInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMemoImage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnAddMemo,
            this.btnShowMemo,
            this.btnShowOffices,
            this.barButtonItem4});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(988, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // btnAddMemo
            // 
            this.btnAddMemo.Caption = "Add Memo";
            this.btnAddMemo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddMemo.Glyph")));
            this.btnAddMemo.Id = 1;
            this.btnAddMemo.Name = "btnAddMemo";
            this.btnAddMemo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnShowMemo
            // 
            this.btnShowMemo.Caption = "Show Memos";
            this.btnShowMemo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnShowMemo.Glyph")));
            this.btnShowMemo.Id = 2;
            this.btnShowMemo.Name = "btnShowMemo";
            this.btnShowMemo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnShowMemo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowMemo_ItemClick);
            // 
            // btnShowOffices
            // 
            this.btnShowOffices.Caption = "Show Offices";
            this.btnShowOffices.Glyph = ((System.Drawing.Image)(resources.GetObject("btnShowOffices.Glyph")));
            this.btnShowOffices.Id = 3;
            this.btnShowOffices.Name = "btnShowOffices";
            this.btnShowOffices.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAddMemo);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnShowMemo);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Memorandum";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnShowOffices);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Offices";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 571);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(988, 31);
            // 
            // GrpMemoList
            // 
            this.GrpMemoList.Controls.Add(this.dataGridView1);
            this.GrpMemoList.Location = new System.Drawing.Point(30, 150);
            this.GrpMemoList.Name = "GrpMemoList";
            this.GrpMemoList.Size = new System.Drawing.Size(253, 404);
            this.GrpMemoList.TabIndex = 2;
            this.GrpMemoList.TabStop = false;
            this.GrpMemoList.Text = "List of Memos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(241, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // GrpMemoInfo
            // 
            this.GrpMemoInfo.Controls.Add(this.picMemoImage);
            this.GrpMemoInfo.Controls.Add(this.lblMemoDescription);
            this.GrpMemoInfo.Controls.Add(this.labelControl3);
            this.GrpMemoInfo.Controls.Add(this.lblMemoTitle);
            this.GrpMemoInfo.Controls.Add(this.labelControl2);
            this.GrpMemoInfo.Controls.Add(this.lblMemoNo);
            this.GrpMemoInfo.Controls.Add(this.labelControl1);
            this.GrpMemoInfo.Controls.Add(this.btnMarkReceived);
            this.GrpMemoInfo.Location = new System.Drawing.Point(290, 150);
            this.GrpMemoInfo.Name = "GrpMemoInfo";
            this.GrpMemoInfo.Size = new System.Drawing.Size(686, 404);
            this.GrpMemoInfo.TabIndex = 5;
            this.GrpMemoInfo.TabStop = false;
            this.GrpMemoInfo.Text = "Memo Info";
            // 
            // picMemoImage
            // 
            this.picMemoImage.Location = new System.Drawing.Point(351, 20);
            this.picMemoImage.MenuManager = this.ribbon;
            this.picMemoImage.Name = "picMemoImage";
            this.picMemoImage.Size = new System.Drawing.Size(329, 292);
            this.picMemoImage.TabIndex = 7;
            // 
            // lblMemoDescription
            // 
            this.lblMemoDescription.Location = new System.Drawing.Point(96, 90);
            this.lblMemoDescription.Name = "lblMemoDescription";
            this.lblMemoDescription.Size = new System.Drawing.Size(144, 13);
            this.lblMemoDescription.TabIndex = 6;
            this.lblMemoDescription.Text = "MEMORANDUM DESCRIPTION";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "DESCRIPTION : ";
            // 
            // lblMemoTitle
            // 
            this.lblMemoTitle.Location = new System.Drawing.Point(96, 59);
            this.lblMemoTitle.Name = "lblMemoTitle";
            this.lblMemoTitle.Size = new System.Drawing.Size(103, 13);
            this.lblMemoTitle.TabIndex = 4;
            this.lblMemoTitle.Text = "MEMORANDUM TITLE";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(48, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "TITLE : ";
            // 
            // lblMemoNo
            // 
            this.lblMemoNo.Location = new System.Drawing.Point(96, 30);
            this.lblMemoNo.Name = "lblMemoNo";
            this.lblMemoNo.Size = new System.Drawing.Size(42, 13);
            this.lblMemoNo.TabIndex = 2;
            this.lblMemoNo.Text = "0000000";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Memo No. :";
            // 
            // btnMarkReceived
            // 
            this.btnMarkReceived.Image = ((System.Drawing.Image)(resources.GetObject("btnMarkReceived.Image")));
            this.btnMarkReceived.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnMarkReceived.Location = new System.Drawing.Point(551, 360);
            this.btnMarkReceived.Name = "btnMarkReceived";
            this.btnMarkReceived.Size = new System.Drawing.Size(129, 38);
            this.btnMarkReceived.TabIndex = 0;
            this.btnMarkReceived.Text = "Mark as Received";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Center;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(988, 602);
            this.Controls.Add(this.GrpMemoInfo);
            this.Controls.Add(this.GrpMemoList);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.GrpMemoList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GrpMemoInfo.ResumeLayout(false);
            this.GrpMemoInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMemoImage.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnAddMemo;
        private DevExpress.XtraBars.BarButtonItem btnShowMemo;
        private DevExpress.XtraBars.BarButtonItem btnShowOffices;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.GroupBox GrpMemoList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox GrpMemoInfo;
        private DevExpress.XtraEditors.PictureEdit picMemoImage;
        private DevExpress.XtraEditors.LabelControl lblMemoDescription;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblMemoTitle;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblMemoNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnMarkReceived;
    }
}