using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FM.HRMS.Models
{
    public class Applicant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Applicantid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Experience { get; set; }
        public string HighestQualification { get; set; }
        public string Email { get; set; }
        public string Current_Address { get; set; }
        public string Pincode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Platform { get; set; }
        public string PreviousCompanyName { get; set; }
        public string CurrentCompanyName { get; set; }
        public byte[] ResumeData { get; set; }
       /* public DateOnly CreatedTime { get; set; } = DateOnly.FromDateTime(DateTime.Now);*/
        public DateFormat CreatedTime { get; set; } = DateFormat.ShortTime;

        /*   public int JobId { get; set; }
           public AddJob AddJob { get; set; }*/

        public int JobId { get; set;}
        [ForeignKey("JobId")]
        public AddJob AddJob{ get; set; }
    }
}
