namespace BethanysPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        // Implement the "AllCategories" property defined in the ICategoryRepository interface.
        public IEnumerable<Category> AllCategories =>
            // Return a new list of Category objects, representing different categories of pies.
            new List<Category>
            {
                // Create a Category object for "Fruit pies" with an ID and description.
                new Category{CategoryId=1, CategoryName="Fruit pies", Description="All fruity pies"},

                // Create a Category object for "Chees cakes" with an ID and description.
                new Category{CategoryId=2,CategoryName="Cheese cakes", Description="Cheesy all the way"},

                // Create a Category object for "Seasonal pies" with an ID and description.
                new Category{CategoryId=3, CategoryName="Seasonal pies", Description="Get in the mood for a seasonal pie"},
            };
    }
}
