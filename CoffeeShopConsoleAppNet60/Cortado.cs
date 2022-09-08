using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Cortado : Coffee, IMilk
    {
        public Cortado(int price) : base(price)
        {
            price = 25;
        }

        public override int Price()
        {
            return price;
        }

        public override string Strenght()
        {
            return "Medium";
        }

        public int MlMilk()
        {
            return 40;
        }
    }
}
