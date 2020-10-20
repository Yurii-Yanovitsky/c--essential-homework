using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Title
    {
        string _text;
        public string Text
        {
            get
            {
                if (_text != null)
                {
                    return _text;
                }
                else
                {
                    return "There is no title!";
                }
            }
            set
            {
                _text = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Title: {Text}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
