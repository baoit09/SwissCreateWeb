using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Media;

namespace ViCode_LeVi.Data
{
    public class StepResult
    {
        public StepResultItem Item { get; set; }

        public static StepResultItem StepResultItem_None = new StepResultItem() { Value = 0, Color = Brushes.White, Description = string.Empty };
        public static StepResultItem StepResultItem_Bad = new StepResultItem() { Value = 1, Color = Brushes.Red, Description = "Not good" };
        public static StepResultItem StepResultItem_Normal = new StepResultItem() { Value = 2, Color = Brushes.Yellow, Description = "Normal" };
        public static StepResultItem StepResultItem_Good = new StepResultItem() { Value = 3, Color = Brushes.Green, Description = "Good" };

        public static StepResult Create_StepResult_None()
        {
            return new StepResult() { Item = StepResultItem_None };
        }
    }
}