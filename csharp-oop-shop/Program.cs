namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();


           
            Console.WriteLine($"Codice: {product1.GetCode()}");

          
            Console.WriteLine("Set Price: ");
            product1.SetPrice(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Prezzo: {product1.GetPrice()}$");

           
            Console.WriteLine($"Prezzo IVA: {product1.GetIvaPrice()}$");


            
            Console.WriteLine("Set Name: ");
            product1.SetName(Console.ReadLine());

           
            Console.WriteLine($"Nome: {product1.NameMoreCode(product1.nome, product1.GetCode())}");


           
            Console.WriteLine(product1.nome);
            Console.WriteLine(product1.prezzo);

        }


    }
}