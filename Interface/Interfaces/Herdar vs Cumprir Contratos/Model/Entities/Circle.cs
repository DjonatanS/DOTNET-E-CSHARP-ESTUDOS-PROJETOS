using System;
using System.Globalization;
using Herdar_vs_Cumprir_Contratos.Model.Enum;

namespace Herdar_vs_Cumprir_Contratos.Model.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }
        public Color Color { get; internal set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle Color = "
                + Color
                + ", Radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", area"
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
