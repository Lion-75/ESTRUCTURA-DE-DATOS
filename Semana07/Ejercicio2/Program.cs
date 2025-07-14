using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Resolución del problema de las Torres de Hanoi ===");
            Console.Write("Ingrese el número de discos: ");
            int numeroDiscos = int.Parse(Console.ReadLine());

            TorresDeHanoi torres = new TorresDeHanoi(numeroDiscos);
            torres.Resolver();
        }
    }
}