using Microsoft.AspNetCore.Mvc;
using HTML_Form_Basic.Model;

namespace HTML_Form_Basic.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductEditModel model)
        {
            string message = string.Empty;
            if (ModelState.IsValid)
            {
                message = "Product: " + model.Name + ", Rate: " + model.Rate + ", Rating: " + model.Rating + " create successfully.";
            }
            else
            {
                message = "Failed to create the product. Please try again.";
            }
            return Content(message);
        }
    }
}