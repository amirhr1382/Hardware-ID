namespace Hardware_ID
{
    partial class frmSearch
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
            panel1 = new System.Windows.Forms.Panel();
            btnSearch = new System.Windows.Forms.Button();
            txtRegion = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtPartNumber = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtPartName = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtMemberPersonelCode = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtMemberName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
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
            label1.Size = new System.Drawing.Size(1010, 104);
            label1.TabIndex = 2;
            label1.Text = "فرم جستجو";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtRegion);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtPartNumber);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPartName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtMemberPersonelCode);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtMemberName);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(12, 124);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(987, 357);
            panel1.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.Color.Turquoise;
            btnSearch.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.Location = new System.Drawing.Point(387, 257);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(235, 51);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "جستجو";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtRegion
            // 
            txtRegion.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            txtRegion.Location = new System.Drawing.Point(536, 168);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new System.Drawing.Size(307, 42);
            txtRegion.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            label6.Location = new System.Drawing.Point(880, 171);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(67, 34);
            label6.TabIndex = 8;
            label6.Text = "سازمان:";
            // 
            // txtPartNumber
            // 
            txtPartNumber.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            txtPartNumber.Location = new System.Drawing.Point(43, 95);
            txtPartNumber.Name = "txtPartNumber";
            txtPartNumber.Size = new System.Drawing.Size(307, 42);
            txtPartNumber.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            label5.Location = new System.Drawing.Point(375, 98);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(135, 34);
            label5.TabIndex = 6;
            label5.Text = "شماره اموال قطعه:";
            // 
            // txtPartName
            // 
            txtPartName.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            txtPartName.Location = new System.Drawing.Point(536, 95);
            txtPartName.Name = "txtPartName";
            txtPartName.Size = new System.Drawing.Size(307, 42);
            txtPartName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            label4.Location = new System.Drawing.Point(880, 98);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(75, 34);
            label4.TabIndex = 4;
            label4.Text = "نام قطعه:";
            // 
            // txtMemberPersonelCode
            // 
            txtMemberPersonelCode.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            txtMemberPersonelCode.Location = new System.Drawing.Point(43, 25);
            txtMemberPersonelCode.Name = "txtMemberPersonelCode";
            txtMemberPersonelCode.Size = new System.Drawing.Size(307, 42);
            txtMemberPersonelCode.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            label3.Location = new System.Drawing.Point(387, 28);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 34);
            label3.TabIndex = 2;
            label3.Text = "کد پرسنلی:";
            // 
            // txtMemberName
            // 
            txtMemberName.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            txtMemberName.Location = new System.Drawing.Point(536, 25);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new System.Drawing.Size(307, 42);
            txtMemberName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            label2.Location = new System.Drawing.Point(880, 28);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 34);
            label2.TabIndex = 0;
            label2.Text = "نام شخص:";
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Silver;
            ClientSize = new System.Drawing.Size(1010, 493);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "frmSearch";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "جستجو";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.TextBox txtMemberName;
        public System.Windows.Forms.TextBox txtMemberPersonelCode;
        public System.Windows.Forms.TextBox txtPartNumber;
        public System.Windows.Forms.TextBox txtPartName;
        public System.Windows.Forms.TextBox txtRegion;
    }
}