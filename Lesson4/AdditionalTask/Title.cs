using System;

namespace AdditionalTask
{
    public class Title : AbstractDocumentPart
    {
        public Title(string content)
        {
            _content = content;
        }

        public Title()
        {
        }

        public override string Content
        {
            get
            {
                if (string.IsNullOrEmpty(_content))
                {
                    return "No Title!";
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
