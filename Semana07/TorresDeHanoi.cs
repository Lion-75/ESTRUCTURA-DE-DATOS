using System;
using System.Collections.Generic;

namespace Semana07
{
    /// <summary>
    /// Clase que resuelve el problema de las Torres de Hanoi usando pilas (Stack).
    /// </summary>
    public class TorresDeHanoi
    {
        // Representamos las torres como pilas
        private static Stack<int> TorreOrigen = new Stack<int>();
        private static Stack<int> TorreAuxiliar = new Stack<int>();
        private static Stack<int> TorreDestino = new Stack<int>();

        /// <summary>
        /// Método principal que ejecuta el ejemplo de las Torres de Hanoi.
        /// </summary>
        public static void Ejecutar()
        {
            int numeroDiscos = 3; // Puedes cambiar este valor para probar con más discos

            // Inicializamos la torre de origen con discos (de mayor a menor)
            for (int i = numeroDiscos; i >= 1; i--)
            {
                TorreOrigen.Push(i);
            }

            Console.WriteLine("Estado inicial:");
            MostrarTorres();

            Resolver(numeroDiscos, TorreOrigen, TorreDestino, TorreAuxiliar);

            Console.WriteLine("¡Problema resuelto!");
        }

        /// <summary>
        /// Algoritmo recursivo para resolver el problema de las Torres de Hanoi.
        /// </summary>
        /// <param name="n">Número de discos a mover</param>
        /// <param name="origen">Torre de origen</param>
        /// <param name="destino">Torre de destino</param>
        /// <param name="auxiliar">Torre auxiliar</param>
        private static void Resolver(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar)
        {
            if (n == 0) return;

            // Paso 1: Mover n-1 discos de origen a auxiliar, usando destino como apoyo
            Resolver(n - 1, origen, auxiliar, destino);

            // Paso 2: Mover disco n desde origen hasta destino
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de torre {GetNombre(origen)} a torre {GetNombre(destino)}");
            MostrarTorres();

            // Paso 3: Mover n-1 discos desde auxiliar a destino, usando origen como apoyo
            Resolver(n - 1, auxiliar, destino, origen);
        }

        /// <summary>
        /// Muestra el estado actual de las tres torres.
        /// </summary>
        private static void MostrarTorres()
        {
            Console.WriteLine("Torre Origen: " + StackToString(TorreOrigen));
            Console.WriteLine("Torre Auxiliar: " + StackToString(TorreAuxiliar));
            Console.WriteLine("Torre Destino: " + StackToString(TorreDestino));
            Console.WriteLine();
        }

        /// <summary>
        /// Convierte una pila de discos en una cadena legible.
        /// </summary>
        private static string StackToString(Stack<int> stack)
        {
            return "[" + string.Join(", ", stack.ToArray()) + "]";
        }

        /// <summary>
        /// Devuelve el nombre de la torre basado en su referencia.
        /// </summary>
        private static string GetNombre(Stack<int> torre)
        {
            if (ReferenceEquals(torre, TorreOrigen)) return "Origen";
            if (ReferenceEquals(torre, TorreAuxiliar)) return "Auxiliar";
            if (ReferenceEquals(torre, TorreDestino)) return "Destino";
            return "Desconocida";
        }
    }
}