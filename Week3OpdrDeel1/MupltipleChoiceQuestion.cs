using System;
using System.Collections.Generic;

namespace Week3OpdrDeel1
{
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

    
}
