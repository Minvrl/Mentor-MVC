using System.Runtime.CompilerServices;

namespace Mentor_MVC.Models
{
    public class Price
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Fee { get; set; }
        public bool IsAdvanced { get; set; }  
        public bool IsFeatured { get; set; }
        public string ButtonURL { get; set; }
        public List<Feature> Features { get; set; }    
    }
}
