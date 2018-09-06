using System;
using System.Windows;
using System.Collections.Generic;
using My_Project1.App_Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Controls;

namespace My_Project1
{
    /// <summary>
    /// Логика взаимодействия для Shop.xaml
    /// </summary>
    public partial class Shop : Window
    {
        public List<Order> orderCopy = new List<Order>();//заказы
        public List<Order> painer = new List<Order>();//корзина
        public bool flag = false;


        ShopEntities2 shop;

        public Shop()
        {
            InitializeComponent();

            shop = new ShopEntities2();//созадем экземпляр  модели
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
            if (shop != null)
            {


                if (orderCopy.Count != 0)
                {
                    orderCopy.Clear();
                }

                string name_subject = "";
                for (int i = 0; i<shop.order.Local.Count; i++)//пробегаемся по всем строкам таблицы
                {

                    foreach (subject_order item in shop.subject_order)
                    {
                        if (item.Id == shop.order.Local[i].ID_subject)
                        {
                            TextBlock cbItem = cbSubject.SelectedItem as TextBlock;
                            if (item.subject == cbItem.Text)
                            {
                                name_subject = item.subject;
                                orderCopy.Add(new Order(name_subject, shop.order.Local[i].name_subject, shop.order.Local[i].price, shop.order.Local[i].run_time));
                            }
                            break;
                        }
                    }
                }
            }
        }
        
        private void cbSubject_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            ShowTableOrder();
            if(flag)
            {
                dgOrderTable.ItemsSource = null;
                dgOrderTable.ItemsSource = orderCopy;
            }
        }

        private void dgOrderTable_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                shop.subject_order.Load();
                shop.order.Load();//загружаем информацию с базы данных
                string name_subject="";
                for (int i = 0; i < shop.order.Local.Count; i++)//пробегаемся по всем строкам таблицы
                {
                    foreach(subject_order item in shop.subject_order)
                    {
                        if(item.Id == shop.order.Local[i].ID_subject)
                        {
                            name_subject = item.subject;
                            orderCopy.Add(new Order(name_subject, shop.order.Local[i].name_subject, shop.order.Local[i].price, shop.order.Local[i].run_time));
                            break;
                        }
                    }
                }
                dgOrderTable.ItemsSource = orderCopy;
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
