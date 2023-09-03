using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.Areas.Admin.Models
{
    public class RoleUpdateViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Role ismi: ")]
        public string Name { get; set; } = null!;
    }
}
