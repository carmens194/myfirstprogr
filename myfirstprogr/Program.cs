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
             * Folosind instructiunea switch, scrieti un program care citind de la tast un nr intreg va verifica urmatoarele.
             - ”unu” daca nr citit este unu
             - ” doi” daca nr citit este doi
             - ”trei, cinci, opt daca nr citite sunt 3,5,8
             - ”neidentificat” pt orice alt caz*/

            int numar = int.Parse(Console.ReadLine());
        
            switch (numar)
            {
                case 0:
                Console.WriteLine("Numarul este zero");
                 break;
                case 1:
                    Console.WriteLine("Numarul este unu");
                    break;
                case 2:
                    Console.WriteLine("Numarul este doi");
                    break;
                case 3:
                    Console.WriteLine("Numarul este trei");
                    break;
                default:
                    Console.WriteLine("Numar neidentificat");
                    break;


            }


        }
           
    }
}







