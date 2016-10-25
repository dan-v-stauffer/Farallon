using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceEngine.Calculators;

namespace PortfolioTracker.ViewModels
{
    //MVVM pattern for WinForms
    //ViewModel for Portfolio Wide data (Owner, Portfolio Name, Gain/Losses)
    class PortfolioHeaderViewModel
    {
        #region Members
        private String _owner;
        private String _phone;
        private String _email;
        private String _portfolioName;
        private String _portfoliioNumber;
        private Double _portfolioDayGainLoss;
        private Double _portfolioDayGainLossPercent;
        private Double _portfolioInceptionGainLoss;
        private Double _portfolioInceptionGainLossPercent;
        public String Owner { get { return _owner; } }
        public String Phone { get { return _phone; } }
        public String Email { get { return _email; } }
        public String PortfolioName { get { return _portfolioName; } }
        public String PortfolioNumber { get { return _portfoliioNumber; } }
        public Double PortfolioDayGainLoss { get { return _portfolioDayGainLoss; } }
        public Double PortfolioDayGainLossPercent { get { return _portfolioDayGainLossPercent; } }
        public Double PortfolioInceptionGainLoss { get { return _portfolioInceptionGainLoss; } }
        public Double PortfolioInceptionGainLossPercent { get { return _portfolioInceptionGainLossPercent; } }
        #endregion

        #region Constructor
        public PortfolioHeaderViewModel(String firstName, String lastName, String phone, 
            String email, String portfolioName, String portfolioNumber)
        {
            _owner = String.Format("{0} {1}", firstName, lastName);
            _phone = phone;
            _email = email;
            _portfolioName = portfolioName;
            _portfoliioNumber = portfolioNumber;
        }
        #endregion

        #region Public Methods
        public void UpdateGainLoss(Double purchaseValue, Double openValue, Double currentValue)
        {
            //update Portfolio Daily and Inception Gain/Loss values and percentages

            ProfitLoss dpl = EquityCalculator.GetProfitLoss(openValue, currentValue);
            ProfitLoss ipl = EquityCalculator.GetProfitLoss(purchaseValue, currentValue);

            _portfolioDayGainLoss = dpl.ValueChange;
            _portfolioDayGainLossPercent = dpl.PercentChange;
            _portfolioInceptionGainLoss = ipl.ValueChange;
            _portfolioInceptionGainLossPercent = ipl.PercentChange;
        }
        #endregion
    }
}
