
namespace Hardware_ID
{
    partial class frmHardwareId
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
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            cmbPersonelCode = new System.Windows.Forms.ComboBox();
            cmbRegionName = new System.Windows.Forms.ComboBox();
            txtLastName = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            lblPersonnalCode = new System.Windows.Forms.Label();
            lblLastName = new System.Windows.Forms.Label();
            txtFirstName = new System.Windows.Forms.TextBox();
            lblFirstName = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            cmbPartNumber = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            txtPartModel = new System.Windows.Forms.TextBox();
            txtPartName = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            chkIsTransferred = new System.Windows.Forms.CheckBox();
            txtEndDate = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtStartDate = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(12, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1238, 577);
            label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.White;
            groupBox1.Controls.Add(cmbPersonelCode);
            groupBox1.Controls.Add(cmbRegionName);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblPersonnalCode);
            groupBox1.Controls.Add(lblLastName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(lblFirstName);
            groupBox1.Font = new System.Drawing.Font("B Koodak", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            groupBox1.Location = new System.Drawing.Point(24, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1212, 171);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات هویتی";
            // 
            // cmbPersonelCode
            // 
            cmbPersonelCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cmbPersonelCode.FormattingEnabled = true;
            cmbPersonelCode.Location = new System.Drawing.Point(793, 43);
            cmbPersonelCode.Name = "cmbPersonelCode";
            cmbPersonelCode.Size = new System.Drawing.Size(292, 47);
            cmbPersonelCode.TabIndex = 0;
            cmbPersonelCode.SelectedIndexChanged += cmbPersonelCode_SelectedIndexChanged;
            // 
            // cmbRegionName
            // 
            cmbRegionName.DisplayMember = "Id";
            cmbRegionName.FormattingEnabled = true;
            cmbRegionName.Location = new System.Drawing.Point(794, 107);
            cmbRegionName.Name = "cmbRegionName";
            cmbRegionName.Size = new System.Drawing.Size(292, 47);
            cmbRegionName.TabIndex = 1;
            cmbRegionName.ValueMember = "Id";
            // 
            // txtLastName
            // 
            txtLastName.Enabled = false;
            txtLastName.Location = new System.Drawing.Point(25, 46);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new System.Drawing.Size(292, 47);
            txtLastName.TabIndex = 7;
            txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.BackColor = System.Drawing.Color.White;
            label7.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            label7.Location = new System.Drawing.Point(1092, 118);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(94, 36);
            label7.TabIndex = 6;
            label7.Text = "نام سازمان :";
            // 
            // lblPersonnalCode
            // 
            lblPersonnalCode.BackColor = System.Drawing.Color.White;
            lblPersonnalCode.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            lblPersonnalCode.Location = new System.Drawing.Point(1092, 52);
            lblPersonnalCode.Name = "lblPersonnalCode";
            lblPersonnalCode.Size = new System.Drawing.Size(94, 36);
            lblPersonnalCode.TabIndex = 6;
            lblPersonnalCode.Text = "کد پرسنلی :";
            // 
            // lblLastName
            // 
            lblLastName.BackColor = System.Drawing.Color.White;
            lblLastName.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            lblLastName.Location = new System.Drawing.Point(323, 52);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(112, 36);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "نام خانوادگی :";
            // 
            // txtFirstName
            // 
            txtFirstName.Enabled = false;
            txtFirstName.Location = new System.Drawing.Point(441, 46);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new System.Drawing.Size(292, 47);
            txtFirstName.TabIndex = 8;
            txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFirstName
            // 
            lblFirstName.BackColor = System.Drawing.Color.White;
            lblFirstName.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            lblFirstName.Location = new System.Drawing.Point(739, 52);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(44, 36);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "نام :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.White;
            groupBox2.Controls.Add(cmbPartNumber);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtPartModel);
            groupBox2.Controls.Add(txtPartName);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new System.Drawing.Font("B Koodak", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            groupBox2.Location = new System.Drawing.Point(24, 210);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(1212, 136);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "اطلاعات سخت افزار";
            // 
            // cmbPartNumber
            // 
            cmbPartNumber.DisplayMember = "Id";
            cmbPartNumber.FormattingEnabled = true;
            cmbPartNumber.Location = new System.Drawing.Point(779, 49);
            cmbPartNumber.Name = "cmbPartNumber";
            cmbPartNumber.Size = new System.Drawing.Size(278, 47);
            cmbPartNumber.TabIndex = 0;
            cmbPartNumber.ValueMember = "Id";
            cmbPartNumber.SelectedIndexChanged += cmbPartNumber_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            label3.Location = new System.Drawing.Point(683, 57);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 34);
            label3.TabIndex = 6;
            label3.Text = "نام قطعه :";
            // 
            // txtPartModel
            // 
            txtPartModel.Enabled = false;
            txtPartModel.Location = new System.Drawing.Point(22, 51);
            txtPartModel.Name = "txtPartModel";
            txtPartModel.Size = new System.Drawing.Size(277, 47);
            txtPartModel.TabIndex = 2;
            txtPartModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPartName
            // 
            txtPartName.Enabled = false;
            txtPartName.Location = new System.Drawing.Point(400, 51);
            txtPartName.Name = "txtPartName";
            txtPartName.Size = new System.Drawing.Size(277, 47);
            txtPartName.TabIndex = 1;
            txtPartName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            label5.Location = new System.Drawing.Point(1063, 55);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(139, 34);
            label5.TabIndex = 4;
            label5.Text = "شماره اموال قطعه :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.White;
            label4.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            label4.Location = new System.Drawing.Point(305, 57);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(89, 34);
            label4.TabIndex = 5;
            label4.Text = "مدل قطعه :";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = System.Drawing.Color.White;
            groupBox3.Controls.Add(chkIsTransferred);
            groupBox3.Controls.Add(txtEndDate);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtStartDate);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new System.Drawing.Font("B Koodak", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            groupBox3.Location = new System.Drawing.Point(24, 359);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(1212, 132);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "تاریخ تحویل";
            // 
            // chkIsTransferred
            // 
            chkIsTransferred.AutoSize = true;
            chkIsTransferred.Location = new System.Drawing.Point(151, 45);
            chkIsTransferred.Name = "chkIsTransferred";
            chkIsTransferred.Size = new System.Drawing.Size(166, 43);
            chkIsTransferred.TabIndex = 2;
            chkIsTransferred.Text = "تحویل داده شده";
            chkIsTransferred.UseVisualStyleBackColor = true;
            // 
            // txtEndDate
            // 
            txtEndDate.Location = new System.Drawing.Point(386, 43);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new System.Drawing.Size(292, 47);
            txtEndDate.TabIndex = 1;
            txtEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.White;
            label6.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            label6.Location = new System.Drawing.Point(684, 46);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(102, 34);
            label6.TabIndex = 6;
            label6.Text = "پایان تحویل :";
            // 
            // txtStartDate
            // 
            txtStartDate.Location = new System.Drawing.Point(792, 43);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new System.Drawing.Size(292, 47);
            txtStartDate.TabIndex = 0;
            txtStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.White;
            label2.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            label2.Location = new System.Drawing.Point(1093, 46);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 34);
            label2.TabIndex = 6;
            label2.Text = "شروع تحویل :";
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.Turquoise;
            btnBack.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            btnBack.ForeColor = System.Drawing.Color.White;
            btnBack.Location = new System.Drawing.Point(441, 519);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(229, 55);
            btnBack.TabIndex = 1;
            btnBack.Text = "بازگشت";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.Turquoise;
            btnSave.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(678, 519);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(229, 55);
            btnSave.TabIndex = 0;
            btnSave.Text = "ثبت";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmHardwareId
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Silver;
            ClientSize = new System.Drawing.Size(1262, 607);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "frmHardwareId";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "فرم ثبت شناسنامه سخت افزاری";
            Load += frmHardwareId_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblPersonnalCode;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPartModel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkIsTransferred;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbRegionName;
        private System.Windows.Forms.ComboBox cmbPersonelCode;
        private System.Windows.Forms.ComboBox cmbPartNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}