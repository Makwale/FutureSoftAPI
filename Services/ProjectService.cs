using Newtonsoft.Json;
using ProjectsAPI.Entities;
using ProjectsAPI.Interfaces;

namespace ProjectsAPI.Services
{
    public class ProjectService : IProjectService
    {
        public Project[] GetProjects()
        {
            string jsonFilePath = "./Data/Data.json";

            try
            {
                //Reding json file
                var jsonContent = System.IO.File.ReadAllText(jsonFilePath);

                var projects = JsonConvert.DeserializeObject<Project[]>(jsonContent);

                return projects;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
