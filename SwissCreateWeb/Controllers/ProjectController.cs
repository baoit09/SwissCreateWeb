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

namespace SwissCreateWeb.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {
        #region Fields

        private readonly IWorkContext _workContext;
        private readonly IProjectService _projectService;
        private readonly IProjectCategoryService _projectCategoryService;

        #endregion

        #region Ctor

        public ProjectController(IWorkContext workContext, IProjectService projectService, IProjectCategoryService projectCategoryService)
        {
            this._workContext = workContext;
            this._projectService = projectService;
            this._projectCategoryService = projectCategoryService;
        }

        #endregion

        public ActionResult ProjectEdit(int ProjectId)
        {
            ProjectEditModel model  = LocalGetProjectEditModel(ProjectId);
            return View(model);
        }

        public ActionResult GetProjectEditModel(int projectId)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            return Json(model);
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
                            var nextQA = projectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupindex].QuestionAnswers[nLength-1];

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

        #region Tabs
        public ActionResult Tab_BusinessModel(int projectId)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            return View(model);
        }

        public ActionResult Save_Tab_BusinessModel_QA(int projectId, int stepIndex, Step_QuestionAnwserStep qa)
        {
            bool bSuccess = false;
            var project = _projectService.GetProjectById(projectId);
            if (project != null)
            {
                ProjectData projectData = ProjectData.GetFromXML(project.ProjectData);
                if (projectData != null)
                {
                    var questionAnwserStep = projectData.Period.Steps[stepIndex].QuestionAnwserStep;
                    for (int i = 0; i < questionAnwserStep.QuestionAnwserGroups[0].QuestionAnswers.Length; i++)
                    {
                        questionAnwserStep.QuestionAnwserGroups[0].QuestionAnswers[i].Answer = qa.QuestionAnwserGroups[0].QuestionAnswers[i].Answer;
                    }
                }

                string sXML = projectData.ToXML();
                project.ProjectData = sXML;
                bSuccess = _projectService.UpdateProject(project);
            }

            return Json(new { success = bSuccess });
        }

        public ActionResult Tab_SwotAnalysis(int projectId)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            return PartialView(model);
        }
        #endregion
    }
}
