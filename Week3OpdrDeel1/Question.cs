using System;

namespace Week3OpdrDeel1
{
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

    
}
