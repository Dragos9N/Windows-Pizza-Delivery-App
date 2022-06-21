using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPAW
{
    public class Client
    {
       public int idClient;
       public string nume;
       public string prenume;
    
       public Client(int idClient2, string nume2, string prenume2)
        { 
            idClient = idClient2;
            nume = nume2;
            prenume = prenume2;
        }
       public Client()
        {
            idClient = 0;
            nume = null;
            prenume = null;
        }
       public int IdClient
        {
            get;set;
        }
       public string Nume
        {
            get;set;
        }
       public string Prenume
        {
            get;set;
        }
    }
}
