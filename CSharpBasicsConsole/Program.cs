using System;

namespace CSharpBasicsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Name: Deanna Hollifield
             * Favorite day of the week: Wednesday
             * Least favorite school subject: Gym
             * 
             */

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Please enter a valid name: ");
                name = Console.ReadLine();
            }
            Console.Clear();

            Console.Write("What is your favorite day of the week? ");
            string dayOfWeek = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(dayOfWeek))
            {
                Console.WriteLine("Please enter a valid day of the week: ");
                dayOfWeek = Console.ReadLine();
            }
            Console.Clear();

            Console.Write("What is your least favorite subject in school? ");
            string leastFaveSchoolSubject = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(leastFaveSchoolSubject))
            {
                Console.WriteLine("Please enter a valid school subject: ");
                leastFaveSchoolSubject = Console.ReadLine();
            }
            Console.Clear();

            string displayText = @$"Name: {name}
Favorite Day of the Week: {dayOfWeek}
Least Favorite School Subject: {leastFaveSchoolSubject}";

            Console.Write(displayText);

            Console.ReadLine();

            //string input = "";

            //while (input == "" || input.StartsWith("QQ"))
            //{
            //    //Console.WriteLine("You need to type a real name.");
            //    Console.WriteLine("Enter your name:");
            //    input = Console.ReadLine();
            //}

            //Console.WriteLine($"Hello, {input}");
        }
    }
}