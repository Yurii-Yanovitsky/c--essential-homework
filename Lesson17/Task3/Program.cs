using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<dynamic, dynamic>()
            {
                {new {Key = "customer"} , new {Value = "клиент"} },
                {new {Key = "bevrage"} , new {Value = "напиток"} },
                {new {Key = "subway"} , new {Value = "метро"} },
                {new {Key = "bread"} , new {Value = "хлеб"} },
                {new {Key = "suburb"} , new {Value = "пригород"} },
                {new {Key = "village"} , new {Value = "село"} },
                {new {Key = "plate"} , new {Value = "тарелка"} },
                {new {Key = "spoon"} , new {Value = "ложка"} },
                {new {Key = "direction"} , new {Value = "направление"} },
                {new {Key = "backpack"} , new {Value= "рюкзак"} }
            };

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key.Key} - {item.Value.Value}");
            }

            Console.ReadLine();
        }
    }
}
