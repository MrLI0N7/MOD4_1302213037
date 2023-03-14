using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD4_1302213037
{
    public class KodeBuah
    {
        public enum Buah
        {
            Apel, Aprikot, Alpukat, Pisang, Paprika,
            Blackberry, Ceri, Kelapa, Jagung, Kurma,
            Durian, Anggur, Melon, Semangka
        };
        public string getKodeBuah(Buah buah)
        {
            string[] kode = { "A00", "B00", "C00", "D00", "E00", "F00", "G00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
            return kode[(int)buah];

        }
    }
}
