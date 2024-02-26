
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
            components = new System.ComponentModel.Container();
            btnEdit = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            adminBindingSource = new System.Windows.Forms.BindingSource(components);
            dgvAdmins = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            imagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nationalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            adminBindingSource1 = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)adminBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adminBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(761, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(110, 57);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(877, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(125, 57);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(1008, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(105, 57);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "جدید";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // adminBindingSource
            // 
            adminBindingSource.DataSource = typeof(Models.Admin);
            // 
            // dgvAdmins
            // 
            dgvAdmins.AllowUserToAddRows = false;
            dgvAdmins.AllowUserToDeleteRows = false;
            dgvAdmins.AutoGenerateColumns = false;
            dgvAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, imagePathDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, nationalCodeDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn });
            dgvAdmins.DataSource = adminBindingSource;
            dgvAdmins.Location = new System.Drawing.Point(-1, 75);
            dgvAdmins.Name = "dgvAdmins";
            dgvAdmins.ReadOnly = true;
            dgvAdmins.RowHeadersWidth = 51;
            dgvAdmins.Size = new System.Drawing.Size(1128, 478);
            dgvAdmins.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            Column1.Width = 125;
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
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "نام کاربری";
            usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.ReadOnly = true;
            usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminBindingSource1
            // 
            adminBindingSource1.DataSource = typeof(Models.Admin);
            // 
            // listAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1125, 553);
            Controls.Add(dgvAdmins);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "listAdmin";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "مدیران";
            Load += listAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)adminBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).EndInit();
            ((System.ComponentModel.ISupportInitialize)adminBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCadmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn padminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pICadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private System.Windows.Forms.BindingSource adminBindingSource1;
        public System.Windows.Forms.DataGridView dgvAdmins;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
    }
}