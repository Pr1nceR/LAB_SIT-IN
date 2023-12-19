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
    /// Interaction logic for UserTimer.xaml
    /// </summary>
    public partial class UserTimer : Window
    {
        public UserTimer()
        {
            InitializeComponent();

            double screenWidth = SystemParameters.WorkArea.Width;
            double windowHeight = this.Height;

            // Set window position to be centered horizontally and at the top vertically
            this.Left = (screenWidth - this.Width) / 2;
            this.Top = 0;

            // make TimePopUp.Show(); if time == 5 minutes and else if time == 0
        }

        private void out_BTN_Click(object sender, RoutedEventArgs e)
        {
            CountdownTimer.Visibility = Visibility.Hidden;
            TimeOut.Visibility = Visibility.Visible;
        }

        private void no_BTN_Click(object sender, RoutedEventArgs e)
        {
            TimeOut.Visibility = Visibility.Hidden;
            CountdownTimer.Visibility = Visibility.Visible;
        }

        private void yes_BTN_Click(object sender, RoutedEventArgs e)
        {
            UserMenu userMenu = new UserMenu();
            userMenu.Show();
            this.Close();
        }
    }
}
