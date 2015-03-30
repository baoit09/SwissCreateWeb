using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ViCode_LeVi.Data
{
    public class Step_BalanceAndOthers_Depreciation_Calculation : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void SendPropertyChanged_All_Computed()
        {
            SendPropertyChanged("Total_Initial_Balance_Value");
            SendPropertyChanged("Total_Initial_Year_Depreciation");
            SendPropertyChanged("Total_Year1_Balance_Value");
            SendPropertyChanged("Total_Year1_Depreciation");
            SendPropertyChanged("Total_Year2_Balance_Value");
            SendPropertyChanged("Total_Year2_Depreciation");
            SendPropertyChanged("Total_Year3_Balance_Value");
            SendPropertyChanged("Total_Year3_Depreciation");
            SendPropertyChanged("Total_Year4_Balance_Value");
            SendPropertyChanged("Total_Year4_Depreciation");
            SendPropertyChanged("Total_Year5_Balance_Value");
            SendPropertyChanged("Total_Year5_Depreciation");
            SendPropertyChanged("Total_Total_Balance_Value");
            SendPropertyChanged("Total_Total_Depreciation");
        }
        #endregion

        public Step_BalanceAndOthers_Depreciation_Calculation()
        {
            if (Items == null)
                Items = new List<Step_BalanceAndOthers_Depreciation_Calculation_Item>();
        }
        
        private List<Step_BalanceAndOthers_Depreciation_Calculation_Item> Items { get; set; }

        public Step_BalanceAndOthers_Depreciation_Calculation_Item[] Items_Active
        {
            get
            {
                return Items == null ? new Step_BalanceAndOthers_Depreciation_Calculation_Item[0] :
                        Items.Where(c => c.IsActive == true).ToArray();
            }
        }

        public void RefreshData()
        {
            if (Items == null)
                Items = new List<Step_BalanceAndOthers_Depreciation_Calculation_Item>();
            var _items = Items;
            foreach (var item in _items)
            {
                if (item != null)
                {
                    if (item.Parent != this)
                        item.Parent = this;
                }
            }
            Build_Items_From_LIQUIDITYPLAN();
        }
        public void Build_Items_From_LIQUIDITYPLAN()
        {
            if (RootData.Intance != null
                && RootData.Intance.Tab_Finance_LIQUIDITYPLAN != null)
            {
                var liqOutItems = RootData.Intance.Tab_Finance_LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES;
                var liqInItems = RootData.Intance.Tab_Finance_LIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES;
                if (liqOutItems != null)// && liqItems.Length > 0)
                {
                    for (int i = 0; i < liqOutItems.Length; i++)
                    {
                        Step_BalanceAndOthers_Depreciation_Calculation_Item newItem = null;
                        if (Items.Count > i)
                        {
                            newItem = Items[i];
                        }
                        else
                        {
                            newItem = new Step_BalanceAndOthers_Depreciation_Calculation_Item(this);
                            Items.Add(newItem);
                        }
                        newItem.LIQUIDITYPLAN_Item_OutFlow_Investing_Activities = liqOutItems[i];

                        if (liqInItems.Length > i)
                            newItem.LIQUIDITYPLAN_Item_InFlow_Investing_Activities = liqInItems[i];
                        else
                            newItem.LIQUIDITYPLAN_Item_InFlow_Investing_Activities = null;

                        newItem.IsActive = newItem.LIQUIDITYPLAN_Item_OutFlow_Investing_Activities.ShowAtDepreciation;
                    }
                }
                //Remove others
                int lenOfLiq = liqOutItems != null ? liqOutItems.Length : 0;
                //Very bad code
                //for (int i = lenOfLiq; i < liqOutItems.Length; i++)
                //{                    
                //    Items.RemoveAt(i);
                //}
                while (Items.Count > lenOfLiq)
                {
                    Items.RemoveAt(lenOfLiq);
                }
            }
        }
        public void Build_Item_Total()
        {
        }
        #region UI
        #region Step_BalanceAndOthers_DEPRECIATION_CALCULATION_Header
        
        string _Step_BalanceAndOthers_DEPRECIATION_CALCULATION_Header = string.Empty;
        public string Step_BalanceAndOthers_DEPRECIATION_CALCULATION_Header_4Report
        {
            get
            {
                //if (Report_Config_Finance.IsConvertHeaderToUpper == true)
                //    return Step_BalanceAndOthers_DEPRECIATION_CALCULATION_Header.ToUpper();
                return Step_BalanceAndOthers_DEPRECIATION_CALCULATION_Header;
            }
        }
        public string Step_BalanceAndOthers_DEPRECIATION_CALCULATION_Header
        {
            get
            {
                if (string.IsNullOrEmpty(_Step_BalanceAndOthers_DEPRECIATION_CALCULATION_Header))
                {
                    _Step_BalanceAndOthers_DEPRECIATION_CALCULATION_Header = "Depreciation Calculation";
                }
                return _Step_BalanceAndOthers_DEPRECIATION_CALCULATION_Header;
            }
            set
            {
                if (_Step_BalanceAndOthers_DEPRECIATION_CALCULATION_Header != value)
                {
                    _Step_BalanceAndOthers_DEPRECIATION_CALCULATION_Header = value;
                    SendPropertyChanged("Step_BalanceAndOthers_DEPRECIATION_CALCULATION_Header");
                }
            }
        }
        #endregion

        #region UIText_TOTAL_Text
        
        string _UIText_TOTAL_Text = string.Empty;
        public string UIText_TOTAL_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_TOTAL_Text))
                {
                    _UIText_TOTAL_Text = "TOTAL";
                }
                return _UIText_TOTAL_Text;
            }
            set
            {
                if (_UIText_TOTAL_Text != value)
                {
                    _UIText_TOTAL_Text = value;
                    SendPropertyChanged("UIText_TOTAL_Text");
                }
            }
        }
        #endregion

        #region UIText_Investment
        
        string _UIText_Investment = string.Empty;
        public string UIText_Investment
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Investment))
                {
                    _UIText_Investment = "Investment";
                }
                return _UIText_Investment;
            }
            set
            {
                if (_UIText_Investment != value)
                {
                    _UIText_Investment = value;
                    SendPropertyChanged("UIText_Investment");
                }
            }
        }
        #endregion

        #region UIText_Calculation_Per_Years
        
        string _UIText_Calculation_Per_Years = string.Empty;
        public string UIText_Calculation_Per_Years
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Calculation_Per_Years))
                {
                    _UIText_Calculation_Per_Years = "Calculation per years";
                }
                return _UIText_Calculation_Per_Years;
            }
            set
            {
                if (_UIText_Calculation_Per_Years != value)
                {
                    _UIText_Calculation_Per_Years = value;
                    SendPropertyChanged("UIText_Calculation_Per_Years");
                }
            }
        }
        #endregion

        #region UIText_Initial_Balance_Value
        
        string _UIText_Initial_Balance_Value = string.Empty;
        public string UIText_Initial_Balance_Value
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Initial_Balance_Value))
                {
                    _UIText_Initial_Balance_Value = "Initial Balance Value";
                }
                return _UIText_Initial_Balance_Value;
            }
            set
            {
                if (_UIText_Initial_Balance_Value != value)
                {
                    _UIText_Initial_Balance_Value = value;
                    SendPropertyChanged("UIText_Initial_Balance_Value");
                }
            }
        }
        #endregion

        #region UIText_Initial_Year_Depreciation
        
        string _UIText_Initial_Year_Depreciation = string.Empty;
        public string UIText_Initial_Year_Depreciation
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Initial_Year_Depreciation))
                {
                    _UIText_Initial_Year_Depreciation = "Initial Year Depreciation";
                }
                return _UIText_Initial_Year_Depreciation;
            }
            set
            {
                if (_UIText_Initial_Year_Depreciation != value)
                {
                    _UIText_Initial_Year_Depreciation = value;
                    SendPropertyChanged("UIText_Initial_Year_Depreciation");
                }
            }
        }
        #endregion

        #region UIText_Year1_Balance_Value
        
        string _UIText_Year1_Balance_Value = string.Empty;
        public string UIText_Year1_Balance_Value
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Year1_Balance_Value))
                {
                    _UIText_Year1_Balance_Value = "Year 1 Balance Value";
                }
                return _UIText_Year1_Balance_Value;
            }
            set
            {
                if (_UIText_Year1_Balance_Value != value)
                {
                    _UIText_Year1_Balance_Value = value;
                    SendPropertyChanged("UIText_Year1_Balance_Value");
                }
            }
        }
        #endregion

        #region UIText_Year2_Balance_Value
        
        string _UIText_Year2_Balance_Value = string.Empty;
        public string UIText_Year2_Balance_Value
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Year2_Balance_Value))
                {
                    _UIText_Year2_Balance_Value = "Year 2 Balance Value";
                }
                return _UIText_Year2_Balance_Value;
            }
            set
            {
                if (_UIText_Year2_Balance_Value != value)
                {
                    _UIText_Year2_Balance_Value = value;
                    SendPropertyChanged("UIText_Year2_Balance_Value");
                }
            }
        }
        #endregion

        #region UIText_Year3_Balance_Value
        
        string _UIText_Year3_Balance_Value = string.Empty;
        public string UIText_Year3_Balance_Value
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Year3_Balance_Value))
                {
                    _UIText_Year3_Balance_Value = "Year 3 Balance Value";
                }
                return _UIText_Year3_Balance_Value;
            }
            set
            {
                if (_UIText_Year3_Balance_Value != value)
                {
                    _UIText_Year3_Balance_Value = value;
                    SendPropertyChanged("UIText_Year3_Balance_Value");
                }
            }
        }
        #endregion

        #region UIText_Year4_Balance_Value
      
        string _UIText_Year4_Balance_Value = string.Empty;
        public string UIText_Year4_Balance_Value
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Year4_Balance_Value))
                {
                    _UIText_Year4_Balance_Value = "Year 4 Balance Value";
                }
                return _UIText_Year4_Balance_Value;
            }
            set
            {
                if (_UIText_Year4_Balance_Value != value)
                {
                    _UIText_Year4_Balance_Value = value;
                    SendPropertyChanged("UIText_Year4_Balance_Value");
                }
            }
        }
        #endregion

        #region UIText_Year5_Balance_Value
        
        string _UIText_Year5_Balance_Value = string.Empty;
        public string UIText_Year5_Balance_Value
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Year5_Balance_Value))
                {
                    _UIText_Year5_Balance_Value = "Year 5 Balance Value";
                }
                return _UIText_Year5_Balance_Value;
            }
            set
            {
                if (_UIText_Year5_Balance_Value != value)
                {
                    _UIText_Year5_Balance_Value = value;
                    SendPropertyChanged("UIText_Year5_Balance_Value");
                }
            }
        }
        #endregion

        #region UIText_TOTAL_Balance_Value
        
        string _UIText_TOTAL_Balance_Value = string.Empty;
        public string UIText_TOTAL_Balance_Value
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_TOTAL_Balance_Value))
                {
                    _UIText_TOTAL_Balance_Value = "TOTAL Balance Value";
                }
                return _UIText_TOTAL_Balance_Value;
            }
            set
            {
                if (_UIText_TOTAL_Balance_Value != value)
                {
                    _UIText_TOTAL_Balance_Value = value;
                    SendPropertyChanged("UIText_TOTAL_Balance_Value");
                }
            }
        }
        #endregion

        #region UIText_Year1_Depreciation
        
        string _UIText_Year1_Depreciation = string.Empty;
        public string UIText_Year1_Depreciation
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Year1_Depreciation))
                {
                    _UIText_Year1_Depreciation = "Year 1 Depreciation";
                }
                return _UIText_Year1_Depreciation;
            }
            set
            {
                if (_UIText_Year1_Depreciation != value)
                {
                    _UIText_Year1_Depreciation = value;
                    SendPropertyChanged("UIText_Year1_Depreciation");
                }
            }
        }
        #endregion

        #region UIText_Year2_Depreciation
        
        string _UIText_Year2_Depreciation = string.Empty;
        public string UIText_Year2_Depreciation
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Year2_Depreciation))
                {
                    _UIText_Year2_Depreciation = "Year 2 Depreciation";
                }
                return _UIText_Year2_Depreciation;
            }
            set
            {
                if (_UIText_Year2_Depreciation != value)
                {
                    _UIText_Year2_Depreciation = value;
                    SendPropertyChanged("UIText_Year2_Depreciation");
                }
            }
        }
        #endregion

        #region UIText_Year3_Depreciation
        
        string _UIText_Year3_Depreciation = string.Empty;
        public string UIText_Year3_Depreciation
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Year3_Depreciation))
                {
                    _UIText_Year3_Depreciation = "Year 3 Depreciation";
                }
                return _UIText_Year3_Depreciation;
            }
            set
            {
                if (_UIText_Year3_Depreciation != value)
                {
                    _UIText_Year3_Depreciation = value;
                    SendPropertyChanged("UIText_Year3_Depreciation");
                }
            }
        }
        #endregion

        #region UIText_Year4_Depreciation
        
        string _UIText_Year4_Depreciation = string.Empty;
        public string UIText_Year4_Depreciation
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Year4_Depreciation))
                {
                    _UIText_Year4_Depreciation = "Year 4 Depreciation";
                }
                return _UIText_Year4_Depreciation;
            }
            set
            {
                if (_UIText_Year4_Depreciation != value)
                {
                    _UIText_Year4_Depreciation = value;
                    SendPropertyChanged("UIText_Year4_Depreciation");
                }
            }
        }
        #endregion

        #region UIText_Year5_Depreciation
        
        string _UIText_Year5_Depreciation = string.Empty;
        public string UIText_Year5_Depreciation
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Year5_Depreciation))
                {
                    _UIText_Year5_Depreciation = "Year 5 Depreciation";
                }
                return _UIText_Year5_Depreciation;
            }
            set
            {
                if (_UIText_Year5_Depreciation != value)
                {
                    _UIText_Year5_Depreciation = value;
                    SendPropertyChanged("UIText_Year5_Depreciation");
                }
            }
        }
        #endregion

        #region UIText_TOTAL_Depreciation
        
        string _UIText_TOTAL_Depreciation = string.Empty;
        public string UIText_TOTAL_Depreciation
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_TOTAL_Depreciation))
                {
                    _UIText_TOTAL_Depreciation = "TOTAL Depreciation";
                }
                return _UIText_TOTAL_Depreciation;
            }
            set
            {
                if (_UIText_TOTAL_Depreciation != value)
                {
                    _UIText_TOTAL_Depreciation = value;
                    SendPropertyChanged("UIText_TOTAL_Depreciation");
                }
            }
        }
        #endregion
        #endregion

        #region Property will be computed
        #region Total_Initial_Balance_Value
        public double Total_Initial_Balance_Value
        {
            get
            {
                if (Items_Active != null && Items_Active.Length > 0)
                    return Items_Active.Sum(c => c.Initial_Balance_Value);
                return 0;
            }
        }
        #endregion

        #region Total_Initial_Year_Depreciation
        public double Total_Initial_Year_Depreciation
        {
            get
            {
                if (Items_Active != null && Items_Active.Length > 0)
                    return Items_Active.Sum(c => c.Initial_Year_Depreciation);
                return 0;
            }
        }
        #endregion

        public double Total_Year1_Balance_Value
        {
            get
            {
                if (Items_Active != null && Items_Active.Length > 0)
                    return Items_Active.Sum(c => c.Year1_Balance_Value);
                return 0;
            }
        }
        public double Total_Year1_Depreciation
        {
            get
            {
                if (Items_Active != null && Items_Active.Length > 0)
                    return Items_Active.Sum(c => c.Year1_Depreciation);
                return 0;
            }
        }

        public double Total_Year2_Balance_Value
        {
            get
            {
                if (Items_Active != null && Items_Active.Length > 0)
                    return Items_Active.Sum(c => c.Year2_Balance_Value);
                return 0;
            }
        }
        public double Total_Year2_Depreciation
        {
            get
            {
                if (Items_Active != null && Items_Active.Length > 0)
                    return Items_Active.Sum(c => c.Year2_Depreciation);
                return 0;
            }
        }

        public double Total_Year3_Balance_Value
        {
            get
            {
                if (Items_Active != null && Items_Active.Length > 0)
                    return Items_Active.Sum(c => c.Year3_Balance_Value);
                return 0;
            }
        }
        public double Total_Year3_Depreciation
        {
            get
            {
                if (Items_Active != null && Items_Active.Length > 0)
                    return Items_Active.Sum(c => c.Year3_Depreciation);
                return 0;
            }
        }


        public double Total_Year4_Balance_Value
        {
            get
            {
                if (Items_Active != null && Items_Active.Length > 0)
                    return Items_Active.Sum(c => c.Year4_Balance_Value);
                return 0;
            }
        }
        public double Total_Year4_Depreciation
        {
            get
            {
                if (Items_Active != null && Items_Active.Length > 0)
                    return Items_Active.Sum(c => c.Year4_Depreciation);
                return 0;
            }
        }

        public double Total_Year5_Balance_Value
        {
            get
            {
                if (Items_Active != null && Items_Active.Length > 0)
                    return Items_Active.Sum(c => c.Year5_Balance_Value);
                return 0;
            }
        }
        public double Total_Year5_Depreciation
        {
            get
            {
                if (Items_Active != null && Items_Active.Length > 0)
                    return Items_Active.Sum(c => c.Year5_Depreciation);
                return 0;
            }
        }

        public double Total_Total_Balance_Value
        {
            get
            {
                if (Items_Active != null && Items_Active.Length > 0)
                    return Items_Active.Sum(c => c.Total_Balance_Value);
                return 0;
            }
        }
        public double Total_Total_Depreciation
        {
            get
            {
                if (Items_Active != null && Items_Active.Length > 0)
                    return Items_Active.Sum(c => c.Total_Depreciation);
                return 0;
            }
        }


        #endregion
    }
}