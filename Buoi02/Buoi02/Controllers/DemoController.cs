using Microsoft.AspNetCore.Mvc;

namespace Buoi02.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ABC()
        {
            return Redirect("/Home/Privacy");
        }
        
        public IActionResult XYZ()
        {
            return RedirectToAction("Privacy", "Home");
        }

        public IActionResult MyAPI()
        {
            return Json(new { Name = "Nguyen Van A", Age = 30 });
        }
    }
}
