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

namespace LAB_SIT_IN
{
    public partial class SitInSlip : UserControl
    {
        public SitInSlip()
        {
            InitializeComponent();
        }

        private void ClassSchedule_TXTBX_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ClassSchedule_TXTBX != null)
            {
                if (ClassSchedule_TXTBX.Text == "XX:XX AM - XX:XX PM")
                {
                    ClassSchedule_TXTBX.Text = string.Empty;
                    ClassSchedule_TXTBX.Foreground = Brushes.White;
                }
            }
        }

        private void ClassSchedule_TXTBX_LostFocus(object sender, RoutedEventArgs e)
        {
            if (ClassSchedule_TXTBX != null)
            {
                if (string.IsNullOrWhiteSpace(ClassSchedule_TXTBX.Text))
                {
                    ClassSchedule_TXTBX.Text = "XX:XX AM - XX:XX PM";
                    ClassSchedule_TXTBX.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#222831");
                }
            }
        }

        private void TimeTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Text == "XX")
                {
                    textBox.Text = string.Empty;
                    textBox.Foreground = Brushes.White;
                }
            }
        }

        private void TimeTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = "XX";
                    textBox.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#222831");
                }
            }
        }

        private void submit_BTN_Click(object sender, RoutedEventArgs e)
        {
            UserTimer userTimer = new UserTimer();
            userTimer.Show();

            Window parentWindow = Window.GetWindow(this);

            if (parentWindow != null)
                parentWindow.Close();
        }

        private void AMPM1_BTN_Click(object sender, RoutedEventArgs e)
        {
            if (AMPM1_BTN.Content == "AM")
                AMPM1_BTN.Content = "PM";
            else
                AMPM1_BTN.Content = "AM";
        }

        private void AMPM2_BTN_Click(object sender, RoutedEventArgs e)
        {
            if (AMPM2_BTN.Content == "AM")
                AMPM2_BTN.Content = "PM";
            else
                AMPM2_BTN.Content = "AM";
        }

        private void TimeTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }
    }
}
