using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petzey.Pet.Data;
using Petzey.Pet.Domain.Entities;
using Petzey.Pet.Domain.Repository;

namespace Petzey.Pet.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        public PetController(IPetRepository repo)
        {
            this.repo= repo;
        }
        private IPetRepository repo = null;
        [HttpGet]
        [EnableQuery]
        public IActionResult GetAllPets()
        {
            return Ok(repo.GetAllPets().AsQueryable());
        }
        [HttpPost]
        //[Route("pet")]
        public IActionResult AddPet(Patient patient)
        {
            if(!ModelState.IsValid) return BadRequest("Invalid Pet data");
            repo.SavePatient(patient);
            return Created($"api/pet/{patient.PatientId}", patient);
        }
        [HttpPut]
        public IActionResult EditPet(Patient patient)
        {
            if (!ModelState.IsValid) { return BadRequest("Invalid Pet data"); }
            repo.EditPatient(patient);
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeletePet(int id)
        {
            var patient = repo.GetPatient(id);
            if(patient==null) return NotFound();
            else
            {
                repo.DeletePatient(id);
                return Ok(patient);
            }
        }

        [HttpPut]
        [Route("petowner")]
        public IActionResult EditPetParent(PetOwner petOwner)
        {
            if (!ModelState.IsValid) { return BadRequest("Invalid Pet Parent data"); }
            repo.UpdatePetParent(petOwner);
            return Ok();
        }

        //[HttpGet]
        //////[EnableQuery]
        ////Route["{id}"]
        //public IActionResult GetPetOwner(int id)
        //{
        //    return Ok(repo.GetPetOwner(id));
        //}
    }
}
