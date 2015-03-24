using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SwissCreateWeb.Data
{
    public class StepInfo : INotifyPropertyChanged
    {
        public string ShortName { get; set; }
        public string ShortName_UPPER
        {
            get
            {
                return ShortName;//.ToUpper(); 
            }
            set
            {
                if (ShortName != value)
                {
                    ShortName = value;
                    SendPropertyChanged("ShortName");
                    SendPropertyChanged("ShortName_UPPER");
                    SendPropertyChanged("MenuText");
                }
            }
        }
       
        public string FullName { get; set; }
        public string FullName_UPPER
        {
            get
            {
                return FullName;//.ToUpper(); 
            }
            set
            {
                if (FullName != value)
                {
                    FullName = value;
                    SendPropertyChanged("FullName");
                    SendPropertyChanged("FullName_UPPER");
                    SendPropertyChanged("MenuText");

                }
            }
        }

        public string MenuText
        {
            get { return ShortName; }
        }
       
        public string Summary_Note { get; set; }

       
        public StepResult Result { get; set; }

       
        public Step_QuestionAnwserStep QuestionAnwserStep { get; set; }

       
        public Step_TaskItemStep TaskItemStep { get; set; }

       
        public Step_Analysis Analysis { get; set; }

       
        public Step_Measurement Measurement { get; set; }

       
        public Step_BalanceAndOthers BalanceAndOthers { get; set; }

       
        public Step_RiskManagement RiskManagement { get; set; }

       
        public Step_Budget Budget { get; set; }
       
        public StepInfo_HumanResource HumanResource { get; set; }
        public RootData Root
        {
            get
            {
                return RootData.Intance;
            }
        }
        //public bool IsCurrent
        //{
        //    get
        //    {
        //        return Root != null && Root.Step_Current == this;
        //    }
        //    set
        //    {
        //        if (value == true && Root != null)
        //        {
        //            Root.Step_Current = this;
        //            SendPropertyChanged("IsCurrent");
        //            Root.SendPropertyChanged("Step_Current");
        //        }
        //    }
        //}
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