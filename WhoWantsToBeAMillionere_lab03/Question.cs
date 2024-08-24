using System;
using Dapper;

namespace WhoWantsToBeAMillionere_lab03
{
    public class Question
    {
        public string Text { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public int RightAnswer { get; set; }
        public int Level { get; set; }

        public Question() { }

        [Dapper.ExplicitConstructor]
        public Question(string text, string answer1, string answer2, string answer3, string answer4, int rightAnswer, int level)
        {
            Text = text;
            Answer1 = answer1;
            Answer2 = answer2;
            Answer3 = answer3;
            Answer4 = answer4;
            RightAnswer = rightAnswer;
            Level = level;
        }
    }
}
