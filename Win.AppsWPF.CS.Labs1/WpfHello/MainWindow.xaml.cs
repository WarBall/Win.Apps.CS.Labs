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
using System.IO;

namespace WpfHello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            button.IsEnabled = false;
            button1.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            button1.IsEnabled = true;
            try
            {
                using (StreamWriter sw = new StreamWriter("D:\\username.txt"))
                {
                    sw.WriteLine(textBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("D:\\username.txt"))
                {
                    label.Content = "Приветствую Вас, уважаемый " + sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            button.IsEnabled = true;
        }
    }
}
