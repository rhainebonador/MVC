using Microsoft.AspNetCore.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Name = "Rhaine",
                    Age = 19,
                    Course = "Computer Science"
                },

                new Student
                {
                    Name = "Marizza",
                    Age = 19,
                    Course = "Computer Science"
                }
            };

            return View(students);
        }
    }
}