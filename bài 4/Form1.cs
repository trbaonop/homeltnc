using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bài_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BnKQ_Click(object sender, EventArgs e)
        {
            double so1, so2, kq = 0;

            // kiểm tra dữ liệu nhập
            if (!double.TryParse(txtSo1.Text, out so1) || !double.TryParse(txtSo2.Text, out so2))
            {
                MessageBox.Show("Vui lòng nhập đúng số!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // xử lý phép tính
            if (radCONG.Checked)
                kq = so1 + so2;
            else if (radTRU.Checked)
                kq = so1 - so2;
            else if (radNHAN.Checked)
                kq = so1 * so2;
            else if (radCHIA.Checked)
            {
                if (so2 == 0)
                {
                    MessageBox.Show("Không thể chia cho 0!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                kq = so1 / so2;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phép tính!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // hiện kết quả
            txtKQ.Text = kq.ToString();
        }
    }

}
