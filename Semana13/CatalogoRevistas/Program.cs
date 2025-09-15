using System;
using System.Collections.Generic;

namespace CatalogoRevistas
{
    class Program
    {
        // Lista estática de revistas (el catálogo)
        static List<string> catalogo = new List<string>
        {
            "National Geographic",
            "Time",
            "Scientific American",
            "The Economist",
            "Forbes",
            "Wired",
            "Nature",
            "Harvard Business Review",
            "Discover",
            "Popular Science",
            "El País Semanal",
            "Revista Muy Interesante"
        };

        static void Main()
        {
            Console.WriteLine("=== CATÁLOGO DE REVISTAS ===");
            Console.WriteLine("Bienvenido al sistema de búsqueda de revistas");

            int opcion;

            do
            {
                Console.WriteLine("\n==================== MENÚ ====================");
                Console.WriteLine("1. Buscar una revista (búsqueda iterativa)");
                Console.WriteLine("2. Buscar una revista (búsqueda recursiva)");
                Console.WriteLine("3. Mostrar todas las revistas");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        BusquedaIterativa();
                        break;

                    case 2:
                        BusquedaRecursiva();
                        break;

                    case 3:
                        MostrarCatalogo();
                        break;

                    case 0:
                        Console.WriteLine("Gracias por usar el catálogo. ¡Hasta luego!");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, elija 1, 2, 3 o 0.");
                        break;
                }

            } while (opcion != 0);
        }

        /// <summary>
        /// Busca una revista usando un bucle for (búsqueda iterativa)
        /// </summary>
        static void BusquedaIterativa()
        {
            Console.Write("Ingrese el título de la revista a buscar: ");
            string titulo = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(titulo))
            {
                Console.WriteLine("El título no puede estar vacío.");
                return;
            }

            bool encontrado = false;
            for (int i = 0; i < catalogo.Count; i++)
            {
                if (catalogo[i].Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    encontrado = true;
                    break;
                }
            }

            Console.WriteLine(encontrado ? "✅ Encontrado" : "❌ No encontrado");
        }

        /// <summary>
        /// Busca una revista usando recursión (llamada recursiva sobre un índice)
        /// </summary>
        static void BusquedaRecursiva()
        {
            Console.Write("Ingrese el título de la revista a buscar: ");
            string titulo = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(titulo))
            {
                Console.WriteLine("El título no puede estar vacío.");
                return;
            }

            bool encontrado = BuscarRecursivo(titulo, 0);
            Console.WriteLine(encontrado ? "✅ Encontrado" : "❌ No encontrado");
        }

        /// <summary>
        /// Método auxiliar recursivo que busca un título empezando desde un índice
        /// </summary>
        /// <param name="titulo">Título a buscar</param>
        /// <param name="indice">Índice actual en la lista</param>
        /// <returns>true si lo encuentra, false si no</returns>
        static bool BuscarRecursivo(string titulo, int indice)
        {
            // Caso base: llegamos al final sin encontrar
            if (indice >= catalogo.Count)
                return false;

            // Caso base: encontramos el título
            if (catalogo[indice].Equals(titulo, StringComparison.OrdinalIgnoreCase))
                return true;

            // Llamada recursiva al siguiente índice
            return BuscarRecursivo(titulo, indice + 1);
        }

        /// <summary>
        /// Muestra todas las revistas del catálogo
        /// </summary>
        static void MostrarCatalogo()
        {
            Console.WriteLine("\n--- Catálogo de Revistas ---");
            foreach (string revista in catalogo)
            {
                Console.WriteLine($"• {revista}");
            }
        }
    }
}