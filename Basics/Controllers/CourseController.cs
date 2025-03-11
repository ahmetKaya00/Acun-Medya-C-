using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers{

    public class CourseController : Controller{

        public IActionResult Index(){
            var kurs = new Course();
            kurs.Id = 1;
            kurs.Title = "Acun Medya Akademi C# Eğitimi";
            kurs.Description = "Eğitimimiz Şubat ayında başladı. 6 Ay sürecektir.";
            return View(kurs);
        }

        public IActionResult List(){
            var kurslar = new List<Course>(){
                new Course() {Id = 1, Title = "Aspnet Kursu", Description = "Kursumuz başladı."},
                new Course() {Id = 2, Title = "Backend Kursu", Description = "Kursumuz başladı."},
                new Course() {Id = 3, Title = "Game Kursu", Description = "Kursumuz başladı."},
                new Course() {Id = 4, Title = "Django Kursu", Description = "Kursumuz başladı."},
            };
            return View(kurslar);
        }
    }
}