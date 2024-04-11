using Microsoft.AspNetCore.Identity;

namespace BlazorWebServerDRM.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? Country { get; set; }
    }

}
