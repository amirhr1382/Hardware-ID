
namespace Hardware_ID
{
    partial class listParts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PNparts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npartsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpartsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hardware_IDDataSet = new Hardware_ID.Hardware_IDDataSet();
            this.btnAddP = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.partsTableAdapter = new Hardware_ID.Hardware_IDDataSetTableAdapters.PartsTableAdapter();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.comboBoxSearchType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
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
            this.PNparts,
            this.npartsDataGridViewTextBoxColumn,
            this.mpartsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.partsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(794, 536);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // PNparts
            // 
            this.PNparts.DataPropertyName = "PNparts";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Koodak", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PNparts.DefaultCellStyle = dataGridViewCellStyle1;
            this.PNparts.HeaderText = "شماره اموال قطعه";
            this.PNparts.MinimumWidth = 6;
            this.PNparts.Name = "PNparts";
            this.PNparts.ReadOnly = true;
            this.PNparts.Width = 200;
            // 
            // npartsDataGridViewTextBoxColumn
            // 
            this.npartsDataGridViewTextBoxColumn.DataPropertyName = "Nparts";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Koodak", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.npartsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.npartsDataGridViewTextBoxColumn.HeaderText = "نام قطعه";
            this.npartsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.npartsDataGridViewTextBoxColumn.Name = "npartsDataGridViewTextBoxColumn";
            this.npartsDataGridViewTextBoxColumn.ReadOnly = true;
            this.npartsDataGridViewTextBoxColumn.Width = 150;
            // 
            // mpartsDataGridViewTextBoxColumn
            // 
            this.mpartsDataGridViewTextBoxColumn.DataPropertyName = "Mparts";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Koodak", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mpartsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.mpartsDataGridViewTextBoxColumn.HeaderText = "مدل قطعه";
            this.mpartsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mpartsDataGridViewTextBoxColumn.Name = "mpartsDataGridViewTextBoxColumn";
            this.mpartsDataGridViewTextBoxColumn.ReadOnly = true;
            this.mpartsDataGridViewTextBoxColumn.Width = 160;
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "Parts";
            this.partsBindingSource.DataSource = this.hardware_IDDataSet;
            // 
            // hardware_IDDataSet
            // 
            this.hardware_IDDataSet.DataSetName = "Hardware_IDDataSet";
            this.hardware_IDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddP
            // 
            this.btnAddP.Location = new System.Drawing.Point(677, 32);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(105, 57);
            this.btnAddP.TabIndex = 1;
            this.btnAddP.Text = "قطعه جدید";
            this.btnAddP.UseVisualStyleBackColor = true;
            this.btnAddP.Click += new System.EventHandler(this.btnAddP_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(546, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 57);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(430, 32);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 57);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(9, 40);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(266, 42);
            this.txtSearchBox.TabIndex = 12;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // comboBoxSearchType
            // 
            this.comboBoxSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchType.FormattingEnabled = true;
            this.comboBoxSearchType.Items.AddRange(new object[] {
            "کد پرسنلی",
            "شماره اموال",
            "نام سازمان"});
            this.comboBoxSearchType.Location = new System.Drawing.Point(281, 40);
            this.comboBoxSearchType.Name = "comboBoxSearchType";
            this.comboBoxSearchType.Size = new System.Drawing.Size(121, 42);
            this.comboBoxSearchType.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "جستجو بر اساس :";
            // 
            // listParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 648);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.comboBoxSearchType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddP);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "listParts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست قطعات";
            this.Load += new System.EventHandler(this.listParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardware_IDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Hardware_IDDataSet hardware_IDDataSet;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private Hardware_IDDataSetTableAdapters.PartsTableAdapter partsTableAdapter;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PNparts;
        private System.Windows.Forms.DataGridViewTextBoxColumn npartsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpartsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ComboBox comboBoxSearchType;
        private System.Windows.Forms.Label label1;
    }
}