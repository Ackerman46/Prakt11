using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Prakt11
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

        private void Click1_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"a\w*\d\w*a");
            string textcontent = TextContent1.Text;
            MatchCollection matches = regex.Matches(textcontent);
            object[] mas = new object[matches.Count];
            matches.CopyTo(mas, 0);
            FindRes.ItemsSource = mas;
        }

        private void Click2_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"a\w*[^e x]\w*a");
            string textcontent = TextContent2.Text;
            MatchCollection matches = regex.Matches(textcontent);
            object[] mas = new object[matches.Count];
            matches.CopyTo(mas, 0);
            FindRes.ItemsSource = mas;
        }

        private void Info_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Агеев Алексей ИСП-31 \nДана строка 'a1a a22a a333a a4444a a55555a aba aca'. Напишите регулярное выражение, которое найдет строки, в которых по краям стоят буквы 'a', а междуними любое количество цифр.Дана строка 'aba aea aca aza axa a-a a#a'.Напишите регулярное выражение, которое найдет строки следующего вида: по краям стоят буквы 'a', а между ними - не 'e' и не'x'");

        }
    }
}
