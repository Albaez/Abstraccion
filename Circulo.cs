using System;
using static Abstraccion.Program;

namespace Abstraccion
{
    public class Circulo : FiguraGeometrica
    {
        public double Radio { get; set; }

        public override void CalcularArea()
        {
            Area = Math.PI * Radio * Radio;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = 2 * Math.PI * Radio;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Radio: " + Radio);
            Console.WriteLine("Área: " + Area);
            Console.WriteLine("Perímetro: " + Perimetro);
            Console.WriteLine("Color: " + Color);
        }
    }

}
