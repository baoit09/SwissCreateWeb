using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwissCreateWeb.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult ShowError(string errorMsg)
        {
            ViewBag.ErrorMessage = errorMsg;
            return View();
        }
    }
}