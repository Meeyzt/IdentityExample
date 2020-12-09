using System.ComponentModel.DataAnnotations;

namespace IdentityExample.Models.Administration
{
    public class Role
    {
        [Required]
        public string RoleName { get; set; }
    }
}
