using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SwissCreateWeb.Data
{
    public class Step_QuestionAnwserGroup : INotifyPropertyChanged
    {
        public Step_QuestionAnwserGroup()
        {

        }
        public Step_QuestionAnwserGroup(Step_QuestionAnwser[] data)
        {
            QuestionAnswers_Source = new ObservableCollection<Step_QuestionAnwser>(data);
        }
        #region Name
        private string _Name = string.Empty;
        
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

        #region QuestionAnswers
        
        private Step_QuestionAnwser[] QuestionAnswers
        {
            get
            {
                if (QuestionAnswers_Source == null)
                    return null;
                return QuestionAnswers_Source.ToArray();
            }
            set
            {
                QuestionAnswers_Source = new ObservableCollection<Step_QuestionAnwser>(value);
                SendPropertyChanged("QuestionAnswers");
                SendPropertyChanged("QuestionAnswers_Source");
            }
        }
        public ObservableCollection<Step_QuestionAnwser> QuestionAnswers_Source
        {
            get;
            set;
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