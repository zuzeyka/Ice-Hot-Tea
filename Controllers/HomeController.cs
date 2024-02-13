using Slush.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Slush.Data;
using Slush.Data.Entity;

namespace Slush.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _dataContext;
        public HomeController(ILogger<HomeController> logger, DataContext dataContext)
        {
            _logger = logger;
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HandleFormData(string name, string description)
        {
            var category = new Categories
            {
                id = Guid.NewGuid(),
                name = name,
                description = description
            };

            _logger.LogInformation(_dataContext.Database.CanConnect().ToString());

            _dataContext.dbCategories.Add(category);
            _dataContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
