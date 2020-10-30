namespace AdditionalTask
{
    public class Document
    {
        private Title _title;
        private Body _body;
        private Footer _footer;

        public Document(Title title, Body body, Footer footer)
        {
            _title = title;
            _body = body;
            _footer = footer;
        }
        public Document()
        {
            Initialize();
        }

        public string Title
        {
            set
            {
                _title.Content = value;
            }
        }
        public string Body
        {
            set
            {
                _body.Content = value;
            }
        }
        public string Footer
        {
            set
            {
                _footer.Content = value;
            }
        }

        public void Show()
        {
            _title.Show();
            _body.Show();
            _footer.Show();
        }
        private void Initialize()
        {
            _title = new Title();
            _body = new Body();
            _footer = new Footer();

        }
    }
}
