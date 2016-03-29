using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double resultado;

            resultado = lado * lado;

            return resultado;
        }

        public static double CalcularTriangulo(double Base1, double Altu)
        {
            double resultado;

            resultado = (Base1 * Altu) / 2;

            return resultado;
        }

        public static double CalcularCirculo(double radio)
        {
            double resultado;

            resultado = Math.PI * Math.Pow(radio, 2);

            return resultado;
        }
    }
}
