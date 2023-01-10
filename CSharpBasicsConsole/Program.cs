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
            //object userInput = new
            //{
            //    Name = "Name",
            //    FavoriteDay = "Wednesday",
            //    LeastFavoriteSubject = "Gym",
            //    Age = 0
            //};

            UserInput myUserInput = new UserInput();

            //userInput1.Name = "Deanna";
            //userInput1.FavoriteDayOFWeek = "Friday";
            //userInput1.LeastFavoriteSubject = "Gym";

            Console.Write("Enter your name: ");
            myUserInput.Name = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(myUserInput.Name))
            {
                Console.WriteLine("Please enter a valid name: ");
                myUserInput.Name = Console.ReadLine();
            }
            Console.Clear();

            Console.Write("What is your favorite day of the week? ");
            myUserInput.FavoriteDayOfWeek = Console.ReadLine();

            //I'm making this comment.

            while (String.IsNullOrWhiteSpace(myUserInput.FavoriteDayOfWeek))
            {
                Console.WriteLine("Please enter a valid day of the week: ");
                myUserInput.FavoriteDayOfWeek = Console.ReadLine();
            }
            Console.Clear();

            Console.Write("What is your least favorite subject in school? ");
            myUserInput.LeastFaveSchoolSubject = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(myUserInput.LeastFaveSchoolSubject))
            {
                Console.WriteLine("Please enter a valid school subject: ");
                myUserInput.LeastFaveSchoolSubject = Console.ReadLine();
            }
            Console.Clear();

//            string displayText = @$"Name: {myUserInput.Name}
//Favorite Day of the Week: {myUserInput.FavoriteDayOfWeek}
//Least Favorite School Subject: {myUserInput.LeastFaveSchoolSubject}";

            Console.Write(myUserInput);
            
            //Console.Write(displayText);

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