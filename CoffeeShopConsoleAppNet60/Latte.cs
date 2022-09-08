using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : Coffee, IMilk
    {
        public Latte(int price) : base(price)
        {
            this.price = 40;
        }

        public override int Price()
        {
            return price;
        }

        public override string Strenght()
        {
            return "Weak";
        }

        public int MlMilk()
        {
            return 200;
        }
    }
}
