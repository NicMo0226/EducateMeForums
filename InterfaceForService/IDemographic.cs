using EducateMeForums.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducateMeForums.InterfaceForService
{
    public interface IDemographic
    {
        Demographic GetById(int id);
        IEnumerable<Demographic> GetAll();

        Task Create(Demographic demographic);
        Task Delete(int demographicId);
        Task EditDemographicTown(int id, string newTown);
        Task EditDemographicCountry(int id, string newCountry);
    }
}
