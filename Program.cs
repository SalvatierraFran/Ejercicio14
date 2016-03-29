using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese lado del cuadrado: ");
            double Lado = double.Parse(Console.ReadLine());
            Console.Write("\nEl area del cuadrado es: " + CalculoDeArea.CalcularCuadrado(Lado));

            Console.Write("\nIngrese base del triangulo: ");
            double Base = double.Parse(Console.ReadLine());
            Console.Write("\nIngrese altura del triangulo: ");
            double Altura = double.Parse(Console.ReadLine());
            Console.Write("\nEl area del triangulo es: " + CalculoDeArea.CalcularTriangulo(Base, Altura));

            Console.Write("\nIngrese radio del circulo: ");
            double Radio = double.Parse(Console.ReadLine());
            Console.Write("\nEl area del circulo es: " + CalculoDeArea.CalcularCirculo(Radio));

            Console.ReadKey();
        }
    }
}
