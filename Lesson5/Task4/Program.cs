using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("ATB");

            Article[] articles =
            {
                new Article("Bread", store, 15),
                new Article("Sugar", store, 20),
                new Article("Rice", store, 20),
                new Article("Eggs", store, 27),
                new Article("Potatoes", store, 8)
            };

            store.GetProducts(articles);

            ShowProductInfo(store, 0);
            ShowProductInfo(store, 3);
            ShowProductInfo(store, 5);

            string productName = Console.ReadLine();
            ShowProductInfo(store, productName);

            Console.ReadLine();
        }
        static void ShowProductInfo(Store store, int number)
        {
            string s = store[number] == null ? "Product isn't found" : store[number].ToString();
            Console.WriteLine($"{s}\n");
        }
        static void ShowProductInfo(Store store, string name)
        {
            string s = store[name] == null ? "Product isn't found" : store[name].ToString();
            Console.WriteLine($"{s}\n");
        }
    }
}
