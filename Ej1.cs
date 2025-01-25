using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace grupo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Llamada al metodo adivinarnumero
            Program program = new Program();
            program.adivinarnumero();
        }

        /// <summary>
        /// ejercicio1 = realizar un menu de opciones 
        /// pasos que vamos a utilizar son :
        /// paso 1= generar el numero 
        /// paso 2= pedir que ingrese un numero al usuario
        /// paso 3= guardar el numero por el usuario
        /// paso 4= conparar si el numero es = al numero del usuario 
        /// paso 5= si el numero es igual ahi queda 
        /// paso 6= comparar si el numero es mayor o menor que  el numero areatoriamente 
        /// paso 7= si es menor imprimir por consola debe ser un numero mayor 
        /// paso 8= sio el es mayor debe imprimir  un numero menor 
        /// paso 9= se repite del paso 4 hasta que que el usuario cumpla 
        /// </summary>
        public int generanumero()
        {
            Random random = new Random();
            return random.Next(1, 101);
        }

        public void adivinarnumero()
        {
            int intento;
            int numero_secreto = generanumero();
            bool adivinar = false;
            Console.WriteLine("Adivina un numero entre 1 al 100:");
            while (!adivinar)
            {
                Console.WriteLine("Ingrese un numero entre 1 al 100:");
                intento = int.Parse(Console.ReadLine());

                if (intento == numero_secreto)
                {
                    Console.WriteLine($"El numero adivinado es {intento}!");
                    adivinar = true;
                }
                else if (intento < numero_secreto)
                {
                    Console.WriteLine("El numero es mayor!");
                }
                else
                {
                    Console.WriteLine("El numero es menor!");
                }
            }
        }
    }
}