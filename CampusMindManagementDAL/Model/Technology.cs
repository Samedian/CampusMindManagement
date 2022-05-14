using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CampusMindManagementDAL.Model
{
    [Table("Technology")]
    public class Technology
    {
        [Key]
        [Required]
        public int TechonolgyId { get; set; }

        [Required]
        public string TechnologyName { get; set; }
    }
}
