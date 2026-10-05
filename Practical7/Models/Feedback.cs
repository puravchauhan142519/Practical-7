using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practical7.Models
{
    public class Feedback
    {
        [Required]
        public string StudentName { get; set; }

        [Required]
        [EmailAddress]
        public string StudentEmail { get; set; }

        [Required]
        public string Course { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public string Comment { get; set; }


    }
}