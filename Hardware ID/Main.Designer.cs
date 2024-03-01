
namespace Hardware_ID
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            اطلاعاتپایهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            AdminItem = new System.Windows.Forms.ToolStripMenuItem();
            MemberItem = new System.Windows.Forms.ToolStripMenuItem();
            PartItem = new System.Windows.Forms.ToolStripMenuItem();
            RegionItem = new System.Windows.Forms.ToolStripMenuItem();
            عملیاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            HardwareIdItem = new System.Windows.Forms.ToolStripMenuItem();
            NarmafzarItem = new System.Windows.Forms.ToolStripMenuItem();
            ServerItem = new System.Windows.Forms.ToolStripMenuItem();
            SearchItem = new System.Windows.Forms.ToolStripMenuItem();
            گزارشاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            راهنماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            AboutItem = new System.Windows.Forms.ToolStripMenuItem();
            ExitItem = new System.Windows.Forms.ToolStripMenuItem();
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            lblUsername = new System.Windows.Forms.ToolStripStatusLabel();
            lblLoginDate = new System.Windows.Forms.ToolStripStatusLabel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { اطلاعاتپایهToolStripMenuItem, عملیاتToolStripMenuItem, گزارشاتToolStripMenuItem, راهنماToolStripMenuItem, ExitItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1262, 42);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip2";
            // 
            // اطلاعاتپایهToolStripMenuItem
            // 
            اطلاعاتپایهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { AdminItem, MemberItem, PartItem, RegionItem });
            اطلاعاتپایهToolStripMenuItem.Name = "اطلاعاتپایهToolStripMenuItem";
            اطلاعاتپایهToolStripMenuItem.Size = new System.Drawing.Size(110, 38);
            اطلاعاتپایهToolStripMenuItem.Text = "اطلاعات پایه";
            // 
            // AdminItem
            // 
            AdminItem.Image = Properties.Resources.software_engineer;
            AdminItem.Name = "AdminItem";
            AdminItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A;
            AdminItem.Size = new System.Drawing.Size(291, 38);
            AdminItem.Text = "مدیران";
            AdminItem.Click += AdminItem_Click;
            // 
            // MemberItem
            // 
            MemberItem.Image = Properties.Resources.personal;
            MemberItem.Name = "MemberItem";
            MemberItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M;
            MemberItem.Size = new System.Drawing.Size(291, 38);
            MemberItem.Text = "لیست کارمندان";
            MemberItem.Click += MemberItem_Click;
            // 
            // PartItem
            // 
            PartItem.Image = Properties.Resources.IMG_20240302_024909_274;
            PartItem.Name = "PartItem";
            PartItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P;
            PartItem.Size = new System.Drawing.Size(291, 38);
            PartItem.Text = "لیست قطعات";
            PartItem.Click += PartItem_Click;
            // 
            // RegionItem
            // 
            RegionItem.Image = Properties.Resources.buildings;
            RegionItem.Name = "RegionItem";
            RegionItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R;
            RegionItem.Size = new System.Drawing.Size(291, 38);
            RegionItem.Text = "لیست سازمان ها";
            RegionItem.Click += RegionItem_Click;
            // 
            // عملیاتToolStripMenuItem
            // 
            عملیاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { HardwareIdItem, NarmafzarItem, ServerItem, SearchItem });
            عملیاتToolStripMenuItem.Name = "عملیاتToolStripMenuItem";
            عملیاتToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            عملیاتToolStripMenuItem.Text = "عملیات";
            // 
            // HardwareIdItem
            // 
            HardwareIdItem.Image = Properties.Resources.mainboard;
            HardwareIdItem.Name = "HardwareIdItem";
            HardwareIdItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H;
            HardwareIdItem.Size = new System.Drawing.Size(334, 38);
            HardwareIdItem.Text = "شناسنامه سخت افزاری";
            HardwareIdItem.Click += HardwareIdItem_Click;
            // 
            // NarmafzarItem
            // 
            NarmafzarItem.Image = Properties.Resources._3d_modeling;
            NarmafzarItem.Name = "NarmafzarItem";
            NarmafzarItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            NarmafzarItem.Size = new System.Drawing.Size(334, 38);
            NarmafzarItem.Text = "شناسنامه نرم افزاری";
            // 
            // ServerItem
            // 
            ServerItem.Image = Properties.Resources.office_building;
            ServerItem.Name = "ServerItem";
            ServerItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V;
            ServerItem.Size = new System.Drawing.Size(334, 38);
            ServerItem.Text = "شناسنامه اتاق سرور";
            // 
            // SearchItem
            // 
            SearchItem.Image = Properties.Resources.search;
            SearchItem.Name = "SearchItem";
            SearchItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            SearchItem.Size = new System.Drawing.Size(334, 38);
            SearchItem.Text = "جستجو";
            SearchItem.Click += SearchItem_Click;
            // 
            // گزارشاتToolStripMenuItem
            // 
            گزارشاتToolStripMenuItem.Image = Properties.Resources.monitoring;
            گزارشاتToolStripMenuItem.Name = "گزارشاتToolStripMenuItem";
            گزارشاتToolStripMenuItem.Size = new System.Drawing.Size(112, 38);
            گزارشاتToolStripMenuItem.Text = "گزارشات";
            // 
            // راهنماToolStripMenuItem
            // 
            راهنماToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { AboutItem });
            راهنماToolStripMenuItem.Image = Properties.Resources.guide;
            راهنماToolStripMenuItem.Name = "راهنماToolStripMenuItem";
            راهنماToolStripMenuItem.Size = new System.Drawing.Size(89, 38);
            راهنماToolStripMenuItem.Text = "راهنما";
            // 
            // AboutItem
            // 
            AboutItem.Image = Properties.Resources.about;
            AboutItem.Name = "AboutItem";
            AboutItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B;
            AboutItem.Size = new System.Drawing.Size(237, 38);
            AboutItem.Text = "درباره ما";
            // 
            // ExitItem
            // 
            ExitItem.Image = Properties.Resources.exit;
            ExitItem.Name = "ExitItem";
            ExitItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E;
            ExitItem.Size = new System.Drawing.Size(89, 38);
            ExitItem.Text = "خروج";
            ExitItem.Click += ExitItem_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblUsername, lblLoginDate });
            statusStrip1.Location = new System.Drawing.Point(0, 647);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(1262, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUsername
            // 
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(77, 20);
            lblUsername.Text = "نام کاربری :";
            // 
            // lblLoginDate
            // 
            lblLoginDate.Name = "lblLoginDate";
            lblLoginDate.Size = new System.Drawing.Size(77, 20);
            lblLoginDate.Text = "زمان ورود :";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.main;
            pictureBox1.Location = new System.Drawing.Point(0, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1262, 605);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Image = Properties.Resources.شهرداری_شهرضا;
            pictureBox2.Location = new System.Drawing.Point(12, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(106, 92);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1262, 673);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "Main";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Text = "صفحه اصلی";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem اطلاعاتپایهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdminItem;
        private System.Windows.Forms.ToolStripMenuItem MemberItem;
        private System.Windows.Forms.ToolStripMenuItem PartItem;
        private System.Windows.Forms.ToolStripMenuItem عملیاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HardwareIdItem;
        private System.Windows.Forms.ToolStripMenuItem NarmafzarItem;
        private System.Windows.Forms.ToolStripMenuItem ServerItem;
        private System.Windows.Forms.ToolStripMenuItem SearchItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem راهنماToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutItem;
        private System.Windows.Forms.ToolStripMenuItem ExitItem;
        private System.Windows.Forms.ToolStripMenuItem RegionItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsername;
        private System.Windows.Forms.ToolStripStatusLabel lbldeta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripStatusLabel lblLoginDate;
    }
}