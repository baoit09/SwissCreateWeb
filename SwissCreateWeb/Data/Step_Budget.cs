using SwissCreateWeb.Models.Project;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Windows;

namespace SwissCreateWeb.Data
{
    public class Step_Budget : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public void SendPropertyChanged(string sProp)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
        //StepInfo_Budget[] Childs
        //Name (ten), Cost  (chi phi), Note (ghi chu)

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

        #region Name
        string _Name;
        
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

        #region Cost
        double _Cost;
        
        public double Cost
        {
            get { return _Cost; }
            set
            {
                if (_Cost != value)
                {
                    _Cost = value;
                    SendPropertyChanged("Cost_Text");
                    SendPropertyChanged("Cost");
                    SendPropertyChanged("Cost_Childs");
                    SendPropertyChanged("Get_Cost");
                    SendPropertyChanged("CostCurrent");
                    SendPropertyChanged("CostCurrent_Text");
                    SendPropertyChanged("Cost_Warning_Text");
                    if (Parent != null)
                    {
                        Parent.SendPropertyChanged("Cost_Warning_Text");
                        Parent.SendPropertyChanged("Cost_Childs");
                        Parent.SendPropertyChanged("Get_Cost");
                        Parent.SendPropertyChanged("CostCurrent");
                        Parent.SendPropertyChanged("CostCurrent_Text");
                    }

                }
            }
        }
        public static bool IsAutoSetTotalOfParentWhenChildChanged
        {
            get { return ProjectData.Intance == null ? false : ProjectData.Intance.ConfigData.Config_Budget.AutoSetCostByTotalOfChildren; }
        }
        public double? Cost_Warning_Text_OldValue = null;
        public double? Cost_Warning_Text_NewValue = null;
        public string Cost_Warning_Text
        {
            get
            {
                if (Childs != null && Childs.Count > 0)
                {
                    var c = Cost;
                    var ct = CostTotalChild;
                    if (IsAutoSetTotalOfParentWhenChildChanged == false)
                    {
                        if (c < ct)
                        {
                            return string.Format("Total of children budget ({0}) is greater than total budget, please add another number.", ToString(ct));
                        }
                    }
                    else
                    {
                        if (c != ct)
                        {
                            if (Cost_Warning_Text_NewValue == ct
                            && Cost_Warning_Text_NewValue.HasValue
                            && Cost_Warning_Text_OldValue.HasValue)//gia tri warning truoc do
                            {
                                string sWarning = string.Format("The total budget is changing. From {0} to {1}", ToString(Cost_Warning_Text_OldValue.Value), ToString(Cost_Warning_Text_NewValue.Value));
                                return sWarning;
                            }
                            else
                            {
                                Cost_Warning_Text_OldValue = c;
                                Cost_Warning_Text_NewValue = ct;
                                UpdateCostbyTotalChildren();
                                return string.Format("The total budget is changing. (from {0} to {1})", ToString(c), ToString(ct));
                            }
                        }
                        else
                        {
                            if (Cost_Warning_Text_NewValue == ct
                            && Cost_Warning_Text_NewValue.HasValue
                            && Cost_Warning_Text_OldValue.HasValue)//gia tri warning truoc do
                            {
                                string sWarning = string.Format("The total budget is changing. From {0} to {1}", ToString(Cost_Warning_Text_OldValue.Value), ToString(Cost_Warning_Text_NewValue.Value));
                                return sWarning;
                            }
                        }
                    }
                }
                return string.Empty;
            }
        }
        public void UpdateCostbyTotalChildren()
        {
            var c = Cost;
            var ct = CostTotalChild;
            if (c != ct)
            {
                Cost = ct;
                if (Parent != null)
                {
                    Parent.UpdateCostbyTotalChildren();
                }
            }
        }
        public string ToString(double value)
        {
            //return value.ToString("#,###", CultureInfo.InvariantCulture) + " " + ControlTextInfo.Intance.CurrencySymbol; ;
            return value.ToString();
        }
        public string Cost_Text
        {
            get
            {
                return ToString(Cost);
            }
        }
        public double CostCurrent
        {
            get
            {
                //if (Childs != null && Childs.Count > 0)
                //{
                //    //tinh lai cost
                //    if (Cost != CostTotalChild)
                //    {
                //        Cost = CostTotalChild;
                //    }
                //    return CostTotalChild;
                //}
                //return Cost;
                return Cost;
            }
        }
        public string CostCurrent_Text
        {
            get
            {
                return CostCurrent.ToString("#,###", CultureInfo.InvariantCulture) + " " + ControlTextInfo.Intance.CurrencySymbol;
            }
        }
        public string CostWillDisplay_Text
        {
            get
            {
                return Cost.ToString("#,###", CultureInfo.InvariantCulture) + " " + ControlTextInfo.Intance.CurrencySymbol;
            }
        }
        public double CostTotalChild
        {
            get
            {
                return Childs.Sum(c => c.CostCurrent);
            }
            set
            { }
        }
        public double CostPercentWithParent
        {
            get
            {
                if (Parent == null)
                    return 100;
                return CostCurrent * 100 / Parent.CostTotalChild;
            }
            set { }
        }
        #endregion

        #region Parent
        Step_Budget _Parent;
        public Step_Budget Parent
        {
            get
            {
                return _Parent;
            }
            set
            {
                if (_Parent != value)
                {
                    _Parent = value;
                    SendPropertyChanged("Parent");
                }
            }
        }
        public void RefreshParent()
        {
            foreach (var c in Childs)
            {
                if (c.Parent == null)
                {
                    c.Parent = this;
                    c.RefreshParent();
                }
            }
        }
        public bool CanEditCost
        {
            get { return this.Childs == null || this.Childs.Count == 0; }
        }
        #endregion

        #region Childs
        List<Step_Budget> _Childs;
        
        public List<Step_Budget> Childs
        {
            get
            {
                if (_Childs == null)
                    _Childs = new List<Step_Budget>();
                return _Childs;
            }
            set
            {
                if (_Childs != value)
                {
                    _Childs = value;
                    SendPropertyChanged("Childs");
                    SendPropertyChanged("ObservableCollection_Childs");
                }
            }
        }
        //ObservableCollection<Step_Budget> _ObservableCollection_Childs;
        public ObservableCollection<Step_Budget> ObservableCollection_Childs
        {
            get
            {
                return new ObservableCollection<Step_Budget>(Childs);
            }
        }

        public double Cost_Childs
        {
            get
            {
                if (Childs != null && Childs.Count > 0)
                {
                    return Childs.Sum(c => c.Cost_Childs);
                }
                else
                    return Cost;

            }
        }
        public double Get_Cost
        {
            get
            {
                double result = Cost;
                if (Childs != null && Childs.Count > 0)
                {
                    result = Childs.Sum(c => c.Cost_Childs);
                }
                if (Parent != null)
                {
                    Parent.SendPropertyChanged("Cost_Childs");
                    Parent.SendPropertyChanged("Get_Cost");
                }
                return result;
            }
        }
        #endregion

        #region Instance

        #endregion

        #region Action
        public void Add_Budget(Step_Budget sb)
        {
            if (sb == null)
                return;
            sb.Parent = this;
#warning xem nên select doi tuong con hay cha. Select con -> edit ngay ??
            sb.IsSelected = true;
            Childs.Add(sb);
            this.IsExpanded = true;
            SendPropertyChanged("Childs");
            SendPropertyChanged("ObservableCollection_Childs");
        }
        public void Remove_BudgetSub(Step_Budget sb)
        {
            if (sb == null)
                return;
            if (Childs.Contains(sb))
                Childs.Remove(sb);
            SendPropertyChanged("Childs");
            SendPropertyChanged("ObservableCollection_Childs");
        }
        #endregion

        #region IsExpanded
        private bool _isExpanded;
        public bool IsExpanded
        {
            get
            {
                return _isExpanded;
            }

            set
            {
                _isExpanded = value;
                this.SendPropertyChanged("IsExpanded");
            }
        }
        #endregion

        #region IsSelected
        private bool _isSelected;
        public bool IsSelected
        {
            get
            {
                return _isSelected;
            }

            set
            {
                _isSelected = value;
                this.SendPropertyChanged("IsSelected");
                this.SendPropertyChanged("FontWeight");
                this.SendPropertyChanged("ReadOnlyMode_Visibility");
                this.SendPropertyChanged("EditMode_Visibility");
                this.SendPropertyChanged("EditMode_Visibility_Cost");
                this.SendPropertyChanged("EditMode_Visibility_CostCurrent");
            }
        }
        public System.Windows.FontWeight FontWeight
        {
            get
            {
                return IsSelected == true ? System.Windows.FontWeights.Normal : System.Windows.FontWeights.Normal;
            }
        }

        public Visibility ReadOnlyMode_Visibility
        {
            get
            {
                return IsSelected == true ? Visibility.Collapsed : Visibility.Visible;
            }
        }
        public Visibility EditMode_Visibility
        {
            get
            {
                return IsSelected == true ? Visibility.Visible : Visibility.Collapsed;
            }
        }
        public bool IsNodeLeaf
        {
            get
            {
                return this.Childs == null || this.Childs.Count == 0;
            }
        }
        public Visibility EditMode_Visibility_Cost
        {
            get
            {
                return EditMode_Visibility == Visibility.Visible && IsNodeLeaf ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        public Visibility EditMode_Visibility_CostCurrent
        {
            get
            {
                return EditMode_Visibility == Visibility.Visible && (!IsNodeLeaf) ? Visibility.Visible : Visibility.Collapsed;
            }
        }
        #endregion

        #region Move
        public void MoveUp()
        {
            if (this.Parent != null)
            {
                var item = this.Parent;
                var myIndex = item.Childs.IndexOf(this);
                if (myIndex > 0)
                {
                    var newChildIndex = myIndex - 1;
                    this.IsSelected = false;
                    item.Childs[newChildIndex].IsSelected = true;
                }
            }
        }
        public void MoveDown()
        {
            if (this.Parent != null)
            {
                var item = this.Parent;
                var myIndex = item.Childs.IndexOf(this);
                if (item.Childs.Count > myIndex)
                {
                    var newChildIndex = myIndex + 1;
                    this.IsSelected = false;
                    item.Childs[newChildIndex].IsSelected = true;
                }
            }
        }
        #endregion

        public Action FocusForEditing { get; set; }

        public void ExpandAll()
        {
            this.IsExpanded = true;
            var childs = this.Childs;
            if (childs != null)
            {
                foreach (var c in childs)
                    c.ExpandAll();
            }
        }

        public int GetLevel()
        {
            if (Parent == null)
                return 0;
            return Parent.GetLevel() + 1;
        }
    }
}