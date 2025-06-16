public class ToyDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public double Price { get; set; }
    public string Colors { get; set; } = string.Empty;
    public int Stock { get; set; }
    public List<ToyImageDto> Images { get; set; } = new List<ToyImageDto>();
    public string PrimaryImageUrl { get; set; } = string.Empty;

    public List<string> ImageUrls => Images
        .OrderBy(i => i.DisplayOrder)
        .Select(i => i.ImageUrl)
        .ToList();
}
