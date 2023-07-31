
namespace Hardware_ID
{
    partial class frmMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMember));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPersonnalCode = new System.Windows.Forms.Label();
            this.txtPersonnalCode = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.btnPic = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBacke = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.memberbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hardware_IDDataSet = new Hardware_ID.Hardware_IDDataSet();
            this.memberTableAdapter = new Hardware_ID.Hardware_IDDataSetTableAdapters.MemberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberbindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardware_IDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("B Mitra", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1023, 104);
            this.label1.TabIndex = 0;
            this.label1.Text = "فرم ثبت اطلاعات کارمندان";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(997, 365);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPersonnalCode
            // 
            this.lblPersonnalCode.BackColor = System.Drawing.Color.White;
            this.lblPersonnalCode.Location = new System.Drawing.Point(887, 173);
            this.lblPersonnalCode.Name = "lblPersonnalCode";
            this.lblPersonnalCode.Size = new System.Drawing.Size(94, 36);
            this.lblPersonnalCode.TabIndex = 2;
            this.lblPersonnalCode.Text = "کد پرسنلی :";
            // 
            // txtPersonnalCode
            // 
            this.txtPersonnalCode.Location = new System.Drawing.Point(645, 170);
            this.txtPersonnalCode.MaxLength = 4;
            this.txtPersonnalCode.Name = "txtPersonnalCode";
            this.txtPersonnalCode.Size = new System.Drawing.Size(236, 42);
            this.txtPersonnalCode.TabIndex = 3;
            this.txtPersonnalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPersonnalCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtPersonnalCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPersonnalCode_KeyDown);
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(887, 226);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(45, 36);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "نام :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(645, 226);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(236, 42);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirstName_KeyDown);
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(527, 233);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(108, 36);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "نام خانوادگی :";
            this.lblLastName.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(269, 227);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(256, 42);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLastName_KeyDown);
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.Color.White;
            this.lblCode.Location = new System.Drawing.Point(531, 170);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(69, 36);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "کد ملی :";
            this.lblCode.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(269, 170);
            this.txtCode.MaxLength = 10;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(256, 42);
            this.txtCode.TabIndex = 3;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(883, 282);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(116, 36);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "شماره موبایل :";
            this.lblPhone.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(645, 279);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(236, 42);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            // 
            // lblPhoto
            // 
            this.lblPhoto.BackColor = System.Drawing.Color.White;
            this.lblPhoto.Location = new System.Drawing.Point(53, 124);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(196, 36);
            this.lblPhoto.TabIndex = 2;
            this.lblPhoto.Text = "عکس پرسنلی ";
            this.lblPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPic
            // 
            this.btnPic.BackColor = System.Drawing.Color.Turquoise;
            this.btnPic.ForeColor = System.Drawing.Color.White;
            this.btnPic.Location = new System.Drawing.Point(53, 412);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(195, 40);
            this.btnPic.TabIndex = 5;
            this.btnPic.Text = "بارگذاری تصویر";
            this.btnPic.UseVisualStyleBackColor = false;
            this.btnPic.Click += new System.EventHandler(this.button1_Click);
            this.btnPic.MouseLeave += new System.EventHandler(this.btnPic_MouseLeave);
            this.btnPic.MouseHover += new System.EventHandler(this.btnPic_MouseHover);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Turquoise;
            this.btnSave.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(607, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(235, 51);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // btnBacke
            // 
            this.btnBacke.BackColor = System.Drawing.Color.Turquoise;
            this.btnBacke.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBacke.ForeColor = System.Drawing.Color.White;
            this.btnBacke.Location = new System.Drawing.Point(366, 405);
            this.btnBacke.Name = "btnBacke";
            this.btnBacke.Size = new System.Drawing.Size(235, 51);
            this.btnBacke.TabIndex = 5;
            this.btnBacke.Text = "بازگشت";
            this.btnBacke.UseVisualStyleBackColor = false;
            this.btnBacke.Click += new System.EventHandler(this.btnBacke_Click);
            this.btnBacke.MouseLeave += new System.EventHandler(this.btnBacke_MouseLeave);
            this.btnBacke.MouseHover += new System.EventHandler(this.btnBacke_MouseHover);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picUser
            // 
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(53, 168);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(195, 248);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 4;
            this.picUser.TabStop = false;
            // 
            // memberbindingSource1
            // 
            this.memberbindingSource1.DataMember = "Member";
            this.memberbindingSource1.DataSource = this.hardware_IDDataSet;
            // 
            // hardware_IDDataSet
            // 
            this.hardware_IDDataSet.DataSetName = "Hardware_IDDataSet";
            this.hardware_IDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // frmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1023, 490);
            this.Controls.Add(this.btnBacke);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPic);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtPersonnalCode);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.lblPersonnalCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmMember";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم ثبت اطلاعات کارمندان";
            this.Load += new System.EventHandler(this.frmMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberbindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardware_IDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPersonnalCode;
        private System.Windows.Forms.TextBox txtPersonnalCode;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBacke;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource memberbindingSource1;
        private Hardware_IDDataSet hardware_IDDataSet;
        private Hardware_IDDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
    }
}