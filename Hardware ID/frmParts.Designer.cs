
namespace Hardware_ID
{
    partial class frmParts
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
            this.txtNameParts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelParts = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPNparts = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBacke = new System.Windows.Forms.Button();
            this.partsbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hardware_IDDataSet = new Hardware_ID.Hardware_IDDataSet();
            this.partsTableAdapter = new Hardware_ID.Hardware_IDDataSetTableAdapters.PartsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.partsbindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardware_IDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("B Mitra", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(708, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "فرم ثبت قطعات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(685, 305);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(586, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام قطعه :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNameParts
            // 
            this.txtNameParts.Location = new System.Drawing.Point(365, 140);
            this.txtNameParts.Name = "txtNameParts";
            this.txtNameParts.Size = new System.Drawing.Size(294, 42);
            this.txtNameParts.TabIndex = 3;
            this.txtNameParts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNameParts.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNameParts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNameParts_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(262, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 34);
            this.label4.TabIndex = 2;
            this.label4.Text = "مدل قطعه :";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtModelParts
            // 
            this.txtModelParts.Location = new System.Drawing.Point(45, 140);
            this.txtModelParts.Name = "txtModelParts";
            this.txtModelParts.Size = new System.Drawing.Size(300, 42);
            this.txtModelParts.TabIndex = 3;
            this.txtModelParts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtModelParts.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtModelParts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtModelParts_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(376, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 34);
            this.label5.TabIndex = 2;
            this.label5.Text = "شماره اموال قطعه :";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPNparts
            // 
            this.txtPNparts.Location = new System.Drawing.Point(209, 233);
            this.txtPNparts.MaxLength = 9;
            this.txtPNparts.Name = "txtPNparts";
            this.txtPNparts.Size = new System.Drawing.Size(300, 42);
            this.txtPNparts.TabIndex = 3;
            this.txtPNparts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPNparts.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtPNparts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPNparts_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Turquoise;
            this.btnSave.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(365, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(208, 55);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // btnBacke
            // 
            this.btnBacke.BackColor = System.Drawing.Color.Turquoise;
            this.btnBacke.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBacke.ForeColor = System.Drawing.Color.White;
            this.btnBacke.Location = new System.Drawing.Point(137, 292);
            this.btnBacke.Name = "btnBacke";
            this.btnBacke.Size = new System.Drawing.Size(208, 55);
            this.btnBacke.TabIndex = 4;
            this.btnBacke.Text = "بازگشت";
            this.btnBacke.UseVisualStyleBackColor = false;
            this.btnBacke.Click += new System.EventHandler(this.btnBacke_Click);
            this.btnBacke.MouseLeave += new System.EventHandler(this.btnBacke_MouseLeave);
            this.btnBacke.MouseHover += new System.EventHandler(this.btnBacke_MouseHover);
            // 
            // partsbindingSource1
            // 
            this.partsbindingSource1.DataMember = "Parts";
            this.partsbindingSource1.DataSource = this.hardware_IDDataSet;
            // 
            // hardware_IDDataSet
            // 
            this.hardware_IDDataSet.DataSetName = "Hardware_IDDataSet";
            this.hardware_IDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // frmParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(708, 395);
            this.Controls.Add(this.btnBacke);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPNparts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModelParts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNameParts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmParts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم ثبت قطعات";
            this.Load += new System.EventHandler(this.frmParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsbindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardware_IDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameParts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModelParts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPNparts;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBacke;
        private System.Windows.Forms.BindingSource partsbindingSource1;
        private Hardware_IDDataSet hardware_IDDataSet;
        private Hardware_IDDataSetTableAdapters.PartsTableAdapter partsTableAdapter;
    }
}