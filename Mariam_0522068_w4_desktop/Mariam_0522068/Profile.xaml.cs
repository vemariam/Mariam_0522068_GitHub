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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Mariam_0522068
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Profile(string nam)
        {
           

            
            InitializeComponent();
            Facebook_sosEntities facebook_SosEntities = new Facebook_sosEntities();
            dg.ItemsSource=facebook_SosEntities.User_.ToList();

            // profile +name
            namee.Text= "profile" + nam; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.NavigationService.Navigate(login);
        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
