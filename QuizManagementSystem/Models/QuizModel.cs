namespace QuizManagementSystem.Models
{
    public class QuizModel
    {
        public int QuizId { get; set; }
        public string? QuizTitle { get; set; }
        public string? Category { get; set; }
        public int NoOfQuestion { get; set; }
        public int Maxmarks { get; set; }
        public string? Totaltime{ get; set; }


       
    }
}
