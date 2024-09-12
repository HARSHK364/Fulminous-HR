using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FM.HRMS.Models.Latest
{
    public class ApplicantRounds
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApplicantRoundid { get; set; }
        [ForeignKey("Applicantid")]
        public int Applicantid { get; set; }
        [ForeignKey("Roundid")]
        public int Roundid { get; set; }
        public string Feedback { get; set; }
        public string Current_Status { get; set; }
        public DateTime Updated_at { get; internal set; } = DateTime.Now;
    }
}
