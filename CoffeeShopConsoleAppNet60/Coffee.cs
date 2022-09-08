using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        public Coffee() : this(0)
        {
        }

        public Coffee(int discount)
        {
            if (discount > 5)
                throw new ArgumentException("Discount can't be more than 5 dkk.");
            if (discount < 0)
                throw new ArgumentException("Discount can't be less than 0 dkk.");
            this.Discount = discount;
        }

        protected int Discount { get; private set; }
        public virtual int Price()
        {
            return 20 - Discount;
        }

        public abstract string CoffeeType();
        public abstract string Strength();
    }
}