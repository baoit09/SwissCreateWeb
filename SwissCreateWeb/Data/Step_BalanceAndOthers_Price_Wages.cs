using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ViCode_LeVi.Data
{
    public class Step_BalanceAndOthers_Price_Wages : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region DirectLaborCosts
        
        string _DirectLaborCosts = string.Empty;
        public string DirectLaborCosts
        {
            get { return _DirectLaborCosts; }
            set
            {
                if (_DirectLaborCosts != value)
                {
                    _DirectLaborCosts = value;
                    SendPropertyChanged("DirectLaborCosts");
                }
            }
        }
        #endregion

        #region Hours
        
        double _Hours = 0;
        public double Hours
        {
            get { return _Hours; }
            set
            {
                if (_Hours != value)
                {
                    _Hours = value;
                    SendPropertyChanged("Hours");
                    SendPropertyChanged("Costs");
                }
            }
        }
        #endregion

        #region RatePerHour
        
        double _RatePerHour = 0;
        public double RatePerHour
        {
            get { return _RatePerHour; }
            set
            {
                if (_RatePerHour != value)
                {
                    _RatePerHour = value;
                    SendPropertyChanged("RatePerHour");
                    SendPropertyChanged("Costs");
                }
            }
        }
        #endregion

        #region Costs
        public double Costs
        {
            get { return VMMath.Round(Hours * RatePerHour); }
        }
        #endregion

        #region CurrencySymbol
        
        string _CurrencySymbol = string.Empty;
        public string CurrencySymbol
        {
            get
            {
                //if (ControlTextInfo.JustUse1CurrencySymbolInProject == true)
                //    return ViCode_LeVi.Langs.ControlTextInfo.Intance.CurrencySymbol;
                //if (string.IsNullOrEmpty(_CurrencySymbol))
                //    return ViCode_LeVi.Langs.ControlTextInfo.Intance.CurrencySymbol;
                return _CurrencySymbol;
            }
            set
            {
                //if (ControlTextInfo.JustUse1CurrencySymbolInProject == true)
                //    ViCode_LeVi.Langs.ControlTextInfo.Intance.CurrencySymbol = value;
                //else if (_CurrencySymbol != value)
                //{
                //    _CurrencySymbol = value;
                //    SendPropertyChanged("CurrencySymbol");
                //}
            }
        }
        #endregion

        #region CurrencySymbol_UI
        
        string _CurrencySymbol_UI = "Currency Symbol";
        public string CurrencySymbol_UI
        {
            get { return _CurrencySymbol_UI; }
            set
            {
                if (_CurrencySymbol_UI != value)
                {
                    _CurrencySymbol_UI = value;
                    SendPropertyChanged("CurrencySymbol_UI");
                }
            }
        }
        #endregion
    }
}