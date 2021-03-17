using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _413_Project_one.Models
{
    public class AppointmentModel
    {
        [Key]
        [Required]
        public int AppointmentID { get; set; }

        [Required]
        public DateTime AppointmentStartTime { get; set; }

        [Required]
        public bool Booked { get; set; } = false;

    }
}