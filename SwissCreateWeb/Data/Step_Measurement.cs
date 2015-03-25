using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SwissCreateWeb.Data
{
    public class Step_Measurement : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        public Step_Measurement()
        {
        }

        public Step_Measurement(Step_Measurement_Item[] aMeasurements)
        {
            Measurements = aMeasurements;
        }

        
        private Step_Measurement_Item[] Measurements
        {
            get
            {
                if (Measurements_Source == null)
                    return null;
                return Measurements_Source.ToArray();
            }
            set
            {
                if (value != null)
                    Measurements_Source = new ObservableCollection<Step_Measurement_Item>(value);
                else
                    Measurements_Source = new ObservableCollection<Step_Measurement_Item>();
                SendPropertyChanged("TaskItemGroups");
                SendPropertyChanged("TaskItemGroups_Source");
            }
        }
        #region Measurements_Source
        private ObservableCollection<Step_Measurement_Item> _Measurements_Source;
        public ObservableCollection<Step_Measurement_Item> Measurements_Source
        {
            get
            {
                return _Measurements_Source;
            }
            set
            {
                if (_Measurements_Source != null)
                    _Measurements_Source.CollectionChanged -= _Measurements_Source_CollectionChanged;
                _Measurements_Source = value;
                _Measurements_Source.CollectionChanged += _Measurements_Source_CollectionChanged;
                SendPropertyChanged("Measurements_Source");
                Measurements_Source_Filter_Refresh();
            }
        }

        void _Measurements_Source_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Measurements_Source_Filter_Refresh();
        }

        #region Status Filter
        bool _IsFilterStatus_Planning = true;
        public bool IsFilterStatus_Planning
        {
            get { return _IsFilterStatus_Planning; }
            set
            {
                if (_IsFilterStatus_Planning != value)
                {
                    _IsFilterStatus_Planning = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("IsFilterStatus_Planning"));
                        Measurements_Source_Filter_Refresh();
                    }
                }
            }
        }

        bool _IsFilterStatus_Beginning = true;
        public bool IsFilterStatus_Beginning
        {
            get { return _IsFilterStatus_Beginning; }
            set
            {
                if (_IsFilterStatus_Beginning != value)
                {
                    _IsFilterStatus_Beginning = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("IsFilterStatus_Beginning"));
                        Measurements_Source_Filter_Refresh();
                    }
                }
            }
        }


        bool _IsFilterStatus_Finished = true;
        public bool IsFilterStatus_Finished
        {
            get { return _IsFilterStatus_Finished; }
            set
            {
                if (_IsFilterStatus_Finished != value)
                {
                    _IsFilterStatus_Finished = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("IsFilterStatus_Finished"));
                        Measurements_Source_Filter_Refresh();
                    }
                }
            }
        }
        #endregion

        public void Measurements_Source_Filter_Refresh()
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("Measurements_Source_Filter"));
        }
        public ObservableCollection<Step_Measurement_Item> Measurements_Source_Filter
        {
            get
            {
                var data = Measurements_Source.ToArray();
                //if (IsFilterStatus_Planning == false)
                //    data = data.Where(d => d.Status != ControlTextInfoInData.Intance.Measurement_Status_InPlanning_Text).ToArray();
                //if (IsFilterStatus_Beginning == false)
                //    data = data.Where(d => d.Status != ControlTextInfoInData.Intance.Measurement_Status_InBeginning_Text).ToArray();
                //if (IsFilterStatus_Finished == false)
                //    data = data.Where(d => d.Status != ControlTextInfoInData.Intance.Measurement_Status_Finished_Text).ToArray();
                return new ObservableCollection<Step_Measurement_Item>(data);
            }
        }
        public void Measurements_Source_SortBy_Name(System.ComponentModel.ListSortDirection d)
        {
            if (Measurements_Source != null)
            {
                if (d == ListSortDirection.Ascending)
                    Measurements_Source = new ObservableCollection<Step_Measurement_Item>(Measurements_Source.OrderBy(c => c.Name));
                else
                    Measurements_Source = new ObservableCollection<Step_Measurement_Item>(Measurements_Source.OrderByDescending(c => c.Name));
            }
        }
        public void Measurements_Source_SortBy_StartDate(System.ComponentModel.ListSortDirection d)
        {
            if (Measurements_Source != null)
            {
                if (d == ListSortDirection.Ascending)
                    Measurements_Source = new ObservableCollection<Step_Measurement_Item>(Measurements_Source.OrderBy(c => c.StartedDate));
                else
                    Measurements_Source = new ObservableCollection<Step_Measurement_Item>(Measurements_Source.OrderByDescending(c => c.StartedDate));
            }
        }
        public void Measurements_Source_SortBy_Duration(System.ComponentModel.ListSortDirection d)
        {
            if (Measurements_Source != null)
            {
                if (d == ListSortDirection.Ascending)
                    Measurements_Source = new ObservableCollection<Step_Measurement_Item>(Measurements_Source.OrderBy(c => c.Duration));
                else
                    Measurements_Source = new ObservableCollection<Step_Measurement_Item>(Measurements_Source.OrderByDescending(c => c.Duration));
            }

        }
        public void Measurements_Source_SortBy_DaysRemaining(System.ComponentModel.ListSortDirection d)
        {
            if (Measurements_Source != null)
            {
                if (d == ListSortDirection.Ascending)
                    Measurements_Source = new ObservableCollection<Step_Measurement_Item>(Measurements_Source.OrderBy(c => c.DaysRemaining));
                else
                    Measurements_Source = new ObservableCollection<Step_Measurement_Item>(Measurements_Source.OrderByDescending(c => c.DaysRemaining));
            }
        }
        public void Measurements_Source_SortBy_EndDate(System.ComponentModel.ListSortDirection d)
        {
            if (Measurements_Source != null)
            {
                if (d == ListSortDirection.Ascending)
                    Measurements_Source = new ObservableCollection<Step_Measurement_Item>(Measurements_Source.OrderBy(c => c.EndDate));
                else
                    Measurements_Source = new ObservableCollection<Step_Measurement_Item>(Measurements_Source.OrderByDescending(c => c.EndDate));
            }
        }
        public void Measurements_Source_SortBy_Status(System.ComponentModel.ListSortDirection d)
        {
            if (Measurements_Source != null)
            {
                if (d == ListSortDirection.Ascending)
                    Measurements_Source = new ObservableCollection<Step_Measurement_Item>(Measurements_Source.OrderBy(c => c.Status));
                else
                    Measurements_Source = new ObservableCollection<Step_Measurement_Item>(Measurements_Source.OrderByDescending(c => c.Status));
            }
        }
        public void Measurements_Source_SortBy_ResponsiblePerson(System.ComponentModel.ListSortDirection d)
        {
            if (Measurements_Source != null)
            {
                if (d == ListSortDirection.Ascending)
                    Measurements_Source = new ObservableCollection<Step_Measurement_Item>(Measurements_Source.OrderBy(c => c.ResponsiblePerson));
                else
                    Measurements_Source = new ObservableCollection<Step_Measurement_Item>(Measurements_Source.OrderByDescending(c => c.ResponsiblePerson));
            }
        }
        public void Measurements_Source_SortBy_Department(System.ComponentModel.ListSortDirection d)
        {
            if (Measurements_Source != null)
            {
                if (d == ListSortDirection.Ascending)
                    Measurements_Source = new ObservableCollection<Step_Measurement_Item>(Measurements_Source.OrderBy(c => c.Department));
                else
                    Measurements_Source = new ObservableCollection<Step_Measurement_Item>(Measurements_Source.OrderByDescending(c => c.Department));
            }
        }
        #endregion
    }

    public class Step_Measurement_Item : INotifyPropertyChanged
    {
        public static bool Duration_JustGet = true;
        public static bool EndDate_JustGet = false;
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

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

        #region ResponsiblePerson
        
        string _ResponsiblePerson = string.Empty;
        public string ResponsiblePerson
        {
            get { return _ResponsiblePerson; }
            set
            {
                if (_ResponsiblePerson != value)
                {
                    _ResponsiblePerson = value;
                    SendPropertyChanged("ResponsiblePerson");
                }
            }
        }
        #endregion

        #region Department
        
        string _Department = string.Empty;
        public string Department
        {
            get { return _Department; }
            set
            {
                if (_Department != value)
                {
                    _Department = value;
                    SendPropertyChanged("Department");
                }
            }
        }
        #endregion


        #region IsIgnore
        
        bool _IsIgnore = false;
        public bool IsIgnore
        {
            get { return _IsIgnore; }
            set
            {
                if (_IsIgnore != value)
                {
                    _IsIgnore = value;
                    SendPropertyChanged("IsIgnore");
                }
            }
        }
        #endregion

        #region StartedDate
        
        DateTime _StartedDate = DateTime.Now;
        public DateTime StartedDate
        {
            get { return _StartedDate; }
            set
            {
                if (_StartedDate != value)
                {
                    _StartedDate = value;
                    SendPropertyChanged("StartedDate");
                    SendPropertyChanged("IM_StartedDate");
                    SendPropertyChanged("EndDate");
                    SendPropertyChanged("IM_EndDate");
                    SendPropertyChanged("DaysRemaining");
                    SendPropertyChanged("IM_DaysRemaining");
                }
            }
        }
        public string IM_StartedDate
        {
            get
            {
                return string.Format("{0:dd/MM/yyyy}", StartedDate);
            }
        }
        #endregion

        #region Duration
        
        int _Duration = 0;
        public int Duration
        {
            get
            {
                if (Duration_JustGet == true)
                    return (int)(EndDate.Date - StartedDate.Date).TotalDays;
                return _Duration;
            }
            set
            {
                if (_Duration != value)
                {
                    if (Duration_JustGet == false)
                    {
                        _Duration = value;
                    }
                    SendPropertyChanged("Duration");
                    SendPropertyChanged("IM_Duration");
                    SendPropertyChanged("EndDate");
                    SendPropertyChanged("IM_EndDate");
                    SendPropertyChanged("DaysRemaining");
                    SendPropertyChanged("IM_DaysRemaining");
                }
            }
        }

        //public string IM_Duration
        //{
        //    get
        //    {
        //        string sDay = ViCode_LeVi.Langs.ControlTextInfoInData.Intance.Measurement_UnitDay_Text;
        //        if (Duration == 1 && sDay.EndsWith("s"))
        //        {
        //            sDay = sDay.Substring(0, sDay.Length - 1);
        //        }
        //        return string.Format("{0} {1}", Duration, sDay);
        //    }
        //    set { }
        //}
        #endregion

        #region EndDate
        
        DateTime _EndDate = DateTime.Now;
        public DateTime EndDate
        {
            get
            {
                if (EndDate_JustGet == true)
                    return StartedDate.AddDays(Duration);
                if (_EndDate < StartedDate)
                    _EndDate = StartedDate;
                return _EndDate;
            }
            set
            {
                if (_EndDate != value)
                {
                    if (EndDate_JustGet == false)
                    {
                        _EndDate = value;
                    }
                    SendPropertyChanged("Duration");
                    SendPropertyChanged("IM_Duration");
                    SendPropertyChanged("EndDate");
                    SendPropertyChanged("IM_EndDate");
                    SendPropertyChanged("DaysRemaining");
                    SendPropertyChanged("IM_DaysRemaining");
                }

            }
        }
        public string IM_EndDate
        {
            get
            {
                return string.Format("{0:dd/MM/yyyy}", EndDate);
            }
        }
        #endregion

        #region DaysRemaining
        public int DaysRemaining
        {
            get
            {
                var temp = EndDate - DateTime.Today;
                return temp.Days;
            }

        }
        //public string IM_DaysRemaining
        //{
        //    get
        //    {
        //        string sDay = ViCode_LeVi.Langs.ControlTextInfoInData.Intance.Measurement_UnitDay_Text;
        //        if (DaysRemaining == 1 && sDay.EndsWith("s"))
        //        {
        //            sDay = sDay.Substring(0, sDay.Length - 1);
        //        }
        //        return string.Format("{0} {1}", DaysRemaining, sDay);
        //    }
        //}
        #endregion

        #region Status
        
        string _Status = string.Empty;
        public string Status
        {
            get { return _Status; }
            set
            {
                if (_Status != value)
                {
                    _Status = value;
                    SendPropertyChanged("Status");
                }
            }
        }
        #endregion

        #region Goal
        
        string _Goal = string.Empty;
        public string Goal
        {
            get { return _Goal; }
            set
            {
                if (_Goal != value)
                {
                    _Goal = value;
                    SendPropertyChanged("Goal");
                }
            }
        }
        #endregion

        #region Procedure
        
        string _Procedure = string.Empty;
        public string Procedure
        {
            get { return _Procedure; }
            set
            {
                if (_Procedure != value)
                {
                    _Procedure = value;
                    SendPropertyChanged("Procedure");
                }
            }
        }
        #endregion

        #region Expenses
        
        string _Expenses = string.Empty;
        public string Expenses
        {
            get { return _Expenses; }
            set
            {
                if (_Expenses != value)
                {
                    _Expenses = value;
                    SendPropertyChanged("Expenses");
                }
            }
        }
        #endregion

        #region ExpectedBenefits
        
        string _ExpectedBenefits = string.Empty;
        public string ExpectedBenefits
        {
            get { return _ExpectedBenefits; }
            set
            {
                if (_ExpectedBenefits != value)
                {
                    _ExpectedBenefits = value;
                    SendPropertyChanged("ExpectedBenefits");
                }
            }
        }
        #endregion
    }
}