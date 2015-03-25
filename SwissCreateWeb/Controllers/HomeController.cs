using SwissCreate.Core;
using SwissCreate.Core.Domain.Users;
using SwissCreate.Core.Infrastructure;
using SwissCreate.Services.Projects;
using SwissCreate.Services.Users;
using SwissCreateWeb.Framework.Helpers;
using SwissCreateWeb.Models.Project;
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
        private readonly IProjectService _projectService;
        private readonly IXmlSerializeHelper _xmlSerializeHelper;
        #endregion

        #region Ctor

        public HomeController(){}

        public HomeController(IProjectService projectService, IXmlSerializeHelper xmlSerializeHelper)
        {
            this._projectService = projectService;
            this._xmlSerializeHelper = xmlSerializeHelper;
        }

        #endregion

        public ActionResult Index()
        {
            string sFile = @"E:\Working\SwissCreateWeb\SwissCreateWeb.Tests\XMLFile2.xml";
            string sXML = System.IO.File.ReadAllText(sFile);
            var a = _xmlSerializeHelper.XmlDeserializeObject<ProjectData>(sXML);

            //var project = _projectService.GetProjectById(22);
            //var a = _xmlSerializeHelper.XmlDeserializeObject<ProjectData>(project.ProjectData);
            
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