using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SwissCreateWeb.Data
{
    public class Step_QuestionAnwser
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
        #region Question
        string _Question = string.Empty;
        
        public string Question
        {
            get { return _Question; }
            set
            {
                if (_Question != value)
                {
                    _Question = value;
                    SendPropertyChanged("Question");
                }
            }
        }
        #endregion

        #region Answer
        string _Answer = string.Empty;
        
        public string Answer
        {
            get { return _Answer; }
            set
            {
                if (_Answer != value)
                {
                    _Answer = value;
                    SendPropertyChanged("Answer");
                }
            }
        }
        #endregion
    }
}