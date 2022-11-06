using DietTracker.Shared.Enums;
using Microsoft.AspNetCore.Identity;

namespace DietTracker.Data.Entities;

public class ApplicationUser : IdentityUser
{
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }

    public List<Target> Targets { get; set; }
}
