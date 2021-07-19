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
    }
}
