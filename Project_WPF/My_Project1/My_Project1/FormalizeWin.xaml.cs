using System;
using System.Windows;
using MySql.Data.MySqlClient;
using System.Windows.Documents;
using System.Text.RegularExpressions;

namespace My_Project1
{
    /// <summary>
    /// Логика взаимодействия для FormalizeWin.xaml
    /// </summary>
    public partial class FormalizeWin : Window
    {
        public FormalizeWin()
        {
            InitializeComponent();
        }

        private void btFormalize_Click(object sender, RoutedEventArgs e)
        {
            if(tbPhone_Validate())
                try
                {
                    //TextRange textRange = new TextRange(rtbComment.Document.ContentStart, rtbComment.Document.ContentEnd);
     

                    //MySqlConnection conn = new MySqlConnection(My_Project1.Properties.Settings.Default.ConnString);
                    //conn.Open();
                    //if (tbFIO.Text == "" && tbVk.Text == "" && tbPhone.Text == "")
                    //{
                    //    MessageBox.Show("Заполните хотяб одно из полей ФИО/VK/Телефон, чтобы мы хоть как-то могли с вами связаться", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    //}
                    //else
                    //{
                    //    MySqlCommand command = new MySqlCommand("INSERT INTO formalize_order (formalize_order.name_order, FIO, vk, phone, comment,progress_order) VALUES (\'" +
                    //        tbNanmeOrder.Text + "\',\'"
                    //        + tbFIO.Text + "\',\'"
                    //        + tbVk.Text + "\',\'"
                    //        + tbPhone.Text + "\',\'"
                    //        + textRange.Text+ "\', 0)", conn);
                    //    command.ExecuteNonQuery();
                    //    conn.Close();
                    //    MessageBox.Show("Заказ успешно оформлен !", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    //    this.Close();
                    //}
                }catch(Exception exc)
                {
                    MessageBox.Show(exc.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                }
        }

        private bool tbPhone_Validate()
        {
            try
            {
                Regex telephone = new Regex("[0-9]");
                if (!telephone.IsMatch(tbPhone.Text))//проверяем введенную цифру на валидность
                    MessageBox.Show("Номер телефона должен состоять только из цифр от 0 до 9 без символа \'+\' !", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
                else return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return false;
        }
    }
}
