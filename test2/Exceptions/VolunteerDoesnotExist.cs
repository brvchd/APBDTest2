using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test2.Exceptions
{
    public class VolunteerDoesnotExist : Exception
    {
        public VolunteerDoesnotExist() : base("Volunteer does not exist")
        {

        }
    }
}
