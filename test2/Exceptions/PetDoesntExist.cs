using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test2.Exceptions
{
    public class PetDoesntExist : Exception
    {
        public PetDoesntExist() : base("Pet does not exist")
        {

        }
    }
}
