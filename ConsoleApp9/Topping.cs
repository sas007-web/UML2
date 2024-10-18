using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Topping
    {
        public string NameOfTop { get; set; }
        public double Price { get; set; }

        public Topping(string nameOfTop, double price) {
            NameOfTop = nameOfTop;
            Price = price;
        }
        public string GetNameOfTop() {
            return NameOfTop;
        }
        public double GetPrice() {
            return Price;
        }

    }
}



