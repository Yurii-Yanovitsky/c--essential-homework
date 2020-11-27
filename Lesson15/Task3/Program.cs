using System;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = CreateProduct();

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите имя искомого магазина");
                    string shopName = Console.ReadLine();

                    products = products.Where((x) => x.Shop == shopName).ToArray();

                    if (products.Length != 0)
                    {
                        foreach (var product in products)
                        {
                            Console.WriteLine(product);
                        }
                        break;
                    }
                    else
                    {
                        throw new Exception("Нет такого магазина!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                    Console.WriteLine("Введите \"EXIT\", чтобы закончить поиск.");
                    if("EXIT" == Console.ReadLine().ToUpper())
                    {
                        break;
                    }
                }
            }
        }

        static Price[] CreateProduct()
        {
            Price[] products = new Price[2];

            string productName;
            string shop;
            int cost;

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Введите название товара: ");
                productName = Console.ReadLine();

                Console.WriteLine("Введите название магазина: ");
                shop = Console.ReadLine();

                while (true)
                    try
                    {
                        Console.WriteLine("Введите цену на товар: ");
                        cost = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                products[i] = new Price(productName, shop, cost);

                Console.Clear();
            }
            products = products.OrderBy((x) => x.Shop).ToArray();

            return products;
        }
    }
}
