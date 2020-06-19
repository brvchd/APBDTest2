using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test2.DTOs.Requests;
using test2.DTOs.Responses;
using test2.Models;

namespace test2.Services
{
    public interface IDbService
    {
        public AssignPetResponse AssignPet(AssignPetRequest request, int id);
        public List<Pet> GetPets(int id,int? year);
    }
}
