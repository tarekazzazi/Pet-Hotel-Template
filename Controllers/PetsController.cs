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

            public IActionResult PostPet(Pet pet)
            {
            _context.Pets.Add(pet);
            _context.SaveChanges();
            return CreatedAtAction("Get Pets", new { id = pet.id }, pet);
            }
        // [HttpGet]
        // public IEnumerable<Pet> GetPets() {

        //     Pet newPet1 = new Pet {
        //         name = "Big Dog",
        //         petOwnerid = 2,
        //         color = PetColorType.Black,
        //         breed = PetBreedType.Poodle,
        //     };
      
        //     Pet newPet2 = new Pet {
        //         name = "Little Dog",
        //         petOwner = "tarek",
        //         color = PetColorType.Golden,
        //         breed = PetBreedType.Labrador,
        //     };

        //     return new List<Pet>{newPet1};
        // }
    }
}

       
    

