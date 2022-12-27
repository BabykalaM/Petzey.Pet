using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Pet.Domain.Entities
{
    public class PetOwner
    {
        public int PetOwnerId { get; set; }
        public string Name { get; set; }
        public PetOwnerGender Gender { get; set; }
        public long Mobile { get; set; }
        public string Location { get; set; }
        
        //public int PetId { get; set; }
        public List<Patient> Patients { get; set; }
    }

    public enum PetOwnerGender
    {
        Mr,
        Mrs,
        Other
    }
}
