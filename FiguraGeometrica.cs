using System;


namespace Abstraccion
{
    public abstract class FiguraGeometrica
    {
        public string Nombre { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }
        public string Color { get; set; }

        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();
        public abstract void MostrarDatos();
    }

}
