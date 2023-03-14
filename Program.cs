using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD4_1302213037
{

    internal class Program
    {
        static void Main(string[] args)
        {
            KodeBuah B = new KodeBuah();
            KodeBuah.Buah Banana =  KodeBuah.Buah.Pisang;
            string kodeBuah = B.getKodeBuah(Banana);
            Console.WriteLine("Kode dari buah "+Banana+" adalah "+ kodeBuah);
        }
    }
}
