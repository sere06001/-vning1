using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning1
{
    internal class Bil
    {
        public string märke;
        public string modell;
        public int årsmodell;
        public int streckakörd;
        public string plåtnummer;
        public Bil(string mä, string mo, int år, int str, string plåt)
        {
            märke = mä;
            modell = mo;
            årsmodell = år;
            streckakörd = str;
            plåtnummer = plåt;
        }
        public Bil() { }
    }
}
