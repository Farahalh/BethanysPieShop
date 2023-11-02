using System.ComponentModel;

namespace BethanysPieShop.Models
{
    public class Pie
    {
        // Unique identifier for the pie.
        public int PieId { get; set; }

        // The name of the pie.
        public string Name { get; set; } = string.Empty;

        // A short description of the pie (nullable).
        public string? ShortDescription { get; set; }

        // A longer description of the pie (nullable).
        public string? LongDescription { get; set; }

        // Information about allergies realted to the pie (nullable).
        public string? AllergyInformation { get; set; }

        // The price of the pie.
        public decimal Price { get; set; }

        // URL for the main image of the pie (nullable).
        public string? ImageUrl { get; set; }

        // URL for a thumbnail image of the pie (nullable).
        public string? ImageThumbnailUrl { get; set; }

        // Indicates wheater the pie is the "Pie of the week".
        public bool IsPieOfTheWeek { get; set; }

        // Indicates whaeter the pie is in stock.
        public bool InStock { get; set; }

        // The ID of the category to which the pie belongs.
        public int CategoryId { get; set; }

        // Navigation poroperty representing the category to which the pie belongs.
        public Category Category { get; set; } = default!;
    }
}
