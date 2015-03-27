using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SwissCreateWeb.Framework.Mvc
{
    public class SwissCreateModelBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var model = base.BindModel(controllerContext, bindingContext);
            if (model is BaseSwissCreateModel)
            {
                ((BaseSwissCreateModel)model).BindModel(controllerContext, bindingContext);
            }
            return model;
        }
    }
}
