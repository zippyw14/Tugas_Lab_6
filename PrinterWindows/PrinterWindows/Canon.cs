﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterWindows
{
    public class Canon : PrinterWindows
    {
        public override void show()
        {
            Console.WriteLine("\nCanon display dimension : 9.5*12");
        }

        public override void print()
        {
            Console.WriteLine(" printer printing...");
        }
    }
}
