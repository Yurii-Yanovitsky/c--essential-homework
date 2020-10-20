using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Author
    {
        string _name;
        public string Name
        {
            get
            {
                if (_name != null)
                {
                    return _name;
                }
                else
                {
                    return "There is no author!";
                }
            }
            set
            {
                _name = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Author: {Name}");
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
