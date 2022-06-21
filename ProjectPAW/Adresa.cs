using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPAW
{
    public class Adresa
    {
        public string oras;
        public string strada;
        public int numar;

        public Adresa(string oras2, string strada2, int numar2)
        {
            oras = oras2;
            strada = strada2;
            numar = numar2;
        }
        public Adresa()
        {
            oras = null;
            strada = null;
            numar = 0;
        }
        public string Oras
        {
            get;set;
        }
        public string Strada
        {
            get;set;
        }
        public int Numar
        {
            get;set;
        }
    }
}
