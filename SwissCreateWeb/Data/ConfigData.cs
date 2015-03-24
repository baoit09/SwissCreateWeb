using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SwissCreateWeb.Data
{
    
    public class ConfigData
    {
        public void Refine()
        {
            if (_Config_Budget == null)
                _Config_Budget = new ConfigData_Budget();
        }
        #region Config_Budget
        
        ConfigData_Budget _Config_Budget;
        public ConfigData_Budget Config_Budget { get { return _Config_Budget; } set { _Config_Budget = value; } }
        #endregion
    }
    
    public class ConfigData_Budget : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region AutoSetCostByTotalOfChildren
        
        bool _AutoSetCostByTotalOfChildren;
        public bool AutoSetCostByTotalOfChildren
        {
            get { return _AutoSetCostByTotalOfChildren; }
            set
            {
                if (_AutoSetCostByTotalOfChildren != value)
                {
                    _AutoSetCostByTotalOfChildren = value;
                    SendPropertyChanged("AutoSetCostByTotalOfChildren");
                }
            }
        }
        #endregion
    }
}