namespace BethanysPieShop.Models
{
    public interface ICategoryRepository
    {
        // Defines a property that represents an enumerable list of all categories.
        IEnumerable<Category> AllCategories { get; }
    }
}
