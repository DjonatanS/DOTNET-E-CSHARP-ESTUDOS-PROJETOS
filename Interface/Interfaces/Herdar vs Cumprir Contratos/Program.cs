using System;
using Herdar_vs_Cumprir_Contratos.Model.Entities;
using Herdar_vs_Cumprir_Contratos.Model.Enum;
namespace Herdar_vs_Cumprir_Contratos
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape shape1 = new Circle() { Radius = 2, Color = Color.White };
            IShape shape2 = new Retangle() { Width = 5, Height = 4, Color = Color.Black };
            Console.WriteLine(shape1);
            Console.WriteLine(shape2);
            
        }
    }
}
