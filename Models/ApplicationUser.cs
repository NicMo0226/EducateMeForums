using System;
using Microsoft.AspNetCore.Identity;

namespace EducateMeForums.Models
{
    public class ApplicationUser : IdentityUser    {
      public string ProfileImageUrl { get; set; }

    public DateTime MemberSince { get; set; }

    public DateTime BirthDate { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }


    public bool IsActive { get; set; }

    public int UserRating { get; set; }


    public virtual Demographic DemographicWithProfile { get; set; }

    public virtual WallPost WallPostsWithProfile { get; set; }

    public virtual Portfolio PortfolioWithProfile { get; set; }
    }
}
      
