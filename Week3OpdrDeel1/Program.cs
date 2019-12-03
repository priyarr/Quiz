using System;

namespace Week3OpdrDeel1
{
    class Program
    {
        static void Main(string[] args)
        {
            var FirstQuesiton = new Question() { Text = "Who is the inventor of C#?", Answer = "Microsoft" };
            PresentQuestion(FirstQuesiton);
        }

        public static void PresentQuestion(Question q)
        {
            Console.WriteLine(q.Text);
            Console.WriteLine("Your answer: ");
            string Answer = Console.ReadLine();
            Console.WriteLine("That is " + CheckAnswer(q, Answer));
            Console.ReadKey();


        }

        public static Boolean CheckAnswer(Question q, string GivenAnswer)
        {
            string CorrectAnswer = q.Answer;
            if(GivenAnswer == CorrectAnswer)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }

    public class Question
    {
        public string Text { get; set; }
        public string Answer { get; set; }



    }
}
