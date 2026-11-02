using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace Class08.Data;
// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [DataType(DataType.Date)]
    public DateTime Birthday { get; set; }
}
