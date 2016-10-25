using System;
using System.Globalization;
using FinanceEngine.Calculators;

namespace PortfolioTracker.ViewModels
{
    //MVVM pattern for WinForms
    //ViewModel for Individual Position data (Owner, Portfolio Name, Gain/Losses)

    public class EquityViewModel 
    {
        #region Members
        private NumberFormatInfo _nfi = new CultureInfo("en-US", false).NumberFormat;
        private bool _dataLoaded = false;

        private Int32 _positionId;
        private String _symbol;
        private DateTime _purchaseDate;
        private Double _quantity;
        private Double _purchasePrice;
        private Double _currentPrice;
        private Double _openPrice;
        private Double _dayGainLoss;
        private Double _dayGainLossPercentage;
        private Double _dayGainLossTotal;
        private Double _inceptionGainLoss;
        private Double _inceptionGainLossPercentage;
        private Double _inceptionGainLossTotal;
        private Int32 _direction = 0;

        public Int32 PositionId { get { return _positionId; } }
        public String Symbol { get { return _symbol; } }
        public DateTime PurchaseDate { get { return _purchaseDate; } }
        public Double Quantity { get { return _quantity; } }
        public Double PurchasePrice { get { return _purchasePrice; } }
        public String PurchasePriceString { get { return PurchasePrice.ToString("C3", _nfi); } }
        public Double CurrentPrice {  get { return _currentPrice; } }
        public String CurrentPriceString { get { return CurrentPrice.ToString("C3", _nfi); } }
        public Double OpenPrice { get { return _openPrice; } }
        public String OpenPriceString { get { return OpenPrice.ToString("C3", _nfi); } }
        public Double DayGainLoss { get { return _dayGainLoss; } }
        public String DayGainLossString { get { return DayGainLoss.ToString("C3", _nfi); } }
        public Double DayGainLossPercentage { get { return _dayGainLossPercentage; } }
        public String DayGainLossPercentageString { get { return DayGainLossPercentage.ToString("P", _nfi); } }
        public Double DayGainLossTotal { get  { return _dayGainLossTotal; } }
        public String DayGainLossTotalString { get { return DayGainLossTotal.ToString("C3", _nfi); } }
        public Double InceptionGainLoss { get { return _inceptionGainLoss; } }
        public String InceptionGainLossString { get { return InceptionGainLoss.ToString("C3", CultureInfo.CurrentCulture); } }
        public Double InceptionGainLossPercentage { get { return _inceptionGainLossPercentage; } }
        public String InceptionGainLossPercentageString { get { return _inceptionGainLossPercentage.ToString("P", _nfi); } }
        public Double InceptionGainLossTotal { get { return _inceptionGainLossTotal; } }
        public String InceptionGainLossTotalString { get { return InceptionGainLossTotal.ToString("C3", CultureInfo.CurrentCulture); } }
        public Int32 Direction { get { return _direction; } }
        #endregion

        #region Constructor
        public EquityViewModel(Int32 positionId, String symbol, DateTime purchaseDate, Double quantity, Double purchasePrice)
        {
            _positionId = positionId; ;
            _symbol = symbol;
            _purchaseDate = purchaseDate;
            _quantity = quantity;
            _purchasePrice = purchasePrice;
        }
        #endregion

        #region Public Methods
        public void UpdateValues(Double openPrice, Double currentPrice)
        {
            //cacluate individual position daily and inception Gain/Loss values and percentages
            //keep track of direction of last trade for formatting purposes on UI

            ProfitLoss dpl = EquityCalculator.GetProfitLoss(openPrice, currentPrice);
            ProfitLoss ipl = EquityCalculator.GetProfitLoss(_purchasePrice, currentPrice);

            if (_dataLoaded)
            {
                if (_currentPrice < currentPrice)
                    _direction = 1;
                else if (_currentPrice > currentPrice)
                    _direction = -1;
                else
                    _direction = 0;
            }

            _openPrice = openPrice;
            _currentPrice = currentPrice;
            _dayGainLoss = dpl.ValueChange;
            _dayGainLossPercentage = dpl.PercentChange;
            _dayGainLossTotal = _dayGainLoss * _quantity;

            _inceptionGainLoss = ipl.ValueChange;
            _inceptionGainLossPercentage = ipl.PercentChange;
            _inceptionGainLossTotal = _inceptionGainLoss * _quantity;

            _dataLoaded = true;
        }
        #endregion
    }
}
