using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class FinalBillAmount
    {
        private IBill _dscountType;
        public FinalBillAmount(IBill discountType)
        {
            _dscountType = discountType;
        }

        public double GetFinalBillAmount(double billAmount)
        {
            return _dscountType.getFinalBillAmount(billAmount);
        }
    }
}
