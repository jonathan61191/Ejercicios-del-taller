using System;

//Construir un programa que pida un número y luego diga si este número es par o no

namespace Ejercicio8
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resuldiv, resulmul;

            Console.WriteLine("ingresa el numero 1: ");
            numero1 = Convert.ToInt32 (Console.ReadLine());

            resuldiv = numero1 / 2;
            resulmul = resuldiv * 2;

            if (numero1 == resulmul)
            {
                Console.Write("El numero " + numero1 + " es un numero Par");
                Console.Write("\n");
            }

            else {

                Console.Write("El numero " + numero1 + " es un numero Inpar");
                Console.Write("\n");
            }

        }
    }
}
