using System;
using System.Windows;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace My_Project1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool DataRead(MySqlDataReader reader)
        {
            while(reader.Read())
            {
                if (reader[1].ToString() == tbLogin.Text)
                    if (reader[2].ToString() == tbPassword.Password)
                    {
                        reader.Close();
                        return true;
                    }
            }
            return false;
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MySqlConnection conn = new MySqlConnection(My_Project1.Properties.Settings.Default.CoonStringPersonal);
            //MySqlCommand command = new MySqlCommand("SELECT *FROM user_data", conn);
            //MySqlDataReader reader;
            //try
            //{
            //    conn.Open();
            //    reader = command.ExecuteReader();
            //    if (DataRead(reader))
            //    {
            //        MessageBox.Show("Авторизация пройдена успешно !", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
            //        For_Personal obj = new For_Personal();
            //        obj.ShowTableOrder();
            //        obj.Show();
            //        Close();
            //    }
            //    else MessageBox.Show("Неверно введен логин/пароль", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
            //    conn.Close();
            //    reader.Close();
            //}catch(Exception exc)
            //{
            //    MessageBox.Show(exc.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            //}
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
