
namespace Hardware_ID
{
    partial class frmPart
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
            txtName = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtModel = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtNumber = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnBacke = new System.Windows.Forms.Button();
            partsbindingSource1 = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)partsbindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Turquoise;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("B Mitra", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(708, 68);
            label1.TabIndex = 0;
            label1.Text = "فرم ثبت قطعات";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(12, 81);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(685, 305);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(586, 103);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 34);
            label3.TabIndex = 2;
            label3.Text = "نام قطعه :";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(365, 140);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(294, 42);
            txtName.TabIndex = 0;
            txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(262, 103);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(89, 34);
            label4.TabIndex = 2;
            label4.Text = "مدل قطعه :";
            // 
            // txtModel
            // 
            txtModel.Location = new System.Drawing.Point(45, 140);
            txtModel.Name = "txtModel";
            txtModel.Size = new System.Drawing.Size(300, 42);
            txtModel.TabIndex = 1;
            txtModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(376, 196);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(139, 34);
            label5.TabIndex = 2;
            label5.Text = "شماره اموال قطعه :";
            // 
            // txtNumber
            // 
            txtNumber.Location = new System.Drawing.Point(209, 233);
            txtNumber.MaxLength = 9;
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new System.Drawing.Size(300, 42);
            txtNumber.TabIndex = 2;
            txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.Turquoise;
            btnSave.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(365, 292);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(208, 55);
            btnSave.TabIndex = 3;
            btnSave.Text = "ثبت";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBacke
            // 
            btnBacke.BackColor = System.Drawing.Color.Turquoise;
            btnBacke.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            btnBacke.ForeColor = System.Drawing.Color.White;
            btnBacke.Location = new System.Drawing.Point(137, 292);
            btnBacke.Name = "btnBacke";
            btnBacke.Size = new System.Drawing.Size(208, 55);
            btnBacke.TabIndex = 4;
            btnBacke.Text = "بازگشت";
            btnBacke.UseVisualStyleBackColor = false;
            btnBacke.Click += btnBack_Click;
            // 
            // partsbindingSource1
            // 
            partsbindingSource1.DataMember = "Parts";
            // 
            // frmPart
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Silver;
            ClientSize = new System.Drawing.Size(708, 395);
            Controls.Add(btnBacke);
            Controls.Add(btnSave);
            Controls.Add(txtNumber);
            Controls.Add(label5);
            Controls.Add(txtModel);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "frmPart";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "فرم ثبت قطعات";
            Load += frmPart_Load;
            ((System.ComponentModel.ISupportInitialize)partsbindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBacke;
        private System.Windows.Forms.BindingSource partsbindingSource1;
    }
}