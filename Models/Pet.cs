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
        public string name { get; set; }
        public PetOwner petOwner { get;  set; }
        public PetColorType color { get; set; }
        public PetBreedType breed { get; set; }
    }
}
