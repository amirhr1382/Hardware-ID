
namespace Hardware_ID
{
    partial class listPart
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
            btnAdd = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            txtSearchBox = new System.Windows.Forms.TextBox();
            comboBoxSearchType = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            dgvParts = new System.Windows.Forms.DataGridView();
            partBindingSource = new System.Windows.Forms.BindingSource(components);
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(677, 32);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(105, 57);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "قطعه جدید";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(546, 32);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(125, 57);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(430, 32);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(110, 57);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Location = new System.Drawing.Point(9, 40);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new System.Drawing.Size(266, 42);
            txtSearchBox.TabIndex = 12;
            txtSearchBox.KeyDown += txtSearchBox_KeyDown;
            // 
            // comboBoxSearchType
            // 
            comboBoxSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSearchType.FormattingEnabled = true;
            comboBoxSearchType.Items.AddRange(new object[] { "نام" });
            comboBoxSearchType.Location = new System.Drawing.Point(281, 40);
            comboBoxSearchType.Name = "comboBoxSearchType";
            comboBoxSearchType.Size = new System.Drawing.Size(121, 42);
            comboBoxSearchType.TabIndex = 11;
            comboBoxSearchType.SelectedIndexChanged += comboBoxSearchType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(272, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(135, 34);
            label1.TabIndex = 10;
            label1.Text = "جستجو بر اساس :";
            // 
            // dgvParts
            // 
            dgvParts.AutoGenerateColumns = false;
            dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, numberDataGridViewTextBoxColumn });
            dgvParts.DataSource = partBindingSource;
            dgvParts.Location = new System.Drawing.Point(2, 105);
            dgvParts.Name = "dgvParts";
            dgvParts.RowHeadersWidth = 51;
            dgvParts.Size = new System.Drawing.Size(789, 543);
            dgvParts.TabIndex = 13;
            dgvParts.DoubleClick += dgvParts_DoubleClick;
            // 
            // partBindingSource
            // 
            partBindingSource.DataSource = typeof(Models.Part);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "نام";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            modelDataGridViewTextBoxColumn.HeaderText = "مدل";
            modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            numberDataGridViewTextBoxColumn.HeaderText = "شماره اموال";
            numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            numberDataGridViewTextBoxColumn.Width = 125;
            // 
            // listPart
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(794, 648);
            Controls.Add(dgvParts);
            Controls.Add(txtSearchBox);
            Controls.Add(comboBoxSearchType);
            Controls.Add(label1);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "listPart";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "لیست قطعات";
            Load += listPart_Load;
            ((System.ComponentModel.ISupportInitialize)dgvParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)partBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        //private Hardware_IDDataSetTableAdapters.PartsTableAdapter partsTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PNparts;
        private System.Windows.Forms.DataGridViewTextBoxColumn npartsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpartsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ComboBox comboBoxSearchType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
    }
}