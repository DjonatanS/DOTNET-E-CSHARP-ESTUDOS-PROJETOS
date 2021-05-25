using System;

namespace Classes_e_Metodos
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double CalcArea()
        {
            double p = (A + B + C) / 2;
            return  Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
