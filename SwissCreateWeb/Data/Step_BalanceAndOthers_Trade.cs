using SwissCreateWeb.Models.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using ViCode_LeVi.Data;
//using ViCode_LeVi.Data;

namespace ViCode_LeVi.Data
{
    public class Step_BalanceAndOthers_Trade : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region UI
        #region Step_BalanceAndOthers_Trade_Header
        
        string _Step_BalanceAndOthers_Trade_Header = string.Empty;
        public string Step_BalanceAndOthers_Trade_Header_4Report
        {
            get
            {
                //if (Report_Config_Finance.IsConvertHeaderToUpper == true)
                //    return Step_BalanceAndOthers_Trade_Header.ToUpper();
                return Step_BalanceAndOthers_Trade_Header;
            }
        }
        public string Step_BalanceAndOthers_Trade_Header
        {
            get
            {
                if (string.IsNullOrEmpty(_Step_BalanceAndOthers_Trade_Header))
                {
                    _Step_BalanceAndOthers_Trade_Header = "Trade Calculation";
                }
                return _Step_BalanceAndOthers_Trade_Header;
            }
            set
            {
                if (_Step_BalanceAndOthers_Trade_Header != value)
                {
                    _Step_BalanceAndOthers_Trade_Header = value;
                    SendPropertyChanged("Step_BalanceAndOthers_Trade_Header");
                }
            }
        }
        #endregion

        #region UI_Text_Currency
        
        string _UI_Text_Currency = string.Empty;
        public string UI_Text_Currency
        {
            get
            {
                if (string.IsNullOrEmpty(_UI_Text_Currency))
                {
                    _UI_Text_Currency = "Currency";
                }
                return _UI_Text_Currency;
            }
            set
            {
                if (_UI_Text_Currency != value)
                {
                    _UI_Text_Currency = value;
                    SendPropertyChanged("UI_Text_Currency");
                }
            }
        }
        #endregion

        #region UI_Text_ListPriceList
        
        string _UI_Text_ListPriceList = string.Empty;
        public string UI_Text_ListPriceList
        {
            get
            {
                if (string.IsNullOrEmpty(_UI_Text_ListPriceList))
                {
                    _UI_Text_ListPriceList = "List price list";
                }
                return _UI_Text_ListPriceList;
            }
            set
            {
                if (_UI_Text_ListPriceList != value)
                {
                    _UI_Text_ListPriceList = value;
                    SendPropertyChanged("UI_Text_ListPriceList");
                }
            }
        }
        #endregion

        #region UI_Text_TradeDiscount
        
        string _UI_Text_TradeDiscount = string.Empty;
        public string UI_Text_TradeDiscount
        {
            get
            {
                if (string.IsNullOrEmpty(_UI_Text_TradeDiscount))
                {
                    _UI_Text_TradeDiscount = "Trade discount";
                }
                return _UI_Text_TradeDiscount;
            }
            set
            {
                if (_UI_Text_TradeDiscount != value)
                {
                    _UI_Text_TradeDiscount = value;
                    SendPropertyChanged("UI_Text_TradeDiscount");
                }
            }
        }
        #endregion

        #region UI_Text_InvoicePriceSupplier
        
        string _UI_Text_InvoicePriceSupplier = string.Empty;
        public string UI_Text_InvoicePriceSupplier
        {
            get
            {
                if (string.IsNullOrEmpty(_UI_Text_InvoicePriceSupplier))
                {
                    _UI_Text_InvoicePriceSupplier = "Invoice price supplier";
                }
                return _UI_Text_InvoicePriceSupplier;
            }
            set
            {
                if (_UI_Text_InvoicePriceSupplier != value)
                {
                    _UI_Text_InvoicePriceSupplier = value;
                    SendPropertyChanged("UI_Text_InvoicePriceSupplier");
                }
            }
        }
        #endregion

        #region UI_Text_OtherSupplierDiscounts
        
        string _UI_Text_OtherSupplierDiscounts = string.Empty;
        public string UI_Text_OtherSupplierDiscounts
        {
            get
            {
                if (string.IsNullOrEmpty(_UI_Text_OtherSupplierDiscounts))
                {
                    _UI_Text_OtherSupplierDiscounts = "Other supplier discounts";
                }
                return _UI_Text_OtherSupplierDiscounts;
            }
            set
            {
                if (_UI_Text_OtherSupplierDiscounts != value)
                {
                    _UI_Text_OtherSupplierDiscounts = value;
                    SendPropertyChanged("UI_Text_OtherSupplierDiscounts");
                }
            }
        }
        #endregion

        #region UI_Text_InvoicePriceSupplier2
        
        string _UI_Text_InvoicePriceSupplier2 = string.Empty;
        public string UI_Text_InvoicePriceSupplier2
        {
            get
            {
                if (string.IsNullOrEmpty(_UI_Text_InvoicePriceSupplier2))
                {
                    _UI_Text_InvoicePriceSupplier2 = "Invoice price supplier";
                }
                return _UI_Text_InvoicePriceSupplier2;
            }
            set
            {
                if (_UI_Text_InvoicePriceSupplier2 != value)
                {
                    _UI_Text_InvoicePriceSupplier2 = value;
                    SendPropertyChanged("UI_Text_InvoicePriceSupplier2");
                }
            }
        }
        #endregion

        #region UI_Text_OtherCashDiscounts
        
        string _UI_Text_OtherCashDiscounts = string.Empty;
        public string UI_Text_OtherCashDiscounts
        {
            get
            {
                if (string.IsNullOrEmpty(_UI_Text_OtherCashDiscounts))
                {
                    _UI_Text_OtherCashDiscounts = "Supplier cash discounts";
                }
                return _UI_Text_OtherCashDiscounts;
            }
            set
            {
                if (_UI_Text_OtherCashDiscounts != value)
                {
                    _UI_Text_OtherCashDiscounts = value;
                    SendPropertyChanged("UI_Text_OtherCashDiscounts");
                }
            }
        }
        #endregion

        #region UI_Text_PurchasePrice
        
        string _UI_Text_PurchasePrice = string.Empty;
        public string UI_Text_PurchasePrice
        {
            get
            {
                if (string.IsNullOrEmpty(_UI_Text_PurchasePrice))
                {
                    _UI_Text_PurchasePrice = "Purchase Price";
                }
                return _UI_Text_PurchasePrice;
            }
            set
            {
                if (_UI_Text_PurchasePrice != value)
                {
                    _UI_Text_PurchasePrice = value;
                    SendPropertyChanged("UI_Text_PurchasePrice");
                }
            }
        }
        #endregion

        #region UI_Text_PurchasingCosts
        
        string _UI_Text_PurchasingCosts = string.Empty;
        public string UI_Text_PurchasingCosts
        {
            get
            {
                if (string.IsNullOrEmpty(_UI_Text_PurchasingCosts))
                {
                    _UI_Text_PurchasingCosts = "Purchasing costs (eg: packing, transportation, duty)";
                }
                return _UI_Text_PurchasingCosts;
            }
            set
            {
                if (_UI_Text_PurchasingCosts != value)
                {
                    _UI_Text_PurchasingCosts = value;
                    SendPropertyChanged("UI_Text_PurchasingCosts");
                }
            }
        }
        #endregion

        #region UI_Text_AcquistitionPrice
        
        string _UI_Text_AcquistitionPrice = string.Empty;
        public string UI_Text_AcquistitionPrice
        {
            get
            {
                if (string.IsNullOrEmpty(_UI_Text_AcquistitionPrice))
                {
                    _UI_Text_AcquistitionPrice = "Acquistition price";
                }
                return _UI_Text_AcquistitionPrice;
            }
            set
            {
                if (_UI_Text_AcquistitionPrice != value)
                {
                    _UI_Text_AcquistitionPrice = value;
                    SendPropertyChanged("UI_Text_AcquistitionPrice");
                }
            }
        }
        #endregion

        #region UI_Text_IndirectCosts
        
        string _UI_Text_IndirectCosts = string.Empty;
        public string UI_Text_IndirectCosts
        {
            get
            {
                if (string.IsNullOrEmpty(_UI_Text_IndirectCosts))
                {
                    _UI_Text_IndirectCosts = "Indirect costs (eg: wages, rental)";
                }
                return _UI_Text_IndirectCosts;
            }
            set
            {
                if (_UI_Text_IndirectCosts != value)
                {
                    _UI_Text_IndirectCosts = value;
                    SendPropertyChanged("UI_Text_IndirectCosts");
                }
            }
        }
        #endregion

        #region UI_Text_CostPrice
        
        string _UI_Text_CostPrice = string.Empty;
        public string UI_Text_CostPrice
        {
            get
            {
                if (string.IsNullOrEmpty(_UI_Text_CostPrice))
                {
                    _UI_Text_CostPrice = "Cost price";
                }
                return _UI_Text_CostPrice;
            }
            set
            {
                if (_UI_Text_CostPrice != value)
                {
                    _UI_Text_CostPrice = value;
                    SendPropertyChanged("UI_Text_CostPrice");
                }
            }
        }
        #endregion

        #region UI_Text_Profit
        
        string _UI_Text_Profit = string.Empty;
        public string UI_Text_Profit
        {
            get
            {
                if (string.IsNullOrEmpty(_UI_Text_Profit))
                {
                    _UI_Text_Profit = "Profit";
                }
                return _UI_Text_Profit;
            }
            set
            {
                if (_UI_Text_Profit != value)
                {
                    _UI_Text_Profit = value;
                    SendPropertyChanged("UI_Text_Profit");
                }
            }
        }
        #endregion

        #region UI_Text_GrossSalesPrice
        
        string _UI_Text_GrossSalesPrice = string.Empty;
        public string UI_Text_GrossSalesPrice
        {
            get
            {
                if (string.IsNullOrEmpty(_UI_Text_GrossSalesPrice))
                {
                    _UI_Text_GrossSalesPrice = "Gross sales price";
                }
                return _UI_Text_GrossSalesPrice;
            }
            set
            {
                if (_UI_Text_GrossSalesPrice != value)
                {
                    _UI_Text_GrossSalesPrice = value;
                    SendPropertyChanged("UI_Text_GrossSalesPrice");
                }
            }
        }
        #endregion

        #region UI_Text_SalesCost
        
        string _UI_Text_SalesCost = string.Empty;
        public string UI_Text_SalesCost
        {
            get
            {
                if (string.IsNullOrEmpty(_UI_Text_SalesCost))
                {
                    _UI_Text_SalesCost = "Sales cost (eg:  packing, transportation, sale commission)";
                }
                return _UI_Text_SalesCost;
            }
            set
            {
                if (_UI_Text_SalesCost != value)
                {
                    _UI_Text_SalesCost = value;
                    SendPropertyChanged("UI_Text_SalesCost");
                }
            }
        }
        #endregion

        #region UI_Text_NetSalesPrice
        
        string _UI_Text_NetSalesPrice = string.Empty;
        public string UI_Text_NetSalesPrice
        {
            get
            {
                if (string.IsNullOrEmpty(_UI_Text_NetSalesPrice))
                {
                    _UI_Text_NetSalesPrice = "Net sales price";
                }
                return _UI_Text_NetSalesPrice;
            }
            set
            {
                if (_UI_Text_NetSalesPrice != value)
                {
                    _UI_Text_NetSalesPrice = value;
                    SendPropertyChanged("UI_Text_NetSalesPrice");
                }
            }
        }
        #endregion

        #region UI_Text_CustomerCashDiscount
        
        string _UI_Text_CustomerCashDiscount = string.Empty;
        public string UI_Text_CustomerCashDiscount
        {
            get
            {
                if (string.IsNullOrEmpty(_UI_Text_CustomerCashDiscount))
                {
                    _UI_Text_CustomerCashDiscount = "Customer cash discount";
                }
                return _UI_Text_CustomerCashDiscount;
            }
            set
            {
                if (_UI_Text_CustomerCashDiscount != value)
                {
                    _UI_Text_CustomerCashDiscount = value;
                    SendPropertyChanged("UI_Text_CustomerCashDiscount");
                }
            }
        }
        #endregion

        #region UI_Text_InvoicePrice
        
        string _UI_Text_InvoicePrice = string.Empty;
        public string UI_Text_InvoicePrice
        {
            get
            {
                if (string.IsNullOrEmpty(_UI_Text_InvoicePrice))
                {
                    _UI_Text_InvoicePrice = "Invoice price";
                }
                return _UI_Text_InvoicePrice;
            }
            set
            {
                if (_UI_Text_InvoicePrice != value)
                {
                    _UI_Text_InvoicePrice = value;
                    SendPropertyChanged("UI_Text_InvoicePrice");
                }
            }
        }
        #endregion

        #region UI_Text_CustomerDiscount
        
        string _UI_Text_CustomerDiscount = string.Empty;
        public string UI_Text_CustomerDiscount
        {
            get
            {
                if (string.IsNullOrEmpty(_UI_Text_CustomerDiscount))
                {
                    _UI_Text_CustomerDiscount = "Customer discount";
                }
                return _UI_Text_CustomerDiscount;
            }
            set
            {
                if (_UI_Text_CustomerDiscount != value)
                {
                    _UI_Text_CustomerDiscount = value;
                    SendPropertyChanged("UI_Text_CustomerDiscount");
                }
            }
        }
        #endregion

        #region UI_Text_ListPriceSales
        
        string _UI_Text_ListPriceSales = string.Empty;
        public string UI_Text_ListPriceSales
        {
            get
            {
                if (string.IsNullOrEmpty(_UI_Text_ListPriceSales))
                {
                    _UI_Text_ListPriceSales = "List price (sales)";
                }
                return _UI_Text_ListPriceSales;
            }
            set
            {
                if (_UI_Text_ListPriceSales != value)
                {
                    _UI_Text_ListPriceSales = value;
                    SendPropertyChanged("UI_Text_ListPriceSales");
                }
            }
        }
        #endregion

        #endregion


        public string CompanyName { get { return ProjectData.Intance.CompanyName; } }
        #region ProductName
        
        string _ProductName = string.Empty;
        public string ProductName
        {
            get { return _ProductName; }
            set
            {
                if (_ProductName != value)
                {
                    _ProductName = value;
                    SendPropertyChanged("ProductName");
                }
            }
        }
        #endregion

        #region CurrencyChar
        
        string _CurrencyChar = string.Empty;
        public string CurrencyChar
        {
            get { return _CurrencyChar; }
            set
            {
                if (_CurrencyChar != value)
                {
                    _CurrencyChar = value;
                    SendPropertyChanged("CurrencyChar");
                }
            }
        }
        #endregion

        #region ListPriceSupplier
        
        double _ListPriceSupplier = 0;
        public double ListPriceSupplier
        {
            get { return _ListPriceSupplier; }
            set
            {
                if (_ListPriceSupplier != value)
                {
                    _ListPriceSupplier = value;
                    SendPropertyChanged("ListPriceSupplier");
                    SendPropertyChanged("TradeDiscountMoney");
                    SendPropertyChanged("InvoicePriceSupplier");
                    SendPropertyChanged("OtherSupplierDiscountsMoney");
                    SendPropertyChanged("InvoicePriceSupplier2");
                    SendPropertyChanged("OtherCashDiscountsMoney");
                    SendPropertyChanged("PurchasePrice");
                    SendPropertyChanged("PurchasingCostsMoney");
                    SendPropertyChanged("AcquistitionPrice");
                    SendPropertyChanged("IndirectCostsMoney");
                    SendPropertyChanged("CostPrice");
                    SendPropertyChanged("ProfitMoney");
                    SendPropertyChanged("GrossSalesPrice");
                    SendPropertyChanged("SalesCostMoney");
                    SendPropertyChanged("NetSalesPrice");
                    SendPropertyChanged("CustomerCashDiscountMoney");
                    SendPropertyChanged("InvoicePrice");
                    SendPropertyChanged("CustomerDiscountMoney");
                    SendPropertyChanged("ListPriceSales");
                }
            }
        }
        #endregion

        #region TradeDiscountPercent
        
        double _TradeDiscountPercent = 0;
        public double TradeDiscountPercent
        {
            get { return _TradeDiscountPercent; }
            set
            {
                if (_TradeDiscountPercent != value)
                {
                    _TradeDiscountPercent = value;
                    SendPropertyChanged("TradeDiscountPercent");
                    SendPropertyChanged("TradeDiscountMoney");
                    SendPropertyChanged("InvoicePriceSupplier");
                    SendPropertyChanged("OtherSupplierDiscountsMoney");
                    SendPropertyChanged("InvoicePriceSupplier2");
                    SendPropertyChanged("OtherCashDiscountsMoney");
                    SendPropertyChanged("PurchasePrice");
                    SendPropertyChanged("PurchasingCostsMoney");
                    SendPropertyChanged("AcquistitionPrice");
                    SendPropertyChanged("IndirectCostsMoney");
                    SendPropertyChanged("CostPrice");
                    SendPropertyChanged("ProfitMoney");
                    SendPropertyChanged("GrossSalesPrice");
                    SendPropertyChanged("SalesCostMoney");
                    SendPropertyChanged("NetSalesPrice");
                    SendPropertyChanged("CustomerCashDiscountMoney");
                    SendPropertyChanged("InvoicePrice");
                    SendPropertyChanged("CustomerDiscountMoney");
                    SendPropertyChanged("ListPriceSales");
                }
            }
        }
        #endregion

        #region TradeDiscountMoney
        public double TradeDiscountMoney
        {
            get { return VMMath.Round(ListPriceSupplier * ((TradeDiscountPercent) / 100)); }
        }
        #endregion


        #region InvoicePriceSupplier
        public double InvoicePriceSupplier
        {
            get { return VMMath.Round(ListPriceSupplier - TradeDiscountMoney); }
        }
        #endregion

        #region OtherSupplierDiscountsPercent
        
        double _OtherSupplierDiscountsPercent = 0;
        public double OtherSupplierDiscountsPercent
        {
            get { return _OtherSupplierDiscountsPercent; }
            set
            {
                if (_OtherSupplierDiscountsPercent != value)
                {
                    _OtherSupplierDiscountsPercent = value;
                    SendPropertyChanged("OtherSupplierDiscountsPercent");
                    SendPropertyChanged("OtherSupplierDiscountsMoney");
                    SendPropertyChanged("InvoicePriceSupplier2");
                    SendPropertyChanged("OtherCashDiscountsMoney");
                    SendPropertyChanged("PurchasePrice");
                    SendPropertyChanged("PurchasingCostsMoney");
                    SendPropertyChanged("AcquistitionPrice");
                    SendPropertyChanged("IndirectCostsMoney");
                    SendPropertyChanged("CostPrice");
                    SendPropertyChanged("ProfitMoney");
                    SendPropertyChanged("GrossSalesPrice");
                    SendPropertyChanged("SalesCostMoney");
                    SendPropertyChanged("NetSalesPrice");
                    SendPropertyChanged("CustomerCashDiscountMoney");
                    SendPropertyChanged("InvoicePrice");
                    SendPropertyChanged("CustomerDiscountMoney");
                    SendPropertyChanged("ListPriceSales");

                }
            }
        }
        #endregion

        #region OtherSupplierDiscountsMoney
        public double OtherSupplierDiscountsMoney
        {
            get { return VMMath.Round(InvoicePriceSupplier * (OtherSupplierDiscountsPercent / 100d)); }
        }
        #endregion


        #region InvoicePriceSupplier2
        public double InvoicePriceSupplier2
        {
            get { return VMMath.Round(InvoicePriceSupplier - OtherSupplierDiscountsMoney); }
        }
        #endregion

        #region OtherCashDiscountsPercent
        
        double _OtherCashDiscountsPercent = 0;
        public double OtherCashDiscountsPercent
        {
            get { return _OtherCashDiscountsPercent; }
            set
            {
                if (_OtherCashDiscountsPercent != value)
                {
                    _OtherCashDiscountsPercent = value;
                    SendPropertyChanged("OtherCashDiscountsPercent");
                    SendPropertyChanged("OtherCashDiscountsMoney");
                    SendPropertyChanged("PurchasePrice");
                    SendPropertyChanged("PurchasingCostsMoney");
                    SendPropertyChanged("AcquistitionPrice");
                    SendPropertyChanged("IndirectCostsMoney");
                    SendPropertyChanged("CostPrice");
                    SendPropertyChanged("ProfitMoney");
                    SendPropertyChanged("GrossSalesPrice");
                    SendPropertyChanged("SalesCostMoney");
                    SendPropertyChanged("NetSalesPrice");
                    SendPropertyChanged("CustomerCashDiscountMoney");
                    SendPropertyChanged("InvoicePrice");
                    SendPropertyChanged("CustomerDiscountMoney");
                    SendPropertyChanged("ListPriceSales");
                }
            }
        }
        #endregion

        #region OtherCashDiscountsMoney
        public double OtherCashDiscountsMoney
        {
            get { return VMMath.Round(InvoicePriceSupplier2 * (OtherCashDiscountsPercent / 100d)); }
        }
        #endregion


        #region PurchasePrice
        public double PurchasePrice
        {
            get { return VMMath.Round(InvoicePriceSupplier2 - OtherCashDiscountsMoney); }

        }
        #endregion

        #region PurchasingCostsPercent
        
        double _PurchasingCostsPercent = 0;
        public double PurchasingCostsPercent
        {
            get { return _PurchasingCostsPercent; }
            set
            {
                if (_PurchasingCostsPercent != value)
                {
                    _PurchasingCostsPercent = value;
                    SendPropertyChanged("PurchasingCostsPercent");
                    SendPropertyChanged("PurchasingCostsMoney");
                    SendPropertyChanged("AcquistitionPrice");
                    SendPropertyChanged("IndirectCostsMoney");
                    SendPropertyChanged("CostPrice");
                    SendPropertyChanged("ProfitMoney");
                    SendPropertyChanged("GrossSalesPrice");
                    SendPropertyChanged("SalesCostMoney");
                    SendPropertyChanged("NetSalesPrice");
                    SendPropertyChanged("CustomerCashDiscountMoney");
                    SendPropertyChanged("InvoicePrice");
                    SendPropertyChanged("CustomerDiscountMoney");
                    SendPropertyChanged("ListPriceSales");

                }
            }
        }
        #endregion

        #region PurchasingCostsMoney
        public double PurchasingCostsMoney
        {
            get { return VMMath.Round(PurchasePrice * (PurchasingCostsPercent / 100d)); }
        }
        #endregion

        #region AcquistitionPrice
        public double AcquistitionPrice
        {
            get { return VMMath.Round(PurchasePrice + PurchasingCostsMoney); }
        }
        #endregion

        #region IndirectCostsPercent
        
        double _IndirectCostsPercent = 0;
        public double IndirectCostsPercent
        {
            get { return _IndirectCostsPercent; }
            set
            {
                if (_IndirectCostsPercent != value)
                {
                    _IndirectCostsPercent = value;
                    SendPropertyChanged("IndirectCostsPercent");

                    SendPropertyChanged("IndirectCostsMoney");
                    SendPropertyChanged("CostPrice");
                    SendPropertyChanged("ProfitMoney");
                    SendPropertyChanged("GrossSalesPrice");
                    SendPropertyChanged("SalesCostMoney");
                    SendPropertyChanged("NetSalesPrice");
                    SendPropertyChanged("CustomerCashDiscountMoney");
                    SendPropertyChanged("InvoicePrice");
                    SendPropertyChanged("CustomerDiscountMoney");
                    SendPropertyChanged("ListPriceSales");
                }
            }
        }
        #endregion

        #region IndirectCostsMoney
        public double IndirectCostsMoney
        {
            get { return VMMath.Round(AcquistitionPrice * (IndirectCostsPercent / 100d)); }
        }
        #endregion


        #region CostPrice
        public double CostPrice
        {
            get { return VMMath.Round(AcquistitionPrice + IndirectCostsMoney); }
        }
        #endregion

        #region ProfitPercent
        
        double _ProfitPercent = 0;
        public double ProfitPercent
        {
            get { return _ProfitPercent; }
            set
            {
                if (_ProfitPercent != value)
                {
                    _ProfitPercent = value;
                    SendPropertyChanged("ProfitPercent");

                    SendPropertyChanged("ProfitMoney");
                    SendPropertyChanged("GrossSalesPrice");
                    SendPropertyChanged("SalesCostMoney");
                    SendPropertyChanged("NetSalesPrice");
                    SendPropertyChanged("CustomerCashDiscountMoney");
                    SendPropertyChanged("InvoicePrice");
                    SendPropertyChanged("CustomerDiscountMoney");
                    SendPropertyChanged("ListPriceSales");
                }
            }
        }
        #endregion

        #region ProfitMoney
        public double ProfitMoney
        {
            get { return VMMath.Round(CostPrice * (ProfitPercent / 100d)); }
        }
        #endregion

        #region GrossSalesPrice
        public double GrossSalesPrice
        {
            get { return VMMath.Round(CostPrice + ProfitMoney); }

        }
        #endregion

        #region SalesCostPercent
        
        double _SalesCostPercent = 0;
        public double SalesCostPercent
        {
            get { return _SalesCostPercent; }
            set
            {
                if (_SalesCostPercent != value)
                {
                    _SalesCostPercent = value;
                    SendPropertyChanged("SalesCostPercent");
                    SendPropertyChanged("SalesCostMoney");
                    SendPropertyChanged("NetSalesPrice");
                    SendPropertyChanged("CustomerCashDiscountMoney");
                    SendPropertyChanged("InvoicePrice");
                    SendPropertyChanged("CustomerDiscountMoney");
                    SendPropertyChanged("ListPriceSales");
                }
            }
        }
        #endregion

        #region SalesCostMoney
        public double SalesCostMoney
        {
            get { return VMMath.Round(GrossSalesPrice * (SalesCostPercent / 100d)); }
        }
        #endregion

        #region NetSalesPrice
        public double NetSalesPrice
        {
            get { return VMMath.Round(GrossSalesPrice + SalesCostMoney); }
        }
        #endregion

        #region CustomerCashDiscountPercent
        
        double _CustomerCashDiscountPercent = 0;
        public double CustomerCashDiscountPercent
        {
            get { return _CustomerCashDiscountPercent; }
            set
            {
                if (_CustomerCashDiscountPercent != value)
                {
                    _CustomerCashDiscountPercent = value;
                    SendPropertyChanged("CustomerCashDiscountPercent");
                    SendPropertyChanged("CustomerCashDiscountMoney");
                    SendPropertyChanged("InvoicePrice");
                    SendPropertyChanged("CustomerDiscountMoney");
                    SendPropertyChanged("ListPriceSales");
                }
            }
        }
        #endregion

        #region CustomerCashDiscountMoney
        public double CustomerCashDiscountMoney
        {
            get
            {
                //return VMMath.Round(NetSalesPrice * (CustomerCashDiscountPercent / 100d));
                //return VMMath.Round((NetSalesPrice / (100d - CustomerCashDiscountPercent)) * CustomerCashDiscountPercent);
                return VMMath.Round(InvoicePrice * (CustomerCashDiscountPercent / 100d));
            }
        }
        #endregion


        #region InvoicePrice
        public double InvoicePrice
        {
            get
            {
                //return VMMath.Round(NetSalesPrice + CustomerCashDiscountMoney);
                return VMMath.Round((NetSalesPrice * 100) / (100 - CustomerCashDiscountPercent));
            }
        }
        #endregion

        #region CustomerDiscountPercent
        
        double _CustomerDiscountPercent = 0;
        public double CustomerDiscountPercent
        {
            get { return _CustomerDiscountPercent; }
            set
            {
                if (_CustomerDiscountPercent != value)
                {
                    _CustomerDiscountPercent = value;
                    SendPropertyChanged("CustomerDiscountPercent");
                    SendPropertyChanged("CustomerDiscountMoney");
                    SendPropertyChanged("ListPriceSales");
                    SendPropertyChanged("CustomerCashDiscountMoney");

                }
            }
        }
        #endregion

        #region CustomerDiscountMoney
        public double CustomerDiscountMoney
        {
            get
            {
                //return VMMath.Round((InvoicePrice / (100d - CustomerDiscountPercent)) * CustomerDiscountPercent);
                //return VMMath.Round( InvoicePrice * (CustomerDiscountPercent / 100d)); 
                return VMMath.Round(ListPriceSales * (CustomerDiscountPercent / 100d));
            }
        }
        #endregion

        #region ListPriceSales
        public double ListPriceSales
        {
            get
            {
                //return VMMath.Round(InvoicePrice + CustomerDiscountMoney); 
                return VMMath.Round((InvoicePrice * 100) / (100 - CustomerDiscountPercent));
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