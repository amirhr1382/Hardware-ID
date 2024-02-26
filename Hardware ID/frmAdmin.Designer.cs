
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
            label2 = new System.Windows.Forms.Label();
            txtNationalCode = new System.Windows.Forms.TextBox();
            lblCode = new System.Windows.Forms.Label();
            txtLastName = new System.Windows.Forms.TextBox();
            lblLastName = new System.Windows.Forms.Label();
            txtFirstName = new System.Windows.Forms.TextBox();
            lblFirstName = new System.Windows.Forms.Label();
            txtPersonelCode = new System.Windows.Forms.TextBox();
            lblPersonnalCode = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtUserName = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            btnBack = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
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
            // label2
            // 
            label2.BackColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(12, 120);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(732, 283);
            label2.TabIndex = 2;
            // 
            // txtNationalCode
            // 
            txtNationalCode.Location = new System.Drawing.Point(28, 135);
            txtNationalCode.MaxLength = 10;
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new System.Drawing.Size(256, 42);
            txtNationalCode.TabIndex = 8;
            txtNationalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCode
            // 
            lblCode.BackColor = System.Drawing.Color.White;
            lblCode.Location = new System.Drawing.Point(290, 135);
            lblCode.Name = "lblCode";
            lblCode.Size = new System.Drawing.Size(69, 36);
            lblCode.TabIndex = 4;
            lblCode.Text = "کد ملی :";
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(28, 192);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(256, 42);
            txtLastName.TabIndex = 9;
            txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLastName
            // 
            lblLastName.BackColor = System.Drawing.Color.White;
            lblLastName.Location = new System.Drawing.Point(286, 198);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(108, 36);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "نام خانوادگی :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new System.Drawing.Point(404, 191);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(236, 42);
            txtFirstName.TabIndex = 10;
            txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFirstName
            // 
            lblFirstName.BackColor = System.Drawing.Color.White;
            lblFirstName.Location = new System.Drawing.Point(646, 191);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(45, 36);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "نام :";
            // 
            // txtPersonelCode
            // 
            txtPersonelCode.Location = new System.Drawing.Point(404, 135);
            txtPersonelCode.MaxLength = 4;
            txtPersonelCode.Name = "txtPersonelCode";
            txtPersonelCode.Size = new System.Drawing.Size(236, 42);
            txtPersonelCode.TabIndex = 11;
            txtPersonelCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPersonnalCode
            // 
            lblPersonnalCode.BackColor = System.Drawing.Color.White;
            lblPersonnalCode.Location = new System.Drawing.Point(646, 138);
            lblPersonnalCode.Name = "lblPersonnalCode";
            lblPersonnalCode.Size = new System.Drawing.Size(94, 36);
            lblPersonnalCode.TabIndex = 7;
            lblPersonnalCode.Text = "کد پرسنلی :";
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(646, 248);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 36);
            label3.TabIndex = 6;
            label3.Text = "نام کاربری :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new System.Drawing.Point(404, 248);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(236, 42);
            txtUserName.TabIndex = 10;
            txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(290, 248);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(79, 36);
            label4.TabIndex = 6;
            label4.Text = "گذرواژه :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(28, 248);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(256, 42);
            txtPassword.TabIndex = 10;
            txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.Turquoise;
            btnBack.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            btnBack.ForeColor = System.Drawing.Color.White;
            btnBack.Location = new System.Drawing.Point(118, 316);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(235, 51);
            btnBack.TabIndex = 12;
            btnBack.Text = "بازگشت";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.Turquoise;
            btnSave.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(359, 316);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(235, 51);
            btnSave.TabIndex = 13;
            btnSave.Text = "ثبت";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Silver;
            ClientSize = new System.Drawing.Size(756, 412);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(txtNationalCode);
            Controls.Add(lblCode);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label4);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(lblFirstName);
            Controls.Add(txtPersonelCode);
            Controls.Add(lblPersonnalCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "frmAdmin";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += frmAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtPersonelCode;
        private System.Windows.Forms.Label lblPersonnalCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
    }
}