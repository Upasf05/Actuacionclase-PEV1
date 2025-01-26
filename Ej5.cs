using System;

namespace EjerciciosSwitch //Nombre del programa
{
    internal class Program //Clase interna
    {
        static void Main(string[] args) //Metodo donde se ejecuta el programa
        {
            Console.WriteLine("Ingrese 1 o 2 para escoger una opcion:");
            Console.WriteLine("1. Determinar si un numero es par o impar.");
            Console.WriteLine("2. Determinar el mayor entre dos numeros.");

            if (int.TryParse(Console.ReadLine(), out int opcion)) //Funcion If para ver si los valores introducidos son enteros
            {
                switch (opcion) //Uso de switch para ambas opciones
                {
                    case 1: //Determinar si un numero es par o impar
                        Console.Write("Ingrese un numero: ");
                        if (int.TryParse(Console.ReadLine(), out int numero)) //Funcion If
                        {
                            switch (numero % 2) //Switch secundario
                            {
                                case 0:
                                    Console.WriteLine($"Par"); //Si el numero introducido es par
                                    break;
                                case 1:
                                    Console.WriteLine($"Impar"); //Si el numero introducido es impar
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un numero valido."); //Ver si se introdujo un numero entero
                        }
                        break;

                    case 2: //Determinar el mayor de dos numeros
                        Console.Write("Ingrese el primer numero: "); //Ver si los valores introducidos son enteros
                        if (int.TryParse(Console.ReadLine(), out int num1)) //Funcion If
                        {
                            Console.Write("Ingrese el segundo numero: ");
                            if (int.TryParse(Console.ReadLine(), out int num2)) //Ver si los valores introducidos son enteros
                            {
                                switch (num1.CompareTo(num2)) //Switch secundario
                                {
                                    case 1:
                                        Console.WriteLine($"El numero mayor es: {num1}."); //Si el numero mayor es el primero
                                        break;
                                    case -1:
                                        Console.WriteLine($"El numero mayor es: {num2}."); //Si el numero mayor es el segundo
                                        break;
                                    case 0:
                                        Console.WriteLine("Ambos numeros son iguales."); //Si se introdujo el mismo numero en ambas opciones
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un numero valido."); //Ver si se introdujo un numero entero
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un numero valido."); //Ver si se introdujo un numero entero
                        }
                        break;

                    default:
                        Console.WriteLine("Seleccione entre 1 y 2."); //Mensaje si se introduce un numero mayor a 2
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ingrese un numero valido."); //Ver si se introdujo un numero entero
            }
        }
    }
}