
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PCmemeber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmemeberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lmemeberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCmemeberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hardware_IDDataSet = new Hardware_ID.Hardware_IDDataSet();
            this.btnAddM = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSearchType = new System.Windows.Forms.ComboBox();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.memberTableAdapter = new Hardware_ID.Hardware_IDDataSetTableAdapters.MemberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardware_IDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PCmemeber,
            this.nmemeberDataGridViewTextBoxColumn,
            this.lmemeberDataGridViewTextBoxColumn,
            this.nCmemeberDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.memberBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 543);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // PCmemeber
            // 
            this.PCmemeber.DataPropertyName = "PCmemeber";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Blue;
            this.PCmemeber.DefaultCellStyle = dataGridViewCellStyle6;
            this.PCmemeber.HeaderText = "کد پرسنلی";
            this.PCmemeber.MinimumWidth = 6;
            this.PCmemeber.Name = "PCmemeber";
            this.PCmemeber.ReadOnly = true;
            this.PCmemeber.Width = 150;
            // 
            // nmemeberDataGridViewTextBoxColumn
            // 
            this.nmemeberDataGridViewTextBoxColumn.DataPropertyName = "Nmemeber";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Blue;
            this.nmemeberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.nmemeberDataGridViewTextBoxColumn.HeaderText = "نام";
            this.nmemeberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nmemeberDataGridViewTextBoxColumn.Name = "nmemeberDataGridViewTextBoxColumn";
            this.nmemeberDataGridViewTextBoxColumn.ReadOnly = true;
            this.nmemeberDataGridViewTextBoxColumn.Width = 200;
            // 
            // lmemeberDataGridViewTextBoxColumn
            // 
            this.lmemeberDataGridViewTextBoxColumn.DataPropertyName = "Lmemeber";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Blue;
            this.lmemeberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.lmemeberDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            this.lmemeberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lmemeberDataGridViewTextBoxColumn.Name = "lmemeberDataGridViewTextBoxColumn";
            this.lmemeberDataGridViewTextBoxColumn.ReadOnly = true;
            this.lmemeberDataGridViewTextBoxColumn.Width = 200;
            // 
            // nCmemeberDataGridViewTextBoxColumn
            // 
            this.nCmemeberDataGridViewTextBoxColumn.DataPropertyName = "NCmemeber";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.nCmemeberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.nCmemeberDataGridViewTextBoxColumn.HeaderText = "کد ملی";
            this.nCmemeberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nCmemeberDataGridViewTextBoxColumn.Name = "nCmemeberDataGridViewTextBoxColumn";
            this.nCmemeberDataGridViewTextBoxColumn.ReadOnly = true;
            this.nCmemeberDataGridViewTextBoxColumn.Width = 200;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Blue;
            this.telDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.telDataGridViewTextBoxColumn.HeaderText = "شماره همراه";
            this.telDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            this.telDataGridViewTextBoxColumn.Width = 200;
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
            // btnAddM
            // 
            this.btnAddM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddM.Location = new System.Drawing.Point(860, 40);
            this.btnAddM.Name = "btnAddM";
            this.btnAddM.Size = new System.Drawing.Size(132, 57);
            this.btnAddM.TabIndex = 1;
            this.btnAddM.Text = "کارمند جدید";
            this.btnAddM.UseVisualStyleBackColor = true;
            this.btnAddM.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(729, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 57);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "غیر فعال ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(627, 40);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 57);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "جستجو بر اساس :";
            // 
            // comboBoxSearchType
            // 
            this.comboBoxSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchType.FormattingEnabled = true;
            this.comboBoxSearchType.Items.AddRange(new object[] {
            "کد پرسنلی",
            "نام خانوادگی"});
            this.comboBoxSearchType.Location = new System.Drawing.Point(342, 48);
            this.comboBoxSearchType.Name = "comboBoxSearchType";
            this.comboBoxSearchType.Size = new System.Drawing.Size(121, 42);
            this.comboBoxSearchType.TabIndex = 5;
            this.comboBoxSearchType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchType_SelectedIndexChanged);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(70, 48);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(266, 42);
            this.txtSearchBox.TabIndex = 6;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            this.txtSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchBox_KeyDown);
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // listMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 661);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.comboBoxSearchType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddM);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "listMember";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست اعضا";
            this.Load += new System.EventHandler(this.listMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardware_IDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Hardware_IDDataSet hardware_IDDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private Hardware_IDDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.Button btnAddM;
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
    }
}