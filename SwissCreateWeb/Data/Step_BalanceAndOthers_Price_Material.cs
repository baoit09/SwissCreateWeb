using SwissCreateWeb.Models.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
//using ViCode_LeVi.Data;

namespace SwissCreateWeb.Data
{
    public class Step_BalanceAndOthers_Price_Material : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        public string CompanyName { get { return ProjectData.Intance.CompanyName; } }
        #region IndividualMaterial

        string _IndividualMaterial = string.Empty;
        public string IndividualMaterial
        {
            get { return _IndividualMaterial; }
            set
            {
                if (_IndividualMaterial != value)
                {
                    _IndividualMaterial = value;
                    SendPropertyChanged("IndividualMaterial");
                }
            }
        }
        #endregion

        #region Costs

        double _Costs = 0;
        public double Costs
        {
            get { return _Costs; }
            set
            {
                if (_Costs != value)
                {
                    _Costs = value;
                    SendPropertyChanged("Costs");
                }
            }
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
    
    