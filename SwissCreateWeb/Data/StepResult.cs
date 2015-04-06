using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Windows.Media;

namespace ViCode_LeVi.Data
{
    public class StepResult : INotifyPropertyChanged
    {
        public StepResultItem Item { get; set; }

        #region Note
        string _Note;

        public string Note
        {
            get { return _Note; }
            set
            {
                if (_Note != value)
                {
                    _Note = value;
                    SendPropertyChanged("Note");
                }
            }
        }
        #endregion

        public static StepResultItem StepResultItem_None = new StepResultItem() { Value = 0, Color = "White", Description = string.Empty };
        public static StepResultItem StepResultItem_Bad = new StepResultItem() { Value = 1, Color = "Red", Description = "Not good" };
        public static StepResultItem StepResultItem_Normal = new StepResultItem() { Value = 2, Color = "Yellow", Description = "Normal" };
        public static StepResultItem StepResultItem_Good = new StepResultItem() { Value = 3, Color = "Green", Description = "Good" };

        public static StepResult Create_StepResult_None()
        {
            return new StepResult() { Item = StepResultItem_None };
        }

        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string s)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(s));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}