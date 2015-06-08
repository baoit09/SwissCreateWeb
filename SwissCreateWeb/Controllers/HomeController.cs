using Newtonsoft.Json;
using SwissCreate.Core;
using SwissCreate.Core.Domain.Projects;
using SwissCreate.Core.Domain.Users;
using SwissCreate.Core.Infrastructure;
using SwissCreate.Services.Configuration;
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
        private readonly ISettingService _settingService;

        private readonly ProjectSettings _projectSettings;
        #endregion

        #region Ctor

        public HomeController(){}

        public HomeController(ISettingService settingService)
        {
            //this._projectService = projectService;
            //this._xmlSerializeHelper = xmlSerializeHelper;
            this._settingService = settingService;

            //this._projectSettings = projectSettings;
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

            //TestData();

            return View();
        }

        private void TestData()
        {
            //int stepIndex = _projectSettings.Step_SuccessFactors_Index;
            //var project = _projectService.GetProjectById(24);
            //if (project != null)
            //{
            //    ProjectData projectData = ProjectData.GetFromXML(project.ProjectData);
            //    if (projectData != null)
            //    {
            //        var taskItemStep = projectData.Period.Steps[stepIndex].TaskItemStep;

            //        string sJson = JsonConvert.SerializeObject(taskItemStep);                    
            //    }
            //}

            //ProjectSettings projectSettings = new ProjectSettings()
            //{
            //    Step_BusinessModel_Index = 0,
            //    Step_SwotAnalysis_Index = 1,
            //    Step_BusinessStrategy_Index = 2,
            //    Step_SuccessFactors_Index = 3,
            //    Step_Review_Index = 4,
            //    Step_Evaluation_Index = 5,
            //    Step_Measures_Index = 6,
            //    Step_Marketing_Index = 7,
            //    Step_Finance_Index = 9,
            //    Step_Risk_Index = 11,
            //    Step_Charts_Index = 12,
            //    Step_HR_Index = 13,
            //    Step_Conclusion_Index = 8,

            //    Url_Image_Sad = "~/Content/Images/1.png",
            //    Url_Image_Normal = "~/Content/Images/2.png",
            //    Url_Image_Happy = "~/Content/Images/3.png",

            //    Quantity_Image_Level1 = 30,
            //    Quantity_Image_Level2 = 59,
            //    Quantity_Image_Level3 = 100
            //};

            //_settingService.SaveSetting(projectSettings);

            //UserSettings userSettings = new UserSettings()
            //{
            //    DefaultPasswordFormat = PasswordFormat.Hashed
            //};
            //_settingService.SaveSetting(userSettings);
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