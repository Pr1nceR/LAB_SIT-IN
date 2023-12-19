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
    /// Interaction logic for TimePopUp.xaml
    /// </summary>
    public partial class TimePopUp : Window
    {
        public TimePopUp()
        {
            InitializeComponent(); 
            // insert code here else if time == 0 make TimesUp.Visibility = Visibility.Visible; and Warning.Visibility = Visibility.Collapsed;
        }

        private void no_BTN_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void yes_BTN_Click(object sender, RoutedEventArgs e)
        {
            Extend.Visibility = Visibility.Visible;
            Warning.Visibility = Visibility.Hidden;
        }

        private void extension_TXTBX_GotFocus(object sender, RoutedEventArgs e)
        {
            if (extension_TXTBX != null)
            {
                if (extension_TXTBX.Text == "XX:XX:XX")
                {
                    extension_TXTBX.Text = string.Empty;
                    extension_TXTBX.Foreground = Brushes.White;
                }
            }
        }

        private void extension_TXTBX_LostFocus(object sender, RoutedEventArgs e)
        {
            if (extension_TXTBX != null)
            {
                if (string.IsNullOrWhiteSpace(extension_TXTBX.Text))
                {
                    extension_TXTBX.Text = "XX:XX:XX";
                    extension_TXTBX.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#222831");
                }
            }
        }
    }
}
