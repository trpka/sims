using Model;
using System.Collections.Generic;

namespace Service
{
    public class MedicineService
    {
        private Repository.MedicineRepository medicineRepository = new Repository.MedicineRepository();

        public List<Medicine> GetAll()
        {
            return medicineRepository.GetAll();
        }

        public List<Medicine> GetVerified()
        {
            return medicineRepository.GetVerified();
        }
        public List<Medicine> GetNotRejected()
        {
            return medicineRepository.GetNotRejected();
        }

        public Medicine GetById(int id)
        {
            return medicineRepository.GetById(id);
        }

        public Medicine GetByName(string name)
        {
            return medicineRepository.GetByName(name);
        }

        public void Save(string name, string description)
        {
            int id = medicineRepository.GenerateNewId();
            Medicine medicine = new Medicine(id, name, description);
            medicineRepository.Save(medicine);
        }

        public void Delete(int id)
        {
            medicineRepository.Delete(id);
        }

        public void Update(int id, string name, VerificationType verification, string description)
        {
            Medicine medicine = GetById(id);
            medicine.Name = name;
            medicine.Verification = verification;
            medicine.Description = description;
            medicineRepository.Update(medicine);
        }
    }
}