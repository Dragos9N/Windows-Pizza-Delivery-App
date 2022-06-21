using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPAW
{
    public class Pizza
    {
        public string denumire;
        public float dimensiune;
        public float pret;


        public Pizza(string denumire2, float dimensiune2, float pret2)
        {
            denumire = denumire2;
            dimensiune = dimensiune2;
            pret = pret2;
        }
        public Pizza()
        {
            denumire = "";
            dimensiune = 0;
            pret = 0;
        }
        public string Denumire
        {
            get;set;
        }
        public float Dimensiune
        {
            get;set;
        }
        public float Pret
        {
            get;set;
        }

     //public bool Pizza2(Pizza obj2)
     //   {
     //       return obj2.pret < this.pret;
     //   }
     //   public bool Pizza3(Pizza obj3)
     //   {
     //       return obj3.pret > this.pret;
     //   }
    }
}
