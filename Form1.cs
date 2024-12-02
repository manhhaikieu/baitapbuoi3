using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(txtLastname.Text);

            lvi.SubItems.Add(txtFirstname.Text);
            lvi.SubItems.Add(txtPhone.Text);


            lvStudents.Items.Add(lvi);


        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            {

                if (lvStudents.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Hãy chọn một mục để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                foreach (ListViewItem selectedItem in lvStudents.SelectedItems)
                {
                    lvStudents.Items.Remove(selectedItem);
                }


            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lvStudents.SelectedItems.Count > 0) // Kiểm tra có mục nào được chọn không
            {
                ListViewItem selectedItem = lvStudents.SelectedItems[0];
                selectedItem.Text = txtLastname.Text; // Cập nhật cột Last Name
                selectedItem.SubItems[1].Text = txtFirstname.Text; // Cập nhật cột First Name
                selectedItem.SubItems[2].Text = txtPhone.Text; // Cập nhật cột Phone
                MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        

    }
}
    

