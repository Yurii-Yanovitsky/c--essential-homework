using System;
using System.Net.Http.Headers;

namespace AdditionalTask
{
    abstract public class AbstractDocumentPart
    {
        protected string _content;

        abstract public string Content { get; set; }

        abstract public void Show();
    }
}
