using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
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
                if (opcion.Key == ConsoleKey.D1)
                {                    
                    Console.WriteLine(inputTexto.ToUpper());
                }
                else
                {
                    if (opcion.Key == ConsoleKey.D2)
                    {                        
                        Console.WriteLine(inputTexto.ToLower());
                    }
                    else
                    {
                        if (opcion.Key == ConsoleKey.D3)
                        {
                            Console.WriteLine(inputTexto.Length);
                        }

                    }
                }
                
            }
            Console.ReadLine();
        }
    }
}
