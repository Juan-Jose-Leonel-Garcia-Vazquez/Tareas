using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== VERIFICADOR DE NÚMEROS PARES E IMPARES ===\n");

            string respuesta;

           
            do
            {
                Console.Write("Introduce un número entero: ");

                try
                {
                    int numero = Convert.ToInt32(Console.ReadLine());

                    
                    if (numero == 0)
                    {
                        Console.WriteLine($"\nel número es cero y es par ");
                    }
                    
                    else if (numero % 2 == 0)
                    {
                        Console.WriteLine($"\nEl número {numero} es par");
                    }
                    else
                    {
                        Console.WriteLine($"\nEl número {numero} es impar");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nError: Debes ingresar un número entero válido.");
                }

                
                Console.WriteLine("\n¿Deseas analizar otro número? (s/n): ");
                respuesta = Console.ReadLine().ToLower();
                

            } while (respuesta == "s" || respuesta == "si");

            Console.WriteLine("\ngracias por usar el programa");
            Console.ReadKey();
        }
    }
}