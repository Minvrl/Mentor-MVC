namespace Mentor_MVC.Models
{
    public class FeaturePrice
    {
        public int Id { get; set; }
        public int PriceId { get; set; }
        public int FeatureId { get; set; }
        public Price Price { get; set; }
        public Feature Feature { get; set; }
    }
}
