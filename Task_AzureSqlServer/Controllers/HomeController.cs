using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using System.Text.Json;
using Task_AzureSqlServer.Entity;
using Task_AzureSqlServer.Service;
using Task_AzureSqlServer.Service.Abstract;

namespace Task_AzureSqlServer.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _service;

        public HomeController(IRepository service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(new HomeViewModel
            {
                Categories = _service.GetCategories(),
                Products = _service.GetProductsForCategory(ClassHelper.SelectedCategoryId),
            });
        }


        public JsonResult ReturnJsonProducts(int categoryId)
        {
            JsonSerializerOptions options = new()
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles,
                WriteIndented = true
            };

            if (categoryId > 0)
            {
                ClassHelper.SelectedCategoryId = categoryId;
            }
            var jsonData = _service.GetProductsForCategory(ClassHelper.SelectedCategoryId);
            return Json(jsonData, options);
        }
    }
}
