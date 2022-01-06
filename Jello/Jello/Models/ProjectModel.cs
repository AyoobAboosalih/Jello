using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jello.Data;
using Microsoft.EntityFrameworkCore;

namespace Jello.Models
{
    public class ProjectModel
    {

        private readonly ApplicationDbContext _dbContext;
        public ProjectModel(ApplicationDbContext context)
        {
            _dbContext = context;
        }
        public async Task<bool> DeleteProject(Guid id)
        {
            var project = _dbContext.Projects.FirstOrDefault(x => x.Id == id);
            if (project != null)
            {
                _dbContext.Projects.Remove(project);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Project>> GetProjects()
        {
            return await _dbContext.Projects.ToListAsync();
        }

        public async Task<Project>  GetProjectById(Guid id)
        {
            var project = await _dbContext.Projects.FirstOrDefaultAsync(x => x.Id == id);
            return project;
        }

        public async Task<bool> SaveProject(Project project)
        {
            if (project.Id.Equals(0)) {
                project.Id = new Guid();
                await _dbContext.Projects.AddAsync(project);
            } 
            else _dbContext.Projects.Update(project);
            await _dbContext.SaveChangesAsync();
            return true;

        }
    }
}
