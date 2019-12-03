using System;
using System.Collections.Generic;
using System.Linq;

namespace Week3OpdrDeel1
{
    class Program
    {
        static void Main(string[] args)
        {
            var FirstQuesiton = new Question()
            {
                Text = "Who is the inventor of C#?",
                Answer = "Microsoft",
                Difficulty = 4

            };

            var SecondQuestion = new Question()
            {
                Text = "What day comes after monday?",
                Answer = "Tuesday",
                Difficulty = 1
            };

            var ThirdQuestion = new Question()
            {
                Text = "Is lo-fi a music genre or a movie genre?",
                Answer = "Music genre",
                Difficulty = 3
            };

            var FourthQuestion = new Question()
            {
                Text = "Who discovered America",
                Answer = "Colombus",
                Difficulty = 2,
            };

            var MQuestion1 = new MupltipleChoiceQuestion()
            {
                Text = "In which country was the inventor of C# born?",
                Answer = "America",
                Difficulty = 4
                
            };
            var Choice1 = new Choice() { Answer = true, Option = "America" };
            var Choice2 = new Choice() { Answer = false, Option = "India" };
            var Choice3 = new Choice() { Answer = false, Option = "Spain" };
            MQuestion1.Choices = new List<Choice> { Choice1, Choice2, Choice3 };

            var MQuestion2 = new MupltipleChoiceQuestion()
            {
                Text = "Which one is a vegatable?",
                Answer = "Carrot",
                Difficulty = 1

            };
            var Q2Choice1 = new Choice() { Answer = true, Option = "Carrot" };
            var Q2Choice2 = new Choice() { Answer = false, Option = "Tomtato" };
            var Q2Choice3 = new Choice() { Answer = false, Option = "Apple" };
            MQuestion2.Choices = new List<Choice> { Q2Choice1, Q2Choice2, Q2Choice3 };

            var AllQuestions = new List<IQuestion>()
            {
                FirstQuesiton,
                SecondQuestion,
                ThirdQuestion,
                FourthQuestion,
                MQuestion1,
                MQuestion2
            };

            PresentQuestionOnDifficulty(AllQuestions);

        }

        public static IEnumerable<IQuestion> SortQuestionsOnDifficulty(List<IQuestion> questions)
        {
            return questions.OrderBy(q => q.Difficulty);
        }

        public static IQuestion GetQuestionByDifficulty(IEnumerable<IQuestion> questions, int difficulty)
        {
            var questionsWithChosenDifficulty = questions.Where(q => q.Difficulty.Equals(difficulty));
            int amount = questionsWithChosenDifficulty.Count();
            Random r = new Random();
            int RandomIndex = r.Next(0, amount);
            return questionsWithChosenDifficulty.ElementAt(RandomIndex);
        }

        public static void PresentQuestion(IQuestion q)
        {
            q.Print();
            Console.WriteLine("Your answer: ");
            string Answer = Console.ReadLine();
            Console.WriteLine("That is " + CheckAnswer(q, Answer));
            Console.ReadKey();


        }

        public static void PresentQuestionOnDifficulty(IEnumerable<IQuestion> questions)
        {
            Console.WriteLine("Choose a difficulty: ");
            int ChosenDifficulty = int.Parse(Console.ReadLine());

            IQuestion question = GetQuestionByDifficulty(questions, ChosenDifficulty);
            question.Print();
            Console.WriteLine("Your answer: ");
            string Answer = Console.ReadLine();
            Console.WriteLine("That is " + CheckAnswer(question, Answer));

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
        int Difficulty { get; set; }
        void Print();
        //string ToString();
    }

    public class Question : IQuestion
    {
        public string Text { get; set; }
        public string Answer { get; set; }
        public int Difficulty { get; set; }
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
        public int Difficulty { get; set; }
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
