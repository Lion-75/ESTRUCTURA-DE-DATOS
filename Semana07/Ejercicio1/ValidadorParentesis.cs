using System;
using System.Collections.Generic;

namespace Ejercicio1
{
    public class ValidadorParentesis
    {
        /// <summary>
        /// Verifica si los símbolos de apertura y cierre están correctamente anidados.
        /// </summary>
        public bool VerificarBalance(string expresion)
        {
            Stack<char> pila = new Stack<char>();
            Dictionary<char, char> pares = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            foreach (char c in expresion)
            {
                if ("({[".Contains(c))
                {
                    pila.Push(c);
                }
                else if (")}]".Contains(c))
                {
                    if (pila.Count == 0) return false;
                    char ultimoApertura = pila.Pop();
                    if (pares[c] != ultimoApertura) return false;
                }
            }

            return pila.Count == 0;
        }
    }
}