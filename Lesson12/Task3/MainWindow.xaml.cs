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
using System.Windows.Threading;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public readonly DispatcherTimer timer = new DispatcherTimer();
        private EventHandler start;
        private EventHandler reset;
        private EventHandler stop;

        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler Start
        {
            add
            {
                start += value;
            }
            remove
            {
                start -= value;
            }
        }
        public event EventHandler Reset
        {
            add
            {
                reset += value;
            }
            remove
            {
                reset -= value;
            }
        }
        public event EventHandler Stop
        {
            add
            {
                stop += value;
            }
            remove
            {
                stop -= value;
            }
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            start.Invoke(sender, e);
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            reset.Invoke(sender, e);
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            stop.Invoke(sender, e);
        }
    }
}
