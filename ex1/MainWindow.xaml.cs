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
        public double displayPrice = 0;
        public const double TOPPING_PRICE = 0.5;
        public MainWindow()
        {
            InitializeComponent();
            InitializeSizes();
            InitializeToppings();
        }
        /** Intializes radio buttons for sizes. Stores parameters in the list then for each parameter creates a radio button
         */
        private void InitializeSizes()
        {
            List<Size> pizzaSizes = new List<Size>();
            pizzaSizes.Add(new Size("Small", 5.0));
            pizzaSizes.Add(new Size("Medium", 6.25));
            pizzaSizes.Add(new Size("Large", 7.75));

            foreach (Size entry in pizzaSizes)
            {
                RadioButton sizeRadioButton = new RadioButton();
                sizeRadioButton.Content = entry.Sizing;
                sizeRadioButton.Tag = entry;

                sizeRadioButton.Checked += sizeRadioButton_Checked;
                sizeRadioButton.Unchecked += sizeRadioButton_Unchecked;//events
                sizePanel.Children.Add(sizeRadioButton);
            }
        }
        /** Intializes check boxes for toppings. Stores parameters in the list then for each parameter creates a Check Box 
        */
        private void InitializeToppings()
        {
            List<Toppings> toppings = new List<Toppings>();
            toppings.Add(new Toppings("Onion", TOPPING_PRICE));
            toppings.Add(new Toppings("Pepper", TOPPING_PRICE));
            toppings.Add(new Toppings("Tomato", TOPPING_PRICE));

            foreach (Toppings entry in toppings)
            {
                CheckBox toppingCheckBox = new CheckBox();
                toppingCheckBox.Content = entry.Name;
                toppingCheckBox.Tag = entry;

                toppingCheckBox.Checked += toppingCheckBox_Checked;
                toppingCheckBox.Unchecked += toppingCheckBox_Unchecked;
                toppingsPanel.Children.Add(toppingCheckBox);
            }
        }

        //when Check box is unchecked reduces the value of the price
        private void toppingCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            Toppings toppings = checkBox.Tag as Toppings;
            contentUpdate(-toppings.Price);
        }

        //when check box is checked increases the value of the price
        private void toppingCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            Toppings toppings = checkBox.Tag as Toppings;
            contentUpdate(+toppings.Price);
        }
        //when radio button is unchecked reduces the value of the price
        private void sizeRadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            Size size = radioButton.Tag as Size;
            contentUpdate(-size.Price);
        }
        //when radio button is checked increases the value of the price
        private void sizeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            Size size = radioButton.Tag as Size;
            contentUpdate(+size.Price);
        }

        /**updates the output on the price
         * <BR>
         * @param currentPrice sent from other functions to increase/dicrease the price value
         */
        private void contentUpdate(double currentPrice)
        {
            displayPrice += currentPrice;
            priceTextBlock.Text = $"Price is: {displayPrice}";
        }

    }
}
