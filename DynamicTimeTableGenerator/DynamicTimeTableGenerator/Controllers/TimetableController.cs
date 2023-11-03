using DynamicTimeTableGenerator.Models;
using Microsoft.AspNetCore.Mvc;

namespace DynamicTimeTableGenerator.Controllers
{
    public class TimetableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Generate(Timetable_Entity input, List<Subject> subjects)
        {
            if (!ModelState.IsValid)
            {
                
                return View("Index", input);
            }
            int totalHoursForWeek = input.WorkingDays * input.SubjectsPerDay;
            int totalSubjectHours = input.TotalSubjects * totalHoursForWeek;
            if (totalSubjectHours != totalHoursForWeek)
            {
                ModelState.AddModelError("subjects", "Total subject hours must match the total hours for the week.");
                return View("Index", input);
            }
            List<List<string>> timetable = GenerateTimetable(input, subjects);
            return View("Timetable", timetable);
        }
        private List<List<string>> GenerateTimetable(Timetable_Entity input, List<Subject> subjects)
        {
            var timetable = new List<List<string>>
        {
            new List<string> { "Gujarati", "Maths", "Science", "Science", "Gujarati" },
            new List<string> { "English", "Maths", "Maths", "Maths", "English" },
            new List<string> { "Science", "Gujarati", "English", "English", "Science" },
            new List<string> { "Maths", "Science", "Maths", "Science", "Maths" }
        };

            return timetable;
           
        }
    }
}
