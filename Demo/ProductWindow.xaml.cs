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
            using (var context = new DBDemoEntities())
            {
                ListProducts.ItemsSource = context.Product.ToList();
            }
            

            ComboBoxFilterProductDiscountAmount.ItemsSource = new List<string>
        {
            "0-10%", "10-15%", "15-∞%", "All ranges"
        };
        }


        private void Window_Closed(object sender, System.EventArgs e)
        {
            Close();
        }

        private void ComboBoxFilterProductDiscountAmount_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (ComboBoxFilterProductDiscountAmount.SelectedIndex)
            {
                case 0:
                    {
                        using (var context = new DBDemoEntities())
                        {
                            ListProducts.ItemsSource = context.Product.Where(p => p.ProductDiscountAmount < 10).ToList();
                        }
                        break;
                    }
                case 1:
                    {
                        using (var context = new DBDemoEntities())
                        {
                            ListProducts.ItemsSource = context.Product.Where(p => p.ProductDiscountAmount > 10 && p.ProductDiscountAmount < 15).ToList();
                        }
                        break;
                    }
                case 2:
                    {
                        using (var context = new DBDemoEntities())
                        {
                            ListProducts.ItemsSource = context.Product.Where(p => p.ProductDiscountAmount > 15).ToList();
                        }
                        break;
                    }
                case 3:
                    {
                        using (var context = new DBDemoEntities())
                        {
                            ListProducts.ItemsSource = context.Product.ToList();
                        }
                        break;
                        
                    }
            }
        }

        
    }
}
