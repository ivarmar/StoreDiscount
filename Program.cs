using System.Collections;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace StoreDiscount;

class Program
{

    static void Main(string[] args)
    {
        Product backpack = new Product("Backpack", 100, 60);
        Product tent = new Product(name: "Tent", inventory: 30, price: 100); // bare testet om det er
        Product water = new Product("Water", 75, 5);                         // forkjell fra de uten "inlined"
        Product pie = new Product("Meat-Pie", 4, 10);                      //PS: tror ikke det bare lettere å holde styr med.
        bool inShop = true;
        while (inShop)
        {


            ShopMenu();

            void ShopMenu()
            {
                Console.WriteLine("Welcome to the shop! please select a product to see the inventory.");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("1. A lightweight backpack perfect for an adventure!");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("2. Tent for 1 person, very light. NB: very easy to spot");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("3. Water, essential for anything to live.");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("4. Freshly baked pie, we only have meat-pies right now");
                Console.WriteLine("---------------------------------------------------------");
                Console.Write("What would you like? ");
                var userInput = Convert.ToInt32(Console.ReadLine());
                object productName = userInput switch
                {
                    1 => backpack.ProductInfo(),
                    2 => tent.ProductInfo(),
                    3 => water.ProductInfo(),
                    4 => pie.ProductInfo(),
                    _ => "We dont have that product sorry"
                };
                Console.WriteLine($"{productName}");
                Console.ReadKey();

            }
        }
    }
}
// 2.   Et program som ser på antall produkter en 
//      butikk har av en gitt vare, og skriver ut i terminalen
//      hvor mange prosent avslag den skal ha basert på mengden produkter.