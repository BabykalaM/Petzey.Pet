using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Petzey.Pet.Domain.Entities;


namespace Petzey.Pet.Domain.Repository
{
    public interface IPetRepository
    {
        List<Patient> GetAllPets();
        Patient GetPatient(int id);
        void EditPatient(Patient patient);
        void SavePatient(Patient patient);
        void DeletePatient(int id);

        //Edit PetParent
        void UpdatePetParent(PetOwner petParent);

    }
}
