namespace Mentor_MVC.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Image {  get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public string Description { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
        public List<Course> Courses { get; set; }   


    }
}
