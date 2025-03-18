namespace Basics.Models
{

    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>(){
                new Course() {Id = 1, Title = "Aspnet Kursu", Description = "Kursumuz başladı.",Image = "1.png"},
                new Course() {Id = 2, Title = "Backend Kursu", Description = "Kursumuz başladı.",Image = "2.png"},
                new Course() {Id = 3, Title = "Game Kursu", Description = "Kursumuz başladı.",Image = "3.jpg"},
            };
        }

        public static List<Course> Courses
        {
            get { return _courses; }
        }
    }
}