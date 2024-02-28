
namespace Hardware_ID
{
    partial class listMember
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
            dgvMembers = new System.Windows.Forms.DataGridView();
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            imagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            personelCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nationalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            isEnableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            memberBindingSource = new System.Windows.Forms.BindingSource(components);
            btnAdd = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            comboBoxSearchType = new System.Windows.Forms.ComboBox();
            txtSearchBox = new System.Windows.Forms.TextBox();
            memberBindingSource1 = new System.Windows.Forms.BindingSource(components);
            btnDisableOrEnable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AutoGenerateColumns = false;
            dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, imagePathDataGridViewTextBoxColumn, personelCodeDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, nationalCodeDataGridViewTextBoxColumn, mobileDataGridViewTextBoxColumn, isEnableDataGridViewTextBoxColumn });
            dgvMembers.DataSource = memberBindingSource;
            dgvMembers.Dock = System.Windows.Forms.DockStyle.Bottom;
            dgvMembers.Location = new System.Drawing.Point(0, 118);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.RowTemplate.Height = 30;
            dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new System.Drawing.Size(1004, 543);
            dgvMembers.TabIndex = 0;
            dgvMembers.DoubleClick += dgvMember_DoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // imagePathDataGridViewTextBoxColumn
            // 
            imagePathDataGridViewTextBoxColumn.DataPropertyName = "ImagePath";
            imagePathDataGridViewTextBoxColumn.HeaderText = "ImagePath";
            imagePathDataGridViewTextBoxColumn.MinimumWidth = 6;
            imagePathDataGridViewTextBoxColumn.Name = "imagePathDataGridViewTextBoxColumn";
            imagePathDataGridViewTextBoxColumn.ReadOnly = true;
            imagePathDataGridViewTextBoxColumn.Visible = false;
            imagePathDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelCodeDataGridViewTextBoxColumn
            // 
            personelCodeDataGridViewTextBoxColumn.DataPropertyName = "PersonelCode";
            personelCodeDataGridViewTextBoxColumn.HeaderText = "کد پرسنلی";
            personelCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            personelCodeDataGridViewTextBoxColumn.Name = "personelCodeDataGridViewTextBoxColumn";
            personelCodeDataGridViewTextBoxColumn.ReadOnly = true;
            personelCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "نام";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // nationalCodeDataGridViewTextBoxColumn
            // 
            nationalCodeDataGridViewTextBoxColumn.DataPropertyName = "NationalCode";
            nationalCodeDataGridViewTextBoxColumn.HeaderText = "کد ملی";
            nationalCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nationalCodeDataGridViewTextBoxColumn.Name = "nationalCodeDataGridViewTextBoxColumn";
            nationalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            nationalCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            mobileDataGridViewTextBoxColumn.HeaderText = "موبایل";
            mobileDataGridViewTextBoxColumn.MinimumWidth = 6;
            mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            mobileDataGridViewTextBoxColumn.ReadOnly = true;
            mobileDataGridViewTextBoxColumn.Width = 125;
            // 
            // isEnableDataGridViewTextBoxColumn
            // 
            isEnableDataGridViewTextBoxColumn.DataPropertyName = "IsEnable";
            isEnableDataGridViewTextBoxColumn.HeaderText = "فعال";
            isEnableDataGridViewTextBoxColumn.MinimumWidth = 6;
            isEnableDataGridViewTextBoxColumn.Name = "isEnableDataGridViewTextBoxColumn";
            isEnableDataGridViewTextBoxColumn.ReadOnly = true;
            isEnableDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberBindingSource
            // 
            memberBindingSource.DataSource = typeof(Models.Member);
            // 
            // btnAdd
            // 
            btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnAdd.Location = new System.Drawing.Point(860, 40);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(132, 57);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "کارمند جدید";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(729, 40);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(125, 57);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(496, 40);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(96, 57);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(334, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(135, 34);
            label1.TabIndex = 4;
            label1.Text = "جستجو بر اساس :";
            // 
            // comboBoxSearchType
            // 
            comboBoxSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSearchType.FormattingEnabled = true;
            comboBoxSearchType.Items.AddRange(new object[] { "نام", "کد ملی", "موبایل" });
            comboBoxSearchType.Location = new System.Drawing.Point(342, 48);
            comboBoxSearchType.Name = "comboBoxSearchType";
            comboBoxSearchType.Size = new System.Drawing.Size(121, 42);
            comboBoxSearchType.TabIndex = 5;
            comboBoxSearchType.SelectedIndexChanged += comboBoxSearchType_SelectedIndexChanged;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Location = new System.Drawing.Point(70, 48);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new System.Drawing.Size(266, 42);
            txtSearchBox.TabIndex = 6;
            txtSearchBox.KeyDown += txtSearchBox_KeyDown;
            // 
            // memberBindingSource1
            // 
            memberBindingSource1.DataSource = typeof(Models.Member);
            // 
            // btnDisableOrEnable
            // 
            btnDisableOrEnable.Location = new System.Drawing.Point(598, 40);
            btnDisableOrEnable.Name = "btnDisableOrEnable";
            btnDisableOrEnable.Size = new System.Drawing.Size(125, 57);
            btnDisableOrEnable.TabIndex = 7;
            btnDisableOrEnable.Text = "فعال/غیرفعال";
            btnDisableOrEnable.UseVisualStyleBackColor = true;
            btnDisableOrEnable.Click += btnDisableOrEnable_Click;
            // 
            // listMember
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1004, 661);
            Controls.Add(btnDisableOrEnable);
            Controls.Add(txtSearchBox);
            Controls.Add(comboBoxSearchType);
            Controls.Add(label1);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvMembers);
            Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "listMember";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "لیست اعضا";
            Load += listMember_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMembers;
        //private Hardware_IDDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCmemeber;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmemeberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lmemeberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCmemeberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSearchType;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.BindingSource memberBindingSource1;
        private System.Windows.Forms.Button btnDisableOrEnable;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isEnableDataGridViewTextBoxColumn;
    }
}