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

namespace ItemTemplateExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<User> items = new List<User>();
            items.Add (new User(){ Name = "John Doe", Age = "42", Mail = "johan-Family.com" });
            items.Add(new User() { Name = "John2 Doe", Age = "41", Mail = "johan-Family.com" });
            items.Add(new User() { Name = "John3 Doe", Age = "43", Mail = "johan-Family.com" });
            lvDataBinding.ItemsSource = items;

        }
    }
    public class User
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Mail { get; set; }
        public override string ToString()
        {
            return  $"Name: {this.Name}\tAge: {this.Age}\tMail: {this.Mail}";
        }
    }
}
