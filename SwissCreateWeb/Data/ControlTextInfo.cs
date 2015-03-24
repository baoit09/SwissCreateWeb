using SwissCreateWeb.Models.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Web;

namespace SwissCreateWeb.Data
{
    public class ControlTextInfo : INotifyPropertyChanged
    {
        #region CurrencySymbol
        public static bool JustUse1CurrencySymbolInProject = true;
        public static List<Action> List_Action_CurrencySymbolChanged = new List<Action>();
        
        string _CurrencySymbol = string.Empty;
        public string CurrencySymbol
        {
            get
            {
                if (string.IsNullOrEmpty(_CurrencySymbol))
                    _CurrencySymbol = CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol;
                return _CurrencySymbol;
            }
            set
            {
                if (_CurrencySymbol != value)
                {
                    _CurrencySymbol = value;
                    if (List_Action_CurrencySymbolChanged != null
                        && List_Action_CurrencySymbolChanged.Count > 0)
                    {
                        foreach (var action in List_Action_CurrencySymbolChanged)
                        {
                            action();
                        }
                    }
                }
            }
        }
        #endregion

        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public void SendPropertyChanged()
        {
            var props = this.GetType().GetProperties();
            foreach (var prop in props)
            {
                SendPropertyChanged(prop.Name);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
        static ControlTextInfo _Intance;
        public static ControlTextInfo Intance
        {
            get
            {
                //if (_Intance == null)
                //{
                //    _Intance = LangManager.CreateDefault_VI();
                //}
                //if (_Intance.IsRunRefine == false)
                //    RefineData(Intance);
                return _Intance;
            }
            set
            {
                _Intance = value;
                if (_Intance != null)
                {
                    _Intance.SendPropertyChanged();
                    RefineData(_Intance);
                }
            }
        }
        public static void RefineData(ControlTextInfo item)
        {
            //item.IsRunRefine = true;
            //var lang = LangManager.CreateDefault_VI();
            //var props = typeof(ControlTextInfo).GetProperties();
            //foreach (var prop in props)
            //{
            //    var oldV = prop.GetValue(item);
            //    if (oldV == null)
            //    {
            //        var newV = prop.GetValue(lang);
            //        prop.SetValue(item, newV);
            //    }
            //}
        }
        public bool IsRunRefine { get; set; }

        
        public string Application_Title { get; set; }
        
        public string Measure_Alert_Title { get; set; }
        
        public string Menu_Project { get; set; }
        
        public string Menu_Project_CreateNew { get; set; }
        
        public string Menu_Project_Open { get; set; }
        
        public string Menu_Project_Save { get; set; }
        
        public string Menu_Project_SaveAs { get; set; }
        
        public string Menu_Project_DesignMode { get; set; }
        
        public string Menu_Project_DesignRiskInfo { get; set; }
        
        public string Menu_Project_ModifyProjectInfo { get; set; }

        
        public string Menu_Operation { get; set; }
        
        public string Menu_Lang { get; set; }
        
        public string Menu_Lang_VI { get; set; }
        
        public string Menu_Lang_EN { get; set; }


        
        public string Dialog_File4Saving_Title { get; set; }

        
        public string Dialog_File4Opening_Title { get; set; }


        
        public string Group_StepResult_Header { get; set; }

        
        public string TextBlock_Filter_Task_Text { get; set; }
        
        public string Button_Content_Detail { get; set; }
        
        public string Button_Content_OK { get; set; }
        
        public string Button_Content_Cancel { get; set; }
        
        public string Button_Content_Edit { get; set; }
        
        public string Button_Content_Delete { get; set; }
        
        public string Button_Content_Show { get; set; }
        
        public string Button_Content_AddNew { get; set; }

        
        public string ComboBox_ItemAll_Text { get; set; }

        
        public string RiskManagementItem_RiskNo_Text { get; set; }
        
        public string RiskManagementItem_Risk_Text { get; set; }
        
        public string RiskManagementItem_Impact_Text { get; set; }
        
        public string RiskManagementItem_Probability_Text { get; set; }
        
        public string RiskManagementItem_Manage_Text { get; set; }

        
        public string TaskItem_ID_Text { get; set; }
        
        public string TaskItem_Name_Text { get; set; }
        
        public string TaskItem_IsActive_Text { get; set; }
        
        public string TaskItem_Define_Text { get; set; }
        
        public string TaskItem_WeightText { get; set; }
        
        public string TaskItem_WeightReasonText { get; set; }
        
        public string TaskItem_Quantity_Text { get; set; }
        
        public string TaskItem_Quality_Text { get; set; }
        
        public string TaskItem_Systematic_Text { get; set; }
        
        public string TaskItem_Question_Text { get; set; }
        
        public string TaskItem_Anwser_Text { get; set; }
        
        public string TaskItem_ISTWeight_Percent_Text { get; set; }
        
        public string TaskItem_Evaluation_Text { get; set; }
        
        public string TaskItem_Control_Detail_Text { get; set; }

        
        public string Measurement_Title_Text { get; set; }
        
        public string Measurement_Start_Text { get; set; }
        
        public string Measurement_IsIgnore_Text { get; set; }
        
        public string Measurement_Duration_Text { get; set; }
        /// <summary>
        /// Đơn vị ngày
        /// </summary>
        
        public string Measurement_UnitDay_Text { get; set; }
        
        public string Measurement_Deadline_Text { get; set; }
        
        public string Measurement_Status_Text { get; set; }
        
        public string Measurement_ResponsiblePerson_Text { get; set; }
        
        public string Measurement_Department_Text { get; set; }
        
        public string Measurement_GoalOutCome_Text { get; set; }
        
        public string Measurement_Procedure_Text { get; set; }
        
        public string Measurement_Expenses_Text { get; set; }
        
        public string Measurement_ExpertedBenefits_Text { get; set; }


        #region Conclution_ExternalDocuments_Item
        
        public string Conclution_ExternalDocuments_Item_Name_Text { get; set; }
        
        public string Conclution_ExternalDocuments_Item_Link_Text { get; set; }
        
        public string Conclution_ExternalDocuments_Item_Note_Text { get; set; }
        #endregion
    }


    
    public partial class ControlTextInfoInData : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public void SendPropertyChanged()
        {
            var props = this.GetType().GetProperties();
            foreach (var prop in props)
            {
                SendPropertyChanged(prop.Name);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        //static ControlTextInfoInData _Intance;
        public static ControlTextInfoInData Intance
        {
            get
            {
                //if (_Intance == null)
                //{
                return ProjectData.Intance.ControlTextInfoInData;
                //}
                //return _Intance;
            }
            //set
            //{
            //    _Intance = value;
            //    if (_Intance != null)
            //    {
            //        _Intance.SendPropertyChanged();
            //    }
            //}
        }

        
        public string TextBlock_Filter_Task_Text { get; set; }

        #region Button
        #region Button_Content_Detail
        
        string _Button_Content_Detail;
        public string Button_Content_Detail
        {
            get
            {
                if (string.IsNullOrEmpty(_Button_Content_Detail))
                    _Button_Content_Detail = "Detail";
                return _Button_Content_Detail;
            }
            set
            {
                if (_Button_Content_Detail != value)
                {
                    _Button_Content_Detail = value;
                    SendPropertyChanged("Button_Content_Detail");
                }
            }
        }
        #endregion

        #region Button_Content_OK
        
        string _Button_Content_OK;
        public string Button_Content_OK
        {
            get
            {
                if (string.IsNullOrEmpty(_Button_Content_OK))
                    _Button_Content_OK = "OK";
                return _Button_Content_OK;
            }
            set
            {
                if (_Button_Content_OK != value)
                {
                    _Button_Content_OK = value;
                    SendPropertyChanged("Button_Content_OK");
                }
            }
        }
        #endregion

        #region Button_Content_Cancel
        
        string _Button_Content_Cancel;
        public string Button_Content_Cancel
        {
            get
            {
                if (string.IsNullOrEmpty(_Button_Content_Cancel))
                    _Button_Content_Cancel = "Cancel";
                return _Button_Content_Cancel;
            }
            set
            {
                if (_Button_Content_Cancel != value)
                {
                    _Button_Content_Cancel = value;
                    SendPropertyChanged("Button_Content_Cancel");
                }
            }
        }
        #endregion

        #region Button_Content_Edit
        
        string _Button_Content_Edit;
        public string Button_Content_Edit
        {
            get
            {
                if (string.IsNullOrEmpty(_Button_Content_Edit))
                    _Button_Content_Edit = "Edit";
                return _Button_Content_Edit;
            }
            set
            {
                if (_Button_Content_Edit != value)
                {
                    _Button_Content_Edit = value;
                    SendPropertyChanged("Button_Content_Edit");
                }
            }
        }
        #endregion

        #region Button_Content_Delete
        
        string _Button_Content_Delete;
        public string Button_Content_Delete
        {
            get
            {
                if (string.IsNullOrEmpty(_Button_Content_Delete))
                    _Button_Content_Delete = "Delete";
                return _Button_Content_Delete;
            }
            set
            {
                if (_Button_Content_Delete != value)
                {
                    _Button_Content_Delete = value;
                    SendPropertyChanged("Button_Content_Delete");
                }
            }
        }
        #endregion

        #region Button_Content_Show
        
        string _Button_Content_Show;
        public string Button_Content_Show
        {
            get
            {
                if (string.IsNullOrEmpty(_Button_Content_Show))
                    _Button_Content_Show = "Show";
                return _Button_Content_Show;
            }
            set
            {
                if (_Button_Content_Show != value)
                {
                    _Button_Content_Show = value;
                    SendPropertyChanged("Button_Content_Show");
                }
            }
        }
        #endregion

        #region Button_Content_AddNew
        
        string _Button_Content_AddNew;
        public string Button_Content_AddNew
        {
            get
            {
                if (string.IsNullOrEmpty(_Button_Content_AddNew))
                    _Button_Content_AddNew = "Add New";
                return _Button_Content_AddNew;
            }
            set
            {
                if (_Button_Content_AddNew != value)
                {
                    _Button_Content_AddNew = value;
                    SendPropertyChanged("Button_Content_AddNew");
                }
            }
        }
        #endregion
        #endregion

        
        public string ComboBox_ItemAll_Text { get; set; }

        #region Group_StepResult_Header
        
        string _Group_StepResult_Header;
        public string Group_StepResult_Header
        {
            get
            {
                if (string.IsNullOrEmpty(_Group_StepResult_Header))
                    _Group_StepResult_Header = "Comment";
                return _Group_StepResult_Header;
            }
            set
            {
                if (_Group_StepResult_Header != value)
                {
                    _Group_StepResult_Header = value;
                    SendPropertyChanged("Group_StepResult_Header");
                }
            }
        }
        public string UI_Comment
        {
            get { return Group_StepResult_Header; }
            set { Group_StepResult_Header = value; }
        }
        public string UI_Comment_Dot
        {
            get { return UI_Comment + "..."; }
        }
        public string UI_Comments
        {
            get { return UI_Comment; }// +"s"; }
        }
        #endregion

        #region UI_STRATEGYFORMULATION
        
        string _UI_STRATEGYFORMULATION;
        public string UI_STRATEGYFORMULATION
        {
            get
            {
                //return RootData.Intance.Report_BusinessStrategy;
                //if (string.IsNullOrEmpty(_UI_STRATEGYFORMULATION))
                //    _UI_STRATEGYFORMULATION = "STRATEGY FORMULATION";
                //return _UI_STRATEGYFORMULATION;
                return string.Empty;
            }
            set
            {
                if (_UI_STRATEGYFORMULATION != value)
                {
                    _UI_STRATEGYFORMULATION = value;
                    SendPropertyChanged("UI_STRATEGYFORMULATION");
                }
            }
        }
        #endregion

        #region Analysis
        #region Analysis_Interpretation_Text
        
        string _Analysis_Interpretation_Text;
        public string Analysis_Interpretation_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Analysis_Interpretation_Text))
                    _Analysis_Interpretation_Text = "Interpretation:";
                return _Analysis_Interpretation_Text;
            }
            set
            {
                if (_Analysis_Interpretation_Text != value)
                {
                    _Analysis_Interpretation_Text = value;
                    SendPropertyChanged("Analysis_Interpretation_Text");
                }
            }
        }
        #endregion
        #endregion

        #region TaskItem
        #region TaskItem_ID_Text
        
        string _TaskItem_ID_Text;
        public string TaskItem_ID_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_TaskItem_ID_Text))
                    _TaskItem_ID_Text = "ID";
                return _TaskItem_ID_Text;
            }
            set
            {
                if (_TaskItem_ID_Text != value)
                {
                    _TaskItem_ID_Text = value;
                    SendPropertyChanged("TaskItem_ID_Text");
                }
            }
        }
        #endregion
        #region RiskManagementItem_RiskNo_Text
        
        string _RiskManagementItem_RiskNo_Text;
        public string RiskManagementItem_RiskNo_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_RiskManagementItem_RiskNo_Text))
                    _RiskManagementItem_RiskNo_Text = "No";
                return _RiskManagementItem_RiskNo_Text;
            }
            set
            {
                if (_RiskManagementItem_RiskNo_Text != value)
                {
                    _RiskManagementItem_RiskNo_Text = value;
                    SendPropertyChanged("RiskManagementItem_RiskNo_Text");
                }
            }
        }
        #endregion

        #region RiskManagementItem_Risk_Text
        
        string _RiskManagementItem_Risk_Text;
        public string RiskManagementItem_Risk_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_RiskManagementItem_Risk_Text))
                    _RiskManagementItem_Risk_Text = "Risk Name";
                return _RiskManagementItem_Risk_Text;
            }
            set
            {
                if (_RiskManagementItem_Risk_Text != value)
                {
                    _RiskManagementItem_Risk_Text = value;
                    SendPropertyChanged("RiskManagementItem_Risk_Text");
                }
            }
        }
        #endregion

        #region RiskManagementItem_Impact_Text
        
        string _RiskManagementItem_Impact_Text;
        public string RiskManagementItem_Impact_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_RiskManagementItem_Impact_Text))
                    _RiskManagementItem_Impact_Text = "Impact";
                return _RiskManagementItem_Impact_Text;
            }
            set
            {
                if (_RiskManagementItem_Impact_Text != value)
                {
                    _RiskManagementItem_Impact_Text = value;
                    SendPropertyChanged("RiskManagementItem_Impact_Text");
                }
            }
        }
        #endregion

        #region RiskManagementItem_Probability_Text
        
        string _RiskManagementItem_Probability_Text;
        public string RiskManagementItem_Probability_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_RiskManagementItem_Probability_Text))
                    _RiskManagementItem_Probability_Text = "Probability";
                return _RiskManagementItem_Probability_Text;
            }
            set
            {
                if (_RiskManagementItem_Probability_Text != value)
                {
                    _RiskManagementItem_Probability_Text = value;
                    SendPropertyChanged("RiskManagementItem_Probability_Text");
                }
            }
        }
        #endregion

        #region RiskManagementItem_Manage_Text
        
        string _RiskManagementItem_Manage_Text;
        public string RiskManagementItem_Manage_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_RiskManagementItem_Manage_Text))
                    _RiskManagementItem_Manage_Text = "Manage";
                return _RiskManagementItem_Manage_Text;
            }
            set
            {
                if (_RiskManagementItem_Manage_Text != value)
                {
                    _RiskManagementItem_Manage_Text = value;
                    SendPropertyChanged("RiskManagementItem_Manage_Text");
                }
            }
        }
        #endregion

        #region RiskManagement_EnumData_ID_Text
        
        string _RiskManagement_EnumData_ID_Text;
        public string RiskManagement_EnumData_ID_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_RiskManagement_EnumData_ID_Text))
                    _RiskManagement_EnumData_ID_Text = "Mark";
                return _RiskManagement_EnumData_ID_Text;
            }
            set
            {
                if (_RiskManagement_EnumData_ID_Text != value)
                {
                    _RiskManagement_EnumData_ID_Text = value;
                    SendPropertyChanged("RiskManagement_EnumData_ID_Text");
                }
            }
        }
        #endregion

        #region RiskManagement_EnumData_Name_Text
        
        string _RiskManagement_EnumData_Name_Text;
        public string RiskManagement_EnumData_Name_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_RiskManagement_EnumData_Name_Text))
                    _RiskManagement_EnumData_Name_Text = "Description";
                return _RiskManagement_EnumData_Name_Text;
            }
            set
            {
                if (_RiskManagement_EnumData_Name_Text != value)
                {
                    _RiskManagement_EnumData_Name_Text = value;
                    SendPropertyChanged("RiskManagement_EnumData_Name_Text");
                }
            }
        }
        #endregion

        #region Risk_Impact_Text
        
        string _Risk_Impact_Text;
        public string Risk_Impact_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Risk_Impact_Text))
                    _Risk_Impact_Text = "Impact";
                return _Risk_Impact_Text;
            }
            set
            {
                if (_Risk_Impact_Text != value)
                {
                    _Risk_Impact_Text = value;
                    SendPropertyChanged("Risk_Impact_Text");
                }
            }
        }
        #endregion

        #region Risk_Impact_Sort_Header
        
        string _Risk_Impact_Sort_Header;
        public string Risk_Impact_Sort_Header
        {
            get
            {
                if (string.IsNullOrEmpty(_Risk_Impact_Sort_Header))
                    _Risk_Impact_Sort_Header = "Edit ";
                return _Risk_Impact_Sort_Header;
            }
            set
            {
                if (_Risk_Impact_Sort_Header != value)
                {
                    _Risk_Impact_Sort_Header = value;
                    SendPropertyChanged("Risk_Impact_Sort_Header");
                }
            }
        }
        #endregion

        #region Risk_Impact_Full_Header
        
        string _Risk_Impact_Full_Header;
        public string Risk_Impact_Full_Header
        {
            get
            {
                if (string.IsNullOrEmpty(_Risk_Impact_Full_Header))
                    _Risk_Impact_Full_Header = "Edit description ";
                return _Risk_Impact_Full_Header;
            }
            set
            {
                if (_Risk_Impact_Full_Header != value)
                {
                    _Risk_Impact_Full_Header = value;
                    SendPropertyChanged("Risk_Impact_Full_Header");
                }
            }
        }
        #endregion

        #region Risk_Probability_Text
        
        string _Risk_Probability_Text;
        public string Risk_Probability_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Risk_Probability_Text))
                    _Risk_Probability_Text = "Probability";
                return _Risk_Probability_Text;
            }
            set
            {
                if (_Risk_Probability_Text != value)
                {
                    _Risk_Probability_Text = value;
                    SendPropertyChanged("Risk_Probability_Text");
                }
            }
        }
        #endregion

        #region Risk_Probability_Sort_Header
        
        string _Risk_Probability_Sort_Header;
        public string Risk_Probability_Sort_Header
        {
            get
            {
                if (string.IsNullOrEmpty(_Risk_Probability_Sort_Header))
                    _Risk_Probability_Sort_Header = "Edit";
                return _Risk_Probability_Sort_Header;
            }
            set
            {
                if (_Risk_Probability_Sort_Header != value)
                {
                    _Risk_Probability_Sort_Header = value;
                    SendPropertyChanged("Risk_Probability_Sort_Header");
                }
            }
        }
        #endregion

        #region Risk_Probability_Full_Header
        
        string _Risk_Probability_Full_Header;
        public string Risk_Probability_Full_Header
        {
            get
            {
                if (string.IsNullOrEmpty(_Risk_Probability_Full_Header))
                    _Risk_Probability_Full_Header = "Edit description";
                return _Risk_Probability_Full_Header;
            }
            set
            {
                if (_Risk_Probability_Full_Header != value)
                {
                    _Risk_Probability_Full_Header = value;
                    SendPropertyChanged("Risk_Probability_Full_Header");
                }
            }
        }
        #endregion

        #region Step_Budget_Name_Text
        
        string _Step_Budget_Name_Text;
        public string Step_Budget_Name_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Step_Budget_Name_Text))
                    _Step_Budget_Name_Text = "Name: ";
                return _Step_Budget_Name_Text;
            }
            set
            {
                if (_Step_Budget_Name_Text != value)
                {
                    _Step_Budget_Name_Text = value;
                    SendPropertyChanged("Step_Budget_Name_Text");
                }
            }
        }
        #endregion

        #region Step_Budget_ChartHeader_Text
        
        string _Step_Budget_ChartHeader_Text;
        public string Step_Budget_ChartHeader_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Step_Budget_ChartHeader_Text))
                    _Step_Budget_ChartHeader_Text = "Chart";
                return _Step_Budget_ChartHeader_Text;
            }
            set
            {
                if (_Step_Budget_ChartHeader_Text != value)
                {
                    _Step_Budget_ChartHeader_Text = value;
                    SendPropertyChanged("Step_Budget_ChartHeader_Text");
                    SendPropertyChanged("Step_Budget_ChartHeader_1_Text");
                    SendPropertyChanged("Step_Budget_ChartHeader_2_Text");
                }
            }
        }
        public string Step_Budget_ChartHeader_1_Text
        {
            get { return Step_Budget_ChartHeader_Text + " 1"; }
        }
        public string Step_Budget_ChartHeader_2_Text
        {
            get { return Step_Budget_ChartHeader_Text + " 2"; }
        }
        #endregion

        #region Step_Budget_Cost_Text
        
        string _Step_Budget_Cost_Text;
        public string Step_Budget_Cost_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Step_Budget_Cost_Text))
                    _Step_Budget_Cost_Text = "Cost: ";
                return _Step_Budget_Cost_Text;
            }
            set
            {
                if (_Step_Budget_Cost_Text != value)
                {
                    _Step_Budget_Cost_Text = value;
                    SendPropertyChanged("Step_Budget_Cost_Text");
                }
            }
        }
        #endregion

        #region Step_Budget_Total_Cost_Text
        
        string _Step_Budget_Total_Cost_Text;
        public string Step_Budget_Total_Cost_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Step_Budget_Total_Cost_Text))
                    _Step_Budget_Total_Cost_Text = "  Total Cost: ";
                return _Step_Budget_Total_Cost_Text;
            }
            set
            {
                if (_Step_Budget_Total_Cost_Text != value)
                {
                    _Step_Budget_Total_Cost_Text = value;
                    SendPropertyChanged("Step_Budget_Total_Cost_Text");
                }
            }
        }
        #endregion
        #region Step_Budget_Note_Text
        
        string _Step_Budget_Note_Text;
        public string Step_Budget_Note_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Step_Budget_Note_Text))
                    _Step_Budget_Note_Text = "Note";
                return _Step_Budget_Note_Text;
            }
            set
            {
                if (_Step_Budget_Note_Text != value)
                {
                    _Step_Budget_Note_Text = value;
                    SendPropertyChanged("Step_Budget_Note_Text");
                }
            }
        }
        #endregion
        #region TaskItem_Name_Text
        
        string _TaskItem_Name_Text;
        public string TaskItem_Name_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_TaskItem_Name_Text))
                    _TaskItem_Name_Text = "Title";
                return _TaskItem_Name_Text;
            }
            set
            {
                if (_TaskItem_Name_Text != value)
                {
                    _TaskItem_Name_Text = value;
                    SendPropertyChanged("TaskItem_Name_Text");
                }
            }
        }
        #endregion

        #region TaskItem_IsActive_Text
        
        string _TaskItem_IsActive_Text;
        public string TaskItem_IsActive_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_TaskItem_IsActive_Text))
                    _TaskItem_IsActive_Text = "Active";
                return _TaskItem_IsActive_Text;
            }
            set
            {
                if (_TaskItem_IsActive_Text != value)
                {
                    _TaskItem_IsActive_Text = value;
                    SendPropertyChanged("TaskItem_IsActive_Text");
                }
            }
        }
        #endregion

        #region TaskItem_Define_Text
        
        string _TaskItem_Define_Text;
        public string TaskItem_Define_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_TaskItem_Define_Text))
                    _TaskItem_Define_Text = "Definition";
                return _TaskItem_Define_Text;
            }
            set
            {
                if (_TaskItem_Define_Text != value)
                {
                    _TaskItem_Define_Text = value;
                    SendPropertyChanged("TaskItem_Define_Text");
                }
            }
        }
        #endregion

        #region TaskItem_WeightText
        
        string _TaskItem_WeightText;
        public string TaskItem_WeightText
        {
            get
            {
                if (string.IsNullOrEmpty(_TaskItem_WeightText))
                    _TaskItem_WeightText = "Weight";
                return _TaskItem_WeightText;
            }
            set
            {
                if (_TaskItem_WeightText != value)
                {
                    _TaskItem_WeightText = value;
                    SendPropertyChanged("TaskItem_WeightText");
                }
            }
        }
        #endregion

        #region TaskItem_WeightReasonText
        
        string _TaskItem_WeightReasonText;
        public string TaskItem_WeightReasonText
        {
            get
            {
                if (string.IsNullOrEmpty(_TaskItem_WeightReasonText))
                    _TaskItem_WeightReasonText = "Reason of Weight";
                return _TaskItem_WeightReasonText;
            }
            set
            {
                if (_TaskItem_WeightReasonText != value)
                {
                    _TaskItem_WeightReasonText = value;
                    SendPropertyChanged("TaskItem_WeightReasonText");
                }
            }
        }
        #endregion

        #region TaskItem_Quantity_Text
        
        string _TaskItem_Quantity_Text;
        public string TaskItem_Quantity_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_TaskItem_Quantity_Text))
                    _TaskItem_Quantity_Text = "Quantity(in %)";
                return _TaskItem_Quantity_Text;
            }
            set
            {
                if (this == ControlTextInfoInData.Intance)
                {
                }
                else
                {
                }
                if (_TaskItem_Quantity_Text != value)
                {
                    _TaskItem_Quantity_Text = value;
                    SendPropertyChanged("TaskItem_Quantity_Text");
                }
            }
        }
        #endregion

        #region TaskItem_Quality_Text
        
        string _TaskItem_Quality_Text;
        public string TaskItem_Quality_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_TaskItem_Quality_Text))
                    _TaskItem_Quality_Text = "Quality(in %)";
                return _TaskItem_Quality_Text;
            }
            set
            {
                if (_TaskItem_Quality_Text != value)
                {
                    _TaskItem_Quality_Text = value;
                    SendPropertyChanged("TaskItem_Quality_Text");
                }
            }
        }
        #endregion

        #region TaskItem_Systematic_Text
        
        string _TaskItem_Systematic_Text;
        public string TaskItem_Systematic_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_TaskItem_Systematic_Text))
                    _TaskItem_Systematic_Text = "Systematic(in %)";
                return _TaskItem_Systematic_Text;
            }
            set
            {
                if (_TaskItem_Systematic_Text != value)
                {
                    _TaskItem_Systematic_Text = value;
                    SendPropertyChanged("TaskItem_Systematic_Text");
                }
            }
        }
        #endregion

        #region TaskItem_Question_Text
        
        string _TaskItem_Question_Text;
        public string TaskItem_Question_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_TaskItem_Question_Text))
                    _TaskItem_Question_Text = "Question";
                return _TaskItem_Question_Text;
            }
            set
            {
                if (_TaskItem_Question_Text != value)
                {
                    _TaskItem_Question_Text = value;
                    SendPropertyChanged("TaskItem_Question_Text");
                }
            }
        }
        #endregion

        #region TaskItem_Anwser_Text
        
        string _TaskItem_Anwser_Text;
        public string TaskItem_Anwser_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_TaskItem_Anwser_Text))
                    _TaskItem_Anwser_Text = "Anwser";
                return _TaskItem_Anwser_Text;
            }
            set
            {
                if (_TaskItem_Anwser_Text != value)
                {
                    _TaskItem_Anwser_Text = value;
                    SendPropertyChanged("TaskItem_Anwser_Text");
                }
            }
        }
        #endregion

        #region TaskItem_ISTWeight_Percent_Text
        
        string _TaskItem_ISTWeight_Percent_Text;
        public string TaskItem_ISTWeight_Percent_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_TaskItem_ISTWeight_Percent_Text))
                    _TaskItem_ISTWeight_Percent_Text = "IST Weight %";
                return _TaskItem_ISTWeight_Percent_Text;
            }
            set
            {
                if (_TaskItem_ISTWeight_Percent_Text != value)
                {
                    _TaskItem_ISTWeight_Percent_Text = value;
                    SendPropertyChanged("TaskItem_ISTWeight_Percent_Text");
                }
            }
        }
        #endregion

        #region TaskItem_Evaluation_Text
        
        string _TaskItem_Evaluation_Text;
        public string TaskItem_Evaluation_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_TaskItem_Evaluation_Text))
                    _TaskItem_Evaluation_Text = "Evaluation";
                return _TaskItem_Evaluation_Text;
            }
            set
            {
                if (_TaskItem_Evaluation_Text != value)
                {
                    _TaskItem_Evaluation_Text = value;
                    SendPropertyChanged("TaskItem_Evaluation_Text");
                }
            }
        }
        #endregion

        #region TaskItem_Control_Detail_Text
        
        string _TaskItem_Control_Detail_Text;
        public string TaskItem_Control_Detail_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_TaskItem_Control_Detail_Text))
                    _TaskItem_Control_Detail_Text = "Control_Detail";
                return _TaskItem_Control_Detail_Text;
            }
            set
            {
                if (_TaskItem_Control_Detail_Text != value)
                {
                    _TaskItem_Control_Detail_Text = value;
                    SendPropertyChanged("TaskItem_Control_Detail_Text");
                }
            }
        }
        #endregion
        #endregion

        #region Measurement
        #region Measurement_Title_Text
        
        string _Measurement_Title_Text;
        public string Measurement_Title_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Measurement_Title_Text))
                    _Measurement_Title_Text = "Title";
                return _Measurement_Title_Text;
            }
            set
            {
                if (_Measurement_Title_Text != value)
                {
                    _Measurement_Title_Text = value;
                    SendPropertyChanged("Measurement_Title_Text");
                }
            }
        }
        #endregion

        #region Measurement_IsIgnore_Text
        
        string _Measurement_IsIgnore_Text;
        public string Measurement_IsIgnore_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Measurement_IsIgnore_Text))
                    _Measurement_IsIgnore_Text = "Ignore alert";
                return _Measurement_IsIgnore_Text;
            }
            set
            {
                if (_Measurement_IsIgnore_Text != value)
                {
                    _Measurement_IsIgnore_Text = value;
                    SendPropertyChanged("Measurement_IsIgnore_Text");
                }
            }
        }
        #endregion

        #region Measurement_Start_Text
        
        string _Measurement_Start_Text;
        public string Measurement_Start_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Measurement_Start_Text))
                    _Measurement_Start_Text = "Start";
                return _Measurement_Start_Text;
            }
            set
            {
                if (_Measurement_Start_Text != value)
                {
                    _Measurement_Start_Text = value;
                    SendPropertyChanged("Measurement_Start_Text");
                }
            }
        }
        #endregion

        #region Measurement_Deadline_Text
        
        string _Measurement_Deadline_Text;
        public string Measurement_Deadline_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Measurement_Deadline_Text))
                    _Measurement_Deadline_Text = "Deadline";
                return _Measurement_Deadline_Text;
            }
            set
            {
                if (_Measurement_Deadline_Text != value)
                {
                    _Measurement_Deadline_Text = value;
                    SendPropertyChanged("Measurement_Deadline_Text");
                }
            }
        }
        #endregion

        #region Measurement_ResponsiblePerson_Text
        
        string _Measurement_ResponsiblePerson_Text;
        public string Measurement_ResponsiblePerson_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Measurement_ResponsiblePerson_Text))
                    _Measurement_ResponsiblePerson_Text = "Responsible Person";
                return _Measurement_ResponsiblePerson_Text;
            }
            set
            {
                if (_Measurement_ResponsiblePerson_Text != value)
                {
                    _Measurement_ResponsiblePerson_Text = value;
                    SendPropertyChanged("Measurement_ResponsiblePerson_Text");
                }
            }
        }
        #endregion

        #region Measurement_Department_Text
        
        string _Measurement_Department_Text;
        public string Measurement_Department_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Measurement_Department_Text))
                    _Measurement_Department_Text = "Department";
                return _Measurement_Department_Text;
            }
            set
            {
                if (_Measurement_Department_Text != value)
                {
                    _Measurement_Department_Text = value;
                    SendPropertyChanged("Measurement_Department_Text");
                }
            }
        }
        #endregion

        #region Measurement_Duration_Text
        
        string _Measurement_Duration_Text;
        public string Measurement_Duration_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Measurement_Duration_Text))
                    _Measurement_Duration_Text = "Duration";
                return _Measurement_Duration_Text;
            }
            set
            {
                if (_Measurement_Duration_Text != value)
                {
                    _Measurement_Duration_Text = value;
                    SendPropertyChanged("Measurement_Duration_Text");
                }
            }
        }
        #endregion

        #region Measurement_UnitDay_Text
        
        string _Measurement_UnitDay_Text;
        public string Measurement_UnitDay_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Measurement_UnitDay_Text))
                    _Measurement_UnitDay_Text = "days";
                return _Measurement_UnitDay_Text;
            }
            set
            {
                if (_Measurement_UnitDay_Text != value)
                {
                    _Measurement_UnitDay_Text = value;
                    SendPropertyChanged("Measurement_UnitDay_Text");
                }
            }
        }
        #endregion

        #region Measurement_DaysRemaining_Text
        
        string _Measurement_DaysRemaining_Text;
        public string Measurement_DaysRemaining_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Measurement_DaysRemaining_Text))
                    _Measurement_DaysRemaining_Text = "Remain";
                return _Measurement_DaysRemaining_Text;
            }
            set
            {
                if (_Measurement_DaysRemaining_Text != value)
                {
                    _Measurement_DaysRemaining_Text = value;
                    SendPropertyChanged("Measurement_DaysRemaining_Text");
                }
            }
        }
        #endregion

        #region Measurement_Status_Text
        
        string _Measurement_Status_Text;
        public string Measurement_Status_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Measurement_Status_Text))
                    _Measurement_Status_Text = "Status";
                return _Measurement_Status_Text;
            }
            set
            {
                if (_Measurement_Status_Text != value)
                {
                    _Measurement_Status_Text = value;
                    SendPropertyChanged("Measurement_Status_Text");
                }
            }
        }
        #endregion

        #region Measurement_GoalOutCome_Text
        
        string _Measurement_GoalOutCome_Text;
        public string Measurement_GoalOutCome_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Measurement_GoalOutCome_Text))
                    _Measurement_GoalOutCome_Text = "Goal / outcome";
                return _Measurement_GoalOutCome_Text;
            }
            set
            {
                if (_Measurement_GoalOutCome_Text != value)
                {
                    _Measurement_GoalOutCome_Text = value;
                    SendPropertyChanged("Measurement_GoalOutCome_Text");
                }
            }
        }
        public string Measurement_GoalOutCome_Text_Dot
        {
            get { return Measurement_GoalOutCome_Text + "..."; }
        }
        #endregion

        #region Measurement_Procedure_Text
        
        string _Measurement_Procedure_Text;
        public string Measurement_Procedure_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Measurement_Procedure_Text))
                    _Measurement_Procedure_Text = "Procedure";
                return _Measurement_Procedure_Text;
            }
            set
            {
                if (_Measurement_Procedure_Text != value)
                {
                    _Measurement_Procedure_Text = value;
                    SendPropertyChanged("Measurement_Procedure_Text");
                }
            }
        }
        public string Measurement_Procedure_Text_Dot
        {
            get
            {
                return Measurement_Procedure_Text + "...";
            }
        }
        #endregion

        #region Measurement_Expenses_Text
        
        string _Measurement_Expenses_Text;
        public string Measurement_Expenses_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Measurement_Expenses_Text))
                    _Measurement_Expenses_Text = "Expenses\nInvestment volume";
                return _Measurement_Expenses_Text;
            }
            set
            {
                if (_Measurement_Expenses_Text != value)
                {
                    _Measurement_Expenses_Text = value;
                    SendPropertyChanged("Measurement_Expenses_Text");
                }
            }
        }
        #endregion

        #region Measurement_ExpertedBenefits_Text
        
        string _Measurement_ExpertedBenefits_Text;
        public string Measurement_ExpertedBenefits_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Measurement_ExpertedBenefits_Text))
                    _Measurement_ExpertedBenefits_Text = "Expected benefits";
                return _Measurement_ExpertedBenefits_Text;
            }
            set
            {
                if (_Measurement_ExpertedBenefits_Text != value)
                {
                    _Measurement_ExpertedBenefits_Text = value;
                    SendPropertyChanged("Measurement_ExpertedBenefits_Text");
                }
            }
        }
        #endregion
        #endregion

        #region Evaluation_Chart
        #region Evaluation_Chart_Option_Text
        
        string _Evaluation_Chart_Option_Text;
        public string Evaluation_Chart_Option_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Evaluation_Chart_Option_Text))
                    _Evaluation_Chart_Option_Text = "Option";
                return _Evaluation_Chart_Option_Text;
            }
            set
            {
                if (_Evaluation_Chart_Option_Text != value)
                {
                    _Evaluation_Chart_Option_Text = value;
                    SendPropertyChanged("Evaluation_Chart_Option_Text");
                }
            }
        }
        #endregion

        #region Evaluation_Chart_DisplayChart_Text
        
        string _Evaluation_Chart_DisplayChart_Text;
        public string Evaluation_Chart_DisplayChart_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Evaluation_Chart_DisplayChart_Text))
                    _Evaluation_Chart_DisplayChart_Text = "Display Chart";
                return _Evaluation_Chart_DisplayChart_Text;
            }
            set
            {
                if (_Evaluation_Chart_DisplayChart_Text != value)
                {
                    _Evaluation_Chart_DisplayChart_Text = value;
                    SendPropertyChanged("Evaluation_Chart_DisplayChart_Text");
                }
            }
        }
        #endregion

        #region Evaluation_Chart_ColumnDisplay_Text
        
        string _Evaluation_Chart_ColumnDisplay_Text;
        public string Evaluation_Chart_ColumnDisplay_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Evaluation_Chart_ColumnDisplay_Text))
                    _Evaluation_Chart_ColumnDisplay_Text = "Column Display";
                return _Evaluation_Chart_ColumnDisplay_Text;
            }
            set
            {
                if (_Evaluation_Chart_ColumnDisplay_Text != value)
                {
                    _Evaluation_Chart_ColumnDisplay_Text = value;
                    SendPropertyChanged("Evaluation_Chart_ColumnDisplay_Text");
                }
            }
        }
        #endregion

        #region Evaluation_Chart_ColumnInfomation_Text
        
        string _Evaluation_Chart_ColumnInfomation_Text;
        public string Evaluation_Chart_ColumnInfomation_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Evaluation_Chart_ColumnInfomation_Text))
                    _Evaluation_Chart_ColumnInfomation_Text = "ColumnInfomation";
                return _Evaluation_Chart_ColumnInfomation_Text;
            }
            set
            {
                if (_Evaluation_Chart_ColumnInfomation_Text != value)
                {
                    _Evaluation_Chart_ColumnInfomation_Text = value;
                    SendPropertyChanged("Evaluation_Chart_ColumnInfomation_Text");
                }
            }
        }
        #endregion

        #region Evaluation_Chart_Legend_Text
        
        string _Evaluation_Chart_Legend_Text;
        public string Evaluation_Chart_Legend_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Evaluation_Chart_Legend_Text))
                    _Evaluation_Chart_Legend_Text = "Legend";
                return _Evaluation_Chart_Legend_Text;
            }
            set
            {
                if (_Evaluation_Chart_Legend_Text != value)
                {
                    _Evaluation_Chart_Legend_Text = value;
                    SendPropertyChanged("Evaluation_Chart_Legend_Text");
                }
            }
        }
        #endregion

        #region Evaluation_Chart_LegendWithPercent_Text
        
        string _Evaluation_Chart_LegendWithPercent_Text;
        public string Evaluation_Chart_LegendWithPercent_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Evaluation_Chart_LegendWithPercent_Text))
                    _Evaluation_Chart_LegendWithPercent_Text = "Legend With Percent";
                return _Evaluation_Chart_LegendWithPercent_Text;
            }
            set
            {
                if (_Evaluation_Chart_LegendWithPercent_Text != value)
                {
                    _Evaluation_Chart_LegendWithPercent_Text = value;
                    SendPropertyChanged("Evaluation_Chart_LegendWithPercent_Text");
                }
            }
        }
        #endregion

        #region Evaluation_Chart_Alignment_Text
        
        string _Evaluation_Chart_Alignment_Text;
        public string Evaluation_Chart_Alignment_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Evaluation_Chart_Alignment_Text))
                    _Evaluation_Chart_Alignment_Text = "Alignment";
                return _Evaluation_Chart_Alignment_Text;
            }
            set
            {
                if (_Evaluation_Chart_Alignment_Text != value)
                {
                    _Evaluation_Chart_Alignment_Text = value;
                    SendPropertyChanged("Evaluation_Chart_Alignment_Text");
                }
            }
        }
        #endregion

        #region Evaluation_Chart_AutoZoom_Text
        
        string _Evaluation_Chart_AutoZoom_Text;
        public string Evaluation_Chart_AutoZoom_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Evaluation_Chart_AutoZoom_Text))
                    _Evaluation_Chart_AutoZoom_Text = "Auto Zoom";
                return _Evaluation_Chart_AutoZoom_Text;
            }
            set
            {
                if (_Evaluation_Chart_AutoZoom_Text != value)
                {
                    _Evaluation_Chart_AutoZoom_Text = value;
                    SendPropertyChanged("Evaluation_Chart_AutoZoom_Text");
                }
            }
        }
        #endregion
        #endregion

        #region RiskManagement
        #region RiskManagement_Risk_Text
        
        string _RiskManagement_Risk_Text;
        public string RiskManagement_Risk_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_RiskManagement_Risk_Text))
                    _RiskManagement_Risk_Text = "Risk";
                return _RiskManagement_Risk_Text;
            }
            set
            {
                if (_RiskManagement_Risk_Text != value)
                {
                    _RiskManagement_Risk_Text = value;
                    SendPropertyChanged("RiskManagement_Risk_Text");
                }
            }
        }
        #endregion

        #region RiskManagement_Chart_Text
        
        string _RiskManagement_Chart_Text;
        public string RiskManagement_Chart_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_RiskManagement_Chart_Text))
                    _RiskManagement_Chart_Text = "Chart";
                return _RiskManagement_Chart_Text;
            }
            set
            {
                if (_RiskManagement_Chart_Text != value)
                {
                    _RiskManagement_Chart_Text = value;
                    SendPropertyChanged("RiskManagement_Chart_Text");
                }
            }
        }
        #endregion

        #region RiskManagement_RiskChart_Text
        
        string _RiskManagement_RiskChart_Text;
        public string RiskManagement_RiskChart_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_RiskManagement_RiskChart_Text))
                    _RiskManagement_RiskChart_Text = "Risk Chart";
                return _RiskManagement_RiskChart_Text;
            }
            set
            {
                if (_RiskManagement_RiskChart_Text != value)
                {
                    _RiskManagement_RiskChart_Text = value;
                    SendPropertyChanged("RiskManagement_RiskChart_Text");
                }
            }
        }
        #endregion
        #endregion
        #region eImportanceMode
        #region eImportanceMode_Absolute_Text
        
        string _eImportanceMode_Absolute_Text;
        public string eImportanceMode_Absolute_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_eImportanceMode_Absolute_Text))
                    _eImportanceMode_Absolute_Text = "Absolute";
                return _eImportanceMode_Absolute_Text;
            }
            set
            {
                if (_eImportanceMode_Absolute_Text != value)
                {
                    _eImportanceMode_Absolute_Text = value;
                    SendPropertyChanged("eImportanceMode_Absolute_Text");
                }
            }
        }
        #endregion

        #region eImportanceMode_Relativ_Text
        
        string _eImportanceMode_Relativ_Text;
        public string eImportanceMode_Relativ_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_eImportanceMode_Relativ_Text))
                    _eImportanceMode_Relativ_Text = "Relativ";
                return _eImportanceMode_Relativ_Text;
            }
            set
            {
                if (_eImportanceMode_Relativ_Text != value)
                {
                    _eImportanceMode_Relativ_Text = value;
                    SendPropertyChanged("eImportanceMode_Relativ_Text");
                }
            }
        }
        #endregion
        #endregion

        #region eWBDimension
        #region eWBDimension_Quantity_Text
        
        string _eWBDimension_Quantity_Text;
        public string eWBDimension_Quantity_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_eWBDimension_Quantity_Text))
                    _eWBDimension_Quantity_Text = "Quantity";
                return _eWBDimension_Quantity_Text;
            }
            set
            {
                if (this == ControlTextInfoInData.Intance)
                {
                }
                else
                {
                }
                if (_eWBDimension_Quantity_Text != value)
                {
                    _eWBDimension_Quantity_Text = value;
                    SendPropertyChanged("eWBDimension_Quantity_Text");
                }
            }
        }
        #endregion

        #region eWBDimension_Quality_Text
        
        string _eWBDimension_Quality_Text;
        public string eWBDimension_Quality_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_eWBDimension_Quality_Text))
                    _eWBDimension_Quality_Text = "Quality";
                return _eWBDimension_Quality_Text;
            }
            set
            {
                if (_eWBDimension_Quality_Text != value)
                {
                    _eWBDimension_Quality_Text = value;
                    SendPropertyChanged("eWBDimension_Quality_Text");
                }
            }
        }
        #endregion

        #region eWBDimension_Systematic_Text
        
        string _eWBDimension_Systematic_Text;
        public string eWBDimension_Systematic_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_eWBDimension_Systematic_Text))
                    _eWBDimension_Systematic_Text = "Systematic";
                return _eWBDimension_Systematic_Text;
            }
            set
            {
                if (_eWBDimension_Systematic_Text != value)
                {
                    _eWBDimension_Systematic_Text = value;
                    SendPropertyChanged("eWBDimension_Systematic_Text");
                }
            }
        }
        #endregion
        #endregion

        #region PotentialPortfolioChart_Corner
        #region PotentialPortfolioChart_Corner_Develop_Text
        
        string _PotentialPortfolioChart_Corner_Develop_Text;
        public string PotentialPortfolioChart_Corner_Develop_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_PotentialPortfolioChart_Corner_Develop_Text))
                    _PotentialPortfolioChart_Corner_Develop_Text = "Develop";
                return _PotentialPortfolioChart_Corner_Develop_Text;
            }
            set
            {
                if (this == ControlTextInfoInData.Intance)
                {
                }
                else
                {
                }
                if (_PotentialPortfolioChart_Corner_Develop_Text != value)
                {
                    _PotentialPortfolioChart_Corner_Develop_Text = value;
                    SendPropertyChanged("PotentialPortfolioChart_Corner_Develop_Text");
                }
            }
        }
        #endregion

        #region PotentialPortfolioChart_Corner_Stabilize_Text
        
        string _PotentialPortfolioChart_Corner_Stabilize_Text;
        public string PotentialPortfolioChart_Corner_Stabilize_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_PotentialPortfolioChart_Corner_Stabilize_Text))
                    _PotentialPortfolioChart_Corner_Stabilize_Text = "Stabilize";
                return _PotentialPortfolioChart_Corner_Stabilize_Text;
            }
            set
            {
                if (this == ControlTextInfoInData.Intance)
                {
                }
                else
                {
                }
                if (_PotentialPortfolioChart_Corner_Stabilize_Text != value)
                {
                    _PotentialPortfolioChart_Corner_Stabilize_Text = value;
                    SendPropertyChanged("PotentialPortfolioChart_Corner_Stabilize_Text");
                }
            }
        }
        #endregion

        #region PotentialPortfolioChart_Corner_Analyze_Text
        
        string _PotentialPortfolioChart_Corner_Analyze_Text;
        public string PotentialPortfolioChart_Corner_Analyze_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_PotentialPortfolioChart_Corner_Analyze_Text))
                    _PotentialPortfolioChart_Corner_Analyze_Text = "Analyze";
                return _PotentialPortfolioChart_Corner_Analyze_Text;
            }
            set
            {
                if (this == ControlTextInfoInData.Intance)
                {
                }
                else
                {
                }
                if (_PotentialPortfolioChart_Corner_Analyze_Text != value)
                {
                    _PotentialPortfolioChart_Corner_Analyze_Text = value;
                    SendPropertyChanged("PotentialPortfolioChart_Corner_Analyze_Text");
                }
            }
        }
        #endregion

        #region PotentialPortfolioChart_Corner_No_Need_For_Action_Text
        
        string _PotentialPortfolioChart_Corner_No_Need_For_Action_Text;
        public string PotentialPortfolioChart_Corner_No_Need_For_Action_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_PotentialPortfolioChart_Corner_No_Need_For_Action_Text))
                    _PotentialPortfolioChart_Corner_No_Need_For_Action_Text = "No need for action";
                return _PotentialPortfolioChart_Corner_No_Need_For_Action_Text;
            }
            set
            {
                if (this == ControlTextInfoInData.Intance)
                {
                }
                else
                {
                }
                if (_PotentialPortfolioChart_Corner_No_Need_For_Action_Text != value)
                {
                    _PotentialPortfolioChart_Corner_No_Need_For_Action_Text = value;
                    SendPropertyChanged("PotentialPortfolioChart_Corner_No_Need_For_Action_Text");
                }
            }
        }
        #endregion

        #region PotentialPortfolioChart_Corner_One_Or_More_Unassessed_Dimension_Text
        
        string _PotentialPortfolioChart_Corner_One_Or_More_Unassessed_Dimension_Text;
        public string PotentialPortfolioChart_Corner_One_Or_More_Unassessed_Dimension_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_PotentialPortfolioChart_Corner_One_Or_More_Unassessed_Dimension_Text))
                    _PotentialPortfolioChart_Corner_One_Or_More_Unassessed_Dimension_Text = "One or more unassessed dimension";
                return _PotentialPortfolioChart_Corner_One_Or_More_Unassessed_Dimension_Text;
            }
            set
            {
                if (this == ControlTextInfoInData.Intance)
                {
                }
                else
                {
                }
                if (_PotentialPortfolioChart_Corner_One_Or_More_Unassessed_Dimension_Text != value)
                {
                    _PotentialPortfolioChart_Corner_One_Or_More_Unassessed_Dimension_Text = value;
                    SendPropertyChanged("PotentialPortfolioChart_Corner_One_Or_More_Unassessed_Dimension_Text");
                }
            }
        }
        #endregion
        #endregion

        #region PotentialPortfolioChart_AxisLabel
        #region PotentialPortfolioChart_AxisLabel_X_Text
        
        string _PotentialPortfolioChart_AxisLabel_X_Text;
        public string PotentialPortfolioChart_AxisLabel_X_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_PotentialPortfolioChart_AxisLabel_X_Text))
                    _PotentialPortfolioChart_AxisLabel_X_Text = "Assessment";
                return _PotentialPortfolioChart_AxisLabel_X_Text;
            }
            set
            {
                if (this == ControlTextInfoInData.Intance)
                {
                }
                else
                {
                }
                if (_PotentialPortfolioChart_AxisLabel_X_Text != value)
                {
                    _PotentialPortfolioChart_AxisLabel_X_Text = value;
                    SendPropertyChanged("PotentialPortfolioChart_AxisLabel_X_Text");
                }
            }
        }
        #endregion

        #region PotentialPortfolioChart_AxisLabel_Y_Text
        
        string _PotentialPortfolioChart_AxisLabel_Y_Text;
        public string PotentialPortfolioChart_AxisLabel_Y_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_PotentialPortfolioChart_AxisLabel_Y_Text))
                    _PotentialPortfolioChart_AxisLabel_Y_Text = "Relative Weighting";
                return _PotentialPortfolioChart_AxisLabel_Y_Text;
            }
            set
            {
                if (this == ControlTextInfoInData.Intance)
                {
                }
                else
                {
                }
                if (_PotentialPortfolioChart_AxisLabel_Y_Text != value)
                {
                    _PotentialPortfolioChart_AxisLabel_Y_Text = value;
                    SendPropertyChanged("PotentialPortfolioChart_AxisLabel_Y_Text");
                }
            }
        }
        #endregion
        #endregion

        #region Conclution_ExternalDocuments_Item
        #region Conclution_ExternalDocuments_Item_Name_Text
        
        string _Conclution_ExternalDocuments_Item_Name_Text;
        public string Conclution_ExternalDocuments_Item_Name_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Conclution_ExternalDocuments_Item_Name_Text))
                    _Conclution_ExternalDocuments_Item_Name_Text = "Name";
                return _Conclution_ExternalDocuments_Item_Name_Text;
            }
            set
            {
                if (_Conclution_ExternalDocuments_Item_Name_Text != value)
                {
                    _Conclution_ExternalDocuments_Item_Name_Text = value;
                    SendPropertyChanged("Conclution_ExternalDocuments_Item_Name_Text");
                }
            }
        }
        #endregion

        #region Conclution_ExternalDocuments_Item_Link_Text
        
        string _Conclution_ExternalDocuments_Item_Link_Text;
        public string Conclution_ExternalDocuments_Item_Link_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Conclution_ExternalDocuments_Item_Link_Text))
                    _Conclution_ExternalDocuments_Item_Link_Text = "Link";
                return _Conclution_ExternalDocuments_Item_Link_Text;
            }
            set
            {
                if (_Conclution_ExternalDocuments_Item_Link_Text != value)
                {
                    _Conclution_ExternalDocuments_Item_Link_Text = value;
                    SendPropertyChanged("Conclution_ExternalDocuments_Item_Link_Text");
                }
            }
        }
        #endregion

        #region Conclution_ExternalDocuments_Item_Note_Text
        
        string _Conclution_ExternalDocuments_Item_Note_Text;
        public string Conclution_ExternalDocuments_Item_Note_Text
        {
            get
            {
                if (string.IsNullOrEmpty(_Conclution_ExternalDocuments_Item_Note_Text))
                    _Conclution_ExternalDocuments_Item_Note_Text = "Note";
                return _Conclution_ExternalDocuments_Item_Note_Text;
            }
            set
            {
                if (_Conclution_ExternalDocuments_Item_Note_Text != value)
                {
                    _Conclution_ExternalDocuments_Item_Note_Text = value;
                    SendPropertyChanged("Conclution_ExternalDocuments_Item_Note_Text");
                }
            }
        }
        #endregion
        #endregion
    }
}