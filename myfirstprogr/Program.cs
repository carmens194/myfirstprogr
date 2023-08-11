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
             * Scrieti un program care interschimba valoarea a doua variabile intregi.*/

            int a, b, aux;

           Console.WriteLine("Acest program va interschimba valoarea a doua variabile intregi");
            
            
            Console.WriteLine("Introduceti numarul a: ");
             a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti numarul b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("a={0}, b={1}", a, b);
            aux = a; a = b; b = aux;
            Console.Write("Dupa interschimbare a={0}, b={1}", a, b);

            Console.ReadKey();









        }
        }
    }






