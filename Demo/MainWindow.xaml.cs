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

namespace Demo
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var listAllUsers = new List<User>();
            var enter = false;
            using (DBDemoEntities db = new DBDemoEntities())
            {
                foreach(User i in db.User)
                {
                    if(i.UserLogin == TextBoxEnter.Text && i.UserPassword == PasswordBoxEnter.Password)
                    {
                        enter = true;
                        break;
                    }
                }
            }
            if (enter)
            {
                ProductWindow productWindow = new ProductWindow();
                productWindow.Show();
            }
            else
            {
                MessageBox.Show("Проверьте правильность данных, пользовательне найден.");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            ProductWindow productWindow = new ProductWindow();
            productWindow.Show();
        }
    }
}
