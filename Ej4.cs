using System;

namespace DiasDeLaSemana //Nombre del programa
{
    internal class Program //Clase interna
    {
        static void Main(string[] args) //Metodo donde se ejecuta el programa
        {
            Console.Write("Ingrese un numero del 1 al 7 para obtener un dia de la semana: "); //Mensaje que pide la introduccion de un numero para el programa ejecute su funcion

            if (int.TryParse(Console.ReadLine(), out int dia)) //Funcion If
            {
                switch (dia) //Uso de switch para los dias de la semana
                {
                    case 1:
                        Console.WriteLine("Lunes."); //1=Lunes
                        break;
                    case 2:
                        Console.WriteLine("Martes."); //2=Martes
                        break;
                    case 3:
                        Console.WriteLine("Miercoles."); //3=Miercoles
                        break;
                    case 4:
                        Console.WriteLine("Jueves."); //4=Jueves
                        break;
                    case 5:
                        Console.WriteLine("Viernes."); //5=Viernes
                        break;
                    case 6:
                        Console.WriteLine("Sabado."); //6=Sabado
                        break;
                    case 7:
                        Console.WriteLine("Domingo."); //7=Domingo
                        break;
                    default:
                        Console.WriteLine("Ingrese un numero entre 1 y 7."); //Mensaje si se introdujo un numero fuera del rango
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ingrese un numero valido."); //Mensaje si no se introdujo un valor entero
            }
        }
    }
}    