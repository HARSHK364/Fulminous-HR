using Microsoft.Identity.Client;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FM.HRMS.Models
{
    public class ApplicantJobRole
    {
        [Key]
        public int ApplicationId { get; set; }
        [ForeignKey("Applicantid")]
        public int Applicantid { get; set; }
        public Applicant Applicant { get; set; }
        [ForeignKey("JobId")]
        public int JobId { get; set; }
        public AddJob AddJob { get; set; }
        [ForeignKey("RoundId")]
        public int RoundId {  get; set; }
        public Round Round { get; set; }
        public DateOnly ApplicationDate { get; set; } = DateOnly.FromDateTime(dateTime: DateTime.Now);

    }
}
