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
           /*Lab1, ex1: Scrieti un program care va afisa semnul unui numar citit de la tastatura.
            daca numarul e pozitiv, va afisa ”+”
            daca nr e negativ, va afisa ”-”
            daca nr e 0, va afisa ”0”*/

            
            
            
            Console.WriteLine("Acest program va afisa va afisa semnul unui numar citit de la tastatura");
            
            
            Console.WriteLine("Introduceti numarul:");

            int numar= int.Parse(Console.ReadLine());

            if (numar > 0)
                Console.WriteLine(" + ");

            else if (numar < 0)
                Console.WriteLine("- ");

            else if (numar == 0)
                Console.WriteLine("0");
        }
    }

}





