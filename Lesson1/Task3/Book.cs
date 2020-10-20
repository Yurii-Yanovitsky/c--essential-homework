using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Book
    {
        private Title _title;
        private Author _author;
        private Content _content;

        public Book(string title, string author, string content)
        {
            Initialize();
            _title.Text = title;
            _author.Name = author;
            _content.Text = content;
        }
        public Book()
        {

        }
        void Initialize()
        {
            _title = new Title();
            _author = new Author();
            _content = new Content();
        }
        public void Show()
        {
            _title.Show();
            _author.Show();
            _content.Show();

        }
    }
}
