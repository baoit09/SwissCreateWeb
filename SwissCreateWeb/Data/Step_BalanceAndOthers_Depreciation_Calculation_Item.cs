using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SwissCreateWeb.Data
{
    public class Step_BalanceAndOthers_Depreciation_Calculation_Item : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public Step_BalanceAndOthers_Depreciation_Calculation_Item()
        {

        }

        public void SendPropertyChanged_All_Computed()
        {
            SendPropertyChanged("Initial_Year_Depreciation");
            SendPropertyChanged("Year1_Balance_Value");
            SendPropertyChanged("Year1_Depreciation");
            SendPropertyChanged("Year2_Balance_Value");
            SendPropertyChanged("Year2_Depreciation");
            SendPropertyChanged("Year3_Balance_Value");
            SendPropertyChanged("Year3_Depreciation");
            SendPropertyChanged("Year4_Balance_Value");
            SendPropertyChanged("Year4_Depreciation");
            SendPropertyChanged("Year5_Balance_Value");
            SendPropertyChanged("Year5_Depreciation");
            SendPropertyChanged("Total_Balance_Value");
            SendPropertyChanged("Total_Depreciation");
            if (Parent != null)
                Parent.SendPropertyChanged_All_Computed();
        }
        #endregion

        #region Liq
        public Step_BalanceAndOthers_LIQUIDITYPLAN_Item LIQUIDITYPLAN_Item_OutFlow_Investing_Activities;
        public Step_BalanceAndOthers_LIQUIDITYPLAN_Item LIQUIDITYPLAN_Item_InFlow_Investing_Activities;
        #endregion

        #region Parent
        Step_BalanceAndOthers_Depreciation_Calculation _Parent;
        public Step_BalanceAndOthers_Depreciation_Calculation Parent
        {
            get { return _Parent; }
            set
            {
                if (value != _Parent)
                {
                    _Parent = value;
                    this.PropertyChanged -= new PropertyChangedEventHandler(Step_BalanceAndOthers_Depreciation_Calculation_Item_PropertyChanged);
                    this.PropertyChanged += new PropertyChangedEventHandler(Step_BalanceAndOthers_Depreciation_Calculation_Item_PropertyChanged);
                }
            }
        }
        void Step_BalanceAndOthers_Depreciation_Calculation_Item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //if (Parent != null)
            //    Parent.SendPropertyChanged_Total();
        }
        public Step_BalanceAndOthers_Depreciation_Calculation_Item(Step_BalanceAndOthers_Depreciation_Calculation parent)
        {
            Parent = parent;
        }
        #endregion

        #region Data
        #region Investment
        public string Investment
        {
            get
            {
                return LIQUIDITYPLAN_Item_OutFlow_Investing_Activities == null ? string.Empty : LIQUIDITYPLAN_Item_OutFlow_Investing_Activities.Name;
            }
        }
        #endregion



        #region Calculation_Per_Years
        
        double _Calculation_Per_Years = 0;
        public double Calculation_Per_Years
        {
            get
            {
                return _Calculation_Per_Years;
            }
            set
            {
                if (_Calculation_Per_Years != value)
                {
                    _Calculation_Per_Years = value;
                    SendPropertyChanged("Calculation_Per_Years");
                    SendPropertyChanged_All_Computed();
                }
            }
        }
        #endregion

        #region Initial_Balance_Value
        
        double _Initial_Balance_Value = 0;
        public double Initial_Balance_Value
        {
            get
            {
                return _Initial_Balance_Value;
            }
            set
            {
                if (_Initial_Balance_Value != value)
                {
                    _Initial_Balance_Value = value;
                    SendPropertyChanged("Initial_Balance_Value");
                    SendPropertyChanged_All_Computed();
                }
            }
        }
        #endregion

        #region IsActive
        bool _IsActive = false;
        public bool IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                if (_IsActive != value)
                {
                    _IsActive = value;
                    SendPropertyChanged("IsActive");
                }
            }
        }
        #endregion

        #endregion

        #region Property will be computed

        #region Initial_Year_Depreciation
        public double Initial_Year_Depreciation
        {
            get
            {
                if (Calculation_Per_Years == 0)
                    return 0;
                return Initial_Balance_Value / Calculation_Per_Years; ;
            }
        }
        #endregion

        public double Year1_Balance_Value
        {
            get
            {
                return Initial_Balance_Value
                    + (LIQUIDITYPLAN_Item_OutFlow_Investing_Activities != null ? LIQUIDITYPLAN_Item_OutFlow_Investing_Activities.Year1 : 0)
                    - (LIQUIDITYPLAN_Item_InFlow_Investing_Activities != null ? LIQUIDITYPLAN_Item_InFlow_Investing_Activities.Year1 : 0)
                    ;
            }
        }
        public double Year1_Depreciation
        {
            get
            {
                if (Calculation_Per_Years == 0)
                    return 0;
                return Year1_Balance_Value / Calculation_Per_Years;
            }
        }

        public double Year2_Balance_Value
        {
            get
            {
                if (Calculation_Per_Years < 2)
                    return 0;
                return Year1_Balance_Value
                    + (LIQUIDITYPLAN_Item_OutFlow_Investing_Activities != null ? LIQUIDITYPLAN_Item_OutFlow_Investing_Activities.Year2 : 0)
                    - (LIQUIDITYPLAN_Item_InFlow_Investing_Activities != null ? LIQUIDITYPLAN_Item_InFlow_Investing_Activities.Year2 : 0)
                    ;
            }
        }
        public double Year2_Depreciation
        {
            get
            {
                if (Calculation_Per_Years == 0)
                    return 0;
                return Year2_Balance_Value / Calculation_Per_Years;
            }
        }

        public double Year3_Balance_Value
        {
            get
            {
                if (Calculation_Per_Years < 3)
                    return 0;
                return Year2_Balance_Value
                    + (LIQUIDITYPLAN_Item_OutFlow_Investing_Activities != null ? LIQUIDITYPLAN_Item_OutFlow_Investing_Activities.Year3 : 0)
                    - (LIQUIDITYPLAN_Item_InFlow_Investing_Activities != null ? LIQUIDITYPLAN_Item_InFlow_Investing_Activities.Year3 : 0)
                    ;
            }
        }
        public double Year3_Depreciation
        {
            get
            {
                if (Calculation_Per_Years == 0)
                    return 0;
                return Year3_Balance_Value / Calculation_Per_Years;
            }
        }

        public double Year4_Balance_Value
        {
            get
            {
                if (Calculation_Per_Years < 4)
                    return 0;
                return Year3_Balance_Value
                    + (LIQUIDITYPLAN_Item_OutFlow_Investing_Activities != null ? LIQUIDITYPLAN_Item_OutFlow_Investing_Activities.Year4 : 0)
                    - (LIQUIDITYPLAN_Item_InFlow_Investing_Activities != null ? LIQUIDITYPLAN_Item_InFlow_Investing_Activities.Year4 : 0)
                    ;
            }
        }
        public double Year4_Depreciation
        {
            get
            {
                if (Calculation_Per_Years == 0)
                    return 0;
                return Year4_Balance_Value / Calculation_Per_Years;
            }
        }

        public double Year5_Balance_Value
        {
            get
            {
                if (Calculation_Per_Years < 5)
                    return 0;
                return Year4_Balance_Value
                    + (LIQUIDITYPLAN_Item_OutFlow_Investing_Activities != null ? LIQUIDITYPLAN_Item_OutFlow_Investing_Activities.Year5 : 0)
                    - (LIQUIDITYPLAN_Item_InFlow_Investing_Activities != null ? LIQUIDITYPLAN_Item_InFlow_Investing_Activities.Year5 : 0)
                    ;
            }
        }
        public double Year5_Depreciation
        {
            get
            {
                if (Calculation_Per_Years == 0)
                    return 0;
                return Year5_Balance_Value / Calculation_Per_Years;
            }
        }

        public double Total_Balance_Value
        {
            get
            {
                return Year5_Balance_Value - Total_Depreciation;
            }
        }
        public double Total_Depreciation
        {
            get
            {
                return Year1_Depreciation + Year2_Depreciation + Year3_Depreciation + Year4_Depreciation + Year5_Depreciation;
            }
        }
        #endregion
    }
}