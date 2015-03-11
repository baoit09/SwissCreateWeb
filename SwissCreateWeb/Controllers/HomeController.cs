using SwissCreate.Core;
using SwissCreate.Core.Domain.Users;
using SwissCreate.Core.Infrastructure;
using SwissCreate.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwissCreateWeb.Controllers
{
    public class HomeController : Controller
    {
        #region Fields
        private readonly IUserService _userService;
        #endregion

        #region Ctor

        public HomeController(){}

        public HomeController(IUserService userService)
        {
            this._userService = userService;
        }

        #endregion

        public ActionResult Index()
        {
            IPagedList<User> users = _userService.GetAllUsers();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}