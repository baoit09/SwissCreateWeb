using SwissCreate.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissCreate.Core.Domain.Projects
{
    public class ProjectSettings : ISettings
    {
        public int Step_BusinessModel_Index { get; set; }
        public int Step_SwotAnalysis_Index { get; set; }
        public int Step_BusinessStrategy_Index { get; set; }
        public int Step_SuccessFactors_Index { get; set; }
        public int Step_Review_Index { get; set; }
        public int Step_Evaluation_Index { get; set; }
        public int Step_Measures_Index { get; set; }
        public int Step_Marketing_Index { get; set; }
        public int Step_Finance_Index { get; set; }
        public int Step_Risk_Index { get; set; }
        public int Step_Charts_Index { get; set; }
        public int Step_HR_Index { get; set; }
        public int Step_Conclusion_Index { get; set; }

        public string Url_Image_Sad { get; set; }
        public string Url_Image_Normal { get; set; }
        public string Url_Image_Happy { get; set; }

        public int Quantity_Image_Level1 { get; set; }
        public int Quantity_Image_Level2 { get; set; }
        public int Quantity_Image_Level3 { get; set; }
    }
}
