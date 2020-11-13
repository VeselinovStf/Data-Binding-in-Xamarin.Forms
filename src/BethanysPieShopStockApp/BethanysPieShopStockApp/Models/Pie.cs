namespace BethanysPieShopStockApp.Models
{
    public class Pie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; internal set; }
        public bool InStock { get; set; }
        public string ImageURI { get; set; }
    }
}
