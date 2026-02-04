using System.Diagnostics;
using DemoBuoi3.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoBuoi3.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult DemoSync()
        {
            var sw = new Stopwatch();
            sw.Start();
            Demo.A();
            Demo.B();
            Demo.C();
            sw.Stop();
            return Content($"Chạy hết {sw.ElapsedMilliseconds}ms");
        }

        public async Task<IActionResult> DemoAS()
        {
            var sw = new Stopwatch();
            sw.Start();
            var a = Demo.AA();
            var b = Demo.BB();
            var c = Demo.CC();
            await a; await b; await c;
            //Task.WaitAll();
            sw.Stop();
            return Content($"Chạy hết {sw.ElapsedMilliseconds}ms");
        }
    }
}
