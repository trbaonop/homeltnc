using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MultipleChoise.Entity;
using MultipleChoise.Utils;

namespace MultipleChoise.DAO
{
    public class QuestionDAO
    {
        private List<Question> questions = new List<Question>();
        private string fileName = Path.Combine(Application.StartupPath, "question.csv");

        public List<Question> GetAll()
        {
            questions.Clear();
            if (!File.Exists(fileName)) return questions;

            using (StreamReader dr = new StreamReader(fileName))
            {
                while (!dr.EndOfStream)
                {
                    string st = dr.ReadLine();
                    if (string.IsNullOrWhiteSpace(st)) continue;
                    string[] p = st.Split(';'); // fix: đồng bộ dấu ';'

                    if (p.Length >= 7)
                    {
                        questions.Add(new Question()
                        {
                            Id = p[0],
                            Title = p[1],
                            Answer1 = p[2],
                            Answer2 = p[3],
                            Answer3 = p[4],
                            Answer4 = p[5],
                            Result = p[6]
                        });
                    }
                }
            }
            return questions;
        }

        public void AddQuestion(Question q)
        {
            q.Title = ManageUltimate.NomalizationString(q.Title);
            questions.Add(q);
        }

        public void SaveToFile()
        {
            using (StreamWriter wr = new StreamWriter(fileName, false))
            {
                foreach (Question q in questions)
                {
                    wr.WriteLine($"{q.Id};{q.Title};{q.Answer1};{q.Answer2};{q.Answer3};{q.Answer4};{q.Result}");
                }
            }
        }

        public void EditQuestion(string oldTitle, Question q)
        {
            Question que = GetQuestionByTitle(oldTitle);
            if (que != null)
            {
                que.Title = q.Title;
                que.Answer1 = q.Answer1;
                que.Answer2 = q.Answer2;
                que.Answer3 = q.Answer3;
                que.Answer4 = q.Answer4;
                que.Result = q.Result;
            }
        }

        public Question GetQuestionById(string id)
        {
            return questions.FirstOrDefault(q => q.Id.Trim().ToLower() == id.Trim().ToLower());
        }

        public Question GetQuestionByTitle(string title)
        {
            return questions.FirstOrDefault(q => q.Title.Trim().ToLower() == title.Trim().ToLower());
        }
    }
}
