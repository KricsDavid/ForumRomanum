using Microsoft.AspNetCore.Identity;

namespace ForumRomanum.Models
{
    public class User : IdentityUser
    {
        string? VezetekNev { get; set; }
        string? KereszNev { get; set; }

    }
}
