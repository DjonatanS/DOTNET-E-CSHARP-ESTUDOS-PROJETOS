using System;

namespace IntroDelegate
{

    delegate double BinaryNumericOperation(double n1, double n2);
    delegate double SingleNumericOperation(double n1);


    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 20;

            BinaryNumericOperation somar = CalculationService.Sum;
            SingleNumericOperation area = CalculationService.Square;

            
            
            Console.WriteLine(somar(a, b));
            Console.WriteLine(area(a));
        }
    }
}
