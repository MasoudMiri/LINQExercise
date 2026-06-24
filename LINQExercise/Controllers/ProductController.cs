using Microsoft.AspNetCore.Mvc;
using LINQExercise.Services;
using LINQExercise.Models;

namespace LINQExercise.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View(_productService.GetAllProducts());
        }

        public IActionResult GetByCategory()
        {
            var products = _productService.GetProductsByCategory(Categories.Category1);
            return PartialView("_AnswerModal", new
            {
                Title = "محصولات دسته Category1",
                Data = products.Select(p => new { p.Id, p.Name, Category = (int)p.Category, p.Price })
            });
        }

        public IActionResult GetMostExpensive()
        {
            var product = _productService.GetMostExpensiveProduct();
            return PartialView("_AnswerModal", new
            {
                Title = "گران‌ترین محصول",
                Data = product != null ? new { product.Id, product.Name, Category = (int)product.Category, product.Price } : null
            });
        }

        public IActionResult GetTotalPrice()
        {
            var total = _productService.GetTotalPrice();
            return PartialView("_AnswerModal", new
            {
                Title = "مجموع قیمت تمام محصولات",
                Data = new { TotalPrice = total }
            });
        }

        public IActionResult GetGroupedByCategory()
        {
            var grouped = _productService.GetProductsGroupedByCategory();
            return PartialView("_AnswerModal", new
            {
                Title = "گروه‌بندی بر اساس دسته",
                Data = grouped.Select(g => new
                {
                    Category = g.Key.ToString(),
                    Products = g.Select(p => new { p.Id, p.Name, p.Price })
                })
            });
        }

        public IActionResult GetAveragePrice()
        {
            var avg = _productService.GetAveragePrice();
            return PartialView("_AnswerModal", new
            {
                Title = "میانگین قیمت محصولات",
                Data = new { AveragePrice = avg }
            });
        }
    }
}