using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class Attendance
    {
        public Course Course { get; set; }
        [Key]
        [Column(Order =1)]
        public int CourseId { get; set; }
        public ApplicationUser Attendee { get; set; }
        [Key]
        [Column(Order =2)]
<<<<<<< HEAD
        public string AttendeeId { get; set; }
=======
        public ApplicationUser AttendeeId { get; set; }
>>>>>>> 5ab4a5e12a3212340facf04d930f3a1621409ff2
    }
}