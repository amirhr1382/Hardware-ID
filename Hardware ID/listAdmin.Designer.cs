
namespace Hardware_ID
{
    partial class listAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddP = new System.Windows.Forms.Button();
            this.PCadmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.padminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pICadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hardware_IDDataSet = new Hardware_ID.Hardware_IDDataSet();
            this.adminTableAdapter = new Hardware_ID.Hardware_IDDataSetTableAdapters.AdminTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
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
            this.PCadmin,
            this.nadminDataGridViewTextBoxColumn,
            this.ladminDataGridViewTextBoxColumn,
            this.nCadminDataGridViewTextBoxColumn,
            this.uadminDataGridViewTextBoxColumn,
            this.padminDataGridViewTextBoxColumn,
            this.pICadminDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1125, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(761, 27);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 57);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(877, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 57);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddP
            // 
            this.btnAddP.Location = new System.Drawing.Point(1008, 27);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(105, 57);
            this.btnAddP.TabIndex = 5;
            this.btnAddP.Text = "ثبت";
            this.btnAddP.UseVisualStyleBackColor = true;
            this.btnAddP.Click += new System.EventHandler(this.btnAddP_Click);
            // 
            // PCadmin
            // 
            this.PCadmin.DataPropertyName = "PCadmin";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PCadmin.DefaultCellStyle = dataGridViewCellStyle1;
            this.PCadmin.HeaderText = "کد پرسنلی";
            this.PCadmin.MinimumWidth = 6;
            this.PCadmin.Name = "PCadmin";
            this.PCadmin.ReadOnly = true;
            this.PCadmin.Width = 150;
            // 
            // nadminDataGridViewTextBoxColumn
            // 
            this.nadminDataGridViewTextBoxColumn.DataPropertyName = "Nadmin";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nadminDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nadminDataGridViewTextBoxColumn.HeaderText = "نام";
            this.nadminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nadminDataGridViewTextBoxColumn.Name = "nadminDataGridViewTextBoxColumn";
            this.nadminDataGridViewTextBoxColumn.ReadOnly = true;
            this.nadminDataGridViewTextBoxColumn.Width = 200;
            // 
            // ladminDataGridViewTextBoxColumn
            // 
            this.ladminDataGridViewTextBoxColumn.DataPropertyName = "Ladmin";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ladminDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.ladminDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            this.ladminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ladminDataGridViewTextBoxColumn.Name = "ladminDataGridViewTextBoxColumn";
            this.ladminDataGridViewTextBoxColumn.ReadOnly = true;
            this.ladminDataGridViewTextBoxColumn.Width = 200;
            // 
            // nCadminDataGridViewTextBoxColumn
            // 
            this.nCadminDataGridViewTextBoxColumn.DataPropertyName = "NCadmin";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nCadminDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.nCadminDataGridViewTextBoxColumn.HeaderText = "کد ملی";
            this.nCadminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nCadminDataGridViewTextBoxColumn.Name = "nCadminDataGridViewTextBoxColumn";
            this.nCadminDataGridViewTextBoxColumn.ReadOnly = true;
            this.nCadminDataGridViewTextBoxColumn.Width = 200;
            // 
            // uadminDataGridViewTextBoxColumn
            // 
            this.uadminDataGridViewTextBoxColumn.DataPropertyName = "Uadmin";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.uadminDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.uadminDataGridViewTextBoxColumn.HeaderText = "نام کاربری";
            this.uadminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uadminDataGridViewTextBoxColumn.Name = "uadminDataGridViewTextBoxColumn";
            this.uadminDataGridViewTextBoxColumn.ReadOnly = true;
            this.uadminDataGridViewTextBoxColumn.Width = 160;
            // 
            // padminDataGridViewTextBoxColumn
            // 
            this.padminDataGridViewTextBoxColumn.DataPropertyName = "Padmin";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.padminDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.padminDataGridViewTextBoxColumn.HeaderText = "گزواژه";
            this.padminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.padminDataGridViewTextBoxColumn.Name = "padminDataGridViewTextBoxColumn";
            this.padminDataGridViewTextBoxColumn.ReadOnly = true;
            this.padminDataGridViewTextBoxColumn.Width = 160;
            // 
            // pICadminDataGridViewTextBoxColumn
            // 
            this.pICadminDataGridViewTextBoxColumn.DataPropertyName = "PICadmin";
            this.pICadminDataGridViewTextBoxColumn.HeaderText = "PICadmin";
            this.pICadminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pICadminDataGridViewTextBoxColumn.Name = "pICadminDataGridViewTextBoxColumn";
            this.pICadminDataGridViewTextBoxColumn.ReadOnly = true;
            this.pICadminDataGridViewTextBoxColumn.Visible = false;
            this.pICadminDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.hardware_IDDataSet;
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
            // listAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 553);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddP);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "listAdmin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیران";
            this.Load += new System.EventHandler(this.listAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardware_IDDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Hardware_IDDataSet hardware_IDDataSet;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private Hardware_IDDataSetTableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCadmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn padminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pICadminDataGridViewTextBoxColumn;
    }
}