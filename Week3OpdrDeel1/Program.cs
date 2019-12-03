using System;
using System.Collections.Generic;

namespace Week3OpdrDeel1
{
    class Program
    {
        static void Main(string[] args)
        {
            var FirstQuesiton = new Question() { Text = "Who is the inventor of C#?", Answer = "Microsoft" };
            //PresentQuestion(FirstQuesiton);

            var MQuestion = new MupltipleChoiceQuestion()
            {
                Text = "In which country was the inventor of C# born?",
                Answer = "America"
            };

            var Choice1 = new Choice() { Answer = true, Option = "America" };
            var Choice2 = new Choice() { Answer = false, Option = "India" };
            var Choice3 = new Choice() { Answer = false, Option = "Spain" };

            MQuestion.Choices = new List<Choice> { Choice1, Choice2, Choice3 };
            PresentQuestion(MQuestion);
        }

        public static void PresentQuestion(IQuestion q)
        {
            q.Print();
            Console.WriteLine("Your answer: ");
            string Answer = Console.ReadLine();
            Console.WriteLine("That is " + CheckAnswer(q, Answer));
            Console.ReadKey();


        }

        public static Boolean CheckAnswer(IQuestion q, string GivenAnswer)
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

        public static void Display(IQuestion q)
        {
            q.Print();
            
        }
    }

    public interface IQuestion
    {
        string Text { get; set; }
        string Answer { get; set; }
        void Print();
    }

    public class Question : IQuestion
    {
        public string Text { get; set; }
        public string Answer { get; set; }
        public void Print()
        {
            Console.WriteLine(Text);
        }
    }

    public class MupltipleChoiceQuestion : IQuestion
    {
        public string Text { get; set; }
        public List<Choice> Choices { get; set; }
        public string Answer { get; set; }
        public void AddChoice(Choice choice)
        {
            Choices.Add(choice);
        }

        public void Print()
        {
            Console.WriteLine(Text);
            foreach(Choice choice in Choices)
            {
                Console.WriteLine(choice.Option);
            }
        }

    }

    public class Choice
    {
        public string Option { get; set; }
        public Boolean Answer { get; set; }
    }

    
}
