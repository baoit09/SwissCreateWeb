using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows;

namespace SwissCreateWeb.Data
{
    public class Step_RiskManagement : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        public Step_RiskManagement(Step_RiskManagementItem[] tasks)
        {
            Tasks = tasks;
        }
        public Step_RiskManagement()
        {
            if (Tasks == null)
                Tasks = new Step_RiskManagementItem[0];
        }
        #region Name
        
        string _Name = string.Empty;
        public string Name
        {
            get { return _Name; }
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
        #region Code
        
        string _Code = string.Empty;
        public string Code
        {
            get { return _Code; }
            set
            {
                if (_Code != value)
                {
                    _Code = value;
                    SendPropertyChanged("Code");
                }
            }
        }
        #endregion



        
        private Step_RiskManagementItem[] Tasks
        {
            get
            {
                if (Tasks_Source == null)
                    return null;
                return Tasks_Source.ToArray();
            }
            set
            {
                Tasks_Source = new ObservableCollection<Step_RiskManagementItem>(value);
            }
        }
        public ObservableCollection<Step_RiskManagementItem> Tasks_Source
        {
            get;
            set;
        }
        public Step_RiskManagementItem[] Tasks_Source_AfterSort = null;
        public Step_RiskManagementItem[] Tasks_Source_ForReport
        {
            get
            {
                if (Tasks_Source_AfterSort != null
                    && Tasks_Source_AfterSort.Length == Tasks_Source.Count)
                    return Tasks_Source_AfterSort;
                else
                    return Tasks_Source.ToArray();

            }
            set { }
        }


        #region IM_Current_Task
        Step_RiskManagementItem _IM_Current_Task;
        public Step_RiskManagementItem IM_Current_Task
        {
            get { return _IM_Current_Task; }
            set
            {
                if (_IM_Current_Task != value)
                {
                    _IM_Current_Task = value;
                    SendPropertyChanged("IM_Current_Task");
                    SendPropertyChanged("IsEnableChangeInfo");
                    SendPropertyChanged("ShowHelpAddNew");
                }
            }
        }
        public bool IsEnableChangeInfo
        {
            get { return IM_Current_Task != null; }
        }
        public Visibility ShowHelpAddNew
        {
            get { return _IM_Current_Task != null ? Visibility.Collapsed : Visibility.Visible; }
        }
        #endregion

    }

    public class Step_RiskManagementItem : INotifyPropertyChanged
    {
        public Action<Step_RiskManagementItem> Action_WantToSelect;
        public string GetTooltip()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Risk);
            sb.AppendLine(this.ProbabilityName);
            sb.AppendLine(this.ImpactName);
            sb.AppendLine(this.Manage);
            return sb.ToString();
        }
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region RiskNo
        private long _RiskNo;
        /// <summary>
        /// Mức do quan trong
        /// </summary>
        
        public long RiskNo
        {
            get { return _RiskNo; }
            set
            {
                if (_RiskNo != value)
                {
                    _RiskNo = value;
                    SendPropertyChanged("RiskNo");
                }
            }
        }
        #endregion

        #region Risk
        private string _Risk = string.Empty;
        /// <summary>
        /// Mức do quan trong
        /// </summary>
        
        public string Risk
        {
            get { return _Risk; }
            set
            {
                if (_Risk != value)
                {
                    _Risk = value;
                    SendPropertyChanged("Risk");
                }
            }
        }
        #endregion

        #region Impact
        private int _Impact;
        /// <summary>
        /// Mức do quan trong
        /// </summary>
        
        public int Impact
        {
            get { return _Impact; }
            set
            {
                if (_Impact != value)
                {
                    _Impact = value;
                    SendPropertyChanged("Impact");
                    SendPropertyChanged("ImpactName");
                }
            }
        }
        public string ImpactName
        {
            get
            {
                return E_Risk_Impact.E_Risk_Impact_GetName(Impact);
            }
        }
        #endregion

        #region Manage
        private string _Manage = string.Empty;
        /// <summary>
        /// Mức do quan trong
        /// </summary>
        
        public string Manage
        {
            get { return _Manage; }
            set
            {
                if (_Manage != value)
                {
                    _Manage = value;
                    SendPropertyChanged("Manage");
                }
            }
        }
        #endregion

        #region Probability
        private int _Probability = 0;
        /// <summary>
        /// Mức do quan trong
        /// </summary>
        
        public int Probability
        {
            get { return _Probability; }
            set
            {
                if (_Probability != value)
                {
                    _Probability = value;
                    SendPropertyChanged("Probability");
                    SendPropertyChanged("ProbabilityName");
                }
            }
        }
        public string ProbabilityName
        {
            get
            {
                return E_Risk_Probability.E_Risk_Probability_GetName(Probability);
            }
        }
        #endregion

    }

    public class Static_E_Risk_Impact : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public static Static_E_Risk_Impact _Instance;
        public static Static_E_Risk_Impact Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new Static_E_Risk_Impact();
                return _Instance;
            }
            set { _Instance = value; }
        }
        public E_Risk_Impact[] Intances
        {
            get
            {

                return new E_Risk_Impact[] { IMPACT_VERYLOW, IMPACT_LOW, IMPACT_EVIDENT, IMPACT_CIRITICAL, IMPACT_CATASTROPHIC };
            }
        }

        #endregion
        
        public E_Risk_Impact IMPACT_VERYLOW = new E_Risk_Impact() { Mark = 1, sName = "Very low" };
        
        public E_Risk_Impact IMPACT_LOW = new E_Risk_Impact() { Mark = 2, sName = "Low" };
        
        public E_Risk_Impact IMPACT_EVIDENT = new E_Risk_Impact() { Mark = 3, sName = "Evident" };
        
        public E_Risk_Impact IMPACT_CIRITICAL = new E_Risk_Impact() { Mark = 4, sName = "Critical" };
        
        public E_Risk_Impact IMPACT_CATASTROPHIC = new E_Risk_Impact() { Mark = 5, sName = "Catastrophic" };
    }
    
    public class Static_E_Risk_Probability : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public static Static_E_Risk_Probability _Instance;
        public static Static_E_Risk_Probability Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new Static_E_Risk_Probability();
                return _Instance;
            }
            set { _Instance = value; }
        }

        public E_Risk_Probability[] Intances
        {
            get
            {
                return new E_Risk_Probability[] { PROBABILITY_VERYUNLIKELY, PROBABILITY_UNLIKELY, PROBABILITY_LIKELY, PROBABILITY_VERYLIKELY, PROBABILITY_SURE };
            }
        }
        #endregion
        
        public E_Risk_Probability PROBABILITY_VERYUNLIKELY = new E_Risk_Probability() { Mark = 1, sName = "Very unlikely" };
        
        public E_Risk_Probability PROBABILITY_UNLIKELY = new E_Risk_Probability() { Mark = 2, sName = "Unlikely" };
        
        public E_Risk_Probability PROBABILITY_LIKELY = new E_Risk_Probability() { Mark = 3, sName = "Likely" };
        
        public E_Risk_Probability PROBABILITY_VERYLIKELY = new E_Risk_Probability() { Mark = 4, sName = "Very likely" };
        
        public E_Risk_Probability PROBABILITY_SURE = new E_Risk_Probability() { Mark = 5, sName = "Sure" };


    }
    
    public class E_Risk_Impact : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region sName

        string _sName;
        
        public string sName
        {
            get
            {
                return _sName;

            }
            set
            {
                if (_sName != value)
                {
                    _sName = value;
                    SendPropertyChanged("sName");
                }
            }
        }

        #endregion

        #region Mark

        int _Mark;
        
        public int Mark
        {
            get
            {
                return _Mark;

            }
            set
            {
                if (_Mark != value)
                {
                    _Mark = value;
                    SendPropertyChanged("Mark");
                }
            }
        }

        #endregion
        public static string E_Risk_Impact_GetName(int mark)
        {
            var p = Intance.FirstOrDefault(i => i.Mark == mark);
            return p == null ? string.Empty : p.sName;
        }
        public static E_Risk_Impact[] Intance
        {
            get { return Static_E_Risk_Impact.Instance.Intances.ToArray(); }
        }
    }


    
    public class E_Risk_Probability : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region sName

        string _sName;
        
        public string sName
        {
            get
            {
                return _sName;

            }
            set
            {
                if (_sName != value)
                {
                    _sName = value;
                    SendPropertyChanged("sName");
                }
            }
        }

        #endregion

        #region Mark

        int _Mark;
        
        public int Mark
        {
            get
            {
                return _Mark;

            }
            set
            {
                if (_Mark != value)
                {
                    _Mark = value;
                    SendPropertyChanged("Mark");
                }
            }
        }

        #endregion
        public static string E_Risk_Probability_GetName(int mark)
        {
            var p = Intance.FirstOrDefault(i => i.Mark == mark);
            return p == null ? string.Empty : p.sName;
        }

        public static E_Risk_Probability[] Intance
        {
            get
            {
                return Static_E_Risk_Probability.Instance.Intances;
            }
        }
    }
}