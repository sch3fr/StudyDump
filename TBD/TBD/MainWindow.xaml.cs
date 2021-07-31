using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Forms;

namespace TBD
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    /// 
    // IMPORTANT NAMES
    // ListBox = list
    // Delete single task button = buttonDelOne
    // Delete all tasks button = buttonDelAll
    // Add new task button = buttonAdd
    
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> allTasks { get; set; }
        public MainWindow()
        {
            allTasks = new ObservableCollection<string>();
            
            InitializeComponent();
            this.DataContext = this;
        }
        public void buttonDelOne_Click(object sender, RoutedEventArgs e)
        {
            
                        
            //allTasks.RemoveAt(0);

            //allTasks.Remove(list.SelectedItem);
            //allTasks.Items.Remove
        }

        private void buttonDelAll_Click(object sender, RoutedEventArgs e)
        {
            allTasks.Clear();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            allTasks.Add("new task hee");
        }
    }
}
