using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person person1 = new person(" Faqih Rizky Alfaoz", 19);
            person1.Infoperson();

            karyawan karyawan1 = new karyawan("Hilmi", 19);
            karyawan1.Infoperson();
            karyawan1.Infoperson("pegawai");
        }
    }
}
