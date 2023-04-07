using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Prodotto
    {
        private int codice;
        public string nome;
        public string descrizione;
        public decimal prezzo;
        public int iva;
        public decimal prezzoIva;
        Random rnd = new Random();
        public int getCodice()
        {
          

            return codice;
        }

        public int getPrezzoIva()
        {
            

            return prezzoIva;
        }

        public Prodotto(string nome, string descrizione, decimal prezzo , int iva)
        {
            
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo= prezzo;
            this.iva = iva;
            Random rnd = new Random();
            codice = rnd.Next(1, 11);
            prezzoIva= prezzo / (1 + (iva / 100));


        }

       

    }
}
