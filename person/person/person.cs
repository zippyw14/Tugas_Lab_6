using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace program
{
    public class person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Infoperson()
        {
            Console.WriteLine("Nama saya {0},da umur saya{1}",Name,Age);
        }

    }
    public class karyawan : person
    {
        public string idkaryawan { get; set; }
        public string subjek { get; set; }

        public karyawan(string name, int age) : base(name, age)
        {
           
        }

        public void Infoperson()
        {
            Console.WriteLine("saya disimi sebagai {0} \n", subjek);
        }

    }

}
