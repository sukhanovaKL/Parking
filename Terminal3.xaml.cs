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
using System.Windows.Shapes;

namespace Parking
{
    /// <summary>
    /// Логика взаимодействия для Terminal3.xaml
    /// </summary>
    public partial class Terminal3 : Window
    {
        public Terminal3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("До свидания!");
            new MainWindow().Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new Entry().Show();
            Hide();
        }
    }
}
