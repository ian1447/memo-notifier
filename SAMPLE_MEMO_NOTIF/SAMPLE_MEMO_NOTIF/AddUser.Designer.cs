namespace SAMPLE_MEMO_NOTIF
{
    partial class AddUser
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
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::SAMPLE_MEMO_NOTIF.WaitForm1), true, true);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtnewuser = new DevExpress.XtraEditors.TextEdit();
            this.txtnewpasswd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtretypepasswd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnadduser = new DevExpress.XtraEditors.SimpleButton();
            this.btncanceladduser = new DevExpress.XtraEditors.SimpleButton();
            this.bgadduser = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.txtnewuser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnewpasswd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtretypepasswd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(71, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(142, 36);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Add Users";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Enter Username: ";
            // 
            // txtnewuser
            // 
            this.txtnewuser.Location = new System.Drawing.Point(112, 65);
            this.txtnewuser.Name = "txtnewuser";
            this.txtnewuser.Size = new System.Drawing.Size(160, 20);
            this.txtnewuser.TabIndex = 2;
            // 
            // txtnewpasswd
            // 
            this.txtnewpasswd.Location = new System.Drawing.Point(112, 106);
            this.txtnewpasswd.Name = "txtnewpasswd";
            this.txtnewpasswd.Properties.PasswordChar = '*';
            this.txtnewpasswd.Size = new System.Drawing.Size(160, 20);
            this.txtnewpasswd.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Enter Password:";
            // 
            // txtretypepasswd
            // 
            this.txtretypepasswd.Location = new System.Drawing.Point(112, 144);
            this.txtretypepasswd.Name = "txtretypepasswd";
            this.txtretypepasswd.Properties.PasswordChar = '*';
            this.txtretypepasswd.Size = new System.Drawing.Size(160, 20);
            this.txtretypepasswd.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 147);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Retype Password:";
            // 
            // btnadduser
            // 
            this.btnadduser.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadduser.Appearance.Options.UseFont = true;
            this.btnadduser.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnadduser.Location = new System.Drawing.Point(13, 189);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(117, 39);
            this.btnadduser.TabIndex = 7;
            this.btnadduser.Text = "Add User";
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // btncanceladduser
            // 
            this.btncanceladduser.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncanceladduser.Appearance.Options.UseFont = true;
            this.btncanceladduser.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btncanceladduser.Location = new System.Drawing.Point(155, 189);
            this.btncanceladduser.Name = "btncanceladduser";
            this.btncanceladduser.Size = new System.Drawing.Size(117, 39);
            this.btncanceladduser.TabIndex = 8;
            this.btncanceladduser.Text = "Cancel";
            this.btncanceladduser.Click += new System.EventHandler(this.btncanceladduser_Click);
            // 
            // bgadduser
            // 
            this.bgadduser.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgadduser_DoWork);
            this.bgadduser.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgadduser_RunWorkerCompleted);
            // 
            // AddUser
            // 
            this.AcceptButton = this.btnadduser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btncanceladduser);
            this.Controls.Add(this.btnadduser);
            this.Controls.Add(this.txtretypepasswd);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtnewpasswd);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtnewuser);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            ((System.ComponentModel.ISupportInitialize)(this.txtnewuser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnewpasswd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtretypepasswd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtnewuser;
        private DevExpress.XtraEditors.TextEdit txtnewpasswd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtretypepasswd;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnadduser;
        private DevExpress.XtraEditors.SimpleButton btncanceladduser;
        private System.ComponentModel.BackgroundWorker bgadduser;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}