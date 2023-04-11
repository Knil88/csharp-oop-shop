using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Product
    {
       
        private int codice;
        public string nome;
        public string descrizione;
        public float prezzo;
        public float iva;

        
        public Product()
        {
            codice = GenerateRandomNumber();
            nome = GetName();
            prezzo = GetPrice();
            iva = 0.22f;

        }





      
        private int GenerateRandomNumber()
        {
            Random rnd = new Random();

          
            return rnd.Next(10000000, 99999999);
        }

      
        private float PriceMoreIva(float prezzo)
        {
            float prezzoIva = (prezzo * this.iva) + prezzo;

            return prezzoIva;
        }

      
        public string NameMoreCode(string name, int code)
        {
            string codiceStringa = Convert.ToString(code);

            return codiceStringa + name;
        }




        public int GetCode()
        {
            return codice;
        }

       
        public float GetPrice()
        {
            return prezzo;
        }
        public void SetPrice(float prezzo)
        {
            this.prezzo = prezzo;
        }

     
        public float GetIvaPrice()
        {
            return PriceMoreIva(prezzo);
        }
        //public void SetIvaPrice(float prezzoIva)
        //{
        //    this.prezzoIva = prezzoIva;
        //}


      
        public string GetName()
        {
            return nome;
        }
        public void SetName(string nome)
        {
            this.nome = nome;
        }

    }
}