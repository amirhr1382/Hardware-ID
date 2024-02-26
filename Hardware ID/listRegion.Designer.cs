
namespace Hardware_ID
{
    partial class listRegion
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
            dgvRegions = new System.Windows.Forms.DataGridView();
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            regionBindingSource = new System.Windows.Forms.BindingSource(components);
            btnAdd = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvRegions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)regionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvRegions
            // 
            dgvRegions.AllowUserToAddRows = false;
            dgvRegions.AllowUserToDeleteRows = false;
            dgvRegions.AllowUserToOrderColumns = true;
            dgvRegions.AutoGenerateColumns = false;
            dgvRegions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dgvRegions.DataSource = regionBindingSource;
            dgvRegions.Dock = System.Windows.Forms.DockStyle.Bottom;
            dgvRegions.Location = new System.Drawing.Point(0, 97);
            dgvRegions.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dgvRegions.Name = "dgvRegions";
            dgvRegions.ReadOnly = true;
            dgvRegions.RowHeadersWidth = 51;
            dgvRegions.RowTemplate.Height = 30;
            dgvRegions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvRegions.Size = new System.Drawing.Size(557, 309);
            dgvRegions.TabIndex = 0;
            dgvRegions.DoubleClick += dgvRegion_DoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // regionBindingSource
            // 
            regionBindingSource.DataSource = typeof(Models.Region);
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(430, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(115, 55);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "سازمان جدید";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(168, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(125, 55);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(299, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(125, 55);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // listRegion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(557, 406);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvRegions);
            Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "listRegion";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "لیست سازمان ها";
            Load += listRegion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegions).EndInit();
            ((System.ComponentModel.ISupportInitialize)regionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegions;
        //private Hardware_IDDataSetTableAdapters.RegionTableAdapter regionTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cregion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nregionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private System.Windows.Forms.Button btnEdit;
    }
}