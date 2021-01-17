using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //array

            string[] courses = new string[] {"Yazılım Geliştirici Kampı", "Programlamaya Giriş", "Java'nın Temelleri", "Phyton"};
            

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            //"course" is an alias
            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("Footer");
        }
    }
}
