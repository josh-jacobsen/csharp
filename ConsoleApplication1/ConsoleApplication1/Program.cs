using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string guess;

            do
            {
                Console.WriteLine("guess a number");
                guess = Console.ReadLine();
            } while (!guess.Equals("15"));
        }
    }
}
