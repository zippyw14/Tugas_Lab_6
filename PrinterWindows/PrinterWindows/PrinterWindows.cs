using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterWindows
{
    public class PrinterWindows
    {
        public string Tipe { get; set; }

        public virtual void print()
        {
            Console.WriteLine(" printer printing.... ");
        }
        public virtual void show()
        {
            Console.WriteLine(" Display dimension : ");
        }
    }
}
