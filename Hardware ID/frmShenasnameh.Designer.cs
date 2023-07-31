
namespace Hardware_ID
{
    partial class frmShenasnameh
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hardware_IDDataSet = new Hardware_ID.Hardware_IDDataSet();
            this.comboBoxNregion = new System.Windows.Forms.ComboBox();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPersonnalCode = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelParts = new System.Windows.Forms.TextBox();
            this.txtNameParts = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtEdata = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSdata = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBacke = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.regionTableAdapter = new Hardware_ID.Hardware_IDDataSetTableAdapters.RegionTableAdapter();
            this.memberTableAdapter = new Hardware_ID.Hardware_IDDataSetTableAdapters.MemberTableAdapter();
            this.partsTableAdapter = new Hardware_ID.Hardware_IDDataSetTableAdapters.PartsTableAdapter();
            this.HardwarebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hardware_IDTableAdapter = new Hardware_ID.Hardware_IDDataSetTableAdapters.Hardware_IDTableAdapter();
            this.bindingSourceShenasname = new System.Windows.Forms.BindingSource(this.components);
            this.shenasnameTableAdapter = new Hardware_ID.Hardware_IDDataSetTableAdapters.ShenasnameTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardware_IDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HardwarebindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceShenasname)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1238, 589);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.comboBoxNregion);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblPersonnalCode);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Font = new System.Drawing.Font("B Koodak", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(24, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1212, 171);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات هویتی";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.memberBindingSource;
            this.comboBox1.DisplayMember = "PCmemeber";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(793, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 47);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "PCmemeber";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.hardware_IDDataSet;
            // 
            // hardware_IDDataSet
            // 
            this.hardware_IDDataSet.DataSetName = "Hardware_IDDataSet";
            this.hardware_IDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxNregion
            // 
            this.comboBoxNregion.DataSource = this.regionBindingSource;
            this.comboBoxNregion.DisplayMember = "Nregion";
            this.comboBoxNregion.FormattingEnabled = true;
            this.comboBoxNregion.Location = new System.Drawing.Point(794, 107);
            this.comboBoxNregion.Name = "comboBoxNregion";
            this.comboBoxNregion.Size = new System.Drawing.Size(292, 47);
            this.comboBoxNregion.TabIndex = 10;
            this.comboBoxNregion.ValueMember = "Cregion";
            // 
            // regionBindingSource
            // 
            this.regionBindingSource.DataMember = "Region";
            this.regionBindingSource.DataSource = this.hardware_IDDataSet;
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Lmemeber", true));
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(25, 46);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(292, 47);
            this.txtLastName.TabIndex = 7;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(1092, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 36);
            this.label7.TabIndex = 6;
            this.label7.Text = "نام سازمان :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblPersonnalCode
            // 
            this.lblPersonnalCode.BackColor = System.Drawing.Color.White;
            this.lblPersonnalCode.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPersonnalCode.Location = new System.Drawing.Point(1092, 52);
            this.lblPersonnalCode.Name = "lblPersonnalCode";
            this.lblPersonnalCode.Size = new System.Drawing.Size(94, 36);
            this.lblPersonnalCode.TabIndex = 6;
            this.lblPersonnalCode.Text = "کد پرسنلی :";
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.White;
            this.lblLastName.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLastName.Location = new System.Drawing.Point(323, 52);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(112, 36);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "نام خانوادگی :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Nmemeber", true));
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(441, 46);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(292, 47);
            this.txtFirstName.TabIndex = 8;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.White;
            this.lblFirstName.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFirstName.Location = new System.Drawing.Point(739, 52);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(44, 36);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "نام :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtModelParts);
            this.groupBox2.Controls.Add(this.txtNameParts);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("B Koodak", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(24, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1212, 136);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات سخت افزار";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.partsBindingSource;
            this.comboBox2.DisplayMember = "PNparts";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(779, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(278, 47);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.ValueMember = "PNparts";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "Parts";
            this.partsBindingSource.DataSource = this.hardware_IDDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(683, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "نام قطعه :";
            // 
            // txtModelParts
            // 
            this.txtModelParts.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Mparts", true));
            this.txtModelParts.Enabled = false;
            this.txtModelParts.Location = new System.Drawing.Point(22, 51);
            this.txtModelParts.Name = "txtModelParts";
            this.txtModelParts.Size = new System.Drawing.Size(277, 47);
            this.txtModelParts.TabIndex = 8;
            this.txtModelParts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNameParts
            // 
            this.txtNameParts.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Nparts", true));
            this.txtNameParts.Enabled = false;
            this.txtNameParts.Location = new System.Drawing.Point(400, 51);
            this.txtNameParts.Name = "txtNameParts";
            this.txtNameParts.Size = new System.Drawing.Size(277, 47);
            this.txtNameParts.TabIndex = 9;
            this.txtNameParts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(1063, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "شماره اموال قطعه :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(305, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "مدل قطعه :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.txtEdata);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtSdata);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("B Koodak", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox3.Location = new System.Drawing.Point(24, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1212, 132);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تاریخ تحویل";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(270, 43);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 46);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "وضعیت";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtEdata
            // 
            this.txtEdata.Location = new System.Drawing.Point(386, 43);
            this.txtEdata.Name = "txtEdata";
            this.txtEdata.Size = new System.Drawing.Size(292, 47);
            this.txtEdata.TabIndex = 9;
            this.txtEdata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEdata.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(684, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 34);
            this.label6.TabIndex = 6;
            this.label6.Text = "پایان تحویل :";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSdata
            // 
            this.txtSdata.Location = new System.Drawing.Point(806, 40);
            this.txtSdata.Name = "txtSdata";
            this.txtSdata.Size = new System.Drawing.Size(292, 47);
            this.txtSdata.TabIndex = 9;
            this.txtSdata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSdata.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(1104, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "زمان تحویل :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnBacke
            // 
            this.btnBacke.BackColor = System.Drawing.Color.Turquoise;
            this.btnBacke.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBacke.ForeColor = System.Drawing.Color.White;
            this.btnBacke.Location = new System.Drawing.Point(441, 519);
            this.btnBacke.Name = "btnBacke";
            this.btnBacke.Size = new System.Drawing.Size(229, 55);
            this.btnBacke.TabIndex = 5;
            this.btnBacke.Text = "بازگشت";
            this.btnBacke.UseVisualStyleBackColor = false;
            this.btnBacke.Click += new System.EventHandler(this.btnBacke_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Turquoise;
            this.btnSave.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(678, 519);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(229, 55);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // HardwarebindingSource
            // 
            this.HardwarebindingSource.DataMember = "Hardware ID";
            this.HardwarebindingSource.DataSource = this.hardware_IDDataSet;
            // 
            // hardware_IDTableAdapter
            // 
            this.hardware_IDTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSourceShenasname
            // 
            this.bindingSourceShenasname.DataMember = "Shenasname";
            this.bindingSourceShenasname.DataSource = this.hardware_IDDataSet;
            // 
            // shenasnameTableAdapter
            // 
            this.shenasnameTableAdapter.ClearBeforeFill = true;
            // 
            // frmShenasnameh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1262, 607);
            this.Controls.Add(this.btnBacke);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmShenasnameh";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم ثبت شناسنامه سخت افزاری";
            this.Load += new System.EventHandler(this.frmShenasnameh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardware_IDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HardwarebindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceShenasname)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtNameParts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModelParts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSdata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtEdata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBacke;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxNregion;
        private Hardware_IDDataSet hardware_IDDataSet;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private Hardware_IDDataSetTableAdapters.RegionTableAdapter regionTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private Hardware_IDDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private Hardware_IDDataSetTableAdapters.PartsTableAdapter partsTableAdapter;
        private System.Windows.Forms.BindingSource HardwarebindingSource;
        private Hardware_IDDataSetTableAdapters.Hardware_IDTableAdapter hardware_IDTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceShenasname;
        private Hardware_IDDataSetTableAdapters.ShenasnameTableAdapter shenasnameTableAdapter;
    }
}