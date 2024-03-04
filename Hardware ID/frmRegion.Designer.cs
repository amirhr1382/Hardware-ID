
namespace Hardware_ID
{
    partial class frmRegion
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
            label4 = new System.Windows.Forms.Label();
            RegionbindingSource1 = new System.Windows.Forms.BindingSource(components);
            panel1 = new System.Windows.Forms.Panel();
            btnBack = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            txtName = new System.Windows.Forms.TextBox();
            txtCode = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)RegionbindingSource1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Turquoise;
            label4.Dock = System.Windows.Forms.DockStyle.Top;
            label4.Font = new System.Drawing.Font("B Mitra", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(0, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(492, 99);
            label4.TabIndex = 2;
            label4.Text = "فرم ثبت سازمان ها";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegionbindingSource1
            // 
            RegionbindingSource1.DataMember = "Region";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtCode);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(12, 107);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(468, 285);
            panel1.TabIndex = 4;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.Turquoise;
            btnBack.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            btnBack.Location = new System.Drawing.Point(113, 209);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(242, 58);
            btnBack.TabIndex = 9;
            btnBack.Text = "بازگشت";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.Turquoise;
            btnSave.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            btnSave.Location = new System.Drawing.Point(113, 145);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(242, 58);
            btnSave.TabIndex = 7;
            btnSave.Text = "ثبت";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(45, 81);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(280, 42);
            txtName.TabIndex = 5;
            // 
            // txtCode
            // 
            txtCode.Location = new System.Drawing.Point(45, 17);
            txtCode.MaxLength = 3;
            txtCode.Name = "txtCode";
            txtCode.Size = new System.Drawing.Size(280, 42);
            txtCode.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(330, 21);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 34);
            label3.TabIndex = 8;
            label3.Text = "کد سازمان :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.White;
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(330, 85);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 34);
            label2.TabIndex = 6;
            label2.Text = "نام سازمان :";
            // 
            // frmRegion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Silver;
            ClientSize = new System.Drawing.Size(492, 404);
            Controls.Add(panel1);
            Controls.Add(label4);
            Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "frmRegion";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "فرم ثبت سازمان";
            Load += frmRegion_Load;
            ((System.ComponentModel.ISupportInitialize)RegionbindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource RegionbindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}