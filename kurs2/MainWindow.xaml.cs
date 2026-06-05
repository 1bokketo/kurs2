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
using kurs2.models;
using kurs2.Services;




namespace kurs2
{
    public partial class MainWindow : Window
    {
        private DataStorageService _storageService;
        private List<Product> _products;
        private Cart _cart;
        public MainWindow()
        {
            InitializeComponent();

            _storageService = new DataStorageService();

            _products = _storageService.LoadProducts();

            _cart = new Cart();

            ProductsGrid.ItemsSource = _products;
        }
    }
}
