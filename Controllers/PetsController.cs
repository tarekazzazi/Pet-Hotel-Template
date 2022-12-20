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
    [Route("/api/pets")]
    public class PetsController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public PetsController(ApplicationContext context) {
            _context = context;
        }

        [HttpGet]

          public IEnumerable<Pet> GetPets() {
              return _context.Pets;
          }
        // public IEnumerable<Pet> GetPets() {

        //     Pet newPet1 = new Pet {
        //         name = "Big Dog",
        //         petOwner = "tarek",
        //         color = PetColorType.Black,
        //         breed = PetBreedType.Poodle,
        //     };
      
        //     Pet newPet2 = new Pet {
        //         name = "Little Dog",
        //         petOwner = "tarek",
        //         color = PetColorType.Golden,
        //         breed = PetBreedType.Labrador,
        //     };

        //     return new List<Pet>{newPet1,newPet2};
        // }
    }
}

       
    

