using Assessment2.Data;
using Assessment2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    class PatientManager:IPatientOperations
    {
        private DataStore _dataStore;
        public PatientManager(DataStore dataStore)
        {
            _dataStore = dataStore;

        }
        public void Add(Patient patient)
        {
            _dataStore.Patients.Add(patient);
            Console.WriteLine("Patient added successfully.");
        }
        public List<Patient> ListAll()
        {
            return _dataStore.Patients;
        }
        public void Update(Patient patient)
        {
            var find = _dataStore.Patients.Find(p => p.Id == patient.Id);
            if (find != null)
            {
                find.Name = patient.Name;
                find.Age = patient.Age;
                find.Gender = patient.Gender;
                find.MedicalCondition = patient.MedicalCondition;
                Console.WriteLine("Patient updated successfully");
            }
            else
            {
                Console.WriteLine("Patient not found");
            }
        }
        public void Delete(int id)
        {
            var delete = _dataStore.Patients.Find(p => p.Id == id);
            if (delete != null)
            {
                _dataStore.Patients.Remove(delete);
                Console.WriteLine("Patient deleted successfully");
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }
        }
    }
}
