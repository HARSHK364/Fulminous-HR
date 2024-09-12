using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace FM.HRMS.Models
{
    public class AddJob
    {
        [Key]
        public int JobId { get; set; }
        public string JobRole { get; set; }
        public string Experience { get; set; }
        public string JobDescription { get; set; }
        public string Address { get; set; }
        /*public DateOnly CreatedTime { get; set; } = DateOnly.FromDateTime(DateTime.Now);*/
        public DateFormat CreatedTime { get; set; }=DateFormat.ShortTime;


    }
}
