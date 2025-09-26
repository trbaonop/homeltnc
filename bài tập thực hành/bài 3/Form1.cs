using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace bài_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < lstTinh.Items.Count; i++)
            {
                int val = int.Parse(lstTinh.Items[i].ToString());
                if (val % 2 == 0)
                    count++;
            }
            MessageBox.Show("Số lượng ước số chẵn là: " + count,
                "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtSo.Text, out n) && n > 0)
            {
                cboSo.Items.Add(n);
                txtSo.Clear();
                txtSo.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i = 0; i < lstTinh.Items.Count; i++)
            {
                tong += int.Parse(lstTinh.Items[i].ToString());
            }
            MessageBox.Show("Tổng các ước số là: " + tong,
                "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }
        private void btnNguyenTo_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < lstTinh.Items.Count; i++)
            {
                int val = int.Parse(lstTinh.Items[i].ToString());
                if (LaSoNguyenTo(val))
                    count++;
            }
            MessageBox.Show("Số lượng ước số nguyên tố là: " + count,
                "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTinh.Items.Clear();
            int so = int.Parse(cboSo.SelectedItem.ToString());

            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                {
                    lstTinh.Items.Add(i);
                }
            }
        }
    }
}
