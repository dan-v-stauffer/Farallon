using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Models;
using FinanceEngine;
using FinanceEngine.Models;

namespace PortfolioTracker.ViewModels
{
    //MVVM pattern for WinForms
    //ViewModel for Overall Portfolio data (Owner, Portfolio Name, Gain/Losses, and Positions)

    public delegate void ViewModelChangedEventHandler(object sender, EventArgs e);
    public delegate void HttpBlackoutEventHander(object sender, EventArgs e);
    class PortfolioViewModel
    {
        #region Members
        private BindingSource _equityBindingSource = new BindingSource();
        private BindingSource _portfolioBindingSource = new BindingSource();
        private Portfolio _portfolio;
        private QuoteEngine _engine;
        private List<EquityViewModel> _equityviews = new List<EquityViewModel>();

        public event ViewModelChangedEventHandler ViewModelChanged;
        public event HttpBlackoutEventHander InternetBlackout;
        public BindingSource EquityBindingSource { get { return _equityBindingSource; } }
        public BindingSource PortfolioBindingSource { get { return _portfolioBindingSource; } }
        #endregion

        #region Constructor
        public PortfolioViewModel(String filePath, String service="Google")
        {

            try
            {
                //create portfolio object from xml file path
                _portfolio = DataAccess.Factory.PortfolioFactory.Instance.GetPortfolio(filePath);
            }
            catch(Exception e)
            {
                throw e;
            }

            //Create a QuoteEngine that will manage communication and tracking of web service quotes
            _engine = new QuoteEngine(_portfolio.GetSymbols(), service);

            //initialize binding sources for ViewModel
            intitializePortfolioBindingSource();
            initializeEqutiyBindingSource();

            //bubble up events when quotes change
            _engine.QuoteChanged += new QuoteChangedEventHandler(OnQuoteChanged);
            _engine.InternetBlackout += new HttpBlackoutEventHandler(OnInternetBlackout);
        }
        protected virtual void OnInternetBlackoutEvent(EventArgs e)
        {
            InternetBlackout?.Invoke(this, e);
        }
        #endregion

        #region Protected Methods
        protected virtual void OnViewModelChanged(EventArgs e)
        {
            ViewModelChanged?.Invoke(this, e);
        }

        #endregion

        #region Private Methods
        private void initializeEqutiyBindingSource()
        {
            //create EquityViewModel for each position
            _portfolio.Positions.ForEach(posit => _equityviews.Add(
                new EquityViewModel(posit.PositionId, posit.Symbol, posit.PurchaseDate, posit.Quantity, posit.PurchasePrice)));

            //update gain/loss information in EquityViewModels
            updateEquityValues();

            //assign EquityViewModels to BindingSource
            _equityBindingSource.DataSource = _equityviews;
        }

        private void intitializePortfolioBindingSource()
        {
            _portfolioBindingSource.Add(new PortfolioHeaderViewModel(
                _portfolio.PortfolioOwner.FirstName,
                _portfolio.PortfolioOwner.LastName,
                _portfolio.PortfolioOwner.PhoneNumber,
                _portfolio.PortfolioOwner.Email,
                _portfolio.PortfolioName,
                _portfolio.PortfolioNumber));
        }

        private void OnQuoteChanged(object sender, EventArgs e)
        {
            updateEquityValues();
            OnViewModelChanged(e);
        }
        private void OnInternetBlackout(object sender, EventArgs e)
        {
            OnInternetBlackoutEvent(e);
        }
        private void updateEquityValues()
        {
            //update EquityViewModels\ if quotes have been udpated.
            Double purchaseValue = 0;
            Double openValue = 0;
            Double currentValue = 0;

            _equityviews.ForEach(posit =>
                {
                    posit.UpdateValues(_engine.ReturnOpenPrice(posit.Symbol), _engine.ReturnQuote(posit.Symbol));
                    purchaseValue += (posit.PurchasePrice * posit.Quantity);
                    openValue += (posit.OpenPrice * posit.Quantity);
                    currentValue += (posit.CurrentPrice * posit.Quantity);
                });
            PortfolioHeaderViewModel header = (PortfolioHeaderViewModel)_portfolioBindingSource.List[0];
            header.UpdateGainLoss(purchaseValue, openValue, currentValue);

        }
        #endregion
    }
}
