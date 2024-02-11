using System;

class Program
{
    static void Main(string[] args)
    {
        ListaTareas listaTareas = new ListaTareas();

        Console.WriteLine("¡Bienvenido a la lista de tareas!");

        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Eliminar tarea");
            Console.WriteLine("3. Mostrar tareas");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida. Intente nuevamente.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el nombre de la tarea a agregar: ");
                    string nuevaTarea = Console.ReadLine();
                    listaTareas.AgregarTarea(nuevaTarea);
                    Console.WriteLine("Tarea agregada correctamente.");
                    break;
                case 2:
                    Console.Write("Ingrese el nombre de la tarea a eliminar: ");
                    string tareaEliminar = Console.ReadLine();
                    listaTareas.EliminarTarea(tareaEliminar);
                    Console.WriteLine("Tarea eliminada correctamente.");
                    break;
                case 3:
                    listaTareas.MostrarTareas();
                    break;
                case 4:
                    Console.WriteLine("¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }
        }
    }
}
