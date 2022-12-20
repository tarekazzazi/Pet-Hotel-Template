using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using pet_hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace pet_hotel.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PetOwnersController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public PetOwnersController(ApplicationContext context) {
            _context = context;
        }

        // This is just a stub for GET / to prevent any weird frontend errors that 
        // occur when the route is missing in this controller
        [HttpGet]
        public IEnumerable<PetOwner> GetOwners() 
        {
    
            return _context.PetOwners;
        }

        [HttpDelete("{id}")]
           public IActionResult DeleteOwner(int id)
        {
            PetOwner petOwners = _context.PetOwners.Find(id);
            if (petOwners == null)
            {
                return NotFound();
            }

            _context.PetOwners.Remove(petOwners);
            _context.SaveChanges();

            return NoContent();
        }
        [HttpPost]
        public IActionResult PostOwner(PetOwner petOwners)
        {
        _context.PetOwners.Add(petOwners);
        _context.SaveChanges();
        return CreatedAtAction("GetOwners", new { id = petOwners.id }, petOwners);
        }
        // [HttpGet("{id}")]
        // public IEnumerable<PetOwner> GetOwners(id)
        // {
        //     PetOwner tarek = new PetOwner{
        //         name = "Tarek",
        //         email = "Speedytarek02@email.com",
        //         pets = 0,
        //     };
        // }
    }
}
