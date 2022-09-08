using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        public Coffee(int price)
        {
            this.price = 20;
        }

        public int price { get; set; }
        public virtual int Price()
        {
            return price;
        }

        public abstract string Strenght();
    }
}
