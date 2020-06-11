using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Captain : ClubBola
    {
        public override void Posisi()
        {
            Console.WriteLine("Captain sebagai ketua bagi sekelompok pemain.");
            Console.WriteLine("Captain adalah seorang ketua di suatu permainan dan memberi arahan sebagian pemain lainnya.");
        }
    }
}
