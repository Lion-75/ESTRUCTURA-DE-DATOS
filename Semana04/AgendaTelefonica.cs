using System;
using System.Collections.Generic;

namespace AgendaTelefonica
{
    /// <summary>
    /// Clase principal que gestiona la agenda telefónica.
    /// </summary>
    public class AgendaTelefonica
    {
        /// <summary>
        /// Lista de contactos almacenados en la agenda.
        /// </summary>
        private List<Contacto> contactos = new List<Contacto>();

        /// <summary>
        /// Agrega un nuevo contacto a la agenda.
        /// </summary>
        public void AgregarContacto()
        {
            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Ingrese teléfono: ");
            string telefono = Console.ReadLine();

            Console.Write("Ingrese correo electrónico: ");
            string email = Console.ReadLine();

            contactos.Add(new Contacto(nombre, apellido, telefono, email));
            Console.WriteLine("Contacto agregado exitosamente.");
        }

        /// <summary>
        /// Muestra todos los contactos activos en la agenda.
        /// </summary>
        public void MostrarContactos()
        {
            if (contactos.Count == 0)
            {
                Console.WriteLine("No hay contactos registrados.");
                return;
            }

            Console.WriteLine("=== LISTADO DE CONTACTOS ===");
            foreach (var contacto in contactos.Where(c => c.Activo))
            {
                contacto.MostrarDetalles();
                Console.WriteLine(); // Línea en blanco entre contactos
            }
        }

        /// <summary>
        /// Busca contactos por nombre o apellido.
        /// </summary>
        public void BuscarContacto()
        {
            Console.Write("Ingrese nombre o apellido a buscar: ");
            string criterio = Console.ReadLine().ToLower();

            var resultados = contactos.Where(c => (c.Nombre.ToLower().Contains(criterio) || c.Apellido.ToLower().Contains(criterio)) && c.Activo);

            if (!resultados.Any())
            {
                Console.WriteLine("No se encontraron coincidencias.");
                return;
            }

            Console.WriteLine("Resultados de búsqueda:");
            foreach (var contacto in resultados)
            {
                contacto.MostrarDetalles();
                Console.WriteLine(); // Línea en blanco entre contactos
            }
        }

        /// <summary>
        /// Edita la información de un contacto existente.
        /// </summary>
        public void EditarContacto()
        {
            Console.Write("Ingrese índice del contacto a editar: ");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < contactos.Count && contactos[indice].Activo)
            {
                Console.WriteLine($"Editando contacto: {contactos[indice].Nombre} {contactos[indice].Apellido}");

                Console.Write("Nuevo teléfono: ");
                contactos[indice].Telefono = Console.ReadLine();

                Console.Write("Nuevo correo electrónico: ");
                contactos[indice].Email = Console.ReadLine();

                Console.WriteLine("Datos actualizados correctamente.");
            }
            else
            {
                Console.WriteLine("Índice inválido o contacto inactivo.");
            }
        }

        /// <summary>
        /// Elimina un contacto de la agenda (eliminación lógica).
        /// </summary>
        public void EliminarContacto()
        {
            Console.Write("Ingrese índice del contacto a eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < contactos.Count && contactos[indice].Activo)
            {
                contactos[indice].Activo = false;
                Console.WriteLine("Contacto eliminado (inactividad lógica).");
            }
            else
            {
                Console.WriteLine("Índice inválido o contacto ya eliminado.");
            }
        }
    }
}