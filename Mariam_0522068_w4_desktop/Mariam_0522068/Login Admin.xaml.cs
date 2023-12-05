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

namespace Mariam_0522068
{
    /// <summary>
    /// Interaction logic for Login_Admin.xaml
    /// </summary>
    public partial class Login_Admin : Page
    {
        public Login_Admin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Facebook_sosEntities1 facebook_SosEntities = new Facebook_sosEntities1();
            Admin_ admin_ = new Admin_();
            int id =int.Parse(ID.Text);
            facebook_SosEntities.Admin_.First(x => x.admin_id == id && x.admin_pass==pass.Text);
            if (pass.Text == pass.Text)
            {
               Delete delete = new Delete();
                this.NavigationService.Navigate(delete);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
