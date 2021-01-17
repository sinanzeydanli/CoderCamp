using System;

namespace CoderCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety

            //CategoryTag is an alias
            
            string CategoryTag = "Category";
            int studentCount = 32000;
            double interestRate = 1.45;
            bool isSignedIn = false;
            double dollarPrevious = 7.35;
            double dollarCurrent = 7.60;

            if (dollarPrevious > dollarCurrent)
            {
                Console.WriteLine("decreasingArrow");
            }
            else if (dollarPrevious < dollarCurrent)
            {
                Console.WriteLine("increasingArrow");
            }
            else
            {
                Console.WriteLine("stillMark");
            }


            if (isSignedIn == true)
            {
                Console.WriteLine("UserSettingButton");
            }
            else
            {
                Console.WriteLine("SignInButton");
            }

            
            Console.WriteLine(CategoryTag);


        }
    }
}
