using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pet_hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace pet_hotel.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PetsController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public PetsController(ApplicationContext context) {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Pet> GetPets() {
              return _context.Pets.Include(PetOwner => PetOwner.petOwner);
          }
        [HttpPost]

        public IActionResult Post(Pet pet)
        {
        PetOwner owner = _context.PetOwners
        .SingleOrDefault(owner => owner.id == pet.petOwnerid);
        _context.Add(pet);
        _context.SaveChanges();
        return CreatedAtAction(nameof(Post), new { id = pet.id }, pet);
        }

        [HttpPut("{id}")]

        public Pet Put(int id, Pet pet){
            pet.id = id;
            _context.Pets.Update(pet);
            _context.SaveChanges();
            return pet;
        }

        [HttpDelete("{id}")]
        public IActionResult deletePet(int id){
            Pet pet = _context.Pets.Find(id);
            
            _context.Pets.Remove(pet);
            _context.SaveChanges();

            return NoContent();
        }

    }
}

       
    

