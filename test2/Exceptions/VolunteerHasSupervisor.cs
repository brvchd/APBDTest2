using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test2.Exceptions
{
    public class VolunteerHasSupervisor : Exception
    {
        public VolunteerHasSupervisor() : base("Volunteer has an supervisor. It is impossible to proceed.")
        {

        }
    }
}
