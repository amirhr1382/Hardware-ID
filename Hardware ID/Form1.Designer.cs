
namespace Hardware_ID
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.InformationItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MembersItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PartsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegionItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShenasnamehItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SoftwareItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.GuideItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LabelUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InformationItem
            // 
            this.InformationItem.AccessibleDescription = "";
            this.InformationItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MembersItem,
            this.PartsItem,
            this.RegionItem});
            this.InformationItem.Name = "InformationItem";
            this.InformationItem.Size = new System.Drawing.Size(110, 38);
            this.InformationItem.Text = "اطلاعات پایه";
            // 
            // MembersItem
            // 
            this.MembersItem.BackColor = System.Drawing.SystemColors.Control;
            this.MembersItem.Name = "MembersItem";
            this.MembersItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.MembersItem.Size = new System.Drawing.Size(258, 26);
            this.MembersItem.Text = "لیست اعضا";
            this.MembersItem.Click += new System.EventHandler(this.MembersItem_Click);
            // 
            // PartsItem
            // 
            this.PartsItem.Name = "PartsItem";
            this.PartsItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PartsItem.Size = new System.Drawing.Size(258, 26);
            this.PartsItem.Text = "فهرست قطعات";
            this.PartsItem.Click += new System.EventHandler(this.PartsItem_Click);
            // 
            // RegionItem
            // 
            this.RegionItem.Name = "RegionItem";
            this.RegionItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.RegionItem.Size = new System.Drawing.Size(258, 26);
            this.RegionItem.Text = "فهرست سازمان ها";
            this.RegionItem.Click += new System.EventHandler(this.RegionItem_Click_1);
            // 
            // OperationItem
            // 
            this.OperationItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShenasnamehItem,
            this.SoftwareItem,
            this.ServerItem,
            this.SearchItem});
            this.OperationItem.Name = "OperationItem";
            this.OperationItem.Size = new System.Drawing.Size(77, 38);
            this.OperationItem.Text = "عملیات";
            // 
            // ShenasnamehItem
            // 
            this.ShenasnamehItem.Name = "ShenasnamehItem";
            this.ShenasnamehItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.ShenasnamehItem.Size = new System.Drawing.Size(287, 26);
            this.ShenasnamehItem.Text = "شناسنامه سخت افزاری";
            this.ShenasnamehItem.Click += new System.EventHandler(this.ShenasnamehItem_Click);
            // 
            // SoftwareItem
            // 
            this.SoftwareItem.Name = "SoftwareItem";
            this.SoftwareItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.SoftwareItem.Size = new System.Drawing.Size(287, 26);
            this.SoftwareItem.Text = "شناسنامه نرم افزاری";
            // 
            // ServerItem
            // 
            this.ServerItem.Name = "ServerItem";
            this.ServerItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.ServerItem.Size = new System.Drawing.Size(287, 26);
            this.ServerItem.Text = "شناسنامه اتاق سرور";
            // 
            // SearchItem
            // 
            this.SearchItem.Name = "SearchItem";
            this.SearchItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SearchItem.Size = new System.Drawing.Size(287, 26);
            this.SearchItem.Text = "جستجو";
            this.SearchItem.Click += new System.EventHandler(this.SearchItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(92, 38);
            this.toolStripMenuItem1.Text = "گزارشات";
            // 
            // GuideItem
            // 
            this.GuideItem.Name = "GuideItem";
            this.GuideItem.Size = new System.Drawing.Size(69, 38);
            this.GuideItem.Text = "راهنما";
            // 
            // AboutItem
            // 
            this.AboutItem.Name = "AboutItem";
            this.AboutItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.AboutItem.Size = new System.Drawing.Size(239, 38);
            this.AboutItem.Text = "درباره ما";
            // 
            // ExitItem
            // 
            this.ExitItem.Name = "ExitItem";
            this.ExitItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ExitItem.Size = new System.Drawing.Size(89, 38);
            this.ExitItem.Text = "خروج";
            this.ExitItem.Click += new System.EventHandler(this.ExitItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 695);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1262, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // LabelUsername
            // 
            this.LabelUsername.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(70, 20);
            this.LabelUsername.Text = "نام کاربری";
            this.LabelUsername.Click += new System.EventHandler(this.toolStripStatusLabel1_Click_1);
            // 
            // LabelDate
            // 
            this.LabelDate.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(86, 20);
            this.LabelDate.Text = "ساعت ورود ";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شناسنامه سخت افزاری";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem InformationItem;
        private System.Windows.Forms.ToolStripMenuItem MembersItem;
        private System.Windows.Forms.ToolStripMenuItem PartsItem;
        private System.Windows.Forms.ToolStripMenuItem RegionItem;
        private System.Windows.Forms.ToolStripMenuItem OperationItem;
        private System.Windows.Forms.ToolStripMenuItem ShenasnamehItem;
        private System.Windows.Forms.ToolStripMenuItem GuideItem;
        private System.Windows.Forms.ToolStripMenuItem AboutItem;
        private System.Windows.Forms.ToolStripMenuItem ExitItem;
        private System.Windows.Forms.ToolStripMenuItem SearchItem;
        private System.Windows.Forms.ToolStripMenuItem SoftwareItem;
        private System.Windows.Forms.ToolStripMenuItem ServerItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel LabelUsername;
        public System.Windows.Forms.ToolStripStatusLabel LabelDate;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

