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
        public string name { get; set; }
        public string petOwner { get;  set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public  PetColorType color { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public  PetBreedType breed{ get; set; }
    }
}
