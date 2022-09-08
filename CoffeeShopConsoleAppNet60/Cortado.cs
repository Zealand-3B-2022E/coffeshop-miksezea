using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Cortado : Coffee, IMilk
    {
        public Cortado() : base()
        {
        }
        public Cortado(int discount) : base(discount)
        {
        }

        public override int Price()
        {
            return 25 - Discount;
        }

        public override string Strength()
        {
            return "Medium";
        }

        public int MlMilk()
        {
            return 40;
        }

        public override string CoffeeType()
        {
            return "Cortado";
        }
    }
}
