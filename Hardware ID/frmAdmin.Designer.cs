
namespace Hardware_ID
{
    partial class frmAdmin
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
            bindingSource1 = new System.Windows.Forms.BindingSource(components);
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            btnBack = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            txtNationalCode = new System.Windows.Forms.TextBox();
            lblCode = new System.Windows.Forms.Label();
            txtLastName = new System.Windows.Forms.TextBox();
            lblLastName = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            txtUserName = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtFirstName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            lblFirstName = new System.Windows.Forms.Label();
            txtPersonelCode = new System.Windows.Forms.TextBox();
            lblPersonnalCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bindingSource1
            // 
            bindingSource1.DataMember = "Admin";
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Turquoise;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("B Mitra", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(756, 104);
            label1.TabIndex = 1;
            label1.Text = "فرم ثبت مدیران";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtNationalCode);
            panel1.Controls.Add(lblCode);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblFirstName);
            panel1.Controls.Add(txtPersonelCode);
            panel1.Controls.Add(lblPersonnalCode);
            panel1.Location = new System.Drawing.Point(12, 107);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(732, 293);
            panel1.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.Turquoise;
            btnBack.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            btnBack.ForeColor = System.Drawing.Color.White;
            btnBack.Location = new System.Drawing.Point(100, 211);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(235, 51);
            btnBack.TabIndex = 20;
            btnBack.Text = "بازگشت";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.Turquoise;
            btnSave.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(341, 211);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(235, 51);
            btnSave.TabIndex = 16;
            btnSave.Text = "ثبت";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtNationalCode
            // 
            txtNationalCode.Location = new System.Drawing.Point(10, 30);
            txtNationalCode.MaxLength = 10;
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new System.Drawing.Size(240, 42);
            txtNationalCode.TabIndex = 9;
            txtNationalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCode
            // 
            lblCode.BackColor = System.Drawing.Color.White;
            lblCode.Location = new System.Drawing.Point(271, 30);
            lblCode.Name = "lblCode";
            lblCode.Size = new System.Drawing.Size(78, 36);
            lblCode.TabIndex = 12;
            lblCode.Text = "کد ملی :";
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(10, 87);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(240, 42);
            txtLastName.TabIndex = 11;
            txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLastName
            // 
            lblLastName.BackColor = System.Drawing.Color.White;
            lblLastName.Location = new System.Drawing.Point(260, 93);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(123, 36);
            lblLastName.TabIndex = 14;
            lblLastName.Text = "نام خانوادگی :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(10, 143);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(240, 42);
            txtPassword.TabIndex = 15;
            txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserName
            // 
            txtUserName.Location = new System.Drawing.Point(397, 143);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(212, 42);
            txtUserName.TabIndex = 13;
            txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(263, 143);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(93, 36);
            label4.TabIndex = 17;
            label4.Text = "گذرواژه :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new System.Drawing.Point(397, 86);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(212, 42);
            txtFirstName.TabIndex = 10;
            txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(628, 143);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(104, 36);
            label3.TabIndex = 18;
            label3.Text = "نام کاربری :";
            // 
            // lblFirstName
            // 
            lblFirstName.BackColor = System.Drawing.Color.White;
            lblFirstName.Location = new System.Drawing.Point(628, 86);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(74, 36);
            lblFirstName.TabIndex = 19;
            lblFirstName.Text = "نام :";
            // 
            // txtPersonelCode
            // 
            txtPersonelCode.Location = new System.Drawing.Point(397, 30);
            txtPersonelCode.MaxLength = 4;
            txtPersonelCode.Name = "txtPersonelCode";
            txtPersonelCode.Size = new System.Drawing.Size(212, 42);
            txtPersonelCode.TabIndex = 8;
            txtPersonelCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPersonnalCode
            // 
            lblPersonnalCode.BackColor = System.Drawing.Color.White;
            lblPersonnalCode.Location = new System.Drawing.Point(615, 33);
            lblPersonnalCode.Name = "lblPersonnalCode";
            lblPersonnalCode.Size = new System.Drawing.Size(117, 36);
            lblPersonnalCode.TabIndex = 21;
            lblPersonnalCode.Text = "کد پرسنلی :";
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Silver;
            ClientSize = new System.Drawing.Size(756, 412);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "frmAdmin";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += frmAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtPersonelCode;
        private System.Windows.Forms.Label lblPersonnalCode;
    }
}