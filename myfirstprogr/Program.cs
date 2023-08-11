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
           /*Lab1, ex1: Scrieti un program care citind de la tastatura cele trei dimensiuni ale unui paralelipiped dreptunghic
            * va afisa volumul lui*/

            
            
            
            Console.WriteLine("Acest program va calcula volumul paralelipipedului dreptunghic");

            Console.WriteLine("Introduceti latimea:");
           int latime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti lungimea:");
           int lungime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti inaltimea:");
            int inaltime = int.Parse(Console.ReadLine());

            int volumulParalelipipeduluiDreptunghic = latime * lungime * inaltime;
            Console.WriteLine("Volumul paralelipipedului este" + volumulParalelipipeduluiDreptunghic);







        }
    }
}
