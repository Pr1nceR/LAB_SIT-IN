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
using System.Windows.Shapes;

namespace LAB_SIT_IN
{
    /// <summary>
    /// Interaction logic for UserMenu.xaml
    /// </summary>
    public partial class UserMenu : Window
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void Logout_BTN_Click(object sender, RoutedEventArgs e)
        {
            UserMenuInteractives.Visibility = Visibility.Collapsed;
            SitIn_form.Visibility = Visibility.Hidden;
            LogoutConfirmation.Visibility = Visibility.Visible;
        }

        private void goBack_BTN_Click(object sender, RoutedEventArgs e)
        {
            UserMenuInteractives.Visibility = Visibility.Visible;
            LogoutConfirmation.Visibility = Visibility.Collapsed;
        }

        private void Instruction_BTN_Click(object sender, RoutedEventArgs e)
        {
            SitIn_form.Visibility = Visibility.Hidden;
            Instruction.Visibility = Visibility.Visible;
        }

        private void Logout_BTN1_Click(object sender, RoutedEventArgs e) // red login button
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void SitIn_BTN_Click(object sender, RoutedEventArgs e)
        {
            if (SitIn_form.Visibility == Visibility.Hidden)
                SitIn_form.Visibility = Visibility.Visible;
            else
                SitIn_form.Visibility = Visibility.Hidden;
        }
    }
}
