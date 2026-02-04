using Microsoft.AspNetCore.Mvc;

namespace DemoBuoi3.Controllers
{
    public class UploaderController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UploadFile(IFormFile myfile)
        {
            if(myfile == null)
            {
                ViewBag.Message = "Chưa chọn file để upload";
            }
            else
            {
                var fullpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot","data", myfile.FileName);
                using (var stream = new FileStream(fullpath, FileMode.Create))
                {
                    myfile.CopyTo(stream);
                }
            }
            return View("Index");
        }
        public IActionResult UploadFiles(List<IFormFile> myfiles)
        {
            if (myfiles == null || myfiles.Count == 0)
            {
                ViewBag.Message = "Chưa chọn file để upload";
            }
            else
            {
                foreach (var myfile in myfiles)
                {
                    var fullpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", myfile.FileName);
                    using (var stream = new FileStream(fullpath, FileMode.Create))
                    {
                        myfile.CopyTo(stream);
                    }
                }

            }
            return View("Index");

        }
    }
}
