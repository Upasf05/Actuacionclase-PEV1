using System;

namespace SistemaExamenes //Nombre del programa
{
    internal class Program //Clase interna
    {
        static void Main(string[] args) //Metodo donde se ejecuta el programa
        {
            Console.WriteLine("Sistema de notas: ingrese un numero del 0 al 100 para obtener una nota de la A a la F:"); //Mensaje que pide la introduccion de un numero segun lo solicitado

            string input = Console.ReadLine()?.Trim(); //Metodo que ejecuta el programa
            if (int.TryParse(input, out int nota)) //Funcion If
            {
                if (nota >= 0 && nota <= 100) //If general para el correcto funcionamiento del programa
                {
                    string letra;

                    if (nota >= 90 && nota <= 100) //Mayor a 90: Aprobado
                    {
                        letra = "A, excelente";
                    }
                    else if (nota >= 80 && nota <= 89) //Mayor a 80: Satisfactorio
                    {
                        letra = "B, satisfactorio";
                    }
                    else if (nota >= 70 && nota <= 79) //Mayor a 70: Aceptable
                    {
                        letra = "C, aceptable";
                    }
                    else if (nota >= 60 && nota <= 69) //Mayor a 60: Mejorable
                    {
                        letra = "D, mejorable";
                    }
                    else  //De 59 para abajo: reprobado o suspendido
                    {
                        letra = "F, reprobado";
                    }

                    Console.WriteLine($"La nota es: {letra}"); //Escribir el resultado segun el numero introducido
                }
                else
                {
                    Console.WriteLine("Ingrese un numero entre 0 y 100."); //Ver si el numero introducido esta en el rango solicitado
                }
            }
            else
            {
                Console.WriteLine("Ingrese un numero valido"); //Ver si se introdujo un numero entero
            }
        }
    }
}
