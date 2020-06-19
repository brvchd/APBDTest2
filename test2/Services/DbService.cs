using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test2.DTOs.Requests;
using test2.DTOs.Responses;
using test2.Exceptions;
using test2.Models;

namespace test2.Services
{
    public class DbService : IDbService
    {
        private readonly VolunteerDbContext _context;
        public DbService(VolunteerDbContext context)
        {
            _context = context;
        }
        public AssignPetResponse AssignPet(AssignPetRequest request, int id)
        {
            var volunteerCheck = _context.Volunteers.FirstOrDefault(p => p.IdVolunteer == id);
            var petCheck = _context.Pets.FirstOrDefault(p => p.IdPet == request.IdPet);
            if (volunteerCheck == null) throw new VolunteerDoesnotExist();
            if (petCheck == null) throw new PetDoesntExist();
            if (volunteerCheck.IdSupervisor != null) throw new VolunteerHasSupervisor();

            var pet = new Volunteer_Pet() { IdVolunteer = id, IdPet = request.IdPet, DateAccepted = request.DateAccepted };
            _context.Volunteer_Pets.Add(pet);
                
            return new AssignPetResponse() { IdVolunteer = id, IdPet = request.IdPet, DateAccepted = request.DateAccepted };
        }
        /*
        public List<Pet> GetPets(int id,int? year)
        {
            var volunteerCheck = _context.Volunteers.FirstOrDefault(p => p.IdVolunteer == id);
            if (volunteerCheck == null) throw new VolunteerDoesnotExist();
            if (year == null) { }
            return null;
        }
        */
    }
}
