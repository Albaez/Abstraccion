using System;
using static Abstraccion.Program;

namespace Abstraccion
{
    public class Cuadrado : FiguraGeometrica
    {
        public double Lado { get; set; }

        public override void CalcularArea()
        {
            Area = Lado * Lado;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = 4 * Lado;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Lado: " + Lado);
            Console.WriteLine("Área: " + Area);
            Console.WriteLine("Perímetro: " + Perimetro);
            Console.WriteLine("Color: " + Color);
        }
    }
}
