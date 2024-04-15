using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    // For Employee Card only ( 20% )
    public class HighDiscount : IBill
    {
        public double getFinalBillAmount(double billAmount)
        {
            return Convert.ToDouble(billAmount - (billAmount * 0.2));
        }
    }
}
