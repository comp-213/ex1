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
      public Toppings(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
