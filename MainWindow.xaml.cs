using System.Linq;
using System.Windows;

namespace Parking
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ParkingEntities db = new ParkingEntities();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(db.Cards.ToList().LastOrDefault().CountCards > 0)
            {
                MessageBox.Show("Проезжайте!");
                new Entry().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("К сожалению, карточки закончились :(");
            }
        }
    }
}
