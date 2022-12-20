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

        // [HttpGet("{id}")]
        // public IEnumerable<PetOwner> GetOwners(id)
        // {
        //     PetOwner tarek = new PetOwner{
            //     name = "Tarek",
            //     email = "Speedytarek02@email.com",
            //     pets = 0,
            // };
        // }
    }
}
