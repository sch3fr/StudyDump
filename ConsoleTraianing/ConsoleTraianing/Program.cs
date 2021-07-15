using System;

namespace ConsoleTraianing
{
    class Program
    {
        static void Main(string[] args)
        {
            //==============================================================================================================================

            /* 
            
            Variables revision
            
            string name = "Frank";
            int age = 20;

            Console.WriteLine("There once was a man named {0}.", name);
            Console.WriteLine("He was {0} years old.", age);
            Console.WriteLine("He really liked the name {0}", name);
            Console.WriteLine("But he didn't lke being {0}", age);

            */

            //==============================================================================================================================

            /*

            Strings revision

            string characterName = "Greg";
            Console.WriteLine(characterName + " rulez \nok?");

            Console.WriteLine("The name " + characterName + " is " + characterName.Length + " characters long.");

            Console.WriteLine(characterName.ToUpper());
            Console.WriteLine(characterName.Contains("a"));

            Console.WriteLine(characterName[0]);
            Console.WriteLine(characterName.IndexOf('e'));
            Console.WriteLine(characterName.IndexOf('b'));
            Console.WriteLine(characterName.Substring(2) + "g");

            */

            //==============================================================================================================================

            /*
            
            Numbers revision

            Console.WriteLine(10 % 3);
            Console.WriteLine(4 + 2 * 3);
            Console.WriteLine(5 + 8.1);
            Console.WriteLine(5 / 2);
            Console.WriteLine(5.0 / 2.0);
            Console.WriteLine();

            int num = 7;
            num++;
            Console.WriteLine(num);
            num--;
            Console.WriteLine(num);
            Console.WriteLine();

            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(4, 2));
            Console.WriteLine(Math.Sqrt(81));
            Console.WriteLine(Math.Max(13, 7));
            Console.WriteLine(Math.Min(13, 7));
            Console.WriteLine(Math.Round(5.3));
            
            */

            //==============================================================================================================================

            /*

            Input revision

            Console.Write("Hello, I'm a computer. Now, what's your first name? ");
            string firstName = Console.ReadLine();
            Console.Write("Cool. Now tell me your last name please. ");
            string lastName = Console.ReadLine();
            Console.Write("Hey {0} {1}, what's up dawg?", firstName, lastName);

            */

            //==============================================================================================================================

            /*
            
            Simple calculator

            Console.WriteLine("Please enter a number.");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now please enter another number.");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The sum is " + (num1+num2));
            Console.WriteLine("The difference is " + (num1 - num2));
            Console.WriteLine("The product is " + (num1 * num2));
            Console.WriteLine("The division is " + (num1 / num2));

            */

            //==============================================================================================================================

            /*

            MadLib Time!

            Console.WriteLine("Hey, let's play a Mad Lips game! I'm gonna need some words first though.");

            Console.Write("Enter an adjective ");
            string adjective1 = Console.ReadLine();

            Console.Write("Now enter a nationality. Go nuts! ");
            string nationality = Console.ReadLine();

            Console.Write("Next I'll need a name. ");
            string name = Console.ReadLine();

            Console.Write("Cool. Now give me a noun. ");
            string noun1 = Console.ReadLine();

            Console.Write("Adjective? ");
            string adjective2 = Console.ReadLine();

            Console.Write("Noun pls. ");
            string noun2 = Console.ReadLine();

            Console.Write("Adjective? ");
            string adjective3 = Console.ReadLine();

            Console.Write("Adjective? ");
            string adjective4 = Console.ReadLine();

            Console.Write("Choose a plural noun. ");
            string plural = Console.ReadLine();

            Console.Write("Another noun. ");
            string noun3 = Console.ReadLine();

            Console.Write("Now we're talking. Give me a number! ");
            string number1 = Console.ReadLine();

            Console.Write("This is gonna be interesting! Now I need some shapes. ");
            string shape = Console.ReadLine();

            Console.Write("Food? ");
            string food1 = Console.ReadLine();

            Console.Write("And another food. ");
            string food2 = Console.ReadLine();

            Console.Write("And finally - give me a last number. ");
            string number2 = Console.ReadLine();
            Console.WriteLine();


            Console.WriteLine("Pizza was invented by a {0} {1} chef named {2}.", adjective1, nationality, name);
            Console.WriteLine("To make a pizza, you need to take a lum of {0}, and make a thin, round {1} {2}.", noun1, adjective2, noun2);
            Console.WriteLine("Then you cover it with {0} sauce, {1} cheese, and fresh chopped {2}.", adjective3, adjective4, plural);
            Console.WriteLine("Next you have to bake it in a very hot {0}. When it's done, cut it into {1} {2}.", noun3, number1, shape);
            Console.WriteLine("Some kids like {0} pizza the best, but my favourite is the {1} pizza.", food1, food2);
            Console.WriteLine("If I could, I would eat pizza {0} times a day.", number2);

            */

            //==============================================================================================================================

            /*
            
            Arrays revision

            int[] luckyNumbers = { 7, 13, 14, 42, 69, 420};
            Console.WriteLine(luckyNumbers[4]);
            luckyNumbers[2] = 36;
            Console.WriteLine(luckyNumbers[2]);

            string[] friends = new string[5];
            friends[0] = "Matouš";
            friends[1] = "Ondra";

            */

            //==============================================================================================================================



        }
    }
}
