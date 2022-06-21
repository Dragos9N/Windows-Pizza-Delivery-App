using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPAW
{
    public class Comanda
    {
        public Client client;
        public Adresa adresa;
        public int idComanda;
        public float pretComanda;
        public List<Pizza> pizza = new List<Pizza>();
        public DateTime data;
     
        public Comanda(List<Pizza>pizza2,Client client2, Adresa adresa2, int idComanda2, float pretComanda2, DateTime data2)
        {
            pizza = pizza2;
            client = client2;
            adresa = adresa2;
            idComanda = idComanda2;
            pretComanda = pretComanda2;
            data = data2;
        }
        public Comanda()
        {
            pizza = null;
            client = null;
            adresa = null;
            idComanda = 0;
            pretComanda = 0;
            data = DateTime.Now;
        }
        public void adaugaComanda(Pizza obj)
        {
            pizza.Add(obj);
        }
        public Client Client
        {
            get;set;
        }
        public Adresa Adresa
        {
            get;set;
        }
        public int IdComanda
        {
            get;set;
        }
        public float PretComanda
        {
            get;set;
        }
    }
    
}
