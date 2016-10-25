using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceEngine.WebServices;

namespace FinanceEngine.Calculators
{
    //helper class for calculator to return both value and percentage changes to view models in one call
    public class ProfitLoss
    {
        private Double _valueChange;
        private Double _percentChange;
        public Double ValueChange { get { return _valueChange; } }
        public Double PercentChange { get { return _percentChange; } }

        public ProfitLoss(Double value, Double percent)
        {
            _valueChange = value;
            _percentChange = percent;
        }

    }

    //Static helper class for view models to calculate gain/loss values and percentages
    public static class EquityCalculator
    {
        public static ProfitLoss GetProfitLoss(Double startPrice, Double currentPrice)
        {
            Double delta = currentPrice - startPrice;

            return new ProfitLoss(delta, (delta / startPrice));
        }

    }
}
