using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_ID
{
    public partial class listMember : Form
    {
        public listMember()
        {
            InitializeComponent();
        }

        private void listMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hardware_IDDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.hardware_IDDataSet.Member);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMember formmember = new frmMember();
            formmember.ShowDialog();
            this.memberTableAdapter.Fill(this.hardware_IDDataSet.Member); 
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int personelcode = int.Parse(dataGridView1.CurrentRow.Cells["PCmemeber"].Value.ToString());
            DialogResult result = MessageBox.Show("آیا از غیر فعال کردن این رکورد اطمینان دارید", "تاییدیه غیر فعال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                memberTableAdapter.DeleteQueryMember(personelcode);
                this.memberTableAdapter.Fill(this.hardware_IDDataSet.Member);
                MessageBox.Show("با موفقیت حذف شد");     
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmMember newmember = new frmMember();
            newmember.update = true;
            newmember.PCmemeber =int.Parse(dataGridView1.CurrentRow.Cells["PCmemeber"].Value.ToString());
            newmember.ShowDialog();
            this.memberTableAdapter.Fill(this.hardware_IDDataSet.Member);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            listShenasnameh smember = new listShenasnameh();
            smember.select = true;
            smember.PCmemeber = int.Parse(dataGridView1.CurrentRow.Cells["PCmemeber"].Value.ToString());
            smember.ShowDialog();
            this.memberTableAdapter.Fill(this.hardware_IDDataSet.Member);
        }

        private void comboBoxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchBox.Clear();
            txtSearchBox.Focus();
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (txtSearchBox.Text.Length != 0)
                {
                    if (comboBoxSearchType.SelectedIndex == 0)
                    {
                        this.memberBindingSource.DataSource = this.memberTableAdapter.GetDataByPCmemeber(int.Parse(txtSearchBox.Text));
                    }
                    if(comboBoxSearchType.SelectedIndex==1)
                    {
                        this.memberBindingSource.DataSource=this.memberTableAdapter.GetDataByLastName(txtSearchBox.Text);
                    }
                }
                else
                    this.memberBindingSource.DataSource = this.memberTableAdapter.GetData();
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
