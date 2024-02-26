
namespace Hardware_ID
{
    partial class frmMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMember));
            label1 = new System.Windows.Forms.Label();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            memberbindingSource1 = new System.Windows.Forms.BindingSource(components);
            panel1 = new System.Windows.Forms.Panel();
            btnBack = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnPic = new System.Windows.Forms.Button();
            picUser = new System.Windows.Forms.PictureBox();
            txtMobile = new System.Windows.Forms.TextBox();
            lblPhone = new System.Windows.Forms.Label();
            txtNationalCode = new System.Windows.Forms.TextBox();
            lblCode = new System.Windows.Forms.Label();
            txtLastName = new System.Windows.Forms.TextBox();
            lblLastName = new System.Windows.Forms.Label();
            txtFirstName = new System.Windows.Forms.TextBox();
            lblFirstName = new System.Windows.Forms.Label();
            txtPersonnelCode = new System.Windows.Forms.TextBox();
            lblPhoto = new System.Windows.Forms.Label();
            lblPersonnalCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)memberbindingSource1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Turquoise;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("B Mitra", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1023, 104);
            label1.TabIndex = 0;
            label1.Text = "فرم ثبت اطلاعات کارمندان";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // memberbindingSource1
            // 
            memberbindingSource1.DataMember = "Member";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnPic);
            panel1.Controls.Add(picUser);
            panel1.Controls.Add(txtMobile);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(txtNationalCode);
            panel1.Controls.Add(lblCode);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(lblFirstName);
            panel1.Controls.Add(txtPersonnelCode);
            panel1.Controls.Add(lblPhoto);
            panel1.Controls.Add(lblPersonnalCode);
            panel1.Location = new System.Drawing.Point(12, 122);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(999, 356);
            panel1.TabIndex = 8;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.Turquoise;
            btnBack.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            btnBack.ForeColor = System.Drawing.Color.White;
            btnBack.Location = new System.Drawing.Point(339, 293);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(235, 51);
            btnBack.TabIndex = 21;
            btnBack.Text = "بازگشت";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.Turquoise;
            btnSave.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(580, 293);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(235, 51);
            btnSave.TabIndex = 20;
            btnSave.Text = "ثبت";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnPic
            // 
            btnPic.BackColor = System.Drawing.Color.Turquoise;
            btnPic.ForeColor = System.Drawing.Color.White;
            btnPic.Location = new System.Drawing.Point(26, 300);
            btnPic.Name = "btnPic";
            btnPic.Size = new System.Drawing.Size(195, 40);
            btnPic.TabIndex = 22;
            btnPic.Text = "بارگذاری تصویر";
            btnPic.UseVisualStyleBackColor = false;
            // 
            // picUser
            // 
            picUser.Image = (System.Drawing.Image)resources.GetObject("picUser.Image");
            picUser.Location = new System.Drawing.Point(26, 56);
            picUser.Name = "picUser";
            picUser.Size = new System.Drawing.Size(195, 248);
            picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picUser.TabIndex = 18;
            picUser.TabStop = false;
            // 
            // txtMobile
            // 
            txtMobile.Location = new System.Drawing.Point(625, 167);
            txtMobile.MaxLength = 11;
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new System.Drawing.Size(229, 42);
            txtMobile.TabIndex = 19;
            txtMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPhone
            // 
            lblPhone.BackColor = System.Drawing.Color.White;
            lblPhone.Location = new System.Drawing.Point(856, 170);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(121, 36);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "شماره موبایل :";
            lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNationalCode
            // 
            txtNationalCode.Location = new System.Drawing.Point(242, 58);
            txtNationalCode.MaxLength = 10;
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new System.Drawing.Size(256, 42);
            txtNationalCode.TabIndex = 9;
            txtNationalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCode
            // 
            lblCode.BackColor = System.Drawing.Color.White;
            lblCode.Location = new System.Drawing.Point(504, 58);
            lblCode.Name = "lblCode";
            lblCode.Size = new System.Drawing.Size(108, 36);
            lblCode.TabIndex = 11;
            lblCode.Text = "کد ملی :";
            lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(242, 115);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(256, 42);
            txtLastName.TabIndex = 17;
            txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLastName
            // 
            lblLastName.BackColor = System.Drawing.Color.White;
            lblLastName.Location = new System.Drawing.Point(500, 121);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(119, 36);
            lblLastName.TabIndex = 12;
            lblLastName.Text = "نام خانوادگی :";
            lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new System.Drawing.Point(625, 114);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(229, 42);
            txtFirstName.TabIndex = 13;
            txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFirstName
            // 
            lblFirstName.BackColor = System.Drawing.Color.White;
            lblFirstName.Location = new System.Drawing.Point(860, 114);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(117, 36);
            lblFirstName.TabIndex = 14;
            lblFirstName.Text = "نام :";
            lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPersonnelCode
            // 
            txtPersonnelCode.Location = new System.Drawing.Point(625, 58);
            txtPersonnelCode.MaxLength = 4;
            txtPersonnelCode.Name = "txtPersonnelCode";
            txtPersonnelCode.Size = new System.Drawing.Size(229, 42);
            txtPersonnelCode.TabIndex = 8;
            txtPersonnelCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPhoto
            // 
            lblPhoto.BackColor = System.Drawing.Color.White;
            lblPhoto.Location = new System.Drawing.Point(26, 12);
            lblPhoto.Name = "lblPhoto";
            lblPhoto.Size = new System.Drawing.Size(196, 36);
            lblPhoto.TabIndex = 15;
            lblPhoto.Text = "عکس پرسنلی ";
            lblPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPersonnalCode
            // 
            lblPersonnalCode.BackColor = System.Drawing.Color.White;
            lblPersonnalCode.Location = new System.Drawing.Point(860, 61);
            lblPersonnalCode.Name = "lblPersonnalCode";
            lblPersonnalCode.Size = new System.Drawing.Size(117, 36);
            lblPersonnalCode.TabIndex = 16;
            lblPersonnalCode.Text = "کد پرسنلی :";
            lblPersonnalCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMember
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Silver;
            ClientSize = new System.Drawing.Size(1023, 490);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "frmMember";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "فرم ثبت اطلاعات کارمندان";
            Load += frmMember_Load;
            ((System.ComponentModel.ISupportInitialize)memberbindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource memberbindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtPersonnelCode;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.Label lblPersonnalCode;
    }
}