using System;
using System.Windows;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;

namespace My_Project1
{
    /// <summary>
    /// Логика взаимодействия для For_Personal.xaml
    /// </summary>
    public partial class For_Personal : Window
    {
        public List<Order> order = new List<Order>();//заказы
        public List<Working> workings = new List<Working>();//рабочии

        public For_Personal()
        {
            InitializeComponent();
        }

        public void GetItemsWorking(Appoint obj)//получаем список рабочих
        {
            if (workings.Count != 0)
            {
                workings.Clear();
            }

            //try
            //{
            //    MySqlConnection conn1 = new MySqlConnection(My_Project1.Properties.Settings.Default.CoonStringPersonal);
            //    conn1.Open();


            //    MySqlCommand command1 = new MySqlCommand("SELECT *FROM personal", conn1);

            //    MySqlDataReader reader1 = command1.ExecuteReader();
            //    while (reader1.Read())
            //    {
            //        workings.Add(new Working(reader1[1].ToString()));
            //        obj.cbWorking.Items.Add(reader1[1].ToString());
            //    }
            //    conn1.Close();
            //    reader1.Close();
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            //}
        }

        public void ShowTableOrder()//выводит таблицу заказов
        {
            if (order.Count != 0)
            {
                order.Clear();
            }

            //try
            //{
            //    MySqlConnection conn1 = new MySqlConnection(My_Project1.Properties.Settings.Default.ConnString);//подключаемся к бд shop
            //    conn1.Open();
            //    MySqlCommand command1 = new MySqlCommand("SELECT *FROM shop.order WHERE shop.order.name_subject = (SELECT name_order FROM formalize_order)", conn1);


            //    MySqlConnection conn2 = new MySqlConnection(My_Project1.Properties.Settings.Default.ConnString);//подключаемся к бд shop
            //    conn2.Open();
            //    MySqlCommand command2 = new MySqlCommand("SELECT *FROM shop.subject_order", conn2);//берем оттуда тематику заказа, для подстановки ее вместо ID_subject

            //    MySqlConnection conn3 = new MySqlConnection(My_Project1.Properties.Settings.Default.ConnString);//подключаемся к бд shop
            //    conn3.Open();
            //    MySqlCommand command3 = new MySqlCommand("SELECT *FROM formalize_order", conn3);//берем оттуда коммент, исполнителя и прогресс заказа

            //    MySqlDataReader reader1 = command1.ExecuteReader();
            //    while (reader1.Read())
            //    {
            //        MySqlDataReader reader2 = command2.ExecuteReader();
            //        while (reader2.Read()) if (reader2[0].ToString() == reader1[2].ToString()) break;//поиск тематики по ключ ID

            //        MySqlDataReader reader3 = command3.ExecuteReader();
            //        while (reader3.Read()) if (reader3[1].ToString() == reader1[1].ToString()) break;//если название заказа совпадает
            //        order.Add(new Order(reader2[1].ToString(), reader1[1].ToString(), (int)reader1[3], reader1[4].ToString(),reader3[6].ToString(), reader3[5].ToString(), Convert.ToInt32(reader3[7]) ));
            //        reader2.Close();
            //        reader3.Close();
            //    }
            //    conn1.Close();
            //    conn2.Close();
            //    conn3.Close();
            //    reader1.Close();
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
        
        }

        private void dgOrder_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                dgOrder.ItemsSource = null;
                dgOrder.ItemsSource = order;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void dgOrder_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            try
            {
                Appoint obj = new Appoint();
                obj.tbNameOrder.Text = (dgOrder.Items[dgOrder.SelectedIndex] as Order).NAME_ORDER;
                GetItemsWorking(obj);
                obj.ShowDialog();
                ShowTableOrder();
                dgOrder_Loaded(sender, e);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void miBackSignIn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

        private void miCLose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void miHelp_Click(object sender, RoutedEventArgs e)
        {
            Help help = new Help();
            help.tcHelper.Items.Remove(help.tcHelper.Items[0]);
            help.ShowDialog();
        }
    }
}
