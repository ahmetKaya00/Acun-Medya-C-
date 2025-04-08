namespace Basics.Models
{

    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>(){
                new Course() {Id = 1, Title = "Aspnet Kursu", Description = "Kursumuz başladı.",Image = "1.png", isActive = true, isHome = true},
                new Course() {Id = 2, Title = "Backend Kursu", Description = "Kursumuz başladı.",Image = "2.png", isActive = false, isHome = true},
                new Course() {Id = 3, Title = "Game Kursu", Description = "Kursumuz başladı.",Image = "3.jpg", isActive = true, isHome = false},
            };
        }

        public static List<Course> Courses
        {
            get { return _courses; }
        }

        public static Course? GetById(int? id){
            return _courses.FirstOrDefault(c=>c.Id == id);
        }
    }
}