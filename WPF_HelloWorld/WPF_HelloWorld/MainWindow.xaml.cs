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

namespace WPF_HelloWorld
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*TextBlock myTb = new TextBlock();
            myTb.Text = "Hello BBBBBorld";
            myTb.Inlines.Add(" + inlines thingy.");
            myTb.Inlines.Add(new Run(" New Run Text, IDK what that means") 
            {
                Foreground = Brushes.Red,
                TextDecorations = TextDecorations.Underline
            });
            myTb.TextWrapping = TextWrapping.WrapWithOverflow;
            myTb.Foreground = Brushes.BlueViolet;
            this.Content = myTb;
            */

        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            theLabel.Content = "Now look at me again";
            theLabel.Foreground = Brushes.Coral;
            theLabel.FontSize++;
        }

        private void theButton_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            theLabel.FontSize--;
        }

        private void theButton_MouseEnter(object sender, MouseEventArgs e)
        {
            theLabel.Foreground = Brushes.Red;
        }

        private void theButton_MouseLeave(object sender, MouseEventArgs e)
        {
            theLabel.Foreground = Brushes.Pink;
        }

        private void rbMae_Checked(object sender, RoutedEventArgs e)
        {
            wpMae.Background = Brushes.LimeGreen;
        }

        private void rbMae_Unchecked(object sender, RoutedEventArgs e)
        {
            wpMae.Background = Brushes.White;
        }

        private void rbGregg_Checked(object sender, RoutedEventArgs e)
        {
            wpGregg.Background = Brushes.LimeGreen;
        }

        private void rbGregg_Unchecked(object sender, RoutedEventArgs e)
        {
            wpGregg.Background = Brushes.White;
        }

        private void rbBea_Checked(object sender, RoutedEventArgs e)
        {
            wpBea.Background = Brushes.LimeGreen;
        }

        private void rbBea_Unchecked(object sender, RoutedEventArgs e)
        {
            wpBea.Background = Brushes.White;
        }

        private void rbAngus_Checked(object sender, RoutedEventArgs e)
        {
            wpAngus.Background = Brushes.LimeGreen;
        }

        private void rbAngus_Unchecked(object sender, RoutedEventArgs e)
        {
            wpAngus.Background = Brushes.White;
        }

        private void boxA_Checked(object sender, RoutedEventArgs e)
        {
            boxAlab.Background = Brushes.LimeGreen;
        }

        private void boxA_Unchecked(object sender, RoutedEventArgs e)
        {
            boxAlab.Background = Brushes.White;
        }

        private void checkAll_Checked(object sender, RoutedEventArgs e)
        {
            bool value = (checkAll.IsChecked == true);
            order1.IsChecked = value;
            order2.IsChecked = value;
            order3.IsChecked = value;
            order4.IsChecked = value;
            order5.IsChecked = value;
            orderLabel.Content = "And a large soda";

            if((checkAll.IsChecked == false) || (checkAll.IsChecked == null))
            {
                orderLabel.Content = "Your order";
            }
        }

        private void orderChanged(object sender, RoutedEventArgs e)
        {
            checkAll.IsChecked = null;
            if((order1.IsChecked == true) && (order2.IsChecked == true) && (order3.IsChecked == true) && (order4.IsChecked == true) && (order5.IsChecked == true))
            {
                checkAll.IsChecked = true;
            }
            if ((order1.IsChecked == false) && (order2.IsChecked == false) && (order3.IsChecked == false) && (order4.IsChecked == false) && (order5.IsChecked == false))
            {
                checkAll.IsChecked = false;
            }
        }

        private void mySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(myTextblock != null) 
            {
                double fontSize = mySlider.Value;
                myTextblock.Text = "The value is " + mySlider.Value.ToString();
                try
                {
                    myTextblock.FontSize = fontSize;
                }
                catch
                {
                    myTextblock.FontSize = 1;
                }
            }
        }

        //private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if ((sender as DatePicker).SelectedDate != null)
        //    {
        //        string myDate = (sender as DatePicker).SelectedDate.ToString();
        //        MessageBox.Show("Date has been changed to " + myDate);
        //    }
        //}


    }
}
