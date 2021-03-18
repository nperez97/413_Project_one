using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _413_Project_one.Models
{
    public class Group
    {
        [Key]
        [Required]
        public int GroupID { get; set; }

        [Required]
        public string GroupName { get; set; }

        [Required]
        public int GroupSize { get; set; }

        [Required]
        [EmailAddress]
        public string GroupContactEmailAddress { get; set; }

        [RegularExpression(@"^\(\d{3}\)\s\d{3}-\d{4}", ErrorMessage = "Please enter phone in this format: (XXX) XXX-XXXX")]
        public string GroupContactPhoneNumber { get; set; }

        public string GroupAppointmentTime { get; set; }
        

    }
}
