/* made by basti
 * 
 * 11.01.2021 01:46
 * 
 * revision 3:
 * additions:
 * - protected idiotproof inputs
 * - more commeting 
 * - new design
 */


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

            string entryvip;


            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome in " + erstershop.shopname);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("");

            Console.Write("do you wanna subscribe to our ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("gold VIP PRO ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("membership ?");
            Console.WriteLine("y/n");
            
            do
            {
                entryvip = Console.ReadLine();
            } while ((entryvip != "y") && (entryvip != "n"));
            
            
            Console.Clear();

            #region signup

            if (entryvip == "y")
            #region vip
            {

                // VIP Welcome Screen
                
                Console.WriteLine("Nice to have you here :)");
                var customer = new shop.vip_customer();
                customer.name = "unspecifed";

                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.White;
                
                Console.WriteLine("VIP Sign up:");

                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("");

                // User Data Requests 

                Console.Write("Name:");

                customer.name = Console.ReadLine();


                Console.Write("Password:");
                Console.ForegroundColor = ConsoleColor.Gray;

                customer.password = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                // Adress Data Request

                Console.WriteLine("");
                Console.WriteLine("It looks like you are a new customer, so we will need your Address.");
                Console.WriteLine("");
                Console.Write("Address:");
                customer.address = Console.ReadLine();

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

                foreach (shop.product p in erstershop.productlist)
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
                    int entry = 0;

                    // First Function Display


                    Console.WriteLine("");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Functions: ");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("");

                    Console.WriteLine(" 1   View all Products in stock");
                    Console.WriteLine(" 2   Add Products to your cart");
                    Console.WriteLine(" 3   Checkout");
                    Console.WriteLine();
                    Console.WriteLine("Please select a function:");

                    try
                    {
                        entry = Convert.ToInt32(Console.ReadLine());

                    }
                    catch
                    {

                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Please enter a valid int");
                        Task.Delay(1000).Wait();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Gray;
                        
                    }

                    #region Function 1 view all products

                    if (entry == 1)                                   
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();

                        Console.WriteLine("");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("All Products: ");
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("");

                        Console.WriteLine("sku   description");
                        foreach (var product in erstershop.productlist)
                        {
                            Console.Write(product.sku + "     ");
                            Console.WriteLine(product.name);
                        }

                        Console.WriteLine("");

                    }

                    #endregion

                    #region Function 2 addproductscart

                    if (entry == 2)                                  
                    {
                        string shortsku = "";
                        int tempsku = 0;

                        Console.WriteLine("");

                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("add products to your cart: ");
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("please enter sku:");
                        
                        try
                        {
                            shortsku = Console.ReadLine();
                            tempsku = Convert.ToInt32(shortsku);
                        }

                        catch
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Please enter a number..");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Task.Delay(1000).Wait();

                        }

                        // add product

                        foreach (shop.product p in erstershop.productlist)
                        {
                          if (p.sku == tempsku)
                          {
                            firstcart.productcart.Add(p);
                          }
                        }

                        // show cart

                        Console.WriteLine("your cart contains:");
                        foreach (shop.product z in firstcart.productcart)
                        {
                            Console.WriteLine(z.name);
                        }

                        Task.Delay(1000).Wait();

                        Console.Clear();

                    }
                    #endregion

                    #region Function 3 checkout

                    if (entry == 3)                       
                    {
                        Console.WriteLine("");
                        Console.Clear();
                        Console.WriteLine("proceeding to checkout....");
                        Task.Delay(100).Wait();
                        Console.Clear();

                        Console.WriteLine("");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Checkout: ");
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;

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
                        int totaldiscount = 0;
                        int totalprice = 0;
                        
                        totalprice = (totalcost / 100) * (100 - customer.perk);

                        totaldiscount = totalprice - totalcost;


                        Console.Write(totalprice + " Pounds");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine();
                        Console.WriteLine("-----------------");
                        Console.Write("You just saved ");
                        Console.Write(totaldiscount);
                        
                        Console.WriteLine("");
                        Console.WriteLine("the bill will be sent to your address: " + customer.address);
                        Console.WriteLine("Thanks for choosing " + erstershop.shopname);
                        Task.Delay(10000).Wait();
                        Environment.Exit(0);
                    }
                    #endregion

                    if (entry > 3 || entry <1 && entry !=0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Please select one of the displayed functions..");
                        Task.Delay(1000).Wait();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Clear();
                    }

                } while (true);

                #endregion



            }
            #endregion
            else
            #region notvip
            {
                // Regular Welcome Screen

                Console.WriteLine("Maybe another time ..");
                var customer = new shop.regular_customer();
                customer.name = "unspecifed";

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Sign up:");

                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("");

                // User Data Requests 

                Console.Write("Name:");

                customer.name = Console.ReadLine();


                Console.Write("Password:");
                Console.ForegroundColor = ConsoleColor.Gray;

                customer.password = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                // Adress Data Request

                Console.WriteLine("");
                Console.WriteLine("It looks like you are a new customer, so we will need your Address.");
                Console.WriteLine("");
                Console.Write("Address:");
                customer.address = Console.ReadLine();

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

                foreach (shop.product p in erstershop.productlist)
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
                    int entry = 0;

                    // First Function Display


                    Console.WriteLine("");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Functions: ");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("");

                    Console.WriteLine(" 1   View all Products in stock");
                    Console.WriteLine(" 2   Add Products to your cart");
                    Console.WriteLine(" 3   Checkout");
                    Console.WriteLine();
                    Console.WriteLine("Please select a function:");

                    try
                    {
                        entry = Convert.ToInt32(Console.ReadLine());

                    }
                    catch
                    {

                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Please enter a valid int");
                        Task.Delay(1000).Wait();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Gray;

                    }

                    #region Function 1 view all products

                    if (entry == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();

                        Console.WriteLine("");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("All Products: ");
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("");

                        Console.WriteLine("sku   description");
                        foreach (var product in erstershop.productlist)
                        {
                            Console.Write(product.sku + "     ");
                            Console.WriteLine(product.name);
                        }

                        Console.WriteLine("");

                    }

                    #endregion

                    #region Function 2 addproductscart

                    if (entry == 2)
                    {
                        string shortsku = "";
                        int tempsku = 0;

                        Console.WriteLine("");

                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("add products to your cart: ");
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("please enter sku:");

                        try
                        {
                            shortsku = Console.ReadLine();
                            tempsku = Convert.ToInt32(shortsku);
                        }

                        catch
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Please enter a number..");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Task.Delay(1000).Wait();

                        }

                        // add product

                        foreach (shop.product p in erstershop.productlist)
                        {
                            if (p.sku == tempsku)
                            {
                                firstcart.productcart.Add(p);
                            }
                        }

                        // show cart

                        Console.WriteLine("your cart contains:");
                        foreach (shop.product z in firstcart.productcart)
                        {
                            Console.WriteLine(z.name);
                        }

                        Task.Delay(1000).Wait();

                        Console.Clear();

                    }
                    #endregion

                    #region Function 3 checkout

                    if (entry == 3)
                    {
                        Console.WriteLine("");
                        Console.Clear();
                        Console.WriteLine("proceeding to checkout....");
                        Task.Delay(100).Wait();
                        Console.Clear();

                        Console.WriteLine("");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Checkout: ");
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;

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
                        Console.WriteLine();
                        Console.WriteLine("-----------------");
                        

                        Console.WriteLine("");
                        Console.WriteLine("the bill will be sent to your address: " + customer.address);
                        Console.WriteLine("Thanks for choosing " + erstershop.shopname);
                        Task.Delay(5000).Wait();
                        Environment.Exit(0);
                    }
                    #endregion

                    if (entry > 3 || entry < 1 && entry != 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Please select one of the displayed functions..");
                        Task.Delay(1000).Wait();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Clear();
                    }

                } while (true);

                #endregion

            }
            #endregion

            #endregion




            #endregion
        }
    }
}