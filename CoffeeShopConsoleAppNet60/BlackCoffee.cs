using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class BlackCoffee : Coffee
    {
        public BlackCoffee(int price) : base(price)
        {
        }

        public override string Strenght()
        {
            return "Strong";
        }
    }
}
