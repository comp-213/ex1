using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace ex1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Toppings toppings = new Toppings();
        Size size = new Size();
        double displayPrice = 0;
        public MainWindow()
        {
            InitializeComponent();
            createSizes();
            createToppings();

        }

        public void createSizes()
        {
            sizeOneStackPanel.Children.Add(size.sizeNamePrice("Small", 5.0));
            sizeTwoStackPanel.Children.Add(size.sizeNamePrice("Medium", 6.25));
            sizeThreeStackPanel.Children.Add(size.sizeNamePrice("Large", 7.75));
        }
        public void createToppings()
        {
            toppingOneStackPanel.Children.Add(toppings.toppingsName("Onion"));
            toppingTwoStackPanel.Children.Add(toppings.toppingsName("Pepper"));
            toppingThreeStackPanel.Children.Add(toppings.toppingsName("Tomato"));
        }
        public void myRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            displayPrice += size.sizePrice;
            contentUpdate();
        }

        public void myRadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            displayPrice -= size.sizePrice;
            contentUpdate();
        }

        private void contentUpdate()
        {
            priceTextBlock.Text = $"Price is: {displayPrice}";
        }

    }
}
