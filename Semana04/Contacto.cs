using System;

namespace AgendaTelefonica
{
    /// <summary>
    /// Clase que representa un contacto genérico.
    /// </summary>
    public class Contacto
    {
        /// <summary>
        /// Nombre del contacto.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Apellido del contacto.
        /// </summary>
        public string Apellido { get; set; }

        /// <summary>
        /// Número de teléfono del contacto.
        /// </summary>
        public string Telefono { get; set; }

        /// <summary>
        /// Dirección de correo electrónico del contacto.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Indica si el contacto está activo (true) o eliminado lógicamente (false).
        /// </summary>
        public bool Activo { get; set; }

        /// <summary>
        /// Constructor de la clase Contacto.
        /// </summary>
        /// <param name="nombre">Nombre del contacto.</param>
        /// <param name="apellido">Apellido del contacto.</param>
        /// <param name="telefono">Número de teléfono del contacto.</param>
        /// <param name="email">Dirección de correo electrónico del contacto.</param>
        public Contacto(string nombre, string apellido, string telefono, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Email = email;
            Activo = true; // Por defecto, el contacto está activo al crearse.
        }

        /// <summary>
        /// Método para mostrar los detalles del contacto.
        /// </summary>
        public void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Teléfono: {Telefono}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Activo: {(Activo ? "Sí" : "No")}");
        }
    }
}