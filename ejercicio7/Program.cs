using System;

//Escribir un algoritmo que dados 2 valores de entrada imprima siempre la división del mayor entre el menor.

namespace Ejercicio7
{
    public class Program
    {
        static void Main(string[] args)
        { 
            //declaramos variables
            double numero1, numero2, resulDivi;

            //solicita por pantalla el numero 1 y 2
            Console.WriteLine("Este programa recibe dos numeros y calcula la division del mayor entre el menor");
            Console.WriteLine("\n");
            Console.Write("Ingresa el numero 1: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Write("Ingresa el numero 2: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");

            if (numero1 > numero2)
            {
                resulDivi = numero1 / numero2;
                Console.Write("El reultado de la division es: " + resulDivi);
                Console.WriteLine("\n");
            }
            else
            {
                resulDivi = numero2 / numero1;
                Console.Write("El reultado de la division es: " + resulDivi);
                Console.WriteLine("\n");
            }


        }
    }
}
