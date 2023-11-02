namespace BethanysPieShop.Models
{
    public class Category
    {
        // Unique identifier for the category.
        public int CategoryId { get; set; }

        // The name of the category.
        public string CategoryName { get; set; } = string.Empty;

        // A description of the category (nullable).
        public string? Description { get; set; }

        // A collection of pies associated with this category (nullable).
        public List<Pie>? Pies { get; set; }
    }
}
