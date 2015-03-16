using SwissCreateWeb.Framework.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwissCreateWeb.Models.Common
{
    public class LanguageModel : BaseSwissCreateEntityModel
    {
        public string Name { get; set; }

        public string FlagImageFileName { get; set; }
    }
}