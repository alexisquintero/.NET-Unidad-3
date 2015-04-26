using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Ingrese los dos numeros a sumar");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c=a+b;
            Console.WriteLine("El resultado de la suma de " + a.ToString() + "y " + b.ToString() + " es " + c.ToString() );
            Console.ReadKey();
        }
    }
}
