using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel
{
    public enum PetBreedType {
        Poodle,
        Labrador,
    };
    
    public enum PetColorType {
         Golden,
         Black, 
    }
    public class Pet {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
   
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public  PetColorType color { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public  PetBreedType breed{ get; set; }

        [ForeignKey("petOwner")]
        public int petOwnerid { get;  set; }
        public PetOwner petOwner { get; set; }
    }
}
