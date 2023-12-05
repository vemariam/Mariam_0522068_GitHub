using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace Mariam_0522068
{
    /// <summary>
    /// Interaction logic for Sign_up.xaml
    /// </summary>
    public partial class Sign_up : Page
    {
        public Sign_up() 
        {
            InitializeComponent();
            

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.NavigationService.Navigate(login);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {            try {
                if (password.Password.Length > 8 && Regex.IsMatch(password.Password, @"^(?=.*[A-z])(?=.*\d)(?=.*\w)"))
                {
                   
                    Facebook_sosEntities facebook_SosEntities = new Facebook_sosEntities();
                    User_ user_ = new User_();
                    if (user_.Age > 18 && user_.Age < 60)
                    {
                        user_.Username = name.Text;
                    user_.Age=int.Parse(age.Text);
                    user_.Phonenumber = num.Text;
                    user_.Password_ = password.Password;
                    user_.City = combo.Text;
                    user_.Gender = r1.ToString();
                    user_.Gender = r2.ToString();
                    facebook_SosEntities.User_.Add(user_);
                    facebook_SosEntities.SaveChanges();
                    }
                    else
                    { MessageBox.Show("Error"); }
               if (combo.Text == "Cairo")
                    {
                        combo.SelectedItem = facebook_SosEntities.User_.Add(user_);
                    }
                    else if (combo.Text == "Giza")
                    {
                        combo.SelectedItem = facebook_SosEntities.User_.Add(user_);
                    }
                    else if (combo.Text == "monofia")
                    {
                        combo.SelectedItem = facebook_SosEntities.User_.Add(user_);
                    }
                    else if (combo.Text == "mansora")
                    {
                        combo.SelectedItem = facebook_SosEntities.User_.Add(user_);
                    }
                    else { MessageBox.Show("Error"); }
                    //radio button
             if (r1.IsChecked != null )
                    {
                        r1.IsChecked = true;
                     
                    }
                    else if ( r2.IsChecked == null)
                    {
                        r2.IsChecked = true;
                    }
                    else { MessageBox.Show("Error"); }
                    MessageBox.Show("Sign up succesfully");
                    Login LO = new Login();
                    this.NavigationService.Navigate(LO);

                }
               
               
            } 
            catch{ MessageBox.Show("error"); }
            MessageBox.Show("Sign up succesfully");
            Login LOG = new Login();
            this.NavigationService.Navigate(LOG);
        } 

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
