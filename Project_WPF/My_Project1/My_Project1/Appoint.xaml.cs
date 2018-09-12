using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Collections.Generic;
using My_Project1.App_Data;
using System.Data.Entity;
using MySql.Data.MySqlClient;

namespace My_Project1
{
    /// <summary>
    /// Логика взаимодействия для Appoint.xaml
    /// </summary>
    public partial class Appoint : Window
    {
        MyCompanyEntities myCompany = new MyCompanyEntities();
        ShopEntities2 shop = new ShopEntities2();

        public Appoint()
        {
            InitializeComponent();
        }

        private void btAppoint_Click(object sender, RoutedEventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            try
            {
                if (cbWorking.Text != ""&&tbSalary.Text!=""&& reg.IsMatch(tbSalary.Text)==true)
                {
                    shop.formalize_orderSet.Load();//загружаем из БД в List информацию о незакоченных заказах
                    foreach(formalize_order item in shop.formalize_orderSet)//пробегаемся по всех незавершенным заказам
                    {
                        if(item.name_order == tbNameOrder.Text)//находим выбранным заказ
                        {
                            item.working_fio = cbWorking.Text;//устанавливаем назначенного пользователем рабочего
                            break;
                        }
                    }

                    
                    myCompany.Personal.Load();//загружаем информацию о каждом члене персонала из БД
                    foreach(Personal item in myCompany.Personal)//перебираем рабочих
                    {
                        if(item.FIO == cbWorking.Text)//если ФИО рабочего совпадает с выбранным пользователем
                        {
                            item.SALARY = tbSalary.Text;//устанавливаем для него зарплату за данный заказ
                            break;
                        }
                    }

                    //сохраняем изменения
                    shop.SaveChanges();
                    myCompany.SaveChanges();

                    MessageBox.Show("Заказ успешно назначен рабочему " + cbWorking.Text, "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Для назначения заказа требуется корректно указать ФИО рабочего и его зарплату", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
