using System;

namespace Task2
{
    public class Presenter
    {
        private Model _model;
        private View _view;

        public Presenter(View view)
        {
            _model = new Model();
            _view = view;
            _view.TextAdd += TextAddHandler;
        }

        private void TextAddHandler(string str)
        {
            Console.WriteLine(_model.SayHi(str));
        }
    }
}