using System;

namespace ConsoleTrainingPT2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  SayHi Method
            SayHi("Frank", 20);
            SayHi("Melanie", 18);
            SayHi("Todd", 23);
            */

            //======================================================================================================================================

            /* Cubed Method
            int cubedNumber;
            cubedNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(cubed(cubedNumber));
            */

            //======================================================================================================================================

            /* Gender Choice
            char choice;
            Console.Write("Choose your gender. Press M for male, F for female, or N for not sure. ");
            //choice = Convert.ToChar(Console.ReadKey());
            choice = Console.ReadKey().KeyChar;
            if (choice == 'm')
            {
                Console.WriteLine("\nSo you a stronk boy huh?");
            }
            else if (choice == 'f')
            {
                Console.WriteLine("\nHello there pretty lady ;)");
            }
            else if (choice == 'N')
            {
                Console.WriteLine("\nDon't worry, you'll figure that out :)");
            }
            else
            {
                Console.WriteLine("\nYou seem more than confused bruv.");
            }
            */

            //======================================================================================================================================

            /* IF ELSE Revision
            bool isMale = true;
            bool isTall = true;
            if (isMale && isTall)
            {
                Console.WriteLine("You a tall boi");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("Haha small boy");
            }
            else if (!isMale && isTall) 
            { 
                Console.WriteLine("ooh tall girl :)"); 
            }
            else
            {
                Console.WriteLine("Either youre not in a bois club or in a tall club. Or both. Sorry mate.");
            }

            if (isMale || isTall)
            {
                Console.WriteLine("Good for you");
            }
            else
            {
                Console.WriteLine("Haha, small girl");
            }
            */

            //======================================================================================================================================

            //Numbers Comparison
            //Console.WriteLine(GetMax(4, 23, 12));

            //======================================================================================================================================

            /* Dumb calculator
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter another number :");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
            */

            //======================================================================================================================================

            //Switch revision
            //Console.WriteLine(GetDay(14));

            //======================================================================================================================================

            /* While revision
            int index = 1;
            while (index < 11)
            {
                Console.WriteLine("Index value is " + index);
                index++;
            }
            */

            //======================================================================================================================================

            /* Guessing game
            string secretWord = "programming";
            string guess = "";
            int counter = 0;
            int limit = 5;
            bool outOfGuesses = false;

            do
            {
                if (counter < limit) 
                { 
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    counter++;
                }
                else
                {
                    outOfGuesses = true;
                }
            } while (guess != secretWord && !outOfGuesses);
            if (outOfGuesses) { Console.WriteLine("You lose :("); }
            else { Console.WriteLine("You Win!"); }
            */

            //======================================================================================================================================

            /* For revision
            int[] luckyNumbers = { 7, 13, 14, 42, 69, 420 };
            for (int i = 0; i < luckyNumbers.Length; i++) 
            {
                Console.WriteLine("The number is  " + luckyNumbers[i]); 
            }
            */

            Console.WriteLine("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The number is " + Power(num1, num2));


        }
        static double Power(double numBase, double numPower)
        {
            double result = 0.00;

            result = Math.Pow(numBase, numPower);

            return result;
        }
        static string GetDay(int dayNum)
        {
            string dayName = "";
            switch (dayNum)
            {
                case 0:
                    dayName = "pondělí";
                    break;
                case 1:
                    dayName = "uterý";
                    break;
                case 2:
                    dayName = "středa";
                    break;
                case 3:
                    dayName = "čtvrtek";
                    break;
                case 4:
                    dayName = "pátek";
                    break;
                case 5:
                    dayName = "sobota";
                    break;
                case 6:
                    dayName = "neděle";
                    break;
                default:
                    Console.WriteLine("invalid day number");
                    break;
            }
            return dayName;
        }
        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        }
        static int cubed(int num)
        {
            int result = num * num * num;
            return result;
        }
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age + " years old.");
        }
    }
}
