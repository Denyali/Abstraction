using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Pemain : ClubBola
    {
        public override void Posisi()
        {
            Console.WriteLine("Pemain adalah yang melakukan sebuah aksi.");
            Console.WriteLine("Orang yang melakukan memainkan di suatu pertandingan.");
        }
    }
}
