using System;

namespace Task2
{
    public delegate void MeDelegate(string str);
    public class View
    {
        public event MeDelegate TextAdd;

        public View()
        {
            new Presenter(this);
            EnterText();
        }

        public void EnterText()
        {
            Console.WriteLine("Enter your name:");
            while (true)
            {
                string str = Console.ReadLine();
                if (!string.IsNullOrEmpty(str) && TextAdd != null)
                {
                    TextAdd(str);
                }
                else
                {
                    break;
                }
            }
        }
    }
}