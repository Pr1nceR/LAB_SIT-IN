using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    public partial class Administrator : Window
    {
        SqlConnection databaseSource = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        public Administrator()
        {
            InitializeComponent();
        }

        private void search_TXTBX_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (textBox.Text == "id number")
                {
                    textBox.Text = string.Empty;
                    textBox.Foreground = Brushes.White;
                }
            }
        }

        private void search_TXTBX_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = "id number";
                    textBox.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#393E46");
                }
            }
        }

        private void closeUpdateUser_BTN_Click(object sender, RoutedEventArgs e)
        {
            UpdateUser.Visibility = Visibility.Hidden;
        }

        private void update_BTN_Click(object sender, RoutedEventArgs e)
        {
            UpdateUser.Visibility = Visibility.Visible;
        }

        private void no_BTN_Click(object sender, RoutedEventArgs e)
        {
            Delete.Visibility = Visibility.Hidden;
        }

        private void delete_BTN_Click(object sender, RoutedEventArgs e)
        {
            // if admin selected account then proceed to this
            Delete.Visibility = Visibility.Visible;
        }

        private void logOut_BTN_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void records_BTN_Click(object sender, RoutedEventArgs e)
        {
            Record.Visibility = Visibility.Visible;
        }

        private void request_BTN_Click(object sender, RoutedEventArgs e)
        {
            Request.Visibility = Visibility.Visible;
        }

        private void closeRequest_BTN_Click(object sender, RoutedEventArgs e)
        {
            Request.Visibility = Visibility.Hidden;
        }

        private void closeUpdateAdmin_BTN_Click(object sender, RoutedEventArgs e)
        {
            UpdateAdmin.Visibility = Visibility.Hidden;
        }

        private void updateAdminAccount_BTN_Click(object sender, RoutedEventArgs e)
        {
            UpdateAdmin.Visibility = Visibility.Visible;
        }

        private void Admin_Loaded(object sender, RoutedEventArgs e)
        {

            LAB_SIT_IN.DatabaseDataSet databaseDataSet = ((LAB_SIT_IN.DatabaseDataSet)(this.FindResource("databaseDataSet")));
            // Load data into the table accounts. You can modify this code as needed.
            LAB_SIT_IN.DatabaseDataSetTableAdapters.accountsTableAdapter databaseDataSetaccountsTableAdapter = new LAB_SIT_IN.DatabaseDataSetTableAdapters.accountsTableAdapter();
            databaseDataSetaccountsTableAdapter.Fill(databaseDataSet.accounts);
            System.Windows.Data.CollectionViewSource accountsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("accountsViewSource")));
            accountsViewSource.View.MoveCurrentToFirst();
        }

        private void search_TXTBX_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }
    }
}
