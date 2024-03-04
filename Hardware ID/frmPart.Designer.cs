
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
            partsbindingSource1 = new System.Windows.Forms.BindingSource(components);
            panel1 = new System.Windows.Forms.Panel();
            btnBack = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            txtNumber = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtModel = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)partsbindingSource1).BeginInit();
            panel1.SuspendLayout();
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
            // partsbindingSource1
            // 
            partsbindingSource1.DataMember = "Parts";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtNumber);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtModel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label3);
            panel1.Location = new System.Drawing.Point(12, 80);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(684, 303);
            panel1.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.Turquoise;
            btnBack.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            btnBack.ForeColor = System.Drawing.Color.White;
            btnBack.Location = new System.Drawing.Point(124, 218);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(208, 55);
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
            btnSave.Location = new System.Drawing.Point(352, 218);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(208, 55);
            btnSave.TabIndex = 11;
            btnSave.Text = "ثبت";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtNumber
            // 
            txtNumber.Location = new System.Drawing.Point(196, 159);
            txtNumber.MaxLength = 9;
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new System.Drawing.Size(300, 42);
            txtNumber.TabIndex = 7;
            txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(363, 122);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(139, 34);
            label5.TabIndex = 8;
            label5.Text = "شماره اموال قطعه :";
            // 
            // txtModel
            // 
            txtModel.Location = new System.Drawing.Point(32, 66);
            txtModel.Name = "txtModel";
            txtModel.Size = new System.Drawing.Size(300, 42);
            txtModel.TabIndex = 6;
            txtModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(249, 29);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(89, 34);
            label4.TabIndex = 9;
            label4.Text = "مدل قطعه :";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(352, 66);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(294, 42);
            txtName.TabIndex = 5;
            txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(573, 29);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 34);
            label3.TabIndex = 10;
            label3.Text = "نام قطعه :";
            // 
            // frmPart
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Silver;
            ClientSize = new System.Drawing.Size(708, 395);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource partsbindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
    }
}