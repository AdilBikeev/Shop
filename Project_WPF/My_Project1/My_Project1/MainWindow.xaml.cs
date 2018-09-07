using System;
using System.Windows;
using MySql.Data.MySqlClient;
using MySql.Data;
using My_Project1.App_Data;
using System.Data.Entity;
using System.Linq;

namespace My_Project1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyCompanyEntities myCompany;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool DataRead()
        {
            foreach(Users_Data item in myCompany.Users_Data.Local)
            {
                if (item.Login == tbLogin.Text)
                    if (item.Password == tbPassword.Password)
                    {
                        return true;
                    }
            }
            return false;
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {//загрыжаем данные из базы данных
                myCompany = new MyCompanyEntities();
                myCompany.Users_Data.Load();
                myCompany.Personal.Load();
                if (DataRead())
                {
                    MessageBox.Show("Авторизация пройдена успешно !", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                    For_Personal obj = new For_Personal();
                    obj.ShowTableOrder();
                    obj.Show();
                    Close();
                }
                else MessageBox.Show("Неверно введен логин/пароль", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btCostumer_Click(object sender, RoutedEventArgs e)
        {
            Shop obj = new Shop();
            obj.Show();
            obj.tbCountPainer.Text = "Кол-во товаров в корзине: " + obj.lbPanier.Items.Count;
            Close();
        }
    }
}
