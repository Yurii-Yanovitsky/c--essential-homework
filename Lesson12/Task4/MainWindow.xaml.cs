using System;
using System.Windows;

namespace Task4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EventHandler _add;
        private EventHandler _subtract;
        private EventHandler _mul;
        private EventHandler _divide;

        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler Add
        {
            add { _add += value; }
            remove { _add -= value; }
        }
        public event EventHandler Subtract
        {
            add { _subtract += value; }
            remove { _subtract -= value; }
        }
        public event EventHandler Mul
        {
            add { _mul += value; }
            remove { _mul -= value; }
        }
        public event EventHandler Divide
        {
            add { _divide += value; }
            remove { _divide -= value; }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            _add.Invoke(sender, e);
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            _subtract.Invoke(sender, e);
        }
        private void Mul_Click(object sender, RoutedEventArgs e)
        {
           _mul.Invoke(sender, e);
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            _divide.Invoke(sender, e);
        }
    }
}
