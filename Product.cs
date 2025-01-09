using System;
namespace StoreDiscount
{

    class Product
    {
        string Name { get; set; }

        int Inventory { get; set; }

        int Price { get; set; }

        public Product(string name, int inventory, int price)
        {
            Name = name;
            Inventory = inventory;
            Price = price;
        }

        public string ProductInfo()
        {
            return $"Name: {Name}\nIn Stock: {Inventory}\nPrice: {Price} gold\nDiscount: {Discounts()}";
        }

        public int Discounts()
        {
            var discount = 0;
            if (Inventory >= 100)
            {
                discount = 10;
            }
            else if (Inventory >= 50)
            {
                discount = 5;
            }
            return (Price * discount) / 100;
        }

    }
}