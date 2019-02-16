using EducateMeForums.ViewModels.ApplicationUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducateMeForums.ViewModels.Demographic
{
    public class DemographicListingModel
    {
        public int Id { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
        public string Introduction { get; set; }

      }
}
