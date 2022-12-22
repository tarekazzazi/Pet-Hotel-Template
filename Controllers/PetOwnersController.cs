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
            Console.WriteLine("Pets", _context.PetOwners.Include(petOwner => petOwner.petList));
            return _context.PetOwners;
        }

        [HttpGet("{id}")]
        public ActionResult<PetOwner> GetById(int id)
        {
            Console.WriteLine("get by id" + id);
            PetOwner petOwner = _context.PetOwners
            .Include(petOwner => petOwner.petList)
            .SingleOrDefault(petOwner => petOwner.id == id);

            return petOwner;
        }

        [HttpDelete("{id}")]
           public IActionResult DeleteOwner(int id)
        {
            PetOwner petOwners = _context.PetOwners.Find(id);
            _context.PetOwners.Remove(petOwners);
            _context.SaveChanges();

            return NoContent();
        }
        [HttpPost]
        public IActionResult Post(PetOwner petOwner)
        {
        _context.Add(petOwner);
        _context.SaveChanges();
        return CreatedAtAction(nameof(Post), new { id = petOwner.id }, petOwner);
        }

        [HttpPut("{id}")]

        public  PetOwner Put(int id, PetOwner petOwner){
            petOwner.id = id;
            _context.PetOwners.Update(petOwner);
            _context.SaveChanges();
            return petOwner;
        }
       
  
    }
}
