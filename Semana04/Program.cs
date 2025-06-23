using System;

namespace AgendaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== AGENDA TELEFÓNICA =====");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Mostrar contactos");
            Console.WriteLine("3. Buscar contacto");
            Console.WriteLine("4. Editar contacto");
            Console.WriteLine("5. Eliminar contacto");
            Console.WriteLine("6. Salir");

            int opcion;
            do
            {
                Console.Write("\nSeleccione una opción: ");
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            // Agregar un nuevo contacto
                            ContactManager.AgregarContacto();
                            break;
                        case 2:
                            // Mostrar todos los contactos registrados
                            ContactManager.MostrarContactos();
                            break;
                        case 3:
                            // Buscar un contacto por nombre o apellido
                            ContactManager.BuscarContacto();
                            break;
                        case 4:
                            // Editar información de un contacto existente
                            ContactManager.EditarContacto();
                            break;
                        case 5:
                            // Eliminar un contacto (eliminación lógica)
                            ContactManager.EliminarContacto();
                            break;
                        case 6:
                            Console.WriteLine("Saliendo del programa. ¡Gracias por usar la Agenda Telefónica!");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Inténtelo nuevamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Ingrese un número válido.");
                }

                Console.WriteLine("\nPresione Enter para continuar...");
                Console.ReadLine();
            } while (opcion != 6);
        }
    }
}