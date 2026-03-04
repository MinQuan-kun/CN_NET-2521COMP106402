using Buoi04.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buoi04.Controllers
{
    public class DemoController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Person person)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Dữ liệu không hợp lệ. Vui lòng kiểm tra lại.");
            }
            return View();
        }
    }
}
