namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            var erstershop = new shop.shopclass();

            Console.WriteLine("");
            Console.WriteLine("Welcome in " + erstershop.shopname);
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Todays Super deal: ");

            // random shop item 


            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Functions: ");
            Console.WriteLine(" 1   View all Products in stock");
            Console.WriteLine(" 2   Add Products to your cart");
            Console.WriteLine(" 3   Checkout");
            Console.WriteLine();
            Console.WriteLine("Please select a function:");

            Console.ReadLine(); 
        }
    }
}