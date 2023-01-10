using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicsConsole
{

    //class - a blueprint to represent something in your application
    //all code in a class will be related

    public class UserInput
    {
        /*
            * 
            * Name: Deanna Hollifield
            * Favorite day of the week: Wednesday
            * Least favorite school subject: Gym
            * 
            * object userInput = new
            * { 
            * 
            */


        public string Name { get; set; }
        public string? FavoriteDayOfWeek { get; set; }
        public string? LeastFaveSchoolSubject { get; set; }

        public override string ToString()
        {
            return @$"Name: {Name}
Favorite Day of the Week: {FavoriteDayOfWeek}
Least Favorite School Subject: {LeastFaveSchoolSubject}";
        }
    }
}
