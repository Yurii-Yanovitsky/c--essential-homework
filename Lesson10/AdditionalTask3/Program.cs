using System;

namespace AdditionalTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            var bag = new Bag<Stuff>();
            bag.Add(new CreditCard());
            bag.Add(new Wallet());
            bag.Add(new Passport());
            GoShopping(bag);

            foreach (var item in bag)
            {
                Console.WriteLine(item.GetType().Name);
            }

            Console.ReadLine();
        }
        static void GoShopping(Bag<Stuff> bag)
        {
            Stuff[] products = new Stuff[7];
            products[0] = new Rice();
            products[1] = new Bread();
            products[2] = new Milk();
            products[3] = new Cheese();
            products[4] = new Ham();
            products[5] = new Drugs();
            products[6] = new Gun();

            PayForProducts(bag);
            GiveBagToTheGuyWhoPacksProducts(bag, products);

        }
        static void GiveBagToTheGuyWhoPacksProducts(Bag<Stuff> bag, Stuff[] products)
        {

            foreach (var product in products)
            {
                if (product is Product p)
                {
                    bag.Add(p);
                }
            }
        }
        static void PayForProducts(Bag<Stuff> bag)
        {

            foreach (var item in bag)
            {
                if (item is Wallet)
                {
                    Console.WriteLine("Pay products!");
                }
            }
        }
    }
    abstract class Stuff { }
    abstract class PersonalStuff : Stuff { }
    class CreditCard : PersonalStuff { }
    class Wallet : PersonalStuff { }
    class Cigarettes : PersonalStuff { }
    class Lighter : PersonalStuff { }
    class Passport : PersonalStuff { }
    abstract class IllegalObject : Stuff { }
    class Gun : IllegalObject { }
    class Drugs : IllegalObject { }
    abstract class Product : Stuff { }
    class Rice : Product { }
    class Bread : Product { }
    class Milk : Product { }
    class Cheese : Product { }
    class Ham : Product { }
}
