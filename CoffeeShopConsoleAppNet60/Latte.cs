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
        public Latte() : base()
        {
        }

        public Latte(int discount) : base(discount)
        {
        }

        public override int Price()
        {
            return 40 - Discount;
        }

        public override string Strength()
        {
            return "Weak";
        }

        public int MlMilk()
        {
            return 200;
        }

        public override string CoffeeType()
        {
            return "Latte";
        }
    }
}
