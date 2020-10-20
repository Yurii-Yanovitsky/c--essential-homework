using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Content
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
                    return "Content is empty!";
                }
            }
            set
            {
                _text = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Content: {Text}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
