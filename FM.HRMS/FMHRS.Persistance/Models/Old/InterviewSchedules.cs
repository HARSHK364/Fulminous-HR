using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace FM.HRMS.Models.Latest
{
    public class InterviewSchedules
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Scheduleid { get; set; }
        [ForeignKey("Aplicantid")]
        public int Applicantid { get; set; }
        [ForeignKey("Roundid")]
        public int Roundid { get; set; }
        public DateOnly ScheduleDate { get; set; }
        public TimeOnly ScheduleTime { get; set; }
        public string InterviewStatus { get; set; }
    }
}
