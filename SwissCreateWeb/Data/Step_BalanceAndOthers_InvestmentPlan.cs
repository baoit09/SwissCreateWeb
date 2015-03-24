using SwissCreateWeb.Models.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SwissCreateWeb.Data
{
    public class Step_BalanceAndOthers_InvestmentPlan : INotifyPropertyChanged
    {
        public Step_BalanceAndOthers_InvestmentPlan()
        {
            if (Items == null)
                Items = new List<Step_BalanceAndOthers_InvestmentPlan_Item>();
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
        #region Step_BalanceAndOthers_InvestmentPlan_Header
        
        string _Step_BalanceAndOthers_InvestmentPlan_Header = string.Empty;
        public string Step_BalanceAndOthers_InvestmentPlan_Header_4Report
        {
            get
            {
                if (Report_Config_Finance.IsConvertHeaderToUpper == true)
                    return Step_BalanceAndOthers_InvestmentPlan_Header.ToUpper();
                return Step_BalanceAndOthers_InvestmentPlan_Header;
            }
        }
        public string Step_BalanceAndOthers_InvestmentPlan_Header
        {
            get
            {
                if (string.IsNullOrEmpty(_Step_BalanceAndOthers_InvestmentPlan_Header))
                {
                    _Step_BalanceAndOthers_InvestmentPlan_Header = "Investment plan";
                }
                return _Step_BalanceAndOthers_InvestmentPlan_Header;
            }
            set
            {
                if (_Step_BalanceAndOthers_InvestmentPlan_Header != value)
                {
                    _Step_BalanceAndOthers_InvestmentPlan_Header = value;
                    SendPropertyChanged("Step_BalanceAndOthers_InvestmentPlan_Header");
                }
            }
        }
        #endregion

        #region UIText_InvestmentsForMachinery
        
        string _UIText_InvestmentsForMachinery = string.Empty;
        public string UIText_InvestmentsForMachinery
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_InvestmentsForMachinery))
                {
                    _UIText_InvestmentsForMachinery = "Buy machinery, movable goods, IT, real estate, buildings… ";
                }
                return _UIText_InvestmentsForMachinery;
            }
            set
            {
                if (_UIText_InvestmentsForMachinery != value)
                {
                    _UIText_InvestmentsForMachinery = value;
                    SendPropertyChanged("UIText_InvestmentsForMachinery");
                }
            }
        }
        #endregion

        #region UIText_SellMachinery
        
        string _UIText_SellMachinery = string.Empty;
        public string UIText_SellMachinery
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_SellMachinery))
                {
                    _UIText_SellMachinery = "Sell machinery, movable goods, IT, real estate, buildings…";
                }
                return _UIText_SellMachinery;
            }
            set
            {
                if (_UIText_SellMachinery != value)
                {
                    _UIText_SellMachinery = value;
                    SendPropertyChanged("UIText_SellMachinery");
                }
            }
        }
        #endregion

        #region UIText_Total
        
        string _UIText_Total = string.Empty;
        public string UIText_Total
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Total))
                {
                    _UIText_Total = "Total";
                }
                return _UIText_Total;
            }
            set
            {
                if (_UIText_Total != value)
                {
                    _UIText_Total = value;
                    SendPropertyChanged("UIText_Total");
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

        #region UIText_TimeOfInvestment
        
        string _UIText_TimeOfInvestment = string.Empty;
        public string UIText_TimeOfInvestment
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_TimeOfInvestment))
                {
                    _UIText_TimeOfInvestment = "Time of investment";
                }
                return _UIText_TimeOfInvestment;
            }
            set
            {
                if (_UIText_TimeOfInvestment != value)
                {
                    _UIText_TimeOfInvestment = value;
                    SendPropertyChanged("UIText_TimeOfInvestment ");
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

        #region UIText_UseFor
        
        string _UIText_UseFor = string.Empty;
        public string UIText_UseFor
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_UseFor))
                {
                    _UIText_UseFor = "Use for";
                }
                return _UIText_UseFor;
            }
            set
            {
                if (_UIText_UseFor != value)
                {
                    _UIText_UseFor = value;
                    SendPropertyChanged("UIText_UseFor");
                }
            }
        }
        #endregion

        #region UIText_FinancingMethod
        
        string _UIText_FinancingMethod = string.Empty;
        public string UIText_FinancingMethod
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_FinancingMethod))
                {
                    _UIText_FinancingMethod = "Financing method";
                }
                return _UIText_FinancingMethod;
            }
            set
            {
                if (_UIText_FinancingMethod != value)
                {
                    _UIText_FinancingMethod = value;
                    SendPropertyChanged("UIText_FinancingMethod");
                }
            }
        }
        #endregion

        #region UIText_AdditionalRemark
        
        string _UIText_AdditionalRemark = string.Empty;
        public string UIText_AdditionalRemark
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_AdditionalRemark))
                {
                    _UIText_AdditionalRemark = "Additional remark";
                }
                return _UIText_AdditionalRemark;
            }
            set
            {
                if (_UIText_AdditionalRemark != value)
                {
                    _UIText_AdditionalRemark = value;
                    SendPropertyChanged("UIText_AdditionalRemark");
                }
            }
        }
        #endregion
        #endregion

        #region Data
        public void RefreshData()
        {
            if (Items == null)
                Items = new List<Step_BalanceAndOthers_InvestmentPlan_Item>();
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
        
        public List<Step_BalanceAndOthers_InvestmentPlan_Item> Items { get; set; }
        public Step_BalanceAndOthers_InvestmentPlan_Item[] Items_INVESTMENT
        {
            get
            {
                return Items == null ? new Step_BalanceAndOthers_InvestmentPlan_Item[0] : Items.Where(c => c.GroupName == GROUP_INVESTMENT).ToArray();
            }
            set { }
        }
        public Step_BalanceAndOthers_InvestmentPlan_Item[] Items_SELL
        {
            get
            {
                return Items == null ? new Step_BalanceAndOthers_InvestmentPlan_Item[0] : Items.Where(c => c.GroupName == GROUP_SELL).ToArray();
            }
            set { }
        }
        public double Total_Investment
        {
            get { return Items_INVESTMENT.Sum(c => c.Value); }
        }
        public double Total_Investment_Year1
        {
            get { return Items_INVESTMENT.Sum(c => c.Year1); }
        }
        public double Total_Investment_Year2
        {
            get { return Items_INVESTMENT.Sum(c => c.Year2); }
        }
        public double Total_Investment_Year3
        {
            get { return Items_INVESTMENT.Sum(c => c.Year3); }
        }
        public double Total_Investment_Year4
        {
            get { return Items_INVESTMENT.Sum(c => c.Year4); }
        }
        public double Total_Investment_Year5
        {
            get { return Items_INVESTMENT.Sum(c => c.Year5); }
        }
        public double Total_Sell
        {
            get { return Items_SELL.Sum(c => c.Value); }
        }
        public double Total_Sell_Year1
        {
            get { return Items_SELL.Sum(c => c.Year1); }
        }
        public double Total_Sell_Year2
        {
            get { return Items_SELL.Sum(c => c.Year2); }
        }
        public double Total_Sell_Year3
        {
            get { return Items_SELL.Sum(c => c.Year3); }
        }
        public double Total_Sell_Year4
        {
            get { return Items_SELL.Sum(c => c.Year4); }
        }
        public double Total_Sell_Year5
        {
            get { return Items_SELL.Sum(c => c.Year5); }
        }
        public string GROUP_INVESTMENT
        {
            get { return "INVESTMENT"; }
        }
        public string GROUP_SELL
        {
            get { return "SELL"; }
        }
        public void SendPropertyChanged_Total()
        {
            SendPropertyChanged("Total_Investment");
            SendPropertyChanged("Total_Sell");

            SendPropertyChanged("Total_Sell_Year1");
            SendPropertyChanged("Total_Sell_Year2");
            SendPropertyChanged("Total_Sell_Year3");
            SendPropertyChanged("Total_Sell_Year4");
            SendPropertyChanged("Total_Sell_Year5");
            SendPropertyChanged("Total_Investment_Year1");
            SendPropertyChanged("Total_Investment_Year2");
            SendPropertyChanged("Total_Investment_Year3");
            SendPropertyChanged("Total_Investment_Year4");
            SendPropertyChanged("Total_Investment_Year5");

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
            Step_BalanceAndOthers_InvestmentPlan_Item newItem = new Step_BalanceAndOthers_InvestmentPlan_Item(this)
            {
                GroupName = group,
            };
            if (Items == null)
                Items = new List<Step_BalanceAndOthers_InvestmentPlan_Item>();
            Items.Add(newItem);
        }
        public void Remove(Step_BalanceAndOthers_InvestmentPlan_Item removeItem)
        {
            var grps = this.Items.Where(c => c.GroupName == removeItem.GroupName);
            if (grps.Count() == 1)
            {
                removeItem.Name = string.Empty;
                removeItem.Value = 0;
                removeItem.Year1 = 0;// string.Empty;
                removeItem.Year2 = 0;//string.Empty;
                removeItem.Year3 = 0;//string.Empty;
                removeItem.Year4 = 0;//string.Empty;
                removeItem.Year5 = 0;//string.Empty;
                removeItem.UseFor = string.Empty;
                removeItem.FinancingMethod = string.Empty;
                removeItem.AdditionalRemark = string.Empty;
            }
            else
            {
                this.Items.Remove(removeItem);
            }
        }
        #endregion


    }
}