using System;

class Tarea
{
    public string Nombre { get; set; }
    public Tarea Siguiente { get; set; }

    public Tarea(string nombre)
    {
        Nombre = nombre;
        Siguiente = null;
    }
}