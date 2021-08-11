using System;
using System.Threading;

namespace ConsoleTraianing
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            char choice;
            Console.WriteLine("Welcome to console demo.\nPress 'I' for input test, 'V' for variables demo, 'S' for strings manipulation demo, 'C' for simple calculator, 'A' for arrays, and 'M' for madlibz.\n Press 'Q' to exit the program.");

            do
            {
                choice = char.ToLower(Console.ReadKey().KeyChar);
                switch (choice)
                {
                    case 'i':
                        InputTest();
                        break;
                    case 'v':
                        VariablesDemo();
                        break;
                    case 's':
                        StringManipulatoin();
                        break;
                    case 'c':
                        Calculator();
                        break;
                    case 'a':
                        ArrayDemo();
                        break;
                    case 'm':
                        Madlibz();
                        break;
                    case 'Q':
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Choose on of the option above, please");
                        break;
                }
            } while (quit == false);


           

            /*

            MadLib Time!

            

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
        public static void InputTest()
        {
            Console.Clear();
            Console.WriteLine("This is a inputs test.");
            Thread.Sleep(500);

            Console.Write("Hello, I'm a computer. Now, what's your first name? ");
            string firstName = Console.ReadLine();
            Console.Write("Cool. Now tell me your last name please. ");
            string lastName = Console.ReadLine();
            Console.Write("Hey {0} {1}, what's up dawg?", firstName, lastName);

            Ending();
        }
        public static void VariablesDemo()
        {
            Console.Clear();
            string name;
            int age;
            Console.WriteLine("Welcome to variables demo. You will enter some variables and see how they change things.\nPlease enter a name: ");
            name = Console.ReadLine();
            Console.WriteLine("Good. Now enter age in numbers");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Terrific. Press any key to see the results.\n");
            Console.ReadKey();

            Console.WriteLine("There once was a man named {0}.", name);
            Console.WriteLine("He was {0} years old.", age);
            Console.WriteLine("He really liked the name {0}", name);
            Console.WriteLine("But he didn't lke being {0}", age);
            Ending();
        }
        public static void StringManipulatoin()
        {
            Console.Clear();

            Console.WriteLine("This is demo of string manipulation.\nPlease enter name of a character.");
            string characterName = Console.ReadLine();
            Console.WriteLine(characterName + " rulez, ok?\n\nPress any key to continue.");
            Console.ReadKey();
            Console.WriteLine("The name " + characterName + " is " + characterName.Length + " characters long");
            Thread.Sleep(500);
            Console.WriteLine("The name in uppercase looks like this: " + characterName.ToUpper());
            Thread.Sleep(500);
            Console.WriteLine("Does the characters name include the letter 'a'? : " + characterName.Contains("a"));
            if (characterName.Contains("a"))
            {
                Thread.Sleep(500);
                Console.WriteLine("The index of letter 'a' is : " + characterName.IndexOf('a'));
            }
            Thread.Sleep(500);
            Console.WriteLine("The first letter (with index number 0) is : " + characterName[0]);
            Thread.Sleep(500);
            Console.WriteLine("Honeslty I forgot what this does. " + characterName.Substring(2) + "g");
            Ending();
        }
        public static void Calculator()
        {
            Console.Clear();
            
            Console.WriteLine("Please enter a number.");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now please enter another number.");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The sum is " + (num1 + num2));
            Console.WriteLine("The difference is " + (num1 - num2));
            Console.WriteLine("The product is " + (num1 * num2));
            Console.WriteLine("The division is " + (num1 / num2));
            Console.WriteLine("Reminder is " + (num1 % num2));
            Console.WriteLine("Absolute value of both numbers is {0} and {1}", Math.Abs(num1), Math.Abs(num2));
            Console.WriteLine("Numbers powered are " + Math.Pow(num1, num2));
            Console.WriteLine("The square root of the first number is " + Math.Sqrt(num1));
            Console.WriteLine("The higher number is {0} and the lover number is {1}", Math.Max(num1, num2), Math.Min(num1, num2));
            Console.WriteLine("The first number rounded is " + Math.Round(num1));

            Console.WriteLine("Using int++, the first number is {0} and the second number is now {1}", num1++, num2++);
            Console.WriteLine("Using int--, the first number is {0} and the second number is now {1}", num1--, num2--);

            Ending();
        }
        public static void ArrayDemo()
        {

        }
        public static void Madlibz()
        {
            Console.Clear();
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

            Ending();
        }
        public static void Ending()
        {
            Console.WriteLine("\n Please choose antoher activity.\n'I' - input test, 'V' - variables demo, 'S' - strings manipulation demo, 'C' - simple calculator, 'A' - arrays, and 'M' - madlibz.\n Press 'Q' to exit the program.");
        }
    }
}
