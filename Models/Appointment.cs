using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _413_Project_one.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public int AppointmentID { get; set; }
        
        [Required]
        public datetime AppointmentDateTime { get; set; }
        
        /*[Required]
        public int GroupSize { get; set; }
        
        [Required]
        [EmailAddress]
        public string GroupEmailAddress { get; set; } 
       
        [Phone]
        public string GroupPhoneNumber { get; set; } */

    }
}
