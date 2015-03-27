using SwissCreateWeb.Models.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
//using ViCode_LeVi.Data;

namespace SwissCreateWeb.Data
{
    
    public class Step_BalanceAndOthers_Price : INotifyPropertyChanged
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
        #region Step_BalanceAndOthers_Price_Header
        
        string _Step_BalanceAndOthers_Price_Header = string.Empty;
        public string Step_BalanceAndOthers_Price_Header_4Report
        {
            get
            {
                //if (Report_Config_Finance.IsConvertHeaderToUpper == true)
                //    return Step_BalanceAndOthers_Price_Header.ToUpper();
                return Step_BalanceAndOthers_Price_Header;
            }
        }
        public string Step_BalanceAndOthers_Price_Header
        {
            get
            {
                if (string.IsNullOrEmpty(_Step_BalanceAndOthers_Price_Header))
                {
                    _Step_BalanceAndOthers_Price_Header = "Price Calculation";
                }
                return _Step_BalanceAndOthers_Price_Header;
            }
            set
            {
                if (_Step_BalanceAndOthers_Price_Header != value)
                {
                    _Step_BalanceAndOthers_Price_Header = value;
                    SendPropertyChanged("Step_BalanceAndOthers_Price_Header");
                }
            }
        }
        #endregion

        #region UIText_PreCalculation
        
        string _UIText_PreCalculation = string.Empty;
        public string UIText_PreCalculation
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_PreCalculation))
                {
                    _UIText_PreCalculation = "Pre Calculation";
                }
                return _UIText_PreCalculation;
            }
            set
            {
                if (_UIText_PreCalculation != value)
                {
                    _UIText_PreCalculation = value;
                    SendPropertyChanged("UIText_PreCalculation");
                }
            }
        }
        #endregion

        #region UIText_POSTCalculation
        
        string _UIText_POSTCalculation = string.Empty;
        public string UIText_POSTCalculation
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_POSTCalculation))
                {
                    _UIText_POSTCalculation = "Post Calculation";
                }
                return _UIText_POSTCalculation;
            }
            set
            {
                if (_UIText_POSTCalculation != value)
                {
                    _UIText_POSTCalculation = value;
                    SendPropertyChanged("UIText_POSTCalculation");
                }
            }
        }
        #endregion

        #region UIText_Order
        
        string _UIText_Order = string.Empty;
        public string UIText_Order
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Order))
                {
                    _UIText_Order = "Order:";
                }
                return _UIText_Order;
            }
            set
            {
                if (_UIText_Order != value)
                {
                    _UIText_Order = value;
                    SendPropertyChanged("UIText_Order");
                }
            }
        }
        #endregion

        #region UIText_Author
        
        string _UIText_Author = string.Empty;
        public string UIText_Author
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Author))
                {
                    _UIText_Author = "Author:";
                }
                return _UIText_Author;
            }
            set
            {
                if (_UIText_Author != value)
                {
                    _UIText_Author = value;
                    SendPropertyChanged("UIText_Author");
                }
            }
        }
        #endregion

        #region UIText_Date
        
        string _UIText_Date = string.Empty;
        public string UIText_Date
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Date))
                {
                    _UIText_Date = "Date:";
                }
                return _UIText_Date;
            }
            set
            {
                if (_UIText_Date != value)
                {
                    _UIText_Date = value;
                    SendPropertyChanged("UIText_Date");
                }
            }
        }
        #endregion

        #region UIText_MATERIAL
        
        string _UIText_MATERIAL = string.Empty;
        public string UIText_MATERIAL
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_MATERIAL))
                {
                    _UIText_MATERIAL = "MATERIAL";
                }
                return _UIText_MATERIAL;
            }
            set
            {
                if (_UIText_MATERIAL != value)
                {
                    _UIText_MATERIAL = value;
                    SendPropertyChanged("UIText_MATERIAL");
                }
            }
        }
        #endregion

        #region UIText_IndividualMaterial
        
        string _UIText_IndividualMaterial = string.Empty;
        public string UIText_IndividualMaterial
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_IndividualMaterial))
                {
                    _UIText_IndividualMaterial = "Individual material";
                }
                return _UIText_IndividualMaterial;
            }
            set
            {
                if (_UIText_IndividualMaterial != value)
                {
                    _UIText_IndividualMaterial = value;
                    SendPropertyChanged("UIText_IndividualMaterial");
                }
            }
        }
        #endregion

        #region UIText_Costs
        
        string _UIText_Costs = string.Empty;
        public string UIText_Costs
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Costs))
                {
                    _UIText_Costs = "Costs";
                }
                return _UIText_Costs;
            }
            set
            {
                if (_UIText_Costs != value)
                {
                    _UIText_Costs = value;
                    SendPropertyChanged("UIText_Costs");
                }
            }
        }
        #endregion

        #region UIText_MaterialOverheadCosts
        
        string _UIText_MaterialOverheadCosts = string.Empty;
        public string UIText_MaterialOverheadCosts
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_MaterialOverheadCosts))
                {
                    _UIText_MaterialOverheadCosts = "Material overhead costs:";
                }
                return _UIText_MaterialOverheadCosts;
            }
            set
            {
                if (_UIText_MaterialOverheadCosts != value)
                {
                    _UIText_MaterialOverheadCosts = value;
                    SendPropertyChanged("UIText_MaterialOverheadCosts");
                }
            }
        }
        #endregion

        #region UIText_RatePercent
        
        string _UIText_RatePercent = string.Empty;
        public string UIText_RatePercent
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_RatePercent))
                {
                    _UIText_RatePercent = "rate %:";
                }
                return _UIText_RatePercent;
            }
            set
            {
                if (_UIText_RatePercent != value)
                {
                    _UIText_RatePercent = value;
                    SendPropertyChanged("UIText_RatePercent");
                }
            }
        }
        #endregion

        #region UIText_TotalMaterialCosts
        
        string _UIText_TotalMaterialCosts = string.Empty;
        public string UIText_TotalMaterialCosts
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_TotalMaterialCosts))
                {
                    _UIText_TotalMaterialCosts = "Total Material costs";
                }
                return _UIText_TotalMaterialCosts;
            }
            set
            {
                if (_UIText_TotalMaterialCosts != value)
                {
                    _UIText_TotalMaterialCosts = value;
                    SendPropertyChanged("UIText_TotalMaterialCosts");
                }
            }
        }
        #endregion

        #region UIText_WAGES
        
        string _UIText_WAGES = string.Empty;
        public string UIText_WAGES
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_WAGES))
                {
                    _UIText_WAGES = "WAGES";
                }
                return _UIText_WAGES;
            }
            set
            {
                if (_UIText_WAGES != value)
                {
                    _UIText_WAGES = value;
                    SendPropertyChanged("UIText_WAGES");
                }
            }
        }
        #endregion

        #region UIText_DirectLaborCosts
        
        string _UIText_DirectLaborCosts = string.Empty;
        public string UIText_DirectLaborCosts
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_DirectLaborCosts))
                {
                    _UIText_DirectLaborCosts = "Direct labor costs";
                }
                return _UIText_DirectLaborCosts;
            }
            set
            {
                if (_UIText_DirectLaborCosts != value)
                {
                    _UIText_DirectLaborCosts = value;
                    SendPropertyChanged("UIText_DirectLaborCosts");
                }
            }
        }
        #endregion

        #region UIText_Hours
        
        string _UIText_Hours = string.Empty;
        public string UIText_Hours
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Hours))
                {
                    _UIText_Hours = "hours";
                }
                return _UIText_Hours;
            }
            set
            {
                if (_UIText_Hours != value)
                {
                    _UIText_Hours = value;
                    SendPropertyChanged("UIText_Hours");
                }
            }
        }
        #endregion

        #region UIText_RatePecentPerHour
        
        string _UIText_RatePecentPerHour = string.Empty;
        public string UIText_RatePecentPerHour
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_RatePecentPerHour))
                {
                    _UIText_RatePecentPerHour = "rate % / $/h";
                }
                return _UIText_RatePecentPerHour;
            }
            set
            {
                if (_UIText_RatePecentPerHour != value)
                {
                    _UIText_RatePecentPerHour = value;
                    SendPropertyChanged("UIText_RatePecentPerHour");
                }
            }
        }
        #endregion

        #region UIText_WagesOverheadCosts
        
        string _UIText_WagesOverheadCosts = string.Empty;
        public string UIText_WagesOverheadCosts
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_WagesOverheadCosts))
                {
                    _UIText_WagesOverheadCosts = "Wages overhead costs:";
                }
                return _UIText_WagesOverheadCosts;
            }
            set
            {
                if (_UIText_WagesOverheadCosts != value)
                {
                    _UIText_WagesOverheadCosts = value;
                    SendPropertyChanged("UIText_WagesOverheadCosts");
                }
            }
        }
        #endregion

        #region UIText_TotalCostsForWages
        
        string _UIText_TotalCostsForWages = string.Empty;
        public string UIText_TotalCostsForWages
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_TotalCostsForWages))
                {
                    _UIText_TotalCostsForWages = "Total Costs for wages:";
                }
                return _UIText_TotalCostsForWages;
            }
            set
            {
                if (_UIText_TotalCostsForWages != value)
                {
                    _UIText_TotalCostsForWages = value;
                    SendPropertyChanged("UIText_TotalCostsForWages");
                }
            }
        }
        #endregion

        #region UIText_DIRECTCOSTS
        
        string _UIText_DIRECTCOSTS = string.Empty;
        public string UIText_DIRECTCOSTS
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_DIRECTCOSTS))
                {
                    _UIText_DIRECTCOSTS = "DIRECT COSTS";
                }
                return _UIText_DIRECTCOSTS;
            }
            set
            {
                if (_UIText_DIRECTCOSTS != value)
                {
                    _UIText_DIRECTCOSTS = value;
                    SendPropertyChanged("UIText_DIRECTCOSTS");
                }
            }
        }
        #endregion

        #region UIText_UseOfMachinesAndEquipment
        
        string _UIText_UseOfMachinesAndEquipment = string.Empty;
        public string UIText_UseOfMachinesAndEquipment
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_UseOfMachinesAndEquipment))
                {
                    _UIText_UseOfMachinesAndEquipment = " (Use of machines and equipment)";
                }
                return _UIText_UseOfMachinesAndEquipment;
            }
            set
            {
                if (_UIText_UseOfMachinesAndEquipment != value)
                {
                    _UIText_UseOfMachinesAndEquipment = value;
                    SendPropertyChanged("UIText_UseOfMachinesAndEquipment");
                }
            }
        }
        #endregion

        #region UIText_IndividualDirectCosts
        
        string _UIText_IndividualDirectCosts = string.Empty;
        public string UIText_IndividualDirectCosts
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_IndividualDirectCosts))
                {
                    _UIText_IndividualDirectCosts = "Individual DirectCosts";
                }
                return _UIText_IndividualDirectCosts;
            }
            set
            {
                if (_UIText_IndividualDirectCosts != value)
                {
                    _UIText_IndividualDirectCosts = value;
                    SendPropertyChanged("UIText_IndividualDirectCosts");
                }
            }
        }
        #endregion

        #region UIText_TotalDirectCosts
        
        string _UIText_TotalDirectCosts = string.Empty;
        public string UIText_TotalDirectCosts
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_TotalDirectCosts))
                {
                    _UIText_TotalDirectCosts = "Total Direct Costs:";
                }
                return _UIText_TotalDirectCosts;
            }
            set
            {
                if (_UIText_TotalDirectCosts != value)
                {
                    _UIText_TotalDirectCosts = value;
                    SendPropertyChanged("UIText_TotalDirectCosts");
                }
            }
        }
        #endregion

        #region UIText_ProdutionCosts
        
        string _UIText_ProdutionCosts = string.Empty;
        public string UIText_ProdutionCosts
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_ProdutionCosts))
                {
                    _UIText_ProdutionCosts = "Prodution Costs";
                }
                return _UIText_ProdutionCosts;
            }
            set
            {
                if (_UIText_ProdutionCosts != value)
                {
                    _UIText_ProdutionCosts = value;
                    SendPropertyChanged("UIText_ProdutionCosts");
                }
            }
        }
        #endregion

        #region UIText_GeneralCostsForManagementAndAdministration
        
        string _UIText_GeneralCostsForManagementAndAdministration = string.Empty;
        public string UIText_GeneralCostsForManagementAndAdministration
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_GeneralCostsForManagementAndAdministration))
                {
                    _UIText_GeneralCostsForManagementAndAdministration = "General costs for management and Administration";
                }
                return _UIText_GeneralCostsForManagementAndAdministration;
            }
            set
            {
                if (_UIText_GeneralCostsForManagementAndAdministration != value)
                {
                    _UIText_GeneralCostsForManagementAndAdministration = value;
                    SendPropertyChanged("UIText_GeneralCostsForManagementAndAdministration");
                }
            }
        }
        #endregion

        #region UIText_ThirdpartyWorks
        
        string _UIText_ThirdpartyWorks = string.Empty;
        public string UIText_ThirdpartyWorks
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_ThirdpartyWorks))
                {
                    _UIText_ThirdpartyWorks = "Thirdparty works";
                }
                return _UIText_ThirdpartyWorks;
            }
            set
            {
                if (_UIText_ThirdpartyWorks != value)
                {
                    _UIText_ThirdpartyWorks = value;
                    SendPropertyChanged("UIText_ThirdpartyWorks");
                }
            }
        }
        #endregion

        #region UIText_PrimeCosts
        
        string _UIText_PrimeCosts = string.Empty;
        public string UIText_PrimeCosts
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_PrimeCosts))
                {
                    _UIText_PrimeCosts = "Prime Costs";
                }
                return _UIText_PrimeCosts;
            }
            set
            {
                if (_UIText_PrimeCosts != value)
                {
                    _UIText_PrimeCosts = value;
                    SendPropertyChanged("UIText_PrimeCosts");
                }
            }
        }
        #endregion

        #region UIText_RiskAndProfit
        
        string _UIText_RiskAndProfit = string.Empty;
        public string UIText_RiskAndProfit
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_RiskAndProfit))
                {
                    _UIText_RiskAndProfit = "Risk and Profit";
                }
                return _UIText_RiskAndProfit;
            }
            set
            {
                if (_UIText_RiskAndProfit != value)
                {
                    _UIText_RiskAndProfit = value;
                    SendPropertyChanged("UIText_RiskAndProfit");
                }
            }
        }
        #endregion

        #region UIText_CalculatedPrice
        
        string _UIText_CalculatedPrice = string.Empty;
        public string UIText_CalculatedPrice
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CalculatedPrice))
                {
                    _UIText_CalculatedPrice = "Calculated Price";
                }
                return _UIText_CalculatedPrice;
            }
            set
            {
                if (_UIText_CalculatedPrice != value)
                {
                    _UIText_CalculatedPrice = value;
                    SendPropertyChanged("UIText_CalculatedPrice");
                }
            }
        }
        #endregion

        #region UIText_ValueAddedTax
        
        string _UIText_ValueAddedTax = string.Empty;
        public string UIText_ValueAddedTax
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_ValueAddedTax))
                {
                    _UIText_ValueAddedTax = "Value added tax";
                }
                return _UIText_ValueAddedTax;
            }
            set
            {
                if (_UIText_ValueAddedTax != value)
                {
                    _UIText_ValueAddedTax = value;
                    SendPropertyChanged("UIText_ValueAddedTax");
                }
            }
        }
        #endregion

        #region UIText_SALSEPRICE
        
        string _UIText_SALSEPRICE = string.Empty;
        public string UIText_SALSEPRICE
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_SALSEPRICE))
                {
                    _UIText_SALSEPRICE = "SALSE PRICE";
                }
                return _UIText_SALSEPRICE;
            }
            set
            {
                if (_UIText_SALSEPRICE != value)
                {
                    _UIText_SALSEPRICE = value;
                    SendPropertyChanged("UIText_SALSEPRICE");
                }
            }
        }
        #endregion
        #endregion


        public string CompanyName { get { return ProjectData.Intance.CompanyName; } }
        #region IsPreCalculation
        
        bool _IsPreCalculation = true;
        public bool IsPreCalculation
        {
            get { return _IsPreCalculation; }
            set
            {
                if (_IsPreCalculation != value)
                {
                    _IsPreCalculation = value;
                    SendPropertyChanged("IsPreCalculation");
                    SendPropertyChanged("IsPostCalculation");
                }
            }
        }
        public bool IsPostCalculation
        {
            get { return !_IsPreCalculation; }
            set
            {
                if (_IsPreCalculation == value)
                {
                    _IsPreCalculation = !value;
                    SendPropertyChanged("IsPostCalculation");
                    SendPropertyChanged("IsPreCalculation");
                }
            }
        }

        #endregion

        #region Order
        
        string _Order = string.Empty;
        public string Order
        {
            get { return _Order; }
            set
            {
                if (_Order != value)
                {
                    _Order = value;
                    SendPropertyChanged("Order");
                }
            }
        }
        #endregion

        #region Author
        
        string _Author = string.Empty;
        public string Author
        {
            get { return _Author; }
            set
            {
                if (_Author != value)
                {
                    _Author = value;
                    SendPropertyChanged("Author");
                }
            }
        }
        #endregion

        #region Date
        
        DateTime _Date = DateTime.Now;
        public DateTime Date
        {
            get { return _Date; }
            set
            {
                if (_Date != value)
                {
                    _Date = value;
                    SendPropertyChanged("Date");
                }
            }
        }
        #endregion

        #region Material
        #region MaterialItems
        
        List<Step_BalanceAndOthers_Price_Material> _MaterialItems = null;
        public Step_BalanceAndOthers_Price_Material[] MaterialItems
        {
            get
            {
                if (_MaterialItems == null)
                    _MaterialItems = new List<Step_BalanceAndOthers_Price_Material>();
                if (_MaterialItems.Count == 0)
                    AddMaterialItems(new Step_BalanceAndOthers_Price_Material());
                return _MaterialItems.ToArray();
            }
        }
        public void AddMaterialItems(Step_BalanceAndOthers_Price_Material newItem)
        {
            if (_MaterialItems == null)
                _MaterialItems = new List<Step_BalanceAndOthers_Price_Material>();
            _MaterialItems.Add(newItem);
            SendPropertyChanged("MaterialItems");
            newItem.PropertyChanged -= new PropertyChangedEventHandler(MaterialItems_newItem_PropertyChanged);
            newItem.PropertyChanged += new PropertyChangedEventHandler(MaterialItems_newItem_PropertyChanged);
        }

        void MaterialItems_newItem_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            SendPropertyChanged("Material_RatePercent");
            SendPropertyChanged("MaterialOverHeadCosts");
            SendPropertyChanged("TotalMaterialCosts");
            SendPropertyChanged("ProdutionCosts");
            SendPropertyChanged("GeneralCosts");
            SendPropertyChanged("RiskAndProfitCosts");
            SendPropertyChanged("ValueAddedTaxCosts");
            SendPropertyChanged("SalesPrice");
            SendPropertyChanged("PrimeCosts");
            SendPropertyChanged("CalculatedPrice");
        }
        public void RemoveMaterialItems(Step_BalanceAndOthers_Price_Material removeItem)
        {
            if (_MaterialItems == null)
                _MaterialItems = new List<Step_BalanceAndOthers_Price_Material>();
            if (_MaterialItems.Count() == 1)
            {
                removeItem.IndividualMaterial = string.Empty;
                removeItem.Costs = 0;
            }
            else
            {
                this._MaterialItems.Remove(removeItem);
            }
            SendPropertyChanged("MaterialItems");
        }
        #endregion

        #region Material_RatePercent
        
        double _Material_RatePercent = 0;
        public double Material_RatePercent
        {
            get { return _Material_RatePercent; }
            set
            {
                if (_Material_RatePercent != value)
                {
                    _Material_RatePercent = value;
                    SendPropertyChanged("Material_RatePercent");
                    SendPropertyChanged("MaterialOverHeadCosts");
                    SendPropertyChanged("TotalMaterialCosts");
                    SendPropertyChanged("ProdutionCosts");
                    SendPropertyChanged("GeneralCosts");
                    SendPropertyChanged("RiskAndProfitCosts");
                    SendPropertyChanged("ValueAddedTaxCosts");
                    SendPropertyChanged("SalesPrice");
                    SendPropertyChanged("PrimeCosts");
                    SendPropertyChanged("CalculatedPrice");
                }
            }
        }
        #endregion

        public double MaterialOverHeadCosts
        {
            get
            {
                if (MaterialItems == null || MaterialItems.Length == 0)
                    return 0;
                return VMMath.Round(MaterialItems.Sum(c => c.Costs) * Material_RatePercent / 100d);
            }
        }
        public double TotalMaterialCosts
        {
            get
            {
                if (MaterialItems == null || MaterialItems.Length == 0)
                    return 0;
                return VMMath.Round(MaterialItems.Sum(c => c.Costs) + MaterialOverHeadCosts);
            }
        }
        #endregion

        #region Wages
        #region WagesItems
        
        List<Step_BalanceAndOthers_Price_Wages> _WagesItems = null;
        public Step_BalanceAndOthers_Price_Wages[] WagesItems
        {
            get
            {
                if (_WagesItems == null)
                    _WagesItems = new List<Step_BalanceAndOthers_Price_Wages>();
                if (_WagesItems.Count == 0)
                    AddWagesItems(new Step_BalanceAndOthers_Price_Wages());
                return _WagesItems.ToArray();
            }
        }
        public void AddWagesItems(Step_BalanceAndOthers_Price_Wages newItem)
        {
            if (_WagesItems == null)
                _WagesItems = new List<Step_BalanceAndOthers_Price_Wages>();
            _WagesItems.Add(newItem);
            SendPropertyChanged("WagesItems");
            newItem.PropertyChanged -= new PropertyChangedEventHandler(WagesItems_newItem_PropertyChanged);
            newItem.PropertyChanged += new PropertyChangedEventHandler(WagesItems_newItem_PropertyChanged);
        }

        void WagesItems_newItem_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            SendPropertyChanged("Wages_RatePercent");
            SendPropertyChanged("WagesOverHeadCosts");
            SendPropertyChanged("TotalWagesCosts");
            SendPropertyChanged("ProdutionCosts");
            SendPropertyChanged("GeneralCosts");
            SendPropertyChanged("RiskAndProfitCosts");
            SendPropertyChanged("ValueAddedTaxCosts");
            SendPropertyChanged("SalesPrice");
            SendPropertyChanged("PrimeCosts");
            SendPropertyChanged("CalculatedPrice");
        }
        public void RemoveWagesItems(Step_BalanceAndOthers_Price_Wages removeItem)
        {
            if (_WagesItems == null)
                _WagesItems = new List<Step_BalanceAndOthers_Price_Wages>();
            if (_WagesItems.Count() == 1)
            {
                removeItem.DirectLaborCosts = string.Empty;
                removeItem.RatePerHour = 0;
                removeItem.Hours = 0;
            }
            else
            {
                this._WagesItems.Remove(removeItem);
            }
            SendPropertyChanged("WagesItems");
        }
        #endregion

        #region Wages_RatePercent
        
        double _Wages_RatePercent = 0;
        public double Wages_RatePercent
        {
            get { return _Wages_RatePercent; }
            set
            {
                if (_Wages_RatePercent != value)
                {
                    _Wages_RatePercent = value;
                    SendPropertyChanged("Wages_RatePercent");
                    SendPropertyChanged("WagesOverHeadCosts");
                    SendPropertyChanged("TotalWagesCosts");
                    SendPropertyChanged("ProdutionCosts");
                    SendPropertyChanged("GeneralCosts");
                    SendPropertyChanged("RiskAndProfitCosts");
                    SendPropertyChanged("ValueAddedTaxCosts");
                    SendPropertyChanged("SalesPrice");
                    SendPropertyChanged("PrimeCosts");
                    SendPropertyChanged("CalculatedPrice");
                }
            }
        }
        #endregion

        public double WagesOverHeadCosts
        {
            get
            {
                if (WagesItems == null || WagesItems.Length == 0)
                    return 0;
                return VMMath.Round(WagesItems.Sum(c => c.Costs) * Wages_RatePercent / 100d);
            }
        }
        public double TotalWagesCosts
        {
            get
            {
                if (WagesItems == null || WagesItems.Length == 0)
                    return 0;
                return VMMath.Round(WagesItems.Sum(c => c.Costs) + WagesOverHeadCosts);
            }
        }
        #endregion

        #region DirectCosts
        #region DirectCostsItems
        
        List<Step_BalanceAndOthers_Price_DirectCosts> _DirectCostsItems = null;
        public Step_BalanceAndOthers_Price_DirectCosts[] DirectCostsItems
        {
            get
            {
                if (_DirectCostsItems == null)
                    _DirectCostsItems = new List<Step_BalanceAndOthers_Price_DirectCosts>();
                if (_DirectCostsItems.Count == 0)
                    AddDirectCostsItems(new Step_BalanceAndOthers_Price_DirectCosts());
                if (_DirectCostsItems != null)
                {
                    foreach (var newItem in _DirectCostsItems)
                    {
                        newItem.PropertyChanged -= new PropertyChangedEventHandler(DirectCostsItems_newItem_PropertyChanged);
                        newItem.PropertyChanged += new PropertyChangedEventHandler(DirectCostsItems_newItem_PropertyChanged);
                    }
                }
                return _DirectCostsItems.ToArray();
            }
        }
        public void AddDirectCostsItems(Step_BalanceAndOthers_Price_DirectCosts newItem)
        {
            if (_DirectCostsItems == null)
                _DirectCostsItems = new List<Step_BalanceAndOthers_Price_DirectCosts>();
            _DirectCostsItems.Add(newItem);
            SendPropertyChanged("DirectCostsItems");
            DirectCostsItems_newItem_PropertyChanged(null, null);
            newItem.PropertyChanged -= new PropertyChangedEventHandler(DirectCostsItems_newItem_PropertyChanged);
            newItem.PropertyChanged += new PropertyChangedEventHandler(DirectCostsItems_newItem_PropertyChanged);
        }

        void DirectCostsItems_newItem_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            SendPropertyChanged("DirectCosts_RatePercent");
            SendPropertyChanged("DirectCostsOverHeadCosts");
            SendPropertyChanged("TotalDirectCostsCosts");
            SendPropertyChanged("ProdutionCosts");
            SendPropertyChanged("GeneralCosts");
            SendPropertyChanged("RiskAndProfitCosts");
            SendPropertyChanged("ValueAddedTaxCosts");
            SendPropertyChanged("SalesPrice");
            SendPropertyChanged("PrimeCosts");
            SendPropertyChanged("CalculatedPrice");
        }
        public void RemoveDirectCostsItems(Step_BalanceAndOthers_Price_DirectCosts removeItem)
        {
            if (_DirectCostsItems == null)
                _DirectCostsItems = new List<Step_BalanceAndOthers_Price_DirectCosts>();
            if (_DirectCostsItems.Count() == 1)
            {
                removeItem.IndividualDirectCosts = string.Empty;
                removeItem.Hours = 0;
                removeItem.RatePerHour = 0;
            }
            else
            {
                this._DirectCostsItems.Remove(removeItem);
            }
            SendPropertyChanged("DirectCostsItems");
            DirectCostsItems_newItem_PropertyChanged(null, null);
        }
        #endregion

        #region DirectCosts_RatePercent
        
        double _DirectCosts_RatePercent = 0;
        public double DirectCosts_RatePercent
        {
            get { return _DirectCosts_RatePercent; }
            set
            {
                if (_DirectCosts_RatePercent != value)
                {
                    _DirectCosts_RatePercent = value;
                    SendPropertyChanged("DirectCosts_RatePercent");
                    SendPropertyChanged("DirectCostsOverHeadCosts");
                    SendPropertyChanged("TotalDirectCostsCosts");
                    SendPropertyChanged("ProdutionCosts");
                    SendPropertyChanged("GeneralCosts");
                    SendPropertyChanged("RiskAndProfitCosts");
                    SendPropertyChanged("ValueAddedTaxCosts");
                    SendPropertyChanged("SalesPrice");
                    SendPropertyChanged("PrimeCosts");
                    SendPropertyChanged("CalculatedPrice");
                }
            }
        }
        #endregion

        public double DirectCostsOverHeadCosts
        {
            get
            {
                if (DirectCostsItems == null || DirectCostsItems.Length == 0)
                    return 0;
                return VMMath.Round(DirectCostsItems.Sum(c => c.Costs) * DirectCosts_RatePercent / 100d);
            }
        }
        public double TotalDirectCostsCosts
        {
            get
            {
                if (DirectCostsItems == null || DirectCostsItems.Length == 0)
                    return 0;
                return VMMath.Round(DirectCostsItems.Sum(c => c.Costs) + DirectCostsOverHeadCosts);
            }
        }
        #endregion

        #region ProdutionCosts
        public double ProdutionCosts
        {
            get { return VMMath.Round(TotalDirectCostsCosts + TotalMaterialCosts + TotalWagesCosts); }
        }
        #endregion

        #region General Costs
        #region General_RatePercent
        
        double _General_RatePercent = 0;
        public double General_RatePercent
        {
            get { return _General_RatePercent; }
            set
            {
                if (_General_RatePercent != value)
                {
                    _General_RatePercent = value;
                    SendPropertyChanged("General_RatePercent");
                    SendPropertyChanged("GeneralCosts");
                    SendPropertyChanged("RiskAndProfitCosts");
                    SendPropertyChanged("ValueAddedTaxCosts");
                    SendPropertyChanged("SalesPrice");
                    SendPropertyChanged("PrimeCosts");
                    SendPropertyChanged("CalculatedPrice");
                }
            }
        }
        #endregion
        public double GeneralCosts
        {
            get { return VMMath.Round(ProdutionCosts * General_RatePercent / 100d); }
        }
        #endregion

        #region Thirdparty works
        #region ThirdpartyWorks
        
        double _ThirdpartyWorks = 0;
        public double ThirdpartyWorks
        {
            get { return _ThirdpartyWorks; }
            set
            {
                if (_ThirdpartyWorks != value)
                {
                    _ThirdpartyWorks = value;
                    SendPropertyChanged("ThirdpartyWorks");
                    SendPropertyChanged("RiskAndProfitCosts");
                    SendPropertyChanged("ValueAddedTaxCosts");
                    SendPropertyChanged("SalesPrice");
                    SendPropertyChanged("PrimeCosts");
                    SendPropertyChanged("CalculatedPrice");
                }
            }
        }
        #endregion
        #endregion

        #region PrimeCosts
        public double PrimeCosts
        {
            get { return VMMath.Round(ProdutionCosts + GeneralCosts + ThirdpartyWorks); }
        }
        #endregion

        #region RiskAndProfit
        #region RiskAndProfit_RatePercent
        
        double _RiskAndProfit_RatePercent = 0;
        public double RiskAndProfit_RatePercent
        {
            get { return _RiskAndProfit_RatePercent; }
            set
            {
                if (_RiskAndProfit_RatePercent != value)
                {
                    _RiskAndProfit_RatePercent = value;
                    SendPropertyChanged("RiskAndProfit_RatePercent");
                    SendPropertyChanged("RiskAndProfitCosts");
                    SendPropertyChanged("PrimeCosts");
                    SendPropertyChanged("CalculatedPrice");
                    SendPropertyChanged("ValueAddedTaxCosts");
                    SendPropertyChanged("SalesPrice");
                }
            }
        }
        #endregion
        public double RiskAndProfitCosts
        {
            get { return VMMath.Round(PrimeCosts * RiskAndProfit_RatePercent / 100d); }
        }
        #endregion

        #region CalculatedPrice
        public double CalculatedPrice
        {
            get { return VMMath.Round(PrimeCosts + RiskAndProfitCosts); }
        }
        #endregion

        #region ValueAddedTax
        #region ValueAddedTax_RatePercent
        
        double _ValueAddedTax_RatePercent = 0;
        public double ValueAddedTax_RatePercent
        {
            get { return _ValueAddedTax_RatePercent; }
            set
            {
                if (_ValueAddedTax_RatePercent != value)
                {
                    _ValueAddedTax_RatePercent = value;
                    SendPropertyChanged("ValueAddedTax_RatePercent");
                    SendPropertyChanged("ValueAddedTaxCosts");
                    SendPropertyChanged("SalesPrice");
                }
            }
        }
        #endregion
        public double ValueAddedTaxCosts
        {
            get { return VMMath.Round(CalculatedPrice * ValueAddedTax_RatePercent / 100d); }
        }
        #endregion

        #region SalesPrice
        public double SalesPrice
        {
            get { return VMMath.Round(CalculatedPrice + ValueAddedTaxCosts); }
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