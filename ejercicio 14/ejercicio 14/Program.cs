using System;

//Elabora un algoritmo que imprima los números del 1 al 100. Que calcule la suma de todos los
//números pares por un lado, y por otro, la de todos los impares

namespace Ejercicio
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            double   resulPar = 0, resulInPar = 0;

            for (int i = 1; i <= 6;  i++) 
            
            {
                


                if ( i % 2 == 0)
                {
                    resulPar = resulPar + i;
                }

                else
                {
                    resulInPar = resulInPar + i;
                }

                Console.Write(i + ", ");

            };

            Console.Write("\n");
            Console.WriteLine(String.Format("la suma de todos los numeros pares es: {0} ", resulPar));
            Console.Write("\n");
            Console.WriteLine(String.Format("la suma de todos los numeros INpares es: {0} ", resulInPar));


            ////Declaracion de variables
            //double numero100 = 6, resulSuma = 0, resulPar = 0, resulInPar = 0;


            //while (resulSuma < 6)
            //{
            //    resulSuma++;


            //    if (resulSuma % 2 == 0)
            //    {
            //        resulPar = resulPar + resulSuma;
            //    }

            //    else
            //    {
            //        resulInPar = resulInPar + resulSuma;
            //    }

            //    Console.Write(resulSuma + ", ");

            //};

            //Console.Write("\n");
            //Console.WriteLine(String.Format("la suma de todos los numeros pares es: {0} ", resulPar));
            //Console.Write("\n");
            //Console.WriteLine(String.Format("la suma de todos los numeros INpares es: {0} ", resulInPar));

        }
    }
}

