using Microsoft.AspNetCore.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student student = new Student();

            student.Name = "Rhaine";
            student.Age = 19;
            student.Course = "Computer Science";

            return View(student);
        }
    }
}