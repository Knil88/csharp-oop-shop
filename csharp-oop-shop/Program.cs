namespace csharp_oop_shop
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            
            Prodotto  mioProdotto = new Prodotto("portafoglio","Bel portafoglio", 9.99m, 22);

            Console.WriteLine($"Il codice prodotto è: {mioProdotto.getCodice()}");
            Console.WriteLine($"Il prezzo base  è: {mioProdotto.prezzo} ");
            //Console.WriteLine($"Il prezzo senza iva  è: {mioProdotto.getPrezzoIva}");

        }
    }
}