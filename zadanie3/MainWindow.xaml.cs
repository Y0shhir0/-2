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

namespace zadanie3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Year.Text, out int dayOfYear))
            {
                int week = Week(dayOfYear);
                string weekName = WeekName(week);
                resultLabel.Content = weekName;
            }
            else
            {
                resultLabel.Content = "Неверный ввод";
            }
        }
        private int Week(int dayOfYear)
        {
            int dayweek = 7; //  2023 1 января
            int week = (dayweek + dayOfYear - 1) % 7;
            return week == 0 ? 7 : week;
        }

        private string WeekName(int week)
        {
            string[] dayOfWeekNames = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            return dayOfWeekNames[week - 1];
        }
    }
}
