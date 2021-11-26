using System.Threading.Tasks;
namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            var erstershop = new shop.shopclass();

            #region initialisation 

            var ram1 = new shop.product();
            ram1.name = "corsair vengeance rgb pro";
            ram1.price = 90;
            ram1.sku = 1;
            erstershop.productlist.Add(ram1);

            var ram2 = new shop.product();
            ram2.name = "corsair vengeance LPX";
            ram2.price = 60;
            ram2.sku = 2;
            erstershop.productlist.Add(ram2);

            var motherboard1 = new shop.product();
            motherboard1.name = "gigabyte fusion b550";
            motherboard1.price = 200;
            motherboard1.sku = 3;
            erstershop.productlist.Add(motherboard1);

            var motherboard2 = new shop.product();
            motherboard2.name = "msi b550 gaming plus";
            motherboard2.price = 120;
            motherboard2.sku = 4;
            erstershop.productlist.Add(motherboard2);

            var motherboard3 = new shop.product();
            motherboard3.name = "msi z690";
            motherboard3.price = 300;
            motherboard3.sku = 5;
            erstershop.productlist.Add(motherboard3);

            var processor1 = new shop.product();
            processor1.name = "AMD Ryzen 5 5600X";
            processor1.price = 270;
            processor1.sku = 6;
            erstershop.productlist.Add(processor1);

            var processor2 = new shop.product();
            processor2.name = "AMD Ryzen 5 3600";
            processor2.price = 170;
            processor2.sku = 7;
            erstershop.productlist.Add(processor2);

            var processor3 = new shop.product();
            processor3.name = "Intel Core 5 11400F";
            processor3.price = 250;
            processor3.sku = 8;
            erstershop.productlist.Add(processor3);

            var pccase1 = new shop.product();
            pccase1.name = "corsair 4000D";
            pccase1.price = 80;
            pccase1.sku = 9;
            erstershop.productlist.Add(pccase1);

            var pccase2 = new shop.product();
            pccase2.name = "NZXT h511";
            pccase2.price = 60;
            pccase2.sku = 10;
            erstershop.productlist.Add(pccase2);

            var graphicscard = new shop.product();
            graphicscard.name = "nvidia rtx 3060";
            graphicscard.price = 800;
            graphicscard.sku = 11;
            erstershop.productlist.Add(graphicscard);


            #endregion


            #region inteface

            var customer = new shop.customer();
            customer.name = "unspecifed";

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome in " + erstershop.shopname);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            Console.WriteLine("Sign up:");
            Console.WriteLine("");
            Console.Write("Name:");
            customer.name = Console.ReadLine();
            Console.Write("Password:");
            customer.password = Console.ReadLine();
            Console.Clear();

            #region todays super sale

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("---------------------------------------");

            // random shop item 

            
            Console.WriteLine("Todays Super deal: ");
            
            Random rand = new Random();
            int randomitem = rand.Next(1, erstershop.productlist.Count);
            var firstcart = new shop.cart();
            int jj = erstershop.productlist.Count;
            
            foreach(shop.product p in erstershop.productlist)
            {
                if (p.sku == randomitem)
                {
                    Console.WriteLine(p.name + " for " + p.price + " Pounds");
                }
            }
            Console.WriteLine("---------------------------------------");
            Task.Delay(3000).Wait();
            #endregion


            #region functions

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            do
            {
               
                Console.WriteLine("---------------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Functions: ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(" 1   View all Products in stock");
                Console.WriteLine(" 2   Add Products to your cart");
                Console.WriteLine(" 3   Checkout");
                Console.WriteLine();
                Console.WriteLine("Please select a function:");

                string eingabe1="";
                while(eingabe1 == "")
                {
                    eingabe1 = Console.ReadLine();
                }               
                int eingabe = Convert.ToInt32(eingabe1);
                if (eingabe == 1)                                   // all products in stock 
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine("function 1 selected....");
                    Task.Delay(1000).Wait();
                    Console.Clear();

                    Console.WriteLine("sku   description");
                    foreach (var product in erstershop.productlist)
                    {
                        Console.Write(product.sku + "     ");
                        Console.WriteLine(product.name);
                    }
                    
                    Console.WriteLine("");

                }

                if (eingabe == 2)                                  // add products to cart 
                {
                    string shortsku = "";
                    int tempsku = 0;
                    Console.WriteLine("add products to your cart: ");
                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("please enter sku:");
                    Console.ForegroundColor = ConsoleColor.Black;
                    shortsku = Console.ReadLine();
                    tempsku = Convert.ToInt32(shortsku);
                    int i = 0;

                    

                    foreach (shop.product p in erstershop.productlist)
                    {
                        if (p.sku == tempsku)
                        {
                            firstcart.productcart.Add(p);
                        }
                    }

                    Console.WriteLine("your cart contains:");
                    foreach (shop.product z in firstcart.productcart)
                    {
                        Console.WriteLine(z.name);
                    }

                    Task.Delay(1000).Wait();

                    Console.Clear();
                 
                }

                if (eingabe == 3)                       //checkout
                {
                    Console.WriteLine("");
                    Console.Clear();
                    Console.WriteLine("proceeding to checkout....");
                    Task.Delay(100).Wait();
                    Console.Clear();
                    Console.WriteLine("Hey " + customer.name + ", your selected products: ");
                    Console.WriteLine();
                    foreach (shop.product z in firstcart.productcart)
                    {
                        Console.WriteLine(z.name);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(z.price + " Pounds");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine();
                    Console.Write("Total Cost: ");
                    int totalcost = 0;
                    Console.ForegroundColor = ConsoleColor.Green;
                    foreach (shop.product z in firstcart.productcart)
                    {
                        totalcost = z.price + totalcost;
                    }
                    Console.Write(totalcost + " Pounds");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.WriteLine("the bill will be sent to your address.");
                    Console.WriteLine("Thanks for choosing " + erstershop.shopname);
                    Console.ReadKey();
                    Environment.Exit(0);
                }

            }while(true);
            Console.ReadLine();
            #endregion

            #endregion
        }
    }
}