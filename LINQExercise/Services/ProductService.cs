using LINQExercise.Data;
using LINQExercise.Models;

namespace LINQExercise.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> GetAllProducts() => _repository.GetAll();
        public IEnumerable<Product> GetProductsByCategory(Categories category) => _repository.GetByCategory(category);

        public Product? GetMostExpensiveProduct()
        {
            return _repository.GetAll().OrderByDescending(p => p.Price).FirstOrDefault();
        }

        public decimal GetTotalPrice()
        {
            return _repository.GetAll().Sum(p => p.Price);
        }

        public double GetAveragePrice()
        {
            return _repository.GetAll().Average(p => (double)p.Price);
        }

        public IEnumerable<IGrouping<Categories, Product>> GetProductsGroupedByCategory()
        {
            return _repository.GetAll().GroupBy(p => p.Category);
        }
    }
}