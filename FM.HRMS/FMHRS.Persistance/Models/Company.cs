using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FM.HRMS.Models
{
    public class Company : IdentityUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CompanyCIN{ get; set; }
        public string CompanyName { get; set; }
        public string Location{ get; set; }
        public DateOnly CreatedTime { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        
    }
}