using System;

//Realice un programa en C# donde se tenga la posibilidad de evaluar la siguiente expresión 
//matemática y me permita encontrar el valor de la variable "𝒙":

namespace Ejercicio
{
    public class Punto1
    {
        static void Main(string[] args)
        {
            double resultadoX, vriableInterna, parentesis1, parentesis2,parentesis3,parentesis4,corchete;
            
            //variable A
            Random rnda = new Random();

            int ramdomA = rnda.Next(1, 8);

            //variable B
            Random rndb = new Random();

            int ramdomB = rndb.Next(1, 8);

            //variable C
            Random rndc = new Random();

            int ramdomC = rndc.Next(1, 9);


            parentesis1 = (3 * ramdomA) + (4 * ramdomB);
            corchete = Math.Pow(parentesis1, 3);
            parentesis3 = ramdomC * (Math.Pow(corchete, 2));
            parentesis2 = (2 * ramdomC) + (ramdomA);
            parentesis4 = Math.Pow(parentesis2, 2);
            vriableInterna = parentesis3 / parentesis4; 
            resultadoX = Math.Sqrt(vriableInterna);






        }
    }
}
