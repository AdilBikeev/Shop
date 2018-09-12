using System;
using System.Windows;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;
using My_Project1.App_Data;
using System.Data.Entity;

namespace My_Project1
{
    /// <summary>
    /// Логика взаимодействия для For_Personal.xaml
    /// </summary>
    public partial class For_Personal : Window
    {
        
        public List<Order> orderCopy = new List<Order>();//заказы
        public List<Working> workings = new List<Working>();//рабочии
        MyCompanyEntities myCompany;
        ShopEntities2 shop;//созадем экземпляр  модели;

        public For_Personal()
        {
            InitializeComponent();
        }

        public void GetItemsWorking(Appoint obj)//получаем список рабочих
        {
            if (workings.Count != 0)//если список рабочих не пуст
            {
                workings.Clear();//очищаем этот список для его обновления
            }

            try
            {
                myCompany.Personal.Load();//загрыжаем данные с БД о всех членах компании
                foreach (Personal item in myCompany.Personal.Local)//пробегаемся по всем членам персонала
                {
                    workings.Add(new Working(item.FIO));//добавляем каждого рабочего в List
                    obj.cbWorking.Items.Add(item.FIO);//и добавляем его в ComboBox для того, чтобы пользователь мог сделать выбор - кому назначить работу
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void ShowTableOrder()//выводит таблицу заказов
        {
            if (dgOrder.ItemsSource == null)
            {
                try
                {//загружаем информацию с базы данных
                    myCompany = new MyCompanyEntities();
                    myCompany.Personal.Load();

                    shop = new ShopEntities2();
                    shop.formalize_orderSet.Load();


                    foreach (formalize_order item in shop.formalize_orderSet)//пробегаемся по всем заказам
                    {
                        int price;
                        string run_time;
                        GetInf(out price, out run_time, item.name_subject, item.name_order);
                        orderCopy.Add(new Order(item.name_subject, item.name_order, price, run_time, item.working_fio, item.comment, item.progress_order));
                    }
                    dgOrder.ItemsSource = orderCopy;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }


        public void GetInf(out int price,out string run_time, string name_subject, string name_order)//возвращает тематику заказа
        {
            price = 0;
            run_time = "0 часов";

            shop.subject_order.Load();
            shop.order.Load();
            for (int i = 0; i < shop.order.Local.Count; i++)//пробегаемся по всем строкам таблицы
            {
                foreach (subject_order item in shop.subject_order)//пробегаемся по названиям тематик
                {
                    if (item.Id == shop.order.Local[i].ID_subject)
                    {
                        price = shop.order.Local[i].price;
                        run_time = shop.order.Local[i].run_time;
                        break;
                    }
                }
            }
        }
        private void dgOrder_Loaded(object sender, RoutedEventArgs e)
        {
            ShowTableOrder();
        }

        private void dgOrder_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            try
            {
                Appoint obj = new Appoint();
                obj.tbNameOrder.Text = (dgOrder.Items[dgOrder.SelectedIndex] as Order).NAME_ORDER;//запомнинаем тематику заказа
                GetItemsWorking(obj);
                obj.ShowDialog();

                if (orderCopy.Count != 0)
                {
                    orderCopy.Clear();
                }

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
