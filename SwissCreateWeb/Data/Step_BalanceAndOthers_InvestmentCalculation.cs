using SwissCreateWeb.Models.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using ViCode_LeVi.Data;

namespace ViCode_LeVi.Data
{
    public class Step_BalanceAndOthers_InvestmentCalculation : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        double Round(double number)
        {
            //return VMMath.Round(number);
            return number;
        }

        public string CompanyName { get { return ProjectData.Intance.CompanyName; } }
        #region ProjectName
        
        string _ProjectName = string.Empty;
        public string ProjectName
        {
            get { return _ProjectName; }
            set
            {
                if (_ProjectName != value)
                {
                    _ProjectName = value;
                    SendPropertyChanged("ProjectName");
                }
            }
        }
        #endregion

        #region UI
        #region Step_BalanceAndOthers_InvestmentCalculation_Header
        
        string _Step_BalanceAndOthers_InvestmentCalculation_Header = string.Empty;
        public string Step_BalanceAndOthers_InvestmentCalculation_Header_4Report
        {
            get
            {
                //if (Report_Config_Finance.IsConvertHeaderToUpper == true)
                //    return Step_BalanceAndOthers_InvestmentCalculation_Header.ToUpper();
                return Step_BalanceAndOthers_InvestmentCalculation_Header;
            }
        }
        public string Step_BalanceAndOthers_InvestmentCalculation_Header
        {
            get
            {
                if (string.IsNullOrEmpty(_Step_BalanceAndOthers_InvestmentCalculation_Header))
                {
                    _Step_BalanceAndOthers_InvestmentCalculation_Header = "Investment Calculation";
                }
                return _Step_BalanceAndOthers_InvestmentCalculation_Header;
            }
            set
            {
                if (_Step_BalanceAndOthers_InvestmentCalculation_Header != value)
                {
                    _Step_BalanceAndOthers_InvestmentCalculation_Header = value;
                    SendPropertyChanged("Step_BalanceAndOthers_InvestmentCalculation_Header");
                }
            }
        }
        #endregion

        #region Group_Project
        
        string _Group_Project = string.Empty;
        public string Group_Project
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Project))
                {
                    _Group_Project = "Project";
                }
                return _Group_Project;
            }
            set
            {
                if (_Group_Project != value)
                {
                    _Group_Project = value;
                    SendPropertyChanged("Group_Project");
                }
            }
        }
        #endregion

        #region Goals
        #region Group_Goals
        
        string _Group_Goals = string.Empty;
        public string Group_Goals
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Goals))
                {
                    _Group_Goals = "Goals";
                }
                return _Group_Goals;
            }
            set
            {
                if (_Group_Goals != value)
                {
                    _Group_Goals = value;
                    SendPropertyChanged("Group_Goals");
                }
            }
        }
        #endregion

        #region Group_Goals_DesiredRentability
        
        string _Group_Goals_DesiredRentability = string.Empty;
        public string Group_Goals_DesiredRentability
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Goals_DesiredRentability))
                {
                    _Group_Goals_DesiredRentability = "Desired Rentability";
                }
                return _Group_Goals_DesiredRentability;
            }
            set
            {
                if (_Group_Goals_DesiredRentability != value)
                {
                    _Group_Goals_DesiredRentability = value;
                    SendPropertyChanged("Group_Goals_DesiredRentability");
                }
            }
        }
        #endregion

        #region Group_Goals_PercentSign
        
        string _Group_Goals_PercentSign = string.Empty;
        public string Group_Goals_PercentSign
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Goals_PercentSign))
                {
                    _Group_Goals_PercentSign = "%";
                }
                return _Group_Goals_PercentSign;
            }
            set
            {
                if (_Group_Goals_PercentSign != value)
                {
                    _Group_Goals_PercentSign = value;
                    SendPropertyChanged("Group_Goals_PercentSign");
                }
            }
        }
        #endregion

        #region Group_Goals_LifeTime
        
        string _Group_Goals_LifeTime = string.Empty;
        public string Group_Goals_LifeTime
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Goals_LifeTime))
                {
                    _Group_Goals_LifeTime = "Life time";
                }
                return _Group_Goals_LifeTime;
            }
            set
            {
                if (_Group_Goals_LifeTime != value)
                {
                    _Group_Goals_LifeTime = value;
                    SendPropertyChanged("Group_Goals_LifeTime");
                }
            }
        }
        #endregion

        #region Group_Goals_Year
        
        string _Group_Goals_Year = string.Empty;
        public string Group_Goals_Year
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Goals_Year))
                {
                    _Group_Goals_Year = "years";
                }
                return _Group_Goals_Year;
            }
            set
            {
                if (_Group_Goals_Year != value)
                {
                    _Group_Goals_Year = value;
                    SendPropertyChanged("Group_Goals_Year");
                }
            }
        }
        #endregion


        #endregion

        #region Investment
        #region Group_Investment
        
        string _Group_Investment = string.Empty;
        public string Group_Investment
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Investment))
                {
                    _Group_Investment = "Investment";
                }
                return _Group_Investment;
            }
            set
            {
                if (_Group_Investment != value)
                {
                    _Group_Investment = value;
                    SendPropertyChanged("Group_Investment");
                }
            }
        }
        #endregion

        #region Group_Investment_InvestmentCosts
        
        string _Group_Investment_InvestmentCosts = string.Empty;
        public string Group_Investment_InvestmentCosts
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Investment_InvestmentCosts))
                {
                    _Group_Investment_InvestmentCosts = "Investment costs";
                }
                return _Group_Investment_InvestmentCosts;
            }
            set
            {
                if (_Group_Investment_InvestmentCosts != value)
                {
                    _Group_Investment_InvestmentCosts = value;
                    SendPropertyChanged("Group_Investment_InvestmentCosts");
                }
            }
        }
        #endregion

        #region Group_Investment_AdditionalCosts
        
        string _Group_Investment_AdditionalCosts = string.Empty;
        public string Group_Investment_AdditionalCosts
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Investment_AdditionalCosts))
                {
                    _Group_Investment_AdditionalCosts = "Additional costs";
                }
                return _Group_Investment_AdditionalCosts;
            }
            set
            {
                if (_Group_Investment_AdditionalCosts != value)
                {
                    _Group_Investment_AdditionalCosts = value;
                    SendPropertyChanged("Group_Investment_AdditionalCosts");
                }
            }
        }
        #endregion

        #region Group_Investment_GrossInvestment
        
        string _Group_Investment_GrossInvestment = string.Empty;
        public string Group_Investment_GrossInvestment
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Investment_GrossInvestment))
                {
                    _Group_Investment_GrossInvestment = "Gross Investment";
                }
                return _Group_Investment_GrossInvestment;
            }
            set
            {
                if (_Group_Investment_GrossInvestment != value)
                {
                    _Group_Investment_GrossInvestment = value;
                    SendPropertyChanged("Group_Investment_GrossInvestment");
                }
            }
        }
        #endregion

        #region Group_Investment_LiquidationValue
        
        string _Group_Investment_LiquidationValue = string.Empty;
        public string Group_Investment_LiquidationValue
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Investment_LiquidationValue))
                {
                    _Group_Investment_LiquidationValue = "Liquidation value";
                }
                return _Group_Investment_LiquidationValue;
            }
            set
            {
                if (_Group_Investment_LiquidationValue != value)
                {
                    _Group_Investment_LiquidationValue = value;
                    SendPropertyChanged("Group_Investment_LiquidationValue");
                }
            }
        }
        #endregion

        #region Group_Investment_NetInvestment
        
        string _Group_Investment_NetInvestment = string.Empty;
        public string Group_Investment_NetInvestment
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Investment_NetInvestment))
                {
                    _Group_Investment_NetInvestment = "Investment";
                }
                return _Group_Investment_NetInvestment;
            }
            set
            {
                if (_Group_Investment_NetInvestment != value)
                {
                    _Group_Investment_NetInvestment = value;
                    SendPropertyChanged("Group_Investment_NetInvestment");
                }
            }
        }
        #endregion
        #endregion

        #region Group_Investment_MoneySign
        
        string _Group_Investment_MoneySign = string.Empty;
        public string Group_Investment_MoneySign
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Investment_MoneySign))
                {
                    _Group_Investment_MoneySign = "$";
                }
                return _Group_Investment_MoneySign;
            }
            set
            {
                if (_Group_Investment_MoneySign != value)
                {
                    _Group_Investment_MoneySign = value;
                    SendPropertyChanged("Group_Investment_MoneySign");
                }
            }
        }
        #endregion

        #region Group_Earning
        #region Group_Earning
        
        string _Group_Earning = string.Empty;
        public string Group_Earning
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Earning))
                {
                    _Group_Earning = "Earning";
                }
                return _Group_Earning;
            }
            set
            {
                if (_Group_Earning != value)
                {
                    _Group_Earning = value;
                    SendPropertyChanged("Group_Earning");
                }
            }
        }
        #endregion

        #region Group_Earning_EarningsPerYear
        
        string _Group_Earning_EarningsPerYear = string.Empty;
        public string Group_Earning_EarningsPerYear
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Earning_EarningsPerYear))
                {
                    _Group_Earning_EarningsPerYear = "Earnings per year";
                }
                return _Group_Earning_EarningsPerYear;
            }
            set
            {
                if (_Group_Earning_EarningsPerYear != value)
                {
                    _Group_Earning_EarningsPerYear = value;
                    SendPropertyChanged("Group_Earning_EarningsPerYear");
                }
            }
        }
        #endregion

        #region Group_Earning_TotalEarnings
        
        string _Group_Earning_TotalEarnings = string.Empty;
        public string Group_Earning_TotalEarnings
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Earning_TotalEarnings))
                {
                    _Group_Earning_TotalEarnings = "Total earnings";
                }
                return _Group_Earning_TotalEarnings;
            }
            set
            {
                if (_Group_Earning_TotalEarnings != value)
                {
                    _Group_Earning_TotalEarnings = value;
                    SendPropertyChanged("Group_Earning_TotalEarnings");
                }
            }
        }
        #endregion
        #endregion

        #region Group_FixedCostsPerYear
        #region Group_FixedCostsPerYear
        
        string _Group_FixedCostsCerYear = string.Empty;
        public string Group_FixedCostsPerYear
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_FixedCostsCerYear))
                {
                    _Group_FixedCostsCerYear = "Fixed costs per year";
                }
                return _Group_FixedCostsCerYear;
            }
            set
            {
                if (_Group_FixedCostsCerYear != value)
                {
                    _Group_FixedCostsCerYear = value;
                    SendPropertyChanged("Group_Fixed costs per year");
                }
            }
        }
        #endregion

        #region Group_FixedCostsPerYear_PercentInterest
        
        string _Group_FixedCostsPerYear_PercentInterest = string.Empty;
        public string Group_FixedCostsPerYear_PercentInterest
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_FixedCostsPerYear_PercentInterest))
                {
                    _Group_FixedCostsPerYear_PercentInterest = "% Interest";
                }
                return _Group_FixedCostsPerYear_PercentInterest;
            }
            set
            {
                if (_Group_FixedCostsPerYear_PercentInterest != value)
                {
                    _Group_FixedCostsPerYear_PercentInterest = value;
                    SendPropertyChanged("Group_FixedCostsPerYear_PercentInterest");
                }
            }
        }
        #endregion

        #region Group_FixedCostsPerYear_Depreciation
        
        string _Group_FixedCostsPerYear_Depreciation = string.Empty;
        public string Group_FixedCostsPerYear_Depreciation
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_FixedCostsPerYear_Depreciation))
                {
                    _Group_FixedCostsPerYear_Depreciation = "Depreciation";
                }
                return _Group_FixedCostsPerYear_Depreciation;
            }
            set
            {
                if (_Group_FixedCostsPerYear_Depreciation != value)
                {
                    _Group_FixedCostsPerYear_Depreciation = value;
                    SendPropertyChanged("Group_FixedCostsPerYear_Depreciation");
                }
            }
        }
        #endregion

        #region Group_FixedCostsPerYear_IndirectLaborCosts
        
        string _Group_FixedCostsPerYear_IndirectLaborCosts = string.Empty;
        public string Group_FixedCostsPerYear_IndirectLaborCosts
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_FixedCostsPerYear_IndirectLaborCosts))
                {
                    _Group_FixedCostsPerYear_IndirectLaborCosts = "Indirect labor costs";
                }
                return _Group_FixedCostsPerYear_IndirectLaborCosts;
            }
            set
            {
                if (_Group_FixedCostsPerYear_IndirectLaborCosts != value)
                {
                    _Group_FixedCostsPerYear_IndirectLaborCosts = value;
                    SendPropertyChanged("Group_FixedCostsPerYear_IndirectLaborCosts");
                }
            }
        }
        #endregion

        #region Group_FixedCostsPerYear_OtherFixedCosts
        
        string _Group_FixedCostsPerYear_OtherFixedCosts = string.Empty;
        public string Group_FixedCostsPerYear_OtherFixedCosts
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_FixedCostsPerYear_OtherFixedCosts))
                {
                    _Group_FixedCostsPerYear_OtherFixedCosts = "Other fixed costs";
                }
                return _Group_FixedCostsPerYear_OtherFixedCosts;
            }
            set
            {
                if (_Group_FixedCostsPerYear_OtherFixedCosts != value)
                {
                    _Group_FixedCostsPerYear_OtherFixedCosts = value;
                    SendPropertyChanged("Group_FixedCostsPerYear_OtherFixedCosts");
                }
            }
        }
        #endregion

        #region Group_FixedCostsPerYear_Sum
        
        string _Group_FixedCostsPerYear_Sum = string.Empty;
        public string Group_FixedCostsPerYear_Sum
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_FixedCostsPerYear_Sum))
                {
                    _Group_FixedCostsPerYear_Sum = "Sum";
                }
                return _Group_FixedCostsPerYear_Sum;
            }
            set
            {
                if (_Group_FixedCostsPerYear_Sum != value)
                {
                    _Group_FixedCostsPerYear_Sum = value;
                    SendPropertyChanged("Group_FixedCostsPerYear_Sum");
                }
            }
        }
        #endregion

        #endregion

        #region Group_VariableCostsPerYear
        #region Group_VariableCostsPerYear
        
        string _Group_VariableCostsPerYear = string.Empty;
        public string Group_VariableCostsPerYear
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_VariableCostsPerYear))
                {
                    _Group_VariableCostsPerYear = "Variable costs per year";
                }
                return _Group_VariableCostsPerYear;
            }
            set
            {
                if (_Group_VariableCostsPerYear != value)
                {
                    _Group_VariableCostsPerYear = value;
                    SendPropertyChanged("Group_VariableCostsPerYear");
                }
            }
        }
        #endregion

        #region Group_VariableCostsPerYear_VariableWages
        
        string _Group_VariableCostsPerYear_VariableWages = string.Empty;
        public string Group_VariableCostsPerYear_VariableWages
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_VariableCostsPerYear_VariableWages))
                {
                    _Group_VariableCostsPerYear_VariableWages = "Variable wages";
                }
                return _Group_VariableCostsPerYear_VariableWages;
            }
            set
            {
                if (_Group_VariableCostsPerYear_VariableWages != value)
                {
                    _Group_VariableCostsPerYear_VariableWages = value;
                    SendPropertyChanged("Group_VariableCostsPerYear_VariableWages");
                }
            }
        }
        #endregion

        #region Group_VariableCostsPerYear_VariableMaterialCosts
        
        string _Group_VariableCostsPerYear_VariableMaterialCosts = string.Empty;
        public string Group_VariableCostsPerYear_VariableMaterialCosts
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_VariableCostsPerYear_VariableMaterialCosts))
                {
                    _Group_VariableCostsPerYear_VariableMaterialCosts = "Variable material costs";
                }
                return _Group_VariableCostsPerYear_VariableMaterialCosts;
            }
            set
            {
                if (_Group_VariableCostsPerYear_VariableMaterialCosts != value)
                {
                    _Group_VariableCostsPerYear_VariableMaterialCosts = value;
                    SendPropertyChanged("Group_VariableCostsPerYear_VariableMaterialCosts");
                }
            }
        }
        #endregion

        #region Group_VariableCostsPerYear_OtherVariableCosts
        
        string _Group_VariableCostsPerYear_OtherVariableCosts = string.Empty;
        public string Group_VariableCostsPerYear_OtherVariableCosts
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_VariableCostsPerYear_OtherVariableCosts))
                {
                    _Group_VariableCostsPerYear_OtherVariableCosts = "Other variable costs";
                }
                return _Group_VariableCostsPerYear_OtherVariableCosts;
            }
            set
            {
                if (_Group_VariableCostsPerYear_OtherVariableCosts != value)
                {
                    _Group_VariableCostsPerYear_OtherVariableCosts = value;
                    SendPropertyChanged("Group_VariableCostsPerYear_OtherVariableCosts");
                }
            }
        }
        #endregion

        #region Group_VariableCostsPerYear_Sum
        
        string _Group_VariableCostsPerYear_Sum = string.Empty;
        public string Group_VariableCostsPerYear_Sum
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_VariableCostsPerYear_Sum))
                {
                    _Group_VariableCostsPerYear_Sum = "Sum";
                }
                return _Group_VariableCostsPerYear_Sum;
            }
            set
            {
                if (_Group_VariableCostsPerYear_Sum != value)
                {
                    _Group_VariableCostsPerYear_Sum = value;
                    SendPropertyChanged("Group_VariableCostsPerYear_Sum");
                }
            }
        }
        #endregion
        #endregion

        #region Group_TotalCosts
        #region Group_TotalCosts
        
        string _Group_TotalCosts = string.Empty;
        public string Group_TotalCosts
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_TotalCosts))
                {
                    _Group_TotalCosts = "Total costs";
                }
                return _Group_TotalCosts;
            }
            set
            {
                if (_Group_TotalCosts != value)
                {
                    _Group_TotalCosts = value;
                    SendPropertyChanged("Group_TotalCosts");
                }
            }
        }
        #endregion

        #region Group_TotalCosts_PerYear_Sum
        
        string _Group_TotalCosts_PerYear_Sum = string.Empty;
        public string Group_TotalCosts_PerYear_Sum
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_TotalCosts_PerYear_Sum))
                {
                    _Group_TotalCosts_PerYear_Sum = "per year | over all";
                }
                return _Group_TotalCosts_PerYear_Sum;
            }
            set
            {
                if (_Group_TotalCosts_PerYear_Sum != value)
                {
                    _Group_TotalCosts_PerYear_Sum = value;
                    SendPropertyChanged("Group_TotalCosts_PerYear_Sum");
                }
            }
        }
        #endregion
        #endregion

        #region Group_Result
        #region Group_Result
        
        string _Group_Result = string.Empty;
        public string Group_Result
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Result))
                {
                    _Group_Result = "Result";
                }
                return _Group_Result;
            }
            set
            {
                if (_Group_Result != value)
                {
                    _Group_Result = value;
                    SendPropertyChanged("Group_Result");
                }
            }
        }
        #endregion

        #region Group_Result_ResultPerYear
        
        string _Group_Result_ResultPerYear = string.Empty;
        public string Group_Result_ResultPerYear
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Result_ResultPerYear))
                {
                    _Group_Result_ResultPerYear = "Result per year";
                }
                return _Group_Result_ResultPerYear;
            }
            set
            {
                if (_Group_Result_ResultPerYear != value)
                {
                    _Group_Result_ResultPerYear = value;
                    SendPropertyChanged("Group_Result_ResultPerYear");
                }
            }
        }
        #endregion

        #region Group_Result_Rentability
        
        string _Group_Result_Rentability = string.Empty;
        public string Group_Result_Rentability
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Result_Rentability))
                {
                    _Group_Result_Rentability = "Rentability";
                }
                return _Group_Result_Rentability;
            }
            set
            {
                if (_Group_Result_Rentability != value)
                {
                    _Group_Result_Rentability = value;
                    SendPropertyChanged("Group_Result_Rentability");
                }
            }
        }
        #endregion

        #region Group_Result_Rentability_PercentSign
        
        string _Group_Result_Rentability_PercentSign = string.Empty;
        public string Group_Result_Rentability_PercentSign
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Result_Rentability_PercentSign))
                {
                    _Group_Result_Rentability_PercentSign = "%";
                }
                return _Group_Result_Rentability_PercentSign;
            }
            set
            {
                if (_Group_Result_Rentability_PercentSign != value)
                {
                    _Group_Result_Rentability_PercentSign = value;
                    SendPropertyChanged("Group_Result_Rentability_PercentSign");
                }
            }
        }
        #endregion

        #region Group_Result_ResultTotal
        
        string _Group_Result_ResultTotal = string.Empty;
        public string Group_Result_ResultTotal
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Result_ResultTotal))
                {
                    _Group_Result_ResultTotal = "Result total";
                }
                return _Group_Result_ResultTotal;
            }
            set
            {
                if (_Group_Result_ResultTotal != value)
                {
                    _Group_Result_ResultTotal = value;
                    SendPropertyChanged("Group_Result_ResultTotal");
                }
            }
        }
        #endregion

        #region Group_Result_ResultTotal_LiquidationValueConsidered
        
        string _Group_Result_ResultTotal_LiquidationValueConsidered = string.Empty;
        public string Group_Result_ResultTotal_LiquidationValueConsidered
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_Result_ResultTotal_LiquidationValueConsidered))
                {
                    _Group_Result_ResultTotal_LiquidationValueConsidered = "liquidation value considered";
                }
                return _Group_Result_ResultTotal_LiquidationValueConsidered;
            }
            set
            {
                if (_Group_Result_ResultTotal_LiquidationValueConsidered != value)
                {
                    _Group_Result_ResultTotal_LiquidationValueConsidered = value;
                    SendPropertyChanged("Group_Result_ResultTotal_LiquidationValueConsidered");
                }
            }
        }
        #endregion
        #endregion
        #endregion



        #region Goals
        #region DesiredRentability
        
        double _DesiredRentability = 0;
        public double DesiredRentability
        {
            get { return _DesiredRentability; }
            set
            {
                if (_DesiredRentability != value)
                {
                    _DesiredRentability = value;
                    SendPropertyChanged("DesiredRentability");
                    SendPropertyChanged("ResultPerYear");
                    SendPropertyChanged("ResultTotal");
                    SendPropertyChanged("Rentability");
                }
            }
        }
        #endregion
        #region LifeTime
        
        int _LifeTime = 0;
        public int LifeTime
        {
            get { return _LifeTime; }
            set
            {
                if (_LifeTime != value)
                {
                    _LifeTime = value;
                    SendPropertyChanged("LifeTime");
                    SendPropertyChanged("TotalEarnings");
                    SendPropertyChanged("FixedCostsSum");
                    SendPropertyChanged("TotalCostSum1");
                    SendPropertyChanged("TotalCostSum2");
                    SendPropertyChanged("ResultPerYear");
                    SendPropertyChanged("ResultTotal");
                    SendPropertyChanged("Rentability");
                }
            }
        }
        #endregion
        #endregion

        #region Investment
        #region InvestmentCosts
        
        double _InvestmentCosts = 0;
        public double InvestmentCosts
        {
            get { return _InvestmentCosts; }
            set
            {
                if (_InvestmentCosts != value)
                {
                    _InvestmentCosts = value;
                    SendPropertyChanged("InvestmentCosts");
                    SendPropertyChanged("GrossInvestment");
                    SendPropertyChanged("Depreciation");
                    SendPropertyChanged("FixedCostsSum");
                    SendPropertyChanged("InterestMoney");
                    SendPropertyChanged("NetInvestment");
                    SendPropertyChanged("TotalCostSum1");
                    SendPropertyChanged("TotalCostSum2");
                }
            }
        }
        #endregion

        #region AdditionalCosts
        
        double _AdditionalCosts = 0;
        public double AdditionalCosts
        {
            get { return _AdditionalCosts; }
            set
            {
                if (_AdditionalCosts != value)
                {
                    _AdditionalCosts = value;
                    SendPropertyChanged("AdditionalCosts");
                    SendPropertyChanged("GrossInvestment");
                    SendPropertyChanged("Depreciation");
                    SendPropertyChanged("FixedCostsSum");
                    SendPropertyChanged("InterestMoney");
                    SendPropertyChanged("NetInvestment");
                    SendPropertyChanged("TotalCostSum1");
                    SendPropertyChanged("TotalCostSum2");
                    SendPropertyChanged("ResultPerYear");
                    SendPropertyChanged("ResultTotal");
                    SendPropertyChanged("Rentability");
                }
            }
        }
        #endregion

        #region GrossInvestment
        public double GrossInvestment
        {
            get { return Round(InvestmentCosts + AdditionalCosts); }
        }
        #endregion

        #region LiquidationValue
        
        double _LiquidationValue = 0;
        public double LiquidationValue
        {
            get { return _LiquidationValue; }
            set
            {
                if (_LiquidationValue != value)
                {
                    _LiquidationValue = value;
                    SendPropertyChanged("LiquidationValue");
                    SendPropertyChanged("NetInvestment");
                    SendPropertyChanged("ResultPerYear");
                    SendPropertyChanged("ResultTotal");
                    SendPropertyChanged("Rentability");
                    SendPropertyChanged("ResultPerYear");
                    SendPropertyChanged("ResultTotal");
                    SendPropertyChanged("Rentability");
                }
            }
        }
        #endregion

        #region NetInvestment
        public double NetInvestment
        {
            get { return Round(GrossInvestment - LiquidationValue); }
        }
        #endregion
        #endregion

        #region Earning
        #region EarningsPerYear
        
        double _EarningsPerYear = 0;
        public double EarningsPerYear
        {
            get { return _EarningsPerYear; }
            set
            {
                if (_EarningsPerYear != value)
                {
                    _EarningsPerYear = value;
                    SendPropertyChanged("EarningsPerYear");
                    SendPropertyChanged("TotalEarnings");
                    SendPropertyChanged("ResultPerYear");
                    SendPropertyChanged("ResultTotal");
                    SendPropertyChanged("Rentability");
                }
            }
        }
        #endregion

        #region TotalEarnings
        public double TotalEarnings
        {
            get { return Round(EarningsPerYear * LifeTime); }
        }
        #endregion
        #endregion

        #region Fixed costs per year
        #region InterestPercent
        
        double _InterestPercent = 0;
        public double InterestPercent
        {
            get { return _InterestPercent; }
            set
            {
                if (_InterestPercent != value)
                {
                    _InterestPercent = value;
                    SendPropertyChanged("InterestPercent");
                    SendPropertyChanged("InterestMoney");
                    SendPropertyChanged("FixedCostsSum");
                    SendPropertyChanged("TotalCostSum1");
                    SendPropertyChanged("TotalCostSum2");
                    SendPropertyChanged("ResultPerYear");
                    SendPropertyChanged("ResultTotal");
                    SendPropertyChanged("Rentability");
                }
            }
        }
        #endregion

        #region InterestMoney
        public double InterestMoney
        {
            get { return Round((InterestPercent * GrossInvestment) / 100); }
        }
        #endregion

        #region Depreciation
        public double Depreciation
        {
            get { return Round((GrossInvestment) / LifeTime); }
        }
        #endregion

        #region IndirectLaborCosts
        
        double _IndirectLaborCosts = 0;
        public double IndirectLaborCosts
        {
            get { return _IndirectLaborCosts; }
            set
            {
                if (_IndirectLaborCosts != value)
                {
                    _IndirectLaborCosts = value;
                    SendPropertyChanged("IndirectLaborCosts");
                    SendPropertyChanged("FixedCostsSum");
                    SendPropertyChanged("TotalCostSum1");
                    SendPropertyChanged("TotalCostSum2");
                    SendPropertyChanged("ResultPerYear");
                    SendPropertyChanged("ResultTotal");
                    SendPropertyChanged("Rentability");
                }
            }
        }
        #endregion

        #region OtherFixedCosts
        
        double _OtherFixedCosts = 0;
        public double OtherFixedCosts
        {
            get { return _OtherFixedCosts; }
            set
            {
                if (_OtherFixedCosts != value)
                {
                    _OtherFixedCosts = value;
                    SendPropertyChanged("OtherFixedCosts");
                    SendPropertyChanged("FixedCostsSum");
                    SendPropertyChanged("TotalCostSum1");
                    SendPropertyChanged("TotalCostSum2");
                    SendPropertyChanged("ResultPerYear");
                    SendPropertyChanged("ResultTotal");
                    SendPropertyChanged("Rentability");
                }
            }
        }
        #endregion

        #region FixedCostsSum
        public double FixedCostsSum
        {
            get { return Round(InterestMoney + Depreciation + IndirectLaborCosts + OtherFixedCosts); }
        }
        #endregion
        #endregion

        #region Variable costs per year
        #region VariableWages
        
        double _VariableWages = 0;
        public double VariableWages
        {
            get { return _VariableWages; }
            set
            {
                if (_VariableWages != value)
                {
                    _VariableWages = value;
                    SendPropertyChanged("VariableWages");
                    SendPropertyChanged("VariableCostsSum");
                    SendPropertyChanged("TotalCostSum1");
                    SendPropertyChanged("TotalCostSum2");
                    SendPropertyChanged("ResultPerYear");
                    SendPropertyChanged("ResultTotal");
                    SendPropertyChanged("Rentability");
                }
            }
        }
        #endregion

        #region VariableaterialCosts
        
        double _VariableaterialCosts = 0;
        public double VariableaterialCosts
        {
            get { return _VariableaterialCosts; }
            set
            {
                if (_VariableaterialCosts != value)
                {
                    _VariableaterialCosts = value;
                    SendPropertyChanged("VariableaterialCosts");
                    SendPropertyChanged("VariableCostsSum");
                    SendPropertyChanged("TotalCostSum1");
                    SendPropertyChanged("TotalCostSum2");
                    SendPropertyChanged("ResultPerYear");
                    SendPropertyChanged("ResultTotal");
                    SendPropertyChanged("Rentability");
                }
            }
        }
        #endregion

        #region OtherVariableCosts
        
        double _OtherVariableCosts = 0;
        public double OtherVariableCosts
        {
            get { return _OtherVariableCosts; }
            set
            {
                if (_OtherVariableCosts != value)
                {
                    _OtherVariableCosts = value;
                    SendPropertyChanged("OtherVariableCosts");
                    SendPropertyChanged("VariableCostsSum");
                    SendPropertyChanged("TotalCostSum1");
                    SendPropertyChanged("TotalCostSum2");
                    SendPropertyChanged("ResultPerYear");
                    SendPropertyChanged("ResultTotal");
                    SendPropertyChanged("Rentability");
                }
            }
        }
        #endregion

        #region VariableCostsSum
        public double VariableCostsSum
        {
            get { return Round(VariableWages + VariableaterialCosts + OtherVariableCosts); }
        }
        #endregion
        #endregion

        #region TotalCostSum
        public double TotalCostSum1
        {
            get { return Round(FixedCostsSum + VariableCostsSum); }
        }
        public double TotalCostSum2
        {
            get { return Round(TotalCostSum1 * LifeTime); }
        }
        #endregion

        #region Result
        public double ResultPerYear
        {
            get { return Round(EarningsPerYear - TotalCostSum1); }
        }
        public double ResultTotal
        {
            get { return Round(TotalEarnings - TotalCostSum2 + LiquidationValue); }
        }
        public double Rentability
        {
            get { return Round((ResultPerYear * 100) / GrossInvestment); }
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