using System;

namespace HelloWorld
{
    // simple program that asks for user input via cmd line
    // + performs basic math to respond with (mostly accurate) information.
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "";
            int userAge = 0;
            int currentYear;

            Console.Write("Please Enter Your Name: ");
            userName = Console.ReadLine();

            Console.Write("Please Enter You Age: ");
            userAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter Current Year: ");
            currentYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello World! My name is {0} and I am {1} years old.  I was born in the year {2}.", userName, userAge, currentYear - userAge);
        }
    }
    // EXAMPLE OUTPUT
    //Please Enter Your Name: greg
    //Please Enter You Age: 26
    //Please Enter Current Year: 2018
    //Hello World! My name is greg and I am 26 years old.I was born in the year 1992.
}
