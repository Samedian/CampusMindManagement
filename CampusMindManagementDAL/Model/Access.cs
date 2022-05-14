using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CampusMindManagementDAL.Model
{
    public class Access
    {
        [Key]
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public string RoleAssign { get; set; }

    }
}
