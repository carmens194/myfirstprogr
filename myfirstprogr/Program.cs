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
           /*Lab1, ex1: Scrieti un program care va calcula media aritmetica a trei numere citite de la tastatura*/

            
            
            
            Console.WriteLine("Acest program va calcula media aritmetica a trei numere");

            Console.WriteLine("Introduceti primul numar:");
           int primulNumar = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar:");
           int alDoileaNumar = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al treilea numar:");
            int alTreileaNumar = int.Parse(Console.ReadLine());

            int mediaAritmetica = primulNumar + alDoileaNumar + alTreileaNumar;
            Console.WriteLine("Media aritmetica este" + mediaAritmetica);







        }
    }
}
