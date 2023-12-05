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
    /// Interaction logic for Forget.xaml
    /// </summary>
    public partial class Forget : Page
    {
        public Forget()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Facebook_sosEntities facebook_SosEntities = new Facebook_sosEntities();
            User_ user_ = new User_();
            facebook_SosEntities.User_.First(x => x.Phonenumber == num.Text);
            if (npass.Text == com.Text)
            {////////////////////////good
                user_.Password_ = npass.Text;
                user_.Password_ = com.Text;
                facebook_SosEntities.User_.AddOrUpdate(user_);
                facebook_SosEntities.SaveChanges();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
