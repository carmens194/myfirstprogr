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
            /*Lab1, ex7: 
             * Scrieti un program care va verifica, daca un numar citit de la tastatura este par sau impar.*/

            int i;
           Console.WriteLine("Acest program va verifica paritatea unui numar");
            
            
            Console.WriteLine("Introduceti numarul: ");
             i = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine("Numarul introdus este un numar par");


            }
            else
            {
                Console.WriteLine("Numarul introdus este un numar impar");
                







            }
        }
    }
}





