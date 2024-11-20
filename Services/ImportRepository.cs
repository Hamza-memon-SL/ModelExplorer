using GenAiPoc.Contracts.Context;
using GenAiPoc.Contracts.Models;
using GenAiPoc.Contracts.Response;
using GenAiPoc.Interfaces;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace GenAiPoc.Services
{
    public class ImportRepository:IImportRepository
    {
        private readonly DbContextGenAiPOC _dbContextGenAiPOC;

        public ImportRepository(DbContextGenAiPOC dbContextGenAiPOC)
        {

            _dbContextGenAiPOC = dbContextGenAiPOC;
        }

        public async Task<ImportResponse> ImportFile(string url, string ProjectName)
        {
            //_logger.Info(LoggingConstant.Start);
            //Projects projects = new Projects();
            bool isSuccess = false;

            try
            {
                var isProjectExist = await _dbContextGenAiPOC.Projects.Where(x => x.GitHubURL.Equals(url)).FirstOrDefaultAsync();
                if (isProjectExist == null)
                {
                    Projects projects = new Projects();

                    projects.Name = ProjectName;
                    projects.GitHubURL = url;
                    projects.Status = "New";
                    projects.CreateDate = DateTime.Now;
                    await _dbContextGenAiPOC.Projects.AddAsync(projects);
                    int isProjectAdded = await _dbContextGenAiPOC.SaveChangesAsync();

                    if (isProjectAdded > 0)
                    {
                        isSuccess = true;
                        return new ImportResponse(0, "Project Added Successfully");
                    }
                    else
                    {
                        isSuccess = false;
                        return new ImportResponse(1, "Project Added Failed");
                    }
                }
                else
                {
                  
                        isSuccess = false;
                    return new ImportResponse(1, "Project Already Exist, Please try different project repo");
                }
            }
            catch (Exception ex)
            {

                return new ImportResponse(1, "Project Added Failed, Something Went Wrong");

            }
        }

    }
}
