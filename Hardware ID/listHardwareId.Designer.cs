
namespace Hardware_ID
{
    partial class listHardwareId
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
            dgvHardwareIds = new System.Windows.Forms.DataGridView();
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            memberDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            memberBindingSource = new System.Windows.Forms.BindingSource(components);
            regionCodeDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            regionBindingSource = new System.Windows.Forms.BindingSource(components);
            partDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            partBindingSource = new System.Windows.Forms.BindingSource(components);
            startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            isTransferredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            hardwareIdBindingSource = new System.Windows.Forms.BindingSource(components);
            btnAdd = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            txtSearchBox = new System.Windows.Forms.TextBox();
            comboBoxSearchType = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvHardwareIds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)regionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hardwareIdBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvHardwareIds
            // 
            dgvHardwareIds.AllowUserToAddRows = false;
            dgvHardwareIds.AllowUserToDeleteRows = false;
            dgvHardwareIds.AllowUserToOrderColumns = true;
            dgvHardwareIds.AutoGenerateColumns = false;
            dgvHardwareIds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHardwareIds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, memberDataGridViewComboBoxColumn, regionCodeDataGridViewComboBoxColumn, partDataGridViewComboBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, isTransferredDataGridViewCheckBoxColumn });
            dgvHardwareIds.DataSource = hardwareIdBindingSource;
            dgvHardwareIds.Dock = System.Windows.Forms.DockStyle.Bottom;
            dgvHardwareIds.Location = new System.Drawing.Point(0, 124);
            dgvHardwareIds.Name = "dgvHardwareIds";
            dgvHardwareIds.ReadOnly = true;
            dgvHardwareIds.RowHeadersWidth = 51;
            dgvHardwareIds.RowTemplate.Height = 30;
            dgvHardwareIds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvHardwareIds.Size = new System.Drawing.Size(1262, 562);
            dgvHardwareIds.TabIndex = 0;
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
            // memberDataGridViewComboBoxColumn
            // 
            memberDataGridViewComboBoxColumn.DataPropertyName = "Member";
            memberDataGridViewComboBoxColumn.DataSource = memberBindingSource;
            memberDataGridViewComboBoxColumn.DisplayMember = "PersonelCode";
            memberDataGridViewComboBoxColumn.HeaderText = "کد پرسنلی";
            memberDataGridViewComboBoxColumn.MinimumWidth = 6;
            memberDataGridViewComboBoxColumn.Name = "memberDataGridViewComboBoxColumn";
            memberDataGridViewComboBoxColumn.ReadOnly = true;
            memberDataGridViewComboBoxColumn.ValueMember = "Id";
            memberDataGridViewComboBoxColumn.Width = 125;
            // 
            // memberBindingSource
            // 
            memberBindingSource.DataSource = typeof(Models.Member);
            // 
            // regionCodeDataGridViewComboBoxColumn
            // 
            regionCodeDataGridViewComboBoxColumn.DataPropertyName = "Region";
            regionCodeDataGridViewComboBoxColumn.DataSource = regionBindingSource;
            regionCodeDataGridViewComboBoxColumn.DisplayMember = "Name";
            regionCodeDataGridViewComboBoxColumn.HeaderText = "کد سازمان";
            regionCodeDataGridViewComboBoxColumn.MinimumWidth = 6;
            regionCodeDataGridViewComboBoxColumn.Name = "regionCodeDataGridViewComboBoxColumn";
            regionCodeDataGridViewComboBoxColumn.ReadOnly = true;
            regionCodeDataGridViewComboBoxColumn.ValueMember = "Id";
            regionCodeDataGridViewComboBoxColumn.Width = 125;
            // 
            // regionBindingSource
            // 
            regionBindingSource.DataSource = typeof(Models.Region);
            // 
            // partDataGridViewComboBoxColumn
            // 
            partDataGridViewComboBoxColumn.DataPropertyName = "Part";
            partDataGridViewComboBoxColumn.DataSource = partBindingSource;
            partDataGridViewComboBoxColumn.DisplayMember = "Name";
            partDataGridViewComboBoxColumn.HeaderText = "شماره اموال قطعه";
            partDataGridViewComboBoxColumn.MinimumWidth = 6;
            partDataGridViewComboBoxColumn.Name = "partDataGridViewComboBoxColumn";
            partDataGridViewComboBoxColumn.ReadOnly = true;
            partDataGridViewComboBoxColumn.ValueMember = "Id";
            partDataGridViewComboBoxColumn.Width = 125;
            // 
            // partBindingSource
            // 
            partBindingSource.DataSource = typeof(Models.Part);
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "زمان تحویل";
            startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.ReadOnly = true;
            startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            endDateDataGridViewTextBoxColumn.HeaderText = "پایان تحویل";
            endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            endDateDataGridViewTextBoxColumn.ReadOnly = true;
            endDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // isTransferredDataGridViewCheckBoxColumn
            // 
            isTransferredDataGridViewCheckBoxColumn.DataPropertyName = "IsTransferred";
            isTransferredDataGridViewCheckBoxColumn.HeaderText = "وضعیت";
            isTransferredDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isTransferredDataGridViewCheckBoxColumn.Name = "isTransferredDataGridViewCheckBoxColumn";
            isTransferredDataGridViewCheckBoxColumn.ReadOnly = true;
            isTransferredDataGridViewCheckBoxColumn.Width = 125;
            // 
            // hardwareIdBindingSource
            // 
            hardwareIdBindingSource.DataSource = typeof(Models.HardwareId);
            // 
            // btnAdd
            // 
            btnAdd.Font = new System.Drawing.Font("B Koodak", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            btnAdd.Location = new System.Drawing.Point(1129, 44);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(112, 56);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "جدید";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new System.Drawing.Font("B Koodak", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            btnEdit.Location = new System.Drawing.Point(1027, 43);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(96, 57);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Location = new System.Drawing.Point(17, 53);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new System.Drawing.Size(266, 42);
            txtSearchBox.TabIndex = 12;
            txtSearchBox.KeyDown += txtSearchBox_KeyDown;
            // 
            // comboBoxSearchType
            // 
            comboBoxSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSearchType.FormattingEnabled = true;
            comboBoxSearchType.Items.AddRange(new object[] { "کد پرسنلی", "شماره اموال", "کد سازمان", "" });
            comboBoxSearchType.Location = new System.Drawing.Point(289, 53);
            comboBoxSearchType.Name = "comboBoxSearchType";
            comboBoxSearchType.Size = new System.Drawing.Size(121, 42);
            comboBoxSearchType.TabIndex = 11;
            comboBoxSearchType.SelectedIndexChanged += comboBoxSearchType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(280, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(135, 34);
            label1.TabIndex = 10;
            label1.Text = "جستجو بر اساس :";
            // 
            // listShenasnameh
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1262, 686);
            Controls.Add(txtSearchBox);
            Controls.Add(comboBoxSearchType);
            Controls.Add(label1);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvHardwareIds);
            Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "listShenasnameh";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "شناسنامه سخت افزاری";
            Load += listShenasnameh_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHardwareIds).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)regionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)partBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)hardwareIdBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn nmemeberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lmemeberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn npartsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpartsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nregionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvHardwareIds;
        //private Hardware_IDDataSetTableAdapters.ShenasnameTableAdapter shenasnameTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCmemeberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNpartsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn transferDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ComboBox comboBoxSearchType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource hardwareIdBindingSource;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn memberDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn regionCodeDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn partDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isTransferredDataGridViewCheckBoxColumn;
    }
}