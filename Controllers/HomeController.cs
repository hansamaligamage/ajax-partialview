using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ajaxPartial.Models;

namespace ajaxPartial.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = Student.GetStudents(new StudentFilter());
            return View(students);
        }

        [HttpPost]
        public IActionResult Students (StudentFilter filters)
        {
            List<Student> students = Student.GetStudents(filters);
            return PartialView("_Students", students);
        }
    }
}
