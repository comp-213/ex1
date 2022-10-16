using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ex1
{
    internal class Toppings
    {
        public const double toppingsPrice= 0.5;
        public Toppings(){}

        public UIElement toppingsName(string name)
        {
            CheckBox myCheckBox = new CheckBox();
            myCheckBox.Content = name;
            return myCheckBox;
        }

    }
}
