﻿namespace SAMPLE_MEMO_NOTIF
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAddMemo = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowMemo = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowOffices = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.brbtnlogout = new DevExpress.XtraBars.BarButtonItem();
            this.brbtnadd = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
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
            this.barButtonItem4,
            this.brbtnlogout,
            this.brbtnadd});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.brbtnlogout);
            this.ribbon.PageHeaderItemLinks.Add(this.brbtnadd);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(988, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
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
            this.btnShowOffices.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowOffices_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // brbtnlogout
            // 
            this.brbtnlogout.Caption = "Logout";
            this.brbtnlogout.Glyph = ((System.Drawing.Image)(resources.GetObject("brbtnlogout.Glyph")));
            this.brbtnlogout.Id = 5;
            this.brbtnlogout.Name = "brbtnlogout";
            toolTipTitleItem1.Text = "Log Out User and Go back to login page!";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.brbtnlogout.SuperTip = superToolTip1;
            this.brbtnlogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // brbtnadd
            // 
            this.brbtnadd.Caption = "Add User";
            this.brbtnadd.Glyph = ((System.Drawing.Image)(resources.GetObject("brbtnadd.Glyph")));
            this.brbtnadd.Id = 7;
            this.brbtnadd.Name = "brbtnadd";
            toolTipTitleItem2.Text = "Add User";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.brbtnadd.SuperTip = superToolTip2;
            this.brbtnadd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Center;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(988, 602);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem brbtnlogout;
        private DevExpress.XtraBars.BarButtonItem brbtnadd;
    }
}