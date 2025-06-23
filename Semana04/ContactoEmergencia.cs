using System;

namespace AgendaTelefonica
{
    /// <summary>
    /// Clase que representa un contacto de emergencia, heredando de Contacto.
    /// </summary>
    public class ContactoEmergencia : Contacto
    {
        /// <summary>
        /// Relación del contacto de emergencia (por ejemplo, "Padre", "Madre", "Hermano").
        /// </summary>
        public string Relacion { get; set; }

        /// <summary>
        /// Constructor de la clase ContactoEmergencia.
        /// </summary>
        /// <param name="nombre">Nombre del contacto.</param>
        /// <param name="apellido">Apellido del contacto.</param>
        /// <param name="telefono">Número de teléfono del contacto.</param>
        /// <param name="email">Dirección de correo electrónico del contacto.</param>
        /// <param name="relacion">Relación del contacto de emergencia.</param>
        public ContactoEmergencia(string nombre, string apellido, string telefono, string email, string relacion)
            : base(nombre, apellido, telefono, email)
        {
            Relacion = relacion;
        }

        /// <summary>
        /// Método para mostrar los detalles del contacto de emergencia.
        /// </summary>
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Relación: {Relacion}");
        }
    }
}