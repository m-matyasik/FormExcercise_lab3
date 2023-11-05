using FormExcercise.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FormExcercise.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RegisterForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterForm(Data data) 
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return View("Result", data);
        }

        public IActionResult Result(Data data) 
        {
            return View(data);
        }

    }
}
