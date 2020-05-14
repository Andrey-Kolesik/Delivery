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

namespace WpfApp1.Windows
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        UserContext db;
        public Admin()
        {
            InitializeComponent();
            db = new UserContext();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminApp adminApp = new AdminApp();
            adminApp.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.dataGrid.ItemsSource = db.restaurants.ToList();
            adminMenu.Show();
            Close();
        }

 
    }
}
