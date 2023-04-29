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
using System.Windows.Shapes;
using System.Data.Entity;

namespace Demo
{
    /// <summary>
    /// Логика взаимодействия для ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        public ProductWindow()
        {
            
            InitializeComponent();
            using (DBDemoEntities db = new DBDemoEntities())
            {
                ProductList.ItemsSource = db.Product.ToList<Product>();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            using (DBDemoEntities db = new DBDemoEntities())
            {
                ProductList.ItemsSource = db.Product.ToList<Product>().OrderByDescending(x => x.ProductCost);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (DBDemoEntities db = new DBDemoEntities())
            {
                ProductList.ItemsSource = db.Product.ToList<Product>().OrderBy(x => x.ProductCost);
                
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (DBDemoEntities db = new DBDemoEntities())
            {
                ProductList.ItemsSource = db.Product.ToList<Product>();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            using (DBDemoEntities db = new DBDemoEntities())
            {
                ProductList.ItemsSource = db.Product.ToList<Product>().Where(x => x.ProductMaxDiscountAmount<10);

            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            using (DBDemoEntities db = new DBDemoEntities())
            {
                ProductList.ItemsSource = db.Product.ToList<Product>().Where(x => x.ProductMaxDiscountAmount >= 10 && x.ProductMaxDiscountAmount<15);

            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            using (DBDemoEntities db = new DBDemoEntities())
            {
                ProductList.ItemsSource = db.Product.ToList<Product>().Where(x => x.ProductMaxDiscountAmount >= 15);

            }
        }
    }
}
