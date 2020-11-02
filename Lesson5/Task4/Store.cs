using System;

namespace Task4
{
    class Store
    {
        private Article[] _articles = new Article[0];

        public Store(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public Article this[int index]
        {
            get
            {
                if (index < _articles.Length)
                {

                    return _articles[index];
                }
                else
                {

                    return null;
                }
            }
        }
        public Article this[string name]
        {
            get
            {

                for (int i = 0; i < _articles.Length; i++)
                {
                    if (_articles[i].ProductName == name)
                    {

                        return _articles[i];
                    }
                }

                return null;
            }
        }
        public void GetProducts(params Article[] articles)
        {
            _articles = articles;
        }

    }
}
