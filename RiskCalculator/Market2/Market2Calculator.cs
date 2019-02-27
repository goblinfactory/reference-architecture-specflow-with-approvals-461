using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskCalculator.Market2
{
    public class Market2Calculator : CalculatorBase
    {
        public override decimal CalculateRisk(decimal initial)
        {
            return base.CalculateRisk(initial) * 1.2M;
        }
    }
}
