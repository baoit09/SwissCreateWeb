using ViCode_LeVi.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using SwissCreateWeb.Framework.Helpers;

namespace ViCode_LeVi.Data
{
    public class ProjectData : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region UIText_CompanyName

        string _UIText_CompanyName = string.Empty;
        public string UIText_CompanyName
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_CompanyName))
                    _UIText_CompanyName = "Company:";
                return _UIText_CompanyName;
            }
            set
            {
                if (_UIText_CompanyName != value)
                {
                    _UIText_CompanyName = value;
                    SendPropertyChanged("UIText_CompanyName");
                }
            }
        }
        #endregion

        #region UIText_Name

        string _UIText_Name = string.Empty;
        public string UIText_Name
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Name))
                    _UIText_Name = "Project's name:";
                return _UIText_Name;
            }
            set
            {
                if (_UIText_Name != value)
                {
                    _UIText_Name = value;
                    SendPropertyChanged("UIText_Name");
                }
            }
        }
        #endregion

        #region UIText_Author

        string _UIText_Author = string.Empty;
        public string UIText_Author
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Author))
                    _UIText_Author = "Creator";
                return _UIText_Author;
            }
            set
            {
                if (_UIText_Author != value)
                {
                    _UIText_Author = value;
                    SendPropertyChanged("UIText_Author");
                }
            }
        }
        #endregion

        #region UIText_Comment

        string _UIText_Comment = string.Empty;
        public string UIText_Comment
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Comment))
                    _UIText_Comment = "Commentator";
                return _UIText_Comment;
            }
            set
            {
                if (_UIText_Comment != value)
                {
                    _UIText_Comment = value;
                    SendPropertyChanged("UIText_Comment");
                }
            }
        }
        #endregion

        #region UIText_StartedDate

        string _UIText_StartedDate = string.Empty;
        public string UIText_StartedDate
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_StartedDate))
                    _UIText_StartedDate = "Start Date";
                return _UIText_StartedDate;
            }
            set
            {
                if (_UIText_StartedDate != value)
                {
                    _UIText_StartedDate = value;
                    SendPropertyChanged("UIText_StartedDate");
                }
            }
        }
        #endregion

        #region UIText_Note

        string _UIText_Note = string.Empty;
        public string UIText_Note
        {
            get
            {
                if (string.IsNullOrEmpty(_UIText_Note))
                    _UIText_Note = "Note";
                return _UIText_Note;
            }
            set
            {
                if (_UIText_Note != value)
                {
                    _UIText_Note = value;
                    SendPropertyChanged("UIText_Note");
                }
            }
        }
        #endregion

        public string CompanyName { get; set; }

        public string Name { get; set; }

        public string FileName { get; set; }

        public string Author { get; set; }

        public string Comment { get; set; }

        public string Note { get; set; }

        #region StartedDate_Date
        public DateTime _StartedDate_Date = DateTime.Now;
        public DateTime StartedDate_Date
        {
            get { return _StartedDate_Date; }
            set
            {
                if (_StartedDate_Date != value)
                {
                    _StartedDate_Date = value;
                    SendPropertyChanged("StartedDate_Date");
                }
            }
        }
        #endregion

        public List<RootData> Periods { get; set; }
        
        private static ProjectData _Intance = new ProjectData();
        public static ProjectData Intance
        {
            get
            {
                if (_Intance == null)
                    _Intance = new ProjectData();
                //if (AppStarted == false)
                //    return _Intance;
                //if (_Intance.StartedDate_Date < DateTime.Now.AddYears(-100))
                //    _Intance.StartedDate_Date = DateTime.Now;
                //#region ImageInfos
                //if (_Intance.ImageInfos == null)
                //    _Intance.ImageInfos = new ImageInfo[1];
                //if (_Intance.ImageInfos.Length < 1)
                //{
                //    List<ImageInfo> list = new List<ImageInfo>(_Intance.ImageInfos);
                //    while (list.Count < 1)
                //    {
                //        list.Add(new ImageInfo());
                //        if (list.Count > 1)
                //            break;
                //    }
                //    _Intance.ImageInfos = list.ToArray();
                //}
                //for (int i = 0; i < _Intance.ImageInfos.Length; i++)
                //    if (_Intance.ImageInfos[i] == null)
                //        _Intance.ImageInfos[i] = new ImageInfo();
                //#endregion

                return _Intance;
            }
            set
            {
                _Intance = value;
                //VMTextBlockExt_ControlTextInfoInDatas.RefreshUI();
                //if (_Intance != null)
                //    _Intance.RaiseAllProperties();
            }
        }

        public int Period_Index;
        //public RootData Period
        //{
        //    get
        //    {
        //        if (Periods == null || Periods.Length == 0)
        //            return null;
        //        if (Period_Index < 0)
        //            Period_Index = 0;
        //        if (Period_Index > Periods.Length - 1)
        //            Period_Index = Periods.Length - 1;
        //        var period = Periods[Period_Index];
        //        return period;
        //    }
        //}

        #region ConfigData

        ConfigData _ConfigData;
        public ConfigData ConfigData
        {
            get
            {
                if (_ConfigData == null)
                    _ConfigData = new ConfigData();
                _ConfigData.Refine();
                return _ConfigData;
            }
            set { _ConfigData = value; }
        }
        #endregion

        #region ControlTextInfoInData

        public ControlTextInfoInData _ControlTextInfoInData;
        public ControlTextInfoInData ControlTextInfoInData
        {
            get
            {
                //if (_ControlTextInfoInData == null)
                //{
                //    if (CurrentPeriod != null)
                //        _ControlTextInfoInData = new ControlTextInfoInData();
                //    else
                //    {
                //        //Chua load du lieu
                //    }
                //}
                return _ControlTextInfoInData;
            }
            set
            {
                _ControlTextInfoInData = value;
                if (_ControlTextInfoInData != null)
                {
                    _ControlTextInfoInData = value;
                }
            }
        }
        #endregion

        public static ProjectData GetFromXML(string sXML)
        {
            if (string.IsNullOrWhiteSpace(sXML))
                return null;

            try
            {
                var bytes = System.Text.Encoding.UTF8.GetBytes(sXML);
                var projectData = XMLData<ProjectData>.GetEntity(bytes);
                return projectData;
            }
            catch(Exception ex)
            {
                throw ex;
                //return null;
            }
        }

        public string ToXML()
        {
            try
            {
                byte[] data = SerializerHelper.Serialize(this);
                string sXML = System.Text.Encoding.UTF8.GetString(data);
                return sXML;
            }
            catch(Exception ex)
            {
                throw ex;
                //return null;
            }
        }
    }
}