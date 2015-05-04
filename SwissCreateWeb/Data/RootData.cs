using SwissCreateWeb.Models.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using ViCode_LeVi.Data;

namespace ViCode_LeVi.Data
{
    public class RootData : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        public static RootData Intance
        {
            get { return ProjectData.Intance.Periods[0]; }
        }

        public StepInfo[] Steps { get; set; }

        #region ConfigData
        
        ConfigData _ConfigData;
        public ConfigData ConfigData
        {
            get
            {
                if (_ConfigData == null)
                    _ConfigData = new ConfigData();
                _ConfigData.Refine();
                return _ConfigData;
            }
            set { _ConfigData = value; }
        }
        #endregion

        #region Finance alanceAndOthers
        public int Report_Finance_Index
        {
            get { return 9; }
        }
        public Step_BalanceAndOthers_LIQUIDITYPLAN Tab_Finance_LIQUIDITYPLAN
        {
            get
            {
                //int index = Report_Finance_Index;
                //var step = this.Steps[index];
                //if (step == null || step.BalanceAndOthers == null
                //    || step.BalanceAndOthers.LIQUIDITYPLAN == null)
                //    return null;
                //return step.BalanceAndOthers.LIQUIDITYPLAN;
                return null;
            }
        }
        public Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT Tab_Finance_PROFIT_LOSS_STATEMENT
        {
            get
            {
                //int index = Report_Finance_Index;
                //var step = this.Steps[index];
                //if (step == null || step.BalanceAndOthers == null
                //    || step.BalanceAndOthers.PROFIT == null)
                //    return null;
                //return step.BalanceAndOthers.PROFIT;

                return null;
            }
        }
        public Step_BalanceAndOthers_Depreciation_Calculation Tab_Finance_DEPRECIATION_CALCULATION
        {
            get
            {
                //int index = Report_Finance_Index;
                //var step = this.Steps[index];
                //if (step == null || step.BalanceAndOthers == null
                //    || step.BalanceAndOthers.DEPRECIATION_CALCULATION == null)
                //    return null;
                //return step.BalanceAndOthers.DEPRECIATION_CALCULATION;

                return null;
            }
        }

        #endregion

    }
}