using System;
using System.Collections.Generic;
using System.Linq;

namespace Semana10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Crear conjunto ficticio de 500 ciudadanos
            var ciudadanos = new HashSet<string>();
            for (int i = 1; i <= 500; i++)
            {
                ciudadanos.Add($"Ciudadano {i}");
            }

            // 2. 75 vacunados con Pfizer (aleatorios)
            var random = new Random();
            var todos = ciudadanos.ToList();
            var vacunadosPfizer = new HashSet<string>(Enumerable.Range(0, 75)
                .Select(_ => todos[random.Next(todos.Count)]).Distinct());

            // 3. 75 vacunados con AstraZeneca (aleatorios)
            var vacunadosAstra = new HashSet<string>(Enumerable.Range(0, 75)
                .Select(_ => todos[random.Next(todos.Count)]).Distinct());

            // 4. Operaciones de conjuntos

            // Ciudadanos que han recibido ambas dosis (intersección)
            var ambasDosis = new HashSet<string>(vacunadosPfizer.Intersect(vacunadosAstra));

            // Ciudadanos que solo han recibido Pfizer
            var soloPfizer = new HashSet<string>(vacunadosPfizer.Except(ambasDosis));

            // Ciudadanos que solo han recibido AstraZeneca
            var soloAstra = new HashSet<string>(vacunadosAstra.Except(ambasDosis));

            // Ciudadanos que no se han vacunado (no están en Pfizer ni Astra)
            var vacunadosTotales = new HashSet<string>(vacunadosPfizer.Union(vacunadosAstra));
            var noVacunados = new HashSet<string>(ciudadanos.Except(vacunadosTotales));

            // Mostrar resultados
            Console.WriteLine("=== INFORME DE VACUNACIÓN CONTRA EL COVID-19 ===\n");

            Console.WriteLine($"Total de ciudadanos: {ciudadanos.Count}");
            Console.WriteLine($"Vacunados con Pfizer: {vacunadosPfizer.Count}");
            Console.WriteLine($"Vacunados con AstraZeneca: {vacunadosAstra.Count}");
            Console.WriteLine($"Ambas dosis: {ambasDosis.Count}");
            Console.WriteLine($"No vacunados: {noVacunados.Count}\n");

            // Listado 1: No vacunados
            Console.WriteLine("1. Ciudadanos que no se han vacunado:");
            ImprimirLista(noVacunados);

            // Listado 2: Ambas dosis
            Console.WriteLine("\n2. Ciudadanos que han recibido ambas dosis:");
            ImprimirLista(ambasDosis);

            // Listado 3: Solo Pfizer
            Console.WriteLine("\n3. Ciudadanos que solo han recibido Pfizer:");
            ImprimirLista(soloPfizer);

            // Listado 4: Solo AstraZeneca
            Console.WriteLine("\n4. Ciudadanos que solo han recibido AstraZeneca:");
            ImprimirLista(soloAstra);

            Console.WriteLine("\n\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Método auxiliar para imprimir listas sin desbordar la consola
        static void ImprimirLista(IEnumerable<string> lista)
        {
            int count = 0;
            foreach (var item in lista.OrderBy(x => x))
            {
                if (count >= 10)
                {
                    Console.WriteLine("  ... (y más)");
                    break;
                }
                Console.WriteLine($"  {item}");
                count++;
            }
            if (count == 0)
            {
                Console.WriteLine("  (Ninguno)");
            }
        }
    }
}