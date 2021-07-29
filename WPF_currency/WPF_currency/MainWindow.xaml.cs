using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WPF_currency
{
    ///following the tutorials.eu currency converter tutorial with small changes every now and then
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BindCurrency();
        }
        private void BindCurrency()
        {
            DataTable dtCurrencies = new DataTable();
            dtCurrencies.Columns.Add("Text");
            dtCurrencies.Columns.Add("Value");
            
            dtCurrencies.Rows.Add("...", 0);
            dtCurrencies.Rows.Add("INR", 1);
            dtCurrencies.Rows.Add("USD", 75);
            dtCurrencies.Rows.Add("EUR", 85);
            dtCurrencies.Rows.Add("SAR", 20);
            dtCurrencies.Rows.Add("POUND", 5);
            dtCurrencies.Rows.Add("DEM", 43);

            cmbFromCurrency.ItemsSource = dtCurrencies.DefaultView;
            cmbFromCurrency.DisplayMemberPath = "Text";
            cmbFromCurrency.SelectedValuePath = "Value";
            cmbFromCurrency.SelectedIndex = 0;

            cmbToCurrency.ItemsSource = dtCurrencies.DefaultView;
            cmbToCurrency.ItemsSource = dtCurrencies.DefaultView;
            cmbToCurrency.DisplayMemberPath = "Text";
            cmbToCurrency.SelectedValuePath = "Value";
            cmbToCurrency.SelectedIndex = 0;
        }

        private void txtCurrency_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            double convertedValue;
            if (txtCurrency.Text == null || txtCurrency.Text.Trim() == "") //check if textbox is null or blank
            {
                MessageBox.Show("Please Enter Currency", "Information", MessageBoxButton.OK, MessageBoxImage.Information); //displays message if the condition is true
                txtCurrency.Focus(); //focus on textbox
                return;
            }
            else if(cmbFromCurrency.SelectedValue == null || cmbFromCurrency.SelectedIndex == 0) //check if the value in the first combo box is valid
            {
                MessageBox.Show("Please Select Currency form", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                cmbFromCurrency.Focus(); //focus on first comboBox
                return;
            }
            else if (cmbToCurrency.SelectedValue == null || cmbToCurrency.SelectedIndex == 0) //check if the value in the second comboBox is valid
            {
                MessageBox.Show("Please Select Currency To", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                cmbToCurrency.Focus(); //focus on second combo box
                return;
            }

            if (cmbFromCurrency.Text == cmbToCurrency.Text)
            {
                convertedValue = double.Parse(txtCurrency.Text);
                lblCurrency.Content = cmbToCurrency.Text + " " + convertedValue.ToString("N3"); //Show in label converted currency and converted currency name. ToString("N3") is used to place 000 after the .
            }
            else
            {
                convertedValue = (double.Parse(cmbFromCurrency.SelectedValue.ToString()) * double.Parse(txtCurrency.Text))/double.Parse(cmbToCurrency.SelectedValue.ToString()); //formula I stole on the internet
                lblCurrency.Content = cmbToCurrency.Text + " " + convertedValue.ToString("N3");
            }
        }

        private void DeleteEverything() //clears the textbox, answer label and both comboboxes
        {
            txtCurrency.Text = string.Empty;
            if (cmbFromCurrency.Items.Count > 0) cmbFromCurrency.SelectedIndex = 0;
            if (cmbToCurrency.Items.Count > 0) cmbToCurrency.SelectedIndex = 0;
            lblCurrency.Content = "";
            txtCurrency.Focus();
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            DeleteEverything();
        }
    }
}
