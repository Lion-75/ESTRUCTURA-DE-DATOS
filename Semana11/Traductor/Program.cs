using System;
using System.Collections.Generic;

namespace Semana11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== TRADUCTOR BÁSICO ESPAÑOL → INGLÉS ===");
            Console.WriteLine("Bienvenido al traductor de la Semana 11 - Estructura de Datos");

            // Diccionario: español → inglés
            var diccionario = new Dictionary<string, string>
            {
                { "tiempo", "time" },
                { "persona", "person" },
                { "año", "year" },
                { "camino", "way" },
                { "día", "day" },
                { "cosa", "thing" },
                { "hombre", "man" },
                { "mundo", "world" },
                { "vida", "life" },
                { "mano", "hand" },
                { "parte", "part" },
                { "niño", "child" },
                { "niña", "child" },
                { "niño/a", "child" },
                { "ojo", "eye" },
                { "mujer", "woman" },
                { "lugar", "place" },
                { "trabajo", "work" },
                { "semana", "week" },
                { "caso", "case" },
                { "punto", "point" },
                { "tema", "point" },
                { "gobierno", "government" },
                { "empresa", "company" },
                { "compañía", "company" }
            };

            int opcion;
            do
            {
                Console.WriteLine("\n==================== MENÚ ====================");
                Console.WriteLine("1. Traducir una frase (español → inglés)");
                Console.WriteLine("2. Agregar palabra al diccionario");
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
                        TraducirFrase(diccionario);
                        break;

                    case 2:
                        AgregarPalabra(diccionario);
                        break;

                    case 0:
                        Console.WriteLine("Gracias por usar el traductor. ¡Hasta la próxima!");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, elija 1, 2 o 0.");
                        break;
                }

            } while (opcion != 0);
        }

        static void TraducirFrase(Dictionary<string, string> diccionario)
        {
            Console.Write("Ingrese una frase en español: ");
            string frase = Console.ReadLine().ToLower();

            char[] separadores = { ' ', '.', ',', ';', ':', '!', '?', '"' };
            string[] palabras = frase.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

            List<string> traduccion = new List<string>();

            foreach (string palabra in palabras)
            {
                string limpia = palabra.Trim();
                if (string.IsNullOrEmpty(limpia)) continue;

                if (diccionario.ContainsKey(limpia))
                {
                    traduccion.Add(diccionario[limpia]); // Traduce al inglés
                }
                else
                {
                    traduccion.Add(limpia); // Deja la palabra en español
                }
            }

            Console.WriteLine("Traducción (parcial): " + string.Join(" ", traduccion));
        }

        static void AgregarPalabra(Dictionary<string, string> diccionario)
        {
            Console.Write("Ingrese la palabra en español: ");
            string espanol = Console.ReadLine().Trim().ToLower();

            if (string.IsNullOrEmpty(espanol))
            {
                Console.WriteLine("Error: La palabra no puede estar vacía.");
                return;
            }

            Console.Write("Ingrese la traducción en inglés: ");
            string ingles = Console.ReadLine().Trim().ToLower();

            if (string.IsNullOrEmpty(ingles))
            {
                Console.WriteLine("Error: La traducción no puede estar vacía.");
                return;
            }

            if (diccionario.ContainsKey(espanol))
            {
                Console.WriteLine($"La palabra '{espanol}' ya está en el diccionario.");
            }
            else
            {
                diccionario[espanol] = ingles;
                Console.WriteLine($"✅ Palabra '{espanol}' agregada con éxito.");
            }
        }
    }
}