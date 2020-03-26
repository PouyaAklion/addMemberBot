using AddMemberBot.Items;
using Microsoft.Win32;
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

namespace AddMemberBot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TeleSharpcs tl = new TeleSharpcs();
            tl.Init(action_object, action_bool);
            //tl.AuthUser();
            //tl.SendMessageTest();
            //tl.addMemmberTest();
            Random random = new Random();
            for (int i = 0; i <= 100; i++)
            {
                ItemContact lstItem = new ItemContact();
                byte r = (byte)random.Next(20, 220);
                byte g = (byte)random.Next(20, 220);
                byte b = (byte)random.Next(20, 220);
                
                lstItem.Background = new SolidColorBrush(Color.FromArgb(100, r,g ,b ));
                
                lst_contacts.Items.Add(lstItem);
            }
            Random random2 = new Random();
            for (int i = 0; i <= 100; i++)
            {
                ItemGroup lstItem = new ItemGroup();
                byte r = (byte)random2.Next(20, 220);
                byte g = (byte)random2.Next(20, 220);
                byte b = (byte)random2.Next(20, 220);

                lstItem.Background = new SolidColorBrush(Color.FromArgb(100, r, g, b));

                lst_groups.Items.Add(lstItem);
            }

            for (int i = 0; i <= 100; i++)
            {
                ItemNumber lstNumber = new ItemNumber();
                lst_numbers.Items.Add(lstNumber);
            }
            
            
        }
         
        static void action_bool(bool i)
        {
            MessageBox.Show("message from action bool : " + i.ToString());
        }


        static void action_object(object i)
        {
            MessageBox.Show("message from action object : " + i.ToString());
        }
        private static readonly Regex _regex = new Regex("[^0-9.-]+");
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }
        private void inp_number_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xls)|*.xlsx|All files (*.*)|*.*";
            openFileDialog.Title = "Browse your number list file";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == true)
            {
                lbl_filepath.Content = openFileDialog.FileName;
            }
                
        }
    }
}
