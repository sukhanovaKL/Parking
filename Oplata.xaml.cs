using System.Windows;

namespace Parking
{
    /// <summary>
    /// Логика взаимодействия для Oplata.xaml
    /// </summary>
    public partial class Oplata : Window
    {
        public int Hours;
        public int Cost;
        public Oplata(int hours)
        {
            InitializeComponent();
            Hours = hours;
            Cost = Hours * 70;
            Sum.Content = Cost;
        }

        private void a100_Click(object sender, RoutedEventArgs e)
        {
            if (new Functions().Racschet(Cost, 100))
            {
                if(100 > Cost)
                    MessageBox.Show($"Успешно оплачено! Сдача {100 -Cost}");
                else
                    MessageBox.Show("Успешно оплачено!");
                new Terminal3().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Недостаточно средств!");
            }
        }

        private void a200_Click(object sender, RoutedEventArgs e)
        {
            if(new Functions().Racschet(Cost, 200))
            {
                if (200 > Cost)
                    MessageBox.Show($"Успешно оплачено! Сдача {200 - Cost}");
                else
                    MessageBox.Show("Успешно оплачено!");
                new Terminal3().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Недостаточно средств!");
            }
        }

        private void a500_Click(object sender, RoutedEventArgs e)
        {
            if (new Functions().Racschet(Cost, 500))
            {
                if (500 > Cost)
                    MessageBox.Show($"Успешно оплачено! Сдача {500 - Cost}");
                else
                    MessageBox.Show("Успешно оплачено!");
                new Terminal3().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Недостаточно средств!");
            }
        }

        private void a1000_Click(object sender, RoutedEventArgs e)
        {
            if (new Functions().Racschet(Cost, 1000))
            {
                if (1000 > Cost)
                    MessageBox.Show($"Успешно оплачено! Сдача {1000 - Cost}");
                else
                    MessageBox.Show("Успешно оплачено!");
                new Terminal3().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Недостаточно средств!");
            }
        }

        private void a2000_Click(object sender, RoutedEventArgs e)
        {
            if (new Functions().Racschet(Cost, 2000))
            {
                if (2000 > Cost)
                    MessageBox.Show($"Успешно оплачено! Сдача {2000 - Cost}");
                else
                    MessageBox.Show("Успешно оплачено!");
                new Terminal3().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Недостаточно средств!");
            }
        }

        private void a5000_Click(object sender, RoutedEventArgs e)
        {
            if (new Functions().Racschet(Cost, 5000))
            {
                if (5000 > Cost)
                    MessageBox.Show($"Успешно оплачено! Сдача {5000 - Cost}");
                else
                    MessageBox.Show("Успешно оплачено!");
                new Terminal3().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Недостаточно средств!");
            }
        }
    }
}
