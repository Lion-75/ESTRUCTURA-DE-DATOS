// Clase que representa una lista enlazada simple
public class ListaEnlazada
{
    // Nodo cabeza: el primer nodo de la lista
    private Nodo cabeza;

    // Constructor: crea una lista vacía
    public ListaEnlazada()
    {
        cabeza = null;
    }

    // Método para agregar un nuevo dato al final de la lista
    public void Agregar(int dato)
    {
        Nodo nuevo = new Nodo(dato); // Crear nuevo nodo con el dato

        // Si la lista está vacía, el nuevo nodo será la cabeza
        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            // Si no, recorrer hasta el final y agregar el nuevo nodo
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    // Método para mostrar todos los elementos de la lista
    public void Mostrar()
    {
        Nodo actual = cabeza;

        // Recorremos la lista desde la cabeza hasta el final
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> "); // Mostrar el dato
            actual = actual.Siguiente;          // Avanzar al siguiente nodo
        }

        Console.WriteLine("null"); // Indicamos el final de la lista
    }

    // Ejercicio 1: contar cuántos elementos hay en la lista
    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = cabeza;

        // Recorremos y contamos los nodos
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }

        return contador; // Devolvemos la cantidad total
    }

    // Ejercicio 2: invertir la lista enlazada
    public void Invertir()
    {
        Nodo anterior = null;
        Nodo actual = cabeza;
        Nodo siguiente = null;

        // Mientras no lleguemos al final
        while (actual != null)
        {
            siguiente = actual.Siguiente;     // Guardar el siguiente nodo
            actual.Siguiente = anterior;      // Invertir el enlace
            anterior = actual;                // Mover "anterior" al actual
            actual = siguiente;               // Mover al siguiente nodo
        }

        cabeza = anterior; // La nueva cabeza es el último nodo original
    }
}
