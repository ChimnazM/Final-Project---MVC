using System.Collections.Generic;

namespace MvcFinalProject.Areas.Dashboard.ViewModels
{
    public class AddRoleVM
    {
        public string UserId { get; set; }
        public List<string> Roles { get; set; }
        public string RoleName { get; set; }
    }
}
