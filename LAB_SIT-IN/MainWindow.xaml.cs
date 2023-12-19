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
using System.Windows.Media.Effects;
using System.Windows.Media.Animation;

namespace LAB_SIT_IN
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exit_BTN_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void username_TXTBX_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (textBox.Text == "username")
                {
                    textBox.Text = string.Empty;
                    textBox.Foreground = Brushes.White;
                }
            }
        }

        private void username_TXTBX_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = "username";
                    textBox.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#393E46");
                }
            }
        }

        private void password_TXTBX_GotFocus(object sender, RoutedEventArgs e)
        {

            PasswordBox passBox = sender as PasswordBox;
            if (passBox != null)
            {
                if (passBox.Password == "password")
                {
                    passBox.Password = string.Empty;
                    passBox.Foreground = Brushes.White;
                }
            }
        }

        private void password_TXTBX_LostFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox passBox = sender as PasswordBox;
            if (passBox != null)
            {
                if (string.IsNullOrWhiteSpace(passBox.Password))
                {
                    passBox.Password = "password";
                    passBox.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#393E46");
                }
            }
        }

        private void login_BTN_Click(object sender, RoutedEventArgs e)
        {
            if (username_TXTBX.Text == "admin123" && password_PASSBX.Password == "admin123")
            {
                Administrator admin = new Administrator();
                admin.Show();
                this.Close();
            }
            else if (username_TXTBX.Text == "user123" && password_PASSBX.Password == "user123")
            {
                UserMenu userMenu = new UserMenu();
                userMenu.Show();
                this.Close();
            }
            else
                error_LBL.Visibility = Visibility.Visible;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            Image Eyes = (Image)checkBox.Template.FindName("Eyes", checkBox);

            Check.IsEnabled = true;
            textBox.Visibility = Visibility.Visible;
            textBox.Text = password_PASSBX.Password;
            password_PASSBX.Visibility = Visibility.Collapsed;
            textBox.Foreground = Brushes.White;

            Eyes.Source = new BitmapImage(new Uri("/Assets/Icons/ICO_visible.png", UriKind.Relative));
        }

        private void Check_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            Image Eyes = (Image)checkBox.Template.FindName("Eyes", checkBox);

            password_PASSBX.Password = textBox.Text;
            textBox.Visibility = Visibility.Collapsed;
            password_PASSBX.Visibility = Visibility.Visible;
            Eyes.Source = new BitmapImage(new Uri("/Assets/Icons/ICO_notVisible.png", UriKind.Relative));

        }

        private void Check_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (password_PASSBX.Password == "password" || string.IsNullOrWhiteSpace(password_PASSBX.Password) && textBox.Text == "password" || string.IsNullOrEmpty(textBox.Text))
            {
                e.Handled = true;
            }
        }


        private void createAccount_BTN_Click(object sender, RoutedEventArgs e)
        {
            loginLayout.Visibility = Visibility.Hidden;
            createAccount.Visibility = Visibility.Visible;
        }

        private void closeCreateAccount_BTN_Click(object sender, RoutedEventArgs e)
        {
            loginLayout.Visibility = Visibility.Visible;
            createAccount.Visibility = Visibility.Hidden;
        }

        private void closeForgotPassword_BTN_Click(object sender, RoutedEventArgs e)
        {
            loginLayout.Visibility = Visibility.Visible;
            forgotPassword.Visibility = Visibility.Hidden;
        }

        private void forgotPassword_BTN_Click(object sender, RoutedEventArgs e)
        {
            loginLayout.Visibility = Visibility.Hidden;
            forgotPassword.Visibility = Visibility.Visible;
        }

        private void about_BTN_Click(object sender, RoutedEventArgs e)
        {
            aboutLayout.Visibility = Visibility.Visible;
        }

        private void closeAbout_BTN_Click(object sender, RoutedEventArgs e)
        {
            aboutLayout.Visibility = Visibility.Hidden;
        }
    }
}
