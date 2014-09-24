using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplikationtabell
{
    class Program
    {
        static int theNumber;
        static int loop = 1;
        static string restartGame;

        static void Main(string[] args)
        {
            while (loop == 1)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter any number.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                theNumber = Convert.ToInt32(Console.ReadLine());

                Answer();
            }
        }

        static void Answer()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("{0} * 1 = {1} ", theNumber, theNumber * 1);
            Console.WriteLine("{0} * 2 = {1} ", theNumber, theNumber * 2);
            Console.WriteLine("{0} * 3 = {1} ", theNumber, theNumber * 3);
            Console.WriteLine("{0} * 4 = {1} ", theNumber, theNumber * 4);
            Console.WriteLine("{0} * 5 = {1} ", theNumber, theNumber * 5);
            Console.WriteLine("{0} * 6 = {1} ", theNumber, theNumber * 6);
            Console.WriteLine("{0} * 7 = {1} ", theNumber, theNumber * 7);
            Console.WriteLine("{0} * 8 = {1} ", theNumber, theNumber * 8);
            Console.WriteLine("{0} * 9 = {1} ", theNumber, theNumber * 9);
            Console.WriteLine("{0} * 10 = {1} ", theNumber, theNumber * 10);

            Console.WriteLine();
            Restart();
        }

        static void Restart()
        {
            Console.WriteLine("Do you want to restart?");
            Console.WriteLine("[Yes]-[No]");
            restartGame = Console.ReadLine().ToLower();

            if (restartGame == "yes")
            {
                Console.Clear();
                return;
            }

            else if (restartGame == "no")
                Environment.Exit(0);

            else
            {
                Console.Clear();
                Restart();
            }
        }
    }
}
