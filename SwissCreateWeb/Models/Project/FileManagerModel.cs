using SwissCreateWeb.Framework.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SwissCreateWeb.Models.Project
{
    public class FileManagerModel : BaseSwissCreateModel
    {
        public ProjectCategoryModel ProjectCategoryRoot { get; set; }

        [Display(Name = "Confirm new password")]
        public bool IsOnlyShowFolderHasProject { get; set; }
    }
}