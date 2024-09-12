using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.VisualBasic;

namespace FM.HRMS.Models
{
    public class Round
    {
        [Key]
        public int RoundId { get; set; }
        public int JobId { get; set; }

        [ForeignKey("JobId")]
        public AddJob AddJob { get; set; }
        public string RoundName { get; set; }


/*        public int Applicantid { get; set; }
        [ForeignKey("Applicantid")]
        public Applicant Applicant { get; set; }*/



    }
}
