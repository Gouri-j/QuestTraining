using Assessment2.Data;
using Assessment2.Entities;
using Assessment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assessment2
{
    internal class Program
    {
        static void AddPatient(PatientManager patientManager)
        {
            Console.Write("Enter patient ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter patient name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Gender: 1.Male 2.Female 3.Other: ");
            var genderInput = Console.ReadLine();
            var gender = genderInput == "1"? Gender.Male : genderInput == "2"? Gender.Female :Gender.Other;

            Console.Write("Enter medical condition: ");
            string medicalCondition = Console.ReadLine();

            Patient patient = new Patient {Id = id,Name = name,Age = age,Gender =gender,MedicalCondition = medicalCondition };

            patientManager.Add(patient);
        }
        static void AddDoctor(DoctorManager doctorManager)
        {
            Console.Write("Enter doctor ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter doctor name: ");
            string name = Console.ReadLine();

            Console.Write("Enter specialization: ");
            string specialization = Console.ReadLine();

            Doctor doctor = new Doctor { Id = id, Name = name, Specialization = specialization };
            doctorManager.Add(doctor);
        }
        static void ListAllPatients (PatientManager patientManager)
        {
            var patients = patientManager.ListAll();
            if (patients.Count > 0)
            {
                foreach (var patient in patients)
                {
                    Console.WriteLine($"ID: {patient.Id}, Name: {patient.Name}, Age: {patient.Age}, Gender: {patient.Gender}, Medical Condition: {patient.MedicalCondition}");
                }
            }
            else
            {
                Console.WriteLine("List is empty");
            }
        }

        static void ListAllDoctors(DoctorManager doctorManager)
        {
            var doctors = doctorManager.ListAll();
            if (doctors.Count > 0)
            {
                foreach (var doctor in doctors)
                {
                    Console.WriteLine($"ID: {doctor.Id}, Name: {doctor.Name}, Specialization: {doctor.Specialization}, Patient Assigned: {doctor.PatientId}");
                }
            }
            else
            {
                Console.WriteLine("List is empty");
            }
        }

        static void UpdatePatient(PatientManager patientManager)
        {
            Console.Write("Enter patient id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter patient name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter medical condition: ");
            string medicalCondition = Console.ReadLine();

            Patient patient = new Patient { Id = id, Name = name, Age = age, MedicalCondition = medicalCondition };

            patientManager.Update(patient);
        }

        static void UpdateDoctor(DoctorManager doctorManager)
        {
            Console.Write("Enter doctor id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter doctor name: ");
            string name = Console.ReadLine();

            Console.Write("Enter specialization: ");
            string specialization = Console.ReadLine();

            Doctor doctor = new Doctor { Id = id, Name = name, Specialization = specialization };
            doctorManager.Update(doctor);
        }

        static void DeletePatient(PatientManager patientManager)
        {
            Console.Write("Enter patient ID: ");
            int id = int.Parse(Console.ReadLine());

            patientManager.Delete(id);
        }
        static void DeleteDoctor(DoctorManager doctorManager)
        {
            Console.Write("Enter doctor ID: ");
            int id = int.Parse(Console.ReadLine());

            doctorManager.Delete(id);
        }

        static void Main(string[] args)
        {
            var dataStore = new DataStore();
            var patientManager = new PatientManager(dataStore);
            var doctorManager = new DoctorManager(dataStore);

            while (true)
            {
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Add Doctor");
                Console.WriteLine("3. Display list of Patients");
                Console.WriteLine("4. Display list of Doctors");
                Console.WriteLine("5. Update Patient");
                Console.WriteLine("6. Update Doctor");
                Console.WriteLine("7. Delete Patient");
                Console.WriteLine("8. Delete Doctor");
                Console.WriteLine("9. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddPatient(patientManager);
                        break;
                    case 2:
                        AddDoctor(doctorManager);
                        break;
                    case 3:
                        ListAllPatients(patientManager);
                        break;
                    case 4:
                        ListAllDoctors(doctorManager);
                        break;
                    case 5:
                        UpdatePatient(patientManager);
                        break;
                    case 6:
                        UpdateDoctor(doctorManager);
                        break;
                    case 7:
                        DeletePatient(patientManager);
                        break;
                    case 8:



                    case 9:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
