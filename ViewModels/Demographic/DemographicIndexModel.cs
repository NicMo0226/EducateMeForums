using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EducateMeForums.ViewModels.Forum;

namespace EducateMeForums.ViewModels.Demographic
{
    public class DemographicIndexModel
    {
        public int Id { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
        public string Introduction { get; set; }

        public string UserName { get; set; }
        public int ApplicatioUserId { get; set; }
    }
}