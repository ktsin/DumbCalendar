using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Services;
using DumbCalendar.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DumbCalendar.Controllers
{
    [Authorize]
    public class ProjectsController : Controller
    {
        private readonly IGroupService _groupService;
        private readonly IProjectService _projectService;
        private readonly IUserDataService _userDataService;
        private readonly UserManager<IdentityUser> _userManager;

        public ProjectsController(UserManager<IdentityUser> userManager, IUserDataService userDataService,
            IProjectService projectService, IGroupService groupService)
        {
            _userManager = userManager;
            _userDataService = userDataService;
            _projectService = projectService;
            _groupService = groupService;
        }

        public async Task<IActionResult> Index()
        {
            List<ProjectDTO> projects =
                await _projectService.GetUsersProjects(_userManager.GetUserId(User)) as List<ProjectDTO>;
            projects = projects.Concat(await _projectService.UserOwnedProjects(_userManager.GetUserId(User))).ToList();
            return View(projects);
        }

        public async Task<IActionResult> ProjectInfo(int id)
        {
            var project = await _projectService.GetProjectById(id);
            return PartialView("_projectDetails", project);
        }

        [HttpGet]
        public async Task<IActionResult> AddParticipantToProject(int id)
        {
            var availableUsers = await _groupService.GetUserGroups(_userManager.GetUserId(User));
            var select = availableUsers.Select(e => e.GroupParticipants);
            var list = new List<UserDTO>();
            foreach (var col in select)
            {
                list.AddRange(col);
            }

            var options = list
                .Distinct()
                .Select(e => new {Id = e.Id, FullName = e.FullName})
                .ToList();
            ViewBag.SelectOpts = new MultiSelectList(options, "Id", "FullName");
            // var categories = db.Categories.Select(c => new { 
            //     CategoryID = c.CategoryID, 
            //     CategoryName = c.CategoryName 
            // }).ToList();
            // ViewBag.Categories = new MultiSelectList(categories, "CategoryID", "CategoryName");
            return PartialView("_addToProject", new AddParticipantViewModel()
            {
                AvailableUsers = list,
                SelectedUser = ViewBag.SelectOpts,
                TargetId = id
            });
        }

        [HttpPost]
        public async Task<IActionResult> AddParticipantToProject(string[] id)
        {
            int projectId = Int32.Parse(Request.Form["TargetId"]);
            id = id.Distinct().ToArray();
            foreach (var uid in id)
            {
                await _projectService.AddUserToProject(projectId, uid);
            }

            return RedirectToAction("Index");
        }
    }
}