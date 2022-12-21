using Microsoft.AspNetCore.Identity;

namespace AspNetCoreIdentity.Models.Identity
{
    public class AppUser:IdentityUser<Guid>
    {
        public string City { get; set; }
    }
}
