using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Week2Challenges2
{
    class Challenges
    {
        static void Main(string[] args)
        {
            Greeter hello = new Greeter();
            hello.GreetAPerson("");

            Challenges function = new Challenges();
            function.TokenFunction();

            Greeter farewell = new Greeter();
            farewell.GoodbyePerson("");

            Challenges function2 = new Challenges();
            function2.TokenFunction();

            Greeter time = new Greeter();
            time.TimePlease("");

            Console.WriteLine("Please press ENTER to clear the console and move onto a new greeting and farewell...");
            Console.ReadLine();
            Console.Clear();

            Greeter greeter = new Greeter();
            string person = greeter.GreetAPerson2("Dolly!");
            Console.WriteLine(person);

            Greeter farewell2 = new Greeter();
            string person2 = farewell2.GoodbyePerson2("Jimmy!");
            Console.WriteLine(person2);

            Console.WriteLine("\nGoodbye!" + "\nPress ENTER to clear the console and exit...");
            Console.ReadLine();
            Console.Clear();
        }

        void TokenFunction()
        {
            Console.WriteLine("Please press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }

}

//Build a class called Greeter.This class will hold our next few methods.
//Inside our new class, build a method that takes in a name as a parameter and then outputs (writes to the Console) hello to that person.
//Ex: If the method is given the name Joshua, the output should be "Hello Joshua"
//Build another method that outputs (writes to the Console) some sort of farewell to the name it is given as a parameter.
//Build a method that outputs (writes to the Console) Good Morning/Afternoon/Evening/Night depending on the time of day.
//New up (instantiate) an instance of your Greeter class inside your Main method. From this instance call all of the methods you've built out.

