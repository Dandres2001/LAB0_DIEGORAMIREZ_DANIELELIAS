using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LAB0_DIEGORAMIREZ_DANIELELIAS.Models
{
    public class Client
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
