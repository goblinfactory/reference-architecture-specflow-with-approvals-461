using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskCalculator
{
   public  class CalculatorBase
    {
        private float _risk = 1.0F;

        // pretend risk increases linearly with the number of trades so that we can look at a lot of data
        public virtual decimal CalculateRisk(decimal initial)
        {
            _risk = _risk * 1.001F;
            return (decimal)((float)initial + 1.1F * _risk);
        }
    }
}
