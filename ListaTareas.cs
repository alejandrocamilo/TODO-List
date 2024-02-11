using System;

class ListaTareas
{
    private Tarea cabeza;

    public ListaTareas()
    {
        cabeza = null;
    }

    public void AgregarTarea(string nombre)
    {
        Tarea nuevaTarea = new Tarea(nombre);
        if (cabeza == null)
        {
            cabeza = nuevaTarea;
        }
        else
        {
            Tarea actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevaTarea;
        }
    }

    public void EliminarTarea(string nombre)
    {
        if (cabeza != null)
        {
            if (cabeza.Nombre == nombre)
            {
                cabeza = cabeza.Siguiente;
            }
            else
            {
                Tarea anterior = cabeza;
                Tarea actual = cabeza.Siguiente;
                while (actual != null && actual.Nombre != nombre)
                {
                    anterior = actual;
                    actual = actual.Siguiente;
                }
                if (actual != null)
                {
                    anterior.Siguiente = actual.Siguiente;
                }
            }
        }
    }

    public void MostrarTareas()
    {
        Console.WriteLine("Lista de tareas pendientes:");
        Tarea actual = cabeza;
        while (actual != null)
        {
            Console.WriteLine(actual.Nombre);
            actual = actual.Siguiente;
        }
    }
}