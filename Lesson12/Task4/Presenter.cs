using System;

namespace Task4
{
    class Presenter
    {
        Model _model;
        MainWindow _view;

        public Presenter(MainWindow view)
        {
            _model = new Model();
            _view = view;
            _view.Add += View_Add;
            _view.Subtract += View_Subtract;
            _view.Mul += View_Mul;
            _view.Divide += View_Divide;
        }

        private void View_Add(object sender, EventArgs e)
        {
            var result = CheckOperants();
            if (result.isValid)
            {
                _view.Result_TextBox.Text = _model.Add(result.oper1, result.oper2);
            }
        }
        private void View_Subtract(object sender, EventArgs e)
        {
            var result = CheckOperants();
            if (result.isValid)
            {
                _view.Result_TextBox.Text = _model.Subtract(result.oper1, result.oper2);
            }
        }
        private void View_Mul(object sender, EventArgs e)
        {
            var result = CheckOperants();
            if (result.isValid)
            {
                _view.Result_TextBox.Text = _model.Mul(result.oper1, result.oper2);
            }
        }
        private void View_Divide(object sender, EventArgs e)
        {
            var result = CheckOperants();
            if (result.isValid)
            {
                _view.Result_TextBox.Text = _model.Divide(result.oper1, result.oper2);
            }
        }

        private (bool isValid, int oper1, int oper2) CheckOperants()
        {
            bool isValid1 = int.TryParse(_view.Operant1_TextBox.Text, out int operand1);
            bool isValid2 = int.TryParse(_view.Operant2_TextBox.Text, out int operand2);

            if (isValid1 && isValid2)
            {
                return (true, operand1, operand2);
            }
            {
                return (false, 0, 0);
            }
        }
    }
}
