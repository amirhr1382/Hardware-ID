namespace Hardware_ID
{
    partial class listSearch
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            memberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            memberPersonelCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            partNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            partNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            regionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            searchViewModelBindingSource = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { memberNameDataGridViewTextBoxColumn, memberPersonelCodeDataGridViewTextBoxColumn, partNameDataGridViewTextBoxColumn, partNumberDataGridViewTextBoxColumn, regionNameDataGridViewTextBoxColumn });
            dataGridView1.DataSource = searchViewModelBindingSource;
            dataGridView1.Location = new System.Drawing.Point(0, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(798, 450);
            dataGridView1.TabIndex = 0;
            // 
            // memberNameDataGridViewTextBoxColumn
            // 
            memberNameDataGridViewTextBoxColumn.DataPropertyName = "MemberName";
            memberNameDataGridViewTextBoxColumn.HeaderText = "نام";
            memberNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            memberNameDataGridViewTextBoxColumn.Name = "memberNameDataGridViewTextBoxColumn";
            memberNameDataGridViewTextBoxColumn.ReadOnly = true;
            memberNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberPersonelCodeDataGridViewTextBoxColumn
            // 
            memberPersonelCodeDataGridViewTextBoxColumn.DataPropertyName = "MemberPersonelCode";
            memberPersonelCodeDataGridViewTextBoxColumn.HeaderText = "کد پرسنلی";
            memberPersonelCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            memberPersonelCodeDataGridViewTextBoxColumn.Name = "memberPersonelCodeDataGridViewTextBoxColumn";
            memberPersonelCodeDataGridViewTextBoxColumn.ReadOnly = true;
            memberPersonelCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // partNameDataGridViewTextBoxColumn
            // 
            partNameDataGridViewTextBoxColumn.DataPropertyName = "PartName";
            partNameDataGridViewTextBoxColumn.HeaderText = "نام قطعه";
            partNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            partNameDataGridViewTextBoxColumn.Name = "partNameDataGridViewTextBoxColumn";
            partNameDataGridViewTextBoxColumn.ReadOnly = true;
            partNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // partNumberDataGridViewTextBoxColumn
            // 
            partNumberDataGridViewTextBoxColumn.DataPropertyName = "PartNumber";
            partNumberDataGridViewTextBoxColumn.HeaderText = "شماره اموال";
            partNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            partNumberDataGridViewTextBoxColumn.Name = "partNumberDataGridViewTextBoxColumn";
            partNumberDataGridViewTextBoxColumn.ReadOnly = true;
            partNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // regionNameDataGridViewTextBoxColumn
            // 
            regionNameDataGridViewTextBoxColumn.DataPropertyName = "RegionName";
            regionNameDataGridViewTextBoxColumn.HeaderText = "سازمان";
            regionNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            regionNameDataGridViewTextBoxColumn.Name = "regionNameDataGridViewTextBoxColumn";
            regionNameDataGridViewTextBoxColumn.ReadOnly = true;
            regionNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // searchViewModelBindingSource
            // 
            searchViewModelBindingSource.DataSource = typeof(ViewModels.SearchViewModel);
            // 
            // listSearch
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "listSearch";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "جستجو";
            Load += listSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchViewModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource searchViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberPersonelCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionNameDataGridViewTextBoxColumn;
    }
}