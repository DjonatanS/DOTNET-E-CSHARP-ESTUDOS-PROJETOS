﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hereança_Multipla.Devices
{
    class Scanner : Device , IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing" + document);
        }

        public string Scan()
        {
            return "scan scanner result";
        }
    }
}
