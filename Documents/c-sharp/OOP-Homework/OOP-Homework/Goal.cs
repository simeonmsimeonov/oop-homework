namespace OOP_Homework
{
    public class Goal
        
    {
        public double Minute { get; set; }
        public footballPlayer Player { get; set; }
        public Goal(double minute, footballPlayer player)
        {
            Minute = minute;
            Player = player;
        }
       
    }
}