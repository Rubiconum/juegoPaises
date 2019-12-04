using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego.src.LibreriasJuego
{
    class Dummy
    {
        public static void Main()
        {
            pintarEvaluacion(cuadrado, 5);
            pintarEvaluacion((j)=>j/3, 5);
            pintarEvaluacion(tercio,5);
        }
        public static int tercio(int j) {
            return j / 3;
        }
        public static int cuadrado(int x)
        {
            return x * x;
        }

        public static void pintarEvaluacion(Func<int, int> funcion, int x)
        {
            int resultado = funcion(x);
            Console.WriteLine("El resultado es" + resultado);
        }
    }

}
