using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Week2Challenges2
{
    class Greeter
    {
        //Expirementation (week 2 challenges below first two methods):
        public string Name { get; set; }
        
        public void GreetAPerson(string name)
        {
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
            Console.WriteLine($"Hello, {Name}!");
        }

        public void GoodbyePerson(string farewell)
        {
            Console.WriteLine("What's your name again?");
            Name = Console.ReadLine();
            Console.WriteLine($"Thank you for the reminder! Leaving so soon, {Name}? Type \"yes\" or \"no\".");
            string response = Console.ReadLine();
            if (response == "yes")
            {
                Console.WriteLine($"Farewell, {Name}!");
            }
            else if (response == "no")
            {
                Console.WriteLine($"Yay! I'm glad you've chosen to stay, {Name}!");
            }
            else
            {
                Console.WriteLine($"You should really make up your mind, {Name}!");
            }
        }

        //The way its supposed to be done:
        public string GreetAPerson2(string name)
        {
            return "Hello, " + name;
        }

        public string GoodbyePerson2(string name)
        {
            return "Goodbye, " + name;
        }

        public void TimePlease(string time)
        {
            Console.WriteLine("Here's a greeting based on the time of day:");

            var hour = DateTime.Now.Hour;

            if ((hour >= 0) && (hour < 12))
            {
                Console.WriteLine("Good morning!");
            }
            else if ((hour >= 12) && (hour < 18))
            {
                Console.WriteLine("Good afternoon!");
            }
            else if ((hour >= 18) && (hour < 21))
            {
                Console.WriteLine("Good evening!");
            }
            else if ((hour >= 21) && (hour < 24))
            {
                Console.WriteLine("Good night!");
            }
            else
            {
                Console.WriteLine("Does anyone really know what time it is?");
            }
        }

        public Greeter()
        {

        }

    }
}

//Build a class called Greeter.This class will hold our next few methods.
//Inside our new class, build a method that takes in a name as a parameter and then outputs (writes to the Console) hello to that person.
//Ex: If the method is given the name Joshua, the output should be "Hello Joshua"
//Build another method that outputs (writes to the Console) some sort of farewell to the name it is given as a parameter.
//Build a method that outputs (writes to the Console) Good Morning/Afternoon/Evening/Night depending on the time of day.
//New up (instantiate) an instance of your Greeter class inside your Main method. From this instance call all of the methods you've built out.
