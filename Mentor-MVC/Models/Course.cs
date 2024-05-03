namespace Mentor_MVC.Models
{
    public class Course
    {
        public int Id { get; set; }
        public int TrainerId { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public int Fee { get; set;}
        public string Title { get; set; }
        public string Description { get; set; }
        public Trainer Trainer { get; set; }

    }
}
