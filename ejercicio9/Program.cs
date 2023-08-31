using System;

//Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor de los números ingresados.

namespace Ejercicio9
{
    public class Program
    {
        static void Main(string[] args)
        { 
            //declaracion de variables
            double numero1, numero2, numero3, numeroMayor;

            //solicitar numeros por pantalla
            Console.Write("ingrese el numero 1: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("ingrese el numero 2: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("ingrese el numero 3: ");
            numero3 = Convert.ToDouble(Console.ReadLine());

            if (numero1 > numero2)
            {
                if (numero1 > numero3)
                {
                    Console.Write("el numero mayor es el : " + numero1);
                }
            }
            else 
            {
                if (numero2 > numero1)
                {
                    if (numero2 > numero3)
                    {
                        Console.Write("el numero mayor es el : " + numero2);
                    }
                }

                else
                {
                    if (numero3 > numero1)
                    {
                        if (numero3 > numero2)
                        {
                            Console.Write("el numero mayor es el : " + numero3);
                        }
                    }
                }
            }

        }
    }
}
