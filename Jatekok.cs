using System;
using System.Collections.Generic;
using System.Text;

namespace Doga.Dolgozat
{
    internal class Jatekok
    {
        public string Cim { get; set; }
        public string Mufaj { get; set; }
        public DateTime KiadasDatum { get; set; }
        public int AktivJatekosok { get; set; }
        public double Ertekeles { get; set; }


        public Jatekok(string row)
        {
            var tmp = row.Split(',');
            Cim = tmp[0];
            Mufaj = tmp[1];
            KiadasDatum = Convert.ToDateTime(tmp[2]);
            AktivJatekosok = int.Parse(tmp[3]);
            Ertekeles = double.Parse(tmp[4]);
        }
    }
}
