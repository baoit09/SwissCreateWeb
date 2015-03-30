using SwissCreateWeb.Models.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using ViCode_LeVi.Data;

namespace ViCode_LeVi.Data
{
    public static class Report_Config_Finance
    {
        public static bool IsConvertHeaderToUpper = true;
    }
    
    public class Step_BalanceAndOthers_Sheet_Statement : INotifyPropertyChanged
    {
        public Step_BalanceAndOthers_Sheet_Statement()
        {
            //if (Items == null)
            //    Items = new List<Step_BalanceAndOthers_Sheet_Statement_Item>();            
        }
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        public void SendPropertyChangedAll()
        {
            SendPropertyChanged("InventoryYear1");
            SendPropertyChanged("InventoryYear2");
            SendPropertyChanged("InventoryYear3");
            SendPropertyChanged("InventoryYear4");
            SendPropertyChanged("InventoryYear5");

            SendPropertyChanged("CashEquivalentYear1");
            SendPropertyChanged("CashEquivalentYear2");
            SendPropertyChanged("CashEquivalentYear3");
            SendPropertyChanged("CashEquivalentYear4");
            SendPropertyChanged("CashEquivalentYear5");

            SendPropertyChanged("AccountsReceivableYear1");
            SendPropertyChanged("AccountsReceivableYear2");
            SendPropertyChanged("AccountsReceivableYear3");
            SendPropertyChanged("AccountsReceivableYear4");
            SendPropertyChanged("AccountsReceivableYear5");

            SendPropertyChanged("TotalCurrentAssetsYear1");
            SendPropertyChanged("TotalCurrentAssetsYear2");
            SendPropertyChanged("TotalCurrentAssetsYear3");
            SendPropertyChanged("TotalCurrentAssetsYear4");
            SendPropertyChanged("TotalCurrentAssetsYear5");

            SendPropertyChanged("ComputerEquipmentYear1");
            SendPropertyChanged("ComputerEquipmentYear2");
            SendPropertyChanged("ComputerEquipmentYear3");
            SendPropertyChanged("ComputerEquipmentYear4");
            SendPropertyChanged("ComputerEquipmentYear5");

            SendPropertyChanged("MachineryEquipmentYear1");
            SendPropertyChanged("MachineryEquipmentYear2");
            SendPropertyChanged("MachineryEquipmentYear3");
            SendPropertyChanged("MachineryEquipmentYear4");
            SendPropertyChanged("MachineryEquipmentYear5");

            SendPropertyChanged("FurnitureFixturesYear1");
            SendPropertyChanged("FurnitureFixturesYear2");
            SendPropertyChanged("FurnitureFixturesYear3");
            SendPropertyChanged("FurnitureFixturesYear4");
            SendPropertyChanged("FurnitureFixturesYear5");

            SendPropertyChanged("VehiclesYear1");
            SendPropertyChanged("VehiclesYear2");
            SendPropertyChanged("VehiclesYear3");
            SendPropertyChanged("VehiclesYear4");
            SendPropertyChanged("VehiclesYear5");

            SendPropertyChanged("LeaseholdImprovementsYear1");
            SendPropertyChanged("LeaseholdImprovementsYear2");
            SendPropertyChanged("LeaseholdImprovementsYear3");
            SendPropertyChanged("LeaseholdImprovementsYear4");
            SendPropertyChanged("LeaseholdImprovementsYear5");

            SendPropertyChanged("BuildingYear1");
            SendPropertyChanged("BuildingYear2");
            SendPropertyChanged("BuildingYear3");
            SendPropertyChanged("BuildingYear4");
            SendPropertyChanged("BuildingYear5");

            SendPropertyChanged("LandYear1");
            SendPropertyChanged("LandYear2");
            SendPropertyChanged("LandYear3");
            SendPropertyChanged("LandYear4");
            SendPropertyChanged("LandYear5");

            SendPropertyChanged("LessAccumulatedDepreciationYear1");
            SendPropertyChanged("LessAccumulatedDepreciationYear2");
            SendPropertyChanged("LessAccumulatedDepreciationYear3");
            SendPropertyChanged("LessAccumulatedDepreciationYear4");
            SendPropertyChanged("LessAccumulatedDepreciationYear5");

            SendPropertyChanged("TotalNonCurrentAssetsYear1");
            SendPropertyChanged("TotalNonCurrentAssetsYear2");
            SendPropertyChanged("TotalNonCurrentAssetsYear3");
            SendPropertyChanged("TotalNonCurrentAssetsYear4");
            SendPropertyChanged("TotalNonCurrentAssetsYear5");

            SendPropertyChanged("TotalAssetsYear1");
            SendPropertyChanged("TotalAssetsYear2");
            SendPropertyChanged("TotalAssetsYear3");
            SendPropertyChanged("TotalAssetsYear4");
            SendPropertyChanged("TotalAssetsYear5");


            SendPropertyChanged("LoansYear1");
            SendPropertyChanged("LoansYear2");
            SendPropertyChanged("LoansYear3");
            SendPropertyChanged("LoansYear4");
            SendPropertyChanged("LoansYear5");

            SendPropertyChanged("OtherNonCurrentLiabilitiesYear1");
            SendPropertyChanged("OtherNonCurrentLiabilitiesYear2");
            SendPropertyChanged("OtherNonCurrentLiabilitiesYear3");
            SendPropertyChanged("OtherNonCurrentLiabilitiesYear4");
            SendPropertyChanged("OtherNonCurrentLiabilitiesYear5");

            SendPropertyChanged("RealEstateLoansYear1");
            SendPropertyChanged("RealEstateLoansYear2");
            SendPropertyChanged("RealEstateLoansYear3");
            SendPropertyChanged("RealEstateLoansYear4");
            SendPropertyChanged("RealEstateLoansYear5");

            SendPropertyChanged("ShareholderLoanYear1");
            SendPropertyChanged("ShareholderLoanYear2");
            SendPropertyChanged("ShareholderLoanYear3");
            SendPropertyChanged("ShareholderLoanYear4");
            SendPropertyChanged("ShareholderLoanYear5");

            SendPropertyChanged("TotalLongTermLiabilitiesYear1");
            SendPropertyChanged("TotalLongTermLiabilitiesYear2");
            SendPropertyChanged("TotalLongTermLiabilitiesYear3");
            SendPropertyChanged("TotalLongTermLiabilitiesYear4");
            SendPropertyChanged("TotalLongTermLiabilitiesYear5");

            SendPropertyChanged("TotalLiabilitiesYear1");
            SendPropertyChanged("TotalLiabilitiesYear2");
            SendPropertyChanged("TotalLiabilitiesYear3");
            SendPropertyChanged("TotalLiabilitiesYear4");
            SendPropertyChanged("TotalLiabilitiesYear5");

            SendPropertyChanged("AccountPayableYear1");
            SendPropertyChanged("AccountPayableYear2");
            SendPropertyChanged("AccountPayableYear3");
            SendPropertyChanged("AccountPayableYear4");
            SendPropertyChanged("AccountPayableYear5");

            SendPropertyChanged("LineOfCreditYear1");
            SendPropertyChanged("LineOfCreditYear2");
            SendPropertyChanged("LineOfCreditYear3");
            SendPropertyChanged("LineOfCreditYear4");
            SendPropertyChanged("LineOfCreditYear5");

            SendPropertyChanged("TotalCurrentLiabilitiesYear1");
            SendPropertyChanged("TotalCurrentLiabilitiesYear2");
            SendPropertyChanged("TotalCurrentLiabilitiesYear3");
            SendPropertyChanged("TotalCurrentLiabilitiesYear4");
            SendPropertyChanged("TotalCurrentLiabilitiesYear5");

            SendPropertyChanged("OwnersEquityYear1");
            SendPropertyChanged("OwnersEquityYear2");
            SendPropertyChanged("OwnersEquityYear3");
            SendPropertyChanged("OwnersEquityYear4");
            SendPropertyChanged("OwnersEquityYear5");

            SendPropertyChanged("PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year1");
            SendPropertyChanged("PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year2");
            SendPropertyChanged("PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year3");
            SendPropertyChanged("PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year4");
            SendPropertyChanged("PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year5");

            SendPropertyChanged("RetainedEarningsYear1");
            SendPropertyChanged("RetainedEarningsYear2");
            SendPropertyChanged("RetainedEarningsYear3");
            SendPropertyChanged("RetainedEarningsYear4");
            SendPropertyChanged("RetainedEarningsYear5");

            SendPropertyChanged("LessOwnersInvestorDrawsYear1");
            SendPropertyChanged("LessOwnersInvestorDrawsYear2");
            SendPropertyChanged("LessOwnersInvestorDrawsYear3");
            SendPropertyChanged("LessOwnersInvestorDrawsYear4");
            SendPropertyChanged("LessOwnersInvestorDrawsYear5");

            SendPropertyChanged("TotalEquityYear1");
            SendPropertyChanged("TotalEquityYear2");
            SendPropertyChanged("TotalEquityYear3");
            SendPropertyChanged("TotalEquityYear4");
            SendPropertyChanged("TotalEquityYear5");


            SendPropertyChanged("TotalEquityLiabilitiesYear1");
            SendPropertyChanged("TotalEquityLiabilitiesYear2");
            SendPropertyChanged("TotalEquityLiabilitiesYear3");
            SendPropertyChanged("TotalEquityLiabilitiesYear4");
            SendPropertyChanged("TotalEquityLiabilitiesYear5");
        }
        public string CompanyName { get { return ProjectData.Intance.CompanyName; } }
        public Step_BalanceAndOthers_LIQUIDITYPLAN LIQUIDITYPLAN
        {
            get
            {
                var lTab_Finance_LIQUIDITYPLAN = RootData.Intance.Tab_Finance_LIQUIDITYPLAN;
                return lTab_Finance_LIQUIDITYPLAN;
            }
        }
        public Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT PROFIT_LOSS_STATEMENT
        {
            get
            {
                var lTab_Finance_PROFIT_LOSS_STATEMENT = RootData.Intance.Tab_Finance_PROFIT_LOSS_STATEMENT;
                return lTab_Finance_PROFIT_LOSS_STATEMENT;
            }
        }

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

        #region Step_BalanceAndOthers_Sheet_Statement_Header
        
        string _Step_BalanceAndOthers_Sheet_Statement_Header = string.Empty;
        public string Step_BalanceAndOthers_Sheet_Statement_Header_4Report
        {
            get
            {
                if (Report_Config_Finance.IsConvertHeaderToUpper == true)
                    return Step_BalanceAndOthers_Sheet_Statement_Header.ToUpper();
                return Step_BalanceAndOthers_Sheet_Statement_Header;
            }
        }
        public string Step_BalanceAndOthers_Sheet_Statement_Header
        {
            get
            {
                if (string.IsNullOrEmpty(_Step_BalanceAndOthers_Sheet_Statement_Header))
                {
                    _Step_BalanceAndOthers_Sheet_Statement_Header = "Sheet Statement";
                }
                return _Step_BalanceAndOthers_Sheet_Statement_Header;
            }
            set
            {
                if (_Step_BalanceAndOthers_Sheet_Statement_Header != value)
                {
                    _Step_BalanceAndOthers_Sheet_Statement_Header = value;
                    SendPropertyChanged("Step_BalanceAndOthers_Sheet_Statement_Header");
                }
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

        #region Current Assets

        #region UIText_CURRENT_ASSETS
        
        string _UIText_CURRENT_ASSETS = string.Empty;
        public string UIText_CURRENT_ASSETS
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CURRENT_ASSETS))
                {
                    _UIText_CURRENT_ASSETS = "Current Assets:";
                }
                return _UIText_CURRENT_ASSETS;
            }
            set
            {
                if (_UIText_CURRENT_ASSETS != value)
                {
                    _UIText_CURRENT_ASSETS = value;
                    SendPropertyChanged("UIText_CURRENT_ASSETS");
                }
            }
        }
        #endregion

        #region Cash&Equivalents

        #region UIText_CURRENT_ASSETS_CASH_EQUI
        
        string _UIText_CURRENT_ASSETS_CASH_EQUI = string.Empty;
        public string UIText_CURRENT_ASSETS_CASH_EQUI
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CURRENT_ASSETS_CASH_EQUI))
                {
                    _UIText_CURRENT_ASSETS_CASH_EQUI = "Cash&Equivalents:";
                }
                return _UIText_CURRENT_ASSETS_CASH_EQUI;
            }
            set
            {
                if (_UIText_CURRENT_ASSETS_CASH_EQUI != value)
                {
                    _UIText_CURRENT_ASSETS_CASH_EQUI = value;
                    SendPropertyChanged("UIText_CURRENT_ASSETS_CASH_EQUI");
                }
            }
        }
        #endregion

        #region CashEquivalentYear1
        public decimal CashEquivalentYear1
        {
            get
            {
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                return lLIQUIDITYPLAN == null ? 0 : (decimal)lLIQUIDITYPLAN.GROUP_CASH_AT_THE_END_OF_THE_PERIOD_Total_Year1;
            }
            set
            {
            }
        }
        #endregion

        #region CashEquivalentYear2
        public decimal CashEquivalentYear2
        {
            get
            {
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                return lLIQUIDITYPLAN == null ? 0 : (decimal)lLIQUIDITYPLAN.GROUP_CASH_AT_THE_END_OF_THE_PERIOD_Total_Year2;
            }
            set
            {
            }
        }
        #endregion

        #region CashEquivalentYear3
        public decimal CashEquivalentYear3
        {
            get
            {
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                return lLIQUIDITYPLAN == null ? 0 : (decimal)lLIQUIDITYPLAN.GROUP_CASH_AT_THE_END_OF_THE_PERIOD_Total_Year3;
            }
            set
            {
            }
        }
        #endregion

        #region CashEquivalentYear4
        public decimal CashEquivalentYear4
        {
            get
            {
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                return lLIQUIDITYPLAN == null ? 0 : (decimal)lLIQUIDITYPLAN.GROUP_CASH_AT_THE_END_OF_THE_PERIOD_Total_Year4;
            }
            set
            {
            }
        }
        #endregion

        #region CashEquivalentYear5
        public decimal CashEquivalentYear5
        {
            get
            {
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                return lLIQUIDITYPLAN == null ? 0 : (decimal)lLIQUIDITYPLAN.GROUP_CASH_AT_THE_END_OF_THE_PERIOD_Total_Year5;
            }
            set
            {
            }
        }
        #endregion

        #endregion

        #region Accounts Receivable

        #region UIText_CURRENT_ASSETS_ACCOUNT_RECEI
        
        string _UIText_CURRENT_ASSETS_ACCOUNT_RECEI = string.Empty;
        public string UIText_CURRENT_ASSETS_ACCOUNT_RECEI
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CURRENT_ASSETS_ACCOUNT_RECEI))
                {
                    _UIText_CURRENT_ASSETS_ACCOUNT_RECEI = "Accounts Receivable:";
                }
                return _UIText_CURRENT_ASSETS_ACCOUNT_RECEI;
            }
            set
            {
                if (_UIText_CURRENT_ASSETS_ACCOUNT_RECEI != value)
                {
                    _UIText_CURRENT_ASSETS_ACCOUNT_RECEI = value;
                    SendPropertyChanged("UIText_CURRENT_ASSETS_ACCOUNT_RECEI");
                }
            }
        }
        #endregion

        #region AccountsReceivableYear1
        decimal _AccountsReceivableYear1;
        //
        public decimal AccountsReceivableYear1
        {
            get
            {
                var oldData = 0;
                var lProfit = PROFIT_LOSS_STATEMENT;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                var totalProfit_Income = lProfit == null ? 0 : lProfit.GROUP_INCOME_Total_Year1;
                var totalLIQUIDITYPLAN_CashInFlowFromOperation = lLIQUIDITYPLAN == null ? 0 : lLIQUIDITYPLAN.GROUP_CASH_INFLOW_FROM_OPERATIONS_Total_Year1;
                return oldData + (decimal)(totalProfit_Income - totalLIQUIDITYPLAN_CashInFlowFromOperation);
            }
            set
            {
                //if (_AccountsReceivableYear1 != value)
                //{
                //    _AccountsReceivableYear1 = value;
                //    SendPropertyChanged("AccountsReceivableYear1");
                //    SendPropertyChanged("TotalCurrentAssetsYear1");
                //    SendPropertyChanged("TotalAssetsYear1");
                //}
            }
        }
        #endregion

        #region AccountsReceivableYear2
        decimal _AccountsReceivableYear2;
        //
        public decimal AccountsReceivableYear2
        {
            get
            {
                var oldData = AccountsReceivableYear1;
                var lProfit = PROFIT_LOSS_STATEMENT;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                var totalProfit_Income = lProfit == null ? 0 : lProfit.GROUP_INCOME_Total_Year2;
                var totalLIQUIDITYPLAN_CashInFlowFromOperation = lLIQUIDITYPLAN == null ? 0 : lLIQUIDITYPLAN.GROUP_CASH_INFLOW_FROM_OPERATIONS_Total_Year2;
                return oldData + (decimal)(totalProfit_Income - totalLIQUIDITYPLAN_CashInFlowFromOperation);

            }
            set
            {
                //if (_AccountsReceivableYear2 != value)
                //{
                //    _AccountsReceivableYear2 = value;
                //    SendPropertyChanged("AccountsReceivableYear2");
                //    SendPropertyChanged("TotalCurrentAssetsYear2");
                //    SendPropertyChanged("TotalAssetsYear2");
                //}
            }
        }
        #endregion

        #region AccountsReceivableYear3
        decimal _AccountsReceivableYear3;
        //
        public decimal AccountsReceivableYear3
        {
            get
            {
                var oldData = AccountsReceivableYear2;
                var lProfit = PROFIT_LOSS_STATEMENT;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                var totalProfit_Income = lProfit == null ? 0 : lProfit.GROUP_INCOME_Total_Year3;
                var totalLIQUIDITYPLAN_CashInFlowFromOperation = lLIQUIDITYPLAN == null ? 0 : lLIQUIDITYPLAN.GROUP_CASH_INFLOW_FROM_OPERATIONS_Total_Year3;
                return oldData + (decimal)(totalProfit_Income - totalLIQUIDITYPLAN_CashInFlowFromOperation);

            }
            set
            {
                //if (_AccountsReceivableYear3 != value)
                //{
                //    _AccountsReceivableYear3 = value;
                //    SendPropertyChanged("AccountsReceivableYear3");
                //    SendPropertyChanged("TotalCurrentAssetsYear3");
                //    SendPropertyChanged("TotalAssetsYear3");
                //}
            }
        }
        #endregion

        #region AccountsReceivableYear4
        decimal _AccountsReceivableYear4;
        //
        public decimal AccountsReceivableYear4
        {
            get
            {
                var oldData = AccountsReceivableYear3;
                var lProfit = PROFIT_LOSS_STATEMENT;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                var totalProfit_Income = lProfit == null ? 0 : lProfit.GROUP_INCOME_Total_Year4;
                var totalLIQUIDITYPLAN_CashInFlowFromOperation = lLIQUIDITYPLAN == null ? 0 : lLIQUIDITYPLAN.GROUP_CASH_INFLOW_FROM_OPERATIONS_Total_Year4;
                return oldData + (decimal)(totalProfit_Income - totalLIQUIDITYPLAN_CashInFlowFromOperation);

            }
            set
            {
                //if (_AccountsReceivableYear4 != value)
                //{
                //    _AccountsReceivableYear4 = value;
                //    SendPropertyChanged("AccountsReceivableYear4");
                //    SendPropertyChanged("TotalCurrentAssetsYear4");
                //    SendPropertyChanged("TotalAssetsYear4");
                //}
            }
        }
        #endregion

        #region AccountsReceivableYear5
        decimal _AccountsReceivableYear5;
        //
        public decimal AccountsReceivableYear5
        {
            get
            {
                var oldData = AccountsReceivableYear4;
                var lProfit = PROFIT_LOSS_STATEMENT;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                var totalProfit_Income = lProfit == null ? 0 : lProfit.GROUP_INCOME_Total_Year5;
                var totalLIQUIDITYPLAN_CashInFlowFromOperation = lLIQUIDITYPLAN == null ? 0 : lLIQUIDITYPLAN.GROUP_CASH_INFLOW_FROM_OPERATIONS_Total_Year5;
                return oldData + (decimal)(totalProfit_Income - totalLIQUIDITYPLAN_CashInFlowFromOperation);

            }
            set
            {
                //if (_AccountsReceivableYear5 != value)
                //{
                //    _AccountsReceivableYear5 = value;
                //    SendPropertyChanged("AccountsReceivableYear5");
                //    SendPropertyChanged("TotalCurrentAssetsYear5");
                //    SendPropertyChanged("TotalAssetsYear5");
                //}
            }
        }
        #endregion


        #endregion

        #region Inventory
        #region UIText_CURRENT_ASSETS_INVENTORY
        
        string _UIText_CURRENT_ASSETS_INVENTORY = string.Empty;
        public string UIText_CURRENT_ASSETS_INVENTORY
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CURRENT_ASSETS_INVENTORY))
                {
                    _UIText_CURRENT_ASSETS_INVENTORY = "Inventory:";
                }
                return _UIText_CURRENT_ASSETS_INVENTORY;
            }
            set
            {
                if (_UIText_CURRENT_ASSETS_INVENTORY != value)
                {
                    _UIText_CURRENT_ASSETS_INVENTORY = value;
                    SendPropertyChanged("UIText_CURRENT_ASSETS_INVENTORY");
                }
            }
        }
        #endregion

        #region InventoryYear1
        
        decimal _InventoryYear1;
        public decimal InventoryYear1
        {
            get
            {
                return _InventoryYear1;
                //var oldData = 0;
                //var profit = PROFIT_LOSS_STATEMENT;
                //if (profit == null)
                //    return oldData;
                //return oldData + (decimal)profit.ChangeInInventory_Year1;                
            }
            set
            {
                if (_InventoryYear1 != value)
                {
                    _InventoryYear1 = value;
                    SendPropertyChanged("InventoryYear1");
                    SendPropertyChanged("TotalCurrentAssetsYear1");
                    SendPropertyChanged("TotalAssetsYear1");
                }
            }
        }
        #endregion

        #region InventoryYear2
        
        decimal _InventoryYear2;
        public decimal InventoryYear2
        {
            get
            {
                return _InventoryYear2;
                //var oldData = InventoryYear1;
                //var profit = PROFIT_LOSS_STATEMENT;
                //if (profit == null)
                //    return oldData;
                //return oldData + (decimal)profit.ChangeInInventory_Year2;
            }
            set
            {
                if (_InventoryYear2 != value)
                {
                    _InventoryYear2 = value;
                    SendPropertyChanged("InventoryYear2");
                    SendPropertyChanged("TotalCurrentAssetsYear2");
                    SendPropertyChanged("TotalAssetsYear2");
                }
            }
        }
        #endregion

        #region InventoryYear3
        
        decimal _InventoryYear3;
        public decimal InventoryYear3
        {
            get
            {
                return _InventoryYear3;
                //var oldData = InventoryYear2;
                //var profit = PROFIT_LOSS_STATEMENT;
                //if (profit == null)
                //    return oldData;
                //return oldData + (decimal)profit.ChangeInInventory_Year3;
            }
            set
            {
                if (_InventoryYear3 != value)
                {
                    _InventoryYear3 = value;
                    SendPropertyChanged("InventoryYear3");
                    SendPropertyChanged("TotalCurrentAssetsYear3");
                    SendPropertyChanged("TotalAssetsYear3");
                }
            }
        }
        #endregion

        #region InventoryYear4
        
        decimal _InventoryYear4;
        public decimal InventoryYear4
        {
            get
            {
                return _InventoryYear4;
                //var oldData = InventoryYear3;
                //var profit = PROFIT_LOSS_STATEMENT;
                //if (profit == null)
                //    return oldData;
                //return oldData + (decimal)profit.ChangeInInventory_Year4;
            }
            set
            {
                if (_InventoryYear4 != value)
                {
                    _InventoryYear4 = value;
                    SendPropertyChanged("InventoryYear4");
                    SendPropertyChanged("TotalCurrentAssetsYear4");
                    SendPropertyChanged("TotalAssetsYear4");
                }
            }
        }
        #endregion

        #region InventoryYear5
        
        decimal _InventoryYear5;
        public decimal InventoryYear5
        {
            get
            {
                return _InventoryYear5;
                //var oldData = InventoryYear4;
                //var profit = PROFIT_LOSS_STATEMENT;
                //if (profit == null)
                //    return oldData;
                //return oldData + (decimal)profit.ChangeInInventory_Year5;
            }
            set
            {
                if (_InventoryYear5 != value)
                {
                    _InventoryYear5 = value;
                    SendPropertyChanged("InventoryYear5");
                    SendPropertyChanged("TotalCurrentAssetsYear5");
                    SendPropertyChanged("TotalAssetsYear5");
                }
            }
        }
        #endregion
        #endregion

        #region Security Deposits
        #region UIText_CURRENT_ASSETS_SECURITY_DEP
        
        string _UIText_CURRENT_ASSETS_SECURITY_DEP = string.Empty;
        public string UIText_CURRENT_ASSETS_SECURITY_DEP
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CURRENT_ASSETS_SECURITY_DEP))
                {
                    _UIText_CURRENT_ASSETS_SECURITY_DEP = "Security Deposits:";
                }
                return _UIText_CURRENT_ASSETS_SECURITY_DEP;
            }
            set
            {
                if (_UIText_CURRENT_ASSETS_SECURITY_DEP != value)
                {
                    _UIText_CURRENT_ASSETS_SECURITY_DEP = value;
                    SendPropertyChanged("UIText_CURRENT_ASSETS_SECURITY_DEP");
                }
            }
        }
        #endregion

        #region SecurityDepositsYear1
        decimal _SecurityDepositsYear1;
        
        public decimal SecurityDepositsYear1
        {
            get
            {
                return _SecurityDepositsYear1;
            }
            set
            {
                if (_SecurityDepositsYear1 != value)
                {
                    _SecurityDepositsYear1 = value;
                    SendPropertyChanged("SecurityDepositsYear1");
                    SendPropertyChanged("TotalCurrentAssetsYear1");
                    SendPropertyChanged("TotalAssetsYear1");
                }
            }
        }
        #endregion

        #region SecurityDepositsYear2
        decimal _SecurityDepositsYear2;
        
        public decimal SecurityDepositsYear2
        {
            get
            {
                return _SecurityDepositsYear2;
            }
            set
            {
                if (_SecurityDepositsYear2 != value)
                {
                    _SecurityDepositsYear2 = value;
                    SendPropertyChanged("SecurityDepositsYear2");
                    SendPropertyChanged("TotalCurrentAssetsYear2");
                    SendPropertyChanged("TotalAssetsYear2");
                }
            }
        }
        #endregion

        #region SecurityDepositsYear3
        decimal _SecurityDepositsYear3;
        
        public decimal SecurityDepositsYear3
        {
            get
            {
                return _SecurityDepositsYear3;
            }
            set
            {
                if (_SecurityDepositsYear3 != value)
                {
                    _SecurityDepositsYear3 = value;
                    SendPropertyChanged("SecurityDepositsYear3");
                    SendPropertyChanged("TotalCurrentAssetsYear3");
                    SendPropertyChanged("TotalAssetsYear3");
                }
            }
        }
        #endregion

        #region SecurityDepositsYear4
        decimal _SecurityDepositsYear4;
        
        public decimal SecurityDepositsYear4
        {
            get
            {
                return _SecurityDepositsYear4;
            }
            set
            {
                if (_SecurityDepositsYear4 != value)
                {
                    _SecurityDepositsYear4 = value;
                    SendPropertyChanged("SecurityDepositsYear4");
                    SendPropertyChanged("TotalCurrentAssetsYear4");
                    SendPropertyChanged("TotalAssetsYear4");
                }
            }
        }
        #endregion

        #region SecurityDepositsYear5
        decimal _SecurityDepositsYear5;
        
        public decimal SecurityDepositsYear5
        {
            get
            {
                return _SecurityDepositsYear5;
            }
            set
            {
                if (_SecurityDepositsYear5 != value)
                {
                    _SecurityDepositsYear5 = value;
                    SendPropertyChanged("SecurityDepositsYear5");
                    SendPropertyChanged("TotalCurrentAssetsYear5");
                    SendPropertyChanged("TotalAssetsYear5");
                }
            }
        }
        #endregion
        #endregion

        #region Other Current Assets
        #region UIText_CURRENT_ASSETS_OTHER_CURRENT
        
        string _UIText_CURRENT_ASSETS_OTHER_CURRENT = string.Empty;
        public string UIText_CURRENT_ASSETS_OTHER_CURRENT
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CURRENT_ASSETS_OTHER_CURRENT))
                {
                    _UIText_CURRENT_ASSETS_OTHER_CURRENT = "Cash&Equivalents:";
                }
                return _UIText_CURRENT_ASSETS_OTHER_CURRENT;
            }
            set
            {
                if (_UIText_CURRENT_ASSETS_OTHER_CURRENT != value)
                {
                    _UIText_CURRENT_ASSETS_OTHER_CURRENT = value;
                    SendPropertyChanged("UIText_CURRENT_ASSETS_OTHER_CURRENT");
                }
            }
        }
        #endregion

        #region OtherCurrentAssetsYear1
        decimal _OtherCurrentAssetsYear1;
        
        public decimal OtherCurrentAssetsYear1
        {
            get
            {
                return _OtherCurrentAssetsYear1;
            }
            set
            {
                if (_OtherCurrentAssetsYear1 != value)
                {
                    _OtherCurrentAssetsYear1 = value;
                    SendPropertyChanged("OtherCurrentAssetsYear1");
                    SendPropertyChanged("TotalCurrentAssetsYear1");
                    SendPropertyChanged("TotalAssetsYear1");
                }
            }
        }
        #endregion

        #region OtherCurrentAssetsYear2
        decimal _OtherCurrentAssetsYear2;
        
        public decimal OtherCurrentAssetsYear2
        {
            get
            {
                return _OtherCurrentAssetsYear2;
            }
            set
            {
                if (_OtherCurrentAssetsYear2 != value)
                {
                    _OtherCurrentAssetsYear2 = value;
                    SendPropertyChanged("OtherCurrentAssetsYear2");
                    SendPropertyChanged("TotalCurrentAssetsYear2");
                    SendPropertyChanged("TotalAssetsYear2");
                }
            }
        }
        #endregion

        #region OtherCurrentAssetsYear3
        decimal _OtherCurrentAssetsYear3;
        
        public decimal OtherCurrentAssetsYear3
        {
            get
            {
                return _OtherCurrentAssetsYear3;
            }
            set
            {
                if (_OtherCurrentAssetsYear3 != value)
                {
                    _OtherCurrentAssetsYear3 = value;
                    SendPropertyChanged("OtherCurrentAssetsYear3");
                    SendPropertyChanged("TotalCurrentAssetsYear3");
                    SendPropertyChanged("TotalAssetsYear3");
                }
            }
        }
        #endregion

        #region OtherCurrentAssetsYear4
        decimal _OtherCurrentAssetsYear4;
        
        public decimal OtherCurrentAssetsYear4
        {
            get
            {
                return _OtherCurrentAssetsYear4;
            }
            set
            {
                if (_OtherCurrentAssetsYear4 != value)
                {
                    _OtherCurrentAssetsYear4 = value;
                    SendPropertyChanged("OtherCurrentAssetsYear4");
                    SendPropertyChanged("TotalCurrentAssetsYear4");
                    SendPropertyChanged("TotalAssetsYear4");
                }
            }
        }
        #endregion

        #region OtherCurrentAssetsYear5
        decimal _OtherCurrentAssetsYear5;
        
        public decimal OtherCurrentAssetsYear5
        {
            get
            {
                return _OtherCurrentAssetsYear5;
            }
            set
            {
                if (_OtherCurrentAssetsYear5 != value)
                {
                    _OtherCurrentAssetsYear5 = value;
                    SendPropertyChanged("OtherCurrentAssetsYear5");
                    SendPropertyChanged("TotalCurrentAssetsYear5");
                    SendPropertyChanged("TotalAssetsYear5");
                }
            }
        }
        #endregion
        #endregion

        #region Total Current Assets
        #region UIText_TOLTAL_CURRENT_ASSETS
        
        string _UIText_TOLTAL_CURRENT_ASSETS = string.Empty;
        public string UIText_TOLTAL_CURRENT_ASSETS
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_TOLTAL_CURRENT_ASSETS))
                {
                    _UIText_TOLTAL_CURRENT_ASSETS = "Total Current Assets:";
                }
                return _UIText_TOLTAL_CURRENT_ASSETS;
            }
            set
            {
                if (_UIText_TOLTAL_CURRENT_ASSETS != value)
                {
                    _UIText_TOLTAL_CURRENT_ASSETS = value;
                    SendPropertyChanged("UIText_TOLTAL_CURRENT_ASSETS");
                }
            }
        }
        #endregion

        #region TotalCurrentAssetsYear1


        public decimal TotalCurrentAssetsYear1
        {
            get
            {
                return CashEquivalentYear1 + AccountsReceivableYear1 + InventoryYear1 + SecurityDepositsYear1 + OtherCurrentAssetsYear1;
            }

        }
        #endregion

        #region TotalCurrentAssetsYear2


        public decimal TotalCurrentAssetsYear2
        {
            get
            {
                return CashEquivalentYear2 + AccountsReceivableYear2 + InventoryYear2 + SecurityDepositsYear2 + OtherCurrentAssetsYear2;
            }

        }
        #endregion

        #region TotalCurrentAssetsYear3


        public decimal TotalCurrentAssetsYear3
        {
            get
            {
                return CashEquivalentYear3 + AccountsReceivableYear3 + InventoryYear3 + SecurityDepositsYear3 + OtherCurrentAssetsYear3;
            }

        }
        #endregion

        #region TotalCurrentAssetsYear4


        public decimal TotalCurrentAssetsYear4
        {
            get
            {
                return CashEquivalentYear4 + AccountsReceivableYear4 + InventoryYear4 + SecurityDepositsYear4 + OtherCurrentAssetsYear4;
            }

        }
        #endregion

        #region TotalCurrentAssetsYear5


        public decimal TotalCurrentAssetsYear5
        {
            get
            {
                return CashEquivalentYear5 + AccountsReceivableYear5 + InventoryYear5 + SecurityDepositsYear5 + OtherCurrentAssetsYear5;
            }

        }
        #endregion


        #endregion

        #endregion

        #region Fixed Assets
        #region UIText_FIXED_ASSETS
        
        string _UIText_FIXED_ASSETS = string.Empty;
        public string UIText_FIXED_ASSETS
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_FIXED_ASSETS))
                {
                    _UIText_FIXED_ASSETS = "Fixed Assets:";
                }
                return _UIText_FIXED_ASSETS;
            }
            set
            {
                if (_UIText_FIXED_ASSETS != value)
                {
                    _UIText_FIXED_ASSETS = value;
                    SendPropertyChanged("UIText_FIXED_ASSETS");
                }
            }
        }
        #endregion



        #region Property, Plant & Equipment
        #region UIText_TOLTAL_NON_CURRENT_ASSETS_PRO_PLANT_EQUI
        
        string _UIText_TOLTAL_NON_CURRENT_ASSETS_PRO_PLANT_EQUI = string.Empty;
        public string UIText_TOLTAL_NON_CURRENT_ASSETS_PRO_PLANT_EQUI
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_TOLTAL_NON_CURRENT_ASSETS_PRO_PLANT_EQUI))
                {
                    _UIText_TOLTAL_NON_CURRENT_ASSETS_PRO_PLANT_EQUI = "Property, Plant & Equipment:";
                }
                return _UIText_TOLTAL_NON_CURRENT_ASSETS_PRO_PLANT_EQUI;
            }
            set
            {
                if (_UIText_TOLTAL_NON_CURRENT_ASSETS_PRO_PLANT_EQUI != value)
                {
                    _UIText_TOLTAL_NON_CURRENT_ASSETS_PRO_PLANT_EQUI = value;
                    SendPropertyChanged("UIText_TOLTAL_NON_CURRENT_ASSETS_PRO_PLANT_EQUI");
                }
            }
        }
        #endregion

        #region PropertyPlantEquipmentYear1
        decimal _PropertyPlantEquipmentYear1;
        
        public decimal PropertyPlantEquipmentYear1
        {
            get
            {
                return _PropertyPlantEquipmentYear1;
            }
            set
            {
                if (_PropertyPlantEquipmentYear1 != value)
                {
                    _PropertyPlantEquipmentYear1 = value;
                    SendPropertyChanged("PropertyPlantEquipmentYear1");
                    SendPropertyChanged("TotalNonCurrentAssetsYear1");
                    SendPropertyChanged("TotalAssetsYear1");
                }
            }
        }
        #endregion

        #region PropertyPlantEquipmentYear2
        decimal _PropertyPlantEquipmentYear2;
        
        public decimal PropertyPlantEquipmentYear2
        {
            get
            {
                return _PropertyPlantEquipmentYear2;
            }
            set
            {
                if (_PropertyPlantEquipmentYear2 != value)
                {
                    _PropertyPlantEquipmentYear2 = value;
                    SendPropertyChanged("PropertyPlantEquipmentYear2");
                    SendPropertyChanged("TotalNonCurrentAssetsYear2");
                    SendPropertyChanged("TotalAssetsYear2");
                }
            }
        }
        #endregion

        #region PropertyPlantEquipmentYear3
        decimal _PropertyPlantEquipmentYear3;
        
        public decimal PropertyPlantEquipmentYear3
        {
            get
            {
                return _PropertyPlantEquipmentYear3;
            }
            set
            {
                if (_PropertyPlantEquipmentYear3 != value)
                {
                    _PropertyPlantEquipmentYear3 = value;
                    SendPropertyChanged("PropertyPlantEquipmentYear3");
                    SendPropertyChanged("TotalNonCurrentAssetsYear3");
                    SendPropertyChanged("TotalAssetsYear3");
                }
            }
        }
        #endregion

        #region PropertyPlantEquipmentYear4
        decimal _PropertyPlantEquipmentYear4;
        
        public decimal PropertyPlantEquipmentYear4
        {
            get
            {
                return _PropertyPlantEquipmentYear4;
            }
            set
            {
                if (_PropertyPlantEquipmentYear4 != value)
                {
                    _PropertyPlantEquipmentYear4 = value;
                    SendPropertyChanged("PropertyPlantEquipmentYear4");
                    SendPropertyChanged("TotalNonCurrentAssetsYear4");
                    SendPropertyChanged("TotalAssetsYear4");
                }
            }
        }
        #endregion

        #region PropertyPlantEquipmentYear5
        decimal _PropertyPlantEquipmentYear5;
        
        public decimal PropertyPlantEquipmentYear5
        {
            get
            {
                return _PropertyPlantEquipmentYear5;
            }
            set
            {
                if (_PropertyPlantEquipmentYear5 != value)
                {
                    _PropertyPlantEquipmentYear5 = value;
                    SendPropertyChanged("PropertyPlantEquipmentYear5");
                    SendPropertyChanged("TotalNonCurrentAssetsYear5");
                    SendPropertyChanged("TotalAssetsYear5");
                }
            }
        }
        #endregion
        #endregion

        #region Computer equipment
        int ComputerEquipmentYear_Index
        {
            get { return 0; }
        }



        #region UIText_CURRENT_ASSETS_COMPUTER_EQUI
        
        string _UIText_CURRENT_ASSETS_COMPUTER_EQUI = string.Empty;
        public string UIText_CURRENT_ASSETS_COMPUTER_EQUI
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CURRENT_ASSETS_COMPUTER_EQUI))
                {
                    _UIText_CURRENT_ASSETS_COMPUTER_EQUI = "Computer equipment";
                }
                return _UIText_CURRENT_ASSETS_COMPUTER_EQUI;
            }
            set
            {
                if (_UIText_CURRENT_ASSETS_COMPUTER_EQUI != value)
                {
                    _UIText_CURRENT_ASSETS_COMPUTER_EQUI = value;
                    SendPropertyChanged("UIText_CURRENT_ASSETS_COMPUTER_EQUI");
                }
            }
        }
        #endregion

        #region ComputerEquipmentYear1
        public decimal ComputerEquipmentYear1
        {
            get
            {
                var oldData = 0;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < ComputerEquipmentYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[ComputerEquipmentYear_Index].Year1;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[ComputerEquipmentYear_Index].Year1;
                return oldData + (decimal)(outInvesting - inInvesting);
            }
            set
            {
            }
        }
        #endregion

        #region ComputerEquipmentYear2
        public decimal ComputerEquipmentYear2
        {
            get
            {
                var oldData = ComputerEquipmentYear1;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < ComputerEquipmentYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[ComputerEquipmentYear_Index].Year2;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[ComputerEquipmentYear_Index].Year2;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region ComputerEquipmentYear3
        public decimal ComputerEquipmentYear3
        {
            get
            {
                var oldData = ComputerEquipmentYear2;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < ComputerEquipmentYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[ComputerEquipmentYear_Index].Year3;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[ComputerEquipmentYear_Index].Year3;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region ComputerEquipmentYear4
        decimal _ComputerEquipmentYear4;
        public decimal ComputerEquipmentYear4
        {
            get
            {
                var oldData = ComputerEquipmentYear3;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < ComputerEquipmentYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[ComputerEquipmentYear_Index].Year4;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[ComputerEquipmentYear_Index].Year4;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region ComputerEquipmentYear5
        public decimal ComputerEquipmentYear5
        {
            get
            {
                var oldData = ComputerEquipmentYear4;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < ComputerEquipmentYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[ComputerEquipmentYear_Index].Year5;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[ComputerEquipmentYear_Index].Year5;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion
        #endregion

        #region Equipment/Machinery

        int MachineryEquipmentYear_Index
        {
            get { return 1; }
        }


        #region UIText_CURRENT_ASSETS_MACHINERY_EQUI
        
        string _UIText_CURRENT_ASSETS_MACHINERY_EQUI = string.Empty;
        public string UIText_CURRENT_ASSETS_MACHINERY_EQUI
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CURRENT_ASSETS_MACHINERY_EQUI))
                {
                    _UIText_CURRENT_ASSETS_MACHINERY_EQUI = "Equipment/Machinery";
                }
                return _UIText_CURRENT_ASSETS_MACHINERY_EQUI;
            }
            set
            {
                if (_UIText_CURRENT_ASSETS_MACHINERY_EQUI != value)
                {
                    _UIText_CURRENT_ASSETS_MACHINERY_EQUI = value;
                    SendPropertyChanged("UIText_CURRENT_ASSETS_MACHINERY_EQUI");
                }
            }
        }
        #endregion

        #region MachineryEquipmentYear1
        public decimal MachineryEquipmentYear1
        {
            get
            {
                var oldData = 0;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < MachineryEquipmentYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[MachineryEquipmentYear_Index].Year1;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[MachineryEquipmentYear_Index].Year1;
                return oldData + (decimal)(outInvesting - inInvesting);
            }
            set
            {
            }
        }
        #endregion

        #region MachineryEquipmentYear2
        public decimal MachineryEquipmentYear2
        {
            get
            {
                var oldData = MachineryEquipmentYear1;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < MachineryEquipmentYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[MachineryEquipmentYear_Index].Year2;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[MachineryEquipmentYear_Index].Year2;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region MachineryEquipmentYear3
        public decimal MachineryEquipmentYear3
        {
            get
            {
                var oldData = MachineryEquipmentYear2;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < MachineryEquipmentYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[MachineryEquipmentYear_Index].Year3;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[MachineryEquipmentYear_Index].Year3;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region MachineryEquipmentYear4
        decimal _MachineryEquipmentYear4;
        public decimal MachineryEquipmentYear4
        {
            get
            {
                var oldData = MachineryEquipmentYear3;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < MachineryEquipmentYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[MachineryEquipmentYear_Index].Year4;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[MachineryEquipmentYear_Index].Year4;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region MachineryEquipmentYear5
        public decimal MachineryEquipmentYear5
        {
            get
            {
                var oldData = MachineryEquipmentYear4;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < MachineryEquipmentYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[MachineryEquipmentYear_Index].Year5;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[MachineryEquipmentYear_Index].Year5;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion
        #endregion

        #region Furniture&Fixtures
        int FurnitureFixturesYear_Index
        {
            get { return 2; }
        }



        #region UIText_CURRENT_ASSETS_FUNITURE_FIX
        
        string _UIText_CURRENT_ASSETS_FUNITURE_FIX = string.Empty;
        public string UIText_CURRENT_ASSETS_FUNITURE_FIX
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CURRENT_ASSETS_FUNITURE_FIX))
                {
                    _UIText_CURRENT_ASSETS_FUNITURE_FIX = "Furniture&Fixtures";
                }
                return _UIText_CURRENT_ASSETS_FUNITURE_FIX;
            }
            set
            {
                if (_UIText_CURRENT_ASSETS_FUNITURE_FIX != value)
                {
                    _UIText_CURRENT_ASSETS_FUNITURE_FIX = value;
                    SendPropertyChanged("UIText_CURRENT_ASSETS_FUNITURE_FIX");
                }
            }
        }
        #endregion

        #region FurnitureFixturesYear1
        public decimal FurnitureFixturesYear1
        {
            get
            {
                var oldData = 0;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < FurnitureFixturesYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[FurnitureFixturesYear_Index].Year1;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[FurnitureFixturesYear_Index].Year1;
                return oldData + (decimal)(outInvesting - inInvesting);
            }
            set
            {
            }
        }
        #endregion

        #region FurnitureFixturesYear2
        public decimal FurnitureFixturesYear2
        {
            get
            {
                var oldData = FurnitureFixturesYear1;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < FurnitureFixturesYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[FurnitureFixturesYear_Index].Year2;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[FurnitureFixturesYear_Index].Year2;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region FurnitureFixturesYear3
        public decimal FurnitureFixturesYear3
        {
            get
            {
                var oldData = FurnitureFixturesYear2;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < FurnitureFixturesYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[FurnitureFixturesYear_Index].Year3;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[FurnitureFixturesYear_Index].Year3;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region FurnitureFixturesYear4
        decimal _FurnitureFixturesYear4;
        public decimal FurnitureFixturesYear4
        {
            get
            {
                var oldData = FurnitureFixturesYear3;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < FurnitureFixturesYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[FurnitureFixturesYear_Index].Year4;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[FurnitureFixturesYear_Index].Year4;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region FurnitureFixturesYear5
        public decimal FurnitureFixturesYear5
        {
            get
            {
                var oldData = FurnitureFixturesYear4;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < FurnitureFixturesYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[FurnitureFixturesYear_Index].Year5;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[FurnitureFixturesYear_Index].Year5;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion
        #endregion

        #region Vehicles
        int VehiclesYear_Index
        {
            get { return 3; }
        }



        #region UIText_CURRENT_ASSETS_VEHICLES
        
        string _UIText_CURRENT_ASSETS_VEHICLES = string.Empty;
        public string UIText_CURRENT_ASSETS_VEHICLES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CURRENT_ASSETS_VEHICLES))
                {
                    _UIText_CURRENT_ASSETS_VEHICLES = "Vehicles";
                }
                return _UIText_CURRENT_ASSETS_VEHICLES;
            }
            set
            {
                if (_UIText_CURRENT_ASSETS_VEHICLES != value)
                {
                    _UIText_CURRENT_ASSETS_VEHICLES = value;
                    SendPropertyChanged("UIText_CURRENT_ASSETS_VEHICLES");
                }
            }
        }
        #endregion

        #region VehiclesYear1
        public decimal VehiclesYear1
        {
            get
            {
                var oldData = 0;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < VehiclesYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[VehiclesYear_Index].Year1;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[VehiclesYear_Index].Year1;
                return oldData + (decimal)(outInvesting - inInvesting);
            }
            set
            {
            }
        }
        #endregion

        #region VehiclesYear2
        public decimal VehiclesYear2
        {
            get
            {
                var oldData = VehiclesYear1;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < VehiclesYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[VehiclesYear_Index].Year2;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[VehiclesYear_Index].Year2;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region VehiclesYear3
        public decimal VehiclesYear3
        {
            get
            {
                var oldData = VehiclesYear2;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < VehiclesYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[VehiclesYear_Index].Year3;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[VehiclesYear_Index].Year3;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region VehiclesYear4
        decimal _VehiclesYear4;
        public decimal VehiclesYear4
        {
            get
            {
                var oldData = VehiclesYear3;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < VehiclesYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[VehiclesYear_Index].Year4;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[VehiclesYear_Index].Year4;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region VehiclesYear5
        public decimal VehiclesYear5
        {
            get
            {
                var oldData = VehiclesYear4;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < VehiclesYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[VehiclesYear_Index].Year5;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[VehiclesYear_Index].Year5;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion
        #endregion

        #region Leasehold Improvements
        int LeaseholdImprovementsYear_Index
        {
            get { return 4; }
        }



        #region UIText_CURRENT_ASSETS_LEASE_IMPRO
        
        string _UIText_CURRENT_ASSETS_LEASE_IMPRO = string.Empty;
        public string UIText_CURRENT_ASSETS_LEASE_IMPRO
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CURRENT_ASSETS_LEASE_IMPRO))
                {
                    _UIText_CURRENT_ASSETS_LEASE_IMPRO = "Leasehold Improvements";
                }
                return _UIText_CURRENT_ASSETS_LEASE_IMPRO;
            }
            set
            {
                if (_UIText_CURRENT_ASSETS_LEASE_IMPRO != value)
                {
                    _UIText_CURRENT_ASSETS_LEASE_IMPRO = value;
                    SendPropertyChanged("UIText_CURRENT_ASSETS_LEASE_IMPRO");
                }
            }
        }
        #endregion

        #region LeaseholdImprovementsYear1
        public decimal LeaseholdImprovementsYear1
        {
            get
            {
                var oldData = 0;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < LeaseholdImprovementsYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[LeaseholdImprovementsYear_Index].Year1;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[LeaseholdImprovementsYear_Index].Year1;
                return oldData + (decimal)(outInvesting - inInvesting);
            }
            set
            {
            }
        }
        #endregion

        #region LeaseholdImprovementsYear2
        public decimal LeaseholdImprovementsYear2
        {
            get
            {
                var oldData = LeaseholdImprovementsYear1;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < LeaseholdImprovementsYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[LeaseholdImprovementsYear_Index].Year2;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[LeaseholdImprovementsYear_Index].Year2;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region LeaseholdImprovementsYear3
        public decimal LeaseholdImprovementsYear3
        {
            get
            {
                var oldData = LeaseholdImprovementsYear2;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < LeaseholdImprovementsYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[LeaseholdImprovementsYear_Index].Year3;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[LeaseholdImprovementsYear_Index].Year3;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region LeaseholdImprovementsYear4
        decimal _LeaseholdImprovementsYear4;
        public decimal LeaseholdImprovementsYear4
        {
            get
            {
                var oldData = LeaseholdImprovementsYear3;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < LeaseholdImprovementsYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[LeaseholdImprovementsYear_Index].Year4;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[LeaseholdImprovementsYear_Index].Year4;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region LeaseholdImprovementsYear5
        public decimal LeaseholdImprovementsYear5
        {
            get
            {
                var oldData = LeaseholdImprovementsYear4;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < LeaseholdImprovementsYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[LeaseholdImprovementsYear_Index].Year5;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[LeaseholdImprovementsYear_Index].Year5;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion
        #endregion

        #region Building
        int BuildingYear_Index
        {
            get { return 5; }
        }



        #region UIText_CURRENT_ASSETS_COMPUTER_BUILDING
        
        string _UIText_CURRENT_ASSETS_COMPUTER_BUILDING = string.Empty;
        public string UIText_CURRENT_ASSETS_COMPUTER_BUILDING
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CURRENT_ASSETS_COMPUTER_BUILDING))
                {
                    _UIText_CURRENT_ASSETS_COMPUTER_BUILDING = "Building";
                }
                return _UIText_CURRENT_ASSETS_COMPUTER_BUILDING;
            }
            set
            {
                if (_UIText_CURRENT_ASSETS_COMPUTER_BUILDING != value)
                {
                    _UIText_CURRENT_ASSETS_COMPUTER_BUILDING = value;
                    SendPropertyChanged("UIText_CURRENT_ASSETS_COMPUTER_BUILDING");
                }
            }
        }
        #endregion

        #region BuildingYear1
        public decimal BuildingYear1
        {
            get
            {
                var oldData = 0;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < BuildingYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[BuildingYear_Index].Year1;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[BuildingYear_Index].Year1;
                return oldData + (decimal)(outInvesting - inInvesting);
            }
            set
            {
            }
        }
        #endregion

        #region BuildingYear2
        public decimal BuildingYear2
        {
            get
            {
                var oldData = BuildingYear1;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < BuildingYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[BuildingYear_Index].Year2;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[BuildingYear_Index].Year2;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region BuildingYear3
        public decimal BuildingYear3
        {
            get
            {
                var oldData = BuildingYear2;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < BuildingYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[BuildingYear_Index].Year3;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[BuildingYear_Index].Year3;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region BuildingYear4
        decimal _BuildingYear4;
        public decimal BuildingYear4
        {
            get
            {
                var oldData = BuildingYear3;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < BuildingYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[BuildingYear_Index].Year4;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[BuildingYear_Index].Year4;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region BuildingYear5
        public decimal BuildingYear5
        {
            get
            {
                var oldData = BuildingYear4;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < BuildingYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[BuildingYear_Index].Year5;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[BuildingYear_Index].Year5;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion
        #endregion

        #region Land
        int LandYear_Index
        {
            get { return 6; }
        }

        #region UIText_CURRENT_ASSETS_LAN
        
        string _UIText_CURRENT_ASSETS_LAN = string.Empty;
        public string UIText_CURRENT_ASSETS_LAN
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CURRENT_ASSETS_LAN))
                {
                    _UIText_CURRENT_ASSETS_LAN = "Land";
                }
                return _UIText_CURRENT_ASSETS_LAN;
            }
            set
            {
                if (_UIText_CURRENT_ASSETS_LAN != value)
                {
                    _UIText_CURRENT_ASSETS_LAN = value;
                    SendPropertyChanged("UIText_CURRENT_ASSETS_LAN");
                }
            }
        }
        #endregion

        #region LandYear1
        public decimal LandYear1
        {
            get
            {
                var oldData = 0;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < LandYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[LandYear_Index].Year1;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[LandYear_Index].Year1;
                return oldData + (decimal)(outInvesting - inInvesting);
            }
            set
            {
            }
        }
        #endregion

        #region LandYear2
        public decimal LandYear2
        {
            get
            {
                var oldData = LandYear1;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < LandYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[LandYear_Index].Year2;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[LandYear_Index].Year2;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region LandYear3
        public decimal LandYear3
        {
            get
            {
                var oldData = LandYear2;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < LandYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[LandYear_Index].Year3;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[LandYear_Index].Year3;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region LandYear4
        decimal _LandYear4;
        public decimal LandYear4
        {
            get
            {
                var oldData = LandYear3;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < LandYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[LandYear_Index].Year4;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[LandYear_Index].Year4;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion

        #region LandYear5
        public decimal LandYear5
        {
            get
            {
                var oldData = LandYear4;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                if (lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES.Length < LandYear_Index + 1)
                    return oldData + 0;
                var inInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_INVESTING_ACTIVITIES[LandYear_Index].Year5;
                var outInvesting = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_INVESTING_ACTIVITIES[LandYear_Index].Year5;
                return oldData + (decimal)(outInvesting - inInvesting);

            }
            set
            {
            }
        }
        #endregion
        #endregion



        #region Less: Accumulated Depreciation
        #region UIText_CURRENT_ASSETS_ACCUMULATED
        
        string _UIText_CURRENT_ASSETS_ACCUMULATED = string.Empty;
        public string UIText_CURRENT_ASSETS_ACCUMULATED
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CURRENT_ASSETS_ACCUMULATED))
                {
                    _UIText_CURRENT_ASSETS_ACCUMULATED = "Less: Accumulated Depreciation:";
                }
                return _UIText_CURRENT_ASSETS_ACCUMULATED;
            }
            set
            {
                if (_UIText_CURRENT_ASSETS_ACCUMULATED != value)
                {
                    _UIText_CURRENT_ASSETS_ACCUMULATED = value;
                    SendPropertyChanged("UIText_CURRENT_ASSETS_ACCUMULATED");
                }
            }
        }
        #endregion

        #region UIText_CURRENT_ASSETS_ACCUMULATED_REFTOPROFIT
        
        string _UIText_CURRENT_ASSETS_ACCUMULATED_REFTOPROFIT = string.Empty;
        /// <summary>
        /// Tu khoa dung de lien ket qua Profit and loss statement...
        /// </summary>
        //public string UIText_CURRENT_ASSETS_ACCUMULATED_REFTOPROFIT
        //{
        //    get
        //    {
        //        if (string.IsNullOrEmpty(_UIText_CURRENT_ASSETS_ACCUMULATED_REFTOPROFIT))
        //        {
        //            _UIText_CURRENT_ASSETS_ACCUMULATED_REFTOPROFIT = "Depreciation";
        //        }
        //        if (_UIText_CURRENT_ASSETS_ACCUMULATED_REFTOPROFIT != null)
        //            _UIText_CURRENT_ASSETS_ACCUMULATED_REFTOPROFIT = _UIText_CURRENT_ASSETS_ACCUMULATED_REFTOPROFIT.Trim();
        //        return _UIText_CURRENT_ASSETS_ACCUMULATED_REFTOPROFIT;
        //    }
        //    set
        //    {
        //        if (_UIText_CURRENT_ASSETS_ACCUMULATED_REFTOPROFIT != value)
        //        {
        //            _UIText_CURRENT_ASSETS_ACCUMULATED_REFTOPROFIT = value;
        //            SendPropertyChanged("UIText_CURRENT_ASSETS_ACCUMULATED_REFTOPROFIT");
        //        }
        //    }
        //}
        #endregion

        #region LessAccumulatedDepreciationYear1
        public decimal LessAccumulatedDepreciationYear1
        {
            get
            {
                var oldData = 0;
                var lProfit = PROFIT_LOSS_STATEMENT;
                if (lProfit == null)
                    return oldData;
                var data = lProfit.GROUP_OPERATINGEXPENSES_Depreciation_Year1;// lProfit.Items_OPERATINGEXPENSES.FirstOrDefault(c => c.Name != null && c.Name.Trim().Equals(_UIText_CURRENT_ASSETS_ACCUMULATED_REFTOPROFIT, StringComparison.CurrentCultureIgnoreCase));                 
                if (data == null)
                    return oldData;
                return oldData + (decimal)data;//.Year1;
            }
            set
            {

            }
        }
        #endregion

        #region LessAccumulatedDepreciationYear2
        public decimal LessAccumulatedDepreciationYear2
        {
            get
            {
                var oldData = LessAccumulatedDepreciationYear1;
                var lProfit = PROFIT_LOSS_STATEMENT;
                if (lProfit == null)
                    return oldData;
                var data = lProfit.GROUP_OPERATINGEXPENSES_Depreciation_Year2;// lProfit.Items_OPERATINGEXPENSES.FirstOrDefault(c => c.Name != null && c.Name.Trim().Equals(_UIText_CURRENT_ASSETS_ACCUMULATED_REFTOPROFIT, StringComparison.CurrentCultureIgnoreCase));
                if (data == null)
                    return oldData;
                return oldData + (decimal)data;//.Year2;
            }
            set
            {

            }
        }
        #endregion

        #region LessAccumulatedDepreciationYear3
        public decimal LessAccumulatedDepreciationYear3
        {
            get
            {
                var oldData = LessAccumulatedDepreciationYear2;
                var lProfit = PROFIT_LOSS_STATEMENT;
                if (lProfit == null)
                    return oldData;
                var data = lProfit.GROUP_OPERATINGEXPENSES_Depreciation_Year3; //lProfit.Items_OPERATINGEXPENSES.FirstOrDefault(c => c.Name != null && c.Name.Trim().Equals(_UIText_CURRENT_ASSETS_ACCUMULATED_REFTOPROFIT, StringComparison.CurrentCultureIgnoreCase));
                if (data == null)
                    return oldData;
                return oldData + (decimal)data;//.Year3;
            }
            set
            {

            }
        }
        #endregion

        #region LessAccumulatedDepreciationYear4
        public decimal LessAccumulatedDepreciationYear4
        {
            get
            {
                var oldData = LessAccumulatedDepreciationYear3;
                var lProfit = PROFIT_LOSS_STATEMENT;
                if (lProfit == null)
                    return oldData;
                var data = lProfit.GROUP_OPERATINGEXPENSES_Depreciation_Year4; //lProfit.Items_OPERATINGEXPENSES.FirstOrDefault(c => c.Name != null && c.Name.Trim().Equals(_UIText_CURRENT_ASSETS_ACCUMULATED_REFTOPROFIT, StringComparison.CurrentCultureIgnoreCase));
                if (data == null)
                    return oldData;
                return oldData + (decimal)data;//.Year4;
            }
            set
            {

            }
        }
        #endregion

        #region LessAccumulatedDepreciationYear5
        public decimal LessAccumulatedDepreciationYear5
        {
            get
            {
                var oldData = LessAccumulatedDepreciationYear4;
                var lProfit = PROFIT_LOSS_STATEMENT;
                if (lProfit == null)
                    return oldData;
                var data = lProfit.GROUP_OPERATINGEXPENSES_Depreciation_Year5; //lProfit.Items_OPERATINGEXPENSES.FirstOrDefault(c => c.Name != null && c.Name.Trim().Equals(_UIText_CURRENT_ASSETS_ACCUMULATED_REFTOPROFIT, StringComparison.CurrentCultureIgnoreCase));
                if (data == null)
                    return oldData;
                return oldData + (decimal)data;//.Year5;
            }
            set
            {

            }
        }
        #endregion

        #endregion

        #region Other Non-Current Assets
        #region UIText_CURRENT_ASSETS_OTHER_NON_CURRENT
        
        string _UIText_CURRENT_ASSETS_OTHER_NON_CURRENT = string.Empty;
        public string UIText_CURRENT_ASSETS_OTHER_NON_CURRENT
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CURRENT_ASSETS_OTHER_NON_CURRENT))
                {
                    _UIText_CURRENT_ASSETS_OTHER_NON_CURRENT = "Other Non-Current Assets:";
                }
                return _UIText_CURRENT_ASSETS_OTHER_NON_CURRENT;
            }
            set
            {
                if (_UIText_CURRENT_ASSETS_OTHER_NON_CURRENT != value)
                {
                    _UIText_CURRENT_ASSETS_OTHER_NON_CURRENT = value;
                    SendPropertyChanged("UIText_CURRENT_ASSETS_OTHER_NON_CURRENT");
                }
            }
        }
        #endregion

        #region OtherNonCurrentAssetsYear1
        decimal _OtherNonCurrentAssetsYear1;
        
        public decimal OtherNonCurrentAssetsYear1
        {
            get
            {
                return _OtherNonCurrentAssetsYear1;
            }
            set
            {
                if (_OtherNonCurrentAssetsYear1 != value)
                {
                    _OtherNonCurrentAssetsYear1 = value;
                    SendPropertyChanged("OtherNonCurrentAssetsYear1");
                    SendPropertyChanged("TotalNonCurrentAssetsYear1");
                    SendPropertyChanged("TotalAssetsYear1");
                }
            }
        }
        #endregion

        #region OtherNonCurrentAssetsYear2
        decimal _OtherNonCurrentAssetsYear2;
        
        public decimal OtherNonCurrentAssetsYear2
        {
            get
            {
                return _OtherNonCurrentAssetsYear2;
            }
            set
            {
                if (_OtherNonCurrentAssetsYear2 != value)
                {
                    _OtherNonCurrentAssetsYear2 = value;
                    SendPropertyChanged("OtherNonCurrentAssetsYear2");
                    SendPropertyChanged("TotalNonCurrentAssetsYear2");
                    SendPropertyChanged("TotalAssetsYear2");
                }
            }
        }
        #endregion

        #region OtherNonCurrentAssetsYear3
        decimal _OtherNonCurrentAssetsYear3;
        
        public decimal OtherNonCurrentAssetsYear3
        {
            get
            {
                return _OtherNonCurrentAssetsYear3;
            }
            set
            {
                if (_OtherNonCurrentAssetsYear3 != value)
                {
                    _OtherNonCurrentAssetsYear3 = value;
                    SendPropertyChanged("OtherNonCurrentAssetsYear3");
                    SendPropertyChanged("TotalNonCurrentAssetsYear3");
                    SendPropertyChanged("TotalAssetsYear3");
                }
            }
        }
        #endregion

        #region OtherNonCurrentAssetsYear4
        decimal _OtherNonCurrentAssetsYear4;
        
        public decimal OtherNonCurrentAssetsYear4
        {
            get
            {
                return _OtherNonCurrentAssetsYear4;
            }
            set
            {
                if (_OtherNonCurrentAssetsYear4 != value)
                {
                    _OtherNonCurrentAssetsYear4 = value;
                    SendPropertyChanged("OtherNonCurrentAssetsYear4");
                    SendPropertyChanged("TotalNonCurrentAssetsYear4");
                    SendPropertyChanged("TotalAssetsYear4");
                }
            }
        }
        #endregion

        #region OtherNonCurrentAssetsYear5
        decimal _OtherNonCurrentAssetsYear5;
        
        public decimal OtherNonCurrentAssetsYear5
        {
            get
            {
                return _OtherNonCurrentAssetsYear5;
            }
            set
            {
                if (_OtherNonCurrentAssetsYear5 != value)
                {
                    _OtherNonCurrentAssetsYear5 = value;
                    SendPropertyChanged("OtherNonCurrentAssetsYear5");
                    SendPropertyChanged("TotalNonCurrentAssetsYear5");
                    SendPropertyChanged("TotalAssetsYear5");
                }
            }
        }
        #endregion
        #endregion

        #region Total Non Current Non Assets
        #region UIText_TOLTAL_NON_CURRENT_ASSETS
        
        string _UIText_TOLTAL_NON_CURRENT_ASSETS = string.Empty;
        public string UIText_TOLTAL_NON_CURRENT_ASSETS
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_TOLTAL_NON_CURRENT_ASSETS))
                {
                    _UIText_TOLTAL_NON_CURRENT_ASSETS = "Total Non-Current Assets:";
                }
                return _UIText_TOLTAL_NON_CURRENT_ASSETS;
            }
            set
            {
                if (_UIText_TOLTAL_NON_CURRENT_ASSETS != value)
                {
                    _UIText_TOLTAL_NON_CURRENT_ASSETS = value;
                    SendPropertyChanged("UIText_TOLTAL_NON_CURRENT_ASSETS");
                }
            }
        }
        #endregion

        #region TotalNonCurrentAssetsYear1


        public decimal TotalNonCurrentAssetsYear1
        {
            get
            {
                //Chu y - LessAccumulatedDepreciationYear1 
                return PropertyPlantEquipmentYear1 + ComputerEquipmentYear1 + MachineryEquipmentYear1 + FurnitureFixturesYear1 + VehiclesYear1 + LandYear1 + BuildingYear1 - LessAccumulatedDepreciationYear1 + OtherNonCurrentAssetsYear1 + LeaseholdImprovementsYear1;
            }

        }
        #endregion

        #region TotalNonCurrentAssetsYear2


        public decimal TotalNonCurrentAssetsYear2
        {
            get
            {
                return PropertyPlantEquipmentYear2 + ComputerEquipmentYear2 + MachineryEquipmentYear2 + FurnitureFixturesYear2 + VehiclesYear2 + LandYear2 + BuildingYear2 - LessAccumulatedDepreciationYear2 + OtherNonCurrentAssetsYear2 + LeaseholdImprovementsYear2;
            }

        }
        #endregion

        #region TotalNonCurrentAssetsYear3


        public decimal TotalNonCurrentAssetsYear3
        {
            get
            {
                return PropertyPlantEquipmentYear3 + ComputerEquipmentYear3 + MachineryEquipmentYear3 + FurnitureFixturesYear3 + VehiclesYear3 + LandYear3 + BuildingYear3 - LessAccumulatedDepreciationYear3 + OtherNonCurrentAssetsYear3 + LeaseholdImprovementsYear3;
            }

        }
        #endregion

        #region TotalNonCurrentAssetsYear4


        public decimal TotalNonCurrentAssetsYear4
        {
            get
            {
                return PropertyPlantEquipmentYear4 + ComputerEquipmentYear4 + MachineryEquipmentYear4 + FurnitureFixturesYear4 + VehiclesYear4 + LandYear4 + BuildingYear4 - LessAccumulatedDepreciationYear4 + OtherNonCurrentAssetsYear4 + LeaseholdImprovementsYear4;
            }

        }
        #endregion

        #region TotalNonCurrentAssetsYear5


        public decimal TotalNonCurrentAssetsYear5
        {
            get
            {
                return PropertyPlantEquipmentYear5 + ComputerEquipmentYear5 + MachineryEquipmentYear5 + FurnitureFixturesYear5 + VehiclesYear5 + LandYear5 + BuildingYear5 - LessAccumulatedDepreciationYear5 + OtherNonCurrentAssetsYear5 + LeaseholdImprovementsYear5;
            }

        }
        #endregion


        #endregion
        #endregion

        #region Current Liabilities

        #region UIText_CURRENT_LIABILITIES
        
        string _UIText_CURRENT_LIABILITIES = string.Empty;
        public string UIText_CURRENT_LIABILITIES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CURRENT_LIABILITIES))
                {
                    _UIText_CURRENT_LIABILITIES = "Current Liabilities:";
                }
                return _UIText_CURRENT_LIABILITIES;
            }
            set
            {
                if (_UIText_CURRENT_LIABILITIES != value)
                {
                    _UIText_CURRENT_LIABILITIES = value;
                    SendPropertyChanged("UIText_CURRENT_LIABILITIES");
                }
            }
        }
        #endregion

        #region Account Payable

        #region UIText_CURRENT_LIABILITIES_ACCOUNT
        
        string _UIText_CURRENT_LIABILITIES_ACCOUNT = string.Empty;
        public string UIText_CURRENT_LIABILITIES_ACCOUNT
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CURRENT_LIABILITIES_ACCOUNT))
                {
                    _UIText_CURRENT_LIABILITIES_ACCOUNT = "Account Payable:";
                }
                return _UIText_CURRENT_LIABILITIES_ACCOUNT;
            }
            set
            {
                if (_UIText_CURRENT_LIABILITIES_ACCOUNT != value)
                {
                    _UIText_CURRENT_LIABILITIES_ACCOUNT = value;
                    SendPropertyChanged("UIText_CURRENT_LIABILITIES_ACCOUNT");
                }
            }
        }
        #endregion

        #region UIText_CURRENT_LIABILITIES_ACCOUNT_REFTOLIQUID
        
        string _UIText_CURRENT_LIABILITIES_ACCOUNT_REFTOLIQUID = string.Empty;
        public string UIText_CURRENT_LIABILITIES_ACCOUNT_REFTOLIQUID
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CURRENT_LIABILITIES_ACCOUNT_REFTOLIQUID))
                {
                    _UIText_CURRENT_LIABILITIES_ACCOUNT_REFTOLIQUID = "raw materials;Interest payments on loans";
                }
                return _UIText_CURRENT_LIABILITIES_ACCOUNT_REFTOLIQUID;
            }
            set
            {
                if (_UIText_CURRENT_LIABILITIES_ACCOUNT_REFTOLIQUID != value)
                {
                    _UIText_CURRENT_LIABILITIES_ACCOUNT_REFTOLIQUID = value;
                    SendPropertyChanged("UIText_CURRENT_LIABILITIES_ACCOUNT_REFTOLIQUID");
                }
            }
        }
        #endregion

        #region AccountPayableYear1
        public decimal AccountPayableYear1
        {
            get
            {
                var oldData = 0;
                var lProfit = PROFIT_LOSS_STATEMENT;
                var lliquid = LIQUIDITYPLAN;
                if (lProfit == null || lliquid == null)
                    return oldData;
                var nLenOPERATINGEXPENSES = lProfit.Items_OPERATINGEXPENSES.Length;
                var dataProfit = (decimal)(lProfit.GROUP_COSTS_Total_Year1 + lProfit.GROUP_OPERATINGEXPENSES_Total_Year1)
                    - (decimal)lProfit.GROUP_OPERATINGEXPENSES_Depreciation_Year1;
                //var dataProfit = (decimal)(
                //    lProfit.Items_OPERATINGEXPENSES[nLenOPERATINGEXPENSES-2].Year1
                //    - lProfit.Items_OPERATINGEXPENSES[nLenOPERATINGEXPENSES - 1].Year1 
                //    + lProfit.GROUP_OPERATINGEXPENSES_Total_Year1);
                var sKeys = UIText_CURRENT_LIABILITIES_ACCOUNT_REFTOLIQUID;
                if (string.IsNullOrEmpty(sKeys))
                    return oldData;
                var keys = sKeys.Split(';').Where(c => c != null).Select(c => c.Trim());
                decimal dataLiquid = 0;
                foreach (var key in keys)
                {
                    var dataLiquid1 = lliquid.Items_GROUP_CASH_OUTFLOW_FROM_OPERATIONS.FirstOrDefault(c => c.Name != null && c.Name.Trim().Equals(key, StringComparison.CurrentCultureIgnoreCase));
                    if (dataLiquid1 == null)
                        dataLiquid1 = lliquid.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.FirstOrDefault(c => c.Name != null && c.Name.Trim().Equals(key, StringComparison.CurrentCultureIgnoreCase));
                    if (dataLiquid1 != null)
                    {
                        dataLiquid += (decimal)dataLiquid1.Year1;
                    }
                }
                dataLiquid += (decimal)lliquid.GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total_Year1;
                return (decimal)(dataProfit - dataLiquid);
            }
            set
            {

            }
        }
        #endregion

        #region AccountPayableYear2
        public decimal AccountPayableYear2
        {
            get
            {
                var oldData = AccountPayableYear1;
                var lProfit = PROFIT_LOSS_STATEMENT;
                var lliquid = LIQUIDITYPLAN;
                if (lProfit == null || lliquid == null)
                    return oldData;
                var nLenOPERATINGEXPENSES = lProfit.Items_OPERATINGEXPENSES.Length;
                var dataProfit = (decimal)(lProfit.GROUP_COSTS_Total_Year2 + lProfit.GROUP_OPERATINGEXPENSES_Total_Year2)
                    - (decimal)lProfit.GROUP_OPERATINGEXPENSES_Depreciation_Year2;
                //var dataProfit = (decimal)(
                //    lProfit.Items_OPERATINGEXPENSES[nLenOPERATINGEXPENSES - 2].Year2
                //    - lProfit.Items_OPERATINGEXPENSES[nLenOPERATINGEXPENSES - 1].Year2
                //    + lProfit.GROUP_OPERATINGEXPENSES_Total_Year2);
                var sKeys = UIText_CURRENT_LIABILITIES_ACCOUNT_REFTOLIQUID;
                if (string.IsNullOrEmpty(sKeys))
                    return oldData;
                var keys = sKeys.Split(';').Where(c => c != null).Select(c => c.Trim());
                decimal dataLiquid = 0;
                foreach (var key in keys)
                {
                    var dataLiquid1 = lliquid.Items_GROUP_CASH_OUTFLOW_FROM_OPERATIONS.FirstOrDefault(c => c.Name != null && c.Name.Trim().Equals(key, StringComparison.CurrentCultureIgnoreCase));
                    if (dataLiquid1 == null)
                        dataLiquid1 = lliquid.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.FirstOrDefault(c => c.Name != null && c.Name.Trim().Equals(key, StringComparison.CurrentCultureIgnoreCase));
                    if (dataLiquid1 != null)
                    {
                        dataLiquid += (decimal)dataLiquid1.Year2;
                    }
                }
                dataLiquid += (decimal)lliquid.GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total_Year2;
                //dataLiquid += (decimal)lliquid.GROUP_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE_Total_Year2;
                return (decimal)(oldData + dataProfit - dataLiquid);
            }
            set
            {

            }
        }
        #endregion

        #region AccountPayableYear3
        public decimal AccountPayableYear3
        {
            get
            {
                var oldData = AccountPayableYear2;
                var lProfit = PROFIT_LOSS_STATEMENT;
                var lliquid = LIQUIDITYPLAN;
                if (lProfit == null || lliquid == null)
                    return oldData;
                var nLenOPERATINGEXPENSES = lProfit.Items_OPERATINGEXPENSES.Length;
                var dataProfit = (decimal)(lProfit.GROUP_COSTS_Total_Year3 + lProfit.GROUP_OPERATINGEXPENSES_Total_Year3)
                    - (decimal)lProfit.GROUP_OPERATINGEXPENSES_Depreciation_Year3;
                //var dataProfit = (decimal)(
                //    lProfit.Items_OPERATINGEXPENSES[nLenOPERATINGEXPENSES - 2].Year3
                //    - lProfit.Items_OPERATINGEXPENSES[nLenOPERATINGEXPENSES - 1].Year3
                //    + lProfit.GROUP_OPERATINGEXPENSES_Total_Year3);

                var sKeys = UIText_CURRENT_LIABILITIES_ACCOUNT_REFTOLIQUID;
                if (string.IsNullOrEmpty(sKeys))
                    return oldData;
                var keys = sKeys.Split(';').Where(c => c != null).Select(c => c.Trim());
                decimal dataLiquid = 0;
                foreach (var key in keys)
                {
                    var dataLiquid1 = lliquid.Items_GROUP_CASH_OUTFLOW_FROM_OPERATIONS.FirstOrDefault(c => c.Name != null && c.Name.Trim().Equals(key, StringComparison.CurrentCultureIgnoreCase));
                    if (dataLiquid1 == null)
                        dataLiquid1 = lliquid.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.FirstOrDefault(c => c.Name != null && c.Name.Trim().Equals(key, StringComparison.CurrentCultureIgnoreCase));
                    if (dataLiquid1 != null)
                    {
                        dataLiquid += (decimal)dataLiquid1.Year3;
                    }
                }
                dataLiquid += (decimal)lliquid.GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total_Year3;
                //dataLiquid += (decimal)lliquid.GROUP_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE_Total_Year3;
                return (decimal)(oldData + dataProfit - dataLiquid);
            }
            set
            {

            }
        }
        #endregion

        #region AccountPayableYear4
        public decimal AccountPayableYear4
        {
            get
            {
                var oldData = AccountPayableYear3;
                var lProfit = PROFIT_LOSS_STATEMENT;
                var lliquid = LIQUIDITYPLAN;
                if (lProfit == null || lliquid == null)
                    return oldData;
                var nLenOPERATINGEXPENSES = lProfit.Items_OPERATINGEXPENSES.Length;
                var dataProfit = (decimal)(lProfit.GROUP_COSTS_Total_Year4 + lProfit.GROUP_OPERATINGEXPENSES_Total_Year4)
                    - (decimal)lProfit.GROUP_OPERATINGEXPENSES_Depreciation_Year4;
                //var dataProfit = (decimal)(
                //    lProfit.Items_OPERATINGEXPENSES[nLenOPERATINGEXPENSES - 2].Year4
                //    - lProfit.Items_OPERATINGEXPENSES[nLenOPERATINGEXPENSES - 1].Year4
                //    + lProfit.GROUP_OPERATINGEXPENSES_Total_Year4);

                var sKeys = UIText_CURRENT_LIABILITIES_ACCOUNT_REFTOLIQUID;
                if (string.IsNullOrEmpty(sKeys))
                    return oldData;
                var keys = sKeys.Split(';').Where(c => c != null).Select(c => c.Trim());
                decimal dataLiquid = 0;
                foreach (var key in keys)
                {
                    var dataLiquid1 = lliquid.Items_GROUP_CASH_OUTFLOW_FROM_OPERATIONS.FirstOrDefault(c => c.Name != null && c.Name.Trim().Equals(key, StringComparison.CurrentCultureIgnoreCase));
                    if (dataLiquid1 == null)
                        dataLiquid1 = lliquid.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.FirstOrDefault(c => c.Name != null && c.Name.Trim().Equals(key, StringComparison.CurrentCultureIgnoreCase));
                    if (dataLiquid1 != null)
                    {
                        dataLiquid += (decimal)dataLiquid1.Year4;
                    }
                }
                dataLiquid += (decimal)lliquid.GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total_Year4;
                //dataLiquid += (decimal)lliquid.GROUP_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE_Total_Year4;
                return (decimal)(oldData + dataProfit - dataLiquid);
            }
            set
            {

            }
        }
        #endregion

        #region AccountPayableYear5
        public decimal AccountPayableYear5
        {
            get
            {
                var oldData = AccountPayableYear4;
                var lProfit = PROFIT_LOSS_STATEMENT;
                var lliquid = LIQUIDITYPLAN;
                if (lProfit == null || lliquid == null)
                    return oldData;
                var nLenOPERATINGEXPENSES = lProfit.Items_OPERATINGEXPENSES.Length;
                var dataProfit = (decimal)(lProfit.GROUP_COSTS_Total_Year5 + lProfit.GROUP_OPERATINGEXPENSES_Total_Year5)
                    - (decimal)lProfit.GROUP_OPERATINGEXPENSES_Depreciation_Year5;
                //var dataProfit = (decimal)(
                //    lProfit.Items_OPERATINGEXPENSES[nLenOPERATINGEXPENSES - 2].Year5
                //    - lProfit.Items_OPERATINGEXPENSES[nLenOPERATINGEXPENSES - 1].Year5
                //    + lProfit.GROUP_OPERATINGEXPENSES_Total_Year5);

                var sKeys = UIText_CURRENT_LIABILITIES_ACCOUNT_REFTOLIQUID;
                if (string.IsNullOrEmpty(sKeys))
                    return oldData;
                var keys = sKeys.Split(';').Where(c => c != null).Select(c => c.Trim());
                decimal dataLiquid = 0;
                foreach (var key in keys)
                {
                    var dataLiquid1 = lliquid.Items_GROUP_CASH_OUTFLOW_FROM_OPERATIONS.FirstOrDefault(c => c.Name != null && c.Name.Trim().Equals(key, StringComparison.CurrentCultureIgnoreCase));
                    if (dataLiquid1 == null)
                        dataLiquid1 = lliquid.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.FirstOrDefault(c => c.Name != null && c.Name.Trim().Equals(key, StringComparison.CurrentCultureIgnoreCase));
                    if (dataLiquid1 != null)
                    {
                        dataLiquid += (decimal)dataLiquid1.Year5;
                    }
                }
                dataLiquid += (decimal)lliquid.GROUP_CASH_OUTFLOW_FROM_OPERATIONS_Total_Year5;
                //dataLiquid += (decimal)lliquid.GROUP_CASH_ABUNDANCE_POSITIVE_NEED_FOR_CASH_NEGATIVE_Total_Year5;
                return (decimal)(oldData + dataProfit - dataLiquid);
            }
            set
            {

            }
        }
        #endregion
        #endregion

        #region Other Current Liabilities
        #region UIText_CURRENT_LIABILITIES_OTHER
        
        string _UIText_CURRENT_LIABILITIES_OTHER = string.Empty;
        public string UIText_CURRENT_LIABILITIES_OTHER
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CURRENT_LIABILITIES_OTHER))
                {
                    _UIText_CURRENT_LIABILITIES_OTHER = "Other Current Liabilities:";
                }
                return _UIText_CURRENT_LIABILITIES_OTHER;
            }
            set
            {
                if (_UIText_CURRENT_LIABILITIES_OTHER != value)
                {
                    _UIText_CURRENT_LIABILITIES_OTHER = value;
                    SendPropertyChanged("UIText_CURRENT_LIABILITIES_OTHER");
                }
            }
        }
        #endregion

        #region OtherCurrentLiabilitiesYear1
        decimal _OtherCurrentLiabilitiesYear1;
        
        public decimal OtherCurrentLiabilitiesYear1
        {
            get
            {
                return _OtherCurrentLiabilitiesYear1;
            }
            set
            {
                if (_OtherCurrentLiabilitiesYear1 != value)
                {
                    _OtherCurrentLiabilitiesYear1 = value;
                    SendPropertyChanged("OtherCurrentLiabilitiesYear1");
                    SendPropertyChanged("TotalCurrentLiabilitiesYear1");
                    SendPropertyChanged("TotalLiabilitiesYear1");
                    SendPropertyChanged("TotalEquityLiabilitiesYear1");
                }
            }
        }
        #endregion

        #region OtherCurrentLiabilitiesYear2
        decimal _OtherCurrentLiabilitiesYear2;
        
        public decimal OtherCurrentLiabilitiesYear2
        {
            get
            {
                return _OtherCurrentLiabilitiesYear2;
            }
            set
            {
                if (_OtherCurrentLiabilitiesYear2 != value)
                {
                    _OtherCurrentLiabilitiesYear2 = value;
                    SendPropertyChanged("OtherCurrentLiabilitiesYear2");
                    SendPropertyChanged("TotalCurrentLiabilitiesYear2");
                    SendPropertyChanged("TotalLiabilitiesYear2");
                    SendPropertyChanged("TotalEquityLiabilitiesYear2");
                }
            }
        }
        #endregion

        #region OtherCurrentLiabilitiesYear3
        decimal _OtherCurrentLiabilitiesYear3;
        
        public decimal OtherCurrentLiabilitiesYear3
        {
            get
            {
                return _OtherCurrentLiabilitiesYear3;
            }
            set
            {
                if (_OtherCurrentLiabilitiesYear3 != value)
                {
                    _OtherCurrentLiabilitiesYear3 = value;
                    SendPropertyChanged("OtherCurrentLiabilitiesYear3");
                    SendPropertyChanged("TotalCurrentLiabilitiesYear3");
                    SendPropertyChanged("TotalLiabilitiesYear3");
                    SendPropertyChanged("TotalEquityLiabilitiesYear3");
                }
            }
        }
        #endregion

        #region OtherCurrentLiabilitiesYear4
        decimal _OtherCurrentLiabilitiesYear4;
        
        public decimal OtherCurrentLiabilitiesYear4
        {
            get
            {
                return _OtherCurrentLiabilitiesYear4;
            }
            set
            {
                if (_OtherCurrentLiabilitiesYear4 != value)
                {
                    _OtherCurrentLiabilitiesYear4 = value;
                    SendPropertyChanged("OtherCurrentLiabilitiesYear4");
                    SendPropertyChanged("TotalCurrentLiabilitiesYear4");
                    SendPropertyChanged("TotalLiabilitiesYear4");
                    SendPropertyChanged("TotalEquityLiabilitiesYear4");
                }
            }
        }
        #endregion

        #region OtherCurrentLiabilitiesYear5
        decimal _OtherCurrentLiabilitiesYear5;
        
        public decimal OtherCurrentLiabilitiesYear5
        {
            get
            {
                return _OtherCurrentLiabilitiesYear5;
            }
            set
            {
                if (_OtherCurrentLiabilitiesYear5 != value)
                {
                    _OtherCurrentLiabilitiesYear5 = value;
                    SendPropertyChanged("OtherCurrentLiabilitiesYear5");
                    SendPropertyChanged("TotalCurrentLiabilitiesYear5");
                    SendPropertyChanged("TotalLiabilitiesYear5");
                    SendPropertyChanged("TotalEquityLiabilitiesYear5");
                }
            }
        }
        #endregion
        #endregion

        #region Line of Credit
        public int LineOfCreditYear_Index
        {
            get { return 0; }
        }
        #region UIText_CURRENT_LIABILITIES_LINE_CREDIT
        
        string _UIText_CURRENT_LIABILITIES_LINE_CREDIT = string.Empty;
        public string UIText_CURRENT_LIABILITIES_LINE_CREDIT
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CURRENT_LIABILITIES_LINE_CREDIT))
                {
                    _UIText_CURRENT_LIABILITIES_LINE_CREDIT = "Line of Credit:";
                }
                return _UIText_CURRENT_LIABILITIES_LINE_CREDIT;
            }
            set
            {
                if (_UIText_CURRENT_LIABILITIES_LINE_CREDIT != value)
                {
                    _UIText_CURRENT_LIABILITIES_LINE_CREDIT = value;
                    SendPropertyChanged("UIText_CURRENT_LIABILITIES_LINE_CREDIT");
                }
            }
        }
        #endregion

        #region LineOfCreditYear1
        public decimal LineOfCreditYear1
        {
            get
            {
                var oldData = 0;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                var infinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Length < (LineOfCreditYear_Index + 1) ? 0 :
                    lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES[LineOfCreditYear_Index].Year1;
                var outfinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Length < (LineOfCreditYear_Index + 1) ? 0 :
                    LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES[LineOfCreditYear_Index].Year1;
                return oldData + (decimal)(infinancing - outfinancing);
            }
            set { }
        }
        #endregion

        #region LineOfCreditYear2
        public decimal LineOfCreditYear2
        {
            get
            {
                var oldData = LineOfCreditYear1;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                var infinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Length < (LineOfCreditYear_Index + 1) ? 0 :
                    lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES[LineOfCreditYear_Index].Year2;
                var outfinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Length < (LineOfCreditYear_Index + 1) ? 0 :
                    LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES[LineOfCreditYear_Index].Year2;
                return oldData + (decimal)(infinancing - outfinancing);
            }
            set
            {
            }
        }
        #endregion

        #region LineOfCreditYear3
        public decimal LineOfCreditYear3
        {
            get
            {
                var oldData = LineOfCreditYear2;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                var infinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Length < (LineOfCreditYear_Index + 1) ? 0 :
                    lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES[LineOfCreditYear_Index].Year3;
                var outfinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Length < (LineOfCreditYear_Index + 1) ? 0 :
                    LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES[LineOfCreditYear_Index].Year3;
                return oldData + (decimal)(infinancing - outfinancing);
            }
            set
            {

            }
        }
        #endregion

        #region LineOfCreditYear4
        public decimal LineOfCreditYear4
        {
            get
            {
                var oldData = LineOfCreditYear3;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                var infinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Length < (LineOfCreditYear_Index + 1) ? 0 :
                    lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES[LineOfCreditYear_Index].Year4;
                var outfinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Length < (LineOfCreditYear_Index + 1) ? 0 :
                    LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES[LineOfCreditYear_Index].Year4;
                return oldData + (decimal)(infinancing - outfinancing);
            }
            set
            {
            }
        }
        #endregion

        #region LineOfCreditYear5
        decimal _LineOfCreditYear5;
        public decimal LineOfCreditYear5
        {
            get
            {
                var oldData = LineOfCreditYear4;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                var infinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Length < (LineOfCreditYear_Index + 1) ? 0 :
                    lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES[LineOfCreditYear_Index].Year5;
                var outfinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Length < (LineOfCreditYear_Index + 1) ? 0 :
                    LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES[LineOfCreditYear_Index].Year5;
                return oldData + (decimal)(infinancing - outfinancing);
            }
            set
            {
            }
        }
        #endregion

        #endregion

        #region Total Current Liabilities
        #region UIText_TOLTAL_CURRENT_LIABILITIES
        
        string _UIText_TOLTAL_CURRENT_LIABILITIES = string.Empty;
        public string UIText_TOLTAL_CURRENT_LIABILITIES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_TOLTAL_CURRENT_LIABILITIES))
                {
                    _UIText_TOLTAL_CURRENT_LIABILITIES = "Total Current Liabilities:";
                }
                return _UIText_TOLTAL_CURRENT_LIABILITIES;
            }
            set
            {
                if (_UIText_TOLTAL_CURRENT_LIABILITIES != value)
                {
                    _UIText_TOLTAL_CURRENT_LIABILITIES = value;
                    SendPropertyChanged("UIText_TOLTAL_CURRENT_LIABILITIES");
                }
            }
        }
        #endregion

        #region TotalCurrentLiabilitiesYear1


        public decimal TotalCurrentLiabilitiesYear1
        {
            get
            {
                return AccountPayableYear1 + LineOfCreditYear1 + OtherCurrentLiabilitiesYear1;
            }

        }
        #endregion

        #region TotalCurrentLiabilitiesYear2


        public decimal TotalCurrentLiabilitiesYear2
        {
            get
            {
                return AccountPayableYear2 + LineOfCreditYear2 + OtherCurrentLiabilitiesYear2;
            }

        }
        #endregion

        #region TotalCurrentLiabilitiesYear3


        public decimal TotalCurrentLiabilitiesYear3
        {
            get
            {
                return AccountPayableYear3 + LineOfCreditYear3 + OtherCurrentLiabilitiesYear3;
            }

        }
        #endregion

        #region TotalCurrentLiabilitiesYear4


        public decimal TotalCurrentLiabilitiesYear4
        {
            get
            {
                return AccountPayableYear4 + LineOfCreditYear4 + OtherCurrentLiabilitiesYear4;
            }

        }
        #endregion

        #region TotalCurrentLiabilitiesYear5


        public decimal TotalCurrentLiabilitiesYear5
        {
            get
            {
                return AccountPayableYear5 + LineOfCreditYear5 + OtherCurrentLiabilitiesYear5;
            }

        }
        #endregion

        #endregion
        #endregion

        #region Long-term Liabilities
        #region UIText_LONG_TERM_LIABILITIES
        
        string _UIText_LONG_TERM_LIABILITIES = string.Empty;
        public string UIText_LONG_TERM_LIABILITIES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_LONG_TERM_LIABILITIES))
                {
                    _UIText_LONG_TERM_LIABILITIES = "Long-term Liabilities:";
                }
                return _UIText_LONG_TERM_LIABILITIES;
            }
            set
            {
                if (_UIText_LONG_TERM_LIABILITIES != value)
                {
                    _UIText_LONG_TERM_LIABILITIES = value;
                    SendPropertyChanged("UIText_LONG_TERM_LIABILITIES");
                }
            }
        }
        #endregion

        #region Loans
        public int LoansYear_Index
        {
            get { return 1; }
        }

        #region UIText_LONG_TERM_LIABILITIES_LOANS
        
        string _UIText_LONG_TERM_LIABILITIES_LOANS = string.Empty;
        public string UIText_LONG_TERM_LIABILITIES_LOANS
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_LONG_TERM_LIABILITIES_LOANS))
                {
                    _UIText_LONG_TERM_LIABILITIES_LOANS = "Loans:";
                }
                return _UIText_LONG_TERM_LIABILITIES_LOANS;
            }
            set
            {
                if (_UIText_LONG_TERM_LIABILITIES_LOANS != value)
                {
                    _UIText_LONG_TERM_LIABILITIES_LOANS = value;
                    SendPropertyChanged("UIText_LONG_TERM_LIABILITIES_LOANS");
                }
            }
        }
        #endregion

        #region LoansYear1
        public decimal LoansYear1
        {
            get
            {
                var oldData = 0;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                var infinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Length < (LoansYear_Index + 1) ? 0 :
                    lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES[LoansYear_Index].Year1;
                var outfinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Length < (LoansYear_Index + 1) ? 0 :
                    LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES[LoansYear_Index].Year1;
                return oldData + (decimal)(infinancing - outfinancing);
            }
            set { }
        }
        #endregion

        #region LoansYear2
        public decimal LoansYear2
        {
            get
            {
                var oldData = LoansYear1;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                var infinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Length < (LoansYear_Index + 1) ? 0 :
                    lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES[LoansYear_Index].Year2;
                var outfinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Length < (LoansYear_Index + 1) ? 0 :
                    LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES[LoansYear_Index].Year2;
                return oldData + (decimal)(infinancing - outfinancing);
            }
            set
            {
            }
        }
        #endregion

        #region LoansYear3
        public decimal LoansYear3
        {
            get
            {
                var oldData = LoansYear2;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                var infinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Length < (LoansYear_Index + 1) ? 0 :
                    lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES[LoansYear_Index].Year3;
                var outfinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Length < (LoansYear_Index + 1) ? 0 :
                    LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES[LoansYear_Index].Year3;
                return oldData + (decimal)(infinancing - outfinancing);
            }
            set
            {

            }
        }
        #endregion

        #region LoansYear4
        public decimal LoansYear4
        {
            get
            {
                var oldData = LoansYear3;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                var infinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Length < (LoansYear_Index + 1) ? 0 :
                    lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES[LoansYear_Index].Year4;
                var outfinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Length < (LoansYear_Index + 1) ? 0 :
                    LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES[LoansYear_Index].Year4;
                return oldData + (decimal)(infinancing - outfinancing);
            }
            set
            {
            }
        }
        #endregion

        #region LoansYear5
        decimal _LoansYear5;
        public decimal LoansYear5
        {
            get
            {
                var oldData = LoansYear4;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                var infinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Length < (LoansYear_Index + 1) ? 0 :
                    lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES[LoansYear_Index].Year5;
                var outfinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Length < (LoansYear_Index + 1) ? 0 :
                    LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES[LoansYear_Index].Year5;
                return oldData + (decimal)(infinancing - outfinancing);
            }
            set
            {
            }
        }
        #endregion

        #endregion

        #region Real Estate Loans

        public int RealEstateLoansYear_Index
        {
            get { return 2; }
        }


        #region UIText_LONG_TERM_LIABILITIES_REAL_ESTATE
        
        string _UIText_LONG_TERM_LIABILITIES_REAL_ESTATE = string.Empty;
        public string UIText_LONG_TERM_LIABILITIES_REAL_ESTATE
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_LONG_TERM_LIABILITIES_REAL_ESTATE))
                {
                    _UIText_LONG_TERM_LIABILITIES_REAL_ESTATE = "Real Estate Loans:";
                }
                return _UIText_LONG_TERM_LIABILITIES_REAL_ESTATE;
            }
            set
            {
                if (_UIText_LONG_TERM_LIABILITIES_REAL_ESTATE != value)
                {
                    _UIText_LONG_TERM_LIABILITIES_REAL_ESTATE = value;
                    SendPropertyChanged("UIText_LONG_TERM_LIABILITIES_REAL_ESTATE");
                }
            }
        }
        #endregion

        #region RealEstateLoansYear1
        public decimal RealEstateLoansYear1
        {
            get
            {
                var oldData = 0;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                var infinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Length < (RealEstateLoansYear_Index + 1) ? 0 :
                    lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES[RealEstateLoansYear_Index].Year1;
                var outfinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Length < (RealEstateLoansYear_Index + 1) ? 0 :
                    LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES[RealEstateLoansYear_Index].Year1;
                return oldData + (decimal)(infinancing - outfinancing);
            }
            set { }
        }
        #endregion

        #region RealEstateLoansYear2
        public decimal RealEstateLoansYear2
        {
            get
            {
                var oldData = RealEstateLoansYear1;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                var infinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Length < (RealEstateLoansYear_Index + 1) ? 0 :
                    lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES[RealEstateLoansYear_Index].Year2;
                var outfinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Length < (RealEstateLoansYear_Index + 1) ? 0 :
                    LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES[RealEstateLoansYear_Index].Year2;
                return oldData + (decimal)(infinancing - outfinancing);
            }
            set
            {
            }
        }
        #endregion

        #region RealEstateLoansYear3
        public decimal RealEstateLoansYear3
        {
            get
            {
                var oldData = RealEstateLoansYear2;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                var infinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Length < (RealEstateLoansYear_Index + 1) ? 0 :
                    lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES[RealEstateLoansYear_Index].Year3;
                var outfinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Length < (RealEstateLoansYear_Index + 1) ? 0 :
                    LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES[RealEstateLoansYear_Index].Year3;
                return oldData + (decimal)(infinancing - outfinancing);
            }
            set
            {

            }
        }
        #endregion

        #region RealEstateLoansYear4
        public decimal RealEstateLoansYear4
        {
            get
            {
                var oldData = RealEstateLoansYear3;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                var infinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Length < (RealEstateLoansYear_Index + 1) ? 0 :
                    lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES[RealEstateLoansYear_Index].Year4;
                var outfinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Length < (RealEstateLoansYear_Index + 1) ? 0 :
                    LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES[RealEstateLoansYear_Index].Year4;
                return oldData + (decimal)(infinancing - outfinancing);
            }
            set
            {
            }
        }
        #endregion

        #region RealEstateLoansYear5
        decimal _RealEstateLoansYear5;
        public decimal RealEstateLoansYear5
        {
            get
            {
                var oldData = RealEstateLoansYear4;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                var infinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Length < (RealEstateLoansYear_Index + 1) ? 0 :
                    lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES[RealEstateLoansYear_Index].Year5;
                var outfinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Length < (RealEstateLoansYear_Index + 1) ? 0 :
                    LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES[RealEstateLoansYear_Index].Year5;
                return oldData + (decimal)(infinancing - outfinancing);
            }
            set
            {
            }
        }
        #endregion

        #endregion

        #region ShareholderLoan
        public int ShareholderLoanYear_Index
        {
            get { return 3; }
        }

        #region UIText_LONG_TERM_LIABILITIES_SHAREHOLDERLOAN
        
        string _UIText_LONG_TERM_LIABILITIES_SHAREHOLDERLOAN = string.Empty;
        public string UIText_LONG_TERM_LIABILITIES_SHAREHOLDERLOAN
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_LONG_TERM_LIABILITIES_SHAREHOLDERLOAN))
                {
                    _UIText_LONG_TERM_LIABILITIES_SHAREHOLDERLOAN = "Shareholder loan";
                }
                return _UIText_LONG_TERM_LIABILITIES_SHAREHOLDERLOAN;
            }
            set
            {
                if (_UIText_LONG_TERM_LIABILITIES_SHAREHOLDERLOAN != value)
                {
                    _UIText_LONG_TERM_LIABILITIES_SHAREHOLDERLOAN = value;
                    SendPropertyChanged("UIText_LONG_TERM_LIABILITIES_SHAREHOLDERLOAN ");
                }
            }
        }
        #endregion

        #region ShareholderLoanYear1
        public decimal ShareholderLoanYear1
        {
            get
            {
                var oldData = 0;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                var infinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Length < (ShareholderLoanYear_Index + 1) ? 0 :
                    lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES[ShareholderLoanYear_Index].Year1;
                var outfinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Length < (ShareholderLoanYear_Index + 1) ? 0 :
                    LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES[ShareholderLoanYear_Index].Year1;
                return oldData + (decimal)(infinancing - outfinancing);
            }
            set { }
        }
        #endregion

        #region ShareholderLoanYear2
        public decimal ShareholderLoanYear2
        {
            get
            {
                var oldData = ShareholderLoanYear1;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                var infinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Length < (ShareholderLoanYear_Index + 1) ? 0 :
                    lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES[ShareholderLoanYear_Index].Year2;
                var outfinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Length < (ShareholderLoanYear_Index + 1) ? 0 :
                    LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES[ShareholderLoanYear_Index].Year2;
                return oldData + (decimal)(infinancing - outfinancing);
            }
            set
            {
            }
        }
        #endregion

        #region ShareholderLoanYear3
        public decimal ShareholderLoanYear3
        {
            get
            {
                var oldData = ShareholderLoanYear2;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                var infinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Length < (ShareholderLoanYear_Index + 1) ? 0 :
                    lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES[ShareholderLoanYear_Index].Year3;
                var outfinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Length < (ShareholderLoanYear_Index + 1) ? 0 :
                    LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES[ShareholderLoanYear_Index].Year3;
                return oldData + (decimal)(infinancing - outfinancing);
            }
            set
            {

            }
        }
        #endregion

        #region ShareholderLoanYear4
        public decimal ShareholderLoanYear4
        {
            get
            {
                var oldData = ShareholderLoanYear3;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                var infinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Length < (ShareholderLoanYear_Index + 1) ? 0 :
                    lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES[ShareholderLoanYear_Index].Year4;
                var outfinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Length < (ShareholderLoanYear_Index + 1) ? 0 :
                    LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES[ShareholderLoanYear_Index].Year4;
                return oldData + (decimal)(infinancing - outfinancing);
            }
            set
            {
            }
        }
        #endregion

        #region ShareholderLoanYear5
        public decimal ShareholderLoanYear5
        {
            get
            {
                var oldData = ShareholderLoanYear4;
                var lLIQUIDITYPLAN = LIQUIDITYPLAN;
                if (lLIQUIDITYPLAN == null)
                    return oldData + 0;
                var infinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.Length < (ShareholderLoanYear_Index + 1) ? 0 :
                    lLIQUIDITYPLAN.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES[ShareholderLoanYear_Index].Year5;
                var outfinancing = lLIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Length < (ShareholderLoanYear_Index + 1) ? 0 :
                    LIQUIDITYPLAN.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES[ShareholderLoanYear_Index].Year5;
                return oldData + (decimal)(infinancing - outfinancing);
            }
            set
            {
            }
        }
        #endregion

        #endregion

        #region Other Non-Current Liabilities
        #region UIText_LONG_TERM_LIABILITIES_OTHER
        
        string _UIText_LONG_TERM_LIABILITIES_OTHER = string.Empty;
        public string UIText_LONG_TERM_LIABILITIES_OTHER
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_LONG_TERM_LIABILITIES_OTHER))
                {
                    _UIText_LONG_TERM_LIABILITIES_OTHER = "Other Non-Current Liabilities:";
                }
                return _UIText_LONG_TERM_LIABILITIES_OTHER;
            }
            set
            {
                if (_UIText_LONG_TERM_LIABILITIES_OTHER != value)
                {
                    _UIText_LONG_TERM_LIABILITIES_OTHER = value;
                    SendPropertyChanged("UIText_LONG_TERM_LIABILITIES_OTHER");
                }
            }
        }
        #endregion

        #region OtherNonCurrentLiabilitiesYear1
        decimal _OtherNonCurrentLiabilitiesYear1;
        
        public decimal OtherNonCurrentLiabilitiesYear1
        {
            get
            {
                return _OtherNonCurrentLiabilitiesYear1;
            }
            set
            {
                if (_OtherNonCurrentLiabilitiesYear1 != value)
                {
                    _OtherNonCurrentLiabilitiesYear1 = value;
                    SendPropertyChanged("OtherNonCurrentLiabilitiesYear1");
                    SendPropertyChanged("TotalLongTermLiabilitiesYear1");
                    SendPropertyChanged("TotalLiabilitiesYear1");
                    SendPropertyChanged("TotalEquityLiabilitiesYear1");
                }
            }
        }
        #endregion

        #region OtherNonCurrentLiabilitiesYear2
        decimal _OtherNonCurrentLiabilitiesYear2;
        
        public decimal OtherNonCurrentLiabilitiesYear2
        {
            get
            {
                return _OtherNonCurrentLiabilitiesYear2;
            }
            set
            {
                if (_OtherNonCurrentLiabilitiesYear2 != value)
                {
                    _OtherNonCurrentLiabilitiesYear2 = value;
                    SendPropertyChanged("OtherNonCurrentLiabilitiesYear2");
                    SendPropertyChanged("TotalLongTermLiabilitiesYear2");
                    SendPropertyChanged("TotalLiabilitiesYear2");
                    SendPropertyChanged("TotalEquityLiabilitiesYear2");
                }
            }
        }
        #endregion

        #region OtherNonCurrentLiabilitiesYear3
        decimal _OtherNonCurrentLiabilitiesYear3;
        
        public decimal OtherNonCurrentLiabilitiesYear3
        {
            get
            {
                return _OtherNonCurrentLiabilitiesYear3;
            }
            set
            {
                if (_OtherNonCurrentLiabilitiesYear3 != value)
                {
                    _OtherNonCurrentLiabilitiesYear3 = value;
                    SendPropertyChanged("OtherNonCurrentLiabilitiesYear3");
                    SendPropertyChanged("TotalLongTermLiabilitiesYear3");
                    SendPropertyChanged("TotalLiabilitiesYear3");
                    SendPropertyChanged("TotalEquityLiabilitiesYear3");
                }
            }
        }
        #endregion

        #region OtherNonCurrentLiabilitiesYear4
        decimal _OtherNonCurrentLiabilitiesYear4;
        
        public decimal OtherNonCurrentLiabilitiesYear4
        {
            get
            {
                return _OtherNonCurrentLiabilitiesYear4;
            }
            set
            {
                if (_OtherNonCurrentLiabilitiesYear4 != value)
                {
                    _OtherNonCurrentLiabilitiesYear4 = value;
                    SendPropertyChanged("OtherNonCurrentLiabilitiesYear4");
                    SendPropertyChanged("TotalLongTermLiabilitiesYear4");
                    SendPropertyChanged("TotalLiabilitiesYear4");
                    SendPropertyChanged("TotalEquityLiabilitiesYear4");
                }
            }
        }
        #endregion

        #region OtherNonCurrentLiabilitiesYear5
        decimal _OtherNonCurrentLiabilitiesYear5;
        
        public decimal OtherNonCurrentLiabilitiesYear5
        {
            get
            {
                return _OtherNonCurrentLiabilitiesYear5;
            }
            set
            {
                if (_OtherNonCurrentLiabilitiesYear5 != value)
                {
                    _OtherNonCurrentLiabilitiesYear5 = value;
                    SendPropertyChanged("OtherNonCurrentLiabilitiesYear5");
                    SendPropertyChanged("TotalLongTermLiabilitiesYear5");
                    SendPropertyChanged("TotalLiabilitiesYear5");
                    SendPropertyChanged("TotalEquityLiabilitiesYear5");
                }
            }
        }
        #endregion
        #endregion

        #region Total Long-term Liabilities
        #region UIText_TOLTAL_LONG_TERM_LIABILITIES
        
        string _UIText_TOLTAL_LONG_TERM_LIABILITIES = string.Empty;
        public string UIText_TOLTAL_LONG_TERM_LIABILITIES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_TOLTAL_LONG_TERM_LIABILITIES))
                {
                    _UIText_TOLTAL_LONG_TERM_LIABILITIES = "Total Long-term Liabilities:";
                }
                return _UIText_TOLTAL_LONG_TERM_LIABILITIES;
            }
            set
            {
                if (_UIText_TOLTAL_LONG_TERM_LIABILITIES != value)
                {
                    _UIText_TOLTAL_LONG_TERM_LIABILITIES = value;
                    SendPropertyChanged("UIText_TOLTAL_LONG_TERM_LIABILITIES");
                }
            }
        }
        #endregion

        #region TotalLongTermLiabilitiesYear1


        public decimal TotalLongTermLiabilitiesYear1
        {
            get
            {
                return LoansYear1 + RealEstateLoansYear1 + ShareholderLoanYear1 + OtherNonCurrentLiabilitiesYear1;
            }

        }

        #endregion

        #region TotalLongTermLiabilitiesYear2


        public decimal TotalLongTermLiabilitiesYear2
        {
            get
            {
                return LoansYear2 + RealEstateLoansYear2 + ShareholderLoanYear2 + OtherNonCurrentLiabilitiesYear2;
            }

        }

        #endregion
        #region TotalLongTermLiabilitiesYear3


        public decimal TotalLongTermLiabilitiesYear3
        {
            get
            {
                return LoansYear3 + RealEstateLoansYear3 + ShareholderLoanYear3 + OtherNonCurrentLiabilitiesYear3;
            }

        }

        #endregion
        #region TotalLongTermLiabilitiesYear4


        public decimal TotalLongTermLiabilitiesYear4
        {
            get
            {
                return LoansYear4 + RealEstateLoansYear4 + ShareholderLoanYear4 + OtherNonCurrentLiabilitiesYear4;
            }

        }

        #endregion
        #region TotalLongTermLiabilitiesYear5


        public decimal TotalLongTermLiabilitiesYear5
        {
            get
            {
                return LoansYear5 + RealEstateLoansYear5 + ShareholderLoanYear5 + OtherNonCurrentLiabilitiesYear5;
            }

        }

        #endregion
        #endregion
        #endregion

        #region  Equity

        #region UIText_EQUITY
        
        string _UIText_EQUITY = string.Empty;
        public string UIText_EQUITY
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_EQUITY))
                {
                    _UIText_EQUITY = "Equity:";
                }
                return _UIText_EQUITY;
            }
            set
            {
                if (_UIText_EQUITY != value)
                {
                    _UIText_EQUITY = value;
                    SendPropertyChanged("UIText_EQUITY");
                }
            }
        }
        #endregion

        #region Owners Equity

        #region UIText_EQUITY_OWNERS
        
        string _UIText_EQUITY_OWNERS = string.Empty;
        public string UIText_EQUITY_OWNERS
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_EQUITY_OWNERS))
                {
                    _UIText_EQUITY_OWNERS = "Owners Equity:";
                }
                return _UIText_EQUITY_OWNERS;
            }
            set
            {
                if (_UIText_EQUITY_OWNERS != value)
                {
                    _UIText_EQUITY_OWNERS = value;
                    SendPropertyChanged("UIText_EQUITY_OWNERS");
                }
            }
        }
        #endregion

        #region UIText_EQUITY_OWNERS_REFTOLIQUID
        
        string _UIText_EQUITY_OWNERS_REFTOLIQUID = string.Empty;
        /// <summary>
        /// Tu khoa dung de lien ket qua Profit and loss statement...
        /// </summary>
        public string UIText_EQUITY_OWNERS_REFTOLIQUID
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_EQUITY_OWNERS_REFTOLIQUID))
                {
                    _UIText_EQUITY_OWNERS_REFTOLIQUID = "Increase of capital (private money)";
                }
                if (_UIText_EQUITY_OWNERS_REFTOLIQUID != null)
                    _UIText_EQUITY_OWNERS_REFTOLIQUID = _UIText_EQUITY_OWNERS_REFTOLIQUID.Trim();
                return _UIText_EQUITY_OWNERS_REFTOLIQUID;
            }
            set
            {
                if (_UIText_EQUITY_OWNERS_REFTOLIQUID != value)
                {
                    _UIText_EQUITY_OWNERS_REFTOLIQUID = value;
                    SendPropertyChanged("UIText_EQUITY_OWNERS_REFTOLIQUID");
                }
            }
        }
        #endregion

        #region OwnersEquityYear1
        public decimal OwnersEquityYear1
        {
            get
            {
                decimal oldData = 0;
                var lLIQUID = LIQUIDITYPLAN;
                if (lLIQUID == null)
                    return oldData;
                //Khac biet so voi nam khac
                //20130719: che lai
                //oldData = (decimal)lLIQUID.GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year1;
                var data = lLIQUID.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.FirstOrDefault(c => c.Name != null && c.Name.Trim().Equals(UIText_EQUITY_OWNERS_REFTOLIQUID, StringComparison.CurrentCultureIgnoreCase));
                if (data == null)
                    return oldData;
                return oldData + (decimal)data.Year1;
            }
            set
            {

            }
        }
        #endregion

        #region OwnersEquityYear2
        public decimal OwnersEquityYear2
        {
            get
            {
                var oldData = OwnersEquityYear1;
                var lLIQUID = LIQUIDITYPLAN;
                if (lLIQUID == null)
                    return oldData;
                var data = lLIQUID.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.FirstOrDefault(c => c.Name != null && c.Name.Trim().Equals(UIText_EQUITY_OWNERS_REFTOLIQUID, StringComparison.CurrentCultureIgnoreCase));
                if (data == null)
                    return oldData;
                return oldData + (decimal)data.Year2;
            }
            set
            {

            }
        }
        #endregion

        #region OwnersEquityYear3
        public decimal OwnersEquityYear3
        {
            get
            {
                var oldData = OwnersEquityYear2;
                var lLIQUID = LIQUIDITYPLAN;
                if (lLIQUID == null)
                    return oldData;
                var data = lLIQUID.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.FirstOrDefault(c => c.Name != null && c.Name.Trim().Equals(UIText_EQUITY_OWNERS_REFTOLIQUID, StringComparison.CurrentCultureIgnoreCase));
                if (data == null)
                    return oldData;
                return oldData + (decimal)data.Year3;
            }
            set
            {

            }
        }
        #endregion

        #region OwnersEquityYear4
        public decimal OwnersEquityYear4
        {
            get
            {
                var oldData = OwnersEquityYear3;
                var lLIQUID = LIQUIDITYPLAN;
                if (lLIQUID == null)
                    return oldData;
                var data = lLIQUID.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.FirstOrDefault(c => c.Name != null && c.Name.Trim().Equals(UIText_EQUITY_OWNERS_REFTOLIQUID, StringComparison.CurrentCultureIgnoreCase));
                if (data == null)
                    return oldData;
                return oldData + (decimal)data.Year4;
            }
            set
            {

            }
        }
        #endregion

        #region OwnersEquityYear5
        public decimal OwnersEquityYear5
        {
            get
            {
                var oldData = OwnersEquityYear4;
                var lLIQUID = LIQUIDITYPLAN;
                if (lLIQUID == null)
                    return oldData;
                var data = lLIQUID.Items_GROUP_CASH_INFLOW_FROM_FINANCING_ACTIVITIES.FirstOrDefault(c => c.Name != null && c.Name.Trim().Equals(UIText_EQUITY_OWNERS_REFTOLIQUID, StringComparison.CurrentCultureIgnoreCase));
                if (data == null)
                    return oldData;
                return oldData + (decimal)data.Year5;
            }
            set
            {

            }
        }
        #endregion

        #endregion

        #region PROFIT_LOSS_FOR_THE_CURRENT_PERIOD
        #region UIText_PROFIT_LOSS_FOR_THE_CURRENT_PERIOD
        
        string _UIText_PROFIT_LOSS_FOR_THE_CURRENT_PERIOD = string.Empty;
        public string UIText_PROFIT_LOSS_FOR_THE_CURRENT_PERIOD
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_PROFIT_LOSS_FOR_THE_CURRENT_PERIOD))
                {
                    _UIText_PROFIT_LOSS_FOR_THE_CURRENT_PERIOD = "Profit/loss for the current period";
                }
                return _UIText_PROFIT_LOSS_FOR_THE_CURRENT_PERIOD;
            }
            set
            {
                if (_UIText_PROFIT_LOSS_FOR_THE_CURRENT_PERIOD != value)
                {
                    _UIText_PROFIT_LOSS_FOR_THE_CURRENT_PERIOD = value;
                    SendPropertyChanged("UIText_PROFIT_LOSS_FOR_THE_CURRENT_PERIOD");
                }
            }
        }
        #endregion

        #region PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year1
        public decimal PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year1
        {
            get
            {
                var lProfit = PROFIT_LOSS_STATEMENT;
                return lProfit == null ? 0 : (decimal)lProfit.GROUP_NETPROFITLOSS_Total_Year1;
            }
            set
            {
            }
        }
        #endregion

        #region PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year2
        public decimal PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year2
        {
            get
            {
                var lProfit = PROFIT_LOSS_STATEMENT;
                return lProfit == null ? 0 : (decimal)lProfit.GROUP_NETPROFITLOSS_Total_Year2;
            }
            set
            {
            }
        }
        #endregion

        #region PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year3
        public decimal PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year3
        {
            get
            {
                var lProfit = PROFIT_LOSS_STATEMENT;
                return lProfit == null ? 0 : (decimal)lProfit.GROUP_NETPROFITLOSS_Total_Year3;
            }
            set
            {
            }
        }
        #endregion

        #region PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year4
        public decimal PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year4
        {
            get
            {
                var lProfit = PROFIT_LOSS_STATEMENT;
                return lProfit == null ? 0 : (decimal)lProfit.GROUP_NETPROFITLOSS_Total_Year4;
            }
            set
            {
            }
        }
        #endregion

        #region PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year5
        public decimal PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year5
        {
            get
            {
                var lProfit = PROFIT_LOSS_STATEMENT;
                return lProfit == null ? 0 : (decimal)lProfit.GROUP_NETPROFITLOSS_Total_Year5;
            }
            set
            {
            }
        }
        #endregion

        #endregion

        #region Retained Earnings

        #region UIText_EQUITY_RETAINED_EARNINGS
        
        string _UIText_EQUITY_RETAINED_EARNINGS = string.Empty;
        public string UIText_EQUITY_RETAINED_EARNINGS
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_EQUITY_RETAINED_EARNINGS))
                {
                    _UIText_EQUITY_RETAINED_EARNINGS = "Retained Earnings:";
                }
                return _UIText_EQUITY_RETAINED_EARNINGS;
            }
            set
            {
                if (_UIText_EQUITY_RETAINED_EARNINGS != value)
                {
                    _UIText_EQUITY_RETAINED_EARNINGS = value;
                    SendPropertyChanged("UIText_EQUITY_RETAINED_EARNINGS");
                }
            }
        }
        #endregion

        #region UIText_EQUITY_RETAINED_EARNINGS_REFLIQUIDITY
        //
        //string _UIText_EQUITY_RETAINED_EARNINGS_REFLIQUIDITY = string.Empty;
        //public string UIText_EQUITY_RETAINED_EARNINGS_REFLIQUIDITY
        //{
        //    get
        //    {
        //        if (string.IsNullOrEmpty(_UIText_EQUITY_RETAINED_EARNINGS_REFLIQUIDITY))
        //        {
        //            _UIText_EQUITY_RETAINED_EARNINGS_REFLIQUIDITY = "Cash in the beginning of the period";
        //        }
        //        if (_UIText_EQUITY_RETAINED_EARNINGS_REFLIQUIDITY != null)
        //            _UIText_EQUITY_RETAINED_EARNINGS_REFLIQUIDITY = _UIText_EQUITY_RETAINED_EARNINGS_REFLIQUIDITY.Trim();
        //        return _UIText_EQUITY_RETAINED_EARNINGS_REFLIQUIDITY;
        //    }
        //    set
        //    {
        //        if (_UIText_EQUITY_RETAINED_EARNINGS_REFLIQUIDITY != value)
        //        {
        //            _UIText_EQUITY_RETAINED_EARNINGS_REFLIQUIDITY = value;
        //            SendPropertyChanged("UIText_EQUITY_RETAINED_EARNINGS_REFLIQUIDITY");
        //        }
        //    }
        //}
        #endregion
        public decimal RetainedEarningsYear_REFLIQUIDITY_Year1
        {
            get
            {
                decimal value = 0;
                var liq = LIQUIDITYPLAN;
                if (liq != null)
                {
                    value = (decimal)liq.GROUP_CASH_IN_THE_BEGINNING_OF_THE_PERIOD_Total_Year1;
                    //var item = liq.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.Where(c => c.Name != null
                    //    && c.Name.Trim() == UIText_EQUITY_RETAINED_EARNINGS_REFLIQUIDITY).FirstOrDefault();
                    //if (item != null)
                    //    value = (decimal)item.Year1;
                }
                return value;
            }
            set
            {
            }
        }

        #region RetainedEarningsYear1
        public decimal RetainedEarningsYear1
        {
            get
            {
                return RetainedEarningsYear_REFLIQUIDITY_Year1;//- LessOwnersInvestorDrawsYear1;
            }
            set
            {
            }
        }
        #endregion

        #region RetainedEarningsYear2
        public decimal RetainedEarningsYear2
        {
            get
            {
                var oldData = RetainedEarningsYear1;
                return oldData + PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year1 - LessOwnersInvestorDrawsYear1;
            }
            set
            {
            }
        }
        #endregion

        #region RetainedEarningsYear3
        public decimal RetainedEarningsYear3
        {
            get
            {
                var oldData = RetainedEarningsYear2;
                return oldData + PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year2 - LessOwnersInvestorDrawsYear2;
            }
            set
            {
            }
        }
        #endregion

        #region RetainedEarningsYear4
        public decimal RetainedEarningsYear4
        {
            get
            {
                var oldData = RetainedEarningsYear3;
                return oldData + PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year3 - LessOwnersInvestorDrawsYear3;
            }
            set
            {
            }
        }
        #endregion

        #region RetainedEarningsYear5
        public decimal RetainedEarningsYear5
        {
            get
            {
                var oldData = RetainedEarningsYear4;
                return oldData + PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year4 - LessOwnersInvestorDrawsYear4;
            }
            set
            {
            }
        }
        #endregion

        #endregion

        #region Less:Owners&Investors Draws

        #region UIText_EQUITY_LESS_OID
        
        string _UIText_EQUITY_LESS_OID = string.Empty;
        public string UIText_EQUITY_LESS_OID
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_EQUITY_LESS_OID))
                {
                    _UIText_EQUITY_LESS_OID = "Less:Owners&Investors Draws:";
                }
                return _UIText_EQUITY_LESS_OID;
            }
            set
            {
                if (_UIText_EQUITY_LESS_OID != value)
                {
                    _UIText_EQUITY_LESS_OID = value;
                    SendPropertyChanged("UIText_EQUITY_LESS_OID");
                }
            }
        }
        #endregion

        #region UIText_EQUITY_LessOwnersInvestorDraws_REFTOLIQUID
        
        string _UIText_EQUITY_LESSOWNERSINVESTORDRAWS_REFTOLIQUID = string.Empty;
        /// <summary>
        /// Tu khoa dung de lien ket qua Profit and loss statement...
        /// </summary>
        public string UIText_EQUITY_LESSOWNERSINVESTORDRAWS_REFTOLIQUID
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_EQUITY_LESSOWNERSINVESTORDRAWS_REFTOLIQUID))
                {
                    _UIText_EQUITY_LESSOWNERSINVESTORDRAWS_REFTOLIQUID = "Dividends paid";
                }
                return _UIText_EQUITY_LESSOWNERSINVESTORDRAWS_REFTOLIQUID;
            }
            set
            {
                if (_UIText_EQUITY_LESSOWNERSINVESTORDRAWS_REFTOLIQUID != value)
                {
                    _UIText_EQUITY_LESSOWNERSINVESTORDRAWS_REFTOLIQUID = value;
                    SendPropertyChanged("UIText_EQUITY_LESSOWNERSINVESTORDRAWS_REFTOLIQUID");
                }
            }
        }
        #endregion

        #region LessOwnersInvestorDrawsYear1
        public Step_BalanceAndOthers_LIQUIDITYPLAN_Item LessOwnersInvestorDrawsYear_Item
        {
            get
            {
                var lLIQUID = LIQUIDITYPLAN;
                if (lLIQUID == null)
                    return null;
                var data = lLIQUID.Items_GROUP_CASH_OUTFLOW_FROM_FINANCING_ACTIVITIES.FirstOrDefault(c =>
                    c.Name != null &&
                    c.Name.Trim().Equals(UIText_EQUITY_LESSOWNERSINVESTORDRAWS_REFTOLIQUID, StringComparison.CurrentCultureIgnoreCase));
                return data;
            }
        }
        public decimal LessOwnersInvestorDrawsYear1
        {
            get
            {
                decimal oldData = 0;
                var data = LessOwnersInvestorDrawsYear_Item;
                if (data == null)
                    return oldData;
                return oldData + (decimal)data.Year1;
            }
            set
            {

            }
        }
        #endregion

        #region LessOwnersInvestorDrawsYear2
        public decimal LessOwnersInvestorDrawsYear2
        {
            get
            {
                var oldData = 0;//LessOwnersInvestorDrawsYear1;
                var data = LessOwnersInvestorDrawsYear_Item;
                if (data == null)
                    return oldData;
                return oldData + (decimal)data.Year2;
            }
            set
            {

            }
        }
        #endregion

        #region LessOwnersInvestorDrawsYear3
        public decimal LessOwnersInvestorDrawsYear3
        {
            get
            {
                var oldData = 0;//LessOwnersInvestorDrawsYear2;
                var data = LessOwnersInvestorDrawsYear_Item;
                if (data == null)
                    return oldData;
                return oldData + (decimal)data.Year3;
            }
            set
            {

            }
        }
        #endregion

        #region LessOwnersInvestorDrawsYear4
        public decimal LessOwnersInvestorDrawsYear4
        {
            get
            {
                var oldData = 0;// LessOwnersInvestorDrawsYear3;
                var data = LessOwnersInvestorDrawsYear_Item;
                if (data == null)
                    return oldData;
                return oldData + (decimal)data.Year4;
            }
            set
            {

            }
        }
        #endregion

        #region LessOwnersInvestorDrawsYear5
        public decimal LessOwnersInvestorDrawsYear5
        {
            get
            {
                var oldData = 0;//LessOwnersInvestorDrawsYear4;
                var data = LessOwnersInvestorDrawsYear_Item;
                if (data == null)
                    return oldData;
                return oldData + (decimal)data.Year5;
            }
            set
            {

            }
        }
        #endregion
        #endregion

        #region Total Equity

        #region UIText_TOTAL_EQUITY
        
        string _UIText_TOTAL_EQUITY = string.Empty;
        public string UIText_TOTAL_EQUITY
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_TOTAL_EQUITY))
                {
                    _UIText_TOTAL_EQUITY = "Total Equity:";
                }
                return _UIText_TOTAL_EQUITY;
            }
            set
            {
                if (_UIText_TOTAL_EQUITY != value)
                {
                    _UIText_TOTAL_EQUITY = value;
                    SendPropertyChanged("UIText_TOTAL_EQUITY");
                }
            }
        }
        #endregion

        #region TotalEquityYear1


        public decimal TotalEquityYear1
        {
            get
            {
                return OwnersEquityYear1 + PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year1 + RetainedEarningsYear1 - LessOwnersInvestorDrawsYear1;
            }

        }
        #endregion

        #region TotalEquityYear2

        public decimal TotalEquityYear2
        {
            get
            {
                return OwnersEquityYear2 + PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year2 + RetainedEarningsYear2 - LessOwnersInvestorDrawsYear2;
            }

        }
        #endregion

        #region TotalEquityYear3


        public decimal TotalEquityYear3
        {
            get
            {
                return OwnersEquityYear3 + PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year3 + RetainedEarningsYear3 - LessOwnersInvestorDrawsYear3;
            }

        }
        #endregion

        #region TotalEquityYear4


        public decimal TotalEquityYear4
        {
            get
            {
                return OwnersEquityYear4 + PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year4 + RetainedEarningsYear4 - LessOwnersInvestorDrawsYear4;
            }

        }
        #endregion

        #region TotalEquityYear5


        public decimal TotalEquityYear5
        {
            get
            {
                return OwnersEquityYear5 + PROFIT_LOSS_FOR_THE_CURRENT_PERIOD_Year5 + RetainedEarningsYear5 - LessOwnersInvestorDrawsYear5;
            }

        }
        #endregion

        #endregion

        #endregion

        #region TOTAL LIABILITIES and EQUITY
        #region UIText_TOTAL_LIABILITIES_EQUITY
        
        string _UIText_TOTAL_LIABILITIES_EQUITY = string.Empty;
        public string UIText_TOTAL_LIABILITIES_EQUITY
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_TOTAL_LIABILITIES_EQUITY))
                {
                    _UIText_TOTAL_LIABILITIES_EQUITY = "TOTAL LIABILITIES & EQUITY";
                }
                return _UIText_TOTAL_LIABILITIES_EQUITY;
            }
            set
            {
                if (_UIText_TOTAL_LIABILITIES_EQUITY != value)
                {
                    _UIText_TOTAL_LIABILITIES_EQUITY = value;
                    SendPropertyChanged("UIText_TOTAL_LIABILITIES_EQUITY");
                }
            }
        }
        #endregion

        #region TotalEquityLiabilitiesYear1


        public decimal TotalEquityLiabilitiesYear1
        {
            get
            {
                return TotalLiabilitiesYear1 + TotalEquityYear1;
            }

        }
        #endregion

        #region TotalEquityLiabilitiesYear2


        public decimal TotalEquityLiabilitiesYear2
        {
            get
            {
                return TotalLiabilitiesYear2 + TotalEquityYear2;
            }

        }
        #endregion

        #region TotalEquityLiabilitiesYear3


        public decimal TotalEquityLiabilitiesYear3
        {
            get
            {
                return TotalLiabilitiesYear3 + TotalEquityYear3;
            }

        }
        #endregion

        #region TotalEquityLiabilitiesYear4


        public decimal TotalEquityLiabilitiesYear4
        {
            get
            {
                return TotalLiabilitiesYear4 + TotalEquityYear4;
            }

        }
        #endregion

        #region TotalEquityLiabilitiesYear5


        public decimal TotalEquityLiabilitiesYear5
        {
            get
            {
                return TotalLiabilitiesYear5 + TotalEquityYear5;
            }

        }
        #endregion

        #endregion

        #region TOTAL ASSETS
        #region UIText_TOTAL ASSETS
        
        string _UIText_TOTALASSETS = string.Empty;
        public string UIText_TOTALASSETS
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_TOTALASSETS))
                {
                    _UIText_TOTALASSETS = "TOTAL ASSETS:";
                }
                return _UIText_TOTALASSETS;
            }
            set
            {
                if (_UIText_TOTALASSETS != value)
                {
                    _UIText_TOTALASSETS = value;
                    SendPropertyChanged("UIText_TOTALASSETS");
                }
            }
        }
        #endregion

        #region TotalAssetsYear1


        public decimal TotalAssetsYear1
        {
            get
            {
                return TotalCurrentAssetsYear1 + TotalNonCurrentAssetsYear1;
            }

        }
        #endregion

        #region TotalAssetsYear2


        public decimal TotalAssetsYear2
        {
            get
            {
                return TotalCurrentAssetsYear2 + TotalNonCurrentAssetsYear2;
            }

        }
        #endregion

        #region TotalAssetsYear3


        public decimal TotalAssetsYear3
        {
            get
            {
                return TotalCurrentAssetsYear3 + TotalNonCurrentAssetsYear3;
            }

        }
        #endregion

        #region TotalAssetsYear4


        public decimal TotalAssetsYear4
        {
            get
            {
                return TotalCurrentAssetsYear4 + TotalNonCurrentAssetsYear4;
            }

        }
        #endregion

        #region TotalAssetsYear5


        public decimal TotalAssetsYear5
        {
            get
            {
                return TotalCurrentAssetsYear5 + TotalNonCurrentAssetsYear5;
            }

        }
        #endregion

        #endregion

        #region TOTAL LIABILITIES
        #region UIText_TOTAL LIABILITIES
        
        string _UIText_TOTAL_LIABILITIES = string.Empty;
        public string UIText_TOTAL_LIABILITIES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_TOTAL_LIABILITIES))
                {
                    _UIText_TOTAL_LIABILITIES = "TOTAL LIABILITIES:";
                }
                return _UIText_TOTAL_LIABILITIES;
            }
            set
            {
                if (_UIText_TOTAL_LIABILITIES != value)
                {
                    _UIText_TOTAL_LIABILITIES = value;
                    SendPropertyChanged("UIText_TOTAL_LIABILITIES");
                }
            }
        }
        #endregion

        #region TotalLiabilitiesYear1


        public decimal TotalLiabilitiesYear1
        {
            get
            {
                return TotalLongTermLiabilitiesYear1 + TotalCurrentLiabilitiesYear1;
            }

        }
        #endregion

        #region TotalLiabilitiesYear2


        public decimal TotalLiabilitiesYear2
        {
            get
            {
                return TotalLongTermLiabilitiesYear2 + TotalCurrentLiabilitiesYear2;
            }

        }
        #endregion

        #region TotalLiabilitiesYear3


        public decimal TotalLiabilitiesYear3
        {
            get
            {
                return TotalLongTermLiabilitiesYear3 + TotalCurrentLiabilitiesYear3;
            }

        }
        #endregion

        #region TotalLiabilitiesYear4


        public decimal TotalLiabilitiesYear4
        {
            get
            {
                return TotalLongTermLiabilitiesYear4 + TotalCurrentLiabilitiesYear4;
            }

        }
        #endregion

        #region TotalLiabilitiesYear5


        public decimal TotalLiabilitiesYear5
        {
            get
            {
                return TotalLongTermLiabilitiesYear5 + TotalCurrentLiabilitiesYear5;
            }

        }
        #endregion

        #endregion
    }
    
    public class Step_BalanceAndOthers_Sheet_Statement_Item : INotifyPropertyChanged
    {
        Step_BalanceAndOthers_Sheet_Statement _Parent;
        public Step_BalanceAndOthers_Sheet_Statement Parent
        {
            get { return _Parent; }
            set
            {
                if (value != _Parent)
                {
                    _Parent = value;
                    this.PropertyChanged -= new PropertyChangedEventHandler(Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item_PropertyChanged);
                    this.PropertyChanged += new PropertyChangedEventHandler(Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item_PropertyChanged);
                }
            }
        }
        public Step_BalanceAndOthers_Sheet_Statement_Item(Step_BalanceAndOthers_Sheet_Statement parent)
        {
            Parent = parent;
        }

        void Step_BalanceAndOthers_PROFIT_LOSS_STATEMENT_Item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //if (Parent != null)
            //    Parent.SendPropertyChanged_Total();
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


    }
}