using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test2.DTOs.Requests;
using test2.Exceptions;
using test2.Services;

namespace test2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IDbService _dbService;
        public PetsController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpPost("{id:int}")]
        public IActionResult AssignPet(AssignPetRequest request, int id)
        {
            try 
            {
                var response = _dbService.AssignPet(request,id);
                return Created("Pet Assign", response);
            }
            catch (PetDoesntExist ex)
            {
                return NotFound(ex.Message);
            }
            catch(VolunteerDoesnotExist ex1)
            {
                return NotFound(ex1.Message);
            }
            catch (VolunteerHasSupervisor ex2)
            {
                return BadRequest(ex2.Message);
            }
        }
    }
}
