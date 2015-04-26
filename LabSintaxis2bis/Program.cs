using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2bis
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTexto;
            

            Console.WriteLine("Ingrese un texto\n");
            inputTexto = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputTexto))
            {
                Console.WriteLine("Error: no se ingresó texto");
            }
            else
            {
                Console.WriteLine("1-Mostrar en mayúsculas\n");
                Console.WriteLine("2-Mostrar en minúsculas\n");
                Console.WriteLine("3-Mostrar cant. de caractéres\n");
                ConsoleKeyInfo opcion = Console.ReadKey();
                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(inputTexto.ToUpper());
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine(inputTexto.ToLower());
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine(inputTexto.Length);
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
