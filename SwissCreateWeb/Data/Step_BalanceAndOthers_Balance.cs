using SwissCreateWeb.Models.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SwissCreateWeb.Data
{
    public class Step_BalanceAndOthers_Balance : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void SendPropertyChanged_All()
        {

        }
        #endregion
        
        public List<Step_BalanceAndOthers_Balance_Item> Items { get; set; }

        public string CompanyName { get { return ProjectData.Intance.CompanyName; } }
        
        public string AsPer { get; set; }
        #region Group
        public Step_BalanceAndOthers_Balance_Item[] Items_KHACHHANG
        {
            get
            {
                return Items == null ? new Step_BalanceAndOthers_Balance_Item[0] : Items.Where(c => c.GroupName == GROUP_KHACHHANG_NAME).ToArray();
            }
            set { }
        }
        public Step_BalanceAndOthers_Balance_Item[] Items_SANXUAT
        {
            get
            {
                return Items == null ? new Step_BalanceAndOthers_Balance_Item[0] : Items.Where(c => c.GroupName == GROUP_SANXUAT_NAME).ToArray();
            }
            set { }
        }
        public Step_BalanceAndOthers_Balance_Item[] Items_NHANVIEN
        {
            get
            {
                return Items == null ? new Step_BalanceAndOthers_Balance_Item[0] : Items.Where(c => c.GroupName == GROUP_NHANVIEN_NAME).ToArray();
            }
            set { }
        }
        public Step_BalanceAndOthers_Balance_Item[] Items_TAICHINH
        {
            get
            {
                return Items == null ? new Step_BalanceAndOthers_Balance_Item[0] : Items.Where(c => c.GroupName == GROUP_TAICHINH_NAME).ToArray();
            }
            set { }
        }
        #endregion

        #region Add
        public void AddNew(string group)
        {
            Step_BalanceAndOthers_Balance_Item newItem = new Step_BalanceAndOthers_Balance_Item()
            {
                GroupName = group,
                ChiuTrachNhiem = string.Empty,
                MucTieu = string.Empty,
                NhanXet = string.Empty,
                TinhHinh = new StepResult() { Item = StepResult.StepResultItem_None }
            };
            if (Items == null)
                Items = new List<Step_BalanceAndOthers_Balance_Item>();
            Items.Add(newItem);
        }
        public void Remove(Step_BalanceAndOthers_Balance_Item removeItem)
        {
            var grps = this.Items.Where(c => c.GroupName == removeItem.GroupName);
            if (grps.Count() == 1)
            {
                removeItem.MucTieu = string.Empty;
                removeItem.NhanXet = string.Empty;
                removeItem.TinhHinh = new StepResult() { Item = StepResult.StepResultItem_None };
            }
            else
            {
                this.Items.Remove(removeItem);
            }
        }
        #endregion

        #region UI
        #region Step_BalanceAndOthers_Balance_Header
        
        string _Step_BalanceAndOthers_Balance_Header = string.Empty;
        public string Step_BalanceAndOthers_Balance_Header_4Report
        {
            get
            {
                if (Report_Config_Finance.IsConvertHeaderToUpper == true)
                    return Step_BalanceAndOthers_Balance_Header.ToUpper();
                return Step_BalanceAndOthers_Balance_Header;
            }
        }
        public string Step_BalanceAndOthers_Balance_Header
        {
            get
            {
                if (string.IsNullOrEmpty(_Step_BalanceAndOthers_Balance_Header))
                {
                    _Step_BalanceAndOthers_Balance_Header = "Cockpit BSC";
                }
                return _Step_BalanceAndOthers_Balance_Header;
            }
            set
            {
                if (_Step_BalanceAndOthers_Balance_Header != value)
                {
                    _Step_BalanceAndOthers_Balance_Header = value;
                    SendPropertyChanged("Step_BalanceAndOthers_Balance_Header");
                }
            }
        }
        #endregion

        #region AsPer_UIText
        
        string _AsPer_UIText = string.Empty;
        public string AsPer_UIText
        {
            get
            {
                if (string.IsNullOrEmpty(_AsPer_UIText))
                    _AsPer_UIText = "as per:";
                return _AsPer_UIText;
            }
            set
            {
                if (_AsPer_UIText != value)
                {
                    _AsPer_UIText = value;
                    SendPropertyChanged("AsPer_UIText");
                }
            }
        }
        #endregion

        #region Step_BalanceAndOthers_Balance_GROUP_KHACHHANG_NAME
        
        string _Step_BalanceAndOthers_Balance_GROUP_KHACHHANG_NAME = string.Empty;
        public string Step_BalanceAndOthers_Balance_GROUP_KHACHHANG_NAME
        {
            get
            {
                if (string.IsNullOrEmpty(_Step_BalanceAndOthers_Balance_GROUP_KHACHHANG_NAME))
                {
                    _Step_BalanceAndOthers_Balance_GROUP_KHACHHANG_NAME = GROUP_KHACHHANG_NAME;
                }
                return _Step_BalanceAndOthers_Balance_GROUP_KHACHHANG_NAME;
            }
            set
            {
                if (_Step_BalanceAndOthers_Balance_GROUP_KHACHHANG_NAME != value)
                {
                    _Step_BalanceAndOthers_Balance_GROUP_KHACHHANG_NAME = value;
                    SendPropertyChanged("Step_BalanceAndOthers_Balance_GROUP_KHACHHANG_NAME");
                }
            }
        }
        #endregion

        #region Step_BalanceAndOthers_Balance_GROUP_SANXUAT_NAME
        
        string _Step_BalanceAndOthers_Balance_GROUP_SANXUAT_NAME = string.Empty;
        public string Step_BalanceAndOthers_Balance_GROUP_SANXUAT_NAME
        {
            get
            {
                if (string.IsNullOrEmpty(_Step_BalanceAndOthers_Balance_GROUP_SANXUAT_NAME))
                {
                    _Step_BalanceAndOthers_Balance_GROUP_SANXUAT_NAME = GROUP_SANXUAT_NAME;
                }
                return _Step_BalanceAndOthers_Balance_GROUP_SANXUAT_NAME;
            }
            set
            {
                if (_Step_BalanceAndOthers_Balance_GROUP_SANXUAT_NAME != value)
                {
                    _Step_BalanceAndOthers_Balance_GROUP_SANXUAT_NAME = value;
                    SendPropertyChanged("Step_BalanceAndOthers_Balance_GROUP_SANXUAT_NAME");
                }
            }
        }
        #endregion

        #region Step_BalanceAndOthers_Balance_GROUP_NHANVIEN_NAME
        
        string _Step_BalanceAndOthers_Balance_GROUP_NHANVIEN_NAME = string.Empty;
        public string Step_BalanceAndOthers_Balance_GROUP_NHANVIEN_NAME
        {
            get
            {
                if (string.IsNullOrEmpty(_Step_BalanceAndOthers_Balance_GROUP_NHANVIEN_NAME))
                {
                    _Step_BalanceAndOthers_Balance_GROUP_NHANVIEN_NAME = GROUP_NHANVIEN_NAME;
                }
                return _Step_BalanceAndOthers_Balance_GROUP_NHANVIEN_NAME;
            }
            set
            {
                if (_Step_BalanceAndOthers_Balance_GROUP_NHANVIEN_NAME != value)
                {
                    _Step_BalanceAndOthers_Balance_GROUP_NHANVIEN_NAME = value;
                    SendPropertyChanged("Step_BalanceAndOthers_Balance_GROUP_NHANVIEN_NAME");
                }
            }
        }
        #endregion

        #region Step_BalanceAndOthers_Balance_GROUP_TAICHINH_NAME
        
        string _Step_BalanceAndOthers_Balance_GROUP_TAICHINH_NAME = string.Empty;
        public string Step_BalanceAndOthers_Balance_GROUP_TAICHINH_NAME
        {
            get
            {
                if (string.IsNullOrEmpty(_Step_BalanceAndOthers_Balance_GROUP_TAICHINH_NAME))
                {
                    _Step_BalanceAndOthers_Balance_GROUP_TAICHINH_NAME = GROUP_TAICHINH_NAME;
                }
                return _Step_BalanceAndOthers_Balance_GROUP_TAICHINH_NAME;
            }
            set
            {
                if (_Step_BalanceAndOthers_Balance_GROUP_TAICHINH_NAME != value)
                {
                    _Step_BalanceAndOthers_Balance_GROUP_TAICHINH_NAME = value;
                    SendPropertyChanged("Step_BalanceAndOthers_Balance_GROUP_TAICHINH_NAME");
                }
            }
        }
        #endregion
        #endregion

        #region UI
        #region Title_UIText
        
        string _Title_UIText = string.Empty;
        public string Title_UIText
        {
            get
            {
                if (string.IsNullOrEmpty(_Title_UIText))
                    _Title_UIText = "Cockpit BSC";
                return _Title_UIText;
            }
            set
            {
                if (_Title_UIText != value)
                {
                    _Title_UIText = value;
                    SendPropertyChanged("Title_UIText");
                }
            }
        }
        #endregion

        #region MucTieu_UIText
        
        string _MucTieu_UIText = string.Empty;
        public string MucTieu_UIText
        {
            get
            {
                if (string.IsNullOrEmpty(_MucTieu_UIText))
                    _MucTieu_UIText = "Objectives";
                return _MucTieu_UIText;
            }
            set
            {
                if (_MucTieu_UIText != value)
                {
                    _MucTieu_UIText = value;
                    SendPropertyChanged("MucTieu_UIText");
                }
            }
        }
        #endregion

        #region TinhHinh_UIText
        
        string _TinhHinh_UIText = string.Empty;
        public string TinhHinh_UIText
        {
            get
            {
                if (string.IsNullOrEmpty(_TinhHinh_UIText))
                    _TinhHinh_UIText = "Status";
                return _TinhHinh_UIText;
            }
            set
            {
                if (_TinhHinh_UIText != value)
                {
                    _TinhHinh_UIText = value;
                    SendPropertyChanged("TinhHinh_UIText");
                }
            }
        }
        #endregion

        #region NhanXet_UIText
        
        string _NhanXet_UIText = string.Empty;
        public string NhanXet_UIText
        {
            get
            {
                if (string.IsNullOrEmpty(_NhanXet_UIText))
                    _NhanXet_UIText = "Remarks";
                return _NhanXet_UIText;
            }
            set
            {
                if (_NhanXet_UIText != value)
                {
                    _NhanXet_UIText = value;
                    SendPropertyChanged("NhanXet_UIText");
                }
            }
        }
        #endregion

        #region ChiuTrachNhiem_UIText
        
        string _ChiuTrachNhiem_UIText = string.Empty;
        public string ChiuTrachNhiem_UIText
        {
            get
            {
                if (string.IsNullOrEmpty(_ChiuTrachNhiem_UIText))
                    _ChiuTrachNhiem_UIText = "Responsible";
                return _ChiuTrachNhiem_UIText;
            }
            set
            {
                if (_ChiuTrachNhiem_UIText != value)
                {
                    _ChiuTrachNhiem_UIText = value;
                    SendPropertyChanged("ChiuTrachNhiem_UIText");
                }
            }
        }
        #endregion
        #endregion

        public string GROUP_KHACHHANG_NAME
        {
            get { return "Client"; }
        }
        public string GROUP_SANXUAT_NAME
        {
            get { return "Production"; }
        }
        public string GROUP_NHANVIEN_NAME
        {
            get { return "Staff"; }
        }
        public string GROUP_TAICHINH_NAME
        {
            get { return "Finances"; }
        }
        #region CurrencySymbol
        
        string _CurrencySymbol = string.Empty;
        //public string CurrencySymbol
        //{
        //    get
        //    {
        //        if (ControlTextInfo.JustUse1CurrencySymbolInProject == true)
        //            return ViCode_LeVi.Langs.ControlTextInfo.Intance.CurrencySymbol;
        //        if (string.IsNullOrEmpty(_CurrencySymbol))
        //            return ViCode_LeVi.Langs.ControlTextInfo.Intance.CurrencySymbol;
        //        return _CurrencySymbol;
        //    }
        //    set
        //    {
        //        if (ControlTextInfo.JustUse1CurrencySymbolInProject == true)
        //            ViCode_LeVi.Langs.ControlTextInfo.Intance.CurrencySymbol = value;
        //        else if (_CurrencySymbol != value)
        //        {
        //            _CurrencySymbol = value;
        //            SendPropertyChanged("CurrencySymbol");
        //        }
        //    }
        //}
        #endregion

        #region CurrencySymbol_UI
        
        string _CurrencySymbol_UI = "Currency Symbol";
        public string CurrencySymbol_UI
        {
            get { return _CurrencySymbol_UI; }
            set
            {
                if (_CurrencySymbol_UI != value)
                {
                    _CurrencySymbol_UI = value;
                    SendPropertyChanged("CurrencySymbol_UI");
                }
            }
        }
        #endregion
    }

    public class Step_BalanceAndOthers_Balance_Item : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void SendPropertyChanged_All()
        {
            SendPropertyChanged("GroupName");
            SendPropertyChanged("MucTieu");
            SendPropertyChanged("TinhHinh");
            SendPropertyChanged("NhanXet");
            SendPropertyChanged("ChiuTrachNhiem");
        }
        #endregion
        
        public string GroupName { get; set; }
        
        public string MucTieu { get; set; }

        #region TinhHinh
        
        public StepResult TinhHinh { get; set; }
        //public string TinhHinh_TextOnReport
        //{
        //    get
        //    {
        //        var th = TinhHinh;
        //        if (th == null)
        //            return string.Empty;
        //        return th.Item.Value.ToString();
        //    }
        //    set { }
        //}
        //public string TinhHinh_TextOnReport_Good
        //{
        //    get
        //    {
        //        var th = TinhHinh;
        //        if (th == null || th.Is_StepResult_Good == false)
        //            return string.Empty;
        //        return "";
        //    }
        //    set { }
        //}
        //public string TinhHinh_TextOnReport_Normal
        //{
        //    get
        //    {
        //        var th = TinhHinh;
        //        if (th == null || th.Is_StepResult_Normal == false)
        //            return string.Empty;
        //        return "";
        //    }
        //    set { }
        //}
        //public string TinhHinh_TextOnReport_Bad
        //{
        //    get
        //    {
        //        var th = TinhHinh;
        //        if (th == null || th.Is_StepResult_Bad == false)
        //            return string.Empty;
        //        return "";
        //    }
        //    set { }
        //}
        //public byte[] TinhHinh_Image
        //{
        //    get
        //    {
        //        var th = TinhHinh;
        //        if (th == null)
        //            return null;
        //        return new byte[] { 1, 2 };
        //    }
        //    set { }
        //}

        #endregion

        
        public string NhanXet { get; set; }
        
        public string ChiuTrachNhiem { get; set; }

        #region UI
        #region Title_UIText
        
        string _Title_UIText = string.Empty;
        public string Title_UIText
        {
            get
            {
                if (string.IsNullOrEmpty(_Title_UIText))
                    _Title_UIText = "Cockpit BSC";
                return _Title_UIText;
            }
            set
            {
                if (_Title_UIText != value)
                {
                    _Title_UIText = value;
                    SendPropertyChanged("Title_UIText");
                }
            }
        }
        #endregion

        #region MucTieu_UIText
        
        string _MucTieu_UIText = string.Empty;
        public string MucTieu_UIText
        {
            get
            {
                if (string.IsNullOrEmpty(_MucTieu_UIText))
                    _MucTieu_UIText = "Objectives";
                return _MucTieu_UIText;
            }
            set
            {
                if (_MucTieu_UIText != value)
                {
                    _MucTieu_UIText = value;
                    SendPropertyChanged("MucTieu_UIText");
                }
            }
        }
        #endregion

        #region TinhHinh_UIText
        
        string _TinhHinh_UIText = string.Empty;
        public string TinhHinh_UIText
        {
            get
            {
                if (string.IsNullOrEmpty(_TinhHinh_UIText))
                    _TinhHinh_UIText = "Status";
                return _TinhHinh_UIText;
            }
            set
            {
                if (_TinhHinh_UIText != value)
                {
                    _TinhHinh_UIText = value;
                    SendPropertyChanged("TinhHinh_UIText");
                }
            }
        }
        #endregion

        #region NhanXet_UIText
        
        string _NhanXet_UIText = string.Empty;
        public string NhanXet_UIText
        {
            get
            {
                if (string.IsNullOrEmpty(_NhanXet_UIText))
                    _NhanXet_UIText = "Remarks";
                return _NhanXet_UIText;
            }
            set
            {
                if (_NhanXet_UIText != value)
                {
                    _NhanXet_UIText = value;
                    SendPropertyChanged("NhanXet_UIText");
                }
            }
        }
        #endregion

        #region ChiuTrachNhiem_UIText
        
        string _ChiuTrachNhiem_UIText = string.Empty;
        public string ChiuTrachNhiem_UIText
        {
            get
            {
                if (string.IsNullOrEmpty(_ChiuTrachNhiem_UIText))
                    _ChiuTrachNhiem_UIText = "Responsible";
                return _ChiuTrachNhiem_UIText;
            }
            set
            {
                if (_ChiuTrachNhiem_UIText != value)
                {
                    _ChiuTrachNhiem_UIText = value;
                    SendPropertyChanged("ChiuTrachNhiem_UIText");
                }
            }
        }
        #endregion
        #endregion
    }
}