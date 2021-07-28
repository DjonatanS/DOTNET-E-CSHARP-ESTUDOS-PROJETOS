using Hereança_Multipla.Devices;
using System;

namespace Hereança_Multipla
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() {SerialNumber = 1020 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 1021 };
            s.ProcessDoc("My lettering");
            Console.WriteLine(s.Scan());

            Console.WriteLine("Combo Device");
            ComboDevice c = new ComboDevice() { SerialNumber = 10250 };
           
            Console.WriteLine(c.Scan());
            c.ProcessDoc("Combo");
            c.Print("Letter");
            
        }
    }
}
