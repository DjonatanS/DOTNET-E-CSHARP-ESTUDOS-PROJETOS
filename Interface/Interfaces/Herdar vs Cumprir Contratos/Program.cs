using System;
using Herdar_vs_Cumprir_Contratos.Model.Entities;
using Herdar_vs_Cumprir_Contratos.Model.Enum;
namespace Herdar_vs_Cumprir_Contratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Circle() { Radius = 2, Color = Color.White };
            Shape shape2 = new Retangle() { Width = 5, Height = 4, Color = Color.Black };
        }
    }
}
