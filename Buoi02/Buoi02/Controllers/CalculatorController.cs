using Microsoft.AspNetCore.Mvc;

namespace Buoi02.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Calculate(double SoHang01 = 0, double SoHang02 = 0, char op = '+')
        {
            switch (op)
            {
                case '+':
                    ViewBag.KetQua = SoHang01 + SoHang02;
                    break;
                case '-':
                    ViewBag.KetQua = SoHang01 - SoHang02;
                    break;
                case 'x':
                    ViewBag.KetQua = SoHang01 * SoHang02;
                    break;
                case ':':
                    ViewBag.KetQua = SoHang01 / SoHang02;
                    break;
            }
            ViewBag.So01 = SoHang01;
            ViewBag.So02 = SoHang02;
            ViewBag.PhepToan = op;
            ViewBag.KetQua = ViewBag.KetQua;
            return View("Index");
        }
    }
}
