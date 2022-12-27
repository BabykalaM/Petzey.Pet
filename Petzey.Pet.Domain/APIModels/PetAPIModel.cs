using Petzey.Pet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Pet.Domain.APIModels
{
    public class PetAPIModel
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public Species Species { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Age { get; set; }
        public string BloodGroup { get; set; }
        public string Allergies { get; set; }
        
        public string PetOwnerName { get; set; }


    }
}
