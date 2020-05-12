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
    /// Логика взаимодействия для RestPage.xaml
    /// </summary>
    public partial class RestPage : Page
    {
        UserContext db;
        public RestPage()
        {
            InitializeComponent();
            db = new UserContext();
            db.restaurants.ToList();
            IsFoundResturant();

        }

        private void IsFoundResturant()
        {
            foreach (var value in db.restaurants.ToList())
            {
                foreach (var control in grid.Children.OfType<Label>())
                {
                    if (string.IsNullOrWhiteSpace(control.Content.ToString()))
                    {
                        control.Content = value.RestName;
                        db.SaveChanges();
                        break;

                    }
                    
                }
                for(int i=1; i<=7;i++)
                {

                }
                foreach (Image img in grid.Children.OfType<Image>())
                {
                    if (!string.IsNullOrWhiteSpace(value.RestSourse))
                    {
                        
                        if (string.IsNullOrEmpty(Convert.ToString(img.Source)))
                        {
                            img.Source = new BitmapImage(new Uri(value.RestSourse));

                            db.SaveChanges();
                            break;

                        }

                    }


                } 

                    
                    

                }

            }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
    }

