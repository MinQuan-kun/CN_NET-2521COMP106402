using Buoi02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buoi02.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>()
        {
            new Product(){
                MaHH=1, TenHH="Iphone 14 Pro Max", Hinh="iphone14promax.jpg", DonGia=30990000, SoLuongTon=50
            },
            new Product(){
                MaHH=2, TenHH="Iphone 14 Pro Max", Hinh="iphone14promax.jpg", DonGia=30990000, SoLuongTon=50
            },
        };

        public IActionResult Index()
        {
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            var product = products.SingleOrDefault(p => p.MaHH == id);
            if (product != null)
            {
                products.Remove(product);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var product = products.SingleOrDefault(p => p.MaHH == id);
            if (product != null)
            {
                return View(product);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(int id, Product model)
        {
            var product = products.SingleOrDefault(p => p.MaHH == id);
            if (product != null)
            {
                return View(product);
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Product model)
        {
            var product = products.SingleOrDefault(p => p.MaHH == model.MaHH);
            if (product != null)
            {
                products.Remove(product);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(Product model, IFormFile UploadHinh)
        {
            var product = products.SingleOrDefault(p => p.MaHH == model.MaHH);
            if(UploadHinh != null)
            {
                var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", UploadHinh.FileName);
                using (var stream = new FileStream(fullPath, FileMode.CreateNew))
                {
                    UploadHinh.CopyTo(stream);
                    model.Hinh = UploadHinh.FileName;
                }
            }
            if (product == null)
            {
                products.Add(model);
                return RedirectToAction("Index");
            }

            ViewBag.ThongBao = $"Đã có mã {model.MaHH} rồi";
            return View(model);
        }
    }
}
