using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MultipleChoise.Entity;
using MultipleChoise.DAO;
using MultipleChoise.Interface;

namespace MultipleChoise.BUS
{
    public class QuestionBus : IQuestionBusiness
    {
        private QuestionDAO questionDAO;

        public QuestionBus()
        {
            questionDAO = new QuestionDAO();
        }

        public bool AddQuestion(Question q)
        {
            try
            {
                // Chuẩn hóa dữ liệu
                var question = new Question()
                {
                    Id = q.Id?.Trim(),
                    Title = q.Title?.Trim(),
                    Answer1 = q.Answer1?.Trim(),
                    Answer2 = q.Answer2?.Trim(),
                    Answer3 = q.Answer3?.Trim(),
                    Answer4 = q.Answer4?.Trim(),
                    Result = q.Result?.Trim()
                };

                if (string.IsNullOrEmpty(question.Id) || string.IsNullOrEmpty(question.Title) ||
                    string.IsNullOrEmpty(question.Answer1) || string.IsNullOrEmpty(question.Answer2) ||
                    string.IsNullOrEmpty(question.Answer3) || string.IsNullOrEmpty(question.Answer4) ||
                    string.IsNullOrEmpty(question.Result))
                {
                    MessageBox.Show("All fields are required.");
                    return false;
                }

                // Kiểm tra trùng ID hoặc Title
                var existed = questionDAO.GetQuestionByTitle(question.Title);
                if (existed != null)
                {
                    MessageBox.Show("This question already exists!");
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
            var existed = questionDAO.GetQuestionByTitle(question.Title);
            if (existed != null && oldTitle != question.Title)
            {
                throw new Exception("Question title already exists.");
            }

            questionDAO.EditQuestion(oldTitle, question);
            questionDAO.SaveToFile();
            return true;
        }
    }
}
