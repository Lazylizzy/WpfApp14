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
using System.Collections.ObjectModel;

namespace WpfApp14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                ProductName = "fish",
                ProductPrise = 10,
                ProductType = ProductTypes.Eat
            });
            products.Add(new Product()
            {
                ProductName = "iron",
                ProductPrise = 100,
                ProductType = ProductTypes.Byttechn
            });
            products.Add(new Product()
            {
                ProductName = "kettle",
                ProductPrise = 1500,
                ProductType = ProductTypes.Byttechn
            });
            products.Add(new Product()
            {
                ProductName = "pizza",
                ProductPrise = 15,
                ProductType = ProductTypes.Eat
            });
            lstBox.ItemsSource = products;
        }
    }
}
