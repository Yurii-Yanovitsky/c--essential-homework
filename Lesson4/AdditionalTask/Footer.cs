using System;

namespace AdditionalTask
{
    public class Footer : AbstractDocumentPart
    {
        public Footer(string content)
        {
            _content = content;
        }

        public Footer()
        {
        }

        public override string Content
        {
            get
            {
                if (string.IsNullOrEmpty(_content))
                {
                    return "No Footer!";
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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
