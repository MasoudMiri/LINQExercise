using LINQExercise.Models;

namespace LINQExercise.Data
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetByCategory(Categories category);
    }
}