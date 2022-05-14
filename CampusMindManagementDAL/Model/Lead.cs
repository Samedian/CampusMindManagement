using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CampusMindManagementDAL.Model
{
    [Table("Lead")]
    public class Lead
    {
        [Key]
        [Required]
        public int LeadId { get; set; }

        [Required]
        public string LeadName { get; set; }

        [Required]
        public int TechnologyId { get; set; }
        
        public Technology Technology { get; set; }
    }
}
