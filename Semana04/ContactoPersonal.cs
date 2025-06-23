using System;

namespace AgendaTelefonica
{
    /// <summary>
    /// Clase que representa un contacto personal, heredando de Contacto.
    /// </summary>
    public class ContactoPersonal : Contacto
    {
        /// <summary>
        /// Fecha de cumpleaños del contacto personal.
        /// </summary>
        public DateTime Cumpleanos { get; set; }

        /// <summary>
        /// Constructor de la clase ContactoPersonal.
        /// </summary>
        /// <param name="nombre">Nombre del contacto.</param>
        /// <param name="apellido">Apellido del contacto.</param>
        /// <param name="telefono">Número de teléfono del contacto.</param>
        /// <param name="email">Dirección de correo electrónico del contacto.</param>
        /// <param name="cumpleanos">Fecha de cumpleaños del contacto personal.</param>
        public ContactoPersonal(string nombre, string apellido, string telefono, string email, DateTime cumpleanos)
            : base(nombre, apellido, telefono, email)
        {
            Cumpleanos = cumpleanos;
        }

        /// <summary>
        /// Método para mostrar los detalles del contacto personal.
        /// </summary>
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Cumpleaños: {Cumpleanos.ToShortDateString()}");
        }
    }
}