using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstprogr
{
    class Program
    {
        static void Main(string[] args)

        {
           /*Lab1, ex1: Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la tastatura*/

            
            
            
            Console.WriteLine("Acest program va afisa ultima cifra a unui numar intreg citit de la tastatura");

            
            Console.WriteLine("Introduceti numarul:");

            int numarIntreg = int.Parse(Console.ReadLine());



            int lastDigit = numarIntreg % (10);
            Console.WriteLine("Ultima cifra este" + lastDigit);







        }
    }
}
