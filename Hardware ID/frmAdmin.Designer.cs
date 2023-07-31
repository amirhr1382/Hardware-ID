
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hardware_IDDataSet = new Hardware_ID.Hardware_IDDataSet();
            this.adminTableAdapter = new Hardware_ID.Hardware_IDDataSetTableAdapters.AdminTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtPersonnalCode = new System.Windows.Forms.TextBox();
            this.lblPersonnalCode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnBacke = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardware_IDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Admin";
            this.bindingSource1.DataSource = this.hardware_IDDataSet;
            // 
            // hardware_IDDataSet
            // 
            this.hardware_IDDataSet.DataSetName = "Hardware_IDDataSet";
            this.hardware_IDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("B Mitra", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 104);
            this.label1.TabIndex = 1;
            this.label1.Text = "فرم ثبت مدیران";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(732, 283);
            this.label2.TabIndex = 2;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(28, 135);
            this.txtCode.MaxLength = 10;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(256, 42);
            this.txtCode.TabIndex = 8;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.Color.White;
            this.lblCode.Location = new System.Drawing.Point(290, 135);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(69, 36);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "کد ملی :";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(28, 192);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(256, 42);
            this.txtLastName.TabIndex = 9;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLastName_KeyDown);
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(286, 198);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(108, 36);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "نام خانوادگی :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(404, 191);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(236, 42);
            this.txtFirstName.TabIndex = 10;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirstName_KeyDown);
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(646, 191);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(45, 36);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "نام :";
            // 
            // txtPersonnalCode
            // 
            this.txtPersonnalCode.Location = new System.Drawing.Point(404, 135);
            this.txtPersonnalCode.MaxLength = 4;
            this.txtPersonnalCode.Name = "txtPersonnalCode";
            this.txtPersonnalCode.Size = new System.Drawing.Size(236, 42);
            this.txtPersonnalCode.TabIndex = 11;
            this.txtPersonnalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPersonnalCode.TextChanged += new System.EventHandler(this.txtPersonnalCode_TextChanged);
            this.txtPersonnalCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPersonnalCode_KeyDown);
            // 
            // lblPersonnalCode
            // 
            this.lblPersonnalCode.BackColor = System.Drawing.Color.White;
            this.lblPersonnalCode.Location = new System.Drawing.Point(646, 138);
            this.lblPersonnalCode.Name = "lblPersonnalCode";
            this.lblPersonnalCode.Size = new System.Drawing.Size(94, 36);
            this.lblPersonnalCode.TabIndex = 7;
            this.lblPersonnalCode.Text = "کد پرسنلی :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(646, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "نام کاربری :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(404, 248);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(236, 42);
            this.txtUserName.TabIndex = 10;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(290, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "گذرواژه :";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(28, 248);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(256, 42);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // btnBacke
            // 
            this.btnBacke.BackColor = System.Drawing.Color.Turquoise;
            this.btnBacke.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBacke.ForeColor = System.Drawing.Color.White;
            this.btnBacke.Location = new System.Drawing.Point(118, 316);
            this.btnBacke.Name = "btnBacke";
            this.btnBacke.Size = new System.Drawing.Size(235, 51);
            this.btnBacke.TabIndex = 12;
            this.btnBacke.Text = "بازگشت";
            this.btnBacke.UseVisualStyleBackColor = false;
            this.btnBacke.Click += new System.EventHandler(this.btnBacke_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Turquoise;
            this.btnSave.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(359, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(235, 51);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(756, 412);
            this.Controls.Add(this.btnBacke);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtPersonnalCode);
            this.Controls.Add(this.lblPersonnalCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmAdmin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardware_IDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private Hardware_IDDataSet hardware_IDDataSet;
        private Hardware_IDDataSetTableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtPersonnalCode;
        private System.Windows.Forms.Label lblPersonnalCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnBacke;
        private System.Windows.Forms.Button btnSave;
    }
}