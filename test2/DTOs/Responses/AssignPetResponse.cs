using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test2.DTOs.Responses
{
    public class AssignPetResponse
    {
        public int IdVolunteer { get; set; }
        public int IdPet { get; set; }
        public DateTime DateAccepted { get; set; }
    }
}
