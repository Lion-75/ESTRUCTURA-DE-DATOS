// Clase Nodo representa un elemento (nodo) de la lista enlazada
public class Nodo
{
    // Almacena el dato del nodo
    public int Dato;

    // Puntero al siguiente nodo en la lista
    public Nodo Siguiente;

    // Constructor del nodo, recibe un dato
    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null; // Al crear un nodo nuevo, no apunta a nada aún
    }
}
