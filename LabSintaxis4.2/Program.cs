using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio;
            Console.WriteLine("Ingrese el año para saber si es bisiesto");
            anio = int.Parse(Console.ReadLine());
            if ((anio%4 == 0) && (anio%100 != 0) || (anio%400 == 0)){
                Console.WriteLine("Es bisiesto");
            }else{
                Console.WriteLine("No es bisiesto");
            }
            Console.ReadKey();
        }
    }
}
