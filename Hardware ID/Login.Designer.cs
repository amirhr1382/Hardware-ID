
namespace Hardware_ID
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblUserName = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            txtUserName = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            chkPassword = new System.Windows.Forms.CheckBox();
            btnLogin = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(124, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(215, 194);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            lblUserName.Location = new System.Drawing.Point(364, 231);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new System.Drawing.Size(133, 49);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "نام کاربری :";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            lblPassword.Location = new System.Drawing.Point(364, 309);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(110, 49);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "گذرواژه :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new System.Drawing.Point(47, 228);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(321, 42);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(47, 306);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(321, 42);
            txtPassword.TabIndex = 4;
            // 
            // chkPassword
            // 
            chkPassword.AutoSize = true;
            chkPassword.Font = new System.Drawing.Font("B Koodak", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            chkPassword.Location = new System.Drawing.Point(216, 362);
            chkPassword.Name = "chkPassword";
            chkPassword.Size = new System.Drawing.Size(158, 43);
            chkPassword.TabIndex = 5;
            chkPassword.Text = "نمایش گذرواژه";
            chkPassword.UseVisualStyleBackColor = true;
            chkPassword.CheckedChanged += chkPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.MidnightBlue;
            btnLogin.Font = new System.Drawing.Font("B Koodak", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Location = new System.Drawing.Point(241, 427);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(161, 63);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "ورود";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.MidnightBlue;
            btnExit.Font = new System.Drawing.Font("B Koodak", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            btnExit.ForeColor = System.Drawing.Color.White;
            btnExit.Location = new System.Drawing.Point(74, 427);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(161, 63);
            btnExit.TabIndex = 7;
            btnExit.Text = "خروج";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.RoyalBlue;
            ClientSize = new System.Drawing.Size(486, 513);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(chkPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(pictureBox1);
            Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "Login";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        //private Hardware_IDDataSet hardware_IDDataSet;
        //private Hardware_IDDataSetTableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}