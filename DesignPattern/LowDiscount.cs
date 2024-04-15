using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    // For Membership Card only ( 10% )
    public class LowDiscount : IBill
    {
        public double getFinalBillAmount(double billAmount)
        {
            return Convert.ToDouble(billAmount - (billAmount * 0.1));
        }
    }
}
