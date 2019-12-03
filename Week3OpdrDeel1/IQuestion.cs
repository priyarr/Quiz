namespace Week3OpdrDeel1
{
    public interface IQuestion
    {
        string Text { get; set; }
        string Answer { get; set; }
        int Difficulty { get; set; }
        void Print();
        //string ToString();
    }

    
}
