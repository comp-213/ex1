using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ex1
{
    internal class Size
    {
        RadioButton myRadioButton = new RadioButton();
        public double sizePrice = 0;
        public Size()
        {
            
        }
        public UIElement sizeNamePrice(string sizing, double price)
        {
            sizePrice = price;
            myRadioButton.Content = sizing;
            return myRadioButton;
        }


    } 
}
