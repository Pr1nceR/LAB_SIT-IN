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
    public partial class UserManual : UserControl
    {
        public UserManual()
        {
            InitializeComponent();
        }

        private void Exit_BTN_Click(object sender, RoutedEventArgs e)
        {
            InstructionUI.Visibility = Visibility.Hidden;
        }
    }
}
