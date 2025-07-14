using System;

namespace Semana07
{
    /// <summary>
    /// Punto de entrada del programa. Muestra un menú para seleccionar el ejercicio a ejecutar.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Menú simple para elegir qué ejercicio ejecutar
            Console.WriteLine("=== Ejercicios de Pilas ===");
            Console.WriteLine("1. Verificar paréntesis balanceados");
            Console.WriteLine("2. Resolver Torres de Hanoi");
            Console.Write("Seleccione una opción: ");
            
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    BalanceadorDeExpresiones.Ejecutar();
                    break;
                case "2":
                    TorresDeHanoi.Ejecutar();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}