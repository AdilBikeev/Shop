using System;
using System.Text.RegularExpressions;
using System.Windows;
using MySql.Data.MySqlClient;

namespace My_Project1
{
    /// <summary>
    /// Логика взаимодействия для Appoint.xaml
    /// </summary>
    public partial class Appoint : Window
    {
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
                    MySqlConnection conn1 = new MySqlConnection(My_Project1.Properties.Settings.Default.ConnString);//открываем бд shop
                    conn1.Open();
                    //указываем в базе, кто будет исполнителем заказа
                    MySqlCommand command1 = new MySqlCommand("UPDATE formalize_order  SET working_fio =\'" + cbWorking.Text + "\' WHERE shop.formalize_order.name_order = \'" + tbNameOrder.Text + "\'", conn1);
                    command1.ExecuteReader();
                    conn1.Close();


                    MySqlConnection conn2 = new MySqlConnection(My_Project1.Properties.Settings.Default.CoonStringPersonal);//открываем бд my_company
                    conn2.Open();
                    //указываем в базе, что данный рабочий будет уже занят
                    MySqlCommand command2 = new MySqlCommand("UPDATE personal SET  salary = \'" + tbSalary.Text +"\' WHERE FIO = \'" + cbWorking.Text + "\'", conn2);
                    command2.ExecuteReader();
                    conn2.Close();

                    MessageBox.Show("Заказ успешно назначен рабочему " + cbWorking.Text, "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
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
