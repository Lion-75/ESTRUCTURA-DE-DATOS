// Programa principal: aquí probamos la lista enlazada
class Program
{
    static void Main(string[] args)
    {
        // Creamos una nueva lista enlazada
        ListaEnlazada lista = new ListaEnlazada();

        // Agregamos algunos datos de prueba
        lista.Agregar(10);
        lista.Agregar(20);
        lista.Agregar(30);
        lista.Agregar(40);

        // Mostramos la lista original
        Console.WriteLine("Lista original:");
        lista.Mostrar();

        // Ejercicio 1: contamos cuántos elementos hay
        int cantidad = lista.ContarElementos();
        Console.WriteLine($"Número de elementos: {cantidad}");

        // Ejercicio 2: invertimos la lista
        lista.Invertir();
        Console.WriteLine("Lista invertida:");
        lista.Mostrar();

        // Esperamos entrada para que no se cierre de inmediato
        Console.ReadLine();
    }
}
