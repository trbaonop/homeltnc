using System;
using System.Windows.Forms;
using MultipleChoise.Entity;
using MultipleChoise.BUS;
using MultipleChoise.Interface;

namespace MultipleChoise.Views
{
    public partial class FrmManagerQuestion : Form
    {
        IQuestionBusiness questionBusiness = new QuestionBus();
        private string oldTitle = "";

        public FrmManagerQuestion()
        {
            InitializeComponent();
        }

        private void FrmManagerQuestion_Load(object sender, EventArgs e)
        {
            dgvQuestion.DataSource = questionBusiness.GetAllQuestions();
        }

        private void dgvQuestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvQuestion.Rows[e.RowIndex];
            txtTitle.Text = row.Cells["Title"].Value.ToString();
            txtAnswer1.Text = row.Cells["Answer1"].Value.ToString();
            txtAnswer2.Text = row.Cells["Answer2"].Value.ToString();
            txtAnswer3.Text = row.Cells["Answer3"].Value.ToString();
            txtAnswer4.Text = row.Cells["Answer4"].Value.ToString();

            string result = row.Cells["Result"].Value.ToString();
            rdoA1.Checked = result == txtAnswer1.Text;
            rdoA2.Checked = result == txtAnswer2.Text;
            rdoA3.Checked = result == txtAnswer3.Text;
            rdoA4.Checked = result == txtAnswer4.Text;

            oldTitle = txtTitle.Text;
        }

        private Question CreateQuestion()
        {
            return new Question()
            {
                Id = Guid.NewGuid().ToString(),
                Title = txtTitle.Text.Trim(),
                Answer1 = txtAnswer1.Text.Trim(),
                Answer2 = txtAnswer2.Text.Trim(),
                Answer3 = txtAnswer3.Text.Trim(),
                Answer4 = txtAnswer4.Text.Trim(),
                Result = rdoA1.Checked ? txtAnswer1.Text :
                         rdoA2.Checked ? txtAnswer2.Text :
                         rdoA3.Checked ? txtAnswer3.Text : txtAnswer4.Text
            };
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Question question = CreateQuestion();
            question.Id = ""; // Không đổi ID khi edit

            try
            {
                questionBusiness.EditQuestion(oldTitle, question);
                dgvQuestion.DataSource = null;
                dgvQuestion.DataSource = questionBusiness.GetAllQuestions();
                MessageBox.Show("Question updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Question q = CreateQuestion();
            if (questionBusiness.AddQuestion(q))
            {
                dgvQuestion.DataSource = null;
                dgvQuestion.DataSource = questionBusiness.GetAllQuestions();
                MessageBox.Show("Added successfully!");
            }
        }
    }
}
