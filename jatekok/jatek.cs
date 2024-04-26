using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jatekok
{
    internal class jatek
    {
        public int megjelenes { get; set; }
        public string cim { get; set; }
        public string mufaj { get; set; }
        public string kiado { get; set; }
        public string platform { get; set; }

        public jatek(string input)
        {
            string[] dbok = input.Split(';');
            megjelenes = int.Parse(dbok[0]);
            cim = dbok[1];
            mufaj = dbok[2];
            kiado = dbok[3];
            platform = dbok[4];
        }
    }
}
