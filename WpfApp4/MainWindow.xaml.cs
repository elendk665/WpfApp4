using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using WpfApp4;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        private readonly List<IProduct> _products = new List<IProduct>();

        public MainWindow()
        {
            InitializeComponent();
            ProductListBox.ItemsSource = _products;
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            if (!decimal.TryParse(PriceTextBox.Text, out decimal price))
            {
                MessageBox.Show("Введите корректную цену.");
                return;
            }

            _products.Add(new Product
            {
                Name = NameTextBox.Text,
                Price = price
            });

            // Обновляем ListBox, чтобы отобразились изменения
            ProductListBox.Items.Refresh();
        }
    }
}

