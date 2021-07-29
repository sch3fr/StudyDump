using System;
using System.Data;
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

namespace WPF_currency
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
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
            
            dtCurrencies.Rows.Add("-SELCET-", 0);
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

        }

        private void txtCurrency_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
