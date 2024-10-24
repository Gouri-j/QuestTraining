using Assessment2.Entities;
using Assessment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2.Data
{
    internal class DataStore
    {
        public List<Patient> Patients { get; set; } = new List<Patient>();
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();

        public DataStore() 
        {
            Patients = new List<Patient>();
            Patients.Add(new Patient { Id = 1, Name = "John Doe", Age = 30, Gender = Gender.Male, MedicalCondition = "Hypertension" });
            Patients.Add(new Patient { Id = 2, Name = "Jane Smith", Age = 25, Gender = Gender.Female, MedicalCondition = "Asthma" });

            Doctors = new List<Doctor>();
            Doctors.Add(new Doctor { Id = 1, Name = "Dr. Alice", Specialization = "Cardiologist" });
            Doctors.Add(new Doctor { Id = 2, Name = "Dr. Bob", Specialization = "Neurologist" });
           
        }
    }
}
