using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.Areas.Admin.Models
{
    public class RoleCreateViewModel
    {
        [Display(Name = "Role İsmi : ")]
        public string Name { get; set; }
    }
}
