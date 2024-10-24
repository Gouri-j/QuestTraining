using Assessment2.Data;
using Assessment2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
   class DoctorManager : IDoctorOperations
    {
        private DataStore _dataStore;
        public DoctorManager(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public void Add(Doctor doctor)
        {
            _dataStore.Doctors.Add(doctor);
            Console.WriteLine("Doctor added successfully.");
        }

        public List<Doctor> ListAll()
        {
            return _dataStore.Doctors;
        }
        public void Update(Doctor doctor)
        {
            var find = _dataStore.Doctors.Find(d => d.Id == doctor.Id);
            if (find != null)
            {
                find.Name = doctor.Name;
                find.Specialization = doctor.Specialization;
                find.PatientId = doctor.PatientId;
                Console.WriteLine("Doctor updated successfully.");
            }
            else
            {
                Console.WriteLine("Doctor not found.");
            }
        }
        public void Delete(int id)
        {
            var delete = _dataStore.Doctors.Find(d => d.Id == id);
            if (delete != null)
            {
                _dataStore.Doctors.Remove(delete);
                Console.WriteLine("Doctor deleted successfully.");
            }
            else
            {
                Console.WriteLine("Doctor not found.");
            }
        }
   }
}
