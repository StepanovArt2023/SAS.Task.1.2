using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SAS.Task._2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int value = rnd.Next(1, 25);
                Console.WriteLine(value);
                if(value ==1)  MessageBox.Show($" №1 Ан Эльвира", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 2) MessageBox.Show($" №3 Береснев Никита", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 3) MessageBox.Show($" №4 Бровкина Злата", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 4) MessageBox.Show($" №5 Бунчуков Леонид", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 5) MessageBox.Show($" №6 Воспищева Мария", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 6) MessageBox.Show($" №7 Зубарев Максим", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 7) MessageBox.Show($" №8 Зуйков Иван", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 8) MessageBox.Show($" №9 Калюжный Даниил", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 9) MessageBox.Show($" №10 Козлов Матвей", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 10) MessageBox.Show($" №11 Косякин Денис", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 11) MessageBox.Show($" №12 Крымов Евгений", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 12) MessageBox.Show($" №13 Кузнецова Ульяна", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 13) MessageBox.Show($" №15 Лукьянчиков Ричард", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 14) MessageBox.Show($" №16 Поддельщиков Роман", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 15) MessageBox.Show($" №17 Пролыгин Даниил", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 16) MessageBox.Show($" №18 Рогожин Кирилл", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 17) MessageBox.Show($" №19 Рыжиков Дмитрий", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 18) MessageBox.Show($" №20 Сазонов Станислав", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 19) MessageBox.Show($" №21 Сильянова Елизавета", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 20) MessageBox.Show($" №22 Степанов Артём", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 21) MessageBox.Show($" №23 Тарасова Кристина", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 22) MessageBox.Show($" №24 Федосеев Данил", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 23) MessageBox.Show($" №25 Чванов Артем", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 24) MessageBox.Show($" №26 Бондарев Даниил", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                else if (value == 25) MessageBox.Show($" №27 Черенков Владимир", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
