using System;

//Realizar un programa en C# que obtenga el promedio de calificaciones de un grupo de N alumnos.

namespace Ejercicio
{
    public class Program
    {
        static void Main(string[] args)
        {

            //decplaracion de variables

            int n;

            double promedio, nota, notaAcomulado=0  ;

            Console.Write("Por favor ingresar el numero de estudiantes: ");
            n = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.Write("Por favor ingresar la nota del estudiante: ");
                nota = Convert.ToDouble(Console.ReadLine());

                notaAcomulado += nota;
            }

            promedio = notaAcomulado / n;
            Console.Write("\n");
            Console.WriteLine(String.Format("La nota promedio de los {0} estudiantes es: {0} ", n, promedio));





        }
    }
}
