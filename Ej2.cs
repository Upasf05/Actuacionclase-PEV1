using System;

namespace EdadVoto //Nombre del programa.
{
    internal class Program //Clase interna.
    {
        static void Main(string[] args) //Metodo principal.
        {
            Console.WriteLine("Ingrese su edad:"); //Solicitar el ingreso de edad.

            int edad = int.Parse(Console.ReadLine()); //Leer el valor entero edad.

            if (edad >= 18) //Verificar si el numero (en este caso la edad) es mayor a 18.
            {
                Console.WriteLine("Ya puedes votar"); //Mensaje si el numero es 18 o mayor.
            }
            else //Activar el else si el numero es menor.
            {
                Console.WriteLine("No puedes votar aun"); //Mensaje si el numero es menor.
            }
        }
    }
}
