using JarvisWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace JarvisWeb.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new Student()
            {
                Id = 1,
                Name = "Afida",
                Addres = "Salatiga"
            };

            return View(student);
        }
    }
}
