using EducateMeForums.Data;
using EducateMeForums.InterfaceForService;
using EducateMeForums.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducateMeForums.Services
{
    public class DemographicService : IDemographic
    {
        private readonly ApplicationDbContext _context;
        public DemographicService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Demographic GetById(int id)
        {
            return _context.Demographics.Where(d => d.Id == id)
                        .First();
        }

        public IEnumerable<Demographic> GetAll()
        {
            return _context.Demographics;
            // .Include(d => d.ApplicationUser);
        }


        public async Task Create(Demographic demographic)
        {
               _context.Add(demographic);
                await _context.SaveChangesAsync();
         }

        public async Task Delete(int demographicId)
        {
            var demographic = GetById(demographicId);
            _context.Remove(demographic);
            await _context.SaveChangesAsync();
        }

        public async Task EditDemographicTown(int id, string newTown)
        {
            _context.Update(newTown);
            await _context.SaveChangesAsync();
        }
        public async Task EditDemographicCountry(int id, string newCountry)
        {
            _context.Update(newCountry);
            await _context.SaveChangesAsync();
        }
   }
}
