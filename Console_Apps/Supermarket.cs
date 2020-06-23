using System;
namespace Supermarket {
    class Product {
        private string name;
        private int price, weight;
        public void Set (string name, int price, int weight) {
            this.name = name;
            this.price = price;
            this.weight = weight;
        }
        public string GetName () { return name; }
        public int GetPrice () { return price; }
        public int GetWeight () { return weight; }
    }
    class Buy : Product {
        private int buyability, price_all_purchased, total_weight;
        public void SetAbility (int buyability) { this.buyability = buyability; }
        public int GetBuyAbility () { return buyability; }
        public int GetPriceAllPurchased () { 
            price_all_purchased = buyability * GetPrice (); 
            return price_all_purchased; 
        }
        public int GetTotoalWeight () {
            total_weight = GetWeight () * buyability;
            return total_weight;
        }
    }
    class Check : Buy {
        public void Print () {
            Console.WriteLine ($"Product: {GetName ()}");
            Console.WriteLine ($"Price: {GetPrice ()} $");
            Console.WriteLine ($"Weight: {GetWeight ()} Kg");

            Console.WriteLine ($"\nProduct purchased: {GetBuyAbility ()}");
            Console.WriteLine ($"In the amount of: {GetPriceAllPurchased ()} $");
            Console.WriteLine ($"Total weight: {GetTotoalWeight ()} Kg");
        }
    }
    class MainClass {
        static void Main () {
            Console.Clear ();
            Check product = new Check ();
            product.Set ("Pilimeshka", 12, 1);
            product.SetAbility (30);
            
            product.Print ();
        }
    }
}