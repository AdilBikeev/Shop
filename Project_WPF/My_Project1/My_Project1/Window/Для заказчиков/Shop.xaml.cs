using System;
using System.Windows;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;


namespace My_Project1
{
    /// <summary>
    /// Логика взаимодействия для Shop.xaml
    /// </summary>
    public partial class Shop : Window
    {
        public string[] Topic = new string[] { "Все", "Программирование", "Дискретная матемаитка", "Математический Анализ", "Линейная алгебра", "Информатика" };
        public List<Order> order = new List<Order>();//заказы
        public List<Order> painer = new List<Order>();//корзина
        public bool flag = false;

        public Shop()
        {
            InitializeComponent();
        }

        private string GetTableUseSubj()
        {
            string sql_requests = "SELECT *FROM shop.order";//строка запроса
            switch (cbSubject.SelectedIndex)
            {
                case 0:
                {
                    break;
                }
                case 1:
                {
                    sql_requests += " WHERE ID_subject = 1";
                    break;
                }
                case 2:
                {
                    sql_requests += " WHERE ID_subject = 2";
                    break;
                }
                case 3:
                {
                    sql_requests += " WHERE ID_subject = 3";
                    break;
                }
                case 4:
                {
                    sql_requests += " WHERE ID_subject = 4";
                    break;
                }
                default:
                {
                    sql_requests += " WHERE ID_subject = 5";
                    break;
                }
            }

            return sql_requests;
        }

        public void ShowTableOrder()//выводит таблицу заказов
        {
            if (order.Count != 0)
            {
                order.Clear();
            }
               
                //try
                //{
                //    MySqlConnection conn1 = new MySqlConnection(My_Project1.Properties.Settings.Default.ConnString);
                //    conn1.Open();
                //    MySqlCommand command1 = new MySqlCommand(GetTableUseSubj(), conn1);


                //    MySqlConnection conn2 = new MySqlConnection(My_Project1.Properties.Settings.Default.ConnString);
                //    conn2.Open();
                //    MySqlCommand command2 = new MySqlCommand("SELECT *FROM shop.subject_order", conn2);

                
                //    MySqlDataReader reader1 = command1.ExecuteReader();
                //    while (reader1.Read())
                //    {
                //        MySqlDataReader reader2 = command2.ExecuteReader();
                //        while (reader2.Read())
                //        {
                //            if (reader2[0].ToString() == reader1[2].ToString())
                //            {
                //                order.Add(new Order(reader2[1].ToString(), reader1[1].ToString(), (int)reader1[3], reader1[4].ToString()));
                //                break;
                //            }
                //        }
                //        reader2.Close();
                //    }
                //    conn1.Close();
                //    conn2.Close();
                //    reader1.Close();
                //}
                //catch (Exception exc)
                //{
                //    MessageBox.Show(exc.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                //}
                
        }
        
        private void cbSubject_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            ShowTableOrder();
            if(flag)
            {
                dgOrderTable.ItemsSource = null;
                dgOrderTable.ItemsSource = order;
            }
        }

        private void dgOrderTable_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                dgOrderTable.ItemsSource = null;
                dgOrderTable.ItemsSource = order;
                flag = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void dgOrderTable_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            try
            {
                Order item = (dgOrderTable.SelectedItem as Order);
                if (painer.IndexOf(item) == -1)
                {
                    if (MessageBox.Show("Добавить заказ " + item.NAME_ORDER + " в коризну ?", "Сообщение", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                    {
                        lbPanier.Items.Add(item.NAME_SUBJECT + " - " + item.NAME_ORDER);
                        painer.Add(item);
                        tbCountPainer.Text = "Кол-во товаров в корзине: " + lbPanier.Items.Count;

                        MessageBox.Show("Заказ успешно добавлен в корзину !", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Даный заказ уже добавлен в корзину", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            if(lbPanier.SelectedIndex!=-1)
            {
                if(MessageBox.Show("Вы действительно хотите удалить заказ " + painer[lbPanier.SelectedIndex].NAME_ORDER + " из корзины ?", "Сообщение", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    painer.Remove(painer[lbPanier.SelectedIndex]);
                    lbPanier.Items.Remove(lbPanier.Items[lbPanier.SelectedIndex]);
                    tbCountPainer.Text = "Кол-во товаров в корзине: " + lbPanier.Items.Count;
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали элемент в списке, либо список пуст", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btFormalizeOrder_Click(object sender, RoutedEventArgs e)
        {
            if (lbPanier.SelectedIndex != -1)
            {
                FormalizeWin formalize = new FormalizeWin();
                formalize.tbNanmeOrder.Text = painer[lbPanier.SelectedIndex].NAME_ORDER;
                formalize.tbNanmeOrder.IsEnabled = false;
                formalize.ShowDialog();
                painer.Remove(painer[lbPanier.SelectedIndex]);
                lbPanier.Items.Remove(lbPanier.Items[lbPanier.SelectedIndex]);
                tbCountPainer.Text = "Кол-во товаров в корзине: " + lbPanier.Items.Count;
            }
            else
            {
                MessageBox.Show("Вы не выбрали элемент в списке, либо список пуст", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
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
            help.tcHelper.Items.Remove(help.tcHelper.Items[1]);
            help.ShowDialog();
        }
    }
}
