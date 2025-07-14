using System;
using System.Collections.Generic;

namespace Semana07
{
    /// <summary>
    /// Clase que verifica si los paréntesis, llaves y corchetes en una expresión están balanceados.
    /// </summary>
    public class BalanceadorDeExpresiones
    {
        /// <summary>
        /// Método principal que ejecuta el ejemplo de verificación.
        /// </summary>
        public static void Ejecutar()
        {
            string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";
            bool estaBalanceada = VerificarBalance(expresion);
            Console.WriteLine(estaBalanceada ? "Fórmula balanceada." : "Fórmula NO balanceada.");
        }

        /// <summary>
        /// Verifica si los símbolos de apertura y cierre están correctamente anidados.
        /// </summary>
        /// <param name="expresion">Cadena que contiene la expresión matemática o lógica</param>
        /// <returns>True si está balanceada, False en caso contrario</returns>
        private static bool VerificarBalance(string expresion)
        {
            // Creamos una pila para guardar los símbolos de apertura
            Stack<char> pila = new Stack<char>();

            // Diccionario para relacionar cada cierre con su apertura correspondiente
            Dictionary<char, char> pares = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            // Recorremos cada carácter de la expresión
            foreach (char c in expresion)
            {
                // Si es un símbolo de apertura, lo agregamos a la pila
                if ("({[".Contains(c))
                {
                    pila.Push(c);
                }
                // Si es un símbolo de cierre
                else if (")}]".Contains(c))
                {
                    // Si la pila está vacía, hay un cierre sin apertura
                    if (pila.Count == 0)
                        return false;

                    // Obtenemos el último símbolo de apertura
                    char ultimoApertura = pila.Pop();

                    // Verificamos si coincide con el cierre actual
                    if (pares[c] != ultimoApertura)
                        return false;
                }
            }

            // Al final, la pila debe estar vacía (todos los símbolos cerrados)
            return pila.Count == 0;
        }
    }
}