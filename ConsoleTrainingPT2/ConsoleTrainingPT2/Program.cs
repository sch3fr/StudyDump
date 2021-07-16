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

            /* Cubed Method
            int cubedNumber;
            cubedNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(cubed(cubedNumber));
            */
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
