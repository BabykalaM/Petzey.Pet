using Petzey.Pet.Domain.Entities;
using Petzey.Pet.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Pet.Data
{
    public class PetRepository : IPetRepository
    {
        private PatientDbContext db=new PatientDbContext();
        public void DeletePatient(int id)
        {
            var patientToRemove=db.Pets.Find(id);
            db.Pets.Remove(patientToRemove);
            db.SaveChanges();
        }

        public void EditPatient(Patient patientToEdit)
        {
            db.Pets.Update(patientToEdit);
            db.SaveChanges();
        }

        public List<Patient> GetAllPets()
        {
            return db.Pets.ToList();
        }

        public Patient GetPatient(int petId)
        {
            return db.Pets.Find(petId);
        }

        public PetOwner GetPetOwner(int id)
        {
            return db.PetOwners.Find(id);
        }

        public void SavePatient(Patient patientToSave)
        {
            db.Pets.Add(patientToSave);
            db.SaveChanges();
        }

        public void UpdatePetParent(PetOwner petParentToEdit)
        {
            db.PetOwners.Update(petParentToEdit);
            db.SaveChanges();
        }
    }
}
