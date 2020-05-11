﻿using System.Data.Entity;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace WpfApp1.Windows
{
    /// <summary>
    /// Логика взаимодействия для LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        UserContext userDB;
        int IdIccount;
        public static string name;

        public LoginScreen()
        {

            InitializeComponent();
            userDB = new UserContext();
            userDB.user.Load();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (!IsCorrectValue(Login.Text) || !IsCorrectValue(Password.Password))
            {
                MessageBox.Show("Ошибка ввода");
            }
            else if (!IsFoundAccount(Login.Text, Password.Password))
            {
                MessageBox.Show("Не найден логин и пароль. Убедитесь в корректности введённый данных");
            }
            else
            {
                if (this.IdIccount == 3)
                {

                    AdminApp admin = new AdminApp();
                    admin.Show();
                    Close();
                    MessageBox.Show($"Вы зашли как администратор");

                }
                else
                {

                    MainWindow mainwindow = new MainWindow();
                    mainwindow.Show();
                    Close();
                    MessageBox.Show($"Вы зашли как {Name}");
                }

            }
        }

        private bool IsFoundAccount(string login, string password)
        {
            foreach (var value in userDB.user.ToList())
            {
                if (login == value.UserName && password == value.Password)
                {
                    IdIccount = value.UserID;
                    Name = value.UserName;
                    return true;
                }
            }
            return false;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
        }

        private bool IsCorrectValue(string text)
        {
            string regex = @"^[а-яА-ЯёЁa-zA-Z0-9]{4,20}$";

            if (Regex.IsMatch(text, regex))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
