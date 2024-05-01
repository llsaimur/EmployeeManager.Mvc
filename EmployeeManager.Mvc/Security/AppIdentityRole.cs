using Microsoft.AspNetCore.Identity;

namespace EmployeeManager.Mvc.Security
{
    public class AppIdentityRole : IdentityRole
    {
        public string Description { get; set; }
    }
}
