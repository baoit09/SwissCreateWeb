using SwissCreateWeb.Models.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SwissCreateWeb.Data
{
    public class Step_BalanceAndOthers_LIQUIDITYPLAN : INotifyPropertyChanged
    {
        public Step_BalanceAndOthers_LIQUIDITYPLAN()
        {
            if (Items == null)
                Items = new List<Step_BalanceAndOthers_LIQUIDITYPLAN_Item>();
        }
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        public string CompanyName { get { return ProjectData.Intance.CompanyName; } }
        #region UI
        #region Step_BalanceAndOthers_LIQUIDITYPLAN_Header
        
        string _Step_BalanceAndOthers_LIQUIDITYPLAN_Header = string.Empty;
        public string Step_BalanceAndOthers_LIQUIDITYPLAN_Header_4Report
        {
            get
            {
                if (Report_Config_Finance.IsConvertHeaderToUpper == true)
                    return Step_BalanceAndOthers_LIQUIDITYPLAN_Header.ToUpper();
                return Step_BalanceAndOthers_LIQUIDITYPLAN_Header;
            }
        }
        public string Step_BalanceAndOthers_LIQUIDITYPLAN_Header
        {
            get
            {
                if (string.IsNullOrEmpty(_Step_BalanceAndOthers_LIQUIDITYPLAN_Header))
                {
                    _Step_BalanceAndOthers_LIQUIDITYPLAN_Header = "Liquidity Plan";
                }
                return _Step_BalanceAndOthers_LIQUIDITYPLAN_Header;
            }
            set
            {
                if (_Step_BalanceAndOthers_LIQUIDITYPLAN_Header != value)
                {
                    _Step_BalanceAndOthers_LIQUIDITYPLAN_Header = value;
                    SendPropertyChanged("Step_BalanceAndOthers_LIQUIDITYPLAN_Header");
                }
            }
        }
        #endregion

        #region FROM_OPERATIONS
        #region UIText_CASH_FLOW_FROM_OPERATIONS
        
        string _UIText_CASH_FLOW_FROM_OPERATIONS = string.Empty;
        public string UIText_CASH_FLOW_FROM_OPERATIONS
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CASH_FLOW_FROM_OPERATIONS))
                {
                    _UIText_CASH_FLOW_FROM_OPERATIONS = "CASH FLOW FROM OPERATIONS";
                }
                return _UIText_CASH_FLOW_FROM_OPERATIONS;
            }
            set
            {
                if (_UIText_CASH_FLOW_FROM_OPERATIONS != value)
                {
                    _UIText_CASH_FLOW_FROM_OPERATIONS = value;
                    SendPropertyChanged("UIText_CASH_FLOW_FROM_OPERATIONS");
                }
            }
        }
        #endregion

        #region UIText_Total_CASH_FLOW_FROM_OPERATIONS
        
        string _UIText_Total_CASH_FLOW_FROM_OPERATIONS = string.Empty;
        public string UIText_Total_CASH_FLOW_FROM_OPERATIONS
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_CASH_FLOW_FROM_OPERATIONS))
                {
                    _UIText_Total_CASH_FLOW_FROM_OPERATIONS = "NET CASH FLOW FROM OPERATIONS";
                }
                return _UIText_Total_CASH_FLOW_FROM_OPERATIONS;
            }
            set
            {
                if (_UIText_Total_CASH_FLOW_FROM_OPERATIONS != value)
                {
                    _UIText_Total_CASH_FLOW_FROM_OPERATIONS = value;
                    SendPropertyChanged("UIText_Total_CASH_FLOW_FROM_OPERATIONS");
                }
            }
        }
        #endregion

        #region UIText_CASH_INFLOW_FROM_OPERATIONS
        
        string _UIText_CASH_INFLOW_FROM_OPERATIONS = string.Empty;
        public string UIText_CASH_INFLOW_FROM_OPERATIONS
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CASH_INFLOW_FROM_OPERATIONS))
                {
                    _UIText_CASH_INFLOW_FROM_OPERATIONS = "Cash inflow from operations";
                }
                return _UIText_CASH_INFLOW_FROM_OPERATIONS;
            }
            set
            {
                if (_UIText_CASH_INFLOW_FROM_OPERATIONS != value)
                {
                    _UIText_CASH_INFLOW_FROM_OPERATIONS = value;
                    SendPropertyChanged("UIText_CASH_INFLOW_FROM_OPERATIONS");
                }
            }
        }
        #endregion

        #region UIText_Total_CASH_INFLOW_FROM_OPERATIONS
        
        string _UIText_Total_CASH_INFLOW_FROM_OPERATIONS = string.Empty;
        public string UIText_Total_CASH_INFLOW_FROM_OPERATIONS
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_CASH_INFLOW_FROM_OPERATIONS))
                {
                    _UIText_Total_CASH_INFLOW_FROM_OPERATIONS = "Total Cash inflow from operations";
                }
                return _UIText_Total_CASH_INFLOW_FROM_OPERATIONS;
            }
            set
            {
                if (_UIText_Total_CASH_INFLOW_FROM_OPERATIONS != value)
                {
                    _UIText_Total_CASH_INFLOW_FROM_OPERATIONS = value;
                    SendPropertyChanged("UIText_Total_CASH_INFLOW_FROM_OPERATIONS");
                }
            }
        }
        #endregion

        #region UIText_CASH_OUTFLOW_FROM_OPERATIONS
        
        string _UIText_CASH_OUTFLOW_FROM_OPERATIONS = string.Empty;
        public string UIText_CASH_OUTFLOW_FROM_OPERATIONS
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CASH_OUTFLOW_FROM_OPERATIONS))
                {
                    _UIText_CASH_OUTFLOW_FROM_OPERATIONS = "Cash outflow from operations";
                }
                return _UIText_CASH_OUTFLOW_FROM_OPERATIONS;
            }
            set
            {
                if (_UIText_CASH_OUTFLOW_FROM_OPERATIONS != value)
                {
                    _UIText_CASH_OUTFLOW_FROM_OPERATIONS = value;
                    SendPropertyChanged("UIText_CASH_OUTFLOW_FROM_OPERATIONS");
                }
            }
        }
        #endregion

        #region UIText_Total_CASH_OUTFLOW_FROM_OPERATIONS
        
        string _UIText_Total_CASH_OUTFLOW_FROM_OPERATIONS = string.Empty;
        public string UIText_Total_CASH_OUTFLOW_FROM_OPERATIONS
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_CASH_OUTFLOW_FROM_OPERATIONS))
                {
                    _UIText_Total_CASH_OUTFLOW_FROM_OPERATIONS = "Total Cash outflow from operations";
                }
                return _UIText_Total_CASH_OUTFLOW_FROM_OPERATIONS;
            }
            set
            {
                if (_UIText_Total_CASH_OUTFLOW_FROM_OPERATIONS != value)
                {
                    _UIText_Total_CASH_OUTFLOW_FROM_OPERATIONS = value;
                    SendPropertyChanged("UIText_Total_CASH_OUTFLOW_FROM_OPERATIONS");
                }
            }
        }
        #endregion
        #endregion

        #region FROM_INVESTING_ACTIVITIES
        #region UIText_CASH_FLOW_FROM_INVESTING_ACTIVITIES
        
        string _UIText_CASH_FLOW_FROM_INVESTING_ACTIVITIES = string.Empty;
        public string UIText_CASH_FLOW_FROM_INVESTING_ACTIVITIES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CASH_FLOW_FROM_INVESTING_ACTIVITIES))
                {
                    _UIText_CASH_FLOW_FROM_INVESTING_ACTIVITIES = "Cash flow from investing activities";
                }
                return _UIText_CASH_FLOW_FROM_INVESTING_ACTIVITIES;
            }
            set
            {
                if (_UIText_CASH_FLOW_FROM_INVESTING_ACTIVITIES != value)
                {
                    _UIText_CASH_FLOW_FROM_INVESTING_ACTIVITIES = value;
                    SendPropertyChanged("UIText_CASH_FLOW_FROM_INVESTING_ACTIVITIES");
                }
            }
        }
        #endregion

        #region UIText_Total_CASH_FLOW_FROM_INVESTING_ACTIVITIES
        
        string _UIText_Total_CASH_FLOW_FROM_INVESTING_ACTIVITIES = string.Empty;
        public string UIText_Total_CASH_FLOW_FROM_INVESTING_ACTIVITIES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_CASH_FLOW_FROM_INVESTING_ACTIVITIES))
                {
                    _UIText_Total_CASH_FLOW_FROM_INVESTING_ACTIVITIES = "Total Cash flow from investing activities";
                }
                return _UIText_Total_CASH_FLOW_FROM_INVESTING_ACTIVITIES;
            }
            set
            {
                if (_UIText_Total_CASH_FLOW_FROM_INVESTING_ACTIVITIES != value)
                {
                    _UIText_Total_CASH_FLOW_FROM_INVESTING_ACTIVITIES = value;
                    SendPropertyChanged("UIText_Total_CASH_FLOW_FROM_INVESTING_ACTIVITIES");
                }
            }
        }
        #endregion

        #region UIText_CASH_INFLOW_FROM_INVESTING_ACTIVITIES
        
        string _UIText_CASH_INFLOW_FROM_INVESTING_ACTIVITIES = string.Empty;
        public string UIText_CASH_INFLOW_FROM_INVESTING_ACTIVITIES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CASH_INFLOW_FROM_INVESTING_ACTIVITIES))
                {
                    _UIText_CASH_INFLOW_FROM_INVESTING_ACTIVITIES = "Cash inflow from investing activities";
                }
                return _UIText_CASH_INFLOW_FROM_INVESTING_ACTIVITIES;
            }
            set
            {
                if (_UIText_CASH_INFLOW_FROM_INVESTING_ACTIVITIES != value)
                {
                    _UIText_CASH_INFLOW_FROM_INVESTING_ACTIVITIES = value;
                    SendPropertyChanged("UIText_CASH_INFLOW_FROM_INVESTING_ACTIVITIES");
                }
            }
        }
        #endregion

        #region UIText_Total_CASH_INFLOW_FROM_INVESTING_ACTIVITIES
        
        string _UIText_Total_CASH_INFLOW_FROM_INVESTING_ACTIVITIES = string.Empty;
        public string UIText_Total_CASH_INFLOW_FROM_INVESTING_ACTIVITIES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_CASH_INFLOW_FROM_INVESTING_ACTIVITIES))
                {
                    _UIText_Total_CASH_INFLOW_FROM_INVESTING_ACTIVITIES = "Total Cash inflow from investing activities";
                }
                return _UIText_Total_CASH_INFLOW_FROM_INVESTING_ACTIVITIES;
            }
            set
            {
                if (_UIText_Total_CASH_INFLOW_FROM_INVESTING_ACTIVITIES != value)
                {
                    _UIText_Total_CASH_INFLOW_FROM_INVESTING_ACTIVITIES = value;
                    SendPropertyChanged("UIText_Total_CASH_INFLOW_FROM_INVESTING_ACTIVITIES");
                }
            }
        }
        #endregion

        #region UIText_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES
        
        string _UIText_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES = string.Empty;
        public string UIText_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES))
                {
                    _UIText_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES = "Cash outflow from investing activities";
                }
                return _UIText_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES;
            }
            set
            {
                if (_UIText_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES != value)
                {
                    _UIText_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES = value;
                    SendPropertyChanged("UIText_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES");
                }
            }
        }
        #endregion

        #region UIText_Total_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES
        
        string _UIText_Total_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES = string.Empty;
        public string UIText_Total_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES))
                {
                    _UIText_Total_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES = "Total cash inflow from investing activities";
                }
                return _UIText_Total_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES;
            }
            set
            {
                if (_UIText_Total_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES != value)
                {
                    _UIText_Total_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES = value;
                    SendPropertyChanged("UIText_Total_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES");
                }
            }
        }
        #endregion
        #endregion

        #region FROM_FINANCING_ACTIVITIES
        #region UIText_CASH_FLOW_FROM_FINANCING_ACTIVITIES
        
        string _UIText_CASH_FLOW_FROM_FINANCING_ACTIVITIES = string.Empty;
        public string UIText_CASH_FLOW_FROM_FINANCING_ACTIVITIES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CASH_FLOW_FROM_FINANCING_ACTIVITIES))
                {
                    _UIText_CASH_FLOW_FROM_FINANCING_ACTIVITIES = "Cash flow from financing activities";
                }
                return _UIText_CASH_FLOW_FROM_FINANCING_ACTIVITIES;
            }
            set
            {
                if (_UIText_CASH_FLOW_FROM_FINANCING_ACTIVITIES != value)
                {
                    _UIText_CASH_FLOW_FROM_FINANCING_ACTIVITIES = value;
                    SendPropertyChanged("UIText_CASH_FLOW_FROM_FINANCING_ACTIVITIES");
                }
            }
        }
        #endregion

        #region UIText_Total_CASH_FLOW_FROM_FINANCING_ACTIVITIES
        
        string _UIText_Total_CASH_FLOW_FROM_FINANCING_ACTIVITIES = string.Empty;
        public string UIText_Total_CASH_FLOW_FROM_FINANCING_ACTIVITIES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_CASH_FLOW_FROM_FINANCING_ACTIVITIES))
                {
                    _UIText_Total_CASH_FLOW_FROM_FINANCING_ACTIVITIES = "Total Cash inflow from financing activities";
                }
                return _UIText_Total_CASH_FLOW_FROM_FINANCING_ACTIVITIES;
            }
            set
            {
                if (_UIText_Total_CASH_FLOW_FROM_FINANCING_ACTIVITIES != value)
                {
                    _UIText_Total_CASH_FLOW_FROM_FINANCING_ACTIVITIES = value;
                    SendPropertyChanged("UIText_Total_CASH_FLOW_FROM_FINANCING_ACTIVITIES");
                }
            }
        }
        #endregion

        #region UIText_CASH_INFLOW_FROM_FINANCING_ACTIVITIES
        
        string _UIText_CASH_INFLOW_FROM_FINANCING_ACTIVITIES = string.Empty;
        public string UIText_CASH_INFLOW_FROM_FINANCING_ACTIVITIES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CASH_INFLOW_FROM_FINANCING_ACTIVITIES))
                {
                    _UIText_CASH_INFLOW_FROM_FINANCING_ACTIVITIES = "Cash inflow from financing activities";
                }
                return _UIText_CASH_INFLOW_FROM_FINANCING_ACTIVITIES;
            }
            set
            {
                if (_UIText_CASH_INFLOW_FROM_FINANCING_ACTIVITIES != value)
                {
                    _UIText_CASH_INFLOW_FROM_FINANCING_ACTIVITIES = value;
                    SendPropertyChanged("UIText_CASH_INFLOW_FROM_FINANCING_ACTIVITIES");
                }
            }
        }
        #endregion

        #region UIText_Total_CASH_INFLOW_FROM_FINANCING_ACTIVITIES
        
        string _UIText_Total_CASH_INFLOW_FROM_FINANCING_ACTIVITIES = string.Empty;
        public string UIText_Total_CASH_INFLOW_FROM_FINANCING_ACTIVITIES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_CASH_INFLOW_FROM_FINANCING_ACTIVITIES))
                {
                    _UIText_Total_CASH_INFLOW_FROM_FINANCING_ACTIVITIES = "Total Cash inflow from financing activities";
                }
                return _UIText_Total_CASH_INFLOW_FROM_FINANCING_ACTIVITIES;
            }
            set
            {
                if (_UIText_Total_CASH_INFLOW_FROM_FINANCING_ACTIVITIES != value)
                {
                    _UIText_Total_CASH_INFLOW_FROM_FINANCING_ACTIVITIES = value;
                    SendPropertyChanged("UIText_Total_CASH_INFLOW_FROM_FINANCING_ACTIVITIES");
                }
            }
        }
        #endregion

        #region UIText_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES
        
        string _UIText_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES = string.Empty;
        public string UIText_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES))
                {
                    _UIText_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES = "Cash outflow from financing activities";
                }
                return _UIText_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES;
            }
            set
            {
                if (_UIText_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES != value)
                {
                    _UIText_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES = value;
                    SendPropertyChanged("UIText_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES");
                }
            }
        }
        #endregion

        #region UIText_Total_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES
        
        string _UIText_Total_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES = string.Empty;
        public string UIText_Total_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES))
                {
                    _UIText_Total_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES = "Total cash inflow from financing activities";
                }
                return _UIText_Total_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES;
            }
            set
            {
                if (_UIText_Total_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES != value)
                {
                    _UIText_Total_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES = value;
                    SendPropertyChanged("UIText_Total_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES");
                }
            }
        }
        #endregion
        #endregion

        #region UIText_Total_CASH_IN_THE_BEGINNING_OF_THE_PERIOD
        
        string _UIText_Total_CASH_IN_THE_BEGINNING_OF_THE_PERIOD = string.Empty;
        public string UIText_Total_CASH_IN_THE_BEGINNING_OF_THE_PERIOD
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_CASH_IN_THE_BEGINNING_OF_THE_PERIOD))
                {
                    _UIText_Total_CASH_IN_THE_BEGINNING_OF_THE_PERIOD = "Cash in the beginning of the period";
                }
                return _UIText_Total_CASH_IN_THE_BEGINNING_OF_THE_PERIOD;
            }
            set
            {
                if (_UIText_Total_CASH_IN_THE_BEGINNING_OF_THE_PERIOD != value)
                {
                    _UIText_Total_CASH_IN_THE_BEGINNING_OF_THE_PERIOD = value;
                    SendPropertyChanged("UIText_Total_CASH_IN_THE_BEGINNING_OF_THE_PERIOD");
                }
            }
        }
        #endregion

        #region UIText_Total_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE
        
        string _UIText_Total_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE = string.Empty;
        public string UIText_Total_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE))
                {
                    _UIText_Total_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE = "Cash abundance (positive) / need for cash (negative)";
                }
                return _UIText_Total_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE;
            }
            set
            {
                if (_UIText_Total_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE != value)
                {
                    _UIText_Total_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE = value;
                    SendPropertyChanged("UIText_Total_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE");
                }
            }
        }
        #endregion

        #region UIText_Total_CASH_AT_THE_END_OF_THE_PERIOD
        
        string _UIText_Total_CASH_AT_THE_END_OF_THE_PERIOD = string.Empty;
        public string UIText_Total_CASH_AT_THE_END_OF_THE_PERIOD
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_CASH_AT_THE_END_OF_THE_PERIOD))
                {
                    _UIText_Total_CASH_AT_THE_END_OF_THE_PERIOD = "Cash at the end of the period";
                }
                return _UIText_Total_CASH_AT_THE_END_OF_THE_PERIOD;
            }
            set
            {
                if (_UIText_Total_CASH_AT_THE_END_OF_THE_PERIOD != value)
                {
                    _UIText_Total_CASH_AT_THE_END_OF_THE_PERIOD = value;
                    SendPropertyChanged("UIText_Total_CASH_AT_THE_END_OF_THE_PERIOD");
                }
            }
        }
        #endregion

        #region UIText_Value
        
        string _UIText_Value = string.Empty;
        public string UIText_Value
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Value))
                {
                    _UIText_Value = "Value";
                }
                return _UIText_Value;
            }
            set
            {
                if (_UIText_Value != value)
                {
                    _UIText_Value = value;
                    SendPropertyChanged("UIText_Value");
                }
            }
        }
        #endregion

        #region UIText_Year1
        
        string _UIText_Year1 = string.Empty;
        public string UIText_Year1
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Year1))
                {
                    _UIText_Year1 = "Year 1";
                }
                return _UIText_Year1;
            }
            set
            {
                if (_UIText_Year1 != value)
                {
                    _UIText_Year1 = value;
                    SendPropertyChanged("UIText_Year1");
                }
            }
        }
        #endregion

        #region UIText_Year2
        
        string _UIText_Year2 = string.Empty;
        public string UIText_Year2
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Year2))
                {
                    _UIText_Year2 = "Year 2";
                }
                return _UIText_Year2;
            }
            set
            {
                if (_UIText_Year2 != value)
                {
                    _UIText_Year2 = value;
                    SendPropertyChanged("UIText_Year2");
                }
            }
        }
        #endregion

        #region UIText_Year3
        
        string _UIText_Year3 = string.Empty;
        public string UIText_Year3
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Year3))
                {
                    _UIText_Year3 = "Year 3";
                }
                return _UIText_Year3;
            }
            set
            {
                if (_UIText_Year3 != value)
                {
                    _UIText_Year3 = value;
                    SendPropertyChanged("UIText_Year3");
                }
            }
        }
        #endregion

        #region UIText_Year4
        
        string _UIText_Year4 = string.Empty;
        public string UIText_Year4
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Year4))
                {
                    _UIText_Year4 = "Year 4";
                }
                return _UIText_Year4;
            }
            set
            {
                if (_UIText_Year4 != value)
                {
                    _UIText_Year4 = value;
                    SendPropertyChanged("UIText_Year4");
                }
            }
        }
        #endregion

        #region UIText_Year5
        
        string _UIText_Year5 = string.Empty;
        public string UIText_Year5
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Year5))
                {
                    _UIText_Year5 = "Year 5";
                }
                return _UIText_Year5;
            }
            set
            {
                if (_UIText_Year5 != value)
                {
                    _UIText_Year5 = value;
                    SendPropertyChanged("UIText_Year5");
                }
            }
        }
        #endregion
        #endregion

        #region Data
        public void RefreshData()
        {
            if (Items == null)
                Items = new List<Step_BalanceAndOthers_LIQUIDITYPLAN_Item>();
            var _items = Items;
            foreach (var item in _items)
            {
                if (item != null)
                {
                    if (item.Parent != this)
                        item.Parent = this;
                }
            }
        }
        
        public List<Step_BalanceAndOthers_LIQUIDITYPLAN_Item> Items { get; set; }
        public Step_BalanceAndOthers_LIQUIDITYPLAN_Item[] Items_GROUP_CASH_INFLOW_FROM_OPERATIONS
        {
            get
            {
                return Items == null ? new Step_BalanceAndOthers_LIQUIDITYPLAN_Item[0] : Items.Where(c => c.GroupName == GROUP_CASH_INFLOW_FROM_OPERATIONS).ToArray();
            }
            set { }
        }
        public Step_BalanceAndOthers_LIQUIDITYPLAN_Item[] Items_GROUP_CASH_OUTFLOW_FROM_OPERATIONS
        {
            get
            {
                return Items == null ? new Step_BalanceAndOthers_LIQUIDITYPLAN_Item[0] : Items.Where(c => c.GroupName == GROUP_CASH_OUTFLOW_FROM_OPERATIONS).ToArray();
            }
            set { }
        }
        public Step_BalanceAndOthers_LIQUIDITYPLAN_Item[] Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES
        {
            get
            {
                return Items == null ? new Step_BalanceAndOthers_LIQUIDITYPLAN_Item[0] : Items.Where(c => c.GroupName == GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES).ToArray();
            }
            set { }
        }
        public Step_BalanceAndOthers_LIQUIDITYPLAN_Item[] Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES
        {
            get
            {
                return Items == null ? new Step_BalanceAndOthers_LIQUIDITYPLAN_Item[0] : Items.Where(c => c.GroupName == GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES).ToArray();
            }
            set { }
        }
        public Step_BalanceAndOthers_LIQUIDITYPLAN_Item[] Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES
        {
            get
            {
                return Items == null ? new Step_BalanceAndOthers_LIQUIDITYPLAN_Item[0] : Items.Where(c => c.GroupName == GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES).ToArray();
            }
            set { }
        }
        public Step_BalanceAndOthers_LIQUIDITYPLAN_Item[] Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES
        {
            get
            {
                return Items == null ? new Step_BalanceAndOthers_LIQUIDITYPLAN_Item[0] : Items.Where(c => c.GroupName == GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES).ToArray();
            }
            set { }
        }

        #region OPERATIONS_Total
        #region GROUP_CASH_INFLOW_FROM_OPERATIONS_Total
        public double GROUP_CASH_INFLOW_FROM_OPERATIONS_Total_Year1
        {
            get { return Items_GROUP_CASH_INFLOW_FROM_OPERATIONS.Sum(c => c.Year1); }
        }
        public double GROUP_CASH_INFLOW_FROM_OPERATIONS_Total_Year2
        {
            get { return Items_GROUP_CASH_INFLOW_FROM_OPERATIONS.Sum(c => c.Year2); }
        }
        public double GROUP_CASH_INFLOW_FROM_OPERATIONS_Total_Year3
        {
            get { return Items_GROUP_CASH_INFLOW_FROM_OPERATIONS.Sum(c => c.Year3); }
        }
        public double GROUP_CASH_INFLOW_FROM_OPERATIONS_Total_Year4
        {
            get { return Items_GROUP_CASH_INFLOW_FROM_OPERATIONS.Sum(c => c.Year4); }
        }
        public double GROUP_CASH_INFLOW_FROM_OPERATIONS_Total_Year5
        {
            get { return Items_GROUP_CASH_INFLOW_FROM_OPERATIONS.Sum(c => c.Year5); }
        }
        #endregion

        #region GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total
        public double GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total_Year1
        {
            get { return Items_GROUP_CASH_OUTFLOW_FROM_OPERATIONS.Sum(c => c.Year1); }
        }
        public double GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total_Year2
        {
            get { return Items_GROUP_CASH_OUTFLOW_FROM_OPERATIONS.Sum(c => c.Year2); }
        }
        public double GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total_Year3
        {
            get { return Items_GROUP_CASH_OUTFLOW_FROM_OPERATIONS.Sum(c => c.Year3); }
        }
        public double GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total_Year4
        {
            get { return Items_GROUP_CASH_OUTFLOW_FROM_OPERATIONS.Sum(c => c.Year4); }
        }
        public double GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total_Year5
        {
            get { return Items_GROUP_CASH_OUTFLOW_FROM_OPERATIONS.Sum(c => c.Year5); }
        }
        #endregion

        #region GROUP_CASH_FLOW_FROM_OPERATIONS_Total
        public double GROUP_CASH_FLOW_FROM_OPERATIONS_Total_Year1
        {
            get { return GROUP_CASH_INFLOW_FROM_OPERATIONS_Total_Year1 - GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total_Year1; }
        }
        public double GROUP_CASH_FLOW_FROM_OPERATIONS_Total_Year2
        {
            get { return GROUP_CASH_INFLOW_FROM_OPERATIONS_Total_Year2 - GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total_Year2; }
        }
        public double GROUP_CASH_FLOW_FROM_OPERATIONS_Total_Year3
        {
            get { return GROUP_CASH_INFLOW_FROM_OPERATIONS_Total_Year3 - GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total_Year3; }
        }
        public double GROUP_CASH_FLOW_FROM_OPERATIONS_Total_Year4
        {
            get { return GROUP_CASH_INFLOW_FROM_OPERATIONS_Total_Year4 - GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total_Year4; }
        }
        public double GROUP_CASH_FLOW_FROM_OPERATIONS_Total_Year5
        {
            get { return GROUP_CASH_INFLOW_FROM_OPERATIONS_Total_Year5 - GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total_Year5; }
        }
        #endregion
        #endregion

        #region INVESTING ACTIVITIES_Total
        #region GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES_Total
        public double GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES_Total_Year1
        {
            get { return Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Sum(c => c.Year1); }
        }
        public double GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES_Total_Year2
        {
            get { return Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Sum(c => c.Year2); }
        }
        public double GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES_Total_Year3
        {
            get { return Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Sum(c => c.Year3); }
        }
        public double GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES_Total_Year4
        {
            get { return Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Sum(c => c.Year4); }
        }
        public double GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES_Total_Year5
        {
            get { return Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Sum(c => c.Year5); }
        }
        #endregion

        #region GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES_Total
        public double GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES_Total_Year1
        {
            get { return Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES.Sum(c => c.Year1); }
        }
        public double GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES_Total_Year2
        {
            get { return Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES.Sum(c => c.Year2); }
        }
        public double GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES_Total_Year3
        {
            get { return Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES.Sum(c => c.Year3); }
        }
        public double GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES_Total_Year4
        {
            get { return Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES.Sum(c => c.Year4); }
        }
        public double GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES_Total_Year5
        {
            get { return Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES.Sum(c => c.Year5); }
        }
        #endregion

        #region GROUP_CASH_FLOW_FROM_INVESTING_ACTIVITIES_Total
        public double GROUP_CASH_FLOW_FROM_INVESTING_ACTIVITIES_Total_Year1
        {
            get { return GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES_Total_Year1 - GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES_Total_Year1; }
        }
        public double GROUP_CASH_FLOW_FROM_INVESTING_ACTIVITIES_Total_Year2
        {
            get { return GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES_Total_Year2 - GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES_Total_Year2; }
        }
        public double GROUP_CASH_FLOW_FROM_INVESTING_ACTIVITIES_Total_Year3
        {
            get { return GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES_Total_Year3 - GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES_Total_Year3; }
        }
        public double GROUP_CASH_FLOW_FROM_INVESTING_ACTIVITIES_Total_Year4
        {
            get { return GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES_Total_Year4 - GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES_Total_Year4; }
        }
        public double GROUP_CASH_FLOW_FROM_INVESTING_ACTIVITIES_Total_Year5
        {
            get { return GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES_Total_Year5 - GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES_Total_Year5; }
        }
        #endregion
        #endregion

        #region FINANCING ACTIVITIES_Total
        #region GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES_Total
        public double GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES_Total_Year1
        {
            get { return Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Sum(c => c.Year1); }
        }
        public double GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES_Total_Year2
        {
            get { return Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Sum(c => c.Year2); }
        }
        public double GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES_Total_Year3
        {
            get { return Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Sum(c => c.Year3); }
        }
        public double GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES_Total_Year4
        {
            get { return Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Sum(c => c.Year4); }
        }
        public double GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES_Total_Year5
        {
            get { return Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Sum(c => c.Year5); }
        }
        #endregion

        #region GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES_Total
        public double GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES_Total_Year1
        {
            get { return Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Sum(c => c.Year1); }
        }
        public double GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES_Total_Year2
        {
            get { return Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Sum(c => c.Year2); }
        }
        public double GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES_Total_Year3
        {
            get { return Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Sum(c => c.Year3); }
        }
        public double GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES_Total_Year4
        {
            get { return Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Sum(c => c.Year4); }
        }
        public double GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES_Total_Year5
        {
            get { return Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Sum(c => c.Year5); }
        }
        #endregion

        #region GROUP_CASH_FLOW_FROM_FINANCING_ACTIVITIES_Total
        public double GROUP_CASH_FLOW_FROM_FINANCING_ACTIVITIES_Total_Year1
        {
            get { return GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES_Total_Year1 - GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES_Total_Year1; }
        }
        public double GROUP_CASH_FLOW_FROM_FINANCING_ACTIVITIES_Total_Year2
        {
            get { return GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES_Total_Year2 - GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES_Total_Year2; }
        }
        public double GROUP_CASH_FLOW_FROM_FINANCING_ACTIVITIES_Total_Year3
        {
            get { return GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES_Total_Year3 - GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES_Total_Year3; }
        }
        public double GROUP_CASH_FLOW_FROM_FINANCING_ACTIVITIES_Total_Year4
        {
            get { return GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES_Total_Year4 - GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES_Total_Year4; }
        }
        public double GROUP_CASH_FLOW_FROM_FINANCING_ACTIVITIES_Total_Year5
        {
            get { return GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES_Total_Year5 - GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES_Total_Year5; }
        }
        #endregion
        #endregion

        #region CASH_IN_THE_BEGINNING_OF_THE_PERIOD
        
        double _GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year1;
        public double GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year1
        {
            get { return _GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year1; }
            set
            {
                if (_GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year1 != value)
                {
                    _GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year1 = value;
                    SendPropertyChanged("GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year1");
                    SendPropertyChanged_Total();
                }
            }
        }
        public double GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year2
        {
            get { return GROUP_CASH_AT_THE_END_OF_THE_PERIOD_Total_Year1; }
        }
        public double GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year3
        {
            get { return GROUP_CASH_AT_THE_END_OF_THE_PERIOD_Total_Year2; }
        }
        public double GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year4
        {
            get { return GROUP_CASH_AT_THE_END_OF_THE_PERIOD_Total_Year3; }
        }
        public double GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year5
        {
            get { return GROUP_CASH_AT_THE_END_OF_THE_PERIOD_Total_Year4; }
        }
        #endregion

        #region CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE
        public double GROUP_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE_Total_Year1
        {
            get { return GROUP_CASH_FLOW_FROM_OPERATIONS_Total_Year1 + GROUP_CASH_FLOW_FROM_INVESTING_ACTIVITIES_Total_Year1 + GROUP_CASH_FLOW_FROM_FINANCING_ACTIVITIES_Total_Year1; }
        }
        public double GROUP_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE_Total_Year2
        {
            get { return GROUP_CASH_FLOW_FROM_OPERATIONS_Total_Year2 + GROUP_CASH_FLOW_FROM_INVESTING_ACTIVITIES_Total_Year2 + GROUP_CASH_FLOW_FROM_FINANCING_ACTIVITIES_Total_Year2; }
        }
        public double GROUP_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE_Total_Year3
        {
            get { return GROUP_CASH_FLOW_FROM_OPERATIONS_Total_Year3 + GROUP_CASH_FLOW_FROM_INVESTING_ACTIVITIES_Total_Year3 + GROUP_CASH_FLOW_FROM_FINANCING_ACTIVITIES_Total_Year3; }
        }
        public double GROUP_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE_Total_Year4
        {
            get { return GROUP_CASH_FLOW_FROM_OPERATIONS_Total_Year4 + GROUP_CASH_FLOW_FROM_INVESTING_ACTIVITIES_Total_Year4 + GROUP_CASH_FLOW_FROM_FINANCING_ACTIVITIES_Total_Year4; }
        }
        public double GROUP_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE_Total_Year5
        {
            get { return GROUP_CASH_FLOW_FROM_OPERATIONS_Total_Year5 + GROUP_CASH_FLOW_FROM_INVESTING_ACTIVITIES_Total_Year5 + GROUP_CASH_FLOW_FROM_FINANCING_ACTIVITIES_Total_Year5; }
        }
        #endregion

        #region CASH_AT_THE_END_OF_THE_PERIOD
        public double GROUP_CASH_AT_THE_END_OF_THE_PERIOD_Total_Year1
        {
            get
            {
                return GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year1 + GROUP_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE_Total_Year1;
            }
        }
        public double GROUP_CASH_AT_THE_END_OF_THE_PERIOD_Total_Year2
        {
            get
            {
                return GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year2 + GROUP_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE_Total_Year2;
            }
        }
        public double GROUP_CASH_AT_THE_END_OF_THE_PERIOD_Total_Year3
        {
            get
            {
                return GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year3 + GROUP_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE_Total_Year3;
            }
        }
        public double GROUP_CASH_AT_THE_END_OF_THE_PERIOD_Total_Year4
        {
            get
            {
                return GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year4 + GROUP_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE_Total_Year4;
            }
        }
        public double GROUP_CASH_AT_THE_END_OF_THE_PERIOD_Total_Year5
        {
            get
            {
                return GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year5 + GROUP_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE_Total_Year5;
            }
        }
        #endregion

        public string GROUP_CASH_INFLOW_FROM_OPERATIONS
        {
            get { return "Cash inflow from operations"; }
        }
        public string GROUP_CASH_OUTFLOW_FROM_OPERATIONS
        {
            get { return "Cash outflow from operations"; }
        }
        public string GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES
        {
            get { return "Cash inflow from investing activities"; }
        }
        public string GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES
        {
            get { return "Cash outflow from investing activities "; }
        }
        public string GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES
        {
            get { return "Cash inflow from financing activities"; }
        }
        public string GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES
        {
            get { return "Cash outflow from financing activities"; }
        }


        public void SendPropertyChanged_Total()
        {
            SendPropertyChanged("GROUP_CASH_INFLOW_FROM_OPERATIONS_Total_Year1");
            SendPropertyChanged("GROUP_CASH_INFLOW_FROM_OPERATIONS_Total_Year2");
            SendPropertyChanged("GROUP_CASH_INFLOW_FROM_OPERATIONS_Total_Year3");
            SendPropertyChanged("GROUP_CASH_INFLOW_FROM_OPERATIONS_Total_Year4");
            SendPropertyChanged("GROUP_CASH_INFLOW_FROM_OPERATIONS_Total_Year5");

            SendPropertyChanged("GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total_Year1");
            SendPropertyChanged("GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total_Year2");
            SendPropertyChanged("GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total_Year3");
            SendPropertyChanged("GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total_Year4");
            SendPropertyChanged("GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total_Year5");

            SendPropertyChanged("GROUP_CASH_FLOW_FROM_OPERATIONS_Total_Year1");
            SendPropertyChanged("GROUP_CASH_FLOW_FROM_OPERATIONS_Total_Year2");
            SendPropertyChanged("GROUP_CASH_FLOW_FROM_OPERATIONS_Total_Year3");
            SendPropertyChanged("GROUP_CASH_FLOW_FROM_OPERATIONS_Total_Year4");
            SendPropertyChanged("GROUP_CASH_FLOW_FROM_OPERATIONS_Total_Year5");


            SendPropertyChanged("GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES_Total_Year1");
            SendPropertyChanged("GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES_Total_Year2");
            SendPropertyChanged("GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES_Total_Year3");
            SendPropertyChanged("GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES_Total_Year4");
            SendPropertyChanged("GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES_Total_Year5");

            SendPropertyChanged("GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES_Total_Year1");
            SendPropertyChanged("GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES_Total_Year2");
            SendPropertyChanged("GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES_Total_Year3");
            SendPropertyChanged("GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES_Total_Year4");
            SendPropertyChanged("GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES_Total_Year5");

            SendPropertyChanged("GROUP_CASH_FLOW_FROM_INVESTING_ACTIVITIES_Total_Year1");
            SendPropertyChanged("GROUP_CASH_FLOW_FROM_INVESTING_ACTIVITIES_Total_Year2");
            SendPropertyChanged("GROUP_CASH_FLOW_FROM_INVESTING_ACTIVITIES_Total_Year3");
            SendPropertyChanged("GROUP_CASH_FLOW_FROM_INVESTING_ACTIVITIES_Total_Year4");
            SendPropertyChanged("GROUP_CASH_FLOW_FROM_INVESTING_ACTIVITIES_Total_Year5");


            SendPropertyChanged("GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES_Total_Year1");
            SendPropertyChanged("GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES_Total_Year2");
            SendPropertyChanged("GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES_Total_Year3");
            SendPropertyChanged("GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES_Total_Year4");
            SendPropertyChanged("GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES_Total_Year5");

            SendPropertyChanged("GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES_Total_Year1");
            SendPropertyChanged("GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES_Total_Year2");
            SendPropertyChanged("GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES_Total_Year3");
            SendPropertyChanged("GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES_Total_Year4");
            SendPropertyChanged("GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES_Total_Year5");

            SendPropertyChanged("GROUP_CASH_FLOW_FROM_FINANCING_ACTIVITIES_Total_Year1");
            SendPropertyChanged("GROUP_CASH_FLOW_FROM_FINANCING_ACTIVITIES_Total_Year2");
            SendPropertyChanged("GROUP_CASH_FLOW_FROM_FINANCING_ACTIVITIES_Total_Year3");
            SendPropertyChanged("GROUP_CASH_FLOW_FROM_FINANCING_ACTIVITIES_Total_Year4");
            SendPropertyChanged("GROUP_CASH_FLOW_FROM_FINANCING_ACTIVITIES_Total_Year5");

            SendPropertyChanged("GROUP_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE_Total_Year1");
            SendPropertyChanged("GROUP_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE_Total_Year2");
            SendPropertyChanged("GROUP_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE_Total_Year3");
            SendPropertyChanged("GROUP_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE_Total_Year4");
            SendPropertyChanged("GROUP_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE_Total_Year5");

            SendPropertyChanged("GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year1");
            SendPropertyChanged("GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year2");
            SendPropertyChanged("GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year3");
            SendPropertyChanged("GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year4");
            SendPropertyChanged("GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year5");

            SendPropertyChanged("GROUP_CASH_AT_THE_END_OF_THE_PERIOD_Total_Year1");
            SendPropertyChanged("GROUP_CASH_AT_THE_END_OF_THE_PERIOD_Total_Year2");
            SendPropertyChanged("GROUP_CASH_AT_THE_END_OF_THE_PERIOD_Total_Year3");
            SendPropertyChanged("GROUP_CASH_AT_THE_END_OF_THE_PERIOD_Total_Year4");
            SendPropertyChanged("GROUP_CASH_AT_THE_END_OF_THE_PERIOD_Total_Year5");
        }
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
        #endregion

        #region Add
        public void AddNew(string group)
        {
            Step_BalanceAndOthers_LIQUIDITYPLAN_Item newItem = new Step_BalanceAndOthers_LIQUIDITYPLAN_Item(this)
            {
                GroupName = group,
            };
            if (Items == null)
                Items = new List<Step_BalanceAndOthers_LIQUIDITYPLAN_Item>();
            Items.Add(newItem);
        }
        public void AddNew(string group, string name)
        {
            Step_BalanceAndOthers_LIQUIDITYPLAN_Item newItem = new Step_BalanceAndOthers_LIQUIDITYPLAN_Item(this)
            {
                GroupName = group,
                Name = name
            };
            if (Items == null)
                Items = new List<Step_BalanceAndOthers_LIQUIDITYPLAN_Item>();
            Items.Add(newItem);
        }
        public void AddNew(string group, bool just1InGrp)
        {
            Step_BalanceAndOthers_LIQUIDITYPLAN_Item newItem = new Step_BalanceAndOthers_LIQUIDITYPLAN_Item(this)
            {
                GroupName = group,
                Name = just1InGrp == true ? group : string.Empty
            };
            if (Items == null)
                Items = new List<Step_BalanceAndOthers_LIQUIDITYPLAN_Item>();
            Items.Add(newItem);
        }
        public void Remove(Step_BalanceAndOthers_LIQUIDITYPLAN_Item removeItem)
        {
            var grps = this.Items.Where(c => c.GroupName == removeItem.GroupName);
            if (grps.Count() == 1)
            {
                removeItem.Name = string.Empty;
                removeItem.Year1 = 0;
                removeItem.Year2 = 0;
                removeItem.Year3 = 0;
                removeItem.Year4 = 0;
                removeItem.Year5 = 0;

            }
            else
            {
                this.Items.Remove(removeItem);
            }
        }
        #endregion
    }
}