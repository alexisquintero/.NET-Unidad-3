using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string clave, ingresado;
            clave = "12345";
            for (int intentos = 0; intentos < 4; intentos++)
                {
                    Console.WriteLine("Introduzca clave");
                    ingresado = Console.ReadLine();
                    if (string.Equals(clave, ingresado))
                    {
                        Console.WriteLine("Clave correcta");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Clave incorrecta");
                    }
                }
            Console.ReadKey();
        }
    }
}
