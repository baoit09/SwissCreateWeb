using SwissCreate.Core;
using SwissCreate.Services.Projects;
using System.Web.Mvc;
using System.Linq;
using SwissCreate.Core.Domain.Projects;
using System.Collections.Generic;
using SwissCreateWeb.Models.Project;
using SwissCreateWeb.Extensions;
using SwissCreateWeb.Framework.Helpers;
using ViCode_LeVi.Data;
using Newtonsoft.Json;
using SwissCreateWeb.CustomAttributes;

namespace SwissCreateWeb.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {
        #region Fields

        private readonly IWorkContext _workContext;
        private readonly IProjectService _projectService;
        private readonly IProjectCategoryService _projectCategoryService;

        private readonly ProjectSettings _projectSettings;

        #endregion

        #region Ctor

        public ProjectController(IWorkContext workContext, IProjectService projectService, IProjectCategoryService projectCategoryService, ProjectSettings projectSettings)
        {
            this._workContext = workContext;
            this._projectService = projectService;
            this._projectCategoryService = projectCategoryService;

            this._projectSettings = projectSettings;
        }

        #endregion

        public ActionResult ProjectEdit(int ProjectId)
        {
            ProjectEditModel model  = LocalGetProjectEditModel(ProjectId);
            ViewBag.ProjectSettings = _projectSettings;

            // Log Last Viewed DateTime and by User
            _projectService.LogLastViewProject(ProjectId, _workContext.CurrentUser);

            return View(model);
        }

        public ActionResult GetProjectEditModel(int projectId)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            return Json(model);
        }

        public ActionResult UpdateProjectEditModel(ProjectEditModel projectEditModel)
        {
            bool bSuccess = false;
            var project = _projectService.GetProjectById(projectEditModel.Project.Id);
            if (project != null)
            {
                string sXML = projectEditModel.ProjectData.ToXML();
                project.ProjectData = sXML;
                bSuccess = _projectService.UpdateProject(project);                
            }
            if (bSuccess)
            {
                // Log Last Update DateTime and by User
                _projectService.LogLastUpdateProject(projectEditModel.Project.Id, _workContext.CurrentUser);
            }
            return Json(new { success = bSuccess });
        }

        private ProjectEditModel LocalGetProjectEditModel(int projectId)
        {
            ProjectEditModel model = new ProjectEditModel();

            var project = _projectService.GetProjectById(projectId);
            if (project != null)
            {
                model.Project = project.ToModel();
                model.ProjectData = ProjectData.GetFromXML(project.ProjectData);
            }
            return model;
        }

        #region Tabs

        #region Shared tabs

        #region Question Answer Operation

        public ActionResult QuestionAnswerStep(int projectId, int stepIndex)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            Step_QuestionAnwserStep QuestionAnwserStep = model.ProjectData.Periods[0].Steps[stepIndex].QuestionAnwserStep;
            return View(QuestionAnwserStep);
        }

        public ActionResult DeleteQuestionAnswer(int projectId, int stepIndex, int groupindex, int questionindex, string option)
        {
            bool bSuccess = false;
            var project = _projectService.GetProjectById(projectId);
            if (project != null)
            {
                ProjectData projectData = ProjectData.GetFromXML(project.ProjectData);
                if (project != null)
                {
                    var questionAnswer = projectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupindex].QuestionAnswers[questionindex];
                    if (option == "question")
                    {
                        questionAnswer.Question = string.Empty;
                    }
                    else if (option == "answer")
                    {
                        questionAnswer.Answer = string.Empty;
                    }
                    else if (option == "both")
                    {
                        var QuestionAnswers = projectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupindex].QuestionAnswers;
                        projectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupindex].QuestionAnswers = QuestionAnswers.Except(new Step_QuestionAnwser[1] { questionAnswer }).ToArray();
                    }
                }
                string sXML = projectData.ToXML();
                project.ProjectData = sXML;
                bSuccess = _projectService.UpdateProject(project);
            }
            return Json(new { success = bSuccess });
        }

        public ActionResult MoveQuestionAnswer(int projectId, int stepIndex, int groupindex, int questionindex, string option)
        {
            var project = _projectService.GetProjectById(projectId);
            if (project != null)
            {
                ProjectData projectData = ProjectData.GetFromXML(project.ProjectData);
                if (project != null)
                {
                    var nLength = projectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupindex].QuestionAnswers.Length;
                    if (option == "Up")
                    {
                        if (questionindex == 0)
                        {
                            return Json(new { success = true });
                        }
                        else
                        {
                            var currentQA = projectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupindex].QuestionAnswers[questionindex];
                            var priviousQA = projectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupindex].QuestionAnswers[questionindex - 1];

                            string sQuestion = currentQA.Question;
                            string sAnswer = currentQA.Question;

                            currentQA.Question = priviousQA.Question;
                            currentQA.Answer = priviousQA.Answer;

                            priviousQA.Question = sQuestion;
                            priviousQA.Answer = sAnswer;

                        }
                    }
                    else if (option == "Down")
                    {
                        if (questionindex == nLength - 1)
                        {
                            return Json(new { success = true });
                        }
                        else
                        {
                            var currentQA = projectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupindex].QuestionAnswers[questionindex];
                            var nextQA = projectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupindex].QuestionAnswers[questionindex + 1];

                            string sQuestion = currentQA.Question;
                            string sAnswer = currentQA.Question;

                            currentQA.Question = nextQA.Question;
                            currentQA.Answer = nextQA.Answer;

                            nextQA.Question = sQuestion;
                            nextQA.Answer = sAnswer;

                        }
                    }
                    else if (option == "Top")
                    {
                        if (questionindex == 0)
                        {
                            return Json(new { success = true });
                        }
                        else
                        {
                            var currentQA = projectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupindex].QuestionAnswers[questionindex];
                            var priviousQA = projectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupindex].QuestionAnswers[0];

                            string sQuestion = currentQA.Question;
                            string sAnswer = currentQA.Question;

                            currentQA.Question = priviousQA.Question;
                            currentQA.Answer = priviousQA.Answer;

                            priviousQA.Question = sQuestion;
                            priviousQA.Answer = sAnswer;

                        }
                    }
                    else if (option == "Bottom")
                    {
                        if (questionindex == nLength - 1)
                        {
                            return Json(new { success = true });
                        }
                        else
                        {
                            var currentQA = projectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupindex].QuestionAnswers[questionindex];
                            var nextQA = projectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupindex].QuestionAnswers[nLength - 1];

                            string sQuestion = currentQA.Question;
                            string sAnswer = currentQA.Question;

                            currentQA.Question = nextQA.Question;
                            currentQA.Answer = nextQA.Answer;

                            nextQA.Question = sQuestion;
                            nextQA.Answer = sAnswer;

                        }
                    }
                }
                string sXML = projectData.ToXML();
                project.ProjectData = sXML;
                bool bSuccess = _projectService.UpdateProject(project);
                return Json(new { success = bSuccess });
            }

            return Json(new { success = true });
        }

        public ActionResult AddNewQuestionAnswer(int projectId, int stepIndex, int groupIndex, string questionText)
        {
            var project = _projectService.GetProjectById(projectId);
            if (project != null)
            {
                ProjectData projectData = ProjectData.GetFromXML(project.ProjectData);
                if (project != null)
                {
                    Step_QuestionAnwser newQA = new Step_QuestionAnwser()
                    {
                        Question = questionText,
                        Answer = string.Empty
                    };
                    var listQAs = projectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupIndex].QuestionAnswers.ToList();
                    listQAs.Add(newQA);
                    projectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupIndex].QuestionAnswers = listQAs.ToArray();
                }

                string sXML = projectData.ToXML();
                project.ProjectData = sXML;
                bool bSuccess = _projectService.UpdateProject(project);
                return Json(new { success = bSuccess });
            }

            return Json(new { success = true });
        }

        #endregion

        public ActionResult Save_QuestionAnwserStep(int projectId, int stepIndex, Step_QuestionAnwserStep qa)
        {
            bool bSuccess = false;
            var project = _projectService.GetProjectById(projectId);
            if (project != null)
            {
                ProjectData projectData = ProjectData.GetFromXML(project.ProjectData);
                if (projectData != null)
                {
                    var questionAnwserStep = projectData.Periods[0].Steps[stepIndex].QuestionAnwserStep;
                    for (int g = 0; g < questionAnwserStep.QuestionAnwserGroups.Length; g++)
                    {
                        for (int q = 0; q < questionAnwserStep.QuestionAnwserGroups[g].QuestionAnswers.Length; q++)
                        {
                            questionAnwserStep.QuestionAnwserGroups[g].QuestionAnswers[q].Answer = qa.QuestionAnwserGroups[g].QuestionAnswers[q].Answer;
                        }
                    }
                }

                string sXML = projectData.ToXML();
                project.ProjectData = sXML;
                bSuccess = _projectService.UpdateProject(project);
            }

            return Json(new { success = bSuccess });
        }

        public ActionResult Save_StepResult(int projectId, int stepIndex, int radioResult, string Note)
        {
            bool bSuccess = false;
            var project = _projectService.GetProjectById(projectId);
            if (project != null)
            {
                ProjectData projectData = ProjectData.GetFromXML(project.ProjectData);
                if (projectData != null)
                {
                    var stepResult = projectData.Periods[0].Steps[stepIndex].Result;
                    if (radioResult == 0)
                    {
                        stepResult.Item = StepResult.StepResultItem_None;
                    }
                    else if (radioResult == 1)
                    {
                        stepResult.Item = StepResult.StepResultItem_Bad;
                    }
                    else if (radioResult == 2)
                    {
                        stepResult.Item = StepResult.StepResultItem_Normal;
                    }
                    else if (radioResult == 3)
                    {
                        stepResult.Item = StepResult.StepResultItem_Good;
                    }
                    stepResult.Note = Note;
                }

                string sXML = projectData.ToXML();
                project.ProjectData = sXML;
                bSuccess = _projectService.UpdateProject(project);
            }

            return Json(new { success = bSuccess });
        }

        public ActionResult Get_Project_Settings()
        {
            return Json(_projectSettings);
        }

        public ActionResult UpdateReportLayout(int projectId, string JSONReportLayout)
        {
            bool bSuccess = false;
            var project = _projectService.GetProjectById(projectId);
            if (project != null)
            {
                project.ReportLayout = JSONReportLayout;
                bSuccess = _projectService.UpdateProject(project);
            }

            return Json(new { success = bSuccess });
        }
        #endregion

        #region Tab_BusinessModel

        public ActionResult Tab_BusinessModel(int projectId)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            ViewBag.StepIndex = _projectSettings.Step_BusinessModel_Index;
            return View(model);
        }

        #endregion

        #region Tab_SwotAnalysis

        public ActionResult Tab_SwotAnalysis(int projectId)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            ViewBag.StepIndex = _projectSettings.Step_SwotAnalysis_Index;
            return PartialView(model);
        }

        #endregion 

        #region Tab_BusinessStrategy

        public ActionResult Tab_BusinessStrategy(int projectId)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            ViewBag.StepIndex = _projectSettings.Step_BusinessStrategy_Index;
            return PartialView(model);
        }

        #endregion

        #region Tab_SuccessFactors

        #endregion

        #region Tab_Review

        public ActionResult Tab_Review(int projectId)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            ViewBag.StepIndex = _projectSettings.Step_Review_Index;
            return PartialView(model);
        }

        #endregion

        #region Tab_Evaluation

        public ActionResult Tab_Evaluation(int projectId)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            ViewBag.StepIndex = _projectSettings.Step_Evaluation_Index;
            return PartialView(model);
        }

        public ActionResult Save_Tab_Evaluation(int projectId, string sInterpretation1, string sInterpretation2, string sInterpretation3)
        {
            int stepIndex = _projectSettings.Step_Evaluation_Index;

            bool bSuccess = false;
            var project = _projectService.GetProjectById(projectId);
            if (project != null)
            {
                ProjectData projectData = ProjectData.GetFromXML(project.ProjectData);
                if (projectData != null)
                {
                    projectData.Periods[0].Steps[stepIndex].Analysis.Interpretation1 = sInterpretation1;
                    projectData.Periods[0].Steps[stepIndex].Analysis.Interpretation2 = sInterpretation2;
                    projectData.Periods[0].Steps[stepIndex].Analysis.Interpretation3 = sInterpretation3;

                    string sXML = projectData.ToXML();
                    project.ProjectData = sXML;

                    bSuccess = _projectService.UpdateProject(project);
                }
            }

            return Json(new { success = bSuccess });
        }


        #endregion

        #region Tab_Measures

        public ActionResult Tab_Measures(int projectId)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            ViewBag.StepIndex = _projectSettings.Step_Measures_Index;
            return PartialView(model);
        }

        public ActionResult Post_Measures(int projectId, Step_Measurement_Item[] measurements)
        {
            int stepIndex = _projectSettings.Step_Measures_Index;

            bool bSuccess = false;
            var project = _projectService.GetProjectById(projectId);
            if (project != null)
            {
                ProjectData projectData = ProjectData.GetFromXML(project.ProjectData);
                if (projectData != null)
                {
                    projectData.Periods[0].Steps[stepIndex].Measurement.Measurements = measurements;
                   
                    string sXML = projectData.ToXML();
                    project.ProjectData = sXML;

                    bSuccess = _projectService.UpdateProject(project);
                }
            }

            return Json(new { success = bSuccess });
        }

        #endregion

        #region Tab_Marketing

        public ActionResult Tab_Marketing(int projectId)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            ViewBag.StepIndex = _projectSettings.Step_Marketing_Index;
            return PartialView(model);
        }

        #endregion

        #region Tab_Finance

        public ActionResult Tab_Finance(int projectId)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            ViewBag.StepIndex = _projectSettings.Step_Finance_Index;
            return PartialView(model);
        }

        #endregion

        #region Tab_Risk

        public ActionResult Tab_Risk(int projectId)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            ViewBag.StepIndex = _projectSettings.Step_Risk_Index;
            return PartialView(model);
        }

        #endregion

        #region Tab_Charts

        public ActionResult Tab_Charts(int projectId)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            ViewBag.StepIndex = _projectSettings.Step_Charts_Index;
            return PartialView(model);
        }

        #endregion

        #region Tab_HR

        public ActionResult Tab_HR(int projectId)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            ViewBag.StepIndex = _projectSettings.Step_HR_Index;
            return PartialView(model);
        }

        #endregion

        #region Tab_Conclusion

        public ActionResult Tab_Conclusion(int projectId)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            ViewBag.StepIndex = _projectSettings.Step_Conclusion_Index;
            return PartialView(model);
        }

        #endregion


        #endregion
    }
}
