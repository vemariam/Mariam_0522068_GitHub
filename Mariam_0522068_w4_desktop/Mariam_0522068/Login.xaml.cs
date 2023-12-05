using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

namespace Mariam_0522068
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }
        Facebook_sosEntities1 facebook_SosEntities = new Facebook_sosEntities1();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User_ user_ = new User_();
            var user = facebook_SosEntities.User_.FirstOrDefault(x=> x.Username==namee.Text&& x.Password_== pass.Text);
            if (user != null) 
            {
                MessageBox.Show("Sign in succsessfuly");
            Profile profile = new Profile(namee.Text);
            this.NavigationService.Navigate(profile);
            }
            else { MessageBox.Show("Error,can you make account and sin in again"); }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Sign_up sign_Up = new Sign_up();
            this.NavigationService.Navigate(sign_Up);   
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Forget forget = new Forget();
            this.NavigationService.Navigate(forget);
            Facebook_sosEntities1 facebook_SosEntities = new Facebook_sosEntities1();
            User_ user_ = new User_();
            facebook_SosEntities.User_.First(x => x.Password_ == pass.Text);
            if (pass.Text == pass.Text)
            {
                facebook_SosEntities.User_.Select(x => x.Username); 
            } 
            else
            {
                MessageBox.Show("Error");
            }  
        }

        private void namee_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
