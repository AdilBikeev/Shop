using System;
using System.Windows;
using MySql.Data.MySqlClient;
using System.Windows.Documents;
using System.Text.RegularExpressions;
using My_Project1.App_Data;
using System.Data.Entity;
using System.Linq;

namespace My_Project1
{
    /// <summary>
    /// Логика взаимодействия для FormalizeWin.xaml
    /// </summary>
    public partial class FormalizeWin : Window
    {
        ShopEntities2 shop = new ShopEntities2();
        public FormalizeWin()
        {
            InitializeComponent();
            shop.formalize_orderSet.Load();
        }

        private void btFormalize_Click(object sender, RoutedEventArgs e)
        {
            if(tbPhone_Validate())
                try
                {
                    TextRange textRange = new TextRange(rtbComment.Document.ContentStart, rtbComment.Document.ContentEnd);

                    if (tbFIO.Text == "" && tbVk.Text == "" && tbPhone.Text == "")
                    {
                        MessageBox.Show("Заполните хотяб одно из полей ФИО/VK/Телефон, чтобы мы хоть как-то могли с вами связаться", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        //добавляем в БД
                        if (tbPhone_Validate())
                        {
                            shop.formalize_orderSet.Local.Add(new formalize_order()
                            {
                                 comment = textRange.Text,
                                 FIO = tbFIO.Text,
                                 name_order = tbNanmeOrder.Text,
                                 phone = (tbPhone.Text),
                                 vk = tbVk.Text
                            });
                            shop.SaveChanges();
                            MessageBox.Show("Заказ успешно добавлен. Ожидайте когда с вами свяжутся наши сотрудники", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        
                    }
                }
                catch(Exception exc)
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
