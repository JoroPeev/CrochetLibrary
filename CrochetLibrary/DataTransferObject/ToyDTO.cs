namespace CrochetLibrary.DTOs
{
    public class ToyDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Colors { get; set; } = "Red, Blue, Green";
        public int Stock { get; set; }
    }
}