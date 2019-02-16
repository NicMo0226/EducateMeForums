using EducateMeForums.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducateMeForums.InterfaceForService
{
    public interface IPortfolio
    { 
        Portfolio GetById(int id);
         IEnumerable<Portfolio> GetAll();

        Task Create(Portfolio portfolio);
        Task Delete(int portfolioId);
        Task EditPortfolioHighestLevel(int id, string newHighestLevel);
        Task EditPortfolioSubject(int id, string newSubject);
        Task EditPortfolioAchievedDate(int id, string newAcheivedDate);
        Task EditPortfolioAcademicInstitution(int id, string newAcademicInstitution);
        Task EditPortfolioWebsite(int id, string newWebsite);
      
    }
}
