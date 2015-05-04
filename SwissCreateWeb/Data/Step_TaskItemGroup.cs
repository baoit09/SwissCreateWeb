using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Windows;

namespace ViCode_LeVi.Data
{
    public class Step_TaskItemGroup : INotifyPropertyChanged
    {
        public Step_TaskItemGroup(Step_TaskItem[] tasks)
        {
            Tasks = tasks;
        }
        public Step_TaskItemGroup()
        {
            if (Tasks == null)
                Tasks = new Step_TaskItem[0];
        }
        #region Name

        public string _Name = string.Empty;
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
        
        public string _Code = string.Empty;
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

        //public FactorType FactorType
        //{
        //    get
        //    {
        //        if (!string.IsNullOrEmpty(Code))
        //        {
        //            if (Code.Contains("H"))
        //                return FactorType.HK;
        //            if (Code.Contains("S"))
        //                return FactorType.SK;
        //        }
        //        return FactorType.BK;
        //    }
        //}


        public Step_TaskItem[] Tasks
        {
            get
            {
                if (Tasks_Source == null)
                    return null;
                return Tasks_Source.ToArray();
            }
            set
            {
                Tasks_Source = new ObservableCollection<Step_TaskItem>(value);
            }
        }
        private ObservableCollection<Step_TaskItem> Tasks_Source
        {
            get;
            set;
        }

        //public Step_TaskItem[] Tasks_Source_IsActive
        //{
        //    get { return Tasks_Source.Where(c => c.Active == true).ToArray(); }
        //    set {}
        //}


        #region IM_Current_Task
        //Step_TaskItem _IM_Current_Task;
        //public Step_TaskItem IM_Current_Task
        //{
        //    get { return _IM_Current_Task; }
        //    set
        //    {
        //        if (_IM_Current_Task != value)
        //        {
        //            _IM_Current_Task = value;
        //            SendPropertyChanged("IM_Current_Task");
        //            SendPropertyChanged("IsEnableChangeInfo");
        //            SendPropertyChanged("ShowHelpAddNew");
        //        }
        //    }
        //}
        //public bool IsEnableChangeInfo
        //{
        //    get
        //    {
        //        return IM_Current_Task != null;
        //    }
        //}
        //public Visibility ShowHelpAddNew
        //{
        //    get { return _IM_Current_Task != null ? Visibility.Collapsed : Visibility.Visible; }
        //}
        #endregion

        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}