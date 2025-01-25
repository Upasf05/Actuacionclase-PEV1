using System;

namespace EdadVoto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad:");

            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Ya puedes votar");
            }
            else
            {
                Console.WriteLine("No puedes votar aun");
            }
        }
    }
}
