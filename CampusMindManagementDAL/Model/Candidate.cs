using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CampusMindManagementDAL.Model
{
    [Table("Candidate")]
    public class Candidate
    {
        [Key]
        [Required]
        public int CandidateId { get; set; }

        [Required]
        public string CandidateName { get; set; }

        [Required]
        [ForeignKey("LeadId")]
        public int LeadId { get; set; }

        public Lead Lead { get; set; }
    }
}
