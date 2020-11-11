using System;

namespace AdditionalTask
{
    public class Body : AbstractDocumentPart
    {
        public Body(string content)
        {
            _content = content;
        }

        public Body()
        {
        }

        public override string Content
        {
            get
            {
                if (string.IsNullOrEmpty(_content))
                {
                    return "No Body!";
                }
                else
                {
                    return _content;
                }
            }
            set
            {
                _content = value;
            }
        }
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
