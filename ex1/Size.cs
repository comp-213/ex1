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

        public Size(string sizing, double price)
        {
            Sizing = sizing;
            Price = price;
        }


        public string Sizing { get; set; }
        public double Price { get; set; }


    } 
}
