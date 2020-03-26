using AddMemberBot.Dialogs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace AddMemberBot.Pages.Authentications
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
            
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
       
            this.NavigationService.Navigate(new Uri("/Pages/authentications/EnterNumber.xaml", UriKind.Relative));
        }
        public event System.Windows.Navigation.NavigatingCancelEventHandler Navigating;
        public bool Cancel { get; set; }
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            var link = (Hyperlink)sender;
            var uri = link.NavigateUri.ToString();
            Process.Start(new ProcessStartInfo(uri));
            e.Handled = true;
            this.NavigationService.Navigate(new Uri("/Pages/authentications/Login.xaml", UriKind.Relative));
           
        }
    }
}
