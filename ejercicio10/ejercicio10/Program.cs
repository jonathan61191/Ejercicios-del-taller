using System;

//Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor, el del medio y el menor
//de los números ingresados.

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

            //comprobar numeros
                
                //num1 mayor
            if (numero1 > numero2)
            {
                if (numero1 > numero3)
                {
                    Console.Write("el numero mayor es el : " + numero1);
                    Console.Write('\n');
                if (numero2 > numero3)
                    {
                        Console.Write("el numero del medio es el : " + numero2);
                        Console.Write('\n');
                        Console.Write("el numero del menor es el : " + numero3);
                        Console.Write('\n');
                    }
                
                else
                {
                    Console.Write("el numero del medio es el : " + numero3);
                    Console.Write('\n');
                    Console.Write("el numero menor es el : " + numero2);
                    Console.Write('\n');


                    }
                }
                      


            }

            //num2 mayor

            if(numero2 > numero1)
            {
                if (numero2 > numero3)
                {
                    Console.Write("el numero mayor es el : " + numero2);
                    Console.Write('\n');
                    if (numero1 > numero3)
                    {
                        Console.Write("el numero del medio es el : " + numero1);
                        Console.Write('\n');
                        Console.Write("el numero del menor es el : " + numero3);
                        Console.Write('\n');
                    }

                    else
                    {
                        Console.Write("el numero del medio es el : " + numero3);
                        Console.Write('\n');
                        Console.Write("el numero menor es el : " + numero1);
                        Console.Write('\n');


                    }
                }



            }

            //num3 mayor

            if (numero3 > numero1)
            {
                if (numero3 > numero2)
                {
                    Console.Write("el numero mayor es el : " + numero3);
                    Console.Write('\n');
                    if (numero2 > numero1)
                    {
                        Console.Write("el numero del medio es el : " + numero2);
                        Console.Write('\n');
                        Console.Write("el numero del menor es el : " + numero1);
                        Console.Write('\n');
                    }

                    else
                    {
                        Console.Write("el numero del medio es el : " + numero1);
                        Console.Write('\n');
                        Console.Write("el numero menor es el : " + numero2);
                        Console.Write('\n');


                    }
                }



            }
            


        }
    }
}
