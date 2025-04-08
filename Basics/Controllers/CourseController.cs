using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers{

    public class CourseController : Controller{

        public IActionResult Index(){
            return View(Repository.Courses);
        }
        public IActionResult List(){
            return View(Repository.Courses);
        }
        public IActionResult Details(int? id){
            if(id == null){
                return Redirect("/course/list");
            }
            var kurs = Repository.GetById(id);
            return View(kurs);
        }
    }
}