using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_golqmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи едно цяло число за a ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Въведи едно цяло число за b ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("По-голямото число е " + a);
            }
            else
            {
                Console.WriteLine("По- малкото число е " + a);
            }
        }
    }
}
