using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectsAPI.Entities;
using ProjectsAPI.Interfaces;
using System;
using System.Collections;
using System.IO;
using System.Net.Http.Json;
using System.Text.Json;

namespace ProjectsAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class ProjectsController: ControllerBase
    {
        private IProjectService _projectService;

        //Injecting services required for request, in this case it will be IProjectService
        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }


        /// <summary>
        /// This endpoint is used to get projects
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetProjects")]   
        public async Task<ActionResult<IEnumerable>> GetProjects()
        {
            // Get projects from project service
            var projects = _projectService.GetProjects();

            return Ok(projects);
        }
    }
}
