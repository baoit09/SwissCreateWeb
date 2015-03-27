using Data;
using SwissCreateWeb.Models.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
//using ViCode_LeVi.Data;

namespace SwissCreateWeb.Data
{
    public class Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT : INotifyPropertyChanged
    {
        public Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT()
        {
            if (Items == null)
                Items = new List<Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item>();
        }
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        public Step_BalanceAndOthers_LIQUIDITYPLAN LIQUIDITYPLAN
        {
            get
            {
                var lTab_Finance_LIQUIDITYPLAN = RootData.Intance.Tab_Finance_LIQUIDITYPLAN;
                return lTab_Finance_LIQUIDITYPLAN;
            }
        }
        public string CompanyName { get { return ProjectData.Intance.CompanyName; } }
        #region UI
        #region Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Header
        
        string _Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Header = string.Empty;
        public string Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Header_4Report
        {
            get
            {
                if (Report_Config_Finance.IsConvertHeaderToUpper == true)
                    return Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Header.ToUpper();
                return Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Header;
            }
        }
        public string Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Header
        {
            get
            {
                if (string.IsNullOrEmpty(_Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Header))
                {
                    _Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Header = "Profit and loss statment, budget";
                }
                return _Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Header;
            }
            set
            {
                if (_Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Header != value)
                {
                    _Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Header = value;
                    SendPropertyChanged("Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Header");
                }
            }
        }
        #endregion

        #region UIText_INCOME
        
        string _UIText_INCOME = string.Empty;
        public string UIText_INCOME
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_INCOME))
                {
                    _UIText_INCOME = "INCOME:";
                }
                return _UIText_INCOME;
            }
            set
            {
                if (_UIText_INCOME != value)
                {
                    _UIText_INCOME = value;
                    SendPropertyChanged("UIText_INCOME");
                }
            }
        }
        #endregion

        #region UIText_Total_INCOME
        
        string _UIText_Total_INCOME = string.Empty;
        public string UIText_Total_INCOME
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_INCOME))
                {
                    _UIText_Total_INCOME = "TOTAL INCOME:";
                }
                return _UIText_Total_INCOME;
            }
            set
            {
                if (_UIText_Total_INCOME != value)
                {
                    _UIText_Total_INCOME = value;
                    SendPropertyChanged("UIText_Total_INCOME");
                }
            }
        }
        #endregion

        #region UIText_COSTS
        
        string _UIText_COSTS = string.Empty;
        public string UIText_COSTS
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_COSTS))
                {
                    _UIText_COSTS = "COSTS (raw material):";
                }
                return _UIText_COSTS;
            }
            set
            {
                if (_UIText_COSTS != value)
                {
                    _UIText_COSTS = value;
                    SendPropertyChanged("UIText_COSTS");
                }
            }
        }
        #endregion

        #region UIText_Total_COSTS
        
        string _UIText_Total_COSTS = string.Empty;
        public string UIText_Total_COSTS
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_COSTS))
                {
                    _UIText_Total_COSTS = "TOTAL COSTS:";
                }
                return _UIText_Total_COSTS;
            }
            set
            {
                if (_UIText_Total_COSTS != value)
                {
                    _UIText_Total_COSTS = value;
                    SendPropertyChanged("UIText_Total_COSTS");
                }
            }
        }
        #endregion

        #region UIText_OPERATINGEXPENSES
        
        string _UIText_OPERATINGEXPENSES = string.Empty;
        public string UIText_OPERATINGEXPENSES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_OPERATINGEXPENSES))
                {
                    _UIText_OPERATINGEXPENSES = "OPERATING EXPENSES:";
                }
                return _UIText_OPERATINGEXPENSES;
            }
            set
            {
                if (_UIText_OPERATINGEXPENSES != value)
                {
                    _UIText_OPERATINGEXPENSES = value;
                    SendPropertyChanged("UIText_OPERATINGEXPENSES");
                }
            }
        }
        #endregion

        #region UIText_Total_OPERATINGEXPENSES_Depreciation
        
        string _UIText_Total_OPERATINGEXPENSES_Depreciation = string.Empty;
        public string UIText_Total_OPERATINGEXPENSES_Depreciation
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_OPERATINGEXPENSES_Depreciation))
                {
                    _UIText_Total_OPERATINGEXPENSES_Depreciation = "Depreciation get from Depreciation Calculation";
                }
                return _UIText_Total_OPERATINGEXPENSES_Depreciation;
            }
            set
            {
                if (_UIText_Total_OPERATINGEXPENSES_Depreciation != value)
                {
                    _UIText_Total_OPERATINGEXPENSES_Depreciation = value;
                    SendPropertyChanged("UIText_Total_OPERATINGEXPENSES_Depreciation");
                }
            }
        }
        #endregion

        #region UIText_Total_OPERATINGEXPENSES_InterestsFromLiquidityPlan
        
        string _UIText_Total_OPERATINGEXPENSES_InterestsFromLiquidityPlan = string.Empty;
        public string UIText_Total_OPERATINGEXPENSES_InterestsFromLiquidityPlan
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_OPERATINGEXPENSES_InterestsFromLiquidityPlan))
                {
                    _UIText_Total_OPERATINGEXPENSES_InterestsFromLiquidityPlan = "Interests get from Liquidity plan";
                }
                return _UIText_Total_OPERATINGEXPENSES_InterestsFromLiquidityPlan;
            }
            set
            {
                if (_UIText_Total_OPERATINGEXPENSES_InterestsFromLiquidityPlan != value)
                {
                    _UIText_Total_OPERATINGEXPENSES_InterestsFromLiquidityPlan = value;
                    SendPropertyChanged("UIText_Total_OPERATINGEXPENSES_InterestsFromLiquidityPlan");
                }
            }
        }
        #endregion

        #region UIText_Total_OPERATINGEXPENSES_InterestsFromLiquidityPlan_REFTOLIQUID
        
        string _UIText_Total_OPERATINGEXPENSES_InterestsFromLiquidityPlan_REFTOLIQUID = string.Empty;
        public string UIText_Total_OPERATINGEXPENSES_InterestsFromLiquidityPlan_REFTOLIQUID
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_OPERATINGEXPENSES_InterestsFromLiquidityPlan_REFTOLIQUID))
                {
                    _UIText_Total_OPERATINGEXPENSES_InterestsFromLiquidityPlan_REFTOLIQUID = "Interest payments on loans";
                }
                return _UIText_Total_OPERATINGEXPENSES_InterestsFromLiquidityPlan_REFTOLIQUID;
            }
            set
            {
                if (_UIText_Total_OPERATINGEXPENSES_InterestsFromLiquidityPlan_REFTOLIQUID != value)
                {
                    _UIText_Total_OPERATINGEXPENSES_InterestsFromLiquidityPlan_REFTOLIQUID = value;
                    SendPropertyChanged("UIText_Total_OPERATINGEXPENSES_InterestsFromLiquidityPlan_REFTOLIQUID");
                }
            }
        }
        #endregion

        #region UIText_Total_OPERATINGEXPENSES
        
        string _UIText_Total_OPERATINGEXPENSES = string.Empty;
        public string UIText_Total_OPERATINGEXPENSES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_OPERATINGEXPENSES))
                {
                    _UIText_Total_OPERATINGEXPENSES = "TOTAL OF OPERATING EXPENSES:";
                }
                return _UIText_Total_OPERATINGEXPENSES;
            }
            set
            {
                if (_UIText_Total_OPERATINGEXPENSES != value)
                {
                    _UIText_Total_OPERATINGEXPENSES = value;
                    SendPropertyChanged("UIText_Total_OPERATINGEXPENSES");
                }
            }
        }
        #endregion

        #region UIText_Total_NETPROFITLOSS
        
        string _UIText_Total_NETPROFITLOSS = string.Empty;
        public string UIText_Total_NETPROFITLOSS
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_NETPROFITLOSS))
                {
                    _UIText_Total_NETPROFITLOSS = "NET PROFIT/LOSS:";
                }
                return _UIText_Total_NETPROFITLOSS;
            }
            set
            {
                if (_UIText_Total_NETPROFITLOSS != value)
                {
                    _UIText_Total_NETPROFITLOSS = value;
                    SendPropertyChanged("UIText_Total_NETPROFITLOSS");
                }
            }
        }
        #endregion

        #region UIText_Total_CHANGEININVENTORY
        
        string _UIText_Total_CHANGEININVENTORY = string.Empty;
        public string UIText_Total_CHANGEININVENTORY
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_CHANGEININVENTORY))
                {
                    _UIText_Total_CHANGEININVENTORY = "Change in inventory:";
                }
                return _UIText_Total_CHANGEININVENTORY;
            }
            set
            {
                if (_UIText_Total_CHANGEININVENTORY != value)
                {
                    _UIText_Total_CHANGEININVENTORY = value;
                    SendPropertyChanged("UIText_Total_CHANGEININVENTORY");
                }
            }
        }
        #endregion

        #region UIText_Total_GROSSPROFIT
        
        string _UIText_Total_GROSSPROFIT = string.Empty;
        public string UIText_Total_GROSSPROFIT
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total_GROSSPROFIT))
                {
                    _UIText_Total_GROSSPROFIT = "GROSS PROFIT:";
                }
                return _UIText_Total_GROSSPROFIT;
            }
            set
            {
                if (_UIText_Total_GROSSPROFIT != value)
                {
                    _UIText_Total_GROSSPROFIT = value;
                    SendPropertyChanged("UIText_Total_GROSSPROFIT");
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
                Items = new List<Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item>();
            var _items = Items;
            foreach (var item in _items)
            {
                if (item != null)
                {
                    if (item.Parent != this)
                        item.Parent = this;
                }
            }
            SendPropertyChanged_GROUP_OPERATINGEXPENSES_Depreciation_Year();
            SendPropertyChanged_GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year();
        }
        
        public List<Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item> Items { get; set; }
        public Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item[] Items_INCOME
        {
            get
            {
                return Items == null ? new Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item[0] : Items.Where(c => c.GroupName == GROUP_INCOME).ToArray();
            }
            set { }
        }
        public Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item[] Items_COSTS
        {
            get
            {
                return Items == null ? new Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item[0] : Items.Where(c => c.GroupName == GROUP_COSTS).ToArray();
            }
            set { }
        }
        public Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item[] Items_OPERATINGEXPENSES
        {
            get
            {
                return Items == null ? new Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item[0] : Items.Where(c => c.GroupName == GROUP_OPERATINGEXPENSES).ToArray();
            }
            set { }
        }
        /// <summary>
        /// Include Depreciation + Interests
        /// </summary>
        public Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item[] Items_OPERATINGEXPENSES_Include_Others
        {
            get
            {
                List<Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item> list = new List<Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item>();
                var list1 = Items_OPERATINGEXPENSES;
                if (list1 != null)
                    list.AddRange(list1);
                list.Add(new Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item(this, true)
                {
                    //GroupName = GROUP_OPERATINGEXPENSES,
                    Name = UIText_Total_OPERATINGEXPENSES_Depreciation
                    ,
                    Year1 = this.GROUP_OPERATINGEXPENSES_Depreciation_Year1
                    ,
                    Year2 = this.GROUP_OPERATINGEXPENSES_Depreciation_Year2
                  ,
                    Year3 = this.GROUP_OPERATINGEXPENSES_Depreciation_Year3
                  ,
                    Year4 = this.GROUP_OPERATINGEXPENSES_Depreciation_Year4
                  ,
                    Year5 = this.GROUP_OPERATINGEXPENSES_Depreciation_Year5

                });
                list.Add(new Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item(this, true)
                {
                    //GroupName = GROUP_OPERATINGEXPENSES,
                    Name = UIText_Total_OPERATINGEXPENSES_InterestsFromLiquidityPlan
                    ,
                    Year1 = this.GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year1
                    ,
                    Year2 = this.GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year2
                  ,
                    Year3 = this.GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year3
                  ,
                    Year4 = this.GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year4
                  ,
                    Year5 = this.GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year5

                });
                return list.ToArray();
            }
            set { }
        }



        #region GROUP_INCOME_Total
        public double GROUP_INCOME_Total_Year1
        {
            get { return Items_INCOME.Sum(c => c.Year1); }
        }
        public double GROUP_INCOME_Total_Year2
        {
            get { return Items_INCOME.Sum(c => c.Year2); }
        }
        public double GROUP_INCOME_Total_Year3
        {
            get { return Items_INCOME.Sum(c => c.Year3); }
        }
        public double GROUP_INCOME_Total_Year4
        {
            get { return Items_INCOME.Sum(c => c.Year4); }
        }
        public double GROUP_INCOME_Total_Year5
        {
            get { return Items_INCOME.Sum(c => c.Year5); }
        }
        #endregion

        #region GROUP_COSTS_Total
        public double GROUP_COSTS_Total_Year1
        {
            get { return Items_COSTS.Sum(c => c.Year1); }
        }
        public double GROUP_COSTS_Total_Year2
        {
            get { return Items_COSTS.Sum(c => c.Year2); }
        }
        public double GROUP_COSTS_Total_Year3
        {
            get { return Items_COSTS.Sum(c => c.Year3); }
        }
        public double GROUP_COSTS_Total_Year4
        {
            get { return Items_COSTS.Sum(c => c.Year4); }
        }
        public double GROUP_COSTS_Total_Year5
        {
            get { return Items_COSTS.Sum(c => c.Year5); }
        }
        #endregion

        #region GROUP_OPERATINGEXPENSES_Depreciation
        public void SendPropertyChanged_GROUP_OPERATINGEXPENSES_Depreciation_Year()
        {
            SendPropertyChanged("GROUP_OPERATINGEXPENSES_Depreciation_Year1");
            SendPropertyChanged("GROUP_OPERATINGEXPENSES_Depreciation_Year2");
            SendPropertyChanged("GROUP_OPERATINGEXPENSES_Depreciation_Year3");
            SendPropertyChanged("GROUP_OPERATINGEXPENSES_Depreciation_Year4");
            SendPropertyChanged("GROUP_OPERATINGEXPENSES_Depreciation_Year5");
        }
        public double GROUP_OPERATINGEXPENSES_Depreciation_Year1
        {
            get
            {
                if (RootData.Intance.Tab_Finance_DEPRECIATION_CALCULATION == null)
                    return 0;
                return RootData.Intance.Tab_Finance_DEPRECIATION_CALCULATION.Total_Year1_Depreciation;
            }
        }
        public double GROUP_OPERATINGEXPENSES_Depreciation_Year2
        {
            get
            {
                if (RootData.Intance.Tab_Finance_DEPRECIATION_CALCULATION == null)
                    return 0;
                return RootData.Intance.Tab_Finance_DEPRECIATION_CALCULATION.Total_Year2_Depreciation;
            }
        }
        public double GROUP_OPERATINGEXPENSES_Depreciation_Year3
        {
            get
            {
                if (RootData.Intance.Tab_Finance_DEPRECIATION_CALCULATION == null)
                    return 0;
                return RootData.Intance.Tab_Finance_DEPRECIATION_CALCULATION.Total_Year3_Depreciation;
            }
        }
        public double GROUP_OPERATINGEXPENSES_Depreciation_Year4
        {
            get
            {
                if (RootData.Intance.Tab_Finance_DEPRECIATION_CALCULATION == null)
                    return 0;
                return RootData.Intance.Tab_Finance_DEPRECIATION_CALCULATION.Total_Year4_Depreciation;
            }
        }
        public double GROUP_OPERATINGEXPENSES_Depreciation_Year5
        {
            get
            {
                if (RootData.Intance.Tab_Finance_DEPRECIATION_CALCULATION == null)
                    return 0;
                return RootData.Intance.Tab_Finance_DEPRECIATION_CALCULATION.Total_Year5_Depreciation;
            }
        }
        #endregion

        #region GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan
        public void SendPropertyChanged_GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year()
        {
            SendPropertyChanged("GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year1");
            SendPropertyChanged("GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year2");
            SendPropertyChanged("GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year3");
            SendPropertyChanged("GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year4");
            SendPropertyChanged("GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year5");
        }
        private Step_BalanceAndOthers_LIQUIDITYPLAN_Item GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year_Item
        {
            get
            {
                var lLIQUID = LIQUIDITYPLAN;
                if (lLIQUID == null)
                    return null;
                var data = lLIQUID.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.FirstOrDefault(c => c.Name != null
                &&
                c.Name.Trim().Equals(UIText_Total_OPERATINGEXPENSES_InterestsFromLiquidityPlan_REFTOLIQUID, StringComparison.CurrentCultureIgnoreCase));
                return data;
            }
        }
        public double GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year1
        {
            get
            {
                double oldData = 0;
                var data = GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year_Item;
                return oldData + (data == null ? 0 : data.Year1);
            }
        }
        public double GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year2
        {
            get
            {
                double oldData = 0;
                var data = GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year_Item;
                return oldData + (data == null ? 0 : data.Year2);
            }
        }
        public double GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year3
        {
            get
            {
                double oldData = 0;
                var data = GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year_Item;
                return oldData + (data == null ? 0 : data.Year3);
            }
        }
        public double GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year4
        {
            get
            {
                double oldData = 0;
                var data = GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year_Item;
                return oldData + (data == null ? 0 : data.Year4);
            }
        }
        public double GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year5
        {
            get
            {
                double oldData = 0;
                var data = GROUP_OPERATINGEXPENSES_InterestsFromLiquidityPlan_Year_Item;
                return oldData + (data == null ? 0 : data.Year5);
            }
        }
        #endregion

        #region GROUP_OPERATINGEXPENSES_Total
        public double GROUP_OPERATINGEXPENSES_Total_Year1
        {
            get { return Items_OPERATINGEXPENSES_Include_Others.Sum(c => c.Year1); }
        }
        public double GROUP_OPERATINGEXPENSES_Total_Year2
        {
            get { return Items_OPERATINGEXPENSES_Include_Others.Sum(c => c.Year2); }
        }
        public double GROUP_OPERATINGEXPENSES_Total_Year3
        {
            get { return Items_OPERATINGEXPENSES_Include_Others.Sum(c => c.Year3); }
        }
        public double GROUP_OPERATINGEXPENSES_Total_Year4
        {
            get { return Items_OPERATINGEXPENSES_Include_Others.Sum(c => c.Year4); }
        }
        public double GROUP_OPERATINGEXPENSES_Total_Year5
        {
            get { return Items_OPERATINGEXPENSES_Include_Others.Sum(c => c.Year5); }
        }
        #endregion

        #region GROSS CASH FLOW
        public double GROUP_GROSSPROFIT_Total_Year1
        {
            get { return GROUP_INCOME_Total_Year1 - GROUP_COSTS_Total_Year1 + ChangeInInventory_Year1; }
        }
        public double GROUP_GROSSPROFIT_Total_Year2
        {
            get { return GROUP_INCOME_Total_Year2 - GROUP_COSTS_Total_Year2 + ChangeInInventory_Year2; }
        }
        public double GROUP_GROSSPROFIT_Total_Year3
        {
            get { return GROUP_INCOME_Total_Year3 - GROUP_COSTS_Total_Year3 + ChangeInInventory_Year3; }
        }
        public double GROUP_GROSSPROFIT_Total_Year4
        {
            get { return GROUP_INCOME_Total_Year4 - GROUP_COSTS_Total_Year4 + ChangeInInventory_Year4; }
        }
        public double GROUP_GROSSPROFIT_Total_Year5
        {
            get { return GROUP_INCOME_Total_Year5 - GROUP_COSTS_Total_Year5 + ChangeInInventory_Year5; }
        }
        #endregion

        #region ChangeInInventory
        #region ChangeInInventory_Year1
        
        double _ChangeInInventory_Year1 = 0;
        public double ChangeInInventory_Year1
        {
            get
            {
                return _ChangeInInventory_Year1;
            }
            set
            {
                if (_ChangeInInventory_Year1 != value)
                {
                    _ChangeInInventory_Year1 = value;
                    SendPropertyChanged("ChangeInInventory_Year1");
                    SendPropertyChanged_Total();
                }
            }
        }
        #endregion

        #region ChangeInInventory_Year2
        
        double _ChangeInInventory_Year2 = 0;
        public double ChangeInInventory_Year2
        {
            get
            {
                return _ChangeInInventory_Year2;
            }
            set
            {
                if (_ChangeInInventory_Year2 != value)
                {
                    _ChangeInInventory_Year2 = value;
                    SendPropertyChanged("ChangeInInventory_Year2");
                    SendPropertyChanged_Total();
                }
            }
        }
        #endregion

        #region ChangeInInventory_Year3
        
        double _ChangeInInventory_Year3 = 0;
        public double ChangeInInventory_Year3
        {
            get
            {
                return _ChangeInInventory_Year3;
            }
            set
            {
                if (_ChangeInInventory_Year3 != value)
                {
                    _ChangeInInventory_Year3 = value;
                    SendPropertyChanged("ChangeInInventory_Year3");
                    SendPropertyChanged_Total();
                }
            }
        }
        #endregion

        #region ChangeInInventory_Year4
        
        double _ChangeInInventory_Year4 = 0;
        public double ChangeInInventory_Year4
        {
            get
            {
                return _ChangeInInventory_Year4;
            }
            set
            {
                if (_ChangeInInventory_Year4 != value)
                {
                    _ChangeInInventory_Year4 = value;
                    SendPropertyChanged("ChangeInInventory_Year4");
                    SendPropertyChanged_Total();
                }
            }
        }
        #endregion

        #region ChangeInInventory_Year5
        
        double _ChangeInInventory_Year5 = 0;
        public double ChangeInInventory_Year5
        {
            get
            {
                return _ChangeInInventory_Year5;
            }
            set
            {
                if (_ChangeInInventory_Year5 != value)
                {
                    _ChangeInInventory_Year5 = value;
                    SendPropertyChanged("ChangeInInventory_Year5");
                    SendPropertyChanged_Total();
                }
            }
        }
        #endregion
        #endregion
        #region NET CASH FLOW
        public double GROUP_NETPROFITLOSS_Total_Year1
        {
            get { return GROUP_GROSSPROFIT_Total_Year1 - GROUP_OPERATINGEXPENSES_Total_Year1; }
        }
        public double GROUP_NETPROFITLOSS_Total_Year2
        {
            get { return GROUP_GROSSPROFIT_Total_Year2 - GROUP_OPERATINGEXPENSES_Total_Year2; }
        }
        public double GROUP_NETPROFITLOSS_Total_Year3
        {
            get { return GROUP_GROSSPROFIT_Total_Year3 - GROUP_OPERATINGEXPENSES_Total_Year3; }
        }
        public double GROUP_NETPROFITLOSS_Total_Year4
        {
            get { return GROUP_GROSSPROFIT_Total_Year4 - GROUP_OPERATINGEXPENSES_Total_Year4; }
        }
        public double GROUP_NETPROFITLOSS_Total_Year5
        {
            get { return GROUP_GROSSPROFIT_Total_Year5 - GROUP_OPERATINGEXPENSES_Total_Year5; }
        }
        #endregion

        public string GROUP_INCOME
        {
            get { return "INCOME"; }
        }
        public string GROUP_COSTS
        {
            get { return "COSTS"; }
        }
        public string GROUP_OPERATINGEXPENSES
        {
            get { return "OPERATINGEXPENSES"; }
        }
        public void SendPropertyChanged_Total()
        {
            SendPropertyChanged("GROUP_INCOME_Total_Year1");
            SendPropertyChanged("GROUP_INCOME_Total_Year2");
            SendPropertyChanged("GROUP_INCOME_Total_Year3");
            SendPropertyChanged("GROUP_INCOME_Total_Year4");
            SendPropertyChanged("GROUP_INCOME_Total_Year5");

            SendPropertyChanged("GROUP_COSTS_Total_Year1");
            SendPropertyChanged("GROUP_COSTS_Total_Year2");
            SendPropertyChanged("GROUP_COSTS_Total_Year3");
            SendPropertyChanged("GROUP_COSTS_Total_Year4");
            SendPropertyChanged("GROUP_COSTS_Total_Year5");

            SendPropertyChanged("GROUP_OPERATINGEXPENSES_Total_Year1");
            SendPropertyChanged("GROUP_OPERATINGEXPENSES_Total_Year2");
            SendPropertyChanged("GROUP_OPERATINGEXPENSES_Total_Year3");
            SendPropertyChanged("GROUP_OPERATINGEXPENSES_Total_Year4");
            SendPropertyChanged("GROUP_OPERATINGEXPENSES_Total_Year5");

            SendPropertyChanged("GROUP_GROSSPROFIT_Total_Year1");
            SendPropertyChanged("GROUP_GROSSPROFIT_Total_Year2");
            SendPropertyChanged("GROUP_GROSSPROFIT_Total_Year3");
            SendPropertyChanged("GROUP_GROSSPROFIT_Total_Year4");
            SendPropertyChanged("GROUP_GROSSPROFIT_Total_Year5");

            SendPropertyChanged("GROUP_NETPROFITLOSS_Total_Year1");
            SendPropertyChanged("GROUP_NETPROFITLOSS_Total_Year2");
            SendPropertyChanged("GROUP_NETPROFITLOSS_Total_Year3");
            SendPropertyChanged("GROUP_NETPROFITLOSS_Total_Year4");
            SendPropertyChanged("GROUP_NETPROFITLOSS_Total_Year5");


        }
        #endregion

        #region Add
        public void AddNew(string group)
        {
            Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item newItem = new Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item(this)
            {
                GroupName = group,
            };
            if (Items == null)
                Items = new List<Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item>();
            Items.Add(newItem);
        }
        public void AddNew(string group, string name)
        {
            Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item newItem = new Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item(this)
            {
                GroupName = group,
                Name = name
            };
            if (Items == null)
                Items = new List<Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item>();
            Items.Add(newItem);
        }
        public void AddNew(string group, bool just1InGrp)
        {
            Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item newItem = new Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item(this)
            {
                GroupName = group,
                Name = just1InGrp == true ? group : string.Empty
            };
            if (Items == null)
                Items = new List<Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item>();
            Items.Add(newItem);
        }
        public void Remove(Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item removeItem)
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