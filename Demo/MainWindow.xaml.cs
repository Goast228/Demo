using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using EasyCaptcha.Wpf;

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
            UniformGridCaptcha.Visibility = Visibility.Hidden;
            StackPanelButtonEnter.Visibility = Visibility.Visible;
            MyCaptcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 5);
            // устанавливаем метод обратного вызова

            // создаем таймер


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
                StackPanelButtonEnter.Visibility = Visibility.Hidden;
                UniformGridCaptcha.Visibility = Visibility.Visible;
                NavigateText.Content = "Введите Каптчу";
                MyCaptcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 5);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            ProductWindow productWindow = new ProductWindow();
            productWindow.Show();
        }

        private void ButtonAcceptCaptcha_Click(object sender, RoutedEventArgs e)
        {
            var answer = MyCaptcha.CaptchaText;
            if (answer == TextBoxCaptcha.Text)
            {
                StackPanelButtonEnter.Visibility = Visibility.Visible;
                UniformGridCaptcha.Visibility = Visibility.Hidden;

                TextBoxEnter.IsEnabled = true;
                PasswordBoxEnter.IsEnabled = true;
                NavigateText.Content = "Пожалуйста, введите свои данные для входа или продолжайте в качестве гостя";
                UserNameForm.IsEnabled = true;
                UserPasswordForm.IsEnabled = true;
            }
            else
            {
                MyCaptcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 5);
                MessageBox.Show("Incorrect captcha. Please enter captcha again.");
                this.IsEnabled = false;
                Thread.Sleep(10000);
                this.IsEnabled = true;
            }
        }
    }
}
