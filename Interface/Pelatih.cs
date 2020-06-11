using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Pelatih : IClubBola
    {
        public void Posisi()
        {
            Console.WriteLine("Pelatih yang berperan sebagai pemberi arahan kepada pemainnya atau anak buahnya.");
            Console.WriteLine("Pelatih yang memantau anak didiknya di lapangan dan memberi sebuah strategi di suatu permainan.");
        }
    }
}
