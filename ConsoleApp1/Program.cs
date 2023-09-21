using System;

//Construir un algoritmo que pida N números por pantalla, cuando el usuario ingrese un número negativo, el programa debe finalizar
//y mostrar en consola la cantidad total de números positivos que ingresó hasta antes de ingresarse el número negativo

namespace Ejercicio
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n, num;
            double contador = 0;

            Console.WriteLine("Por favor ingrese la cantidad de numeros que desea evaluar");
            n= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                contador = contador + 1;

                if (contador < n)
                {
                    
                    Console.WriteLine("Por favor ingrese un numero");
                    num = Convert.ToInt32(Console.ReadLine());


                }

                else break;

                
            }

            Console.WriteLine(string.Format( "la cantidad de numeros ingresada es:{0} ",contador));




        }

            


        
    }
}