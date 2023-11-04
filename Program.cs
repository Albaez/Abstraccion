using System;


namespace Abstraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado();
            cuadrado.Nombre = "Cuadrado";
            cuadrado.Lado = 10;
            cuadrado.Color = "Rosado";
            cuadrado.CalcularArea();
            cuadrado.CalcularPerimetro();
            cuadrado.MostrarDatos();

            Console.WriteLine();

            Circulo circulo = new Circulo();
            circulo.Nombre = "Círculo";
            circulo.Radio = 6;
            circulo.Color = "Verde";
            circulo.CalcularArea();
            circulo.CalcularPerimetro();
            circulo.MostrarDatos();

            Console.ReadKey();
        }
    }

}




