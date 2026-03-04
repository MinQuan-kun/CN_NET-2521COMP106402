using Buoi04.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buoi04.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Employee employee)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Dữ liệu không hợp lệ. Vui lòng kiểm tra lại.");
                return View(employee);
            }
            return View();
        }
        public IActionResult CheckEmployeeNoExists(string employeeNo)
        {
            // Giả sử bạn có một danh sách nhân viên để kiểm tra
            var existingEmployeeNos = new List<string> { "EMP001", "EMP002", "EMP003" };
            if (existingEmployeeNos.Contains(employeeNo))
            {
                return Json($"Mã nhân viên {employeeNo} đã tồn tại.");
            }
            return Json(true);
        }
    }
}
