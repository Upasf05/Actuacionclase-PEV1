using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace grupo1 //Nombre del programa
{
    internal class Program //Clase interna
    {
        static void Main(string[] args) //Metodo principal 
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
        public int generanumero() //Crear el numero aleatorio como un entero
        {
            Random random = new Random(); //Usar la funcion random para determinar el valor del numero
            return random.Next(1, 101); //Rango numerico que limita el valor aleatorio del numero
        }

        public void adivinarnumero() //Funcion para adivinar el numero
        {
            int intento; //Intento del usuario como un valor entero
            int numero_secreto = generanumero(); //Numero a adivinar como otro entero
            bool adivinar = false; 
            Console.WriteLine("Adivina un numero entre 1 al 100:");
            while (!adivinar) //Funcion while donde se adivina el numero
            {
                Console.WriteLine("Ingrese un numero entre 1 al 100:"); //Mensaje que solicita la introduccion de un entero entre 1 y 100
                intento = int.Parse(Console.ReadLine());

                if (intento == numero_secreto) //Verificar si el numero fue adivinado correctamente
                {
                    Console.WriteLine($"El numero adivinado es {intento}!");
                    adivinar = true;
                }
                else if (intento < numero_secreto) //Si el numero es menor al adivinado
                {
                    Console.WriteLine("El numero es mayor!");
                }
                else //Si el numero es mayor al adivinado
                {
                    Console.WriteLine("El numero es menor!");
                }
            }
        }
    }
}
