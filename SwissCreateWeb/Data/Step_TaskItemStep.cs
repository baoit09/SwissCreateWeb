using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ViCode_LeVi.Data
{
    public class Step_TaskItemStep : INotifyPropertyChanged
    {
        public Step_TaskItemStep()
        {
        }

        public Step_TaskItemStep(Step_TaskItemGroup[] tasks)
        {
            TaskItemGroups_Source = new ObservableCollection<Step_TaskItemGroup>(tasks);            
        }
        
        public Step_TaskItemGroup[] TaskItemGroups
        {
            get
            {
                if (TaskItemGroups_Source == null)
                    return null;
                return TaskItemGroups_Source.ToArray();
            }
            set
            {
                TaskItemGroups_Source = new ObservableCollection<Step_TaskItemGroup>(value);                
            }
        }
        public ObservableCollection<Step_TaskItemGroup> TaskItemGroups_Source
        {
            get;
            set;
        }

        #region Tasks_Summary
        //private void Setup_Listening_4Tasks_Summary()
        //{
        //    TaskItemGroups_Source.CollectionChanged -= new System.Collections.Specialized.NotifyCollectionChangedEventHandler(TaskItemGroups_Source_CollectionChanged);
        //    TaskItemGroups_Source.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(TaskItemGroups_Source_CollectionChanged);

        //    foreach (var taskItems in TaskItemGroups_Source)
        //    {
        //        taskItems.Tasks_Source.CollectionChanged -= new System.Collections.Specialized.NotifyCollectionChangedEventHandler(Tasks_Source_CollectionChanged);
        //        taskItems.Tasks_Source.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(Tasks_Source_CollectionChanged);
        //    }
        //}

        void Tasks_Source_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Tasks_Summary_Raise();
        }

        void TaskItemGroups_Source_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Tasks_Summary_Raise();
        }
        public Step_TaskItem[] Tasks_Summary
        {
            get
            {
                List<Step_TaskItem> list = new List<Step_TaskItem>();
                var groups = TaskItemGroups;
                if (groups != null && groups.Length > 0)
                {
                    foreach (var grp in groups)
                    {
                        list.AddRange(grp.Tasks_Source.ToArray());
                    }
                }
                return list.ToArray();
            }
        }
        public void Tasks_Summary_Raise()
        {
            SendPropertyChanged("Tasks_Summary");
        }
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