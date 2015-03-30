using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ViCode_LeVi.Data
{
    public class Step_QuestionAnwserStep : INotifyPropertyChanged
    {
        public Step_QuestionAnwserStep()
        {
            //QuestionAnwserGroups_Source = new ObservableCollection<Step_QuestionAnwserGroup>(qas);
        }

        public Step_QuestionAnwserStep(Step_QuestionAnwserGroup[] qas)
        {
            QuestionAnwserGroups_Source = new ObservableCollection<Step_QuestionAnwserGroup>(qas);
        }
       
        public Step_QuestionAnwserGroup[] QuestionAnwserGroups
        {
            get
            {
                if (QuestionAnwserGroups_Source == null)
                    return null;
                return QuestionAnwserGroups_Source.ToArray();
            }
            set
            {
                QuestionAnwserGroups_Source = new ObservableCollection<Step_QuestionAnwserGroup>(value);
                SendPropertyChanged("QuestionAnwserGroups");
                SendPropertyChanged("QuestionAnwserGroups_Source");
            }
        }
        public ObservableCollection<Step_QuestionAnwserGroup> QuestionAnwserGroups_Source
        {
            get;
            set;
        }

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