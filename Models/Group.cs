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

        [Phone]
        public string GroupContactPhoneNumber { get; set; }

        [Required]
        public int GroupAppointmentID { get; set; }

    }
}
