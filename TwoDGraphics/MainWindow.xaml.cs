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

namespace TwoDGraphics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Rectangle rect1 = new System.Windows.Shapes.Rectangle();
            rect1.Stroke = System.Windows.Media.Brushes.Black;
            rect1.Fill = System.Windows.Media.Brushes.Red;
            rect1.VerticalAlignment = VerticalAlignment.Center;
            rect1.Height = 50;
            rect1.Width = 70;
            dc1.Children.Add(rect1);
        }
    }
}
