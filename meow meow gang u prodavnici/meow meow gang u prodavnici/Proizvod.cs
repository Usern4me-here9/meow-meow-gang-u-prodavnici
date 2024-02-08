
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace meow_meow_gang_u_prodavnici
{
    internal class Proizvod : IComparable
    {
        private string upc, ime, cena;

        public string UPC { get { return upc.ToLower(); } set {  upc = value; } }
        public string IME { get { return ime.ToLower(); } set {  ime = value; } }
        public string CENA { get {  return cena.ToLower(); } set {  cena = value; } }

        public Proizvod(string UPC, string IME, string CENA) {
            upc = UPC;
            ime = IME;
            cena = CENA;
        }

        public string LS_box()
        {
            return upc + ": " + ime + ", " + cena + " dinara";
        }

        public int CompareTo(object obj)
        {
            if (obj is Proizvod)
            {
                return int.Parse(this.cena).CompareTo(int.Parse((obj as Proizvod).cena));
            }
            throw new ArgumentException("Nemoggu da se porede babe i zabe");
        }
    }
}
