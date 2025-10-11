using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultipleChoise.Entity;
using MultipleChoise.DAO;
using MultipleChoise.Interface;

namespace MultipleChoise.BUS
{
    public class QuestionBus : IQuestionBus
    {
        QuestionDAO questionDAO;
        public QuestionBus()
        {
            questionDAO = new QuestionDAO();
        }
        public bool AddQuestion(Question q)
        {
            try
            {
                //chuan hoa du lieu
                var question = new Question();
                question.Id = q.Id.Trim();
                question.Title = q.Title.Trim();
                question.Answer1 = q.Answer1.Trim();
                question.Answer2 = q.Answer2.Trim();
                question.Answer3 = q.Answer3.Trim();
                question.Answer4 = q.Answer4.Trim();
                question.Result = q.Result.Trim();
                if (string.IsNullOrEmpty(question.Id) || string.IsNullOrEmpty(question.Title) ||
                    string.IsNullOrEmpty(question.Answer1) || string.IsNullOrEmpty(question.Answer2) ||
                    string.IsNullOrEmpty(question.Answer3) || string.IsNullOrEmpty(question.Answer4) ||
                    string.IsNullOrEmpty(question.Result))
                {
                    MessageBox.Show("All fields are required.");
                    return false;
                }
                questionDAO.AddQuestion(question);
                questionDAO.SaveToFile();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding question: " + ex.Message);
                return false;
            }
        }
        public List<Question> GetAllQuestions()
        {
            return questionDAO.GetAll();
        }

        public bool EditQuestion(string oldTitle, Question question)
        {
            questionDAO.EditQuestion(oldTitle, question);
            Question q = questionDAO.GetQuestionByTitle(question.Title);
            if (oldTitle == question.Title || q == null)
            {
                questionDAO.EditQuestion(oldTitle, question);
                questionDAO.SaveToFile();
                return true;
            }
            else
                if (q != null)
                    throw new Exception("Question Title is existed");
                return false;
        }

    }
}
