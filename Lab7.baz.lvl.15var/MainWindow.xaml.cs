using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab7.baz.lvl._15var
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Queue<double> numberQueue = new Queue<double>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Enqueue_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtNumber.Text, out double number))
            {
                numberQueue.Enqueue(number);
                lstQueue.Items.Add(number);
            }
            else
            {
                MessageBox.Show("Пожалйста введите правильное число.");
            }
        }

        private void Dequeue_Click(object sender, RoutedEventArgs e)
        {
            if (numberQueue.Count > 0)
            {
                double number = numberQueue.Dequeue();
                lstQueue.Items.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("Очередь пуста.");
            }
        }

        private void FindMin_Click(object sender, RoutedEventArgs e)
        {
            if (numberQueue.Count > 0)
            {
                double minValue = numberQueue.Peek();
                foreach (double number in numberQueue)
                {
                    if (number < minValue)
                    {
                        minValue = number;
                    }
                }
                MessageBox.Show("Минимальный элемент: " + minValue);
            }
            else
            {
                MessageBox.Show("Очередь пуста.");
            }
        }
    }
}
