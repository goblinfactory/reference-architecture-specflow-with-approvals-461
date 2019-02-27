using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskCalculator.Market1
{
    public class Market1Calculator : CalculatorBase
    {
        public override decimal CalculateRisk(decimal initial)
        {
            return base.CalculateRisk(initial) * 1.1M;
        }
    }
}
