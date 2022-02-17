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
using System.Collections;

namespace CollectionBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            listBox1.ItemsSource = GetData();
        }
        private ArrayList GetData()
        {
            ArrayList list = new ArrayList();
            list.Add("Babloo");
            list.Add("Sunny");
            list.Add("Ramjee");
            return list;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
