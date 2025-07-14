using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Verificación de paréntesis balanceados ===");
            Console.Write("Ingrese una expresión matemática: ");
            string expresion = Console.ReadLine();

            ValidadorParentesis validador = new ValidadorParentesis();
            bool estaBalanceada = validador.VerificarBalance(expresion);

            Console.WriteLine(estaBalanceada ? "Fórmula balanceada." : "Fórmula NO balanceada.");
        }
    }
}