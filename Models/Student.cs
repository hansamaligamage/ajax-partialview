using System.Collections.Generic;
using System.Linq;

namespace ajaxPartial.Models
{
    public class Student
    {

        public string Name { get; set; }
        public int CourseId { get; set; }
        public string Course { get; set; }
        public string Lab { get; set; }
        public double Marks { get; set; }


        public static List<Student> GetStudents (StudentFilter filters)
        {
            var students = new List<Student>() {
                new Student { Name = "Hank Aaron", CourseId = 1, Course = "Computer Architecture", Lab = "Lab 01", Marks = 84},
                new Student{ Name = "Alfred Adler", CourseId = 2, Course = "Database Systems", Lab = "Lab 02", Marks = 70 }, 
                new Student { Name = "Conrad Aiken", CourseId = 1, Course = "Computer Architecture", Lab = "Lab 03", Marks = 73 }, 
                new Student { Name = "Buzz Aldrin", CourseId = 3, Course = "Data Structure and Algorithms", Lab = "Lab 04", Marks = 92 },
                new Student { Name = "Susan Anthony", CourseId = 4, Course = "Software Engineering", Lab = "Lab 01", Marks = 65 },
                new Student { Name =  "Norman Ralph Augustine", CourseId = 2, Course = "Database Systems", Lab = "Lab 03", Marks = 59},
                new Student { Name = "Andy Bathgate", CourseId = 1, Course = "Computer Architecture", Lab = "Lab 02", Marks = 80 },
                new Student { Name = "Jimmy Carter", CourseId = 2, Course = "Database Systems", Lab = "Lab 01", Marks = 84 },
                new Student { Name = "Thomas Edison", CourseId = 4, Course = "Software Engineering", Lab = "Lab 04", Marks = 75 },
                new Student { Name = "Thomas Edison", CourseId = 3, Course = "Data Structure and Algorithms", Lab = "Lab 01", Marks = 60 },
                new Student { Name = "William Gladstone", CourseId = 2, Course = "Database Systems", Lab = "Lab 03", Marks = 69 },
                new Student { Name = "Mary Hirsch", CourseId = 2, Course = "Database Systems", Lab = "Lab 01", Marks = 78 },
                new Student { Name = "Derek Jeter", CourseId = 3, Course = "Data Structure and Algorithms", Lab = "Lab 02", Marks = 73 },
                new Student { Name = "Ted Kennedy", CourseId = 3, Course = "Data Structure and Algorithms", Lab = "Lab 03", Marks = 85 },
                new Student { Name = "Steve Lyons", CourseId = 2, Course = "Database Systems", Lab = "Lab 02", Marks = 79 },
                new Student { Name = "Benito Mussolini", CourseId = 4, Course = "Software Engineering", Lab = "Lab 04", Marks = 59 } };

            if (!string.IsNullOrEmpty(filters.Student))
                students = students.Where(s => s.Name.ToLower().Contains(filters.Student.ToLower())).ToList();
            if (filters.CourseId != 0)
                students = students.Where(s => s.CourseId == filters.CourseId).ToList();

            return students;
        }

    }
}
