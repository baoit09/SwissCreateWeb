using SwissCreateWeb.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Data
{
    public class Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item : INotifyPropertyChanged
    {
        Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT _Parent;
        public Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT Parent
        {
            get { return _Parent; }
            set
            {
                if (value != _Parent)
                {
                    _Parent = value;
                    if (DontCatchPropertyChange == false)
                    {
                        this.PropertyChanged -= new PropertyChangedEventHandler(Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item_PropertyChanged);
                        this.PropertyChanged += new PropertyChangedEventHandler(Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item_PropertyChanged);
                    }
                }
            }
        }
        public bool DontCatchPropertyChange = false;

        public Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item()
        {

        }

        public Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item(Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT parent)
        {
            Parent = parent;
        }
        public Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item(Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT parent, bool pDontCatchPropertyChange)
        {
            DontCatchPropertyChange = pDontCatchPropertyChange;
            Parent = parent;
        }

        void Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (DontCatchPropertyChange == true)
                return;
            if (e.PropertyName == "Year1"
                || e.PropertyName == "Year2"
                || e.PropertyName == "Year3"
                || e.PropertyName == "Year4"
                || e.PropertyName == "Year5"
                )
            {
                if (Parent != null)
                    Parent.SendPropertyChanged_Total();
            }
        }

        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Data
        #region GroupName
        
        string _GroupName = string.Empty;
        public string GroupName
        {
            get
            {
                return _GroupName;
            }
            set
            {
                if (_GroupName != value)
                {
                    _GroupName = value;
                    SendPropertyChanged("GroupName");
                }
            }
        }
        #endregion

        #region Name
        
        string _Name = string.Empty;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    SendPropertyChanged("Name");
                }
            }
        }
        #endregion

        #region Year1
        
        double _Year1 = 0;
        public double Year1
        {
            get
            {
                return _Year1;
            }
            set
            {
                if (_Year1 != value)
                {
                    _Year1 = value;
                    SendPropertyChanged("Year1");
                }
            }
        }
        #endregion

        #region Year2
        
        double _Year2 = 0;
        public double Year2
        {
            get
            {
                return _Year2;
            }
            set
            {
                if (_Year2 != value)
                {
                    _Year2 = value;
                    SendPropertyChanged("Year2");
                }
            }
        }
        #endregion

        #region Year3
        
        double _Year3 = 0;
        public double Year3
        {
            get
            {
                return _Year3;
            }
            set
            {
                if (_Year3 != value)
                {
                    _Year3 = value;
                    SendPropertyChanged("Year3");
                }
            }
        }
        #endregion

        #region Year4
        
        double _Year4 = 0;
        public double Year4
        {
            get
            {
                return _Year4;
            }
            set
            {
                if (_Year4 != value)
                {
                    _Year4 = value;
                    SendPropertyChanged("Year4");
                }
            }
        }
        #endregion

        #region Year5
        
        double _Year5 = 0;
        public double Year5
        {
            get
            {
                return _Year5;
            }
            set
            {
                if (_Year5 != value)
                {
                    _Year5 = value;
                    SendPropertyChanged("Year5");
                }
            }
        }
        #endregion
        #endregion

        #region CurrencySymbol
        
        string _CurrencySymbol = string.Empty;
        public string CurrencySymbol
        {
            get { 
                //if (string.IsNullOrEmpty(_CurrencySymbol)) return ViCode_LeVi.Langs.ControlTextInfo.Intance.CurrencySymbol; 
                return _CurrencySymbol; }
            set
            {
                if (_CurrencySymbol != value)
                {
                    _CurrencySymbol = value;
                    SendPropertyChanged("CurrencySymbol");
                }
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