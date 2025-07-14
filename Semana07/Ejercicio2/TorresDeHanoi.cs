using System;
using System.Collections.Generic;

namespace Ejercicio2
{
    public class TorresDeHanoi
    {
        private readonly Stack<int>[] torres;
        private readonly int numeroDiscos;

        public TorresDeHanoi(int n)
        {
            numeroDiscos = n;
            torres = new Stack<int>[3];
            for (int i = 0; i < 3; i++)
            {
                torres[i] = new Stack<int>();
            }

            // Inicializamos la primera torre con discos (de mayor a menor)
            for (int i = n; i >= 1; i--)
            {
                torres[0].Push(i);
            }
        }

        public void Resolver()
        {
            Console.WriteLine("Estado inicial:");
            MostrarTorres();

            ResolverRecursivo(numeroDiscos, 0, 2, 1); // Origen=0, Destino=2, Auxiliar=1

            Console.WriteLine("¡Problema resuelto!");
        }

        private void ResolverRecursivo(int n, int origen, int destino, int auxiliar)
        {
            if (n == 0) return;

            ResolverRecursivo(n - 1, origen, auxiliar, destino);
            int disco = torres[origen].Pop();
            torres[destino].Push(disco);
            Console.WriteLine($"Mover disco {disco} de torre {GetNombre(origen)} a torre {GetNombre(destino)}");
            MostrarTorres();
            ResolverRecursivo(n - 1, auxiliar, destino, origen);
        }

        private void MostrarTorres()
        {
            Console.WriteLine("Torre A: " + StackToString(torres[0]));
            Console.WriteLine("Torre B: " + StackToString(torres[1]));
            Console.WriteLine("Torre C: " + StackToString(torres[2]));
            Console.WriteLine();
        }

        private string StackToString(Stack<int> stack)
        {
            return "[" + string.Join(", ", stack.ToArray()) + "]";
        }

        private string GetNombre(int indice)
        {
            return indice switch
            {
                0 => "A",
                1 => "B",
                2 => "C",
                _ => "Desconocida"
            };
        }
    }
}