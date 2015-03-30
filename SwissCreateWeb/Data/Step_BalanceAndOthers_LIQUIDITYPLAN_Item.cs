using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ViCode_LeVi.Data
{
    public class Step_BalanceAndOthers_LIQUIDITYPLAN_Item : INotifyPropertyChanged
    {
        Step_BalanceAndOthers_LIQUIDITYPLAN _Parent;
        public Step_BalanceAndOthers_LIQUIDITYPLAN Parent
        {
            get { return _Parent; }
            set
            {
                if (value != _Parent)
                {
                    _Parent = value;
                    this.PropertyChanged -= new PropertyChangedEventHandler(Step_BalanceAndOthers_LIQUIDITYPLAN_Item_PropertyChanged);
                    this.PropertyChanged += new PropertyChangedEventHandler(Step_BalanceAndOthers_LIQUIDITYPLAN_Item_PropertyChanged);
                }
            }
        }
        public Step_BalanceAndOthers_LIQUIDITYPLAN_Item()
        {
        }

        public Step_BalanceAndOthers_LIQUIDITYPLAN_Item(Step_BalanceAndOthers_LIQUIDITYPLAN parent)
        {
            Parent = parent;
        }

        void Step_BalanceAndOthers_LIQUIDITYPLAN_Item_PropertyChanged(object sender, PropertyChangedEventArgs e)
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

        #region ShowAtDepreciation
        
        bool _ShowAtDepreciation = false;
        public bool ShowAtDepreciation
        {
            get
            {
                return _ShowAtDepreciation;
            }
            set
            {
                if (_ShowAtDepreciation != value)
                {
                    _ShowAtDepreciation = value;
                    SendPropertyChanged("ShowAtDepreciation");
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
    }
}