using System.ComponentModel.DataAnnotations;

namespace DynamicTimeTableGenerator.Models
{
    public class Timetable_Entity
    {
        [Required]
        [Range(1, 7)]
        public int WorkingDays { get; set; }

        [Required]
        [Range(1, 8)]
        public int SubjectsPerDay { get; set; }

        [Required]
        [Range(1, 100)]
        public int TotalSubjects { get; set; }
    }
}

    

