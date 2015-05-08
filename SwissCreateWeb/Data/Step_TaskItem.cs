using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ViCode_LeVi.Data
{
     //public class Step_TaskItem : INotifyPropertyChanged
     //{ }
    
    public class Step_TaskItem
    {
        #region ID
        private string _ID = string.Empty;
        /// <summary>
        /// Mức do quan trong
        /// </summary>
        
        public string ID
        {
            get { return _ID; }
            set
            {
                if (_ID != value)
                {
                    _ID = value;
                    
                }
            }
        }
        public int ID_Num
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(ID))
                {
                    var sIDCharIndex = ID.IndexOf('-');
                    if (sIDCharIndex < ID.Length)
                    {
                        var sNum = ID.Substring(sIDCharIndex + 1);
                        int nNum = 0;
                        int.TryParse(sNum, out nNum);
                        return nNum;
                    }
                }
                return 0;
            }
            set { 

            }
        }
        #endregion

        #region Name
        private string _Name = string.Empty;
        /// <summary>
        /// Mức do quan trong
        /// </summary>
        
        public string Name
        {
            get { return _Name; }
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                }
            }
        }
        #endregion

        #region Active
        private bool _Active = true;
        /// <summary>
        /// Mức do quan trong
        /// </summary>
        
        public bool Active
        {
            get { return _Active; }
            set
            {
                if (_Active != value)
                {
                    _Active = value;
                }
            }
        }
        #endregion

        #region Define
        private string _Define = string.Empty;
        /// <summary>
        /// Mức do quan trong
        /// </summary>
        
        public string Define
        {
            get { return _Define; }
            set
            {
                if (_Define != value)
                {
                    _Define = value;
                }
            }
        }
        #endregion

        #region Weight
        private int _Weight = 0;
        /// <summary>
        /// Mức do quan trong
        /// </summary>
        
        public int Weight
        {
            get { return _Weight; }
            set
            {
                if (_Weight != value)
                {
                    _Weight = value;
                }
            }
        }
        #endregion

        #region ReasonDescription4Weight
        private string _ReasonDescription4Weight = string.Empty;
        /// <summary>
        /// Mức do quan trong
        /// </summary>
        
        public string ReasonDescription4Weight
        {
            get { return _ReasonDescription4Weight; }
            set
            {
                if (_ReasonDescription4Weight != value)
                {
                    _ReasonDescription4Weight = value;
                }
            }
        }
        #endregion

        public int ImageHeight { get { return 20; } set {} }
        public int ImageWidth { get { return 20; } set {} }

        #region Quantity
        #region Quantity_Checked
        bool _Quantity_Checked = false;
        
        public bool Quantity_Checked
        {
            get { return _Quantity_Checked; }
            set
            {
                if (_Quantity_Checked != value)
                {
                    _Quantity_Checked = value;

                    if (_Quantity_Checked == false)
                    {
                        Quantity_Question = string.Empty;
                        Quantity_Answer = string.Empty;
                        Quantity_WeightPercent = null;
                    }
                }
            }
        }
        #endregion

        #region Quantity_Question
        string _Quantity_Question = string.Empty;
        
        public string Quantity_Question
        {
            get { return _Quantity_Question; }
            set
            {
                if (_Quantity_Question != value)
                {
                    _Quantity_Question = value;
                }
            }
        }
        #endregion

        #region Quantity_WeightPercent
        int? _Quantity_WeightPercent = null;
        
        public int? Quantity_WeightPercent
        {
            get
            {
                if (_Quantity_WeightPercent.HasValue && _Quantity_WeightPercent < 0)
                    _Quantity_WeightPercent = 0;
                if (_Quantity_WeightPercent.HasValue && _Quantity_WeightPercent > 100)
                    _Quantity_WeightPercent = 100;
                return _Quantity_WeightPercent;
            }
            set
            {
                if (_Quantity_WeightPercent != value)
                {
                    _Quantity_WeightPercent = value;
                    if (_Quantity_WeightPercent.HasValue && _Quantity_WeightPercent < 0)
                        _Quantity_WeightPercent = 0;
                    if (_Quantity_WeightPercent.HasValue && _Quantity_WeightPercent > 100)
                        _Quantity_WeightPercent = 100;
                }
            }
        }
        #endregion

        //#region Quantity_Evaluation_Image
        //#region Quantity_Evaluation_Image_Sad
        //static BitmapImage _Quantity_Evaluation_Image_Sad = null;
        //static BitmapImage Quantity_Evaluation_Image_Sad
        //{
        //    get
        //    {
        //        if (_Quantity_Evaluation_Image_Sad == null)
        //        {
        //            _Quantity_Evaluation_Image_Sad = Quantity_Evaluation_Image_GetIt("1.png");
        //        }
        //        return _Quantity_Evaluation_Image_Sad;
        //    }
        //}
        //#endregion
        //#region Quantity_Evaluation_Image_Normal
        //static BitmapImage _Quantity_Evaluation_Image_Normal = null;
        //static BitmapImage Quantity_Evaluation_Image_Normal
        //{
        //    get
        //    {
        //        if (_Quantity_Evaluation_Image_Normal == null)
        //        {
        //            _Quantity_Evaluation_Image_Normal = Quantity_Evaluation_Image_GetIt("2.png");
        //        }
        //        return _Quantity_Evaluation_Image_Normal;
        //    }
        //}
        //#endregion
        //#region Quantity_Evaluation_Image_Happy
        //static BitmapImage _Quantity_Evaluation_Image_Happy = null;
        //static BitmapImage Quantity_Evaluation_Image_Happy
        //{
        //    get
        //    {
        //        if (_Quantity_Evaluation_Image_Happy == null)
        //        {
        //            _Quantity_Evaluation_Image_Happy = Quantity_Evaluation_Image_GetIt("3.png");
        //        }
        //        return _Quantity_Evaluation_Image_Happy;
        //    }
        //}
        //#endregion
        //static BitmapImage Quantity_Evaluation_Image_GetIt(string aPath)
        //{
        //    string path = System.IO.Path.Combine(FileFolder.AppInfo.AppDirectory, "Images/" + aPath);
        //    if (System.IO.File.Exists(path) == false)
        //    {
        //        Assergs.Windows.MessageBox.Show("Không tìm thấy file " + path);
        //        return null;
        //    }
        //    BitmapImage image = new BitmapImage();
        //    image.BeginInit();
        //    image.CacheOption = BitmapCacheOption.OnLoad;
        //    image.UriSource = new Uri(path);
        //    image.EndInit();

        //    return image;
        //}
        //public BitmapImage Quantity_Evaluation_Image
        //{
        //    get
        //    {
        //        if (Quantity_WeightPercent == null)
        //            return null;
        //        if (Quantity_WeightPercent <= VMConfig.Intance.TaskItem_Quantity_Image_Item.Level1)
        //            return Quantity_Evaluation_Image_Sad;
        //        if (Quantity_WeightPercent <= VMConfig.Intance.TaskItem_Quantity_Image_Item.Level2)
        //            return Quantity_Evaluation_Image_Normal;
        //        return Quantity_Evaluation_Image_Happy;
        //    }
        //}
        //#endregion
        #region Quantity_Answer
        string _Quantity_Answer = string.Empty;
        
        public string Quantity_Answer
        {
            get { return _Quantity_Answer; }
            set
            {
                if (_Quantity_Answer != value)
                {
                    _Quantity_Answer = value;
                }
            }
        }
        #endregion
        #endregion

        #region Quality
        #region Quality_Checked
        bool _Quality_Checked = false;
        
        public bool Quality_Checked
        {
            get { return _Quality_Checked; }
            set
            {
                if (_Quality_Checked != value)
                {
                    _Quality_Checked = value;

                    if (_Quality_Checked == false)
                    {
                        Quality_Question = string.Empty;
                        Quality_Answer = string.Empty;
                        Quality_WeightPercent = null;
                    }
                }
            }
        }
        #endregion

        #region Quality_Question
        string _Quality_Question = string.Empty;
        
        public string Quality_Question
        {
            get { return _Quality_Question; }
            set
            {
                if (_Quality_Question != value)
                {
                    _Quality_Question = value;
                }
            }
        }
        #endregion

        #region Quality_WeightPercent
        int? _Quality_WeightPercent = null;
        
        public int? Quality_WeightPercent
        {
            get
            {
                if (_Quality_WeightPercent.HasValue && _Quality_WeightPercent < 0)
                    _Quality_WeightPercent = 0;
                if (_Quality_WeightPercent.HasValue && _Quality_WeightPercent > 100)
                    _Quality_WeightPercent = 100;
                return _Quality_WeightPercent;
            }
            set
            {
                if (_Quality_WeightPercent != value)
                {
                    _Quality_WeightPercent = value;
                    if (_Quality_WeightPercent.HasValue && _Quality_WeightPercent < 0)
                        _Quality_WeightPercent = 0;
                    if (_Quality_WeightPercent.HasValue && _Quality_WeightPercent > 100)
                        _Quality_WeightPercent = 100;
                }
            }
        }
        #endregion

        //#region Quality_Evaluation_Image
        //#region Quality_Evaluation_Image_Sad
        //static BitmapImage _Quality_Evaluation_Image_Sad = null;
        //static BitmapImage Quality_Evaluation_Image_Sad
        //{
        //    get
        //    {
        //        if (_Quality_Evaluation_Image_Sad == null)
        //        {
        //            _Quality_Evaluation_Image_Sad = Quality_Evaluation_Image_GetIt("1.png");
        //        }
        //        return _Quality_Evaluation_Image_Sad;
        //    }
        //}
        //#endregion
        //#region Quality_Evaluation_Image_Normal
        //static BitmapImage _Quality_Evaluation_Image_Normal = null;
        //static BitmapImage Quality_Evaluation_Image_Normal
        //{
        //    get
        //    {
        //        if (_Quality_Evaluation_Image_Normal == null)
        //        {
        //            _Quality_Evaluation_Image_Normal = Quality_Evaluation_Image_GetIt("2.png");
        //        }
        //        return _Quality_Evaluation_Image_Normal;
        //    }
        //}
        //#endregion
        //#region Quality_Evaluation_Image_Happy
        //static BitmapImage _Quality_Evaluation_Image_Happy = null;
        //static BitmapImage Quality_Evaluation_Image_Happy
        //{
        //    get
        //    {
        //        if (_Quality_Evaluation_Image_Happy == null)
        //        {
        //            _Quality_Evaluation_Image_Happy = Quality_Evaluation_Image_GetIt("3.png");
        //        }
        //        return _Quality_Evaluation_Image_Happy;
        //    }
        //}
        //#endregion
        //static BitmapImage Quality_Evaluation_Image_GetIt(string aPath)
        //{
        //    string path = System.IO.Path.Combine(FileFolder.AppInfo.AppDirectory, "Images/" + aPath);
        //    if (System.IO.File.Exists(path) == false)
        //    {
        //        Assergs.Windows.MessageBox.Show("Không tìm thấy file " + path);
        //        return null;
        //    }
        //    BitmapImage image = new BitmapImage();
        //    image.BeginInit();
        //    image.CacheOption = BitmapCacheOption.OnLoad;
        //    image.UriSource = new Uri(path);
        //    image.EndInit();

        //    return image;
        //}
        //public BitmapImage Quality_Evaluation_Image
        //{
        //    get
        //    {
        //        if (Quality_WeightPercent == null)
        //            return null;
        //        if (Quality_WeightPercent <= 30)
        //            return Quality_Evaluation_Image_Sad;
        //        if (Quality_WeightPercent <= 80)
        //            return Quality_Evaluation_Image_Normal;
        //        return Quality_Evaluation_Image_Happy;
        //    }
        //}
        //#endregion
        #region Quality_Answer
        string _Quality_Answer = string.Empty;
        
        public string Quality_Answer
        {
            get { return _Quality_Answer; }
            set
            {
                if (_Quality_Answer != value)
                {
                    _Quality_Answer = value;
                }
            }
        }
        #endregion
        #endregion

        #region Systematic
        #region Systematic_Checked
        bool _Systematic_Checked = false;
        
        public bool Systematic_Checked
        {
            get { return _Systematic_Checked; }
            set
            {
                if (_Systematic_Checked != value)
                {
                    _Systematic_Checked = value;

                    if (_Systematic_Checked == false)
                    {
                        Systematic_Question = string.Empty;
                        Systematic_Answer = string.Empty;
                        Systematic_WeightPercent = null;
                    }
                }
            }
        }
        #endregion

        #region Systematic_Question
        string _Systematic_Question = string.Empty;
        
        public string Systematic_Question
        {
            get { return _Systematic_Question; }
            set
            {
                if (_Systematic_Question != value)
                {
                    _Systematic_Question = value;
                }
            }
        }
        #endregion

        #region Systematic_WeightPercent
        int? _Systematic_WeightPercent = null;
        
        public int? Systematic_WeightPercent
        {
            get
            {
                if (_Systematic_WeightPercent.HasValue && _Systematic_WeightPercent < 0)
                    _Systematic_WeightPercent = 0;
                if (_Systematic_WeightPercent.HasValue && _Systematic_WeightPercent > 100)
                    _Systematic_WeightPercent = 100;
                return _Systematic_WeightPercent;
            }
            set
            {
                if (_Systematic_WeightPercent != value)
                {
                    _Systematic_WeightPercent = value;
                    if (_Systematic_WeightPercent.HasValue && _Systematic_WeightPercent < 0)
                        _Systematic_WeightPercent = 0;
                    if (_Systematic_WeightPercent.HasValue && _Systematic_WeightPercent > 100)
                        _Systematic_WeightPercent = 100;
                }
            }
        }
        #endregion

        //#region Systematic_Evaluation_Image
        //#region Systematic_Evaluation_Image_Sad
        //static BitmapImage _Systematic_Evaluation_Image_Sad = null;
        //static BitmapImage Systematic_Evaluation_Image_Sad
        //{
        //    get
        //    {
        //        if (_Systematic_Evaluation_Image_Sad == null)
        //        {
        //            _Systematic_Evaluation_Image_Sad = Systematic_Evaluation_Image_GetIt("1.png");
        //        }
        //        return _Systematic_Evaluation_Image_Sad;
        //    }
        //}
        //#endregion
        //#region Systematic_Evaluation_Image_Normal
        //static BitmapImage _Systematic_Evaluation_Image_Normal = null;
        //static BitmapImage Systematic_Evaluation_Image_Normal
        //{
        //    get
        //    {
        //        if (_Systematic_Evaluation_Image_Normal == null)
        //        {
        //            _Systematic_Evaluation_Image_Normal = Systematic_Evaluation_Image_GetIt("2.png");
        //        }
        //        return _Systematic_Evaluation_Image_Normal;
        //    }
        //}
        //#endregion
        //#region Systematic_Evaluation_Image_Happy
        //static BitmapImage _Systematic_Evaluation_Image_Happy = null;
        //static BitmapImage Systematic_Evaluation_Image_Happy
        //{
        //    get
        //    {
        //        if (_Systematic_Evaluation_Image_Happy == null)
        //        {
        //            _Systematic_Evaluation_Image_Happy = Systematic_Evaluation_Image_GetIt("3.png");
        //        }
        //        return _Systematic_Evaluation_Image_Happy;
        //    }
        //}
        //#endregion
        //static BitmapImage Systematic_Evaluation_Image_GetIt(string aPath)
        //{
        //    string path = System.IO.Path.Combine(FileFolder.AppInfo.AppDirectory, "Images/" + aPath);
        //    if (System.IO.File.Exists(path) == false)
        //    {
        //        Assergs.Windows.MessageBox.Show("Không tìm thấy file " + path);
        //        return null;
        //    }
        //    BitmapImage image = new BitmapImage();
        //    image.BeginInit();
        //    image.CacheOption = BitmapCacheOption.OnLoad;
        //    image.UriSource = new Uri(path);
        //    image.EndInit();

        //    return image;
        //}
        //public BitmapImage Systematic_Evaluation_Image
        //{
        //    get
        //    {
        //        if (Systematic_WeightPercent == null)
        //            return null;
        //        if (Systematic_WeightPercent <= 30)
        //            return Systematic_Evaluation_Image_Sad;
        //        if (Systematic_WeightPercent <= 80)
        //            return Systematic_Evaluation_Image_Normal;
        //        return Systematic_Evaluation_Image_Happy;
        //    }
        //}
        //#endregion
        #region Systematic_Answer
        string _Systematic_Answer = string.Empty;
        
        public string Systematic_Answer
        {
            get { return _Systematic_Answer; }
            set
            {
                if (_Systematic_Answer != value)
                {
                    _Systematic_Answer = value;
                }
            }
        }
        #endregion
        #endregion
    }
}