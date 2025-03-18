using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers{

    public class CourseController : Controller{

        public IActionResult Index(){
            var kurs = new Course();
            kurs.Id = 1;
            kurs.Title = "Acun Medya Akademi C# Eğitimi";
            kurs.Description = "Eğitimimiz Şubat ayında başladı. 6 Ay sürecektir.";
            kurs.Image = "1.png";
            return View(kurs);
        }

        public IActionResult List(){
            return View(Repository.Courses);
        }
    }
}