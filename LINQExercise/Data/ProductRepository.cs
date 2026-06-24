using LINQExercise.Models;

namespace LINQExercise.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Product A", Category = Categories.Category1, Price = 100 },
                new Product { Id = 2, Name = "Product B", Category = Categories.Category1, Price = 150 },
                new Product { Id = 3, Name = "Product C", Category = Categories.Category2, Price = 120 },
                new Product { Id = 4, Name = "Product D", Category = Categories.Category3, Price = 200 },
                new Product { Id = 5, Name = "Product E", Category = Categories.Category1, Price = 80 }
            };
        }

        public IEnumerable<Product> GetAll() => _products;
        public IEnumerable<Product> GetByCategory(Categories category) => _products.Where(p => p.Category == category);
    }
}