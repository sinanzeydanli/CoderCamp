using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.CourseTutor = "Sinan";
            course1.ViewCount = 120;

            Course course2 = new Course();
            course2.CourseName = "Phyton";
            course2.CourseTutor = "Mesut";
            course2.ViewCount = 60;

            Course course3 = new Course();
            course3.CourseName = "Java";
            course3.CourseTutor = "Berkay";
            course3.ViewCount = 150;

            Course course4 = new Course();
            course4.CourseName = "Fortran";
            course4.CourseTutor = "Tospaa";
            course4.ViewCount = 0;

            Console.WriteLine(course1.CourseName + " : " + course1.CourseTutor);

            Course[] courses = new Course[] {course1, course2, course3, course4};

            foreach (var Course in courses)
            {
                Console.WriteLine(Course.CourseName + " : " +Course.CourseTutor);
            }
        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string CourseTutor { get; set; }
        public int ViewCount { get; set; }
    }
}
