using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectMgtSystemApi.Data.Dto.Projects;
using ProjectMgtSystemApi.Models;

namespace ProjectMgtSystemApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private DataContext _context;
        public ProjectsController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProjects()
        {
            var projects = await _context.Projects
            .Include(p => p.ProjectManager)
            .Select(p => new
            {
                p.Id,
                p.ProjectName,
                p.Description,
                p.Status,
                ProjectManager = p.ProjectManager!.Name,
                p.StartDate,
                p.EndDate
            })
            .ToListAsync();

            return Ok(projects);
        }

        [HttpPost]
        public async Task<IActionResult> AddProject([FromBody] AddProjectsDto _project)
        {
            var project = new Projects
            {
                ProjectName = _project.ProjectName,
                Description = _project.Description,
                Status = _project.Status,
                ProjectManagerId = 1,
                StartDate = _project.StartDate,
                EndDate = _project.EndDate
            };

            await _context.Projects.AddAsync(project);
            await _context.SaveChangesAsync();

            return Created("", project);
        }
    }
}