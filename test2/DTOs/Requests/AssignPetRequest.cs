using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace test2.DTOs.Requests
{
    public class AssignPetRequest
    {
        [Required]
        public int IdPet { get; set; }
        [Required]
        public DateTime DateAccepted { get; set; }
    }
}
