using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ViCode_LeVi.Data
{
    public class Step_BalanceAndOthers : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void SendPropertyChanged_All()
        {

        }
        #endregion
        public Step_BalanceAndOthers()
        {
            Balance = new Step_BalanceAndOthers_Balance();
            InvestmentCalculation = new Step_BalanceAndOthers_InvestmentCalculation();
            Trade = new Step_BalanceAndOthers_Trade();
            Price = new Step_BalanceAndOthers_Price();
            InvestmentPlan = new Step_BalanceAndOthers_InvestmentPlan();
            LIQUIDITYPLAN = new Step_BalanceAndOthers_LIQUIDITYPLAN();
            PROFIT = new Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT();
            SHEET_STATEMENT = new Step_BalanceAndOthers_Sheet_Statement();
        }
        public void CheckAllPropertiesAndRefine()
        {
            if (Balance == null)
                Balance = new Step_BalanceAndOthers_Balance();
            if (InvestmentCalculation == null)
                InvestmentCalculation = new Step_BalanceAndOthers_InvestmentCalculation();
            if (Trade == null)
                Trade = new Step_BalanceAndOthers_Trade();
            if (Price == null)
                Price = new Step_BalanceAndOthers_Price();
            if (InvestmentPlan == null)
                InvestmentPlan = new Step_BalanceAndOthers_InvestmentPlan();
            if (LIQUIDITYPLAN == null)
                LIQUIDITYPLAN = new Step_BalanceAndOthers_LIQUIDITYPLAN();
            if (DEPRECIATION_CALCULATION == null)
                DEPRECIATION_CALCULATION = new Step_BalanceAndOthers_Depreciation_Calculation();
            if (PROFIT == null)
                PROFIT = new Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT();
            if (SHEET_STATEMENT == null)
                SHEET_STATEMENT = new Step_BalanceAndOthers_Sheet_Statement();

            //Check CurrencySymbol
            //if (!ControlTextInfo.List_Action_CurrencySymbolChanged.Contains(SendPropertyChange_CurrencySymbol))
            //{
            //    ControlTextInfo.List_Action_CurrencySymbolChanged.Add(SendPropertyChange_CurrencySymbol);
            //}
        }

        public void SendPropertyChange_CurrencySymbol()
        {
            string sPath = "CurrencySymbol";
            if (Balance != null)
                Balance.SendPropertyChanged(sPath);
            if (InvestmentCalculation != null)
                InvestmentCalculation.SendPropertyChanged(sPath);
            if (Trade != null)
                Trade.SendPropertyChanged(sPath);
            if (Price != null)
                Price.SendPropertyChanged(sPath);
            if (InvestmentPlan != null)
                InvestmentPlan.SendPropertyChanged(sPath);
            if (LIQUIDITYPLAN != null)
                LIQUIDITYPLAN.SendPropertyChanged(sPath);
            if (PROFIT != null)
                PROFIT.SendPropertyChanged(sPath);
            if (SHEET_STATEMENT != null)
                SHEET_STATEMENT.SendPropertyChanged(sPath);

        }

        
        private Step_BalanceAndOthers_Balance _Balance;
        public Step_BalanceAndOthers_Balance Balance
        {
            get
            {
                if (_Balance == null)
                    _Balance = new Step_BalanceAndOthers_Balance();
                return _Balance;
            }
            set
            {
                if (_Balance != value)
                {
                    _Balance = value;
                    SendPropertyChanged("Balance");
                }
            }
        }

        
        public Step_BalanceAndOthers_InvestmentCalculation InvestmentCalculation { get; set; }
        
        public Step_BalanceAndOthers_Trade Trade { get; set; }
        
        public Step_BalanceAndOthers_Price Price { get; set; }
        
        public Step_BalanceAndOthers_InvestmentPlan InvestmentPlan { get; set; }
        
        public Step_BalanceAndOthers_LIQUIDITYPLAN LIQUIDITYPLAN { get; set; }
        
        public Step_BalanceAndOthers_Depreciation_Calculation DEPRECIATION_CALCULATION { get; set; }
        
        public Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT PROFIT { get; set; }
        
        public Step_BalanceAndOthers_Sheet_Statement SHEET_STATEMENT { get; set; }
    }
}