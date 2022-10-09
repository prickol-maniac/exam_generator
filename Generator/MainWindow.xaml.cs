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

namespace Generator
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
        int words;
        char gen;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (gen == 'm')
            {
                GenerateMale(words);
            }
            else if (gen == 'f')
            {
                GenerateFemale(words);
            }
            else if (gen == 'n')
            {
                GenerateNeutral(words);
            }
        }

        private void Radio2_Checked(object sender, RoutedEventArgs e)
        {
            words = 2;
        }

        private void Radio3_Checked(object sender, RoutedEventArgs e)
        {
            words = 3;
        }

        private void Radio1_Checked(object sender, RoutedEventArgs e)
        {
            words = 1;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            gen = 'f';
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            gen = 'm';
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            gen = 'n';
        }
        /// <summary>
        /// Метод генерации мужских ников
        /// </summary>
        /// <param name="words"></param>
        private void GenerateMale(int words)
        {
            NickText.Text = "";
            Random rand = new Random();
            int len1 = File.ReadAllLines("first_male.txt").Length;
            int len2 = File.ReadAllLines("second_male.txt").Length;
            int len3 = File.ReadAllLines("third.txt").Length;

            if (words==3)
            {
                NickText.Text += File.ReadLines("first_male.txt", Encoding.GetEncoding("windows-1251")).Skip(rand.Next(len1)).First() + " ";
            }

            NickText.Text += File.ReadLines("second_male.txt", Encoding.GetEncoding("windows-1251")).Skip(rand.Next(len2)).First() + " ";

            if (words == 2 || words == 3)
            {
                NickText.Text += File.ReadLines("third.txt", Encoding.GetEncoding("windows-1251")).Skip(rand.Next(len3)).First();
            }
        }

        /// <summary>
        /// Метод генерации женских ников
        /// </summary>
        /// <param name="words"></param>
        private void GenerateFemale(int words)
        {
            NickText.Text = "";
            Random rand = new Random();
            int len1 = File.ReadAllLines("first_female.txt").Length;
            int len2 = File.ReadAllLines("second_female.txt").Length;
            int len3 = File.ReadAllLines("third.txt").Length;

            if (words == 3)
            {
                NickText.Text += File.ReadLines("first_female.txt", Encoding.GetEncoding("windows-1251")).Skip(rand.Next(len1)).First() + " ";
            }

            NickText.Text += File.ReadLines("second_female.txt", Encoding.GetEncoding("windows-1251")).Skip(rand.Next(len2)).First() + " ";

            if (words == 2 || words == 3)
            {
                NickText.Text += File.ReadLines("third.txt", Encoding.GetEncoding("windows-1251")).Skip(rand.Next(len3)).First();
            }
        }

        /// <summary>
        /// Метод генерации нейтральный ников
        /// </summary>
        /// <param name="words"></param>
        private void GenerateNeutral(int words)
        {
            NickText.Text = "";
            Random rand = new Random();
            int len1 = File.ReadAllLines("first_neutral.txt").Length;
            int len2 = File.ReadAllLines("second_neutral.txt").Length;
            int len3 = File.ReadAllLines("third.txt").Length;

            if (words == 3)
            {
                NickText.Text += File.ReadLines("first_neutral.txt", Encoding.GetEncoding("windows-1251")).Skip(rand.Next(len1)).First() + " ";
            }

            NickText.Text += File.ReadLines("second_neutral.txt", Encoding.GetEncoding("windows-1251")).Skip(rand.Next(len2)).First() + " ";

            if (words == 2 || words == 3)
            {
                NickText.Text += File.ReadLines("third.txt", Encoding.GetEncoding("windows-1251")).Skip(rand.Next(len3)).First();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(NickText.Text);
        }
    }
}
