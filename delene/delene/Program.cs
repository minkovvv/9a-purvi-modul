using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи едно цяло число ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Числото е четно");
            }
            else
            {
                Console.WriteLine("Числото е Нечетно защото е " + a);
            }
        }
    }
}
