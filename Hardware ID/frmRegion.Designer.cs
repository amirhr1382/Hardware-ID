
namespace Hardware_ID
{
    partial class frmRegion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCregion = new System.Windows.Forms.TextBox();
            this.txtNregion = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBacke = new System.Windows.Forms.Button();
            this.RegionbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hardware_IDDataSet = new Hardware_ID.Hardware_IDDataSet();
            this.regionTableAdapter = new Hardware_ID.Hardware_IDDataSetTableAdapters.RegionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RegionbindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardware_IDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 282);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(343, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام سازمان :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(343, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "کد سازمان :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCregion
            // 
            this.txtCregion.Location = new System.Drawing.Point(58, 126);
            this.txtCregion.MaxLength = 3;
            this.txtCregion.Name = "txtCregion";
            this.txtCregion.Size = new System.Drawing.Size(280, 42);
            this.txtCregion.TabIndex = 3;
            this.txtCregion.TextChanged += new System.EventHandler(this.txtCregion_TextChanged);
            this.txtCregion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCregion_KeyDown);
            // 
            // txtNregion
            // 
            this.txtNregion.Location = new System.Drawing.Point(58, 190);
            this.txtNregion.Name = "txtNregion";
            this.txtNregion.Size = new System.Drawing.Size(280, 42);
            this.txtNregion.TabIndex = 4;
            this.txtNregion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtNregion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNregion_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Turquoise;
            this.btnSave.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.Location = new System.Drawing.Point(126, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(242, 58);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Turquoise;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("B Mitra", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(492, 99);
            this.label4.TabIndex = 2;
            this.label4.Text = "فرم ثبت سازمان ها";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnBacke
            // 
            this.btnBacke.BackColor = System.Drawing.Color.Turquoise;
            this.btnBacke.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBacke.Location = new System.Drawing.Point(126, 318);
            this.btnBacke.Name = "btnBacke";
            this.btnBacke.Size = new System.Drawing.Size(242, 58);
            this.btnBacke.TabIndex = 5;
            this.btnBacke.Text = "بازگشت";
            this.btnBacke.UseVisualStyleBackColor = false;
            this.btnBacke.Click += new System.EventHandler(this.btnBacke_Click);
            this.btnBacke.MouseLeave += new System.EventHandler(this.btnBacke_MouseLeave);
            this.btnBacke.MouseHover += new System.EventHandler(this.btnBacke_MouseHover);
            // 
            // RegionbindingSource1
            // 
            this.RegionbindingSource1.DataMember = "Region";
            this.RegionbindingSource1.DataSource = this.hardware_IDDataSet;
            // 
            // hardware_IDDataSet
            // 
            this.hardware_IDDataSet.DataSetName = "Hardware_IDDataSet";
            this.hardware_IDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
            // 
            // frmRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(492, 404);
            this.Controls.Add(this.btnBacke);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNregion);
            this.Controls.Add(this.txtCregion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmRegion";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم ثبت سازمان";
            this.Load += new System.EventHandler(this.frmRegion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RegionbindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardware_IDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCregion;
        private System.Windows.Forms.TextBox txtNregion;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBacke;
        private System.Windows.Forms.BindingSource RegionbindingSource1;
        private Hardware_IDDataSet hardware_IDDataSet;
        private Hardware_IDDataSetTableAdapters.RegionTableAdapter regionTableAdapter;
    }
}