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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrderFoods.xaml
    /// </summary>
    public partial class OrderFoods : Page
    {
       
        UserContext db;
        Orders orders = new Orders();
        Menu menu = new Menu();

        public OrderFoods()
        {
            InitializeComponent();
            Lko();
        }

        private void Lko()
        {
            db = new UserContext();
            var item = db.restaurants.ToList();
            foreach (var it in item)
            {
                List.Items.Add(it.RestId);
            }

           
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var item = db.menu.ToList();
            
            var lid = Convert.ToInt32(List.SelectedItem);
            
            foreach(var qw in item)
            {
                if(lid == qw.RestId)
                {
                    
                    list2.Items.Add(qw.FoodName);
                    list3.IsEnabled = false;
                    list3.Items.Add(qw.Price);
                    list3.IsEnabled = false;
                    list4.Items.Add(qw.FoodId);
                }
            }
            
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            orders.IdFood = Convert.ToInt32(list4.SelectedItem);
            orders.IdUser = Windows.UserMain.Id;

            var item = db.orders.ToList();

            var lid = Convert.ToInt32(list4.SelectedItem);
            foreach (var qw in item)
            {
                
                if (lid == qw.IdFood)
                {
                    list5.Items.Add(qw.IdFood);
                    list6.Items.Add(qw.IdUser);
                    break;
                }

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var order = new Orders();
            var menu = new Menu();
            var men = db.menu.ToList();
            
            for(int i=0; i < list5.Items.Count; i++)
            {
                
                
                if (!string.IsNullOrWhiteSpace(adress.Text))
                {

                    order.IdFood = Convert.ToInt32(list5.Items[i]);
                    order.IdUser = Convert.ToInt32(list6.Items[i]);
                    db.orders.Add(order);
                    order.Adress = adress.Text;
                    var qury = db.menu.ToList().Where(m => m.FoodId == order.IdFood).First();
                    qury.FoodCount--;
                    
                    db.SaveChanges();
                   


                }
                else
                {
                    MessageBox.Show("Введите адрес");
                    break;
                }
                



            }
            list5.Items.Clear();
            list6.Items.Clear();


        }

        private void delete(object sender, RoutedEventArgs e)
        {
            
            var item = db.orders.ToList();

            var lid = Convert.ToInt32(list5.SelectedItem);
            foreach (var qw in item)
            {

                if (lid == qw.IdFood)
                {
                    list5.Items.Remove(qw.IdFood);
                    list6.Items.Remove(qw.IdUser);
                    break;
                }

            }

        }
    }
}
