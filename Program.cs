using System;

namespace Ejercicio3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar cuatro números distintos 
            // y luego mostrar por pantalla el menor de ellos
            
            int A, B, C, D, Min; 

            Console.WriteLine("Introduce el primer numero");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el tercer numero");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el cuarto numero");
            D = int.Parse(Console.ReadLine());

            Min = A;

            if (B < Min)
                Min = B;
            if (C < Min)
                Min = C;
            if (D < Min)
                Min = D;
            
            Console.WriteLine("El menor de los numeros es: " + Min);
            Console.WriteLine("Fin del programa");
        }
    }
}
