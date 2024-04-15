using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    // For No Card only ( 0% )
    public class NoDiscount : IBill
    {
        public double getFinalBillAmount(double billAmount)
        {
            return billAmount;
        }
    }
}
