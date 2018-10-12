using System;

namespace TAmathExercise
{
    class Program
    {
        static void Main()
        {
            // 1. Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10,000,000).
            Console.WriteLine("Enter a number to be multiplied by 50:");
            int num50 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num50 + " * 50 = " + num50 * 50);

            // 2.Takes an input from the user, adds 25 to it, and prints the result to the console.
            Console.WriteLine("Enter a number to add 25 to:");
            int num25 = Convert.ToInt32(Console.ReadLine());
            int num25plus = num25 + 25;
            Console.WriteLine(num25 + " + 25 = " + num25plus);

            // 3.Takes an input from the user, divides it by 12.5, and prints the result to the console.
            Console.WriteLine("Enter a number to be devided by 12.5:");
            int numDev12p5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numDev12p5 + " / 12.5 = " + numDev12p5 / 12.5);

            // 4.Takes an input from the user, checks if it is greater than 50, and prints the true / false result to the console.
            Console.WriteLine("Enter a number: ");
            int numOver50 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is " + numOver50 + " over 50? " + Convert.ToBoolean(numOver50 > 50));

            // 5.Takes an input from the user, divides it by 7, and prints the remainder to the console(tip: think % operator).
            Console.WriteLine("Enter a number: ");
            int numMod7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((numMod7 % 7) + " is the remainder of " + numMod7 + " / 7.");
            Console.ReadLine();
        }
    }
}
