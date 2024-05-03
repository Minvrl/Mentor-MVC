namespace Mentor_MVC.Models
{
    public class Feature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Price> Prices { get; set; } 
    }
}
