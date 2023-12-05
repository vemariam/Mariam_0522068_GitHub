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
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Page
    {
        Facebook_sosEntities1 _sosEntities1 = new Facebook_sosEntities1();  
        public Delete()
        {
            InitializeComponent();
            dg.ItemsSource=_sosEntities1.User_.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User_ user_=new User_();
            user_ = _sosEntities1.User_.First(x => x.Phonenumber == num.Text);
            user_=_sosEntities1.User_.Remove(user_);
            dg.ItemsSource = _sosEntities1.User_.ToList();
            _sosEntities1.SaveChanges();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            User_ user_ = new User_();
            _sosEntities1.User_.Where(x=> x.City.Contains(user_.City)).ToList();
            dg.ItemsSource = _sosEntities1.User_.ToList();
            _sosEntities1.SaveChanges();
        }
    }
}
