using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SwissCreateWeb.Data
{
    public class Step_BalanceAndOthers_InvestmentPlan_Item : INotifyPropertyChanged
    {
        Step_BalanceAndOthers_InvestmentPlan _Parent;
        public Step_BalanceAndOthers_InvestmentPlan Parent
        {
            get { return _Parent; }
            set
            {
                if (value != _Parent)
                {
                    _Parent = value;
                    this.PropertyChanged -= new PropertyChangedEventHandler(Step_BalanceAndOthers_InvestmentPlan_Item_PropertyChanged);
                    this.PropertyChanged += new PropertyChangedEventHandler(Step_BalanceAndOthers_InvestmentPlan_Item_PropertyChanged);
                }
            }
        }
        public Step_BalanceAndOthers_InvestmentPlan_Item(Step_BalanceAndOthers_InvestmentPlan parent)
        {
            Parent = parent;
        }


        void Step_BalanceAndOthers_InvestmentPlan_Item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (Parent != null)
                Parent.SendPropertyChanged_Total();
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

        #region Value
        
        double _Value = 0;
        public double Value
        {
            get
            {
                return _Value;
            }
            set
            {
                if (_Value != value)
                {
                    _Value = value;
                    SendPropertyChanged("Value");
                }
            }
        }
        #endregion

        #region Year1
        //Lo sai roi gio de em, lam proerty khac
        
        string _Year1 = string.Empty;
        
        public double _Year1_Temp = 0;
        public double Year1
        {
            get
            {
                return _Year1_Temp;
            }
            set
            {
                if (_Year1_Temp != value)
                {
                    _Year1_Temp = value;
                    SendPropertyChanged("Year1");
                }
            }
        }
        #endregion

        #region Year2
        
        string _Year2 = string.Empty;
        
        public double _Year2_Temp = 0;
        public double Year2
        {
            get
            {
                return _Year2_Temp;
            }
            set
            {
                if (_Year2_Temp != value)
                {
                    _Year2_Temp = value;
                    SendPropertyChanged("Year2");
                }
            }
        }
        #endregion

        #region Year3
        
        string _Year3 = string.Empty;
        
        public double _Year3_Temp = 0;
        public double Year3
        {
            get
            {
                return _Year3_Temp;
            }
            set
            {
                if (_Year3_Temp != value)
                {
                    _Year3_Temp = value;
                    SendPropertyChanged("Year3");
                }
            }
        }
        #endregion

        #region Year4
        
        string _Year4 = string.Empty;
        
        public double _Year4_Temp = 0;
        public double Year4
        {
            get
            {
                return _Year4_Temp;
            }
            set
            {
                if (_Year4_Temp != value)
                {
                    _Year4_Temp = value;
                    SendPropertyChanged("Year4");
                }
            }
        }
        #endregion

        #region Year5
        
        string _Year5 = string.Empty;
        
        public double _Year5_Temp = 0;
        public double Year5
        {
            get
            {
                return _Year5_Temp;
            }
            set
            {
                if (_Year5_Temp != value)
                {
                    _Year5_Temp = value;
                    SendPropertyChanged("Year5");
                }
            }
        }
        #endregion

        #region UseFor
        
        string _UseFor = string.Empty;
        public string UseFor
        {
            get
            {
                return _UseFor;
            }
            set
            {
                if (_UseFor != value)
                {
                    _UseFor = value;
                    SendPropertyChanged("UseFor");
                }
            }
        }
        #endregion

        #region FinancingMethod
        
        string _FinancingMethod = string.Empty;
        public string FinancingMethod
        {
            get
            {
                return _FinancingMethod;
            }
            set
            {
                if (_FinancingMethod != value)
                {
                    _FinancingMethod = value;
                    SendPropertyChanged("FinancingMethod");
                }
            }
        }
        #endregion

        #region AdditionalRemark
        
        string _AdditionalRemark = string.Empty;
        public string AdditionalRemark
        {
            get
            {
                return _AdditionalRemark;
            }
            set
            {
                if (_AdditionalRemark != value)
                {
                    _AdditionalRemark = value;
                    SendPropertyChanged("AdditionalRemark");
                }
            }
        }
        #endregion
        #endregion
    }
}