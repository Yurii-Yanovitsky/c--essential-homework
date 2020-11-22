using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdditionalTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public EventHandler _myEvent;
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler MyEvent
        {
            add { _myEvent += value; }
            remove { _myEvent -= value; }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            _myEvent.Invoke(sender, e);
        }
    }
}
