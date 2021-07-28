using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hereança_Multipla.Devices
{
    class ComboDevice : Device, IPrinter, IScanner
    {
        public void Print(string document)
        {
            Console.WriteLine("Combo Device Print:" + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Combo Device Process:" + document);
        }

        public string Scan()
        {
            return "Combo Device Result";
        }
    }
}
