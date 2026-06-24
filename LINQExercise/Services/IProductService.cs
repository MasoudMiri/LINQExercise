using LINQExercise.Models;

namespace LINQExercise.Services
{
    public interface IProductService
    {
        // ===== داده‌های خام =====
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(Categories category);

        // ===== محاسبات =====
        Product? GetMostExpensiveProduct();
        decimal GetTotalPrice();
        double GetAveragePrice();
        IEnumerable<IGrouping<Categories, Product>> GetProductsGroupedByCategory();
    }
}