using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("fidelcastro", "Fidel", "Castro", 50);
            ShowUserInfo(user);

            Console.ReadKey();
        }
        static void ShowUserInfo(User user)
        {
            Console.WriteLine($"Login: {user.Login}");
            Console.WriteLine($"Name: {user.Name}");
            Console.WriteLine($"LastName: {user.LastName}");
            Console.WriteLine($"Age: {user.Age}");
            Console.WriteLine($"Date of filling: {user._date}");
        }
    }

}
