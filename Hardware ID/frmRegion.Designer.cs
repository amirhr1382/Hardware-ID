
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtCode = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            RegionbindingSource1 = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)RegionbindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(12, 113);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(468, 282);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.White;
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(343, 194);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 34);
            label2.TabIndex = 1;
            label2.Text = "نام سازمان :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(343, 130);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 34);
            label3.TabIndex = 2;
            label3.Text = "کد سازمان :";
            // 
            // txtCode
            // 
            txtCode.Location = new System.Drawing.Point(58, 126);
            txtCode.MaxLength = 3;
            txtCode.Name = "txtCode";
            txtCode.Size = new System.Drawing.Size(280, 42);
            txtCode.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(58, 190);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(280, 42);
            txtName.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.Turquoise;
            btnSave.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            btnSave.Location = new System.Drawing.Point(126, 254);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(242, 58);
            btnSave.TabIndex = 2;
            btnSave.Text = "ثبت";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.Turquoise;
            btnBack.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            btnBack.Location = new System.Drawing.Point(126, 318);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(242, 58);
            btnBack.TabIndex = 3;
            btnBack.Text = "بازگشت";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // RegionbindingSource1
            // 
            RegionbindingSource1.DataMember = "Region";
            // 
            // frmRegion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Silver;
            ClientSize = new System.Drawing.Size(492, 404);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "frmRegion";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Text = "فرم ثبت سازمان";
            Load += frmRegion_Load;
            ((System.ComponentModel.ISupportInitialize)RegionbindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource RegionbindingSource1;
    }
}