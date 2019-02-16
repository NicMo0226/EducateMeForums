using EducateMeForums.Data;
using EducateMeForums.InterfaceForService;
using EducateMeForums.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducateMeForums.Services
{
    public class PortfolioService : IPortfolio
    {
        private readonly ApplicationDbContext _context;
        public PortfolioService(ApplicationDbContext context)
        {
            _context = context;
        }

               
        public Portfolio GetById(int id)
        {
            return _context.Portfolios.Where(p => p.Id == id)
        //   .Include(p => p.ApplicationUser)
                     .First();
        }

        public IEnumerable<Portfolio> GetAll()
        {
            return _context.Portfolios;
         //   .Include(p => p.ApplicationUser);
        }

     
        public async Task Create(Portfolio portfolio)
        {
            _context.Add(portfolio);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int portfolioId)
        {
            var portfolio = GetById(portfolioId);
            _context.Remove(portfolio);
            await _context.SaveChangesAsync();
        }

        public  async Task EditPortfolioHighestLevel(int id, string newHighestLevel)
        {
            _context.Update(newHighestLevel);
            await _context.SaveChangesAsync();
        }

        public async Task EditPortfolioSubject(int id, string newSubject)
        {
            _context.Update(newSubject);
            await _context.SaveChangesAsync();
        }

        public async Task EditPortfolioAchievedDate(int id, string newAcheivedDate)
        {
            _context.Update(newAcheivedDate);
            await _context.SaveChangesAsync();
        }

        public async Task EditPortfolioAcademicInstitution(int id, string newAcademicInstitution)
        {
            _context.Update(newAcademicInstitution);
            await _context.SaveChangesAsync();
        }

        public async Task EditPortfolioWebsite(int id, string newWebsite)
        {
            _context.Update(newWebsite);
            await _context.SaveChangesAsync();
        }
    }
}
