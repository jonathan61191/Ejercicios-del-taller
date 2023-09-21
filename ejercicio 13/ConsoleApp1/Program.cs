using System;

//Crear un programa que pida un número, hacer la suma de los números naturales igual e
//inferiores a dicho número ingresado y mostrar el resultado. DONE

namespace Ejercicio
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //Declaracion de variables
            double numero, resulSuma=0,resulSuma2=0;

            //pedir el numero por pantalla
            Console.Write("Ingrese el numero que dese sumar: ");
            numero = Convert.ToDouble(Console.ReadLine());

            while (resulSuma < numero)  
            {
                resulSuma++;

                resulSuma2 = resulSuma2 +resulSuma;
                    };

            Console.Write(String.Format("la suma de todos los numeros hasta este numero es: {0} ", resulSuma2));
            //Console.Write("Ingrese el numero que dese sumar: ");
        }
    }
}
