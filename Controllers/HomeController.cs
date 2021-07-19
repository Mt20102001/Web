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

        public IActionResult Edit()
        {
            var model = new ProductEditModel();
            model.Name = "Test";
            return View(model);
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

        [HttpPost]
        public IActionResult Edit(ProductEditModel model)
        {
            string messageEdit = string.Empty;
            if (ModelState.IsValid)
            {
                messageEdit = "Product: ID: " + model.ID + ", Name: " + model.Name + ", Rate: " + model.Rate + ", Rating: " + model.Rating + " create successfully.";
            }
            else
            {
                messageEdit = "Failed to create the product. Please try again.";
            }
            return Content(messageEdit);
        }
    }
}