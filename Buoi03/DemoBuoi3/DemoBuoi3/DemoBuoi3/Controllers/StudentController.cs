using DemoBuoi3.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoBuoi3.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student model, IFormFile Hinh)
        {
            if (Hinh != null)
            {
                var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", Hinh.FileName);
                using (var f = new FileStream(fullPath, FileMode.CreateNew))
                {
                    Hinh.CopyTo(f);
                    model.Image = Hinh.FileName;
                }
            }
            return View("Profile", model);
        }


    }
}