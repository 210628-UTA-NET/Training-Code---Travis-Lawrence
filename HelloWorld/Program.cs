using System; //Importing System namespace
using HouseFunction;

/*
    Naming conventions in C#
    -We use PascalCase for most of the naming conventions
    -We use camelCase for naming fields
        -_underscore before naming fields
    
*/

namespace HelloWorld
{
    class Program
    {
        private static string _firstWord = "Hello";

        private static string _lastWord = "World!";

        /*
            -Main method is the first method that will be called/run whenever you do the command dotnet run
            -Static means you don't have to instantiate the program class to use that method
        */

        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);

            Console.WriteLine(_firstWord + " " + _lastWord);

            House aHouse = new House();
            Console.WriteLine(aHouse.getColor());
            aHouse.setColor("Greenish-blue");
            Console.WriteLine(aHouse.getColor());
        }
    }

    class Test
    {
        public string SomeMethod()
        {
            return "Yay I did the thing";
        }
    }
}
