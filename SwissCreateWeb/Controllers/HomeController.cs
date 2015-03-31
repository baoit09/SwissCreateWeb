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
using ViCode_LeVi.Data;

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
            //var projectData = new ProjectData();
            //projectData.Author = "Mr. Creator";

            //projectData.Periods = new Data.RootData[1];
            //projectData.Periods[0] = new Data.RootData();
            //projectData.Periods[0].Steps = new Data.StepInfo[0];
            //projectData.Periods[0].Steps[0] = new Data.StepInfo();
            //projectData.Periods[0].Steps[0].FullName = "BUSINESS MODEL DETAILS";
            //projectData.Periods[0].Steps[0].QuestionAnwserStep = new Data.Step_QuestionAnwserStep();
            //projectData.Periods[0].Steps[0].QuestionAnwserStep.QuestionAnwserGroups = new Data.Step_QuestionAnwserGroup[1];
            //projectData.Periods[0].Steps[0].QuestionAnwserStep.QuestionAnwserGroups[0] = new Data.Step_QuestionAnwserGroup();
            //projectData.Periods[0].Steps[0].QuestionAnwserStep.QuestionAnwserGroups[0].


            //string sFile = @"E:\Working\SwissCreateWeb\SwissCreateWeb.Tests\XMLFile2.xml";
            //string sXML = System.IO.File.ReadAllText(sFile);
           
            //var bytes = System.Text.Encoding.UTF8.GetBytes(sXML);

            //var b = XMLData<ProjectData>.GetEntity(bytes);


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